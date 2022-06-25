using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateGun.Infrastructure
{
    internal class Gun

    {
        public int Id { get;set; }                  //PK
        public string Model { get;set; }
        public string Version { get; set; }
        public string Type { get;set; } 
        public string Manufacturer { get;set; }     //FK
        public string[] Factories { get; set; }
        public int ProductionBegin { get; set; }
        public int ProductionFinish { get; set; }
        public int[] MagazineCapacity { get; set; }
        public string[] BCallibers { get; set; }    
        public string DescrGeneral { get; set; }
        public string DescrTech { get; set; }


//(PK) Id broni(int)
//Typ(nvarchar)
//(FK) Producent(int)
//Model(nvarchar)
//~podmodel/wersja(nvarchar)
//Lata produkcji start(int)
//Lata produkcji koniec(int)
//Pojemność magazynków(int)           //*kilka?
//Kalibry(nvarchar)
//Opis ogólny(nvarchar)
//Opis techniczny(nvarchar)
//Ciekawostki(nvarchar)
//Historia(nvarchar)
//Bibliografia(nvarchar)
//(FK) UserID //autor wpisu                (nvarchar)
//Zdjecie1(nvarchar)  //duzo
    }
}
