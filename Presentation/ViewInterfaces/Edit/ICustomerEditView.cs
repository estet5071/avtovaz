namespace Presentation.ViewInterfaces.Edit
{
    public interface ICustomerEditView : ISectionEditView
    {

        string Name { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        string Address { get; set; }
    }
}
