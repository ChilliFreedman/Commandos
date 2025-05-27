using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Weapon
    {
        public string Name;
        public string Manufacturer;
        public int BuletsLeft;

        public Weapon(string name, string manufacturer, int buletsLeft)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.BuletsLeft = buletsLeft;
        }

        public void Shoot()
        {
            Console.WriteLine("shoot");
            this.BuletsLeft--;
            
            
        }
    }
}
