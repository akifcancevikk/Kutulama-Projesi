namespace Design
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtProductName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nrcBoxCount = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.btnSaveBox = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnHome = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dbvForm2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbvForm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(40, 51);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonLabel1.Size = new System.Drawing.Size(114, 24);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Referans Girin";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(40, 116);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonLabel2.Size = new System.Drawing.Size(150, 24);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Kutu İçi Adeti Girin";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(227, 51);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.txtProductName.Size = new System.Drawing.Size(136, 27);
            this.txtProductName.TabIndex = 2;
            // 
            // nrcBoxCount
            // 
            this.nrcBoxCount.Location = new System.Drawing.Point(224, 114);
            this.nrcBoxCount.Name = "nrcBoxCount";
            this.nrcBoxCount.Size = new System.Drawing.Size(139, 26);
            this.nrcBoxCount.TabIndex = 3;
            // 
            // btnSaveBox
            // 
            this.btnSaveBox.Location = new System.Drawing.Point(59, 3);
            this.btnSaveBox.Name = "btnSaveBox";
            this.btnSaveBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.btnSaveBox.Size = new System.Drawing.Size(119, 36);
            this.btnSaveBox.TabIndex = 4;
            this.btnSaveBox.Values.Text = "Ekle";
            this.btnSaveBox.Click += new System.EventHandler(this.btnSaveBox_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(713, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.btnHome.Size = new System.Drawing.Size(119, 42);
            this.btnHome.TabIndex = 5;
            this.btnHome.Values.Text = "Ana Sayfa";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // dbvForm2
            // 
            this.dbvForm2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbvForm2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbvForm2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ReferenceNo,
            this.BoxCount});
            this.dbvForm2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dbvForm2.Location = new System.Drawing.Point(0, 198);
            this.dbvForm2.Name = "dbvForm2";
            this.dbvForm2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.dbvForm2.ReadOnly = true;
            this.dbvForm2.RowHeadersWidth = 15;
            this.dbvForm2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dbvForm2.RowTemplate.Height = 24;
            this.dbvForm2.Size = new System.Drawing.Size(832, 255);
            this.dbvForm2.TabIndex = 6;
            this.dbvForm2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbvForm2_CellContentClick_1);
            this.dbvForm2.Click += new System.EventHandler(this.dbvForm2_Click);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ReferenceNo
            // 
            this.ReferenceNo.DataPropertyName = "ReferenceNo";
            this.ReferenceNo.HeaderText = "Reference No";
            this.ReferenceNo.MinimumWidth = 6;
            this.ReferenceNo.Name = "ReferenceNo";
            this.ReferenceNo.ReadOnly = true;
            // 
            // BoxCount
            // 
            this.BoxCount.DataPropertyName = "MaxCount";
            this.BoxCount.HeaderText = "Max Count";
            this.BoxCount.MinimumWidth = 6;
            this.BoxCount.Name = "BoxCount";
            this.BoxCount.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(59, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.btnDelete.Size = new System.Drawing.Size(119, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Values.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(59, 118);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.btnUpdate.Size = new System.Drawing.Size(119, 36);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Values.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(417, 4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(69, 24);
            this.kryptonLabel3.TabIndex = 10;
            this.kryptonLabel3.Values.Text = "İşlemler";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.kryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighInternalProfile;
            this.kryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonAlternate;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(412, 27);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            this.kryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnSaveBox);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnUpdate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnDelete);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(239, 165);
            this.kryptonGroupBox1.TabIndex = 9;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.dbvForm2);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.nrcBoxCount);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Back.Color1 = System.Drawing.Color.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbvForm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProductName;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown nrcBoxCount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnHome;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dbvForm2;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxCount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
    }
}