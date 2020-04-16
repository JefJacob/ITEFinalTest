using System;
using System.Collections.Generic;
using System.Text;

namespace ITEFinalTest.Entities
{
    public class AthleteEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public CoachEntity Coach { get; set; } 
    }
}
