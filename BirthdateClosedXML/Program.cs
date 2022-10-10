using ClosedXML.Excel;
using System.Reflection;

using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"BirthdateClosedXML.Persons.xlsx"))
using (var workbook = new XLWorkbook(stream)) // --> throws FormatException
{
    var worksheet = workbook.Worksheets.Worksheet("Aktionäre");
    Console.WriteLine($"Firstname: {worksheet.Cell("A2").GetValue<string>()}");
    Console.WriteLine($"Lastname: {worksheet.Cell("B2").GetValue<string>()}");
    Console.WriteLine($"Birthdate: {worksheet.Cell("C2").GetValue<DateTime?>()}");
}
