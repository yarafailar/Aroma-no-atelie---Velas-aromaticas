namespace Aroma_no_atelie___Velas_aromaticas
{
    partial class FormVela
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
            this.txbtamanho = new System.Windows.Forms.TextBox();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.txbpreco = new System.Windows.Forms.TextBox();
            this.txbdescricao = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lbltamanho = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bttsalvar = new System.Windows.Forms.Button();
            this.ltvvela = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txbtamanho
            // 
            this.txbtamanho.Location = new System.Drawing.Point(127, 109);
            this.txbtamanho.Name = "txbtamanho";
            this.txbtamanho.Size = new System.Drawing.Size(258, 20);
            this.txbtamanho.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txbtamanho, "só utilize peso em gramas");
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(127, 79);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(258, 20);
            this.txbnome.TabIndex = 1;
            // 
            // txbpreco
            // 
            this.txbpreco.Location = new System.Drawing.Point(127, 242);
            this.txbpreco.Name = "txbpreco";
            this.txbpreco.Size = new System.Drawing.Size(258, 20);
            this.txbpreco.TabIndex = 2;
            // 
            // txbdescricao
            // 
            this.txbdescricao.Location = new System.Drawing.Point(127, 146);
            this.txbdescricao.MaxLength = 256;
            this.txbdescricao.Multiline = true;
            this.txbdescricao.Name = "txbdescricao";
            this.txbdescricao.Size = new System.Drawing.Size(258, 79);
            this.txbdescricao.TabIndex = 3;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(27, 82);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(74, 13);
            this.lblnome.TabIndex = 7;
            this.lblnome.Text = "Nome da Vela";
            // 
            // lbltamanho
            // 
            this.lbltamanho.AutoSize = true;
            this.lbltamanho.Location = new System.Drawing.Point(27, 109);
            this.lbltamanho.Name = "lbltamanho";
            this.lbltamanho.Size = new System.Drawing.Size(91, 13);
            this.lbltamanho.TabIndex = 8;
            this.lbltamanho.Text = "Tamanho da Vela";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(27, 249);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(100, 13);
            this.lblpreco.TabIndex = 9;
            this.lblpreco.Text = "Preço da Vela (R$):";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Location = new System.Drawing.Point(27, 146);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(94, 13);
            this.lbldescricao.TabIndex = 10;
            this.lbldescricao.Text = "Descricao da Vela";
            // 
            // bttsalvar
            // 
            this.bttsalvar.Location = new System.Drawing.Point(545, 377);
            this.bttsalvar.Name = "bttsalvar";
            this.bttsalvar.Size = new System.Drawing.Size(75, 23);
            this.bttsalvar.TabIndex = 11;
            this.bttsalvar.Text = "Salvar";
            this.bttsalvar.UseVisualStyleBackColor = true;
            this.bttsalvar.Click += new System.EventHandler(this.bttsalvar_Click);
            // 
            // ltvvela
            // 
            this.ltvvela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ltvvela.FullRowSelect = true;
            this.ltvvela.HideSelection = false;
            this.ltvvela.Location = new System.Drawing.Point(435, 79);
            this.ltvvela.Name = "ltvvela";
            this.ltvvela.Size = new System.Drawing.Size(604, 179);
            this.ltvvela.TabIndex = 12;
            this.ltvvela.UseCompatibleStateImageBehavior = false;
            this.ltvvela.View = System.Windows.Forms.View.Details;
            this.ltvvela.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltvvela_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tamanho";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descricao";
            this.columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Preço";
            // 
            // FormVela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1088, 496);
            this.Controls.Add(this.ltvvela);
            this.Controls.Add(this.bttsalvar);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lbltamanho);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txbdescricao);
            this.Controls.Add(this.txbpreco);
            this.Controls.Add(this.txbnome);
            this.Controls.Add(this.txbtamanho);
            this.Name = "FormVela";
            this.Text = "FormVela";
            this.Load += new System.EventHandler(this.FormVela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbtamanho;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.TextBox txbpreco;
        private System.Windows.Forms.TextBox txbdescricao;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbltamanho;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bttsalvar;
        private System.Windows.Forms.ListView ltvvela;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}