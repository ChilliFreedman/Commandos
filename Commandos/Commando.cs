using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        public string Name;
        public string CodeName;
        public string[] Tools;
        public string Status;


        public Commando(string name, string codename)
        {
            this.Name = name;
            this.CodeName = codename;
            this.Status = "standing";
            this.Tools = new string[] { "Hammer", "chisel", "rope", "bag", "water bottle" };
        }

        public void Walk()
        {
            Console.WriteLine("the solder is walking");
            this.Status = "walking";
        }

        public void Hide()
        {
            Console.WriteLine("the solder is hiding");
            this.Status = "hiding";

        }
        public void Attack()
        {
            Console.WriteLine($"A commando named {this.CodeName} is attacking now.");
        }
        
    }
}
