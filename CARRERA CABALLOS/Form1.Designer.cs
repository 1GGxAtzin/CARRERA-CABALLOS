namespace CARRERA_CABALLOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.caballo1 = new System.Windows.Forms.PictureBox();
            this.caballo2 = new System.Windows.Forms.PictureBox();
            this.caballo3 = new System.Windows.Forms.PictureBox();
            this.caballo4 = new System.Windows.Forms.PictureBox();
            this.caballo5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Caballo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Asap", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1210, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "REINICIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Asap", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1210, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "INICIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1182, 409);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Asap", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "CARRERA DE CABALLOS";
            // 
            // caballo1
            // 
            this.caballo1.BackColor = System.Drawing.Color.Transparent;
            this.caballo1.Image = ((System.Drawing.Image)(resources.GetObject("caballo1.Image")));
            this.caballo1.Location = new System.Drawing.Point(22, 167);
            this.caballo1.Name = "caballo1";
            this.caballo1.Size = new System.Drawing.Size(150, 65);
            this.caballo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caballo1.TabIndex = 9;
            this.caballo1.TabStop = false;
            // 
            // caballo2
            // 
            this.caballo2.BackColor = System.Drawing.Color.Transparent;
            this.caballo2.Image = ((System.Drawing.Image)(resources.GetObject("caballo2.Image")));
            this.caballo2.Location = new System.Drawing.Point(22, 249);
            this.caballo2.Name = "caballo2";
            this.caballo2.Size = new System.Drawing.Size(150, 65);
            this.caballo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caballo2.TabIndex = 11;
            this.caballo2.TabStop = false;
            // 
            // caballo3
            // 
            this.caballo3.BackColor = System.Drawing.Color.Transparent;
            this.caballo3.Image = ((System.Drawing.Image)(resources.GetObject("caballo3.Image")));
            this.caballo3.Location = new System.Drawing.Point(22, 331);
            this.caballo3.Name = "caballo3";
            this.caballo3.Size = new System.Drawing.Size(150, 65);
            this.caballo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caballo3.TabIndex = 12;
            this.caballo3.TabStop = false;
            // 
            // caballo4
            // 
            this.caballo4.BackColor = System.Drawing.Color.Transparent;
            this.caballo4.Image = ((System.Drawing.Image)(resources.GetObject("caballo4.Image")));
            this.caballo4.Location = new System.Drawing.Point(22, 411);
            this.caballo4.Name = "caballo4";
            this.caballo4.Size = new System.Drawing.Size(150, 65);
            this.caballo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caballo4.TabIndex = 13;
            this.caballo4.TabStop = false;
            // 
            // caballo5
            // 
            this.caballo5.BackColor = System.Drawing.Color.Transparent;
            this.caballo5.Image = ((System.Drawing.Image)(resources.GetObject("caballo5.Image")));
            this.caballo5.Location = new System.Drawing.Point(22, 456);
            this.caballo5.Name = "caballo5";
            this.caballo5.Size = new System.Drawing.Size(150, 65);
            this.caballo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caballo5.TabIndex = 14;
            this.caballo5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Asap", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Asap", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Asap", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Asap", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Asap", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caballo,
            this.Posición});
            this.dataGridView1.Location = new System.Drawing.Point(1210, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(211, 208);
            this.dataGridView1.TabIndex = 20;
            // 
            // Caballo
            // 
            this.Caballo.HeaderText = "Caballo";
            this.Caballo.Name = "Caballo";
            // 
            // Posición
            // 
            this.Posición.HeaderText = "Posición";
            this.Posición.Name = "Posición";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1433, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caballo2);
            this.Controls.Add(this.caballo1);
            this.Controls.Add(this.caballo5);
            this.Controls.Add(this.caballo4);
            this.Controls.Add(this.caballo3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox caballo1;
        public System.Windows.Forms.PictureBox caballo2;
        public System.Windows.Forms.PictureBox caballo3;
        public System.Windows.Forms.PictureBox caballo4;
        public System.Windows.Forms.PictureBox caballo5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caballo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posición;
    }
}

