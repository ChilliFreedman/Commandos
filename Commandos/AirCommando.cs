﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, string codename) : base(name,codename)
        {

        }
        public void parachuting()
        {
            Console.WriteLine("Parachuting champion");
        }

        public override  void Attack()
        {
            Console.WriteLine($"An aircommando named {this.CodeName} is attacking now.");
        }
    }
}
