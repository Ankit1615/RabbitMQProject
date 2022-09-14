#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models
{
    public class uploadfile
    {
        [NotMapped]
        public IFormFile file { get; set; }
        [NotMapped]
        public string filename { get; set; }

    }
}
