using Model.Entities;
using System;

namespace Presentation.PresenterAbstractions
{
    internal interface IEditPresenter<TEntity> where TEntity : BaseEntity
    {

        event Action<TEntity> AddToDataGrid;
        event Action UpdateDataGrid;

        bool ViewIsUpdate { set; }

        void ShowDataForUpdate();

        void ShowForAdd();
    }
}
