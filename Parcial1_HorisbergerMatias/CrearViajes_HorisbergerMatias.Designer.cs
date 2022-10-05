
namespace Parcial1_HorisbergerMatias
{
    partial class CrearViajes_HorisbergerMatias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearViajes_HorisbergerMatias));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCrucero = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkExtraRegional = new System.Windows.Forms.CheckBox();
            this.chkRegional = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fecFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(170, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crucero:";
            // 
            // cmbCrucero
            // 
            this.cmbCrucero.FormattingEnabled = true;
            this.cmbCrucero.Location = new System.Drawing.Point(264, 17);
            this.cmbCrucero.Name = "cmbCrucero";
            this.cmbCrucero.Size = new System.Drawing.Size(144, 23);
            this.cmbCrucero.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.chkExtraRegional);
            this.panel1.Controls.Add(this.chkRegional);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.fecFecha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbDestino);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbOrigen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbCrucero);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 293);
            this.panel1.TabIndex = 10;
            // 
            // chkExtraRegional
            // 
            this.chkExtraRegional.AutoSize = true;
            this.chkExtraRegional.BackColor = System.Drawing.Color.Transparent;
            this.chkExtraRegional.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkExtraRegional.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkExtraRegional.Location = new System.Drawing.Point(476, 87);
            this.chkExtraRegional.Name = "chkExtraRegional";
            this.chkExtraRegional.Size = new System.Drawing.Size(108, 19);
            this.chkExtraRegional.TabIndex = 11;
            this.chkExtraRegional.Text = "Extra-Regional";
            this.chkExtraRegional.UseVisualStyleBackColor = false;
            // 
            // chkRegional
            // 
            this.chkRegional.AutoSize = true;
            this.chkRegional.BackColor = System.Drawing.Color.Transparent;
            this.chkRegional.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkRegional.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkRegional.Location = new System.Drawing.Point(383, 87);
            this.chkRegional.Name = "chkRegional";
            this.chkRegional.Size = new System.Drawing.Size(74, 19);
            this.chkRegional.TabIndex = 10;
            this.chkRegional.Text = "Regional";
            this.chkRegional.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Square721 BT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.SeaShell;
            this.button3.Location = new System.Drawing.Point(212, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "Crear Viaje";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(113, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de Partida:";
            // 
            // fecFecha
            // 
            this.fecFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fecFecha.Location = new System.Drawing.Point(283, 208);
            this.fecFecha.Name = "fecFecha";
            this.fecFecha.Size = new System.Drawing.Size(229, 23);
            this.fecFecha.TabIndex = 7;
            this.fecFecha.Value = new System.DateTime(2022, 10, 2, 22, 57, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(311, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destino:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(397, 58);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(176, 23);
            this.cmbDestino.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(49, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Origen:";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(126, 58);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(162, 23);
            this.cmbOrigen.TabIndex = 4;
            // 
            // CrearViajes_HorisbergerMatias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(633, 310);
            this.Controls.Add(this.panel1);
            this.Name = "CrearViajes_HorisbergerMatias";
            this.Text = "Crear Viaje";
            this.Load += new System.EventHandler(this.CrearViajes_HorisbergerMatias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCrucero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fecFecha;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chkExtraRegional;
        private System.Windows.Forms.CheckBox chkRegional;
    }
}