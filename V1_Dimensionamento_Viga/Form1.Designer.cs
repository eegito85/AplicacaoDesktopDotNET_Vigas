namespace V1_Dimensionamento_Viga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEcmax = new System.Windows.Forms.TextBox();
            this.txtLarguraViga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAlturaUtil = new System.Windows.Forms.TextBox();
            this.txtModuloElasticidadeAco = new System.Windows.Forms.TextBox();
            this.txtAs = new System.Windows.Forms.TextBox();
            this.txtAslinha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFck = new System.Windows.Forms.TextBox();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.txtAlfa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDlinha = new System.Windows.Forms.TextBox();
            this.txtMomentoFletor = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txtEsl = new System.Windows.Forms.TextBox();
            this.txtEs = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtFyk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 272);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtEcmax
            // 
            this.txtEcmax.Location = new System.Drawing.Point(69, 329);
            this.txtEcmax.Name = "txtEcmax";
            this.txtEcmax.ReadOnly = true;
            this.txtEcmax.Size = new System.Drawing.Size(64, 20);
            this.txtEcmax.TabIndex = 1;
            this.txtEcmax.Text = "3,5";
            // 
            // txtLarguraViga
            // 
            this.txtLarguraViga.Location = new System.Drawing.Point(69, 356);
            this.txtLarguraViga.Name = "txtLarguraViga";
            this.txtLarguraViga.Size = new System.Drawing.Size(64, 20);
            this.txtLarguraViga.TabIndex = 4;
            this.txtLarguraViga.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ε";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "c";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(573, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ε’";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "b:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "d:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "d\':";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Eaço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(191, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "As:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(188, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "As\':";
            // 
            // txtAlturaUtil
            // 
            this.txtAlturaUtil.Location = new System.Drawing.Point(69, 382);
            this.txtAlturaUtil.Name = "txtAlturaUtil";
            this.txtAlturaUtil.Size = new System.Drawing.Size(64, 20);
            this.txtAlturaUtil.TabIndex = 17;
            this.txtAlturaUtil.Text = "0";
            // 
            // txtModuloElasticidadeAco
            // 
            this.txtModuloElasticidadeAco.Location = new System.Drawing.Point(69, 434);
            this.txtModuloElasticidadeAco.Name = "txtModuloElasticidadeAco";
            this.txtModuloElasticidadeAco.ReadOnly = true;
            this.txtModuloElasticidadeAco.Size = new System.Drawing.Size(64, 20);
            this.txtModuloElasticidadeAco.TabIndex = 18;
            this.txtModuloElasticidadeAco.Text = "210000";
            // 
            // txtAs
            // 
            this.txtAs.Location = new System.Drawing.Point(224, 330);
            this.txtAs.Name = "txtAs";
            this.txtAs.Size = new System.Drawing.Size(64, 20);
            this.txtAs.TabIndex = 19;
            this.txtAs.Text = "0";
            // 
            // txtAslinha
            // 
            this.txtAslinha.Location = new System.Drawing.Point(224, 356);
            this.txtAslinha.Name = "txtAslinha";
            this.txtAslinha.Size = new System.Drawing.Size(64, 20);
            this.txtAslinha.TabIndex = 20;
            this.txtAslinha.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(190, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "fck:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(199, 409);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "λ:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(200, 435);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "α:";
            // 
            // txtFck
            // 
            this.txtFck.Location = new System.Drawing.Point(224, 382);
            this.txtFck.Name = "txtFck";
            this.txtFck.Size = new System.Drawing.Size(64, 20);
            this.txtFck.TabIndex = 24;
            this.txtFck.Text = "0";
            this.txtFck.TextChanged += new System.EventHandler(this.txtFck_TextChanged);
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(224, 408);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.ReadOnly = true;
            this.txtLambda.Size = new System.Drawing.Size(64, 20);
            this.txtLambda.TabIndex = 25;
            this.txtLambda.Text = "0,8";
            // 
            // txtAlfa
            // 
            this.txtAlfa.Location = new System.Drawing.Point(224, 434);
            this.txtAlfa.Name = "txtAlfa";
            this.txtAlfa.ReadOnly = true;
            this.txtAlfa.Size = new System.Drawing.Size(64, 20);
            this.txtAlfa.TabIndex = 26;
            this.txtAlfa.Text = "0,85";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(450, 324);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "Momento Fletor Resistente:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Entre com os valores abaixo:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(575, 371);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "ε";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(589, 378);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "s";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(598, 378);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = ":";
            // 
            // txtDlinha
            // 
            this.txtDlinha.Location = new System.Drawing.Point(69, 408);
            this.txtDlinha.Name = "txtDlinha";
            this.txtDlinha.Size = new System.Drawing.Size(64, 20);
            this.txtDlinha.TabIndex = 32;
            this.txtDlinha.Text = "0";
            // 
            // txtMomentoFletor
            // 
            this.txtMomentoFletor.Location = new System.Drawing.Point(614, 323);
            this.txtMomentoFletor.Name = "txtMomentoFletor";
            this.txtMomentoFletor.ReadOnly = true;
            this.txtMomentoFletor.Size = new System.Drawing.Size(74, 20);
            this.txtMomentoFletor.TabIndex = 33;
            this.txtMomentoFletor.Text = "0";
            this.txtMomentoFletor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(354, 383);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 28);
            this.btCalcular.TabIndex = 34;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(294, 333);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "cm2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(294, 359);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "cm2";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(139, 359);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 13);
            this.label22.TabIndex = 37;
            this.label22.Text = "cm";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(139, 385);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 13);
            this.label24.TabIndex = 39;
            this.label24.Text = "cm";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(139, 411);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 13);
            this.label25.TabIndex = 40;
            this.label25.Text = "cm";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(139, 437);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 41;
            this.label26.Text = "MPa";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(138, 331);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(22, 16);
            this.label27.TabIndex = 42;
            this.label27.Text = "‰";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(698, 350);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(22, 16);
            this.label28.TabIndex = 43;
            this.label28.Text = "‰";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(698, 376);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(22, 16);
            this.label29.TabIndex = 44;
            this.label29.Text = "‰";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(294, 385);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 13);
            this.label30.TabIndex = 45;
            this.label30.Text = "MPa";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(694, 326);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(33, 13);
            this.label31.TabIndex = 46;
            this.label31.Text = "KN.m";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(677, 511);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(54, 24);
            this.btSair.TabIndex = 47;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(590, 352);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(12, 13);
            this.label32.TabIndex = 48;
            this.label32.Text = "s";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(599, 350);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(10, 13);
            this.label33.TabIndex = 49;
            this.label33.Text = ":";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(450, 300);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(94, 13);
            this.label36.TabIndex = 52;
            this.label36.Text = "RESULTADOS:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(590, 404);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(18, 13);
            this.label37.TabIndex = 53;
            this.label37.Text = "x :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(698, 404);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(21, 13);
            this.label39.TabIndex = 55;
            this.label39.Text = "cm";
            // 
            // txtEsl
            // 
            this.txtEsl.Location = new System.Drawing.Point(614, 349);
            this.txtEsl.Name = "txtEsl";
            this.txtEsl.ReadOnly = true;
            this.txtEsl.Size = new System.Drawing.Size(74, 20);
            this.txtEsl.TabIndex = 56;
            this.txtEsl.Text = "0";
            this.txtEsl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEs
            // 
            this.txtEs.Location = new System.Drawing.Point(614, 375);
            this.txtEs.Name = "txtEs";
            this.txtEs.ReadOnly = true;
            this.txtEs.Size = new System.Drawing.Size(74, 20);
            this.txtEs.TabIndex = 57;
            this.txtEs.Text = "0";
            this.txtEs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(614, 401);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(74, 20);
            this.txtX.TabIndex = 58;
            this.txtX.Text = "0";
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(12, 525);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(329, 13);
            this.label34.TabIndex = 59;
            this.label34.Text = "Desenvolvido noVisual Studio (C# .NET) por Emmanuel Egito - 2016";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "MPa";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(39, 461);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 15);
            this.label23.TabIndex = 61;
            this.label23.Text = "fyk:";
            // 
            // txtFyk
            // 
            this.txtFyk.Location = new System.Drawing.Point(69, 460);
            this.txtFyk.Name = "txtFyk";
            this.txtFyk.ReadOnly = true;
            this.txtFyk.Size = new System.Drawing.Size(64, 20);
            this.txtFyk.TabIndex = 62;
            this.txtFyk.Text = "500";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(743, 547);
            this.Controls.Add(this.txtFyk);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtEs);
            this.Controls.Add(this.txtEsl);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtMomentoFletor);
            this.Controls.Add(this.txtDlinha);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAlfa);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.txtFck);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAslinha);
            this.Controls.Add(this.txtAs);
            this.Controls.Add(this.txtModuloElasticidadeAco);
            this.Controls.Add(this.txtAlturaUtil);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLarguraViga);
            this.Controls.Add(this.txtEcmax);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(759, 585);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dimensionamento de Vigas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEcmax;
        private System.Windows.Forms.TextBox txtLarguraViga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAlturaUtil;
        private System.Windows.Forms.TextBox txtModuloElasticidadeAco;
        private System.Windows.Forms.TextBox txtAs;
        private System.Windows.Forms.TextBox txtAslinha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFck;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.TextBox txtAlfa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDlinha;
        private System.Windows.Forms.TextBox txtMomentoFletor;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtEsl;
        private System.Windows.Forms.TextBox txtEs;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtFyk;
    }
}

