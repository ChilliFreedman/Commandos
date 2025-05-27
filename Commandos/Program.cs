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
            Commando comando1 = new Commando("jon","agent a");
            Console.WriteLine(comando1.SayName("GENERAL"));
            Console.WriteLine(comando1.SayName("COLONEL"));
            Console.WriteLine(comando1.SayName("aaa"));
            Console.WriteLine(comando1.CodeName);
            comando1.CodeName = "agent u";
            Console.WriteLine(comando1.CodeName);
            Console.WriteLine(comando1.Status);
            foreach(string tool in comando1.Tools)
            {
                Console.WriteLine(tool);
            }
            
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

            AirCommando aircommando1 = new AirCommando("dan", "agent b");
            Console.WriteLine(aircommando1.Status);
            Console.WriteLine(aircommando1.SayName("GENERAL"));
            aircommando1.parachuting();
            //aircommando1.Attack();

            SeaCommando seaCommando1 = new SeaCommando("moshe", "agent c");
            Console.WriteLine(seaCommando1.Status);
            Console.WriteLine(seaCommando1.SayName("GENERAL"));
            //seaCommando1.Attack();
            seaCommando1.swimming();

            Commando[] commandos = new Commando[] { comando1, aircommando1, seaCommando1, };
            foreach (Commando commando in commandos)
            {
                commando.Attack();
            }
        }
    }
}
