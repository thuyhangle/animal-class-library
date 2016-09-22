using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDLL
{
    public class Shark : Animal, IAnimal
    {
        public float Length { get; set; }
        private string species;
        public void SetSpecies()
        {
            species = "Fish";
        }
        public string GetSpecies()
        {
            return species;
        }
    }
}
