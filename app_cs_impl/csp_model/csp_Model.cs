﻿using System;
using System.Collections.Generic;

namespace csp_model
{
    public sealed class CspOptions
    {
        public List<string> Defaults { get; set; } = new List<string>();
        public List<string> Scripts { get; set; } = new List<string>();
        public List<string> Styles { get; set; } = new List<string>();
        public List<string> Images { get; set; } = new List<string>();
        public List<string> Fonts { get; set; } = new List<string>();
        public List<string> Media { get; set; } = new List<string>();
    }
}
