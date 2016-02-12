using Nancy;
using Contact.Objects;
using System.Collections.Generic;

namespace Contact
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["list_all_contacts.cshtml", ContactClass.GetAll()];
      };
      Get["/contacts_deleted"] = _ => {
        ContactClass.DeleteAll();
        return View["contacts_deleted.cshtml"];
      };
      Get["/contact/{id}"] = parameters => {
        return View["view_contact.cshtml", ContactClass.GetById(parameters.id)];
      };
      Get["/addContact"] = _ => {
        return View["add_contact.cshtml"];
      };
    }
  }
}


/*
Contact
name, phone, address, id
static list _instances
get/set each
constructor set all

/ - display links to two pages - show list of all contact
  Display details of individual contacts
  link to form to make new contact
/contact_created - say You created a contact and show the details of that contact
  link back to home page

*/
