﻿using System;
using System.Collections.Generic;
using System.Text;

namespace reCAPTCHA.AspNetCore.Models
{
    public class v2Model
    {
        public Guid Uid { get; set; }
        public string Method { get; set; }
        public string Theme { get; set; }
        public RecaptchaSettings Settings { get; set; }
    }
}
