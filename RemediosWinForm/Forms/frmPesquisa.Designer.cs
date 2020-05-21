namespace RemediosWinForm {
    partial class frmPesquisa {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisa));
            this.checkedListBoxCategorias = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxIndicacoes = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxPrincipios = new System.Windows.Forms.CheckedListBox();
            this.dgvRemedios = new SuperGrid.SuperDGV();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrincipiosCSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRemedios = new System.Windows.Forms.BindingSource(this.components);
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelCategorias = new System.Windows.Forms.Label();
            this.labelIndicacoes = new System.Windows.Forms.Label();
            this.labelPrincipios = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bulaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nupQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxUsoHumano = new System.Windows.Forms.CheckBox();
            this.checkBoxUsoVeterinario = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemedios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRemedios)).BeginInit();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxCategorias
            // 
            this.checkedListBoxCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkedListBoxCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxCategorias.ForeColor = System.Drawing.SystemColors.Control;
            this.checkedListBoxCategorias.FormattingEnabled = true;
            this.checkedListBoxCategorias.Location = new System.Drawing.Point(4, 49);
            this.checkedListBoxCategorias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBoxCategorias.Name = "checkedListBoxCategorias";
            this.checkedListBoxCategorias.Size = new System.Drawing.Size(348, 153);
            this.checkedListBoxCategorias.TabIndex = 0;
            this.checkedListBoxCategorias.Tag = "Categorias";
            this.checkedListBoxCategorias.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxCategorias_ItemCheck);
            // 
            // checkedListBoxIndicacoes
            // 
            this.checkedListBoxIndicacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkedListBoxIndicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxIndicacoes.ForeColor = System.Drawing.SystemColors.Control;
            this.checkedListBoxIndicacoes.FormattingEnabled = true;
            this.checkedListBoxIndicacoes.Location = new System.Drawing.Point(360, 49);
            this.checkedListBoxIndicacoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBoxIndicacoes.Name = "checkedListBoxIndicacoes";
            this.checkedListBoxIndicacoes.Size = new System.Drawing.Size(348, 153);
            this.checkedListBoxIndicacoes.TabIndex = 1;
            this.checkedListBoxIndicacoes.Tag = "Indicações";
            this.checkedListBoxIndicacoes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxIndicacoes_ItemCheck);
            // 
            // checkedListBoxPrincipios
            // 
            this.checkedListBoxPrincipios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkedListBoxPrincipios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxPrincipios.ForeColor = System.Drawing.SystemColors.Control;
            this.checkedListBoxPrincipios.FormattingEnabled = true;
            this.checkedListBoxPrincipios.Location = new System.Drawing.Point(716, 49);
            this.checkedListBoxPrincipios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBoxPrincipios.Name = "checkedListBoxPrincipios";
            this.checkedListBoxPrincipios.Size = new System.Drawing.Size(360, 153);
            this.checkedListBoxPrincipios.TabIndex = 2;
            this.checkedListBoxPrincipios.Tag = "Princípios";
            this.checkedListBoxPrincipios.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxPrincipios_ItemCheck);
            // 
            // dgvRemedios
            // 
            this.dgvRemedios.AllowUserToAddRows = false;
            this.dgvRemedios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRemedios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRemedios.AutoGenerateColumns = false;
            this.dgvRemedios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRemedios.BackgroundColor = System.Drawing.Color.Black;
            this.dgvRemedios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemedios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRemedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemedios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.PrincipiosCSV});
            this.dgvRemedios.DataSource = this.bsRemedios;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRemedios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRemedios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRemedios.EnableHeadersVisualStyles = false;
            this.dgvRemedios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRemedios.Location = new System.Drawing.Point(0, 0);
            this.dgvRemedios.Name = "dgvRemedios";
            this.dgvRemedios.ReadOnly = true;
            this.dgvRemedios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemedios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRemedios.RowHeadersWidth = 20;
            this.dgvRemedios.RowTemplate.Height = 24;
            this.dgvRemedios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemedios.Size = new System.Drawing.Size(1074, 186);
            this.dgvRemedios.TabIndex = 4;
            this.dgvRemedios.DoubleClick += new System.EventHandler(this.dgvRemedios_DoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apresentacao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apresentação";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QtdUnidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Link";
            this.dataGridViewTextBoxColumn7.HeaderText = "Link";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // PrincipiosCSV
            // 
            this.PrincipiosCSV.DataPropertyName = "PrincipiosCSV";
            this.PrincipiosCSV.HeaderText = "Princípios";
            this.PrincipiosCSV.Name = "PrincipiosCSV";
            this.PrincipiosCSV.ReadOnly = true;
            // 
            // bsRemedios
            // 
            this.bsRemedios.DataSource = typeof(DataLayer.Remedio);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpMain.Controls.Add(this.checkedListBoxCategorias, 0, 2);
            this.tlpMain.Controls.Add(this.buttonSearch, 0, 4);
            this.tlpMain.Controls.Add(this.checkedListBoxIndicacoes, 1, 2);
            this.tlpMain.Controls.Add(this.checkedListBoxPrincipios, 2, 2);
            this.tlpMain.Controls.Add(this.labelCategorias, 0, 1);
            this.tlpMain.Controls.Add(this.labelIndicacoes, 1, 1);
            this.tlpMain.Controls.Add(this.labelPrincipios, 2, 1);
            this.tlpMain.Controls.Add(this.splitContainer1, 0, 5);
            this.tlpMain.Controls.Add(this.labelResultado, 1, 4);
            this.tlpMain.Controls.Add(this.panel1, 2, 4);
            this.tlpMain.Controls.Add(this.checkBoxUsoHumano, 0, 3);
            this.tlpMain.Controls.Add(this.checkBoxUsoVeterinario, 1, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 6;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpMain.Size = new System.Drawing.Size(1080, 688);
            this.tlpMain.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Image = global::RemediosWinForm.Properties.Resources.Search_icon;
            this.buttonSearch.Location = new System.Drawing.Point(3, 260);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(350, 44);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Pesquisar";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelCategorias
            // 
            this.labelCategorias.AutoSize = true;
            this.labelCategorias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCategorias.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorias.Location = new System.Drawing.Point(3, 4);
            this.labelCategorias.Name = "labelCategorias";
            this.labelCategorias.Size = new System.Drawing.Size(350, 40);
            this.labelCategorias.TabIndex = 6;
            this.labelCategorias.Text = "Categorias";
            this.labelCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCategorias.DoubleClick += new System.EventHandler(this.labelCategorias_DoubleClick);
            // 
            // labelIndicacoes
            // 
            this.labelIndicacoes.AutoSize = true;
            this.labelIndicacoes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelIndicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIndicacoes.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndicacoes.Location = new System.Drawing.Point(359, 4);
            this.labelIndicacoes.Name = "labelIndicacoes";
            this.labelIndicacoes.Size = new System.Drawing.Size(350, 40);
            this.labelIndicacoes.TabIndex = 7;
            this.labelIndicacoes.Text = "Indicações";
            this.labelIndicacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIndicacoes.DoubleClick += new System.EventHandler(this.labelCategorias_DoubleClick);
            // 
            // labelPrincipios
            // 
            this.labelPrincipios.AutoSize = true;
            this.labelPrincipios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPrincipios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrincipios.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrincipios.Location = new System.Drawing.Point(715, 4);
            this.labelPrincipios.Name = "labelPrincipios";
            this.labelPrincipios.Size = new System.Drawing.Size(362, 40);
            this.labelPrincipios.TabIndex = 8;
            this.labelPrincipios.Text = "Princípios";
            this.labelPrincipios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPrincipios.DoubleClick += new System.EventHandler(this.labelCategorias_DoubleClick);
            // 
            // splitContainer1
            // 
            this.tlpMain.SetColumnSpan(this.splitContainer1, 3);
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 310);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvRemedios);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bulaRichTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1074, 375);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 9;
            // 
            // bulaRichTextBox
            // 
            this.bulaRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRemedios, "Bula", true));
            this.bulaRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bulaRichTextBox.ForeColor = System.Drawing.Color.Black;
            this.bulaRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.bulaRichTextBox.Name = "bulaRichTextBox";
            this.bulaRichTextBox.ReadOnly = true;
            this.bulaRichTextBox.Size = new System.Drawing.Size(1074, 185);
            this.bulaRichTextBox.TabIndex = 1;
            this.bulaRichTextBox.Text = "";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelResultado.Location = new System.Drawing.Point(359, 257);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(350, 50);
            this.labelResultado.TabIndex = 10;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nupQuantidade);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(715, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 44);
            this.panel1.TabIndex = 11;
            // 
            // nupQuantidade
            // 
            this.nupQuantidade.Location = new System.Drawing.Point(205, 0);
            this.nupQuantidade.Name = "nupQuantidade";
            this.nupQuantidade.Size = new System.Drawing.Size(60, 34);
            this.nupQuantidade.TabIndex = 1;
            this.nupQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(90, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade:";
            // 
            // checkBoxUsoHumano
            // 
            this.checkBoxUsoHumano.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxUsoHumano.AutoSize = true;
            this.checkBoxUsoHumano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxUsoHumano.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.checkBoxUsoHumano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxUsoHumano.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUsoHumano.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxUsoHumano.Image = global::RemediosWinForm.Properties.Resources.Person_icon;
            this.checkBoxUsoHumano.Location = new System.Drawing.Point(3, 210);
            this.checkBoxUsoHumano.Name = "checkBoxUsoHumano";
            this.checkBoxUsoHumano.Size = new System.Drawing.Size(350, 44);
            this.checkBoxUsoHumano.TabIndex = 12;
            this.checkBoxUsoHumano.Text = "Uso Humano";
            this.checkBoxUsoHumano.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxUsoHumano.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxUsoHumano.UseVisualStyleBackColor = true;
            // 
            // checkBoxUsoVeterinario
            // 
            this.checkBoxUsoVeterinario.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxUsoVeterinario.AutoSize = true;
            this.checkBoxUsoVeterinario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxUsoVeterinario.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBoxUsoVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxUsoVeterinario.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUsoVeterinario.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxUsoVeterinario.Image = global::RemediosWinForm.Properties.Resources.dog_face_icon;
            this.checkBoxUsoVeterinario.Location = new System.Drawing.Point(359, 210);
            this.checkBoxUsoVeterinario.Name = "checkBoxUsoVeterinario";
            this.checkBoxUsoVeterinario.Size = new System.Drawing.Size(350, 44);
            this.checkBoxUsoVeterinario.TabIndex = 13;
            this.checkBoxUsoVeterinario.Text = "Uso Veterinário";
            this.checkBoxUsoVeterinario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxUsoVeterinario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxUsoVeterinario.UseVisualStyleBackColor = true;
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1080, 688);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemedios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRemedios)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxCategorias;
        private System.Windows.Forms.CheckedListBox checkedListBoxIndicacoes;
        private System.Windows.Forms.CheckedListBox checkedListBoxPrincipios;
        private System.Windows.Forms.BindingSource bsRemedios;
        private SuperGrid.SuperDGV dgvRemedios;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label labelCategorias;
        private System.Windows.Forms.Label labelIndicacoes;
        private System.Windows.Forms.Label labelPrincipios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrincipiosCSV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox bulaRichTextBox;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nupQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxUsoHumano;
        private System.Windows.Forms.CheckBox checkBoxUsoVeterinario;
    }
}