namespace FractalTree
{
    partial class Window1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.length_scale_value = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTheta_value = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.length_value = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.depth_value = new System.Windows.Forms.NumericUpDown();
            this.draw_btn = new System.Windows.Forms.Button();
            this.proggres_bar = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.length_scale_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTheta_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth_value)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.proggres_bar);
            this.panel1.Controls.Add(this.length_scale_value);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DTheta_value);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.length_value);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.depth_value);
            this.panel1.Controls.Add(this.draw_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 97);
            this.panel1.TabIndex = 1;
            // 
            // length_scale_value
            // 
            this.length_scale_value.DecimalPlaces = 1;
            this.length_scale_value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.length_scale_value.Location = new System.Drawing.Point(329, 8);
            this.length_scale_value.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            this.length_scale_value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.length_scale_value.Name = "length_scale_value";
            this.length_scale_value.Size = new System.Drawing.Size(56, 22);
            this.length_scale_value.TabIndex = 11;
            this.length_scale_value.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Length Scale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "DTheta:";
            // 
            // DTheta_value
            // 
            this.DTheta_value.Location = new System.Drawing.Point(456, 8);
            this.DTheta_value.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.DTheta_value.Name = "DTheta_value";
            this.DTheta_value.Size = new System.Drawing.Size(57, 22);
            this.DTheta_value.TabIndex = 7;
            this.DTheta_value.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Length:";
            // 
            // length_value
            // 
            this.length_value.Location = new System.Drawing.Point(581, 8);
            this.length_value.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.length_value.Name = "length_value";
            this.length_value.Size = new System.Drawing.Size(57, 22);
            this.length_value.TabIndex = 5;
            this.length_value.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Depth:";
            // 
            // depth_value
            // 
            this.depth_value.Location = new System.Drawing.Point(699, 8);
            this.depth_value.Name = "depth_value";
            this.depth_value.Size = new System.Drawing.Size(57, 22);
            this.depth_value.TabIndex = 3;
            this.depth_value.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // draw_btn
            // 
            this.draw_btn.Location = new System.Drawing.Point(11, 3);
            this.draw_btn.Name = "draw_btn";
            this.draw_btn.Size = new System.Drawing.Size(75, 58);
            this.draw_btn.TabIndex = 0;
            this.draw_btn.Text = "Draw";
            this.draw_btn.UseVisualStyleBackColor = true;
            this.draw_btn.Click += new System.EventHandler(this.draw_btn_Click);
            // 
            // proggres_bar
            // 
            this.proggres_bar.Location = new System.Drawing.Point(11, 67);
            this.proggres_bar.Name = "proggres_bar";
            this.proggres_bar.Size = new System.Drawing.Size(758, 23);
            this.proggres_bar.TabIndex = 2;
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Window1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.length_scale_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTheta_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth_value)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button draw_btn;
        private System.Windows.Forms.NumericUpDown depth_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DTheta_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown length_value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown length_scale_value;
        private System.Windows.Forms.ProgressBar proggres_bar;
    }
}

