namespace Desafio2
{
    partial class Desafio2
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbLimites = new System.Windows.Forms.GroupBox();
            this.txbMaxValue = new System.Windows.Forms.TextBox();
            this.txbMinValue = new System.Windows.Forms.TextBox();
            this.cbTipos = new System.Windows.Forms.ComboBox();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.lblTipos = new System.Windows.Forms.Label();
            this.gpbLimites.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLimites
            // 
            this.gpbLimites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbLimites.Controls.Add(this.txbMaxValue);
            this.gpbLimites.Controls.Add(this.txbMinValue);
            this.gpbLimites.Controls.Add(this.cbTipos);
            this.gpbLimites.Controls.Add(this.lblMaxValue);
            this.gpbLimites.Controls.Add(this.lblMinValue);
            this.gpbLimites.Controls.Add(this.lblTipos);
            this.gpbLimites.Location = new System.Drawing.Point(12, 12);
            this.gpbLimites.Name = "gpbLimites";
            this.gpbLimites.Size = new System.Drawing.Size(360, 122);
            this.gpbLimites.TabIndex = 0;
            this.gpbLimites.TabStop = false;
            this.gpbLimites.Text = "Limites das Variáveis";
            // 
            // txbMaxValue
            // 
            this.txbMaxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMaxValue.BackColor = System.Drawing.SystemColors.Control;
            this.txbMaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaxValue.ForeColor = System.Drawing.Color.Red;
            this.txbMaxValue.Location = new System.Drawing.Point(96, 86);
            this.txbMaxValue.Name = "txbMaxValue";
            this.txbMaxValue.ReadOnly = true;
            this.txbMaxValue.Size = new System.Drawing.Size(251, 20);
            this.txbMaxValue.TabIndex = 5;
            // 
            // txbMinValue
            // 
            this.txbMinValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMinValue.BackColor = System.Drawing.SystemColors.Control;
            this.txbMinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMinValue.ForeColor = System.Drawing.Color.Green;
            this.txbMinValue.Location = new System.Drawing.Point(96, 60);
            this.txbMinValue.Name = "txbMinValue";
            this.txbMinValue.ReadOnly = true;
            this.txbMinValue.Size = new System.Drawing.Size(251, 20);
            this.txbMinValue.TabIndex = 4;
            // 
            // cbTipos
            // 
            this.cbTipos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipos.FormattingEnabled = true;
            this.cbTipos.Location = new System.Drawing.Point(96, 33);
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Size = new System.Drawing.Size(251, 21);
            this.cbTipos.TabIndex = 3;
            this.cbTipos.SelectedIndexChanged += new System.EventHandler(this.cbTipos_SelectedIndexChanged);
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(33, 89);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(57, 13);
            this.lblMaxValue.TabIndex = 2;
            this.lblMaxValue.Text = "Max Value";
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(36, 63);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(54, 13);
            this.lblMinValue.TabIndex = 1;
            this.lblMinValue.Text = "Min Value";
            // 
            // lblTipos
            // 
            this.lblTipos.AutoSize = true;
            this.lblTipos.Location = new System.Drawing.Point(6, 36);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(84, 13);
            this.lblTipos.TabIndex = 0;
            this.lblTipos.Text = "Tipo de Variável";
            // 
            // Desafio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 146);
            this.Controls.Add(this.gpbLimites);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Desafio2";
            this.Text = "Desafio 2";
            this.gpbLimites.ResumeLayout(false);
            this.gpbLimites.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLimites;
        private System.Windows.Forms.TextBox txbMaxValue;
        private System.Windows.Forms.TextBox txbMinValue;
        private System.Windows.Forms.ComboBox cbTipos;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.Label lblTipos;
    }
}

