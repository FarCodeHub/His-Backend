using DataAccess.Entities.His;
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;
using System;
using System.Data.Entity.Validation;
using System.Threading.Tasks;

namespace DataAccess.Repositories.EF.His
{
    public class EFUnitOfWork : IUnitOfWork
    {
        PortalHisContext _context;
        public EFUnitOfWork()
        {
            _context = new PortalHisContext();
        }
        public PortalHisContext DatabaseContext
        {
            get { return _context; }
        }

        public async Task Save()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbEntityValidationException e)
            {
                String errorMessage = "";
                foreach (var eve in e.EntityValidationErrors)
                {
                    errorMessage += String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        errorMessage += String.Format("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw new Exception(errorMessage);
            }

        }

        public void ResetDatabaseContext()
        {
            _context = new PortalHisContext();
        }

        PortalHisContext IUnitOfWork.DatabaseContext
        {
            get { return _context; }
        }
    }

}
