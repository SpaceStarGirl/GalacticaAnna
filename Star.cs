using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticaAnna
{
    
     class Star : SpaceObjects
    {
        public string Type {  get; set; }
        public int Temperature { get; set; }

        public List<Planet> planetList = new List<Planet>();

        public new Position position { get; }
        public Star()
       
        { this.position = new Position(0, 0);
        
        }
        

    }
}
