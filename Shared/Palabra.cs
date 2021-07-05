﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PalabrasApp.Shared
{
    public class Palabra
    {
        public string SpanishWord { get; set; }
        public string EnglishWord { get; set; }
        public string id { get; set; }

        public string Words { get; set; } = "Palabra";
    }
}
