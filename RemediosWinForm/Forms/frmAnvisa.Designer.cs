namespace RemediosWinForm {
    partial class frmAnvisa {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnvisa));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAnvisaRemedio = new SuperGrid.SuperDGV();
            this.Matches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrincipioAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsAnvisaRemedio = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonPrincipio = new System.Windows.Forms.RadioButton();
            this.radioButtonProduto = new System.Windows.Forms.RadioButton();
            this.radioButtonClasse = new System.Windows.Forms.RadioButton();
            this.labelProcurar = new System.Windows.Forms.Label();
            this.comboBoxProcurar = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUncheck = new System.Windows.Forms.Button();
            this.buttonPesquisaPrincipio = new System.Windows.Forms.Button();
            this.ckbPrincipios = new System.Windows.Forms.CheckedListBox();
            this.bnavAnvisaRemedio = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnvisaRemedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnvisaRemedio)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnavAnvisaRemedio)).BeginInit();
            this.bnavAnvisaRemedio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvAnvisaRemedio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.59711F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.40289F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1220, 698);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvAnvisaRemedio
            // 
            this.dgvAnvisaRemedio.AllowUserToAddRows = false;
            this.dgvAnvisaRemedio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAnvisaRemedio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAnvisaRemedio.AutoGenerateColumns = false;
            this.dgvAnvisaRemedio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAnvisaRemedio.BackgroundColor = System.Drawing.Color.Black;
            this.dgvAnvisaRemedio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnvisaRemedio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnvisaRemedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnvisaRemedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matches,
            this.dataGridViewTextBoxColumn11,
            this.PrincipioAtivo,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvAnvisaRemedio, 2);
            this.dgvAnvisaRemedio.DataSource = this.bsAnvisaRemedio;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnvisaRemedio.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAnvisaRemedio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnvisaRemedio.EnableHeadersVisualStyles = false;
            this.dgvAnvisaRemedio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAnvisaRemedio.Location = new System.Drawing.Point(3, 258);
            this.dgvAnvisaRemedio.Name = "dgvAnvisaRemedio";
            this.dgvAnvisaRemedio.ReadOnly = true;
            this.dgvAnvisaRemedio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnvisaRemedio.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAnvisaRemedio.RowHeadersWidth = 20;
            this.dgvAnvisaRemedio.RowTemplate.Height = 24;
            this.dgvAnvisaRemedio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnvisaRemedio.Size = new System.Drawing.Size(1214, 437);
            this.dgvAnvisaRemedio.TabIndex = 2;
            this.dgvAnvisaRemedio.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.anvisaRemedioSuperDGV_CellFormatting);
            this.dgvAnvisaRemedio.DoubleClick += new System.EventHandler(this.dgvAnvisaRemedio_DoubleClick);
            // 
            // Matches
            // 
            this.Matches.DataPropertyName = "Matches";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Matches.DefaultCellStyle = dataGridViewCellStyle3;
            this.Matches.HeaderText = "#";
            this.Matches.Name = "Matches";
            this.Matches.ReadOnly = true;
            this.Matches.Width = 70;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ProdutoNome";
            this.dataGridViewTextBoxColumn11.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 112;
            // 
            // PrincipioAtivo
            // 
            this.PrincipioAtivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrincipioAtivo.DataPropertyName = "PrincipioAtivo";
            this.PrincipioAtivo.HeaderText = "Princípios Ativos";
            this.PrincipioAtivo.Name = "PrincipioAtivo";
            this.PrincipioAtivo.ReadOnly = true;
            this.PrincipioAtivo.Width = 169;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Apresentacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Apresentação";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 159;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LaboratorioNome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Laboratório";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 143;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ClasseTerapeuticaNome";
            this.dataGridViewTextBoxColumn6.HeaderText = "Classe Terapêutica";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.Width = 180;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TipoDeProdutoNome";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tipo de Produto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.Width = 167;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TarjaNome";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tarja";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "RestricaoHospitalar";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Restrição Hospitalar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // bsAnvisaRemedio
            // 
            this.bsAnvisaRemedio.DataSource = typeof(DataLayer.AnvisaRemedio);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonPrincipio);
            this.panel1.Controls.Add(this.radioButtonProduto);
            this.panel1.Controls.Add(this.radioButtonClasse);
            this.panel1.Controls.Add(this.labelProcurar);
            this.panel1.Controls.Add(this.comboBoxProcurar);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 249);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonPrincipio
            // 
            this.radioButtonPrincipio.AutoSize = true;
            this.radioButtonPrincipio.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonPrincipio.Location = new System.Drawing.Point(419, 40);
            this.radioButtonPrincipio.Name = "radioButtonPrincipio";
            this.radioButtonPrincipio.Size = new System.Drawing.Size(110, 32);
            this.radioButtonPrincipio.TabIndex = 9;
            this.radioButtonPrincipio.TabStop = true;
            this.radioButtonPrincipio.Text = "Princípio";
            this.radioButtonPrincipio.UseVisualStyleBackColor = true;
            this.radioButtonPrincipio.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonProduto
            // 
            this.radioButtonProduto.AutoSize = true;
            this.radioButtonProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonProduto.Location = new System.Drawing.Point(263, 40);
            this.radioButtonProduto.Name = "radioButtonProduto";
            this.radioButtonProduto.Size = new System.Drawing.Size(105, 32);
            this.radioButtonProduto.TabIndex = 8;
            this.radioButtonProduto.TabStop = true;
            this.radioButtonProduto.Text = "Produto";
            this.radioButtonProduto.UseVisualStyleBackColor = true;
            this.radioButtonProduto.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonClasse
            // 
            this.radioButtonClasse.AutoSize = true;
            this.radioButtonClasse.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonClasse.Location = new System.Drawing.Point(33, 40);
            this.radioButtonClasse.Name = "radioButtonClasse";
            this.radioButtonClasse.Size = new System.Drawing.Size(190, 32);
            this.radioButtonClasse.TabIndex = 7;
            this.radioButtonClasse.TabStop = true;
            this.radioButtonClasse.Text = "Classe Terapêutica";
            this.radioButtonClasse.UseVisualStyleBackColor = true;
            this.radioButtonClasse.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelProcurar
            // 
            this.labelProcurar.AutoSize = true;
            this.labelProcurar.ForeColor = System.Drawing.SystemColors.Control;
            this.labelProcurar.Location = new System.Drawing.Point(3, 81);
            this.labelProcurar.Name = "labelProcurar";
            this.labelProcurar.Size = new System.Drawing.Size(90, 28);
            this.labelProcurar.TabIndex = 6;
            this.labelProcurar.Text = "Procurar:";
            // 
            // comboBoxProcurar
            // 
            this.comboBoxProcurar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProcurar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProcurar.FormattingEnabled = true;
            this.comboBoxProcurar.Location = new System.Drawing.Point(88, 78);
            this.comboBoxProcurar.Name = "comboBoxProcurar";
            this.comboBoxProcurar.Size = new System.Drawing.Size(441, 36);
            this.comboBoxProcurar.TabIndex = 5;
            this.comboBoxProcurar.SelectedIndexChanged += new System.EventHandler(this.comboBoxProcurar_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Image = global::RemediosWinForm.Properties.Resources.Add_24;
            this.buttonAdd.Location = new System.Drawing.Point(535, 78);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(41, 31);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonAdd, "Adicionar à lista");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.PrincipioParaLista_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCheck);
            this.panel2.Controls.Add(this.buttonClear);
            this.panel2.Controls.Add(this.buttonUncheck);
            this.panel2.Controls.Add(this.buttonPesquisaPrincipio);
            this.panel2.Controls.Add(this.ckbPrincipios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(613, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 249);
            this.panel2.TabIndex = 1;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.Image = global::RemediosWinForm.Properties.Resources.Check_24;
            this.buttonCheck.Location = new System.Drawing.Point(432, 78);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(41, 37);
            this.buttonCheck.TabIndex = 7;
            this.buttonCheck.Tag = "Principio";
            this.buttonCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCheck, "Selecionar todos");
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonChangeCheck_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Image = global::RemediosWinForm.Properties.Resources.Trash_24;
            this.buttonClear.Location = new System.Drawing.Point(432, 150);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(41, 37);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Tag = "Principio";
            this.buttonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonClear, "Limpar lista");
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUncheck
            // 
            this.buttonUncheck.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUncheck.Image = global::RemediosWinForm.Properties.Resources.Uncheck_24;
            this.buttonUncheck.Location = new System.Drawing.Point(432, 114);
            this.buttonUncheck.Name = "buttonUncheck";
            this.buttonUncheck.Size = new System.Drawing.Size(41, 37);
            this.buttonUncheck.TabIndex = 5;
            this.buttonUncheck.Tag = "Principio";
            this.buttonUncheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonUncheck, "Desmarcar todos");
            this.buttonUncheck.UseVisualStyleBackColor = true;
            this.buttonUncheck.Click += new System.EventHandler(this.buttonChangeCheck_Click);
            // 
            // buttonPesquisaPrincipio
            // 
            this.buttonPesquisaPrincipio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisaPrincipio.Image = global::RemediosWinForm.Properties.Resources.Find_24;
            this.buttonPesquisaPrincipio.Location = new System.Drawing.Point(432, 186);
            this.buttonPesquisaPrincipio.Name = "buttonPesquisaPrincipio";
            this.buttonPesquisaPrincipio.Size = new System.Drawing.Size(41, 37);
            this.buttonPesquisaPrincipio.TabIndex = 4;
            this.buttonPesquisaPrincipio.Tag = "Principio";
            this.toolTip.SetToolTip(this.buttonPesquisaPrincipio, "Procurar");
            this.buttonPesquisaPrincipio.UseVisualStyleBackColor = true;
            this.buttonPesquisaPrincipio.Click += new System.EventHandler(this.buttonPesquisaPrincipio_Click);
            // 
            // ckbPrincipios
            // 
            this.ckbPrincipios.FormattingEnabled = true;
            this.ckbPrincipios.Location = new System.Drawing.Point(21, 78);
            this.ckbPrincipios.Name = "ckbPrincipios";
            this.ckbPrincipios.Size = new System.Drawing.Size(407, 149);
            this.ckbPrincipios.TabIndex = 1;
            this.ckbPrincipios.Tag = "Principio";
            this.ckbPrincipios.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ckbPrincipios_ItemCheck);
            // 
            // bnavAnvisaRemedio
            // 
            this.bnavAnvisaRemedio.AddNewItem = null;
            this.bnavAnvisaRemedio.BindingSource = this.bsAnvisaRemedio;
            this.bnavAnvisaRemedio.CountItem = this.bindingNavigatorCountItem;
            this.bnavAnvisaRemedio.DeleteItem = null;
            this.bnavAnvisaRemedio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnavAnvisaRemedio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bnavAnvisaRemedio.Location = new System.Drawing.Point(0, 0);
            this.bnavAnvisaRemedio.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnavAnvisaRemedio.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnavAnvisaRemedio.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnavAnvisaRemedio.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnavAnvisaRemedio.Name = "bnavAnvisaRemedio";
            this.bnavAnvisaRemedio.PositionItem = this.bindingNavigatorPositionItem;
            this.bnavAnvisaRemedio.Size = new System.Drawing.Size(1220, 27);
            this.bnavAnvisaRemedio.TabIndex = 3;
            this.bnavAnvisaRemedio.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(46, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // frmAnvisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1220, 698);
            this.Controls.Add(this.bnavAnvisaRemedio);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmAnvisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anvisa";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnvisaRemedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnvisaRemedio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnavAnvisaRemedio)).EndInit();
            this.bnavAnvisaRemedio.ResumeLayout(false);
            this.bnavAnvisaRemedio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckedListBox ckbPrincipios;
        private System.Windows.Forms.Button buttonPesquisaPrincipio;
        private SuperGrid.SuperDGV dgvAnvisaRemedio;
        private System.Windows.Forms.BindingSource bsAnvisaRemedio;
        private System.Windows.Forms.BindingNavigator bnavAnvisaRemedio;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUncheck;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matches;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrincipioAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.RadioButton radioButtonPrincipio;
        private System.Windows.Forms.RadioButton radioButtonProduto;
        private System.Windows.Forms.RadioButton radioButtonClasse;
        private System.Windows.Forms.Label labelProcurar;
        private System.Windows.Forms.ComboBox comboBoxProcurar;
    }
}