namespace lab5IsHere
{
    partial class Form1
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnSaveXML = new System.Windows.Forms.Button();
            this.btnLoadXML = new System.Windows.Forms.Button();
            this.btnSaveBinary = new System.Windows.Forms.Button();
            this.btnLoadBinary = new System.Windows.Forms.Button();
            this.btnReflect = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.txtReflection = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReflection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
          
            this.txtA.Location = new System.Drawing.Point(92, 23);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
          
            this.txtB.Location = new System.Drawing.Point(92, 59);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(23, 26);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(56, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "Розмір A:";
            
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(23, 62);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(56, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "Розмір B:";
            
            this.btnSaveXML.Location = new System.Drawing.Point(216, 21);
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Size = new System.Drawing.Size(120, 23);
            this.btnSaveXML.TabIndex = 4;
            this.btnSaveXML.Text = "Зберегти в XML";
            this.btnSaveXML.UseVisualStyleBackColor = true;
            
            this.btnLoadXML.Location = new System.Drawing.Point(216, 57);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(120, 23);
            this.btnLoadXML.TabIndex = 5;
            this.btnLoadXML.Text = "Завантажити з XML";
            this.btnLoadXML.UseVisualStyleBackColor = true;
            
            this.btnSaveBinary.Location = new System.Drawing.Point(348, 21);
            this.btnSaveBinary.Name = "btnSaveBinary";
            this.btnSaveBinary.Size = new System.Drawing.Size(120, 23);
            this.btnSaveBinary.TabIndex = 6;
            this.btnSaveBinary.Text = "Зберегти в Binary";
            this.btnSaveBinary.UseVisualStyleBackColor = true;
            
            this.btnLoadBinary.Location = new System.Drawing.Point(348, 57);
            this.btnLoadBinary.Name = "btnLoadBinary";
            this.btnLoadBinary.Size = new System.Drawing.Size(120, 23);
            this.btnLoadBinary.TabIndex = 7;
            this.btnLoadBinary.Text = "Завантажити з Binary";
            this.btnLoadBinary.UseVisualStyleBackColor = true;
            
            this.btnReflect.Location = new System.Drawing.Point(480, 21);
            this.btnReflect.Name = "btnReflect";
            this.btnReflect.Size = new System.Drawing.Size(120, 59);
            this.btnReflect.TabIndex = 8;
            this.btnReflect.Text = "Рефлексія класу Ромб";
            this.btnReflect.UseVisualStyleBackColor = true;
            
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDraw.Location = new System.Drawing.Point(26, 95);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(166, 32);
            this.btnDraw.TabIndex = 9;
            this.btnDraw.Text = "Намалювати фігуру";
            this.btnDraw.UseVisualStyleBackColor = true;
            
            this.txtReflection.Location = new System.Drawing.Point(348, 120);
            this.txtReflection.Multiline = true;
            this.txtReflection.Name = "txtReflection";
            this.txtReflection.ReadOnly = true;
            this.txtReflection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReflection.Size = new System.Drawing.Size(252, 280);
            this.txtReflection.TabIndex = 10;
             
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(26, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 260);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            
            this.lblReflection.AutoSize = true;
            this.lblReflection.Location = new System.Drawing.Point(345, 100);
            this.lblReflection.Name = "lblReflection";
            this.lblReflection.Size = new System.Drawing.Size(123, 13);
            this.lblReflection.TabIndex = 12;
            this.lblReflection.Text = "Результати рефлексії:";
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 421);
            this.Controls.Add(this.lblReflection);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtReflection);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnReflect);
            this.Controls.Add(this.btnLoadBinary);
            this.Controls.Add(this.btnSaveBinary);
            this.Controls.Add(this.btnLoadXML);
            this.Controls.Add(this.btnSaveXML);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Лабораторна робота 5 - Серіалізація";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnSaveXML;
        private System.Windows.Forms.Button btnLoadXML;
        private System.Windows.Forms.Button btnSaveBinary;
        private System.Windows.Forms.Button btnLoadBinary;
        private System.Windows.Forms.Button btnReflect;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtReflection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReflection;
    }
}