using System;

namespace hw2mvc.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string wow {get; set;}
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}