using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework5
{
    public class DatedeNastere
    {
        public static void seteazaDataNastere()
        {
            DateTime time = DateTime.UtcNow; 
          
            var ziuaActual =  DateTime.Now;
            Console.WriteLine("Data de astazi este: " + ziuaActual );
            
            Console.WriteLine("Introduceti luna/ziua/anul nasterii");
            DateTime utilizatorBH = DateTime.Parse(Console.ReadLine());
            
            TimeSpan virsta = ziuaActual - utilizatorBH;
            int an = virsta.Days / 365;

            Console.WriteLine("Virsta utilizatorului este:"+ an);

        }
        
    }
}
