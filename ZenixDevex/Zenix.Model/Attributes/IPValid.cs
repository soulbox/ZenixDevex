using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Model.Attributes
{
  public  class IPValid: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            IPAddress IP;
            return IPAddress.TryParse(value.ToString(), out IP); 
        }
    }
}
