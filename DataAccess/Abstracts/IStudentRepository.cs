using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.GeneralEnums;

namespace DataAccess.Abstracts
{
    public interface IStudentRepository
    {
        IEnumerable<Student> Get();
        InsertResult insert(Student entity);
        UpdateResult Update(Student entity);
        DeleteResult Delete(int id);
    }
}
