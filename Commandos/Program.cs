using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //בדיקת שדות מתודות של מחלקת קומנדו
            Commando comando1 = new Commando("jon","erez");
            Console.WriteLine(comando1.Name);
            Console.WriteLine(comando1.CodeName);
            Console.WriteLine(comando1.Status);
            comando1.Walk();
            Console.WriteLine(comando1.Status);
            comando1.Hide();
            Console.WriteLine(comando1.Status);
            comando1.Attack();
            //בדיקת שדות ומתודות של מחלקת נשק
            Weapon weapon1 = new Weapon("gun", "Israel Weapon Industries",50);
            Console.WriteLine(weapon1.Name);
            Console.WriteLine(weapon1.Manufacturer);
            Console.WriteLine(weapon1.BuletsLeft);
            weapon1.Shoot();
            
        }
    }
}
