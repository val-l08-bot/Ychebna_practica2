using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Yshebnaya_practica2
{
    public partial class MainMenuForm : Form
    {
        List<Dishes> dishes = new List<Dishes>();
        List<Dishes> tempDishes = new List<Dishes>();

        string connectionString = Properties.Settings.Default.connectionString;
        Dishes selectedDishes = null;

        private string currentUserName;
        private string currentRole;

        // Конструктор с данными пользователя
        public MainMenuForm(string userName, string role)
        {
            InitializeComponent();
            currentUserName = userName;
            currentRole = role;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            // Показываем имя и роль
            lblRole.Text = $"Здравствуйте, {currentUserName} ({currentRole})";

            // Управление видимостью кнопок в зависимости от роли
            bool isAdmin = currentRole == "Администратор" || currentRole == "Admin";
            bool isChef  = currentRole == "Повар" || currentRole == "Chef";

            btnAddDishAdmin.Visible    = isAdmin;
            btnDeleteAdmin.Visible     = isAdmin;
            btnChangeAdmin.Visible     = isAdmin || isChef;

            LoadProductsFromDatabase();
            LoadCategories();
            fillDishes();

            rbPrice.CheckedChanged += (s, ev) => ApplySortAndFilter();
            radioButton2.CheckedChanged += (s, ev) => ApplySortAndFilter();
            cbFilter.SelectedIndexChanged += (s, ev) => ApplySortAndFilter();
            txtSearch.TextChanged += (s, ev) => ApplySortAndFilter();
        }

        public void LoadProductsFromDatabase()
        {
            dishes.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, Название, Цена_руб, Время_приготовления_мин, id_Category, Описание, Категория FROM View_Dishes";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dishes.Add(new Dishes(
                            Convert.ToInt32(reader["id"]),
                            reader["Название"].ToString(),
                            reader["Цена_руб"] != DBNull.Value ? Convert.ToDecimal(reader["Цена_руб"]) : 0m,
                            reader["Время_приготовления_мин"] != DBNull.Value ? Convert.ToInt32(reader["Время_приготовления_мин"]) : 0,
                            reader["id_Category"].ToString(),
                            reader["Описание"].ToString(),
                            reader["Категория"].ToString()
                        ));
                    }
                }

                tempDishes = new List<Dishes>(dishes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            cbFilter.Items.Clear();
            cbFilter.Items.Add("Все категории");
            foreach (var d in dishes)
            {
                if (!cbFilter.Items.Contains(d.category))
                    cbFilter.Items.Add(d.category);
            }
            cbFilter.SelectedIndex = 0;
        }

        private void ApplySortAndFilter()
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            string selectedCategory = cbFilter.SelectedItem?.ToString();

            tempDishes = dishes.Where(d =>
            {
                bool matchSearch = string.IsNullOrEmpty(searchText) || searchText == "поиск"
                    || d.name.ToLower().Contains(searchText);
                bool matchCategory = selectedCategory == "Все категории"
                    || d.category == selectedCategory;
                return matchSearch && matchCategory;
            }).ToList();

            if (rbPrice.Checked)
                tempDishes = tempDishes.OrderBy(d => d.price).ToList();
            else if (radioButton2.Checked)
                tempDishes = tempDishes.OrderBy(d => d.time).ToList();

            fillDishes();
        }

        public void fillDishes()
        {
            FLPdishes.Controls.Clear();
            foreach (Dishes di in tempDishes)
            {
                dishesCart cart = new dishesCart(di);
                cart.Margin = new Padding(6);
                cart.Click += (s, ev) =>
                {
                    selectedDishes = ((dishesCart)s).SelectedProduct;
                    foreach (Control c in FLPdishes.Controls)
                    {
                        if (c is dishesCart)
                            c.BackColor = SystemColors.Control;
                    }
                    ((dishesCart)s).BackColor = Color.LightBlue;
                };
                FLPdishes.Controls.Add(cart);
            }
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void btnAddDishAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
