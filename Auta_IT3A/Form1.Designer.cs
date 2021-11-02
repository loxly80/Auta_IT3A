namespace Auta_IT3A
{
    partial class Form1
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
            this.btnPark = new System.Windows.Forms.Button();
            this.btnUnload = new System.Windows.Forms.Button();
            this.numUnloadStuff = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numLoadStuff = new System.Windows.Forms.NumericUpDown();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLoad3000 = new System.Windows.Forms.Button();
            this.btnLoad2000 = new System.Windows.Forms.Button();
            this.btnLoad1000 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaxWeight = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLoaded = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numMaxWeight = new System.Windows.Forms.NumericUpDown();
            this.txtMargue = new System.Windows.Forms.TextBox();
            this.btnStorno = new System.Windows.Forms.Button();
            this.btnCreateCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUnloadStuff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadStuff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPark
            // 
            this.btnPark.Location = new System.Drawing.Point(23, 411);
            this.btnPark.Name = "btnPark";
            this.btnPark.Size = new System.Drawing.Size(134, 37);
            this.btnPark.TabIndex = 1;
            this.btnPark.Text = "Zaparkovat";
            this.btnPark.UseVisualStyleBackColor = true;
            this.btnPark.Click += new System.EventHandler(this.btnPark_Click);
            // 
            // btnUnload
            // 
            this.btnUnload.Location = new System.Drawing.Point(23, 325);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(108, 37);
            this.btnUnload.TabIndex = 1;
            this.btnUnload.Text = "Vyložit";
            this.btnUnload.UseVisualStyleBackColor = true;
            this.btnUnload.Click += new System.EventHandler(this.btnUnload_Click);
            // 
            // numUnloadStuff
            // 
            this.numUnloadStuff.Location = new System.Drawing.Point(137, 329);
            this.numUnloadStuff.Name = "numUnloadStuff";
            this.numUnloadStuff.Size = new System.Drawing.Size(94, 31);
            this.numUnloadStuff.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "kg";
            // 
            // numLoadStuff
            // 
            this.numLoadStuff.Location = new System.Drawing.Point(308, 239);
            this.numLoadStuff.Name = "numLoadStuff";
            this.numLoadStuff.Size = new System.Drawing.Size(94, 31);
            this.numLoadStuff.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(194, 235);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(108, 37);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Naložit";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnLoad3000
            // 
            this.btnLoad3000.Location = new System.Drawing.Point(23, 235);
            this.btnLoad3000.Name = "btnLoad3000";
            this.btnLoad3000.Size = new System.Drawing.Size(165, 37);
            this.btnLoad3000.TabIndex = 1;
            this.btnLoad3000.Text = "Naložit 3000kg";
            this.btnLoad3000.UseVisualStyleBackColor = true;
            this.btnLoad3000.Click += new System.EventHandler(this.btnLoad3000_Click);
            // 
            // btnLoad2000
            // 
            this.btnLoad2000.Location = new System.Drawing.Point(194, 192);
            this.btnLoad2000.Name = "btnLoad2000";
            this.btnLoad2000.Size = new System.Drawing.Size(165, 37);
            this.btnLoad2000.TabIndex = 1;
            this.btnLoad2000.Text = "Naložit 2000kg";
            this.btnLoad2000.UseVisualStyleBackColor = true;
            this.btnLoad2000.Click += new System.EventHandler(this.btnLoad2000_Click);
            // 
            // btnLoad1000
            // 
            this.btnLoad1000.Location = new System.Drawing.Point(23, 192);
            this.btnLoad1000.Name = "btnLoad1000";
            this.btnLoad1000.Size = new System.Drawing.Size(165, 37);
            this.btnLoad1000.TabIndex = 1;
            this.btnLoad1000.Text = "Naložit 1000kg";
            this.btnLoad1000.UseVisualStyleBackColor = true;
            this.btnLoad1000.Click += new System.EventHandler(this.btnLoad1000_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(126, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "label6";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxWeight
            // 
            this.lblMaxWeight.BackColor = System.Drawing.Color.White;
            this.lblMaxWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaxWeight.Location = new System.Drawing.Point(126, 84);
            this.lblMaxWeight.Name = "lblMaxWeight";
            this.lblMaxWeight.Size = new System.Drawing.Size(200, 35);
            this.lblMaxWeight.TabIndex = 0;
            this.lblMaxWeight.Text = "label5";
            this.lblMaxWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarque
            // 
            this.lblMarque.BackColor = System.Drawing.Color.White;
            this.lblMarque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMarque.Location = new System.Drawing.Point(126, 36);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(200, 35);
            this.lblMarque.TabIndex = 0;
            this.lblMarque.Text = "label4";
            this.lblMarque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Náklad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nosnost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Značka";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblLoaded);
            this.groupBox1.Controls.Add(this.btnPark);
            this.groupBox1.Controls.Add(this.btnUnload);
            this.groupBox1.Controls.Add(this.numUnloadStuff);
            this.groupBox1.Controls.Add(this.numLoadStuff);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnLoad3000);
            this.groupBox1.Controls.Add(this.btnLoad2000);
            this.groupBox1.Controls.Add(this.btnLoad1000);
            this.groupBox1.Controls.Add(this.lblMaxWeight);
            this.groupBox1.Controls.Add(this.lblMarque);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 595);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "kg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(408, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "kg";
            // 
            // lblLoaded
            // 
            this.lblLoaded.BackColor = System.Drawing.Color.White;
            this.lblLoaded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoaded.Location = new System.Drawing.Point(126, 132);
            this.lblLoaded.Name = "lblLoaded";
            this.lblLoaded.Size = new System.Drawing.Size(200, 35);
            this.lblLoaded.TabIndex = 0;
            this.lblLoaded.Text = "label5";
            this.lblLoaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(531, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 554);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vytvořit auto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(724, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Smazat auto";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Nosnost";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Značka";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numMaxWeight);
            this.groupBox2.Controls.Add(this.txtMargue);
            this.groupBox2.Controls.Add(this.btnStorno);
            this.groupBox2.Controls.Add(this.btnCreateCar);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(539, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 196);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nový automobil";
            this.groupBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "kg";
            // 
            // numMaxWeight
            // 
            this.numMaxWeight.Location = new System.Drawing.Point(126, 87);
            this.numMaxWeight.Name = "numMaxWeight";
            this.numMaxWeight.Size = new System.Drawing.Size(94, 31);
            this.numMaxWeight.TabIndex = 2;
            this.numMaxWeight.ValueChanged += new System.EventHandler(this.numMaxWeight_ValueChanged);
            // 
            // txtMargue
            // 
            this.txtMargue.Location = new System.Drawing.Point(126, 35);
            this.txtMargue.Name = "txtMargue";
            this.txtMargue.Size = new System.Drawing.Size(200, 31);
            this.txtMargue.TabIndex = 2;
            this.txtMargue.TextChanged += new System.EventHandler(this.txtMargue_TextChanged);
            // 
            // btnStorno
            // 
            this.btnStorno.Location = new System.Drawing.Point(219, 141);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(107, 37);
            this.btnStorno.TabIndex = 1;
            this.btnStorno.Text = "Storno";
            this.btnStorno.UseVisualStyleBackColor = true;
            this.btnStorno.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Enabled = false;
            this.btnCreateCar.Location = new System.Drawing.Point(106, 141);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(107, 37);
            this.btnCreateCar.TabIndex = 1;
            this.btnCreateCar.Text = "Vytvořit";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 631);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUnloadStuff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadStuff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPark;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.NumericUpDown numUnloadStuff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numLoadStuff;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnLoad3000;
        private System.Windows.Forms.Button btnLoad2000;
        private System.Windows.Forms.Button btnLoad1000;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaxWeight;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLoaded;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMaxWeight;
        private System.Windows.Forms.TextBox txtMargue;
        private System.Windows.Forms.Button btnStorno;
        private System.Windows.Forms.Button btnCreateCar;
    }
}

