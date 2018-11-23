using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApPets.Common
{
    public class PetType : Base<int>
    {
        public virtual ICollection<Pet> Pets { get; set; }
    }
}
