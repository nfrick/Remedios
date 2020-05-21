namespace RemediosWinForm {
    partial class frmComparacao {
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
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remedioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.principiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indicacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comparador2 = new RemediosWinForm.Comparador();
            this.comparador1 = new RemediosWinForm.Comparador();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remedioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicacoesBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comparador2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comparador1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(987, 684);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // comparador2
            // 
            this.comparador2.BackColor = System.Drawing.SystemColors.ControlText;
            this.comparador2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comparador2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comparador2.Location = new System.Drawing.Point(497, 5);
            this.comparador2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comparador2.Name = "comparador2";
            this.comparador2.Size = new System.Drawing.Size(486, 674);
            this.comparador2.TabIndex = 1;
            // 
            // comparador1
            // 
            this.comparador1.BackColor = System.Drawing.SystemColors.ControlText;
            this.comparador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comparador1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comparador1.Location = new System.Drawing.Point(4, 5);
            this.comparador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comparador1.Name = "comparador1";
            this.comparador1.Size = new System.Drawing.Size(485, 674);
            this.comparador1.TabIndex = 0;
            // 
            // frmComparacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(987, 684);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmComparacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparação";
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remedioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicacoesBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource remedioBindingSource;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.BindingSource principiosBindingSource;
        private System.Windows.Forms.BindingSource indicacoesBindingSource;
        private Comparador comparador1;
        private Comparador comparador2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}