using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Student
    {
        enum ProgramDeStudiu
        {
            FI,
            MI,
            IM,
            M,
            I,
            F
        }
        enum AnulDeStudii
        {
            I,
            II,
            III,
            IV
        }
        struct Persoana
        {   
            public string nume;
            public string virsta;
            public ProgramDeStudiu programdestudii;
            public AnulDeStudii anuldestudiu;

            public void AfisareDatePersoana() 
            {
                Console.WriteLine(nume + " " + virsta + " " + programdestudii + " " + anuldestudiu);
                
            } 
        }
        public static void Informatii () 
        {
            var student1 = new Persoana
            {
                nume = "Gutu Ionela",
                virsta = "22",
                programdestudii = ProgramDeStudiu.FI,
                anuldestudiu = AnulDeStudii.IV
            };  
            student1.AfisareDatePersoana();

            var student2 = new Persoana
            {
                nume = "Esanu Daniel",
                virsta = "23",
                programdestudii = ProgramDeStudiu.FI,
                anuldestudiu = AnulDeStudii.IV
            };
            student2.AfisareDatePersoana();

            var student3 = new Persoana
            {
                nume = "Pintea Cristin",
                virsta = "27",
                programdestudii = ProgramDeStudiu.FI,
                anuldestudiu = AnulDeStudii.IV
            };
            student3.AfisareDatePersoana();

            var student4 = new Persoana
            {
                nume = "Martiniuc Ion",
                virsta = "25",
                programdestudii = ProgramDeStudiu.FI,
                anuldestudiu = AnulDeStudii.IV
            };
            student4.AfisareDatePersoana();

            var student5 = new Persoana
            {
                nume = "Reoneac Vitalie",
                virsta = "45",
                programdestudii = ProgramDeStudiu.FI,
                anuldestudiu = AnulDeStudii.IV
            };
            student5.AfisareDatePersoana();
        }
    }
}
