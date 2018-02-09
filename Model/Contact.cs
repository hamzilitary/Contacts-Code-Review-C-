using System.Collections.Generic;
using System;

namespace Contacts.Models
{
  public class Contact
  {
    private string _name;
    private string _contactAddress;
    private int _contactNumber;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact (string name, string contactAddress, long contactNumber)
    {
      _name = name;
      _contactAddress = contactAddress;
      _contactNumber = contactNumber;
      _id = _instances.Count;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name  = newName;
    }
    public string GetContactAddress()
    {
      return _contactAddress;
    }
    public void SetContactAddress(string newContactAddress)
    {
      _contactAddress = newContactAddress;
    }
    public long GetContactNumber()
    {
      return _contactNumber;
    }
    public void SetContactNumber(long newContactNumber)
    {
      _contactNumber = newContactNumber;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public void ContactSave()
    {
      _instances.Add(this);
    }
    public void ContactDelete()
    {
      _instances.Remove(this);
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static List<Contact> DelAll()
    {
      _instances.Clear();
      return _instances;
    }
  }
}
