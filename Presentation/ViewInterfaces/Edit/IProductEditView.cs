using System;
using System.Collections.Generic;
using System.Drawing;

namespace Presentation.ViewInterfaces.Edit
{
    public interface IProductEditView : ISectionEditView
    {

        event Action<int> CarModelChange;
        event Action LoadPhoto;
        event Action RemovePhoto;

        Image Photo { set; }

        string Description { set; get; }

        string CarModel { set; get; }

        DateTime DateCreate { set; get; }

        string CarKit { set; get; }

        string CarBodys { set; get; }

        string CarColor { set; get; }


        void AddCarColorsToComboBox(List<string> colors);

        void AddCarBodysToComboBox(List<string> carBodys);


    }
}
