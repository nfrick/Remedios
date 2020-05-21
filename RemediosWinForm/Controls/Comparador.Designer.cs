namespace RemediosWinForm {
    partial class Comparador {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remedioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.principiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indicacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.veterinarioCheckBox = new System.Windows.Forms.CheckBox();
            this.humanoCheckBox = new System.Windows.Forms.CheckBox();
            this.dgvPrincipios = new SuperGrid.SuperDGV();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIndicacoes = new SuperGrid.SuperDGV();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxRemedio = new System.Windows.Forms.ComboBox();
            this.dgvCategorias = new SuperGrid.SuperDGV();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabelBula = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remedioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.remedioBindingSource;
            // 
            // remedioBindingSource
            // 
            this.remedioBindingSource.DataSource = typeof(DataLayer.Remedio);
            // 
            // principiosBindingSource
            // 
            this.principiosBindingSource.DataMember = "Principios";
            this.principiosBindingSource.DataSource = this.remedioBindingSource;
            // 
            // indicacoesBindingSource
            // 
            this.indicacoesBindingSource.DataMember = "Indicacoes";
            this.indicacoesBindingSource.DataSource = this.remedioBindingSource;
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remedioBindingSource, "Link", true));
            this.linkLinkLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.linkLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLinkLabel.Location = new System.Drawing.Point(11, 41);
            this.linkLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(462, 30);
            this.linkLinkLabel.TabIndex = 24;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "link";
            this.linkLinkLabel.Visible = false;
            this.linkLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLinkLabel_LinkClicked);
            // 
            // veterinarioCheckBox
            // 
            this.veterinarioCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.veterinarioCheckBox.AutoCheck = false;
            this.veterinarioCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.remedioBindingSource, "Veterinario", true));
            this.veterinarioCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.veterinarioCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.veterinarioCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veterinarioCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.veterinarioCheckBox.Image = global::RemediosWinForm.Properties.Resources.dog_face_icon;
            this.veterinarioCheckBox.Location = new System.Drawing.Point(248, 588);
            this.veterinarioCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.veterinarioCheckBox.Name = "veterinarioCheckBox";
            this.veterinarioCheckBox.Size = new System.Drawing.Size(208, 51);
            this.veterinarioCheckBox.TabIndex = 23;
            this.veterinarioCheckBox.Text = "Veterinário";
            this.veterinarioCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.veterinarioCheckBox.UseVisualStyleBackColor = true;
            this.veterinarioCheckBox.Visible = false;
            // 
            // humanoCheckBox
            // 
            this.humanoCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.humanoCheckBox.AutoCheck = false;
            this.humanoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.remedioBindingSource, "Humano", true));
            this.humanoCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.humanoCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.humanoCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanoCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.humanoCheckBox.Image = global::RemediosWinForm.Properties.Resources.Person_icon;
            this.humanoCheckBox.Location = new System.Drawing.Point(32, 588);
            this.humanoCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.humanoCheckBox.Name = "humanoCheckBox";
            this.humanoCheckBox.Size = new System.Drawing.Size(208, 51);
            this.humanoCheckBox.TabIndex = 22;
            this.humanoCheckBox.Text = "Humano";
            this.humanoCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.humanoCheckBox.UseVisualStyleBackColor = true;
            this.humanoCheckBox.Visible = false;
            // 
            // dgvPrincipios
            // 
            this.dgvPrincipios.AllowUserToAddRows = false;
            this.dgvPrincipios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPrincipios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPrincipios.AutoGenerateColumns = false;
            this.dgvPrincipios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrincipios.BackgroundColor = System.Drawing.Color.Black;
            this.dgvPrincipios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrincipios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPrincipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvPrincipios.DataSource = this.principiosBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrincipios.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPrincipios.EnableHeadersVisualStyles = false;
            this.dgvPrincipios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPrincipios.Location = new System.Drawing.Point(11, 196);
            this.dgvPrincipios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPrincipios.Name = "dgvPrincipios";
            this.dgvPrincipios.ReadOnly = true;
            this.dgvPrincipios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrincipios.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPrincipios.RowHeadersVisible = false;
            this.dgvPrincipios.RowHeadersWidth = 20;
            this.dgvPrincipios.RowTemplate.Height = 24;
            this.dgvPrincipios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPrincipios.Size = new System.Drawing.Size(462, 172);
            this.dgvPrincipios.TabIndex = 21;
            this.dgvPrincipios.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn5.HeaderText = "Princípio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Dose";
            this.dataGridViewTextBoxColumn6.HeaderText = "Dose";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dgvIndicacoes
            // 
            this.dgvIndicacoes.AllowUserToAddRows = false;
            this.dgvIndicacoes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvIndicacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvIndicacoes.AutoGenerateColumns = false;
            this.dgvIndicacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIndicacoes.BackgroundColor = System.Drawing.Color.Black;
            this.dgvIndicacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIndicacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvIndicacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndicacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7});
            this.dgvIndicacoes.DataSource = this.indicacoesBindingSource;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIndicacoes.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvIndicacoes.EnableHeadersVisualStyles = false;
            this.dgvIndicacoes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvIndicacoes.Location = new System.Drawing.Point(11, 372);
            this.dgvIndicacoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvIndicacoes.Name = "dgvIndicacoes";
            this.dgvIndicacoes.ReadOnly = true;
            this.dgvIndicacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIndicacoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvIndicacoes.RowHeadersVisible = false;
            this.dgvIndicacoes.RowHeadersWidth = 20;
            this.dgvIndicacoes.RowTemplate.Height = 24;
            this.dgvIndicacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvIndicacoes.Size = new System.Drawing.Size(462, 206);
            this.dgvIndicacoes.TabIndex = 20;
            this.dgvIndicacoes.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn7.HeaderText = "Indicações";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // comboBoxRemedio
            // 
            this.comboBoxRemedio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxRemedio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxRemedio.DisplayMember = "NomeApresentacao";
            this.comboBoxRemedio.FormattingEnabled = true;
            this.comboBoxRemedio.Location = new System.Drawing.Point(11, 3);
            this.comboBoxRemedio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxRemedio.Name = "comboBoxRemedio";
            this.comboBoxRemedio.Size = new System.Drawing.Size(460, 36);
            this.comboBoxRemedio.TabIndex = 19;
            this.comboBoxRemedio.ValueMember = "ID";
            this.comboBoxRemedio.SelectedIndexChanged += new System.EventHandler(this.comboBoxRemedio_SelectedIndexChanged);
            this.comboBoxRemedio.TextChanged += new System.EventHandler(this.comboBoxRemedio_TextChanged);
            // 
            // dgvCategorias
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvCategorias.AutoGenerateColumns = false;
            this.dgvCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.Black;
            this.dgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.dgvCategorias.DataSource = this.categoriasBindingSource;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCategorias.Location = new System.Drawing.Point(11, 74);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvCategorias.RowHeadersWidth = 20;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(457, 119);
            this.dgvCategorias.TabIndex = 25;
            this.dgvCategorias.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Categorias";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // linkLabelBula
            // 
            this.linkLabelBula.ForeColor = System.Drawing.SystemColors.Control;
            this.linkLabelBula.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabelBula.Location = new System.Drawing.Point(11, 644);
            this.linkLabelBula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelBula.Name = "linkLabelBula";
            this.linkLabelBula.Size = new System.Drawing.Size(462, 30);
            this.linkLabelBula.TabIndex = 26;
            this.linkLabelBula.TabStop = true;
            this.linkLabelBula.Text = "Bula";
            this.linkLabelBula.Visible = false;
            this.linkLabelBula.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabelBula.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBula_LinkClicked);
            // 
            // Comparador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.linkLabelBula);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.linkLinkLabel);
            this.Controls.Add(this.veterinarioCheckBox);
            this.Controls.Add(this.humanoCheckBox);
            this.Controls.Add(this.dgvPrincipios);
            this.Controls.Add(this.dgvIndicacoes);
            this.Controls.Add(this.comboBoxRemedio);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Comparador";
            this.Size = new System.Drawing.Size(486, 681);
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remedioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource remedioBindingSource;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.BindingSource principiosBindingSource;
        private System.Windows.Forms.BindingSource indicacoesBindingSource;
        private System.Windows.Forms.LinkLabel linkLinkLabel;
        private System.Windows.Forms.CheckBox veterinarioCheckBox;
        private System.Windows.Forms.CheckBox humanoCheckBox;
        private SuperGrid.SuperDGV dgvPrincipios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private SuperGrid.SuperDGV dgvIndicacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox comboBoxRemedio;
        private SuperGrid.SuperDGV dgvCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.LinkLabel linkLabelBula;
    }
}
