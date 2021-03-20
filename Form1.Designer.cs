
namespace SimpleCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bdiv = new System.Windows.Forms.Button();
            this.bbackspace = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.bclearentry = new System.Windows.Forms.Button();
            this.bmulti = new System.Windows.Forms.Button();
            this.bsubstract = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bcomma = new System.Windows.Forms.Button();
            this.bplusmin = new System.Windows.Forms.Button();
            this.operation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(454, 78);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bdiv
            // 
            this.bdiv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdiv.BackColor = System.Drawing.SystemColors.Control;
            this.bdiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bdiv.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdiv.Location = new System.Drawing.Point(351, 115);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(115, 75);
            this.bdiv.TabIndex = 1;
            this.bdiv.Text = "÷";
            this.bdiv.UseVisualStyleBackColor = false;
            this.bdiv.Click += new System.EventHandler(this.operator_current);
            // 
            // bbackspace
            // 
            this.bbackspace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bbackspace.BackColor = System.Drawing.SystemColors.Control;
            this.bbackspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bbackspace.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbackspace.Location = new System.Drawing.Point(238, 115);
            this.bbackspace.Name = "bbackspace";
            this.bbackspace.Size = new System.Drawing.Size(115, 75);
            this.bbackspace.TabIndex = 1;
            this.bbackspace.Text = "⌫";
            this.bbackspace.UseVisualStyleBackColor = false;
            this.bbackspace.Click += new System.EventHandler(this.operator_bp);
            // 
            // bclear
            // 
            this.bclear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bclear.BackColor = System.Drawing.SystemColors.Control;
            this.bclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bclear.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bclear.Location = new System.Drawing.Point(125, 115);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(115, 75);
            this.bclear.TabIndex = 1;
            this.bclear.Text = "C";
            this.bclear.UseVisualStyleBackColor = false;
            this.bclear.Click += new System.EventHandler(this.operator_c);
            // 
            // bclearentry
            // 
            this.bclearentry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bclearentry.BackColor = System.Drawing.SystemColors.Control;
            this.bclearentry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bclearentry.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bclearentry.Location = new System.Drawing.Point(12, 115);
            this.bclearentry.Name = "bclearentry";
            this.bclearentry.Size = new System.Drawing.Size(115, 75);
            this.bclearentry.TabIndex = 1;
            this.bclearentry.Text = "CE";
            this.bclearentry.UseVisualStyleBackColor = false;
            this.bclearentry.Click += new System.EventHandler(this.operator_ce);
            // 
            // bmulti
            // 
            this.bmulti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bmulti.BackColor = System.Drawing.SystemColors.Control;
            this.bmulti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bmulti.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmulti.Location = new System.Drawing.Point(351, 186);
            this.bmulti.Name = "bmulti";
            this.bmulti.Size = new System.Drawing.Size(115, 75);
            this.bmulti.TabIndex = 1;
            this.bmulti.Text = "×";
            this.bmulti.UseVisualStyleBackColor = false;
            this.bmulti.Click += new System.EventHandler(this.operator_current);
            // 
            // bsubstract
            // 
            this.bsubstract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bsubstract.BackColor = System.Drawing.SystemColors.Control;
            this.bsubstract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bsubstract.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsubstract.Location = new System.Drawing.Point(351, 258);
            this.bsubstract.Name = "bsubstract";
            this.bsubstract.Size = new System.Drawing.Size(115, 75);
            this.bsubstract.TabIndex = 1;
            this.bsubstract.Text = "−";
            this.bsubstract.UseVisualStyleBackColor = false;
            this.bsubstract.Click += new System.EventHandler(this.operator_current);
            // 
            // badd
            // 
            this.badd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.badd.BackColor = System.Drawing.SystemColors.Control;
            this.badd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.badd.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badd.Location = new System.Drawing.Point(351, 330);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(115, 75);
            this.badd.TabIndex = 1;
            this.badd.Text = "+";
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.operator_current);
            // 
            // bequal
            // 
            this.bequal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bequal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bequal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bequal.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bequal.Location = new System.Drawing.Point(351, 403);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(115, 75);
            this.bequal.TabIndex = 2;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = false;
            this.bequal.Click += new System.EventHandler(this.operator_calculation);
            // 
            // b7
            // 
            this.b7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(12, 186);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(115, 75);
            this.b7.TabIndex = 1;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.button_click);
            // 
            // b8
            // 
            this.b8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(125, 186);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(115, 75);
            this.b8.TabIndex = 1;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.button_click);
            // 
            // b9
            // 
            this.b9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(238, 186);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(115, 75);
            this.b9.TabIndex = 1;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.button_click);
            // 
            // b4
            // 
            this.b4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(12, 258);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(115, 75);
            this.b4.TabIndex = 1;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.button_click);
            // 
            // b1
            // 
            this.b1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(12, 330);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(115, 75);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.button_click);
            // 
            // b5
            // 
            this.b5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(125, 258);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(115, 75);
            this.b5.TabIndex = 1;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.button_click);
            // 
            // b2
            // 
            this.b2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(125, 330);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(115, 75);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.button_click);
            // 
            // b6
            // 
            this.b6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(238, 258);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(115, 75);
            this.b6.TabIndex = 1;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.button_click);
            // 
            // b3
            // 
            this.b3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(238, 330);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(115, 75);
            this.b3.TabIndex = 1;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.button_click);
            // 
            // b0
            // 
            this.b0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(125, 403);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(115, 75);
            this.b0.TabIndex = 1;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.button_click);
            // 
            // bcomma
            // 
            this.bcomma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bcomma.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bcomma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bcomma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcomma.Location = new System.Drawing.Point(238, 403);
            this.bcomma.Name = "bcomma";
            this.bcomma.Size = new System.Drawing.Size(115, 75);
            this.bcomma.TabIndex = 1;
            this.bcomma.Text = ",";
            this.bcomma.UseVisualStyleBackColor = false;
            this.bcomma.Click += new System.EventHandler(this.button_click);
            // 
            // bplusmin
            // 
            this.bplusmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bplusmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bplusmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bplusmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bplusmin.Location = new System.Drawing.Point(12, 403);
            this.bplusmin.Name = "bplusmin";
            this.bplusmin.Size = new System.Drawing.Size(115, 75);
            this.bplusmin.TabIndex = 1;
            this.bplusmin.Text = "+/-";
            this.bplusmin.UseVisualStyleBackColor = false;
            this.bplusmin.Click += new System.EventHandler(this.plusminus_Click);
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.operation.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operation.Location = new System.Drawing.Point(12, 9);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(0, 25);
            this.operation.TabIndex = 21;
            /*this.operation.Click += new System.EventHandler(this.label_operation);*/
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(478, 484);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.bcomma);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.bplusmin);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.bclearentry);
            this.Controls.Add(this.bsubstract);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.bmulti);
            this.Controls.Add(this.bbackspace);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bbackspace;
        private System.Windows.Forms.Button bclear;
        private System.Windows.Forms.Button bclearentry;
        private System.Windows.Forms.Button bmulti;
        private System.Windows.Forms.Button bsubstract;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bequal;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bcomma;
        private System.Windows.Forms.Button bplusmin;
        private System.Windows.Forms.Label operation;
    }
}

