using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace zd2_Mezenceva_Polina_Sergeevna
{
    class PhoneBook
    {
        public List<Contact> Contacts;//список контактов
        public PhoneBook()//конструктор
        { 
            Contacts = new List<Contact>();
        }
        //добавление контакта
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
        //добавление контакта, перегрузка
        public void AddContact(string name, string phone)
        {
            Contact contact = new Contact();
            contact.Name = name;
            contact.Phone = phone;
            Contacts.Add(contact);
        }
        //поиск контакта
        public string SearchContact(string name)
        {
            var foundContact = Contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (foundContact != null)
            {
                return $"Имя, фамилия: {foundContact.Name}, Номер: {foundContact.Phone}";
            }
            else
            {
                return "Контакт не найден.";
            }
        }
        //удаление контакта
        public void RemoveContact(int index) 
        {
            int i = 0;
            foreach(var contact in Contacts) 
            {
                if (index == i)
                {
                    Contacts.Remove(contact);
                    break;
                }
                i++;
            }
        }
        //редактирование контакта
        public void EditContact(string name, string phone, int index) 
        {
            int i = 0;
            foreach (var contact in Contacts)
            {
                if (index == i)
                {
                    contact.Name = name;
                    contact.Phone = phone;
                    break;
                }
                i++;
            }
        }
        //метод проверки ввода номера
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            phoneNumber = phoneNumber.Replace(" ", "");

            //проверяем, начинается ли строка с '(' и содержит ли ')'
            if (!phoneNumber.StartsWith("(") || !phoneNumber.Contains(")"))
            {
                return false;
            }

            string[] parts = phoneNumber.Split(new char[] { '(', ')', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //проверяем количество частей и их длину
            if (parts.Length != 4 || parts[0].Length != 3 || parts[1].Length != 3 || parts[2].Length != 2 || parts[3].Length != 2)
            {
                return false;
            }
            foreach (var part in parts)
            {
                if (!int.TryParse(part, out _))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
