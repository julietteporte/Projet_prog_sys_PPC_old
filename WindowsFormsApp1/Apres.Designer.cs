namespace WindowsFormsApp1
{
    partial class Apres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apres));
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(386, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 55);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(225, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 49);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Bilan de la simulation";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(4, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 37);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "Commande(s)";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 22);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(4, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 37);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "Client(s)";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(242, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(218, 22);
            this.textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(4, 182);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(182, 37);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "Plats préparés ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(242, 182);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(218, 22);
            this.textBox7.TabIndex = 22;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(4, 241);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(207, 37);
            this.textBox8.TabIndex = 23;
            this.textBox8.Text = "Chiffre d\'affaire";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(242, 241);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(218, 22);
            this.textBox9.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.61987F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.38013F));
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox11, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(189, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 376);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(4, 307);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(174, 37);
            this.textBox10.TabIndex = 25;
            this.textBox10.Text = "Temps";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(242, 307);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(218, 22);
            this.textBox11.TabIndex = 26;
            // 
            // Apres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Apres";
            this.Text = "Apres";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
    }
}