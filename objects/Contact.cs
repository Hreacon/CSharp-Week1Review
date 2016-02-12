using System.Collections.Generic;

namespace Contact.Objects
{
  public class ContactClass
  {
    private int _id;
    private string _name;
    private string _phone;
    private string _address;
    private static List<ContactClass> _instances = new List<ContactClass>(){};

    public ContactClass(string name, string phone, string address) {
      _name = name;
      _phone = phone;
      _address = address;
      _id = _instances.Count;
      Save();
    }

    public void Save() {
      _instances.Add(this);
    }

    public int GetId() {
      return  _id;
    }
    public string GetName() {
      return  _name;
    }
    public string GetPhone() {
      return  _phone;
    }
    public string GetAddress() {
      return  _address;
    }
    public void SetName(string userInput) {
      _name = userInput;
    }
    public void SetPhone(string userInput) {
      _phone = userInput;
    }
    public void SetAddress(string userInput) {
      _address = userInput;
    }
    public static List<ContactClass> GetAll() {
      return _instances;
    }
    public static void DeleteAll() {
      _instances.Clear();
    }
    public static ContactClass GetById(int id) {
      ContactClass output = null;
      foreach(ContactClass c in _instances) {
        if(c.GetId() == id)
          output = c;
      }
      return output;
    }

  }
}
