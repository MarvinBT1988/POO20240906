﻿namespace DesktopProject
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbVelocidad = new System.Windows.Forms.Label();
            this.btnEncender = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnFrenar = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLuces = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesktopProject.Properties.Resources.sedan;
            this.pictureBox1.Location = new System.Drawing.Point(32, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.lbVelocidad.Click += new System.EventHandler(this.lbVelocidad_Click);
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(482, 111);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(92, 27);
            this.btnEncender.TabIndex = 3;
            this.btnEncender.Text = "Encender";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(580, 111);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(92, 27);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(482, 144);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(92, 27);
            this.btnAcelerar.TabIndex = 5;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // btnFrenar
            // 
            this.btnFrenar.Location = new System.Drawing.Point(580, 144);
            this.btnFrenar.Name = "btnFrenar";
            this.btnFrenar.Size = new System.Drawing.Size(92, 27);
            this.btnFrenar.TabIndex = 6;
            this.btnFrenar.Text = "Frenar";
            this.btnFrenar.UseVisualStyleBackColor = true;
            this.btnFrenar.Click += new System.EventHandler(this.btnFrenar_Click);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(482, 247);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(190, 27);
            this.btnOnOff.TabIndex = 7;
            this.btnOnOff.Text = "ON/ OFF";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Luces";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Velocidad";
            // 
            // lbLuces
            // 
            this.lbLuces.AutoSize = true;
            this.lbLuces.Location = new System.Drawing.Point(479, 288);
            this.lbLuces.Name = "lbLuces";
            this.lbLuces.Size = new System.Drawing.Size(0, 13);
            this.lbLuces.TabIndex = 10;
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 404);
            this.Controls.Add(this.lbLuces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.btnFrenar);
            this.Controls.Add(this.btnAcelerar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.lbVelocidad);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "FrmVehiculo";
            this.Text = "FrmVehiculo";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbVelocidad;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.Button btnFrenar;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLuces;
    }
}