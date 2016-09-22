using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDLL
{
    public class Cat : Animal, IAnimal
    {
        public string Owner { get; set; }
        private string species;

        public void SetSpecies()
        {
            species = "Mammal";
        }
        public string GetSpecies()
        {
            return species;
        }
    }
}
