using Perfectial.EntityFramework.Sample.Business.Utils;
using Perfectial.EntityFramework.Sample.Common.DTOs;
using Perfectial.EntityFramework.Sample.DataAccess;
using Perfectial.EntityFramework.Sample.DataAccess.Models;
using System.Threading.Tasks;
using System.Data.Entity;
using Perfectial.EntityFramework.Sample.Business.Utils.Mapper;

namespace Perfectial.EntityFramework.Sample.Business
{
    public class StudentService : BaseService<Student, StudentSpecification>
    {
        #region Constants
        private const string DEF_SAVE_STUDENT_ERROR_LOG_TEMPLATE = "Save Student Failed, ID: {0}";
        private const string DEF_SAVE_STUDENT_LOG_TEMPLATE = "Save Student Started, ID: {0}";
        #endregion

        #region Constructor
        public StudentService(DataContext dataContext) : base(dataContext, new Logger("User Service")) { }
        #endregion

        #region Service Methods
        public async Task<bool> UpdateUserAsync(StudentSpecification studentSpecification)
        {
            await _logger.Inform(string.Format(
                    DEF_SAVE_STUDENT_LOG_TEMPLATE, studentSpecification.Id));

            var entity = await _context.Set<Student>().FirstOrDefaultAsync(s => s.Id == studentSpecification.Id);
            if (entity == null)
            {
                await _logger.Warn(string.Format(
                    DEF_SAVE_STUDENT_ERROR_LOG_TEMPLATE, studentSpecification.Id));
            }
            else
            {
                var user = Mapper.MapContents(studentSpecification, entity);
                return await _context.SaveChangesAsync() > 0;
            }
           
            return false;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var entity = await _context.Set<Student>().FirstOrDefaultAsync(s => s.Id == id);
            entity.Deleted = true;
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateStudentEmail(string email, int userId)
        {
            var entity = await _context.Set<Student>().FirstOrDefaultAsync(s => s.Id == userId);
            entity.Email = email;
            return await _context.SaveChangesAsync();
        }
        #endregion
    }
}
