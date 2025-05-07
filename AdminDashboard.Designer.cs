// File: AdminDashboard.Designer.cs
namespace TokoParfum.View
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewParfum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewParfum = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataGridViewParfum
            // 
            this.dataGridViewParfum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParfum.Location = new System.Drawing.Point(50, 50);
            this.dataGridViewParfum.Name = "dataGridViewParfum";
            this.dataGridViewParfum.Size = new System.Drawing.Size(500, 200);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "Tambah Parfum";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(200, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Text = "Edit Parfum";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(350, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Hapus Parfum";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AdminDashboard
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewParfum);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
        }
    }
}