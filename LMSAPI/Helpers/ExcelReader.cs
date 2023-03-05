using OfficeOpenXml;

namespace LMSAPI.Helpers;

public class ExcelReader : IDisposable
{
    private ExcelPackage _package = new();

    public ExcelWorksheet GetWorkSheet(string filePath, string worksheet)
    {
        _package = _package.SetFilePath(filePath);
        return _package.Workbook.Worksheets[worksheet];
    }
    
    public ExcelWorksheet GetWorkSheet(string filePath, int index)
    {
        _package = _package.SetFilePath(filePath);
        return _package.Workbook.Worksheets[index];
    }

    public object GetCellValue(ExcelWorksheet worksheet, int row, int col)
    {
        return worksheet.Cells[row, col].Value;
    }

    public int NoOfWorkSheets(string filePath)
    {
        _package = _package.SetFilePath(filePath);
        return _package.Workbook.Worksheets.Count;
    }

    public void Dispose()
    {
        _package.Dispose();
    }
}

public static class ExcelReaderExtensions
{
    public static ExcelPackage SetFilePath(this ExcelPackage package, string filePath)
    {
        return new ExcelPackage(new FileInfo(filePath));   
    }
}