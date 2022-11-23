using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_16_List_Manipulation
{
    public class Phone
    {
        string _brand;
        string _model;
        int _capacity;
        List<string> _contacts = new List<string>();

        public Phone(string brand, string model, int capacity)
        {
            _brand = brand;
            _model = model;
            _capacity = capacity;
        }

        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public int Capacity { get => _capacity; set => _capacity = value; }
        public List<string> Contacts { get => _contacts;}

        public void AddContact(string phoneNumber)
        {
            _contacts.Add(phoneNumber);
        }
    }
}
