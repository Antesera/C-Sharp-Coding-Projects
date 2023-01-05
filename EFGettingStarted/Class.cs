using RazorEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFGettingStarted
{
    public class Class
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public int MaxClassSize { get; set; }

        public Language ClassLanguage { get; set; }
    }
}
