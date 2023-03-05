using LMSAPI.Helpers;
using OfficeOpenXml;

namespace LMSAPI.Initialization;

[Processor]
public class Initializer
{
    private readonly ExcelReader _reader;
    private ExcelWorksheet _firstSemesterWorksheet;
    private const string SecondSemFile = "content/DRAFT TIME TABLE SEM ONE 2022_2023.xlsx";

    public Initializer(ExcelReader reader)
    {
        _reader = reader;
    }
    
    public async Task Initialize()
    {
        InitializeRooms();
    }

    private void InitializeRooms()
    {
        var rooms = new List<string?>();
        var currentWorksheet = 0;

        while (currentWorksheet < _reader.NoOfWorkSheets(SecondSemFile) - 2)
        {
            _firstSemesterWorksheet = _reader.GetWorkSheet(SecondSemFile, currentWorksheet);
            
            // start reading from row 8
            for (int row = 8; row <= _firstSemesterWorksheet.Dimension.End.Row; row++)
            {
                var cellValue = _firstSemesterWorksheet.Cells[row, 1].Value.ToString()?.Trim();
                if (!string.IsNullOrEmpty(cellValue)) rooms.Add(cellValue);
            }

            currentWorksheet += 1;
        }
    }
}