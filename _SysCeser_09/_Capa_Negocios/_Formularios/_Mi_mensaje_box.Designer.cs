namespace _Capa_Negocios
{
    partial class _Mi_mensaje_box
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_Mi_mensaje_box));
            this.btn_no = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_si = new System.Windows.Forms.Button();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_no
            // 
            this.btn_no.BackColor = System.Drawing.Color.Transparent;
            this.btn_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_no.Image = global::_Capa_Negocios.Properties.Resources.cancelar_16x16;
            this.btn_no.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_no.Location = new System.Drawing.Point(240, 72);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(93, 23);
            this.btn_no.TabIndex = 10;
            this.btn_no.Text = "No";
            this.btn_no.UseVisualStyleBackColor = false;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_si
            // 
            this.btn_si.BackColor = System.Drawing.Color.Transparent;
            this.btn_si.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_si.Image = global::_Capa_Negocios.Properties.Resources.seleccionar_16x16;
            this.btn_si.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_si.Location = new System.Drawing.Point(119, 72);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(93, 23);
            this.btn_si.TabIndex = 8;
            this.btn_si.Text = "Si";
            this.btn_si.UseVisualStyleBackColor = false;
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click_1);
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(0, 31);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(466, 33);
            this.lbl_mensaje.TabIndex = 7;
            this.lbl_mensaje.Text = "Mensaje";
            this.lbl_mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _Mi_mensaje_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(466, 113);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_si);
            this.Controls.Add(this.lbl_mensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "_Mi_mensaje_box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_si;
        private System.Windows.Forms.Label lbl_mensaje;
    }
}