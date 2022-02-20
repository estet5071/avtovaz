using System;
using System.Collections.Generic;
using System.Drawing;

namespace Presentation.ViewInterfaces.Edit
{
    public interface IEmployeeEditView : ISectionEditView
    {
        event Action LoadPhoto;
        event Action RemovePhoto;

        string Position { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        string Adress { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        DateTime? Birthday { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        string AccountAcces { get; set; }
        Image Photo { set; }

        void FillComboBoxs(List<string> accessLevels, List<string> employeePositions);

    }
}
