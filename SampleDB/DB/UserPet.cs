using System;
using System.Collections.Generic;

#nullable disable

namespace SampleDB.DB
{
    public partial class UserPet
    {
        public int Id { get; set; }
        public string PetName { get; set; }
        public int UserId { get; set; }
    }
}
