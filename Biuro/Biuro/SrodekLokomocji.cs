﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;

        public SrodekLokomocji()
        {

        }

        public virtual void ObliczCene()
        {
            cenaBiletu = iloscMiejsc * 5.23;
        }

        public double PodajCene()
        {
            return cenaBiletu;
        }
    }
}
