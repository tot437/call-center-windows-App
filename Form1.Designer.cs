namespace data_call_senter_forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCustomerName = new TextBox();
            txtCustomerAge = new TextBox();
            txtCustomerEmail = new TextBox();
            txtCustomerPhone = new TextBox();
            cmbCustomerSocialFeeling = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtCombanyName = new TextBox();
            txtCombanyBranch = new TextBox();
            txtMarketName = new TextBox();
            cmdProdoctTypes = new ComboBox();
            txtProdoctName = new TextBox();
            txtProdoctCode = new TextBox();
            txtProdoctPrice = new TextBox();
            txtDescontPrise = new TextBox();
            txtCustomerAdrres = new RichTextBox();
            btnAddData = new Button();
            btnDelet = new Button();
            btnShow = new Button();
            btnClose = new Button();
            btnFind = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 64);
            label1.ForeColor = Color.FromArgb(255, 192, 255);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "اسم العميل ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 0, 64);
            label2.ForeColor = Color.FromArgb(255, 192, 255);
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "عمره";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 0, 64);
            label3.ForeColor = Color.FromArgb(255, 192, 255);
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "عنوان سكنه";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(64, 0, 64);
            label4.ForeColor = Color.FromArgb(255, 192, 255);
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "ايميل جوجل";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(64, 0, 64);
            label5.ForeColor = Color.FromArgb(255, 192, 255);
            label5.Location = new Point(12, 231);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 4;
            label5.Text = "رقم هاتف/واتساب";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(64, 0, 64);
            label6.ForeColor = Color.FromArgb(255, 192, 255);
            label6.Location = new Point(12, 273);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 5;
            label6.Text = "الحالة الاجتماعية";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(93, 9);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(186, 23);
            txtCustomerName.TabIndex = 6;
            toolTip1.SetToolTip(txtCustomerName, "enter person name");
            // 
            // txtCustomerAge
            // 
            txtCustomerAge.Location = new Point(93, 47);
            txtCustomerAge.Name = "txtCustomerAge";
            txtCustomerAge.Size = new Size(74, 23);
            txtCustomerAge.TabIndex = 7;
            toolTip1.SetToolTip(txtCustomerAge, "persone age");
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(114, 177);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(186, 23);
            txtCustomerEmail.TabIndex = 8;
            toolTip1.SetToolTip(txtCustomerEmail, "persone google mail");
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(114, 228);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(186, 23);
            txtCustomerPhone.TabIndex = 9;
            toolTip1.SetToolTip(txtCustomerPhone, "enter persone call number");
            // 
            // cmbCustomerSocialFeeling
            // 
            cmbCustomerSocialFeeling.Cursor = Cursors.IBeam;
            cmbCustomerSocialFeeling.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCustomerSocialFeeling.FormattingEnabled = true;
            cmbCustomerSocialFeeling.Items.AddRange(new object[] { "اعزب/عزباء", "الارتباط", "الزواج", "لدى ابناء", "كبار السن", "لم يبلغ السن القانونى" });
            cmbCustomerSocialFeeling.Location = new Point(114, 268);
            cmbCustomerSocialFeeling.Name = "cmbCustomerSocialFeeling";
            cmbCustomerSocialFeeling.Size = new Size(186, 25);
            cmbCustomerSocialFeeling.TabIndex = 10;
            toolTip1.SetToolTip(cmbCustomerSocialFeeling, "persone social felling");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 0, 0);
            label7.ForeColor = Color.FromArgb(255, 192, 255);
            label7.Location = new Point(426, 9);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 11;
            label7.Text = "اسم الشركة";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 0, 0);
            label8.ForeColor = Color.FromArgb(255, 192, 255);
            label8.Location = new Point(426, 47);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 12;
            label8.Text = "فرع الشركة";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(192, 0, 0);
            label9.ForeColor = Color.FromArgb(255, 192, 255);
            label9.Location = new Point(428, 86);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 13;
            label9.Text = "اسم المحل";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(192, 0, 0);
            label10.ForeColor = Color.FromArgb(255, 192, 255);
            label10.Location = new Point(430, 127);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 14;
            label10.Text = "نوع المنتج";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(192, 0, 0);
            label11.ForeColor = Color.FromArgb(255, 192, 255);
            label11.Location = new Point(427, 177);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 15;
            label11.Text = "اسم المنتج";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(192, 0, 0);
            label12.ForeColor = Color.FromArgb(255, 192, 255);
            label12.Location = new Point(430, 219);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 16;
            label12.Text = "كود المنتج";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(192, 0, 0);
            label13.ForeColor = Color.FromArgb(255, 192, 255);
            label13.Location = new Point(426, 253);
            label13.Name = "label13";
            label13.Size = new Size(60, 15);
            label13.TabIndex = 17;
            label13.Text = "سعر الشراء\r\n";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(192, 0, 0);
            label14.ForeColor = Color.FromArgb(255, 192, 255);
            label14.Location = new Point(426, 300);
            label14.Name = "label14";
            label14.Size = new Size(128, 15);
            label14.TabIndex = 18;
            label14.Text = "السعر بعد الخصم ان وجد";
            // 
            // txtCombanyName
            // 
            txtCombanyName.Location = new Point(494, 6);
            txtCombanyName.Name = "txtCombanyName";
            txtCombanyName.Size = new Size(174, 23);
            txtCombanyName.TabIndex = 19;
            toolTip1.SetToolTip(txtCombanyName, "enter combany name");
            // 
            // txtCombanyBranch
            // 
            txtCombanyBranch.Location = new Point(492, 39);
            txtCombanyBranch.Name = "txtCombanyBranch";
            txtCombanyBranch.Size = new Size(174, 23);
            txtCombanyBranch.TabIndex = 20;
            toolTip1.SetToolTip(txtCombanyBranch, "combany Branch");
            // 
            // txtMarketName
            // 
            txtMarketName.Location = new Point(492, 83);
            txtMarketName.Name = "txtMarketName";
            txtMarketName.Size = new Size(174, 23);
            txtMarketName.TabIndex = 21;
            toolTip1.SetToolTip(txtMarketName, "market selling name");
            // 
            // cmdProdoctTypes
            // 
            cmdProdoctTypes.Cursor = Cursors.IBeam;
            cmdProdoctTypes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdProdoctTypes.FormattingEnabled = true;
            cmdProdoctTypes.Items.AddRange(new object[] { "", "منتجات اللحوم", "منتجات الالبان", "الخضروات والفواكه", "منتجات معلبة", "ادوات المطبخ", "مستحضرات التجميل", "مستلزمات دراسية", "ادوات مكتبية", "ادوات البناء ", "المعدات الثقيلة", "منتجات طبية", "اشياء معادة الصنع" });
            cmdProdoctTypes.Location = new Point(492, 122);
            cmdProdoctTypes.Name = "cmdProdoctTypes";
            cmdProdoctTypes.Size = new Size(186, 25);
            cmdProdoctTypes.TabIndex = 22;
            toolTip1.SetToolTip(cmdProdoctTypes, "prodoct tybe");
            // 
            // txtProdoctName
            // 
            txtProdoctName.Location = new Point(492, 174);
            txtProdoctName.Name = "txtProdoctName";
            txtProdoctName.Size = new Size(186, 23);
            txtProdoctName.TabIndex = 23;
            toolTip1.SetToolTip(txtProdoctName, "prodoct name");
            // 
            // txtProdoctCode
            // 
            txtProdoctCode.Location = new Point(492, 216);
            txtProdoctCode.Name = "txtProdoctCode";
            txtProdoctCode.Size = new Size(127, 23);
            txtProdoctCode.TabIndex = 24;
            toolTip1.SetToolTip(txtProdoctCode, "prodoct code");
            // 
            // txtProdoctPrice
            // 
            txtProdoctPrice.Location = new Point(492, 250);
            txtProdoctPrice.Name = "txtProdoctPrice";
            txtProdoctPrice.Size = new Size(127, 23);
            txtProdoctPrice.TabIndex = 25;
            toolTip1.SetToolTip(txtProdoctPrice, "enter pying price prodoct");
            // 
            // txtDescontPrise
            // 
            txtDescontPrise.Location = new Point(560, 297);
            txtDescontPrise.Name = "txtDescontPrise";
            txtDescontPrise.Size = new Size(106, 23);
            txtDescontPrise.TabIndex = 26;
            toolTip1.SetToolTip(txtDescontPrise, "the price After descount");
            // 
            // txtCustomerAdrres
            // 
            txtCustomerAdrres.Location = new Point(93, 75);
            txtCustomerAdrres.Name = "txtCustomerAdrres";
            txtCustomerAdrres.Size = new Size(219, 96);
            txtCustomerAdrres.TabIndex = 27;
            txtCustomerAdrres.Text = "";
            toolTip1.SetToolTip(txtCustomerAdrres, "persone adrres");
            // 
            // btnAddData
            // 
            btnAddData.BackColor = Color.FromArgb(0, 0, 64);
            btnAddData.Cursor = Cursors.Hand;
            btnAddData.FlatStyle = FlatStyle.Popup;
            btnAddData.ForeColor = Color.FromArgb(192, 192, 255);
            btnAddData.Location = new Point(12, 411);
            btnAddData.Name = "btnAddData";
            btnAddData.Size = new Size(96, 23);
            btnAddData.TabIndex = 28;
            btnAddData.Text = "اضافة بيانات";
            toolTip1.SetToolTip(btnAddData, "Add data");
            btnAddData.UseVisualStyleBackColor = false;
            btnAddData.Click += btnAddData_Click;
            // 
            // btnDelet
            // 
            btnDelet.BackColor = Color.FromArgb(0, 0, 64);
            btnDelet.Cursor = Cursors.Hand;
            btnDelet.FlatStyle = FlatStyle.Popup;
            btnDelet.ForeColor = Color.FromArgb(192, 192, 255);
            btnDelet.Location = new Point(137, 411);
            btnDelet.Name = "btnDelet";
            btnDelet.Size = new Size(96, 23);
            btnDelet.TabIndex = 30;
            btnDelet.Text = "حذف البيانات";
            toolTip1.SetToolTip(btnDelet, "Delet data");
            btnDelet.UseVisualStyleBackColor = false;
            btnDelet.Click += btnDelet_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.FromArgb(0, 0, 64);
            btnShow.Cursor = Cursors.Hand;
            btnShow.FlatStyle = FlatStyle.Popup;
            btnShow.ForeColor = Color.FromArgb(192, 192, 255);
            btnShow.Location = new Point(269, 411);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(96, 23);
            btnShow.TabIndex = 31;
            btnShow.Text = "عرض البيانات";
            toolTip1.SetToolTip(btnShow, "Show data");
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(0, 0, 64);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.FromArgb(192, 192, 255);
            btnClose.Location = new Point(535, 411);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 23);
            btnClose.TabIndex = 32;
            btnClose.Text = "غلق البرنامج";
            toolTip1.SetToolTip(btnClose, "Close the program");
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(0, 0, 64);
            btnFind.Cursor = Cursors.Hand;
            btnFind.FlatStyle = FlatStyle.Popup;
            btnFind.ForeColor = Color.FromArgb(192, 192, 255);
            btnFind.Location = new Point(405, 411);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(96, 23);
            btnFind.TabIndex = 33;
            btnFind.Text = "البحث عن عميل\r\n";
            toolTip1.SetToolTip(btnFind, "Find data");
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 200;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Nots";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(680, 467);
            Controls.Add(btnFind);
            Controls.Add(btnClose);
            Controls.Add(btnShow);
            Controls.Add(btnDelet);
            Controls.Add(btnAddData);
            Controls.Add(txtCustomerAdrres);
            Controls.Add(txtDescontPrise);
            Controls.Add(txtProdoctPrice);
            Controls.Add(txtProdoctCode);
            Controls.Add(txtProdoctName);
            Controls.Add(cmdProdoctTypes);
            Controls.Add(txtMarketName);
            Controls.Add(txtCombanyBranch);
            Controls.Add(txtCombanyName);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cmbCustomerSocialFeeling);
            Controls.Add(txtCustomerPhone);
            Controls.Add(txtCustomerEmail);
            Controls.Add(txtCustomerAge);
            Controls.Add(txtCustomerName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(700, 550);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "data call senter combany form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCustomerName;
        private TextBox txtCustomerAge;
        private TextBox txtCustomerEmail;
        private TextBox txtCustomerPhone;
        private ComboBox cmbCustomerSocialFeeling;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtCombanyName;
        private TextBox txtCombanyBranch;
        private TextBox txtMarketName;
        private ComboBox cmdProdoctTypes;
        private TextBox txtProdoctName;
        private TextBox txtProdoctCode;
        private TextBox txtProdoctPrice;
        private TextBox txtDescontPrise;
        private RichTextBox txtCustomerAdrres;
        private Button btnAddData;
        private Button btnDelet;
        private Button btnShow;
        private Button btnClose;
        private Button btnFind;
        private ToolTip toolTip1;
    }
}
