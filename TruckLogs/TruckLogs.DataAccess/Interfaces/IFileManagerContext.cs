using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface IFileManagerContext
    {
        public void UploadFile(string base64, string filePath);
    }
}
