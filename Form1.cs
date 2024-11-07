using System.Windows.Forms;

namespace zd2_Mezenceva_Polina_Sergeevna
{
    public partial class Form1 : Form
    {
        PhoneBook phoneBook = new PhoneBook();
        public Form1()//инициализация формы/конструктор
        {
            InitializeComponent();
            panel1.Visible = false;
            contactsListBox.ContextMenuStrip = contextMenuStrip1;

            PhoneBookLoader.Load(phoneBook);
            foreach (Contact contact in phoneBook.Contacts)
            {
                contactsListBox.Items.Add(contact);
            }
        }
        //кнопка поиска
        private void searchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(phoneBook.SearchContact(searchNameSurnameTextBox.Text), "Контакт найден.");
        }
        //добавление нового контакта
        private void newContactButton_Click(object sender, EventArgs e)
        {
            if (phoneBook.IsValidPhoneNumber(phoneTextBox.Text) == true)
            {
                phoneBook.AddContact(nameTextBox.Text + " " + surnameTextBox.Text, phoneTextBox.Text);
                PhoneBookLoader.Save(phoneBook);
                UpdateContactsListBox();
            }
            else MessageBox.Show("Корректный формат ввода номера: (800)800-80-80");
        }
        //обновление лист бокса
        private void UpdateContactsListBox()
        {
            contactsListBox.Items.Clear();
            foreach (Contact contact in phoneBook.Contacts)
            {
                contactsListBox.Items.Add(contact);
            }
        }
        //удаление контакта 
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contactsListBox.SelectedItem != null)
            {
                phoneBook.RemoveContact(contactsListBox.SelectedIndex);
                contactsListBox.Items.Remove(contactsListBox.SelectedItem);
                UpdateContactsListBox();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент для удаления.");
            }
        }
        //для красоты, чтобы по нажатию панель закрывалась
        private void editButton_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
            else panel1.Visible = true;
        }
        //кнопка редактирования
        private void editButton_Click_1(object sender, EventArgs e)
        {
            if (contactsListBox.SelectedItem != null)
            {
                phoneBook.EditContact(nameEditTextBox.Text, phoneEditTextBox.Text, contactsListBox.SelectedIndex);
                contactsListBox.Items.Clear();
                foreach (Contact contact in phoneBook.Contacts)//проходимся по списку и добавляем в листбокс
                {
                    contactsListBox.Items.Add(contact);
                }
                PhoneBookLoader.Save(phoneBook);
                UpdateContactsListBox();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент для редактирования.");
            }
        }

        //кнопка загрузки строки
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (contactsListBox.SelectedIndex != -1)
            {
                string[] str = contactsListBox.SelectedItem.ToString().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                nameEditTextBox.Text = str[0];
                phoneEditTextBox.Text = str[1];
            }
        }
        //закрытие формы при нажатии на нее
        private void tabPage3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
