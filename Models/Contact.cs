using System;
using System.Collections.Generic;

namespace AdressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _address;
    private string _phone;
    private int _id;
    private static List<Contact> _contacts = new List<Contact>{};

    public Contact (string name, string address, string phone)
    {
      _name = name;
      _address = address;
      _phone = phone;
      _contacts.Add(this);
      _id = _contacts.Count;
    }

    public void SetName(string name)
    {
      _name = name;
    }
    public string GetName()
    {
      return _name;
    }

    public void SetAddress(string address)
    {
      _address = address;
    }
    public string GetAddress()
    {
      return _address;
    }

    public void SetPhone(string phone)
    {
      _phone = phone;
    }
    public string GetPhone()
    {
      return _phone;
    }

    public static List<Contact> GetContacts()
    {
      return _contacts;
    }

    public static void ClearContacts()
    {
      _contacts.Clear();
    }

    public static Contact Find(int id)
    {
      return _contacts[id-1];
    }
    public int GetId()
    {
      return _id;
    }
  }
}
