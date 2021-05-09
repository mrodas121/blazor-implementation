using DataAccess.Interfaces;
using Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccess
{
    public class FileManagerContext: IFileManagerContext
    {
        private readonly IConfiguration Configuration;
        public FileManagerContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void UploadFile(string base64, string fileName)
        {
            string filePath =  Directory.GetCurrentDirectory() +  Configuration.GetSection("FileSetting:DriverPath").Value + fileName;
            File.WriteAllBytes(filePath, Convert.FromBase64String(base64));
        }
    }
}
