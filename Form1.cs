using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_16_List_Manipulation
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string>();
        List<Phone> phones = new List<Phone>();

        public Form1()
        {
            InitializeComponent();
            PhonePreload();
            DisplayBrand();
            DisplaySalesInfo();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            string phoneNumber = rtbDisplay.Text;
            int selectedPhone = lbOG.SelectedIndex;
            Phone phone = phones[selectedPhone];
            phone.AddContact(phoneNumber);

            DisplaySalesInfo();
            DisplayPhoneNumbers(phone);

            // Make sure phone is display in combo box
            cbPhones.SelectedIndex = selectedPhone;




        } // btnAddContact_Click()

        private void cbPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int phoneIndex = cbPhones.SelectedIndex;
            Phone phone = phones[phoneIndex];

            DisplayPhoneNumbers(phone);
        } // cbPhones_SelectedIndexChanged()

        public void DisplayBrand()
        {
            foreach (Phone item in phones)
            {
                lbOG.Items.Add(item.Brand);
            }
        }

        public void DisplaySalesInfo()
        {
            cbPhones.Items.Clear();
            foreach(Phone item in phones)
            {
                // Show current contacts
                // Brand Model - Number of Contacts
                string formattedString = $"{item.Brand} {item.Model} - {item.Contacts.Count}";
                cbPhones.Items.Add(formattedString);
            }
        }

        public void DisplayPhoneNumbers(Phone phone)
        {
            lbCurrent.Items.Clear();
            foreach (string phoneNumber in phone.Contacts)
            {
                lbCurrent.Items.Add(phoneNumber);
            }
        }

        // Helper Method
        public void DisplayOgList()
        {
            Display(names, lbOG);
        }

        public void Display(List<string> stringList, ListBox lb)
        {
            lb.Items.Clear();
            foreach (string item in stringList)
            {
                lb.Items.Add(item);
            }
        }

        


        public void Preload()
        {
            names.Add("Wong");
            names.Add("Hannah");
            names.Add("Sam");
            names.Add("Zack");
            names.Add("Kris");
            names.Add("Dylan");
            names.Add("Will");

        }

        public void PhonePreload()
        {
            phones.Add(new Phone("Apple", "IPhone", 1000));
            phones.Add(new Phone("Google", "Pixel", 1000));
            phones.Add(new Phone("Motorla", "Razor", 1000));
            phones.Add(new Phone("Samsung", "S22", 1000));
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            int indexToRemove = lbCurrent.SelectedIndex;
            names.RemoveAt(indexToRemove);

            DisplayOgList();
            Display(names, lbCurrent);
        }

        private void btnRemoveValue_Click(object sender, EventArgs e)
        {

            string selectedValue = lbCurrent.SelectedItem.ToString();
            names.Remove(selectedValue);

            DisplayOgList();
            //Display(names, lbCurrent);

            
        }


    }
}
