using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Mvc_AWS_Dynamo_Usuarios.Helpers;
using Mvc_AWS_Dynamo_Usuarios.Models;
using Mvc_AWS_Dynamo_Usuarios.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_AWS_Dynamo_Usuarios.Controllers
{
    public class UsuariosController : Controller
    {
        ServiceAWSDynamoDb ServiceDynamo;
        private UploadHelper uploadhelper;
        public ServiceAWSS3 ServiceS3;
        private String bucketName;

        public UsuariosController(ServiceAWSDynamoDb service, UploadHelper uploadhelper, ServiceAWSS3 services3, IConfiguration configuration)
        {
            this.ServiceDynamo = service;
            this.uploadhelper = uploadhelper;
            this.ServiceS3 = services3;
            this.bucketName = configuration["AWSS3:BucketName"];
        }

        public async Task<IActionResult> Index()
        {
            return View(await this.ServiceDynamo.GetUsuarios());
        }

        public async Task<IActionResult> BuscarUsuarios()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BuscarUsuarios(string coso)
        {
            return View(await this.ServiceDynamo.BuscarUsuarios(coso));
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await this.ServiceDynamo.FindUser(id));
        }

        public async Task<IActionResult> Delete(int id)
        {
            await this.ServiceDynamo.DeleteUser(id);
            return RedirectToAction("Index");
        }


        public IActionResult UploadFileAWS()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuario user, String titulo, IFormFile file)
        {
            //PRIMERO A LOCAL CON EL HELPER
            String path = await this.uploadhelper.UploadFileAsync(file, Folders.Images);
            //SUBIMOS EL FICHERO LOCAL A AWS
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                bool respuesta = await this.ServiceS3.UploadFileAsync(stream, file.FileName);
                ViewData["MENSAJE"] = "Archivo en AWS Bucket: " + respuesta;
            };


            if (titulo != null)
            {
                user.Imagen = new List<Imagen>();
                Imagen img = new Imagen();
                img.titulo = titulo;
                img.imagen = "https://" + bucketName + ".s3.us-east-2.amazonaws.com/" + file.FileName;
                user.Imagen.Add(img);
            }

            await this.ServiceDynamo.CreateUsuario(user);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await this.ServiceDynamo.FindUser(id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Usuario user, String titulo, IFormFile file)
        {
            //PRIMERO A LOCAL CON EL HELPER
            String path = await this.uploadhelper.UploadFileAsync(file, Folders.Images);
            //SUBIMOS EL FICHERO LOCAL A AWS
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                bool respuesta = await this.ServiceS3.UploadFileAsync(stream, file.FileName);
                ViewData["MENSAJE"] = "Archivo en AWS Bucket: " + respuesta;
            };


            if (titulo != null)
            {
                List<Imagen> imgList;
                if (user.Imagen == null)
                {
                    imgList = new List<Imagen>();
                } else
                {
                    imgList = user.Imagen;
                }
                 
                Imagen img = new Imagen();
                img.titulo = titulo;
                img.imagen = "https://" + bucketName + ".s3.us-east-2.amazonaws.com/" + file.FileName;
                imgList.Add(img);
                user.Imagen = imgList;

            } 

            await this.ServiceDynamo.UpdateUsuario(user);

            return RedirectToAction("Index");
        }

    }
}
