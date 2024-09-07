namespace DesktopProject
{
    partial class FrmVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehiculo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbVelocidad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(45, 346);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 1;
            this.lbEstado.Text = "Estado";
            // 
            // lbVelocidad
            // 
            this.lbVelocidad.AutoSize = true;
            this.lbVelocidad.Location = new System.Drawing.Point(360, 346);
            this.lbVelocidad.Name = "lbVelocidad";
            this.lbVelocidad.Size = new System.Drawing.Size(54, 13);
            this.lbVelocidad.TabIndex = 2;
            this.lbVelocidad.Text = "Velocidad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbVelocidad);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmVehiculo";
            this.Text = "FrmVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbVelocidad;
        private System.Windows.Forms.Button button1;
    }
}