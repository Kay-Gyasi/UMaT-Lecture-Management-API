using OfficeOpenXml;

namespace LMSAPI.Initialization;

[Processor]
public class Initializer
{
    private readonly ExcelReader _reader;
    private readonly RoomProcessor _roomProcessor;
    private ExcelWorksheet _firstSemesterWorksheet;
    private const string SecondSemFile = "_content/DRAFT TIME TABLE SEM ONE 2022_2023.xlsx";

    public Initializer(ExcelReader reader, RoomProcessor roomProcessor)
    {
        _reader = reader;
        _roomProcessor = roomProcessor;
    }
    
    public async Task Initialize()
    {
        InitializeSemesters();
        InitializeDepartments();
        InitializeLecturers();
        InitializeCourses();
        await InitializeRooms();
    }

    private void InitializeSemesters()
    {
        //
    }
    
    private void InitializeDepartments()
    {
        //
    }
    
    private void InitializeLecturers()
    {
        //
    }
    
    private void InitializeCourses()
    {
        //
    }

    private async Task InitializeRooms()
    {
        var currentWorksheet = 0;

        while (currentWorksheet < _reader.NoOfWorkSheets(SecondSemFile) - 2)
        {
            _firstSemesterWorksheet = _reader.GetWorkSheet(SecondSemFile, currentWorksheet);
            
            // start reading from row 8
            for (var row = 8; row < _firstSemesterWorksheet.Dimension.End.Row; row++)
            {
                var cell = _firstSemesterWorksheet.Cells[row, 1].Value;
                if (cell is null) continue;
                var cellValue = cell.ToString()?.Trim();
                if (string.IsNullOrEmpty(cellValue)) continue;
                
                int? capacity = null;
                string[]? split = null;
                if (cellValue.Contains('('))
                {
                    split = cellValue.Split('(');
                    var isParsed = int.TryParse(split[1][..^1], out var i);
                    if (isParsed) capacity = i;
                    else continue;
                }

                var name = split is not null ? split[0].Trim() : cellValue;
                if (await _roomProcessor.Exists(name)) continue;

                var isLab = split is not null ? split[0].Contains("LAB") || split[0].Contains("MEDIA ROOM") 
                    : cellValue.Contains("LAB") || cellValue.Contains("MEDIA ROOM");
                var isWorkshop = split is not null ? split[0].Contains("WORKSHOP") 
                    : cellValue.Contains("WORKSHOP");
                
                var command = new RoomCommand(0, name, capacity, isLab, isWorkshop);

                _ = await _roomProcessor.UpsertAsync(command);
            }

            currentWorksheet += 1;
        }
    }
}