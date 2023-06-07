﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NasaApodExample.Models
{
    public class ApodModel
    {
        public string CopyRight { get; set; }
        public DateTime Date { get; set; }
        public string Explanation { get; set; }
        public string Hdurl { get; set; }
        public string MediaType { get; set; }
        public string ServiceVersion { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
