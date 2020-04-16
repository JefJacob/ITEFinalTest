using System;
using System.Collections.Generic;
using System.Text;
using ITEFinalTest.Entities;
using ITEFinalTest.Repo;

namespace ITEFinalTest.Logic
{
    public class AthleteLogic
    {
        private AthleteRepo _repo;
        public AthleteLogic()
        {
            _repo = new AthleteRepo();
        }
        public void Create(AthleteEntity athlete)
        {
            
            _repo.Create(athlete);
        }
        public AthleteEntity Read(int Id)
        {

            return _repo.Read(Id);
        }

        public void Update(AthleteEntity athlete)
        {

            _repo.Update(athlete);
        }
        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }
         

       
    }
}
