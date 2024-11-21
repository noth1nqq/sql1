namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // получение данных
            using (ApplicationContext db = new ApplicationContext())
            {
                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                label1.Text = "Список пользователей: ";
                foreach (User u in users)
                {
                    label2.Text +=$"{u.Id}.{u.Name} - {u.Age}\n";
                }
            }
        }
    }
    
}
