using Common;
using DataAccess.Abstracts;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StudentRepository: IStudentRepository
    {
        private readonly AppDbContext _appDbContext;
        
        public StudentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Student>Get()
        {
            return _appDbContext.Students.OrderBy(x => x.Id);

        }


        public GeneralEnums.InsertResult insert(Student entity)
        {
            try
            {
                var exists=_appDbContext.Students.Any(x=> x.StudentNumber == entity.StudentNumber);
                if (exists)
                    return GeneralEnums.InsertResult.Duplicated;

                _appDbContext.Students.Add(entity);
                var response=_appDbContext.SaveChanges();
                if (response > 0)
                    return GeneralEnums.InsertResult.Success;
                return GeneralEnums.InsertResult.Error;


            }
            catch (Exception ex)
            {
                return GeneralEnums.InsertResult.Error;

              
            }

        }


        public GeneralEnums.UpdateResult Update(Student entity)
        {
            try
            {
                var oldEntity=_appDbContext.Students.FirstOrDefault(x => x.Id == entity.Id);
                if (oldEntity == null)
                    return GeneralEnums.UpdateResult.NotFound;

                oldEntity.FirstName = entity.FirstName;
                oldEntity.LastName = entity.LastName;
                oldEntity.Birthdate = entity.Birthdate;

                var response = _appDbContext.SaveChanges();
                if (response > 0)
                    return GeneralEnums.UpdateResult.Success;
                return GeneralEnums.UpdateResult.Error;


            }
            catch (Exception ex)
            {
                return GeneralEnums.UpdateResult.Error;


            }

        }


        public GeneralEnums.DeleteResult Delete(int id)
        {
            var oldEntity = _appDbContext.Students.FirstOrDefault(x => x.Id == id);
            if (oldEntity == null)
                return GeneralEnums.DeleteResult.NotFound;

            _appDbContext.Students.Remove(oldEntity);
            var response = _appDbContext.SaveChanges();
            if (response > 0)
                return GeneralEnums.DeleteResult.Success;
            return GeneralEnums.DeleteResult.Error;
        }
    }
}
