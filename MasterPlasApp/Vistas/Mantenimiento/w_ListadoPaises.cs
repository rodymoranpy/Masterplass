using Servicios.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPlasApp.Vistas.Mantenimiento
{
    public partial class w_ListadoPaises : Form
    {
        protected PaisManager manager;

        public w_ListadoPaises()
        {
            InitializeComponent();
        }

        private void w_ListadoPaises_Load(object sender, EventArgs e)
        {
            manager = new PaisManager();

            dataGridView1.DataSource = manager.FindAll();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
        }
    }
}
