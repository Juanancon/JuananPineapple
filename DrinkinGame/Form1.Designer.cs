namespace DrinkinGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.BOTONGIRO = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            this.SuspendLayout();
            // 
            // pic5
            // 
            this.pic5.Image = ((System.Drawing.Image)(resources.GetObject("pic5.Image")));
            this.pic5.Location = new System.Drawing.Point(151, 99);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(103, 105);
            this.pic5.TabIndex = 1;
            this.pic5.TabStop = false;
            this.pic5.Visible = false;
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(151, 99);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(103, 105);
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            this.pic1.Visible = false;
            // 
            // pic6
            // 
            this.pic6.Image = ((System.Drawing.Image)(resources.GetObject("pic6.Image")));
            this.pic6.Location = new System.Drawing.Point(151, 99);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(103, 105);
            this.pic6.TabIndex = 3;
            this.pic6.TabStop = false;
            this.pic6.Visible = false;
            // 
            // pic3
            // 
            this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
            this.pic3.Location = new System.Drawing.Point(151, 99);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(103, 105);
            this.pic3.TabIndex = 4;
            this.pic3.TabStop = false;
            this.pic3.Visible = false;
            // 
            // pic4
            // 
            this.pic4.Image = ((System.Drawing.Image)(resources.GetObject("pic4.Image")));
            this.pic4.Location = new System.Drawing.Point(151, 99);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(103, 105);
            this.pic4.TabIndex = 6;
            this.pic4.TabStop = false;
            this.pic4.Visible = false;
            // 
            // pic7
            // 
            this.pic7.Image = ((System.Drawing.Image)(resources.GetObject("pic7.Image")));
            this.pic7.Location = new System.Drawing.Point(151, 99);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(103, 105);
            this.pic7.TabIndex = 7;
            this.pic7.TabStop = false;
            this.pic7.Visible = false;
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(151, 99);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(103, 105);
            this.pic2.TabIndex = 8;
            this.pic2.TabStop = false;
            this.pic2.Visible = false;
            // 
            // pic8
            // 
            this.pic8.Image = ((System.Drawing.Image)(resources.GetObject("pic8.Image")));
            this.pic8.Location = new System.Drawing.Point(151, 99);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(103, 105);
            this.pic8.TabIndex = 9;
            this.pic8.TabStop = false;
            this.pic8.Visible = false;
            // 
            // BOTONGIRO
            // 
            this.BOTONGIRO.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOTONGIRO.ForeColor = System.Drawing.Color.Brown;
            this.BOTONGIRO.Location = new System.Drawing.Point(139, 241);
            this.BOTONGIRO.Name = "BOTONGIRO";
            this.BOTONGIRO.Size = new System.Drawing.Size(128, 68);
            this.BOTONGIRO.TabIndex = 10;
            this.BOTONGIRO.Text = "GIRAR!!!";
            this.BOTONGIRO.UseVisualStyleBackColor = true;
            this.BOTONGIRO.Click += new System.EventHandler(this.BOTONGIRO_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 6000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(428, 418);
            this.Controls.Add(this.BOTONGIRO);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pic5);
            this.Name = "Form1";
            this.Text = "EL JUEGO DE LA BOTELLA";
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.Button BOTONGIRO;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

