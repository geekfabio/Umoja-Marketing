namespace Vissoka_Marketing.Views
{
    partial class frmCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.panelControlsForm = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabView = new System.Windows.Forms.TabPage();
            this.panelContainerX = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtEndereco = new Vissoka.UI.ViFlatTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new Vissoka.UI.ViFlatTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new Vissoka.Controls.ViFlatButton();
            this.btnAdd = new Vissoka.Controls.ViFlatButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelHideTab = new System.Windows.Forms.Panel();
            this.panelBottomBorder = new System.Windows.Forms.Panel();
            this.bckLoad = new System.ComponentModel.BackgroundWorker();
            this.vissokaControl = new Vissoka.Controls.VissokaCard();
            this.txtSearch = new Vissoka.UI.ViFlatTextBox();
            this.labelTitleText = new System.Windows.Forms.Label();
            this.labelLineDecoration = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new Vissoka.Controls.ViFlatButton();
            this.btnUpdate = new Vissoka.Controls.ViFlatButton();
            this.panelControlsForm.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabView.SuspendLayout();
            this.panelContainerX.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.panel7.SuspendLayout();
            this.vissokaControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControlsForm
            // 
            this.panelControlsForm.BackColor = System.Drawing.Color.White;
            this.panelControlsForm.Controls.Add(this.tabControl1);
            this.panelControlsForm.Location = new System.Drawing.Point(14, 131);
            this.panelControlsForm.Name = "panelControlsForm";
            this.panelControlsForm.Size = new System.Drawing.Size(479, 371);
            this.panelControlsForm.TabIndex = 29;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabView);
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 371);
            this.tabControl1.TabIndex = 32;
            this.tabControl1.TabStop = false;
            // 
            // tabView
            // 
            this.tabView.BackColor = System.Drawing.Color.White;
            this.tabView.Controls.Add(this.panelContainerX);
            this.tabView.Location = new System.Drawing.Point(4, 29);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(471, 338);
            this.tabView.TabIndex = 1;
            this.tabView.Text = "tabPage2";
            // 
            // panelContainerX
            // 
            this.panelContainerX.BackColor = System.Drawing.Color.White;
            this.panelContainerX.Controls.Add(this.label7);
            this.panelContainerX.Controls.Add(this.panel4);
            this.panelContainerX.Controls.Add(this.label8);
            this.panelContainerX.Controls.Add(this.panelGrid);
            this.panelContainerX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerX.Location = new System.Drawing.Point(3, 3);
            this.panelContainerX.Name = "panelContainerX";
            this.panelContainerX.Size = new System.Drawing.Size(465, 332);
            this.panelContainerX.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(104)))), ((int)(((byte)(200)))));
            this.label7.Location = new System.Drawing.Point(11, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "Lista de Categorias";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 279);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(465, 53);
            this.panel4.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(11, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(624, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________________";
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.Controls.Add(this.dgvClientes);
            this.panelGrid.Location = new System.Drawing.Point(15, 44);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(447, 229);
            this.panelGrid.TabIndex = 26;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orchid;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.GridColor = System.Drawing.Color.White;
            this.dgvClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.RowHeadersWidth = 20;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientes.RowTemplate.Height = 35;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(444, 223);
            this.dgvClientes.TabIndex = 23;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.White;
            this.tabAdd.Controls.Add(this.label13);
            this.tabAdd.Controls.Add(this.panel7);
            this.tabAdd.Controls.Add(this.label9);
            this.tabAdd.Controls.Add(this.label10);
            this.tabAdd.Location = new System.Drawing.Point(4, 29);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(471, 338);
            this.tabAdd.TabIndex = 2;
            this.tabAdd.Text = "tabPage1";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(14, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(624, 22);
            this.label13.TabIndex = 31;
            this.label13.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________________";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtEndereco);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.btnBack);
            this.panel7.Controls.Add(this.txtNome);
            this.panel7.Controls.Add(this.btnAdd);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(18, 48);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(423, 267);
            this.panel7.TabIndex = 30;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEndereco.Hint = "";
            this.txtEndereco.Location = new System.Drawing.Point(14, 108);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.Placeholder = "Endereço";
            this.txtEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.Size = new System.Drawing.Size(379, 76);
            this.txtEndereco.TabIndex = 31;
            this.txtEndereco.TabStop = false;
            this.txtEndereco.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Detalhes";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(14, 36);
            this.txtNome.MaxLength = 100;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.Placeholder = "Nome";
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(379, 36);
            this.txtNome.TabIndex = 27;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(10, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nome";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackColorClicked = System.Drawing.Color.Crimson;
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnBack.ButtonType = Vissoka.Enums.ButtonType.Default;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnBack.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.HoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnBack.Location = new System.Drawing.Point(229, 190);
            this.btnBack.Name = "btnBack";
            this.btnBack.Opacity = 0;
            this.btnBack.Size = new System.Drawing.Size(164, 36);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Cancelar";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackColorClicked = System.Drawing.Color.Teal;
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnAdd.ButtonType = Vissoka.Enums.ButtonType.Success;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAdd.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.HoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnAdd.Location = new System.Drawing.Point(10, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Opacity = 0;
            this.btnAdd.Size = new System.Drawing.Size(191, 36);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Cadastrar Cliente";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(104)))), ((int)(((byte)(200)))));
            this.label9.Location = new System.Drawing.Point(14, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "Nova Categoria";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(14, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(624, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________________";
            // 
            // panelHideTab
            // 
            this.panelHideTab.Location = new System.Drawing.Point(14, 128);
            this.panelHideTab.Name = "panelHideTab";
            this.panelHideTab.Size = new System.Drawing.Size(479, 29);
            this.panelHideTab.TabIndex = 25;
            // 
            // panelBottomBorder
            // 
            this.panelBottomBorder.BackColor = System.Drawing.Color.DimGray;
            this.panelBottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBorder.Location = new System.Drawing.Point(0, 654);
            this.panelBottomBorder.Name = "panelBottomBorder";
            this.panelBottomBorder.Size = new System.Drawing.Size(505, 18);
            this.panelBottomBorder.TabIndex = 30;
            // 
            // bckLoad
            // 
            this.bckLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckLoad_DoWork);
            this.bckLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckLoad_RunWorkerCompleted);
            // 
            // vissokaControl
            // 
            this.vissokaControl.BackColor = System.Drawing.Color.White;
            this.vissokaControl.BorderRadius = 5;
            this.vissokaControl.BottomSahddow = true;
            this.vissokaControl.color = System.Drawing.Color.White;
            this.vissokaControl.Controls.Add(this.txtSearch);
            this.vissokaControl.Controls.Add(this.labelTitleText);
            this.vissokaControl.Controls.Add(this.labelLineDecoration);
            this.vissokaControl.LeftSahddow = true;
            this.vissokaControl.Location = new System.Drawing.Point(14, 12);
            this.vissokaControl.Name = "vissokaControl";
            this.vissokaControl.RightSahddow = true;
            this.vissokaControl.ShadowDepth = 30;
            this.vissokaControl.Size = new System.Drawing.Size(477, 110);
            this.vissokaControl.TabIndex = 31;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(22, 52);
            this.txtSearch.MaxLength = 100;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Placeholder = "Procurar";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(421, 36);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TabStop = false;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // labelTitleText
            // 
            this.labelTitleText.AutoSize = true;
            this.labelTitleText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(104)))), ((int)(((byte)(200)))));
            this.labelTitleText.Location = new System.Drawing.Point(18, 15);
            this.labelTitleText.Name = "labelTitleText";
            this.labelTitleText.Size = new System.Drawing.Size(111, 22);
            this.labelTitleText.TabIndex = 1;
            this.labelTitleText.Text = "Categorias";
            // 
            // labelLineDecoration
            // 
            this.labelLineDecoration.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineDecoration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelLineDecoration.Location = new System.Drawing.Point(18, 24);
            this.labelLineDecoration.Name = "labelLineDecoration";
            this.labelLineDecoration.Size = new System.Drawing.Size(425, 22);
            this.labelLineDecoration.TabIndex = 2;
            this.labelLineDecoration.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________________";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 600F;
            this.Column2.HeaderText = "Nome";
            this.Column2.MinimumWidth = 200;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 350F;
            this.Column3.HeaderText = "Detalhes";
            this.Column3.MinimumWidth = 150;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackColorClicked = System.Drawing.Color.Maroon;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnDelete.ButtonType = Vissoka.Enums.ButtonType.Default;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDelete.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.HoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnDelete.Location = new System.Drawing.Point(215, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Opacity = 0;
            this.btnDelete.Size = new System.Drawing.Size(191, 36);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Eliminar Cliente";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackColorClicked = System.Drawing.Color.Green;
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnUpdate.ButtonType = Vissoka.Enums.ButtonType.Default;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnUpdate.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.HoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnUpdate.Location = new System.Drawing.Point(18, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Opacity = 0;
            this.btnUpdate.Size = new System.Drawing.Size(191, 36);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Atualizar Dados";
            this.btnUpdate.TextColor = System.Drawing.Color.Maroon;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(505, 672);
            this.Controls.Add(this.vissokaControl);
            this.Controls.Add(this.panelHideTab);
            this.Controls.Add(this.panelBottomBorder);
            this.Controls.Add(this.panelControlsForm);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.panelControlsForm.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.panelContainerX.ResumeLayout(false);
            this.panelContainerX.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.vissokaControl.ResumeLayout(false);
            this.vissokaControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelControlsForm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.Panel panelContainerX;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Panel panelHideTab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Vissoka.Controls.ViFlatButton btnBack;
        private Vissoka.Controls.ViFlatButton btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private Vissoka.UI.ViFlatTextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private Vissoka.UI.ViFlatTextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelBottomBorder;
        private System.ComponentModel.BackgroundWorker bckLoad;
        private Vissoka.Controls.VissokaCard vissokaControl;
        private Vissoka.UI.ViFlatTextBox txtSearch;
        private System.Windows.Forms.Label labelTitleText;
        private System.Windows.Forms.Label labelLineDecoration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Vissoka.Controls.ViFlatButton btnDelete;
        private Vissoka.Controls.ViFlatButton btnUpdate;
    }
}