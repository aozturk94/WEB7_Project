using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadImageProject.Models
{
    public class UploadedImage
    {
        public string ImageFullName { get; set; }
        public string ImageName { get; set; }
        public long ImageSize { get; set; }
    }
}
