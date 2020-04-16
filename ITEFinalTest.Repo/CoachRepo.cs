using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITEFinalTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace ITEFinalTest.Repo
{
    public class CoachRepo
    {
        private AthleticsContext _context;

        public CoachRepo()
        {
            _context = new AthleticsContext();
        }

        public void Create(CoachEntity coach)
        {
            _context.Entry<CoachEntity>(coach).State = EntityState.Added;
            _context.SaveChanges();
        }

        public CoachEntity Read(int id)
        {
            IQueryable<CoachEntity> dbQuery = _context.Set<CoachEntity>();
            return dbQuery.FirstOrDefault(i => i.Id == id);
        }

        public void Update(CoachEntity coach)
        {
            CoachEntity exCoach = _context.Set<CoachEntity>().FirstOrDefault(entry => entry.Id == coach.Id);
            if (exCoach != null)
            {
                _context.Entry(exCoach).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            _context.Entry(coach).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            CoachEntity coach = Read(id);
            _context.Entry(coach).State = EntityState.Deleted;
            _context.SaveChanges();
        }

    }

}
