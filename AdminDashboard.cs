// File: AdminDashboard.cs
using System.Windows.Forms;
using TokoParfum.Controller;
using TokoParfum.Model;

namespace TokoParfum.View
{
    public partial class AdminDashboard : Form
    {
        private ParfumController parfumController = new ParfumController();

        public AdminDashboard()
        {
            InitializeComponent();
            LoadParfumData();
        }

        private void LoadParfumData()
        {
            dataGridViewParfum.DataSource = parfumController.GetAllParfum();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Implementasi tambah parfum
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Implementasi update parfum
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Implementasi hapus parfum
        }
    }
}