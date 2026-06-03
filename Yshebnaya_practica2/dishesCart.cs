using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yshebnaya_practica2
{
    public partial class dishesCart : UserControl
    {
        private Dishes dishes;
        string connectionString = Properties.Settings.Default.connectionString;


        // Свойство для получения товара снаружи (для редактирования)
        public Dishes SelectedProduct => dishes;
        public dishesCart(Dishes di)
        {
            InitializeComponent();
            dishes = di;
            lblName.Text = di.name;
            lblTime.Text = di.time.ToString() + " мин";
            lblDescription.Text = di.description;
            lblPrice.Text = di.price.ToString("F2") + " руб.";
            lblCategory.Text = di.category;
        }

        private void dishesCart_Load(object sender, EventArgs e)
        {

        }
    }
}
