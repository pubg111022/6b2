using pdf6b2.Interfaces;
using pdf6b2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pdf6b2.Services
{
    public class SubjectService : ISubject
    {
        private readonly StudentDbContext _context;

        public SubjectService(StudentDbContext context)
        {
            _context = context;
        }
        public bool DeleteSubject(int id)
        {
            throw new NotImplementedException();
        }

        public Subject FindById()
        {
            throw new NotImplementedException();
        }

        public List<Subject> GetSubject()
        {
            return _context.Subjects.ToList();
        }

        public bool InsertSubject(Subject s)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSubject(Subject s, int id)
        {
            throw new NotImplementedException();
        }
    }
}
