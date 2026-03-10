namespace Modul3_103022400026
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
            components = new System.ComponentModel.Container();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(374, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 31);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Celcius", "Farenheit", "Kelvin", "Reamur" });
            comboBox1.Location = new Point(39, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(653, 69);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 78);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 9;
            label1.Text = "Satuan Awal";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 91);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 10;
            label2.Text = "Nilai Awal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 189);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 11;
            label3.Text = "Nilai Akhir";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(374, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 31);
            textBox1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 189);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 13;
            label4.Text = "Satuan Akhir";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Celcius", "Frenheit", "Kelvin", "Reamur" });
            comboBox2.Location = new Point(39, 235);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 14;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox2;
    }
}
