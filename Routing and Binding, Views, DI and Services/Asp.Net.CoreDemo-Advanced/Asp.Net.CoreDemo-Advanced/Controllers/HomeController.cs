using Asp.Net.CoreDemo_Advanced.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;

namespace Asp.Net.CoreDemo_Advanced.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult UploadFiles()=>View();
        [HttpPost]
        public async Task<IActionResult> UploadFiles(List<IFormFile>files)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Files");
            foreach (var file in files.Where(f=> f.Length>0 ))
            {

                string fileName = Path.Combine(path, file.FileName);
                using (var fileStream=new FileStream(fileName,FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);

                }
            }
            return Ok(new { savedLenght =files.Sum(f=>f.Length)});


        }
        public IActionResult DownloadFile(string fileName)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Files");
            IFileProvider fileProvider=new PhysicalFileProvider(path);
            IFileInfo fieldInfo=fileProvider.GetFileInfo(fileName);
            var stream=fieldInfo.CreateReadStream();
            var mimeType = "application/octet-strem";
            return File(stream, mimeType, fileName);


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}