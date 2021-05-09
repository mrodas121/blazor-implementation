using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FileEntity
    {
        public string Base64 { get; set; }
        public async Task LoadBase64(Stream data)
        {
            byte[] bytes;
            using (var memoryStream = new MemoryStream())
            {
                await data.CopyToAsync(memoryStream);
                bytes = memoryStream.ToArray();
            }
            //InputFileChangeEventArgs e = new InputFileChangeEventArgs();
            Base64 = Convert.ToBase64String(bytes);
        }
    }
}
