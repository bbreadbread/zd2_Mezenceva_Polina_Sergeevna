﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_Mezenceva_Polina_Sergeevna
{
    class Contact
    { 
        public string Name { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{Name} ; {Phone}";
        }
    }
}
