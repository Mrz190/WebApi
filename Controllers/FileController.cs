using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace WebApiCourse6_7.Controllers
{
    [Route("api/file")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;

        public FileController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider ?? throw new System.ArgumentException(nameof(fileExtensionContentTypeProvider));
        }

        [HttpGet("{fileID}")]
        public ActionResult GetFile(int fileID)
        {
            var pathFile = "bmw.jpg";

            if (!System.IO.File.Exists(pathFile))
            {
                return NotFound("File not found");
            }
            
            if(!_fileExtensionContentTypeProvider.TryGetContentType(pathFile, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            var bytes = System.IO.File.ReadAllBytes(pathFile);

            return File(bytes, contentType, Path.GetFileName(pathFile));
        }
    }
}
