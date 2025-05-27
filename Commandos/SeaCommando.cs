using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, string codename) : base(name, codename)
        {

        }

        public void swimming()
        {
            Console.WriteLine("swimming champion");
        }

        public override void Attack()
        {
            Console.WriteLine($"A seacommando named {this.CodeName} is attacking now.");
        }
    }
}
