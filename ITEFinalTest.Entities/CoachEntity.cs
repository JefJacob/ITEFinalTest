using System;
using System.Collections.Generic;
using System.Text;

namespace ITEFinalTest.Entities
{
    public class CoachEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<AthleteEntity> Athletes { get; set; }
    }
}
