﻿using Microsoft.AspNetCore.Http;
using Mvc_AWS_Dynamo_Usuarios.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_AWS_Dynamo_Usuarios.Helpers
{
    public class UploadHelper
    {
        PathProvider pathprovider;

        public UploadHelper(PathProvider pathprovider)
        {
            this.pathprovider = pathprovider;
        }

        public async Task<String> UploadFileAsync(IFormFile formFile, Folders folder)
        {
            String fileName = formFile.FileName;
            String path = this.pathprovider.MapPath(fileName, Folders.Images);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await formFile.CopyToAsync(stream);
            };

            return path;
        }
    }
}