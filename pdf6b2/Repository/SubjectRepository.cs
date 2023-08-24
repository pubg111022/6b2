using pdf6b2.IRepositories;
using pdf6b2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pdf6b2.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        //xử lý liên quan đến db 
        public Mark FindById()
        {
            throw new NotImplementedException();
        }

        public List<Mark> GetMark()
        {
            throw new NotImplementedException();
        }

        public bool InsertMark(Mark m)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMark(Mark m, int id)
        {
            throw new NotImplementedException();
        }
    }
}
