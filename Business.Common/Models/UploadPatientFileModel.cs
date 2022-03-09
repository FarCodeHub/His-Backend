using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Common.Models
{
  public  class UploadPatientFileModel
    {
      public IFormFile file { get; set; }
      public  int patientId { get; set; }
      public int personId { get; set; }
    }
}
