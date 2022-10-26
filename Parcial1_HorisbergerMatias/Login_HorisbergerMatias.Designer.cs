
namespace Parcial1_HorisbergerMatias
{
    partial class Login_HorisbergerMatias
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_HorisbergerMatias));
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.panelAyuda = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarAyuda = new System.Windows.Forms.Button();
            this.lblAyuda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelAyuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContrasenia
            // 
            resources.ApplyResources(this.txtContrasenia, "txtContrasenia");
            this.txtContrasenia.BackColor = System.Drawing.Color.LightGray;
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasenia.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtUsuario.Name = "txtUsuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.BackColor = System.Drawing.Color.Silver;
            this.lblError.Name = "lblError";
            // 
            // btnAyuda
            // 
            resources.ApplyResources(this.btnAyuda, "btnAyuda");
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // panelAyuda
            // 
            this.panelAyuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAyuda.Controls.Add(this.label2);
            this.panelAyuda.Controls.Add(this.btnCerrarAyuda);
            this.panelAyuda.Controls.Add(this.lblAyuda);
            resources.ApplyResources(this.panelAyuda, "panelAyuda");
            this.panelAyuda.Name = "panelAyuda";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnCerrarAyuda
            // 
            resources.ApplyResources(this.btnCerrarAyuda, "btnCerrarAyuda");
            this.btnCerrarAyuda.BackColor = System.Drawing.Color.DimGray;
            this.btnCerrarAyuda.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCerrarAyuda.Name = "btnCerrarAyuda";
            this.btnCerrarAyuda.UseVisualStyleBackColor = false;
            this.btnCerrarAyuda.Click += new System.EventHandler(this.btnCerrarAyuda_Click);
            // 
            // lblAyuda
            // 
            resources.ApplyResources(this.lblAyuda, "lblAyuda");
            this.lblAyuda.Name = "lblAyuda";
            // 
            // Login_HorisbergerMatias
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.panelAyuda);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Login_HorisbergerMatias";
            this.Load += new System.EventHandler(this.Login_HorisbergerMatias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelAyuda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel panelAyuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrarAyuda;
        private System.Windows.Forms.Label lblAyuda;
    }
}

