﻿using LibAbstraite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourmilliereALIHM
{
    public class AproposViewModel : ViewModelBase
    {
        public string CopyRight { get { return "UQAC 2017"; } }
        public string Date { get { return System.DateTime.Now.ToString(); } }
        public string Author { get { return "Pierre Lochouarn et Corentin Trehiou"; } }
    }
}
