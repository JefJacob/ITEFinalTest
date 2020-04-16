using System;
using System.Collections.Generic;
using System.Text;
using ITEFinalTest.Entities;
using ITEFinalTest.Repo;

namespace ITEFinalTest.Logic
{
    public class CoachLogic
    {
        private CoachRepo _repo;
        public CoachLogic()
        {
            _repo = new CoachRepo();
        }
        public void Create(CoachEntity coach)
        {

            _repo.Create(coach);
        }
        public CoachEntity Read(int Id)
        {

            return _repo.Read(Id);
        }
        public void Update(CoachEntity coach)
        {

            _repo.Update(coach);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

             
    }

}
