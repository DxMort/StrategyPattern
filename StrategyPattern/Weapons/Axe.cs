﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Weapons
{
    public class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Вы атакуете топором!");
        }
    }
}