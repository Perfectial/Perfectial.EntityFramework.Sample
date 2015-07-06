using Perfectial.EntityFramework.Sample.Business.Utils;
using Perfectial.EntityFramework.Sample.Business.Utils.Mapper;
using Perfectial.EntityFramework.Sample.DataAccess;
using Perfectial.EntityFramework.Sample.DataAccess.Models.Base;
using System.Threading.Tasks;
using System.Data.Entity;
using Perfectial.EntityFramework.Sample.Common.Specifications.Base;

namespace Perfectial.EntityFramework.Sample.Business
{
    public abstract class BaseService<TEntity, TSpecification>
        where TEntity : BaseEntity
        where TSpecification : BaseSpecification
    {
        #region Protected Readonly
        protected readonly ILogger _logger;
        protected readonly DataContext _context;
        #endregion

        #region Constants
        private const string DEF_GET_OBJECT_LOG_TEMPLATE = "Get action, Type: {0}, Id: {1}";
        #endregion

        #region Constructors
        public BaseService(DataContext context, ILogger logger)
        {
            _logger = logger;
            _context = context;
        }

        #endregion

        #region Base Service Methods
        public async Task<TSpecification> Get(int id)
        {
            await _logger.Inform(string.Format(DEF_GET_OBJECT_LOG_TEMPLATE, typeof(TSpecification).Name, id));

            return Mapper.Map<TSpecification>(await _context.Set<TEntity>().FirstOrDefaultAsync(s => s.Id == id));
        }
        #endregion
    }
}
