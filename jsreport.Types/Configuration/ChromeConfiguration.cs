﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class ChromeConfiguration
    {
        [DataMember(Name = "chrome_timeout")]
        public int? Timeout { get; set; }     
    }
}