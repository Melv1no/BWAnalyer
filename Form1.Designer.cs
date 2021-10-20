
namespace NomDuLogiciel
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Label();
            this.txtMinimiz = new System.Windows.Forms.Label();
            this.txtTitleWindows = new System.Windows.Forms.Label();
            this.txtQuit = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnAddCsv = new System.Windows.Forms.Button();
            this.listboxCsv = new System.Windows.Forms.ListBox();
            this.separator = new System.Windows.Forms.Label();
            this.txtTitleSearch = new System.Windows.Forms.Label();
            this.pboxSearchIcon = new System.Windows.Forms.PictureBox();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.separator1 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.btnOpenFullscreen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMoyIn = new NomDuLogiciel.Tools.TransparentTextBox();
            this.txtMinIn = new NomDuLogiciel.Tools.TransparentTextBox();
            this.txtMaxIn = new NomDuLogiciel.Tools.TransparentTextBox();
            this.txtMoyOut = new NomDuLogiciel.Tools.TransparentTextBox();
            this.txtMinOut = new NomDuLogiciel.Tools.TransparentTextBox();
            this.txtMaxOut = new NomDuLogiciel.Tools.TransparentTextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.btnMaximize);
            this.pnlHeader.Controls.Add(this.txtMinimiz);
            this.pnlHeader.Controls.Add(this.txtTitleWindows);
            this.pnlHeader.Controls.Add(this.txtQuit);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1386, 39);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // btnMaximize
            // 
            this.btnMaximize.AutoSize = true;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(1296, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(33, 36);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Text = "□";
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // txtMinimiz
            // 
            this.txtMinimiz.AutoSize = true;
            this.txtMinimiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.txtMinimiz.ForeColor = System.Drawing.Color.White;
            this.txtMinimiz.Location = new System.Drawing.Point(1269, 0);
            this.txtMinimiz.Name = "txtMinimiz";
            this.txtMinimiz.Size = new System.Drawing.Size(25, 36);
            this.txtMinimiz.TabIndex = 3;
            this.txtMinimiz.Text = "-";
            this.txtMinimiz.Click += new System.EventHandler(this.txtMinimiz_Click);
            // 
            // txtTitleWindows
            // 
            this.txtTitleWindows.AutoSize = true;
            this.txtTitleWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtTitleWindows.ForeColor = System.Drawing.Color.White;
            this.txtTitleWindows.Location = new System.Drawing.Point(6, 6);
            this.txtTitleWindows.Name = "txtTitleWindows";
            this.txtTitleWindows.Size = new System.Drawing.Size(359, 25);
            this.txtTitleWindows.TabIndex = 2;
            this.txtTitleWindows.Text = "Ajouter ou cliquer sur un fichier CSV";
            this.txtTitleWindows.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // txtQuit
            // 
            this.txtQuit.AutoSize = true;
            this.txtQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtQuit.ForeColor = System.Drawing.Color.White;
            this.txtQuit.Location = new System.Drawing.Point(1335, 7);
            this.txtQuit.Name = "txtQuit";
            this.txtQuit.Size = new System.Drawing.Size(30, 29);
            this.txtQuit.TabIndex = 1;
            this.txtQuit.Text = "X";
            this.txtQuit.Click += new System.EventHandler(this.txtQuit_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.pnlLeft.Controls.Add(this.btnAddCsv);
            this.pnlLeft.Controls.Add(this.listboxCsv);
            this.pnlLeft.Controls.Add(this.separator);
            this.pnlLeft.Controls.Add(this.txtTitleSearch);
            this.pnlLeft.Controls.Add(this.pboxSearchIcon);
            this.pnlLeft.Controls.Add(this.txtboxSearch);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 39);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(270, 749);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnAddCsv
            // 
            this.btnAddCsv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddCsv.FlatAppearance.BorderSize = 0;
            this.btnAddCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCsv.ForeColor = System.Drawing.Color.White;
            this.btnAddCsv.Location = new System.Drawing.Point(0, 663);
            this.btnAddCsv.Name = "btnAddCsv";
            this.btnAddCsv.Size = new System.Drawing.Size(270, 86);
            this.btnAddCsv.TabIndex = 4;
            this.btnAddCsv.Text = "Ajouter un Fichier CSV";
            this.btnAddCsv.UseVisualStyleBackColor = true;
            this.btnAddCsv.Click += new System.EventHandler(this.btnAddCsv_Click);
            // 
            // listboxCsv
            // 
            this.listboxCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.listboxCsv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listboxCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listboxCsv.ForeColor = System.Drawing.Color.White;
            this.listboxCsv.FormattingEnabled = true;
            this.listboxCsv.HorizontalScrollbar = true;
            this.listboxCsv.Location = new System.Drawing.Point(5, 89);
            this.listboxCsv.Name = "listboxCsv";
            this.listboxCsv.ScrollAlwaysVisible = true;
            this.listboxCsv.Size = new System.Drawing.Size(262, 572);
            this.listboxCsv.TabIndex = 3;
            this.listboxCsv.SelectedIndexChanged += new System.EventHandler(this.listboxCsv_SelectedIndexChanged);
            // 
            // separator
            // 
            this.separator.AutoSize = true;
            this.separator.ForeColor = System.Drawing.Color.White;
            this.separator.Location = new System.Drawing.Point(57, 65);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(211, 13);
            this.separator.TabIndex = 3;
            this.separator.Text = "__________________________________";
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.AutoSize = true;
            this.txtTitleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleSearch.ForeColor = System.Drawing.Color.White;
            this.txtTitleSearch.Location = new System.Drawing.Point(122, 3);
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(96, 20);
            this.txtTitleSearch.TabIndex = 3;
            this.txtTitleSearch.Text = "Rechercher";
            // 
            // pboxSearchIcon
            // 
            this.pboxSearchIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxSearchIcon.BackgroundImage")));
            this.pboxSearchIcon.Image = global::BWAnalyser.Properties.Resources.search__1_;
            this.pboxSearchIcon.Location = new System.Drawing.Point(11, 26);
            this.pboxSearchIcon.Name = "pboxSearchIcon";
            this.pboxSearchIcon.Size = new System.Drawing.Size(35, 35);
            this.pboxSearchIcon.TabIndex = 2;
            this.pboxSearchIcon.TabStop = false;
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearch.ForeColor = System.Drawing.Color.White;
            this.txtboxSearch.Location = new System.Drawing.Point(61, 29);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(190, 26);
            this.txtboxSearch.TabIndex = 2;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // separator1
            // 
            this.separator1.AutoSize = true;
            this.separator1.ForeColor = System.Drawing.Color.White;
            this.separator1.Location = new System.Drawing.Point(446, 602);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(817, 13);
            this.separator1.TabIndex = 3;
            this.separator1.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColorTransparent = true;
            this.cartesianChart1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartesianChart1.Location = new System.Drawing.Point(287, 39);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1071, 545);
            this.cartesianChart1.TabIndex = 4;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // btnOpenFullscreen
            // 
            this.btnOpenFullscreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFullscreen.ForeColor = System.Drawing.Color.White;
            this.btnOpenFullscreen.Location = new System.Drawing.Point(276, 602);
            this.btnOpenFullscreen.Name = "btnOpenFullscreen";
            this.btnOpenFullscreen.Size = new System.Drawing.Size(166, 40);
            this.btnOpenFullscreen.TabIndex = 5;
            this.btnOpenFullscreen.Text = "Ouvrir seul";
            this.btnOpenFullscreen.UseVisualStyleBackColor = true;
            this.btnOpenFullscreen.Click += new System.EventHandler(this.btnOpenFullscreen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(444, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Maximum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(450, 665);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Minimum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(447, 693);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Moyenne";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(672, 641);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mb";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(672, 699);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mb";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(672, 671);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mb";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(918, 695);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Moyenne";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(921, 667);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Minimum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(915, 637);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Maximum";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(1148, 674);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 25);
            this.label10.TabIndex = 32;
            this.label10.Text = "Mb";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(1148, 702);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Mb";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(1148, 644);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "Mb";
            // 
            // txtMoyIn
            // 
            this.txtMoyIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoyIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoyIn.ForeColor = System.Drawing.Color.Green;
            this.txtMoyIn.Location = new System.Drawing.Point(1030, 699);
            this.txtMoyIn.Name = "txtMoyIn";
            this.txtMoyIn.Size = new System.Drawing.Size(100, 19);
            this.txtMoyIn.TabIndex = 20;
            this.txtMoyIn.Text = "___ ___ ___";
            this.txtMoyIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMoyIn.TextChanged += new System.EventHandler(this.txtMoyIn_TextChanged);
            // 
            // txtMinIn
            // 
            this.txtMinIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinIn.ForeColor = System.Drawing.Color.Green;
            this.txtMinIn.Location = new System.Drawing.Point(1030, 673);
            this.txtMinIn.Name = "txtMinIn";
            this.txtMinIn.Size = new System.Drawing.Size(100, 19);
            this.txtMinIn.TabIndex = 19;
            this.txtMinIn.Text = "___ ___ ___";
            this.txtMinIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinIn.TextChanged += new System.EventHandler(this.txtMinIn_TextChanged);
            // 
            // txtMaxIn
            // 
            this.txtMaxIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxIn.ForeColor = System.Drawing.Color.Green;
            this.txtMaxIn.Location = new System.Drawing.Point(1030, 647);
            this.txtMaxIn.Name = "txtMaxIn";
            this.txtMaxIn.Size = new System.Drawing.Size(100, 19);
            this.txtMaxIn.TabIndex = 18;
            this.txtMaxIn.Text = "___ ___ ___";
            this.txtMaxIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMoyOut
            // 
            this.txtMoyOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoyOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoyOut.ForeColor = System.Drawing.Color.Red;
            this.txtMoyOut.Location = new System.Drawing.Point(557, 699);
            this.txtMoyOut.Name = "txtMoyOut";
            this.txtMoyOut.Size = new System.Drawing.Size(100, 19);
            this.txtMoyOut.TabIndex = 17;
            this.txtMoyOut.Text = "___ ___ ___";
            this.txtMoyOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMinOut
            // 
            this.txtMinOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinOut.ForeColor = System.Drawing.Color.Red;
            this.txtMinOut.Location = new System.Drawing.Point(557, 641);
            this.txtMinOut.Name = "txtMinOut";
            this.txtMinOut.Size = new System.Drawing.Size(100, 19);
            this.txtMinOut.TabIndex = 16;
            this.txtMinOut.Text = "___ ___ ___";
            this.txtMinOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaxOut
            // 
            this.txtMaxOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxOut.ForeColor = System.Drawing.Color.Red;
            this.txtMaxOut.Location = new System.Drawing.Point(557, 671);
            this.txtMaxOut.Name = "txtMaxOut";
            this.txtMaxOut.Size = new System.Drawing.Size(100, 19);
            this.txtMaxOut.TabIndex = 15;
            this.txtMaxOut.Text = "___ ___ ___";
            this.txtMaxOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoyIn);
            this.Controls.Add(this.txtMinIn);
            this.Controls.Add(this.txtMaxIn);
            this.Controls.Add(this.txtMoyOut);
            this.Controls.Add(this.txtMinOut);
            this.Controls.Add(this.txtMaxOut);
            this.Controls.Add(this.btnOpenFullscreen);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label txtTitleWindows;
        private System.Windows.Forms.Label txtQuit;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnAddCsv;
        private System.Windows.Forms.ListBox listboxCsv;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.Label txtTitleSearch;
        private System.Windows.Forms.PictureBox pboxSearchIcon;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label separator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label txtMinimiz;
        public LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button btnOpenFullscreen;
        private System.Windows.Forms.Label btnMaximize;
        private Tools.TransparentTextBox txtMaxOut;
        private Tools.TransparentTextBox txtMinOut;
        private Tools.TransparentTextBox txtMoyOut;
        private Tools.TransparentTextBox txtMaxIn;
        private Tools.TransparentTextBox txtMinIn;
        private Tools.TransparentTextBox txtMoyIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

