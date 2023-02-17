using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Design
{
    public partial class Form2 : KryptonForm
    {
        ProductTable productTable = new ProductTable();
        BoxMasterTable boxMasterTable = new BoxMasterTable();
        BoxDetailTable boxDetailTable = new BoxDetailTable();
        public Form2()
        {
            InitializeComponent();
        }
        void PopulateDataGridView()
        {
            dbvForm2.AutoGenerateColumns = false;
            using (boxingEntities db = new boxingEntities())
            {
                var list = db.ProductTable.OrderBy(x => x.ProductId).ToList();
                dbvForm2.DataSource = list;
            }
        }
        void Clear()
        {
            txtProductName.Text = "";
            txtProductName.Focus();
            nrcBoxCount.ResetText();
            btnSaveBox.Text = "Kaydet";
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            productTable.ProductId = 0;
        }
        private void btnSaveBox_Click_1(object sender, EventArgs e)
        {

            if ( txtProductName.Text.StartsWith("-") || txtProductName.Text.StartsWith(".") || txtProductName.Text.StartsWith(","))
            {
                MessageBox.Show("Geçersiz Bir Referans Adı Girdiniz!");
                return;
            }
            else if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Referans Adı Boş Olamaz!");
                return;
            }
            if (nrcBoxCount.Value < 0)
            {
                MessageBox.Show("Kutu İçi Adedi Yanlış Girildi!");
                return;
            }
            else if (nrcBoxCount.Value == 0)
            {
                MessageBox.Show("Kutu İçi Adedi Sıfır Olamaz!");
                return;
            }

            using (boxingEntities db = new boxingEntities())
            {

                productTable.ReferenceNo = txtProductName.Text;
                productTable.MaxCount = Convert.ToInt32(nrcBoxCount.Value);
                var b = db.ProductTable.Where(y => y.ReferenceNo == productTable.ReferenceNo).FirstOrDefault();
                if (b != null)
                {
                    MessageBox.Show("Bu Referans Daha Önceden Girilmiş");
                    return;
                }
                else
                {
                    db.ProductTable.Add(productTable);
                    db.SaveChanges();
                }

            }
            PopulateDataGridView();
            Clear();
        }      
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void dbvForm2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dbvForm2.ReadOnly = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void dbvForm2_Click(object sender, EventArgs e)
        {
            if (dbvForm2.CurrentRow.Index != -1)
            {
                productTable.ProductId = Convert.ToInt32(dbvForm2.CurrentRow.Cells["ProductId"].Value);

                using (boxingEntities db = new boxingEntities())
                {
                    productTable = db.ProductTable.Where(x => x.ProductId == productTable.ProductId).FirstOrDefault();
                    txtProductName.Text = productTable.ReferenceNo;
                    nrcBoxCount.Value = Convert.ToDecimal(productTable.MaxCount);
                }                
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dbvForm2.CurrentRow.Cells["ProductId"].Value);
            using (boxingEntities db = new boxingEntities())
            {
                var update = db.ProductTable.Where(x => x.ProductId == id).FirstOrDefault();
                update.ReferenceNo = txtProductName.Text;
                update.MaxCount = Convert.ToInt32(nrcBoxCount.Value);
                db.SaveChanges();
            }
            PopulateDataGridView();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Referansı silmek istediğinizden emin misiniz?","", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(boxingEntities db = new boxingEntities())
                {
                    var entry = db.Entry(productTable);
                    if(entry.State == EntityState.Detached)
                    {
                        db.ProductTable.Attach(productTable);
                        db.ProductTable.Remove(productTable);
                        db.SaveChanges();
                        PopulateDataGridView();
                        Clear();
                    }
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }      
    }
}
