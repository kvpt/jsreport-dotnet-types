﻿namespace jsreport.Types
{
    public class RenderOptions
    {        
        public int? Timeout { get; set; }

        public bool? Preview { get; set; }

        public string Base { get; set; }

        public DebugOptions Debug { get; set; }

        public ReportsOptions Reports { get; set; }
    }
}