
namespace NomDuLogiciel
{
    partial class FullScreen
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
            this.txtQuit = new System.Windows.Forms.Label();
            this.txtMinimiz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMoyIn = new NomDuLogiciel.Tools.TransparentTextBox();
            this.txtMinIn = new NomDuLogiciel.Tools.TransparentTextBox();
            this.txtMaxIn = new NomDuLogiciel.Tools.TransparentTextBox();
            this.txtMoyOut = new NomDuLogiciel.Tools.TransparentTextBox();
            this.txtMinOut = new NomDuLogiciel.Tools.TransparentTextBox();
            this.txtMaxOut = new NomDuLogiciel.Tools.TransparentTextBox();
            this.pnlFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuit
            // 
            this.txtQuit.AutoSize = true;
            this.txtQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuit.ForeColor = System.Drawing.Color.White;
            this.txtQuit.Location = new System.Drawing.Point(1337, 9);
            this.txtQuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtQuit.Name = "txtQuit";
            this.txtQuit.Size = new System.Drawing.Size(20, 20);
            this.txtQuit.TabIndex = 1;
            this.txtQuit.Text = "X";
            this.txtQuit.Click += new System.EventHandler(this.txtQuit_Click);
            // 
            // txtMinimiz
            // 
            this.txtMinimiz.AutoSize = true;
            this.txtMinimiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimiz.ForeColor = System.Drawing.Color.White;
            this.txtMinimiz.Location = new System.Drawing.Point(1310, 3);
            this.txtMinimiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMinimiz.Name = "txtMinimiz";
            this.txtMinimiz.Size = new System.Drawing.Size(19, 26);
            this.txtMinimiz.TabIndex = 2;
            this.txtMinimiz.Text = "-";
            this.txtMinimiz.Click += new System.EventHandler(this.txtMinimiz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du logiciel | fichier courrant";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(0, 41);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1370, 622);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.label10);
            this.pnlFill.Controls.Add(this.label11);
            this.pnlFill.Controls.Add(this.label12);
            this.pnlFill.Controls.Add(this.label7);
            this.pnlFill.Controls.Add(this.label8);
            this.pnlFill.Controls.Add(this.label9);
            this.pnlFill.Controls.Add(this.label6);
            this.pnlFill.Controls.Add(this.label5);
            this.pnlFill.Controls.Add(this.label4);
            this.pnlFill.Controls.Add(this.label3);
            this.pnlFill.Controls.Add(this.label2);
            this.pnlFill.Controls.Add(this.label13);
            this.pnlFill.Controls.Add(this.txtMoyIn);
            this.pnlFill.Controls.Add(this.txtMinIn);
            this.pnlFill.Controls.Add(this.txtMaxIn);
            this.pnlFill.Controls.Add(this.txtMoyOut);
            this.pnlFill.Controls.Add(this.txtMinOut);
            this.pnlFill.Controls.Add(this.txtMaxOut);
            this.pnlFill.Controls.Add(this.btnExport);
            this.pnlFill.Controls.Add(this.txtQuit);
            this.pnlFill.Controls.Add(this.txtMinimiz);
            this.pnlFill.Controls.Add(this.label1);
            this.pnlFill.Controls.Add(this.cartesianChart1);
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(1474, 818);
            this.pnlFill.TabIndex = 2;
            this.pnlFill.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1274, 726);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(96, 35);
            this.btnExport.TabIndex = 21;
            this.btnExport.Text = "Exporter";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(737, 717);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 25);
            this.label10.TabIndex = 50;
            this.label10.Text = "Mb";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(737, 745);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 25);
            this.label11.TabIndex = 49;
            this.label11.Text = "Mb";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(737, 687);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 25);
            this.label12.TabIndex = 48;
            this.label12.Text = "Mb";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(507, 738);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 47;
            this.label7.Text = "Moyenne";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(510, 710);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "Minimum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(504, 680);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 45;
            this.label9.Text = "Maximum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(261, 714);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Mb";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(261, 742);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(261, 684);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Mb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(36, 736);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Moyenne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(39, 708);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Minimum";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(33, 678);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 25);
            this.label13.TabIndex = 39;
            this.label13.Text = "Maximum";
            // 
            // txtMoyIn
            // 
            this.txtMoyIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoyIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoyIn.ForeColor = System.Drawing.Color.Green;
            this.txtMoyIn.Location = new System.Drawing.Point(619, 742);
            this.txtMoyIn.Name = "txtMoyIn";
            this.txtMoyIn.Size = new System.Drawing.Size(100, 19);
            this.txtMoyIn.TabIndex = 38;
            this.txtMoyIn.Text = "___ ___ ___";
            this.txtMoyIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMinIn
            // 
            this.txtMinIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinIn.ForeColor = System.Drawing.Color.Green;
            this.txtMinIn.Location = new System.Drawing.Point(619, 716);
            this.txtMinIn.Name = "txtMinIn";
            this.txtMinIn.Size = new System.Drawing.Size(100, 19);
            this.txtMinIn.TabIndex = 37;
            this.txtMinIn.Text = "___ ___ ___";
            this.txtMinIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaxIn
            // 
            this.txtMaxIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxIn.ForeColor = System.Drawing.Color.Green;
            this.txtMaxIn.Location = new System.Drawing.Point(619, 690);
            this.txtMaxIn.Name = "txtMaxIn";
            this.txtMaxIn.Size = new System.Drawing.Size(100, 19);
            this.txtMaxIn.TabIndex = 36;
            this.txtMaxIn.Text = "___ ___ ___";
            this.txtMaxIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMoyOut
            // 
            this.txtMoyOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoyOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoyOut.ForeColor = System.Drawing.Color.Red;
            this.txtMoyOut.Location = new System.Drawing.Point(146, 742);
            this.txtMoyOut.Name = "txtMoyOut";
            this.txtMoyOut.Size = new System.Drawing.Size(100, 19);
            this.txtMoyOut.TabIndex = 35;
            this.txtMoyOut.Text = "___ ___ ___";
            this.txtMoyOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMinOut
            // 
            this.txtMinOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinOut.ForeColor = System.Drawing.Color.Red;
            this.txtMinOut.Location = new System.Drawing.Point(146, 684);
            this.txtMinOut.Name = "txtMinOut";
            this.txtMinOut.Size = new System.Drawing.Size(100, 19);
            this.txtMinOut.TabIndex = 34;
            this.txtMinOut.Text = "___ ___ ___";
            this.txtMinOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaxOut
            // 
            this.txtMaxOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxOut.ForeColor = System.Drawing.Color.Red;
            this.txtMaxOut.Location = new System.Drawing.Point(146, 714);
            this.txtMaxOut.Name = "txtMaxOut";
            this.txtMaxOut.Size = new System.Drawing.Size(100, 19);
            this.txtMaxOut.TabIndex = 33;
            this.txtMaxOut.Text = "___ ___ ___";
            this.txtMaxOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FullScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pnlFill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FullScreen";
            this.Text = "FullScreen";
            this.Load += new System.EventHandler(this.FullScreen_Load);
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMinimiz;
        private System.Windows.Forms.Label txtQuit;
        private System.Windows.Forms.Panel pnlFill;
        public LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private Tools.TransparentTextBox txtMoyIn;
        private Tools.TransparentTextBox txtMinIn;
        private Tools.TransparentTextBox txtMaxIn;
        private Tools.TransparentTextBox txtMoyOut;
        private Tools.TransparentTextBox txtMinOut;
        private Tools.TransparentTextBox txtMaxOut;
    }
}