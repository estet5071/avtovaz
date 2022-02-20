using System;

namespace Presentation.ViewInterfaces.Edit
{
    public interface ISectionEditView : IView 
    {

        event Action Cancel;
        event Action Apply;

        void ShowForAdd();

        void ShowError(params string[] errors);

        void Hide();

    }
}
