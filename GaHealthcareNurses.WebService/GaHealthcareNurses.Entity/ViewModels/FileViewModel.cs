using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Healthcare.Entity.ViewModels
{

    public class UploadFileViewModel
    {
        public string UserId { get; set; }
        public IFormFile ProfileImage { get; set; }
        public IFormFile ResumeFile { get; set; }
    }
}

