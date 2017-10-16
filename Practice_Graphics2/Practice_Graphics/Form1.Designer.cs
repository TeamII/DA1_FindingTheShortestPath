namespace Practice_Graphics
{
    partial class FrmMS
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
            this.btnPoint = new System.Windows.Forms.Button();
            this.panelMT = new System.Windows.Forms.Panel();
            this.line = new System.Windows.Forms.Button();
            this.txtPS = new System.Windows.Forms.TextBox();
            this.txtPE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMess = new System.Windows.Forms.Label();
            this.panelMT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(199, 65);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(112, 35);
            this.btnPoint.TabIndex = 0;
            this.btnPoint.Text = "Add Point";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // panelMT
            // 
            this.panelMT.BackColor = System.Drawing.Color.White;
            this.panelMT.Controls.Add(this.lblMess);
            this.panelMT.Location = new System.Drawing.Point(328, 18);
            this.panelMT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMT.Name = "panelMT";
            this.panelMT.Size = new System.Drawing.Size(598, 532);
            this.panelMT.TabIndex = 1;
            this.panelMT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMT_MouseDown);
            // 
            // line
            // 
            this.line.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line.Location = new System.Drawing.Point(29, 27);
            this.line.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(112, 35);
            this.line.TabIndex = 2;
            this.line.Text = "Add line";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // txtPS
            // 
            this.txtPS.Location = new System.Drawing.Point(79, 83);
            this.txtPS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPS.Name = "txtPS";
            this.txtPS.Size = new System.Drawing.Size(77, 26);
            this.txtPS.TabIndex = 3;
            // 
            // txtPE
            // 
            this.txtPE.Location = new System.Drawing.Point(79, 122);
            this.txtPE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPE.Name = "txtPE";
            this.txtPE.Size = new System.Drawing.Size(77, 26);
            this.txtPE.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Point S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Point E";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(79, 160);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(77, 26);
            this.txtPath.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.line);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPE);
            this.groupBox1.Controls.Add(this.txtPS);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 203);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lblMess
            // 
            this.lblMess.AutoSize = true;
            this.lblMess.BackColor = System.Drawing.SystemColors.Window;
            this.lblMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMess.ForeColor = System.Drawing.Color.Crimson;
            this.lblMess.Location = new System.Drawing.Point(3, 0);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(0, 25);
            this.lblMess.TabIndex = 0;
            // 
            // FrmMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(945, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.panelMT);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMS";
            this.Text = "MinStreet";
            this.panelMT.ResumeLayout(false);
            this.panelMT.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPoint;
        public System.Windows.Forms.Panel panelMT;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.TextBox txtPS;
        private System.Windows.Forms.TextBox txtPE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMess;
    }
}

