using System.Windows.Forms;

namespace zd2_Mezenceva_Polina_Sergeevna
{
    public partial class Form1 : Form
    {
        PhoneBook phoneBook = new PhoneBook();
        public Form1()//������������� �����/�����������
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
        //������ ������
        private void searchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(phoneBook.SearchContact(searchNameSurnameTextBox.Text), "������� ������.");
        }
        //���������� ������ ��������
        private void newContactButton_Click(object sender, EventArgs e)
        {
            if (phoneBook.IsValidPhoneNumber(phoneTextBox.Text) == true)
            {
                phoneBook.AddContact(nameTextBox.Text + " " + surnameTextBox.Text, phoneTextBox.Text);
                PhoneBookLoader.Save(phoneBook);
                UpdateContactsListBox();
            }
            else MessageBox.Show("���������� ������ ����� ������: (800)800-80-80");
        }
        //���������� ���� �����
        private void UpdateContactsListBox()
        {
            contactsListBox.Items.Clear();
            foreach (Contact contact in phoneBook.Contacts)
            {
                contactsListBox.Items.Add(contact);
            }
        }
        //�������� �������� 
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contactsListBox.SelectedItem != null)
            {
                phoneBook.RemoveContact(contactsListBox.SelectedIndex);
                contactsListBox.Items.Remove(contactsListBox.SelectedItem);
                UpdateContactsListBox();
            }
            else
            {
                MessageBox.Show("����������, �������� ������� ��� ��������.");
            }
        }
        //��� �������, ����� �� ������� ������ �����������
        private void editButton_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
            else panel1.Visible = true;
        }
        //������ ��������������
        private void editButton_Click_1(object sender, EventArgs e)
        {
            if (contactsListBox.SelectedItem != null)
            {
                phoneBook.EditContact(nameEditTextBox.Text, phoneEditTextBox.Text, contactsListBox.SelectedIndex);
                contactsListBox.Items.Clear();
                foreach (Contact contact in phoneBook.Contacts)//���������� �� ������ � ��������� � ��������
                {
                    contactsListBox.Items.Add(contact);
                }
                PhoneBookLoader.Save(phoneBook);
                UpdateContactsListBox();
            }
            else
            {
                MessageBox.Show("����������, �������� ������� ��� ��������������.");
            }
        }

        //������ �������� ������
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (contactsListBox.SelectedIndex != -1)
            {
                string[] str = contactsListBox.SelectedItem.ToString().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                nameEditTextBox.Text = str[0];
                phoneEditTextBox.Text = str[1];
            }
        }
        //�������� ����� ��� ������� �� ���
        private void tabPage3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
