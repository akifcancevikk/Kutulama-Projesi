using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Design
{
    public partial class Form1 : KryptonForm
    {
        ProductTable productTable = new ProductTable();
        BoxMasterTable boxMasterTable = new BoxMasterTable();
        BoxDetailTable boxDetailTable = new BoxDetailTable();
        public int selectedProductId = 0;
        public int selectedBoxDetailId = 0;
        private DateTime Now()
        {
            var now = DateTime.Now;
            return now;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            using (boxingEntities db = new boxingEntities())
            {
                var sonListe = db.BoxMasterTable.Where(x => x.ProductId == selectedProductId).OrderByDescending(x => x.BoxMasterId).FirstOrDefault();
                var boxMax = db.ProductTable.FirstOrDefault(y => y.ProductId == selectedProductId);
                
               
                if (sonListe == null)
                {
                    createNewBoxTable(selectedProductId, boxMax.MaxCount, "Açık");
                    var detail = db.BoxMasterTable.OrderByDescending(x => x.BoxMasterId).FirstOrDefault();
                    selectedBoxDetailId = detail.BoxMasterId;
                    createNewBoxDetailTable(selectedBoxDetailId);
                }
                else
                {
                    if (sonListe.BoxCount == boxMax.MaxCount)
                    {
                        //sonListe.SituationId = "Kapalı";
                        createNewBoxTable(selectedProductId, boxMax.MaxCount, "Açık");
                        var detail = db.BoxMasterTable.OrderByDescending(x => x.BoxMasterId).FirstOrDefault();
                        selectedBoxDetailId = detail.BoxMasterId;
                        createNewBoxDetailTable(selectedBoxDetailId);
                        
                    }
                    else
                    {
                        sonListe.BoxCount += 1;
                        createNewBoxDetailTable(selectedBoxDetailId);
                        if (sonListe.BoxCount == boxMax.MaxCount)
                        {
                            sonListe.SituationId = "Kapalı";
                        }
                    }
                    db.SaveChanges();
                }
            }
            PopulateDataGridView();
        }
        public void createNewBoxTable(int ProductId, int? BoxCount, string Situation)
        {
            using (boxingEntities bDb = new boxingEntities())
            {
                BoxMasterTable willBeAddMasterTable = new BoxMasterTable();
                willBeAddMasterTable.ProductId = ProductId;
                willBeAddMasterTable.BoxCount = 1;
                willBeAddMasterTable.SituationId = Situation;
                willBeAddMasterTable.Date = Now();
                willBeAddMasterTable.LabelNo = Now().ToString("LyyyyMMddHHmmss");
                bDb.BoxMasterTable.Add(willBeAddMasterTable);
                bDb.SaveChanges();
            }
        }
        //public void removeBoxDetail()
        //{
        //    using (boxingEntities rdb = new boxingEntities())
        //    {
        //        BoxMasterTable willBeRemoveTable = new BoxMasterTable();
        //        rdb.BoxMasterTable.Remove(boxMasterTable);
        //    }
        //}
        public void createNewBoxDetailTable(int BoxMasterId)
        {
            using (boxingEntities dbd = new boxingEntities())
            {
                BoxDetailTable willBeAddDetailTable = new BoxDetailTable();
                willBeAddDetailTable.BoxMasterId = BoxMasterId;
                willBeAddDetailTable.LabelNo = Now().ToString("EyyyyMMddHHmmss");
                willBeAddDetailTable.Date = DateTime.Now;
                dbd.BoxDetailTable.Add(willBeAddDetailTable);
                dbd.SaveChanges();
            }
        }
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
        void PopulateDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (boxingEntities db = new boxingEntities())
            {
                var list = db.BoxMasterTable.OrderByDescending(x => x.BoxMasterId).ToList();
                dataGridView1.DataSource = list;
            }
            dataGridView2.AutoGenerateColumns = false;
            using (boxingEntities db = new boxingEntities())
            {
                var list = db.BoxDetailTable.OrderByDescending(x => x.BoxDetailId).ToList();
                dataGridView2.DataSource = list;
            }
            DgvPro.AutoGenerateColumns = false;
            using (boxingEntities db = new boxingEntities())
            {
                var list = db.ProductTable.OrderBy(x => x.ReferenceNo).ToList();
                DgvPro.DataSource = list;
            }
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = false;
            }
            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows[0].Selected = false;
            }
            if (DgvPro.Rows.Count > 0)
            {
                DgvPro.Rows[0].Selected = false;
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }
        private void DgvPro_Click_1(object sender, EventArgs e)
        {
            if (DgvPro.Rows.Count > 0)
                selectedProductId = Convert.ToInt32(DgvPro.CurrentRow.Cells["ProductId_1"].Value);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using( boxingEntities db = new boxingEntities())
            {
                var deger = db.BoxMasterTable.Where(x => x.SituationId == "Açık").FirstOrDefault();
                if (deger == null)
                {
                    Application.Exit();
                }                              
                else
                {
                    DialogResult secenek =  MessageBox.Show("Elinizde açık bir kutu var!!! ", "Uyarı", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                    if (secenek == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }            
                Application.Exit();           
        }       
    }
}
