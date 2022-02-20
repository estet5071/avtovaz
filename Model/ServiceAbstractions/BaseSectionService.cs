using System.Collections.Generic;
using Model.Entities;

namespace Model.ServiceAbstractions
{
    abstract public class BaseSectionService<TEntity> : ISectionService<TEntity> where TEntity : BaseEntity
    {

        protected AvtoVazContext _context;

        public List<TEntity> DataForMainGrid { get; set; }
        public TEntity EntityForAddOrUpdate { get; set ; }

        public void AddToDataBase(TEntity entity)
        {
             if(_context == null)
                _context = new AvtoVazContext();
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            _context = null;
        }

        public void UpdateEntity()
        {
            _context.SaveChanges();
            _context = null;

        }


        public void RemoveEntity(TEntity entity)
        {
              _context.Set<TEntity>().Remove(entity);
              _context.SaveChanges();
              _context = null;
        }

        public TEntity Find(int id)
        {
            _context = new AvtoVazContext();
                 return _context.Set<TEntity>().Find(id);
        }


        abstract public void InitialLoad();


    }
}
