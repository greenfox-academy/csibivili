﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garden_app
{
    public class Flower : Plant
    {
        public Flower (int color, double waterAmount)
        {
            base.color = COLORS[color];
            base.waterAmount = waterAmount;
            base.waterAbsorb = 0.75;
        }
    }
}
