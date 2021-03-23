using iTextSharp.text;
using iTextSharp.text.pdf;
using JobTrackingProject.Business.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JobTrackingProject.Business.Concrete
{
    public class FileManager : IFileService
    {
        public byte[] CreateExcel<T>(List<T> list) where T : class, new()
        {
            var excelPackage = new ExcelPackage();
           var excelBlank = excelPackage.Workbook.Worksheets.Add("Work 1");
            excelBlank.Cells["A1"].LoadFromCollection(list, true, OfficeOpenXml.Table.TableStyles.Light15);
            return excelPackage.GetAsByteArray();
        }

        public string CreatePdf<T>(List<T> list) where T : class, new()
        {
            var fileName = Guid.NewGuid() + ".pdf";
            var returnPath = "/documents/" + fileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/documents/" + fileName);
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4, 25f, 25f, 25f, 25f);
            PdfWriter.GetInstance(document, stream);
               
            return returnPath;
        }
    }
}
