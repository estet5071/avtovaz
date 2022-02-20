using Model.Entities;
using System.Collections.Generic;

namespace Model.ServiceAbstractions
{
    public interface ISectionService <TEntity> where TEntity : BaseEntity
    {
        TEntity EntityForAddOrUpdate { get; set; }
        List<TEntity> DataForMainGrid { get; set; }

        void AddToDataBase(TEntity entity);
        void UpdateEntity();
        void RemoveEntity(TEntity entity);
        TEntity Find(int id);
        void InitialLoad();
    }
}
