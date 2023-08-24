using pdf6b2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pdf6b2.IRepositories
{
    interface ISubjectRepository
    {
        List<Mark> GetMark();
        Mark FindById();
        Boolean InsertMark(Mark m);
        Boolean UpdateMark(Mark m, int id);
    }
}
