
namespace Parcial1_HorisbergerMatias
{
    partial class Viajes_HorisbergerMatias
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
            this.dataViajes = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViajes
            // 
            this.dataViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViajes.Location = new System.Drawing.Point(6, 7);
            this.dataViajes.Name = "dataViajes";
            this.dataViajes.RowTemplate.Height = 25;
            this.dataViajes.Size = new System.Drawing.Size(1203, 478);
            this.dataViajes.TabIndex = 0;
            this.dataViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViajes_CellContentClick);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Square721 BT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(12, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Crear Viaje";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Square721 BT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(970, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ver Pasajeros";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Viajes_HorisbergerMatias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1215, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataViajes);
            this.Name = "Viajes_HorisbergerMatias";
            this.Text = "Viajes Disponibles";
            this.Load += new System.EventHandler(this.Viajes_HorisbergerMatias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViajes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}