using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_Mezenceva_Polina_Sergeevna
{
    static class PhoneBookLoader
    {
        //загрузка списка из файла
        public static void Load(PhoneBook phoneBook)
        {
            string fileName = "contacts.csv";
            if (!File.Exists(fileName))
            {
                return;
            }

            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                var split = line.Split(';');
                if (split.Length == 2)
                {
                    var contact = new Contact
                    {
                        Name = split[0].Trim(),
                        Phone = split[1].Trim()
                    };
                    phoneBook.AddContact(contact);
                }
            }
        }
        //сохранение списка в файл
        public static void Save(PhoneBook phoneBook)
        {
            string fileName = "contacts.csv";

            using (var writer = new StreamWriter(fileName))
            {
                foreach (var contact in phoneBook.Contacts)
                {
                    writer.WriteLine(contact.ToString());
                }
            }
        }
    }
}
