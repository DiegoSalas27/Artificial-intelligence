namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bnStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.board1 = new WindowsFormsApp1.Board();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.lblIterando = new System.Windows.Forms.Label();
            this.lblNoMejor = new System.Windows.Forms.Label();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudLatencia = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatencia)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ItemSize = new System.Drawing.Size(86, 21);
            this.tabControl1.Location = new System.Drawing.Point(40, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 527);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.nudLatencia);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lblAtaque);
            this.tabPage1.Controls.Add(this.lblNoMejor);
            this.tabPage1.Controls.Add(this.lblIterando);
            this.tabPage1.Controls.Add(this.lblPrueba);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(464, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HillClimbing";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(183, 10);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(92, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de reseteos:";
            // 
            // bnStart
            // 
            this.bnStart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bnStart.Location = new System.Drawing.Point(44, 558);
            this.bnStart.Margin = new System.Windows.Forms.Padding(4);
            this.bnStart.Name = "bnStart";
            this.bnStart.Size = new System.Drawing.Size(212, 30);
            this.bnStart.TabIndex = 0;
            this.bnStart.Text = "Resolver";
            this.bnStart.UseVisualStyleBackColor = true;
            this.bnStart.Click += new System.EventHandler(this.bnStart_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(296, 558);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Paso a paso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // board1
            // 
            this.board1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.board1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board1.Location = new System.Drawing.Point(539, 47);
            this.board1.Margin = new System.Windows.Forms.Padding(5);
            this.board1.Name = "board1";
            this.board1.Size = new System.Drawing.Size(547, 502);
            this.board1.TabIndex = 4;
            this.board1.Load += new System.EventHandler(this.board1_Load);
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.ForeColor = System.Drawing.Color.White;
            this.lblPrueba.Location = new System.Drawing.Point(7, 75);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(74, 17);
            this.lblPrueba.TabIndex = 4;
            this.lblPrueba.Text = "Prueba #: ";
            // 
            // lblIterando
            // 
            this.lblIterando.AutoSize = true;
            this.lblIterando.ForeColor = System.Drawing.Color.White;
            this.lblIterando.Location = new System.Drawing.Point(7, 136);
            this.lblIterando.Name = "lblIterando";
            this.lblIterando.Size = new System.Drawing.Size(121, 17);
            this.lblIterando.TabIndex = 5;
            this.lblIterando.Text = "Iterando columna:";
            // 
            // lblNoMejor
            // 
            this.lblNoMejor.AutoSize = true;
            this.lblNoMejor.ForeColor = System.Drawing.Color.White;
            this.lblNoMejor.Location = new System.Drawing.Point(7, 168);
            this.lblNoMejor.Name = "lblNoMejor";
            this.lblNoMejor.Size = new System.Drawing.Size(236, 17);
            this.lblNoMejor.TabIndex = 6;
            this.lblNoMejor.Text = "No se ha encontrado mejor solución";
            this.lblNoMejor.Visible = false;
            // 
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.ForeColor = System.Drawing.Color.White;
            this.lblAtaque.Location = new System.Drawing.Point(7, 105);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(195, 17);
            this.lblAtaque.TabIndex = 7;
            this.lblAtaque.Text = "Par de reinas que se atacan: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Número de reseteos:";
            this.label6.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Latencia:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nudLatencia
            // 
            this.nudLatencia.Location = new System.Drawing.Point(183, 41);
            this.nudLatencia.Margin = new System.Windows.Forms.Padding(4);
            this.nudLatencia.Name = "nudLatencia";
            this.nudLatencia.Size = new System.Drawing.Size(92, 22);
            this.nudLatencia.TabIndex = 10;
            this.nudLatencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1136, 607);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.board1);
            this.Controls.Add(this.bnStart);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1154, 654);
            this.MinimumSize = new System.Drawing.Size(1154, 654);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problema de las 8 reinas resuelto con Hillclimbing";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnStart;
        private Board board1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAtaque;
        private System.Windows.Forms.Label lblNoMejor;
        private System.Windows.Forms.Label lblIterando;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudLatencia;
    }
}

