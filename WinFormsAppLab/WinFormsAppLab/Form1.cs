using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace WinFormsAppLab
{
    public partial class Form1 : Form
    {
        List<BluRayFilm> bluRayFilms = new List<BluRayFilm>();
        List<OnlineFilm> onlineFilms = new List<OnlineFilm>();
        int index = 0;
        string jsonFilePath = "films.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = 0;
            // Зчитування даних з файлу JSON та десеріалізація у колекцію List

            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                JArray array = JArray.Parse(jsonData);
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i].ToString().Contains("Blu-Ray"))
                    {
                        BluRayFilm tmp = new BluRayFilm();
                        tmp = JsonConvert.DeserializeObject<BluRayFilm>(array[i].ToString());
                        bluRayFilms.Add(tmp);
                    }
                    else
                    {
                        OnlineFilm tmp = new OnlineFilm();
                        tmp = JsonConvert.DeserializeObject<OnlineFilm>(array[i].ToString());
                        onlineFilms.Add(tmp);
                    }
                }
                DataToForm();
            }
            else
            {
                MessageBox.Show("Файл не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SerializeToFile()
        {
            List<Film> allFilms = new List<Film>();
            allFilms.AddRange(bluRayFilms);
            allFilms.AddRange(onlineFilms);

            // Серіалізація списку у формат JSON
            string jsonData = JsonConvert.SerializeObject(allFilms, Formatting.Indented);

            // Запис серіалізованих даних у файл
            File.WriteAllText(jsonFilePath, jsonData);
        }
        public void DataToForm()
        {
            if (index < bluRayFilms.Count)
            {
                BluRayFilm brf = bluRayFilms[index];
                label7.Text = "Метод доставка";
                label8.Text = "Спосіб оплати";
                comboBox1.SelectedIndex = 0;
                textBox1.Text = brf.Title;
                textBox2.Text = brf.Director;
                textBox3.Text = brf.Year.ToString();
                textBox4.Text = brf.LeadActor;
                textBox5.Text = brf.Price.ToString("F2");
                textBox6.Text = brf.DeliveryMethod;
                textBox7.Text = brf.PaymentMethod;
            }
            else
            {
                OnlineFilm of = onlineFilms[index - bluRayFilms.Count];
                label7.Text = "Тип карти";
                label8.Text = "Email";
                comboBox1.SelectedIndex = 1;
                textBox1.Text = of.Title;
                textBox2.Text = of.Director;
                textBox3.Text = of.Year.ToString();
                textBox4.Text = of.LeadActor;
                textBox5.Text = of.Price.ToString("F2");
                textBox6.Text = of.CardType;
                textBox7.Text = of.EmailAddress;
            }
            SerializeToFile();
        }
        public void ReadData()
        {
            if (index < bluRayFilms.Count)
            {
                BluRayFilm brf = bluRayFilms[index];
                brf.Title = textBox1.Text;
                brf.Director = textBox2.Text;
                brf.Year = Convert.ToInt32( textBox3.Text);
                brf.LeadActor = textBox4.Text;
                brf.Price = Convert.ToDouble( textBox5.Text);
                brf.DeliveryMethod = textBox6.Text;
                brf.PaymentMethod = textBox7.Text;

            }
            else
            {
                OnlineFilm of = onlineFilms[index - bluRayFilms.Count];
                of.Title = textBox1.Text;
                of.Director = textBox2.Text;
                of.Year = Convert.ToInt32(textBox3.Text);
                of.LeadActor = textBox4.Text;
                of.Price = Convert.ToDouble(textBox5.Text);
                of.CardType = textBox6.Text;
                of.EmailAddress = textBox7.Text;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadData();
            index--;
            if (index < 0)
            {
                index = bluRayFilms.Count + onlineFilms.Count - 1;
            }
            DataToForm();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadData();
            index++;
            if (index > bluRayFilms.Count + onlineFilms.Count - 1)
            {
                index = 0;
            }
            DataToForm();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (index < bluRayFilms.Count + onlineFilms.Count && bluRayFilms.Count + onlineFilms.Count > 0)
            {
                if (index < bluRayFilms.Count)
                    bluRayFilms.RemoveAt(index);
                else
                    onlineFilms.RemoveAt(index - bluRayFilms.Count);

                if (index > bluRayFilms.Count + onlineFilms.Count - 1)
                {
                    index = 0;
                }
                DataToForm();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool rez = MessageBox.Show("Бажаєте додати BlueRay?", "Питання", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if (rez)
            {
                BluRayFilm brf = new BluRayFilm();
                bluRayFilms.Add(brf);
                index = bluRayFilms.Count - 1;
                label7.Text = "Метод доставка";
                label8.Text = "Спосіб оплати";
                DataToForm();
            }
            else
            {
                OnlineFilm of = new OnlineFilm();
                onlineFilms.Add(of);
                index = bluRayFilms.Count + onlineFilms.Count - 1;
                label7.Text = "Тип карти";
                label8.Text = "Email";
                DataToForm();
            }
        }
    }
}