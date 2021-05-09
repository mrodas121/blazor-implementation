using Business.Interfaces;
using DataAccess;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class B_File:IB_File
    {
        private readonly IFileManagerContext _fileManagerContext;
        public B_File(IFileManagerContext fileManagerContext)
        {
            _fileManagerContext = fileManagerContext;
        }
        public void UploadImageDriver(string base64, string name)
        {
            _fileManagerContext.UploadFile(base64, name);
        }
    }
}
