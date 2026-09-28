using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace beutravel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Çıxış düyməsi (button3)
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Proqramdan çıxış edilsinmi?", "Bildiriş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        // Haradan / Haraya dəyişmə düyməsi (button4)
        private void button4_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string b = comboBox2.Text;
            string c = b;
            comboBox2.Text = a;
            comboBox1.Text = c;
        }

        int n = 0;

        // Bilet Əlavə Et düyməsi (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Bütün xanaların doluluğunu yoxlayırıq
            if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                !maskedTextBox1.MaskCompleted ||
                !maskedTextBox2.MaskCompleted ||
                !maskedTextBox4.MaskCompleted)
            {
                MessageBox.Show("Zəhmət olmasa, bütün xanaları tam doldurun!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime travelDate;
            DateTime travelTime;
            if (!DateTime.TryParseExact(maskedTextBox1.Text, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out travelDate) ||
                !DateTime.TryParseExact(maskedTextBox2.Text, "HH:mm",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out travelTime))
            {
                MessageBox.Show("Tarixi gün/ay/il, vaxtı isə 24 saatlıq formatda düzgün daxil edin.",
                    "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Eyni şəhər seçiminin yoxlanılması
            if (string.Equals(comboBox1.Text.Trim(), comboBox2.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Eyni şəhərlərə gediş yoxdur", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. FIN Kodun yoxlanılması (Dəqiq 7 simvol, HƏM rəqəm HƏM də hərf olmalıdır)
            string fin = textBox2.Text.Trim().ToUpperInvariant();
            if (!IsFinValid(fin))
            {
                MessageBox.Show("FIN kod dəqiq 7 simvoldan ibarət olmalı və tərkibində həm hərf, həm də rəqəm olmalıdır!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Email ünvanının yoxlanılması
            string email = textBox3.Text.Trim();
            if (!IsEmailValid(email))
            {
                MessageBox.Show("Düzgün bir Email ünvanı daxil edin! (Məsələn: numune@mail.com)", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Biletin ListBox-a əlavə olunması
            n++;
            listBox1.Items.Add(n.ToString() + ") " + comboBox1.Text + " " + comboBox2.Text + " "
                + maskedTextBox1.Text + " " + maskedTextBox2.Text + " " + textBox1.Text + " | FIN: " + fin + " | Telefon: " + maskedTextBox4.Text + " | Email: " + email);

            // Xanaları təmizləyirik
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox4.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
        }

        // Siyahıdan sil düyməsi (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                // Silindikdən sonra nömrələrin ardıcıl nizamlanması
                ReindexListBox();
            }
            else
            {
                MessageBox.Show("Lütfən, silmək üçün siyahıdan bir bilet seçin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ListBox-da silinmədən sonra nömrələri 1, 2, 3... şəklində bərpa edən funksiya
        private void ReindexListBox()
        {
            n = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                n++;
                string itemText = listBox1.Items[i].ToString();

                int index = itemText.IndexOf(") ");
                if (index != -1 && index < 10)
                {
                    itemText = itemText.Substring(index + 2);
                }

                listBox1.Items[i] = n.ToString() + ") " + itemText;
            }
        }

        // FIN validasiyası
        private bool IsFinValid(string fin)
        {
            if (fin.Length != 7) return false;

            bool hasLetter = Regex.IsMatch(fin, @"[A-Z]");
            bool hasDigit = Regex.IsMatch(fin, @"[0-9]");
            bool isAlphaNumeric = Regex.IsMatch(fin, @"^[A-Z0-9]+$");

            return hasLetter && hasDigit && isAlphaNumeric;
        }

        // Email validasiyası
        private bool IsEmailValid(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
