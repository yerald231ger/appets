﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApPets.Data;

namespace ApPets.Common
{
    public class Pet : Base<int>
    {
        public string Race { get; set; }
        public int Wight { get; set; }
        public DateTime Birthdate { get; set; }
        public string ImageProfileId { get; set; }

        public string UserId { get; set; }
        public ApPetsUser User { get; set; }

        public int PetTypeId { get; set; }
        public PetType PetType { get; set; }
    }
    
}
