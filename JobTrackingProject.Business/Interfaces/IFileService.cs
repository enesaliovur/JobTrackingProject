using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.Business.Interfaces
{
    public interface IFileService
    {
        string CreatePdf<T>(List<T> list) where T : class, new();
        byte[] CreateExcel<T>(List<T> list) where T : class, new();
    }
}
 