using Business.CenterManagment.IServices;
using Business.Common.IServices;
using Business.Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;


namespace PortalHisApi.Controllers
{
 
    [Route("api/[controller]/[action]")]
    [ApiController]
 
    public class FileController : Controller
    {

        private readonly IPatientService patientService;
        private readonly IAccountService accountService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileController(IWebHostEnvironment webHostEnvironment, IPatientService patientService, IAccountService accountService)
        {
            _webHostEnvironment = webHostEnvironment;
            this.patientService = patientService;
            this.accountService = accountService;
        }

      [HttpPost]
        public async Task<JsonResult> UploadFileAsync([FromForm]  UploadPatientFileModel uploadPatientFileModel )
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            string path = "";
            path = Path.Combine(webRootPath, "Images", "UploadedFile");

            var guid = Guid.NewGuid().ToString();
            string fileName = guid + Path.GetExtension(uploadPatientFileModel.file.FileName);
            var fileFullPath = Path.Combine(path, fileName);
            using var output = System.IO.File.Create(fileFullPath);
            await uploadPatientFileModel.file.CopyToAsync(output);
            int Id = uploadPatientFileModel.patientId;
            var result = await patientService.SavePatientFile(fileName, Id);

            return Json(result);

        }



        [HttpPost]
        public async Task<JsonResult> UploadAvatarAsync([FromForm] UploadPatientFileModel avatar)
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            string path = "";
            path = Path.Combine(webRootPath, "Images", "Avatars");

            var guid = Guid.NewGuid().ToString();
            string fileName = guid + Path.GetExtension(avatar.file.FileName);
            var fileFullPath = Path.Combine(path, fileName);
            using var output = System.IO.File.Create(fileFullPath);
            await avatar.file.CopyToAsync(output);
            int personId = avatar.personId;
            var result = await accountService.ChangeAvatar(fileName, personId);

            return Json(result);

        }





    }
}
