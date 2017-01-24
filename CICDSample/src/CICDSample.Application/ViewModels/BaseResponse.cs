using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CICDSample.Application.ViewModels
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public IEnumerable<string> Messages { get; set; }
    }
}
