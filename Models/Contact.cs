using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

    public string GetName()
    {
      return _name;
    }

    public string GetAddress()
    {
      return _address;
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

    public static List<Contact> Search(List<Contact> contacts, string search)
    {
      Regex regex = new Regex($@"{search}", RegexOptions.IgnoreCase);
      List<Contact> searchMatch = new List<Contact> {};
      foreach(Contact contact in contacts)
      {
        Match matchName = regex.Match(contact.GetName());
        Match matchAddress = regex.Match(contact.GetAddress());
        Match matchPhone = regex.Match(contact.GetPhone());
        if (matchName.Success || matchAddress.Success || matchPhone.Success)
        {
          searchMatch.Add(contact);
        }
      }
      return searchMatch;
    }
  }
}
