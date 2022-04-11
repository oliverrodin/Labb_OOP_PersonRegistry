using ClassesLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using System.Windows.Forms;

namespace PersonRegistryUI
{
    public partial class PersonRegistryForm : Form
    {
       
        List<Person> personsList = new List<Person>();

        public PersonRegistryForm()
        {
            InitializeComponent();
    
        }
        /// <summary>
        /// Eventhandler who add person to list every time the 
        /// button clicks, if input is valid 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(FirstNameValue, LastNameValue, MaleRadioButton, FemaleRadioButton))
            {
                if (MaleRadioButton.Checked)
                {
                    personsList.Add(new Male(
                        FirstNameValue.Text,
                        LastNameValue.Text
                        ));
                }
                else
                {
                    personsList.Add(new Female(
                        FirstNameValue.Text,
                        LastNameValue.Text
                        ));
                }
            }
            else
            {
                MessageBox.Show("You need to fill in all information to add new person");
            }

            WireUpList(PersonsListBox);
            ClearNewPerson(FirstNameValue, LastNameValue, MaleRadioButton, FemaleRadioButton);
        }

        /// <summary>
        /// Removes the the highlited item/items every button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Person p;
            foreach (var person in PersonsListBox.SelectedItems)
            {
                p = (Person)person;
                personsList.Remove(p);
            }

            WireUpList(PersonsListBox);
        }

        /// <summary>
        /// If valid input, merge two person and produce a child
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MergeButton_Click(object sender, EventArgs e)
        {
            

            if (ValidateMerge(PersonsListBox))
            {
                ListboxItemsToPerson(personsList, PersonsListBox);
                WireUpList(PersonsListBox);
            }
            else
                MessageBox.Show("You Need to chose one (Mr.) and one (Miss.) to merge");
        }

        /// <summary>
        /// Search for person via textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchValue_TextChanged(object sender, EventArgs e)
        {
            PersonsListBox.DataSource = null;
            List<Person> filteredList =
                personsList.Where(x => x.FullName.ToLower().Contains(SearchValue.Text.ToLower())).ToList();

            PersonsListBox.DataSource = filteredList;
            PersonsListBox.DisplayMember = "FullName";

            if (SearchValue.Text == "")
                WireUpList(PersonsListBox);
        }
        
        
        /// <summary>
        /// Check if the input is valid
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="male"></param>
        /// <param name="female"></param>
        /// <returns></returns>
        private bool ValidateForm(TextBox firstName, TextBox lastName, RadioButton male, RadioButton female)
        {
            bool output = true;

            if (firstName.Text == "" && lastName.Text == "")
                output = false;
            if (firstName.Text == "" || lastName.Text == "")
                output = false;
            if (male.Checked == false && female.Checked == false)
                output = false;

            return output;
        }

        /// <summary>
        /// Check if merge input is of right type
        /// </summary>
        /// <param name="persons"></param>
        /// <returns></returns>
        private bool ValidateMerge(ListBox persons)
        {
            if (persons.SelectedItems.Count < 2 || persons.SelectedItems.Count > 2)
                return false;
            else if (persons.SelectedItems[0].GetType().Equals(persons.SelectedItems[1].GetType()))
                return false;
            else if (persons.SelectedItems[0].GetType().Name == "Child")
                return false;
            else if (persons.SelectedItems[1].GetType().Name == "Child")
                return false;

            return true;
        }

        /// <summary>
        /// Convert listbox items to person objects
        /// </summary>
        /// <param name="persons"></param>
        /// <param name="LbPerson"></param>
        private void ListboxItemsToPerson(List<Person> persons, ListBox LbPerson)
        {
            Person f = new Female();
            Person m = new Male();
            foreach (Person p in LbPerson.SelectedItems)
            {
                if (p is Female female)
                {
                    f = female;
                }
                if (p is Male male)
                {
                    m = male;
                }


            }
            var merged = f + m;
            persons.Add(merged);    
        }

        /// <summary>
        /// wire up the listbox
        /// </summary>
        /// <param name="persons"></param>
        private void WireUpList(ListBox persons)
        {
            personsList.Sort();
            PersonsListBox.DataSource = null;

            PersonsListBox.DataSource = personsList;
            PersonsListBox.DisplayMember = "FullName";
        }

        /// <summary>
        /// Clear the ui when you add a person
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="male"></param>
        /// <param name="female"></param>
        private void ClearNewPerson(TextBox firstName, TextBox lastName, RadioButton male, RadioButton female)
        {
            firstName.Text = "";
            lastName.Text = "";
            male.Checked = false;
            female.Checked = false;
        }

        
    }
}
