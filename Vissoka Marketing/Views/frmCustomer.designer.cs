namespace Diteck_Sky.Views.Customer
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabView = new System.Windows.Forms.TabPage();
            this.panelContainerX = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdate = new Vissoka.Controls.ViFlatButton();
            this.btnDelete = new Vissoka.Controls.ViFlatButton();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.vissokaCardLoading = new Vissoka.Controls.VissokaCard();
            this.progressIndicator1 = new Vissoka.Controls.ViProgressCircular();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cxFlatGroupBox1 = new Vissoka.UI.ViFlatGroupBox();
            this.viSearchByEmail = new Vissoka.UI.ViFlatRadioButton();
            this.viSearchByAll = new Vissoka.UI.ViFlatRadioButton();
            this.txtSearch = new Vissoka.UI.ViFlatTextBox();
            this.viSearchByName = new Vissoka.UI.ViFlatRadioButton();
            this.viSearchByAddress = new Vissoka.UI.ViFlatRadioButton();
            this.viSearchByContact = new Vissoka.UI.ViFlatRadioButton();
            this.btnNew = new Vissoka.Controls.ViFlatButton();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.cxFlatGroupBox2 = new Vissoka.UI.ViFlatGroupBox();
            this.btnBack = new Vissoka.Controls.ViFlatButton();
            this.btnAdd = new Vissoka.Controls.ViFlatButton();
            this.txtEmail = new Vissoka.UI.ViFlatTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndereco = new Vissoka.UI.ViFlatTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContacto = new Vissoka.UI.ViFlatTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new Vissoka.UI.ViFlatTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.viLoading1 = new Vissoka.Controls.ViLoading();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabView.SuspendLayout();
            this.panelContainerX.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.vissokaCardLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.cxFlatGroupBox1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.cxFlatGroupBox2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tabControl1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(21, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(758, 614);
            this.panel5.TabIndex = 28;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabView);
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 614);
            this.tabControl1.TabIndex = 32;
            // 
            // tabView
            // 
            this.tabView.BackColor = System.Drawing.SystemColors.Control;
            this.tabView.Controls.Add(this.panelContainerX);
            this.tabView.Location = new System.Drawing.Point(4, 29);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(750, 581);
            this.tabView.TabIndex = 1;
            this.tabView.Text = "tabPage2";
            // 
            // panelContainerX
            // 
            this.panelContainerX.BackColor = System.Drawing.SystemColors.Control;
            this.panelContainerX.Controls.Add(this.panel4);
            this.panelContainerX.Controls.Add(this.panelGrid);
            this.panelContainerX.Controls.Add(this.cxFlatGroupBox1);
            this.panelContainerX.Controls.Add(this.btnNew);
            this.panelContainerX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerX.Location = new System.Drawing.Point(3, 3);
            this.panelContainerX.Name = "panelContainerX";
            this.panelContainerX.Size = new System.Drawing.Size(744, 575);
            this.panelContainerX.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 500);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(744, 75);
            this.panel4.TabIndex = 27;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColorClicked = System.Drawing.Color.Green;
            this.btnUpdate.ButtonType = Vissoka.Enums.ButtonType.Success;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(347, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Opacity = 0;
            this.btnUpdate.Size = new System.Drawing.Size(191, 36);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Atualizar Dados";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColorClicked = System.Drawing.Color.Maroon;
            this.btnDelete.ButtonType = Vissoka.Enums.ButtonType.Danger;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDelete.Location = new System.Drawing.Point(544, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Opacity = 0;
            this.btnDelete.Size = new System.Drawing.Size(191, 36);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Eliminar Cliente";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.Controls.Add(this.vissokaCardLoading);
            this.panelGrid.Controls.Add(this.dgvClientes);
            this.panelGrid.Location = new System.Drawing.Point(15, 137);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(717, 357);
            this.panelGrid.TabIndex = 26;
            // 
            // vissokaCardLoading
            // 
            this.vissokaCardLoading.BackColor = System.Drawing.Color.White;
            this.vissokaCardLoading.BorderRadius = 5;
            this.vissokaCardLoading.BottomSahddow = false;
            this.vissokaCardLoading.color = System.Drawing.Color.DeepSkyBlue;
            this.vissokaCardLoading.Controls.Add(this.progressIndicator1);
            this.vissokaCardLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vissokaCardLoading.LeftSahddow = false;
            this.vissokaCardLoading.Location = new System.Drawing.Point(0, 0);
            this.vissokaCardLoading.Name = "vissokaCardLoading";
            this.vissokaCardLoading.RightSahddow = false;
            this.vissokaCardLoading.ShadowDepth = 9;
            this.vissokaCardLoading.Size = new System.Drawing.Size(717, 357);
            this.vissokaCardLoading.TabIndex = 24;
            // 
            // progressIndicator1
            // 
            this.progressIndicator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressIndicator1.Location = new System.Drawing.Point(318, 138);
            this.progressIndicator1.MaximumSize = new System.Drawing.Size(80, 80);
            this.progressIndicator1.MinimumSize = new System.Drawing.Size(50, 50);
            this.progressIndicator1.Name = "progressIndicator1";
            this.progressIndicator1.P_AnimationColor = System.Drawing.Color.DodgerBlue;
            this.progressIndicator1.P_AnimationSpeed = 50;
            this.progressIndicator1.P_BaseColor = System.Drawing.Color.DarkGray;
            this.progressIndicator1.Size = new System.Drawing.Size(80, 80);
            this.progressIndicator1.TabIndex = 14;
            this.progressIndicator1.Text = "progressIndicator1";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.GridColor = System.Drawing.Color.White;
            this.dgvClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.RowHeadersWidth = 20;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientes.RowTemplate.Height = 40;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(717, 389);
            this.dgvClientes.TabIndex = 23;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.Column3.HeaderText = "Contacto";
            this.Column3.MinimumWidth = 150;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 550F;
            this.Column4.HeaderText = "Endereço";
            this.Column4.MinimumWidth = 250;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 700F;
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 400;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 300F;
            this.Column6.HeaderText = "Data";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // cxFlatGroupBox1
            // 
            this.cxFlatGroupBox1.Controls.Add(this.viSearchByEmail);
            this.cxFlatGroupBox1.Controls.Add(this.viSearchByAll);
            this.cxFlatGroupBox1.Controls.Add(this.txtSearch);
            this.cxFlatGroupBox1.Controls.Add(this.viSearchByName);
            this.cxFlatGroupBox1.Controls.Add(this.viSearchByAddress);
            this.cxFlatGroupBox1.Controls.Add(this.viSearchByContact);
            this.cxFlatGroupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cxFlatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatGroupBox1.Location = new System.Drawing.Point(15, 67);
            this.cxFlatGroupBox1.Name = "cxFlatGroupBox1";
            this.cxFlatGroupBox1.ShowText = true;
            this.cxFlatGroupBox1.Size = new System.Drawing.Size(484, 36);
            this.cxFlatGroupBox1.TabIndex = 22;
            this.cxFlatGroupBox1.TabStop = false;
            this.cxFlatGroupBox1.Text = "Pesquisar";
            this.cxFlatGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(159)))), ((int)(((byte)(216)))));
            this.cxFlatGroupBox1.Enter += new System.EventHandler(this.cxFlatGroupBox1_Enter);
            this.cxFlatGroupBox1.Leave += new System.EventHandler(this.cxFlatGroupBox1_Leave);
            // 
            // viSearchByEmail
            // 
            this.viSearchByEmail.AutoSize = true;
            this.viSearchByEmail.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(159)))), ((int)(((byte)(216)))));
            this.viSearchByEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viSearchByEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viSearchByEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viSearchByEmail.Location = new System.Drawing.Point(320, 43);
            this.viSearchByEmail.Name = "viSearchByEmail";
            this.viSearchByEmail.Size = new System.Drawing.Size(57, 20);
            this.viSearchByEmail.TabIndex = 23;
            this.viSearchByEmail.Text = "Email";
            this.viSearchByEmail.UseVisualStyleBackColor = true;
            this.viSearchByEmail.CheckedChanged += new System.EventHandler(this.viSearchByEmail_CheckedChanged);
            // 
            // viSearchByAll
            // 
            this.viSearchByAll.AutoSize = true;
            this.viSearchByAll.Checked = true;
            this.viSearchByAll.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(159)))), ((int)(((byte)(216)))));
            this.viSearchByAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viSearchByAll.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viSearchByAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viSearchByAll.Location = new System.Drawing.Point(10, 42);
            this.viSearchByAll.Name = "viSearchByAll";
            this.viSearchByAll.Size = new System.Drawing.Size(60, 20);
            this.viSearchByAll.TabIndex = 22;
            this.viSearchByAll.TabStop = true;
            this.viSearchByAll.Text = "Todos";
            this.viSearchByAll.UseVisualStyleBackColor = true;
            this.viSearchByAll.CheckedChanged += new System.EventHandler(this.viSearchByAll_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(2, 0);
            this.txtSearch.MaxLength = 100;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Placeholder = "Procurar";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(482, 36);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TabStop = false;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // viSearchByName
            // 
            this.viSearchByName.AutoSize = true;
            this.viSearchByName.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(159)))), ((int)(((byte)(216)))));
            this.viSearchByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viSearchByName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viSearchByName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viSearchByName.Location = new System.Drawing.Point(82, 43);
            this.viSearchByName.Name = "viSearchByName";
            this.viSearchByName.Size = new System.Drawing.Size(62, 20);
            this.viSearchByName.TabIndex = 19;
            this.viSearchByName.Text = "Nome";
            this.viSearchByName.UseVisualStyleBackColor = true;
            this.viSearchByName.CheckedChanged += new System.EventHandler(this.viFlatRadioButton1_CheckedChanged);
            // 
            // viSearchByAddress
            // 
            this.viSearchByAddress.AutoSize = true;
            this.viSearchByAddress.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(159)))), ((int)(((byte)(216)))));
            this.viSearchByAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viSearchByAddress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viSearchByAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viSearchByAddress.Location = new System.Drawing.Point(232, 43);
            this.viSearchByAddress.Name = "viSearchByAddress";
            this.viSearchByAddress.Size = new System.Drawing.Size(82, 20);
            this.viSearchByAddress.TabIndex = 21;
            this.viSearchByAddress.Text = "Endereço";
            this.viSearchByAddress.UseVisualStyleBackColor = true;
            // 
            // viSearchByContact
            // 
            this.viSearchByContact.AutoSize = true;
            this.viSearchByContact.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(159)))), ((int)(((byte)(216)))));
            this.viSearchByContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viSearchByContact.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viSearchByContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viSearchByContact.Location = new System.Drawing.Point(147, 43);
            this.viSearchByContact.Name = "viSearchByContact";
            this.viSearchByContact.Size = new System.Drawing.Size(82, 20);
            this.viSearchByContact.TabIndex = 20;
            this.viSearchByContact.Text = "Contacto";
            this.viSearchByContact.UseVisualStyleBackColor = true;
            this.viSearchByContact.CheckedChanged += new System.EventHandler(this.viSearchByContact_CheckedChanged);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColorClicked = System.Drawing.Color.Teal;
            this.btnNew.ButtonType = Vissoka.Enums.ButtonType.Primary;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnNew.Location = new System.Drawing.Point(541, 67);
            this.btnNew.Name = "btnNew";
            this.btnNew.Opacity = 0;
            this.btnNew.Size = new System.Drawing.Size(191, 36);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Novo Cliente";
            this.btnNew.TextColor = System.Drawing.Color.White;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.cxFlatGroupBox2);
            this.tabAdd.Location = new System.Drawing.Point(4, 29);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(750, 581);
            this.tabAdd.TabIndex = 2;
            this.tabAdd.Text = "tabPage1";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // cxFlatGroupBox2
            // 
            this.cxFlatGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cxFlatGroupBox2.Controls.Add(this.btnBack);
            this.cxFlatGroupBox2.Controls.Add(this.btnAdd);
            this.cxFlatGroupBox2.Controls.Add(this.txtEmail);
            this.cxFlatGroupBox2.Controls.Add(this.label6);
            this.cxFlatGroupBox2.Controls.Add(this.txtEndereco);
            this.cxFlatGroupBox2.Controls.Add(this.label3);
            this.cxFlatGroupBox2.Controls.Add(this.txtContacto);
            this.cxFlatGroupBox2.Controls.Add(this.label2);
            this.cxFlatGroupBox2.Controls.Add(this.txtNome);
            this.cxFlatGroupBox2.Controls.Add(this.label1);
            this.cxFlatGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatGroupBox2.Location = new System.Drawing.Point(141, 70);
            this.cxFlatGroupBox2.Name = "cxFlatGroupBox2";
            this.cxFlatGroupBox2.ShowText = false;
            this.cxFlatGroupBox2.Size = new System.Drawing.Size(512, 366);
            this.cxFlatGroupBox2.TabIndex = 0;
            this.cxFlatGroupBox2.TabStop = false;
            this.cxFlatGroupBox2.Text = "cxFlatGroupBox2";
            this.cxFlatGroupBox2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(159)))), ((int)(((byte)(216)))));
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColorClicked = System.Drawing.Color.Crimson;
            this.btnBack.ButtonType = Vissoka.Enums.ButtonType.Danger;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnBack.Location = new System.Drawing.Point(84, 290);
            this.btnBack.Name = "btnBack";
            this.btnBack.Opacity = 0;
            this.btnBack.Size = new System.Drawing.Size(191, 36);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Cancelar";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.Click += new System.EventHandler(this.viFlatButton2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColorClicked = System.Drawing.Color.Teal;
            this.btnAdd.ButtonType = Vissoka.Enums.ButtonType.Primary;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAdd.Location = new System.Drawing.Point(301, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Opacity = 0;
            this.btnAdd.Size = new System.Drawing.Size(191, 36);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Cadastrar Cliente";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.Click += new System.EventHandler(this.viFlatButton1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(11, 237);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Placeholder = "Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(482, 36);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(7, 213);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Email";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEndereco.Hint = "";
            this.txtEndereco.Location = new System.Drawing.Point(11, 174);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Multiline = false;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.Placeholder = "Endereço";
            this.txtEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.Size = new System.Drawing.Size(482, 36);
            this.txtEndereco.TabIndex = 23;
            this.txtEndereco.TabStop = false;
            this.txtEndereco.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Endereço";
            // 
            // txtContacto
            // 
            this.txtContacto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtContacto.Hint = "";
            this.txtContacto.Location = new System.Drawing.Point(11, 107);
            this.txtContacto.MaxLength = 100;
            this.txtContacto.Multiline = false;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.PasswordChar = '\0';
            this.txtContacto.Placeholder = "Contacto";
            this.txtContacto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContacto.SelectedText = "";
            this.txtContacto.SelectionLength = 0;
            this.txtContacto.SelectionStart = 0;
            this.txtContacto.Size = new System.Drawing.Size(482, 36);
            this.txtContacto.TabIndex = 21;
            this.txtContacto.TabStop = false;
            this.txtContacto.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Contacto";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(11, 41);
            this.txtNome.MaxLength = 100;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.Placeholder = "Nome";
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(482, 36);
            this.txtNome.TabIndex = 19;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Control;
            this.panel9.Controls.Add(this.viLoading1);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.labelTitle);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(21, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(758, 93);
            this.panel9.TabIndex = 17;
            // 
            // viLoading1
            // 
            this.viLoading1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viLoading1.AnimationSpeed = 100;
            this.viLoading1.BackgroundColor = System.Drawing.Color.White;
            this.viLoading1.DotColor = System.Drawing.Color.DodgerBlue;
            this.viLoading1.DotsSize = new System.Drawing.Point(15, 15);
            this.viLoading1.Location = new System.Drawing.Point(673, 12);
            this.viLoading1.MinimumSize = new System.Drawing.Size(50, 50);
            this.viLoading1.Name = "viLoading1";
            this.viLoading1.Size = new System.Drawing.Size(73, 73);
            this.viLoading1.TabIndex = 28;
            this.viLoading1.Text = "viLoading1";
            this.viLoading1.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gainsboro;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(757, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 0);
            this.panel10.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(758, 93);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "   Clientes";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.TextChanged += new System.EventHandler(this.labelTitle_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 614);
            this.panel2.TabIndex = 8;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 614);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.panel5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.panelContainerX.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.vissokaCardLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.cxFlatGroupBox1.ResumeLayout(false);
            this.cxFlatGroupBox1.PerformLayout();
            this.tabAdd.ResumeLayout(false);
            this.cxFlatGroupBox2.ResumeLayout(false);
            this.cxFlatGroupBox2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainerX;
        private System.Windows.Forms.Panel panel4;
        private Vissoka.Controls.ViFlatButton btnUpdate;
        private Vissoka.Controls.ViFlatButton btnDelete;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvClientes;
        private Vissoka.UI.ViFlatGroupBox cxFlatGroupBox1;
        private Vissoka.UI.ViFlatTextBox txtSearch;
        private Vissoka.UI.ViFlatRadioButton viSearchByName;
        private Vissoka.UI.ViFlatRadioButton viSearchByAddress;
        private Vissoka.UI.ViFlatRadioButton viSearchByContact;
        private Vissoka.Controls.ViFlatButton btnNew;
        private Vissoka.UI.ViFlatGroupBox cxFlatGroupBox2;
        private Vissoka.UI.ViFlatTextBox txtContacto;
        private System.Windows.Forms.Label label2;
        private Vissoka.UI.ViFlatTextBox txtNome;
        private System.Windows.Forms.Label label1;
        private Vissoka.UI.ViFlatTextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private Vissoka.UI.ViFlatTextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private Vissoka.Controls.ViFlatButton btnBack;
        private Vissoka.Controls.ViFlatButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Vissoka.UI.ViFlatRadioButton viSearchByAll;
        private Vissoka.UI.ViFlatRadioButton viSearchByEmail;
        private Vissoka.Controls.VissokaCard vissokaCardLoading;
        private Vissoka.Controls.ViProgressCircular progressIndicator1;
        private Vissoka.Controls.ViLoading viLoading1;
    }
}