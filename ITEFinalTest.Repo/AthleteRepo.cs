using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITEFinalTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace ITEFinalTest.Repo
{
    public class AthleteRepo
    {
        private AthleticsContext _context;

        public AthleteRepo()
        {
            _context = new AthleticsContext();
        }

        public void Create(AthleteEntity athlete)
        {
            _context.Entry<AthleteEntity>(athlete).State = EntityState.Added;
            _context.SaveChanges();
        }

        public AthleteEntity Read(int id)
        {
            IQueryable<AthleteEntity> dbQuery = _context.Set<AthleteEntity>();
            return dbQuery.FirstOrDefault(i => i.Id == id);
        }

        public void Update(AthleteEntity athlete)
        {
            AthleteEntity exAthlete = _context.Set<AthleteEntity>().FirstOrDefault(entry => entry.Id == athlete.Id);
            if (exAthlete != null)
            {
                _context.Entry(exAthlete).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            _context.Entry(athlete).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            AthleteEntity athlete = Read(id);
            _context.Entry(athlete).State = EntityState.Deleted;
            _context.SaveChanges();
        }

    }
}

