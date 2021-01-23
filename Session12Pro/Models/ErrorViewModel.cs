using System;

namespace Session12Pro.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string Description { get; set; }
    }
}