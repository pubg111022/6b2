using pdf6b2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pdf6b2.Interfaces
{
   public interface ISubject
    {
        List<Subject> GetSubject();
        Subject FindById();
        Boolean InsertSubject(Subject s);
        Boolean UpdateSubject(Subject s, int id);
        Boolean DeleteSubject(int id);
    }
}
