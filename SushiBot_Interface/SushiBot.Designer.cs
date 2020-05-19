namespace Sushi_bot
{
    public partial class SushiBot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>       
        bool sushiChecked;
        bool nameIsChanged;
        bool paymentIsChanged;
        bool telNumberIsChanged;
        bool emailIsChanged;
        bool streetIsChanged;
        bool homeIsChanged;
        bool quarterIsChanged;
        int progressBarStep = 10;
        double totalPrice;
        int progressBar1MaxValue = 80;
        const string webSiteSushiVesla = "https://sushivesla.by/";
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Спайси текка маки", 0, 0);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Сяке маки", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Спайси сяке маки");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Текка маки");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Авокадо маки");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Сяке авокадо маки");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Каппа маки");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Унаги маки");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Спайси кунсей маки");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Энсёку маки");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Катори маки");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Сяке оригами маки");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Суши", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SushiBot));
            this.CompleteOrder = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBoxChahgeOrganization = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTelNumber = new System.Windows.Forms.TextBox();
            this.contactInformation = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.CommenLabel = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelPayment = new System.Windows.Forms.Label();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelHome = new System.Windows.Forms.Label();
            this.textBoxHome = new System.Windows.Forms.TextBox();
            this.labelQuarter = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxMoneySum = new System.Windows.Forms.TextBox();
            this.labelMoneySdacha = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.products = new System.Windows.Forms.Label();
            this.barProgressText = new System.Windows.Forms.Label();
            this.truePurchaseBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CompleteOrder
            // 
            this.CompleteOrder.BackColor = System.Drawing.Color.Red;
            this.CompleteOrder.Location = new System.Drawing.Point(379, 726);
            this.CompleteOrder.Name = "CompleteOrder";
            this.CompleteOrder.Size = new System.Drawing.Size(75, 23);
            this.CompleteOrder.TabIndex = 0;
            this.CompleteOrder.Text = "Заказать!";
            this.CompleteOrder.UseVisualStyleBackColor = false;
            this.CompleteOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Red;
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(16, 710);
            this.progressBar1.Maximum = 80;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(320, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // comboBoxChahgeOrganization
            // 
            this.comboBoxChahgeOrganization.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxChahgeOrganization.Items.AddRange(new object[] {
            "",
            "Суши Вёсла"});
            this.comboBoxChahgeOrganization.Location = new System.Drawing.Point(217, 25);
            this.comboBoxChahgeOrganization.Name = "comboBoxChahgeOrganization";
            this.comboBoxChahgeOrganization.Size = new System.Drawing.Size(331, 21);
            this.comboBoxChahgeOrganization.TabIndex = 3;
            this.comboBoxChahgeOrganization.SelectedIndexChanged += new System.EventHandler(this.comboBoxChahgeOrganization_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(185, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите организацию, у которой хотите заказать суши";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Укажите своё имя :";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxName.Location = new System.Drawing.Point(12, 94);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(324, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Мобильный телефон (+375 XX XXXXXXX)";
            // 
            // textBoxTelNumber
            // 
            this.textBoxTelNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTelNumber.Location = new System.Drawing.Point(12, 141);
            this.textBoxTelNumber.Name = "textBoxTelNumber";
            this.textBoxTelNumber.Size = new System.Drawing.Size(324, 20);
            this.textBoxTelNumber.TabIndex = 8;
            this.textBoxTelNumber.TextChanged += new System.EventHandler(this.textBoxTelNumber_TextChanged);
            // 
            // contactInformation
            // 
            this.contactInformation.AutoSize = true;
            this.contactInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contactInformation.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactInformation.ForeColor = System.Drawing.Color.Black;
            this.contactInformation.Location = new System.Drawing.Point(12, 49);
            this.contactInformation.Name = "contactInformation";
            this.contactInformation.Size = new System.Drawing.Size(265, 25);
            this.contactInformation.TabIndex = 9;
            this.contactInformation.Text = "Контактная информация :";
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.emailText.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailText.Location = new System.Drawing.Point(13, 164);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(171, 21);
            this.emailText.TabIndex = 10;
            this.emailText.Text = "Укажите свой Email :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxEmail.Location = new System.Drawing.Point(12, 188);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(324, 20);
            this.textBoxEmail.TabIndex = 11;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // CommenLabel
            // 
            this.CommenLabel.AutoSize = true;
            this.CommenLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CommenLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommenLabel.Location = new System.Drawing.Point(12, 259);
            this.CommenLabel.Name = "CommenLabel";
            this.CommenLabel.Size = new System.Drawing.Size(194, 21);
            this.CommenLabel.TabIndex = 12;
            this.CommenLabel.Text = "Комментарий к заказу :";
            // 
            // textBoxComment
            // 
            this.textBoxComment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxComment.Location = new System.Drawing.Point(12, 284);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(324, 50);
            this.textBoxComment.TabIndex = 13;
            this.textBoxComment.TextChanged += new System.EventHandler(this.textBoxComment_TextChanged);
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelPayment.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPayment.Location = new System.Drawing.Point(13, 211);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(80, 21);
            this.labelPayment.TabIndex = 14;
            this.labelPayment.Text = "Оплата :";
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Items.AddRange(new object[] {
            "",
            "Наличные",
            "Картой онлайн",
            "Картой курьеру"});
            this.comboBoxPayment.Location = new System.Drawing.Point(12, 235);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(324, 21);
            this.comboBoxPayment.TabIndex = 15;
            this.comboBoxPayment.SelectedIndexChanged += new System.EventHandler(this.comboBoxPayment_SelectedIndexChanged);
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelAdress.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdress.Location = new System.Drawing.Point(485, 49);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(164, 25);
            this.labelAdress.TabIndex = 16;
            this.labelAdress.Text = "Адрес доставки :";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelStreet.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStreet.Location = new System.Drawing.Point(486, 70);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(65, 21);
            this.labelStreet.TabIndex = 17;
            this.labelStreet.Text = "Улица :";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxStreet.Location = new System.Drawing.Point(487, 94);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(301, 20);
            this.textBoxStreet.TabIndex = 18;
            this.textBoxStreet.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelHome.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHome.Location = new System.Drawing.Point(486, 117);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(51, 21);
            this.labelHome.TabIndex = 19;
            this.labelHome.Text = "Дом :";
            // 
            // textBoxHome
            // 
            this.textBoxHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxHome.Location = new System.Drawing.Point(487, 141);
            this.textBoxHome.Name = "textBoxHome";
            this.textBoxHome.Size = new System.Drawing.Size(301, 20);
            this.textBoxHome.TabIndex = 20;
            this.textBoxHome.TextChanged += new System.EventHandler(this.textBoxHome_TextChanged);
            // 
            // labelQuarter
            // 
            this.labelQuarter.AutoSize = true;
            this.labelQuarter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelQuarter.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuarter.Location = new System.Drawing.Point(486, 164);
            this.labelQuarter.Name = "labelQuarter";
            this.labelQuarter.Size = new System.Drawing.Size(96, 21);
            this.labelQuarter.TabIndex = 21;
            this.labelQuarter.Text = "Квартира :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(487, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 20);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxMoneySum
            // 
            this.textBoxMoneySum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMoneySum.Enabled = false;
            this.textBoxMoneySum.Location = new System.Drawing.Point(487, 236);
            this.textBoxMoneySum.Name = "textBoxMoneySum";
            this.textBoxMoneySum.Size = new System.Drawing.Size(301, 20);
            this.textBoxMoneySum.TabIndex = 23;
            this.textBoxMoneySum.TextChanged += new System.EventHandler(this.textBoxMoneySum_TextChanged);
            // 
            // labelMoneySdacha
            // 
            this.labelMoneySdacha.AutoSize = true;
            this.labelMoneySdacha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelMoneySdacha.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoneySdacha.Location = new System.Drawing.Point(487, 211);
            this.labelMoneySdacha.Name = "labelMoneySdacha";
            this.labelMoneySdacha.Size = new System.Drawing.Size(0, 21);
            this.labelMoneySdacha.TabIndex = 24;
            this.labelMoneySdacha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSum.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(491, 679);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(181, 28);
            this.labelSum.TabIndex = 25;
            this.labelSum.Text = "Сумма заказа : 0 ";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.Black;
            this.treeView1.ImageIndex = 71;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Indent = 73;
            this.treeView1.ItemHeight = 70;
            this.treeView1.LabelEdit = true;
            this.treeView1.LineColor = System.Drawing.Color.WhiteSmoke;
            this.treeView1.Location = new System.Drawing.Point(12, 368);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "SpicyTeccaMaki";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Tag = "5,90";
            treeNode1.Text = "Спайси текка маки";
            treeNode1.ToolTipText = "Тунец, острый соус, васаби 0,5 г";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "SyakeMaki";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Tag = "5,30";
            treeNode2.Text = "Сяке маки";
            treeNode2.ToolTipText = "Лосось, васаби 0,5 г";
            treeNode3.ImageKey = "spicy_syace_maki_b.png";
            treeNode3.Name = "SpicySyakeMake";
            treeNode3.SelectedImageKey = "spicy_syace_maki_b.png";
            treeNode3.Tag = "5,80";
            treeNode3.Text = "Спайси сяке маки";
            treeNode3.ToolTipText = "Лосось, острый соус, васаби 0,5 г";
            treeNode4.ImageKey = "tekka_maki_b.png";
            treeNode4.Name = "TeccaMaki";
            treeNode4.SelectedImageKey = "tekka_maki_b.png";
            treeNode4.Tag = "5,80";
            treeNode4.Text = "Текка маки";
            treeNode4.ToolTipText = "Тунец, васаби 0,5 г";
            treeNode5.ImageKey = "avocado_maki_b.png";
            treeNode5.Name = "AvocadoMaki";
            treeNode5.SelectedImageKey = "avocado_maki_b.png";
            treeNode5.Tag = "3,90";
            treeNode5.Text = "Авокадо маки";
            treeNode5.ToolTipText = "Авокадо, майонез, васаби 0,5 г";
            treeNode6.ImageKey = "syace_avocado_maki_b.png";
            treeNode6.Name = "SyakeAvocadoMaki";
            treeNode6.SelectedImageKey = "syace_avocado_maki_b.png";
            treeNode6.Tag = "7,40";
            treeNode6.Text = "Сяке авокадо маки";
            treeNode6.ToolTipText = "Лосось, авокадо, васаби 0,5 г";
            treeNode7.ImageKey = "kappa_maki_b.png";
            treeNode7.Name = "CappaMaki";
            treeNode7.SelectedImageKey = "kappa_maki_b.png";
            treeNode7.Tag = "3,10";
            treeNode7.Text = "Каппа маки";
            treeNode7.ToolTipText = "Огурец, кунжут, васаби 0,5 г";
            treeNode8.ImageKey = "unagi_maki_b.png";
            treeNode8.Name = "UnagiMaki";
            treeNode8.SelectedImageKey = "unagi_maki_b.png";
            treeNode8.Tag = "7,30";
            treeNode8.Text = "Унаги маки";
            treeNode8.ToolTipText = "Угорь копченый, огурец, васаби 0,5 г";
            treeNode9.ImageKey = "spicy_kunsei_maki_b.png";
            treeNode9.Name = "SpicyKunseiMaki";
            treeNode9.SelectedImageKey = "spicy_kunsei_maki_b.png";
            treeNode9.Tag = "6,90";
            treeNode9.Text = "Спайси кунсей маки";
            treeNode9.ToolTipText = "Лосось копчёный, зелёный лук, острый соус, васаби 0,5 г";
            treeNode10.ImageKey = "Ensecu_maki_b.png";
            treeNode10.Name = "EnsecuMaki";
            treeNode10.SelectedImageKey = "Ensecu_maki_b.png";
            treeNode10.Tag = "7,40";
            treeNode10.Text = "Энсёку маки";
            treeNode10.ToolTipText = "Креветка тигровая, творожный сыр, икра Масаго, васаби 0,5 г";
            treeNode11.ImageKey = "katori_maki_b.png";
            treeNode11.Name = "CatoriMaki";
            treeNode11.SelectedImageKey = "katori_maki_b.png";
            treeNode11.Tag = "6,90";
            treeNode11.Text = "Катори маки";
            treeNode11.ToolTipText = "Лосось, авокадо, творожный сыр, соевая бумага Маменори, васаби 0,5 г";
            treeNode12.ImageKey = "syace_origami_maki_b.png";
            treeNode12.Name = "SyakeOrigameMaki";
            treeNode12.SelectedImageKey = "syace_origami_maki_b.png";
            treeNode12.Tag = "9,50";
            treeNode12.Text = "Сяке оригами маки";
            treeNode12.ToolTipText = "Лосось, творожный сыр, водоросли хияши вакаме, сыр Тофу, икра летучей рыбы черная" +
    ", васаби 0,5 г";
            treeNode13.ImageKey = "arizona_maki_b.png";
            treeNode13.Name = "Суши";
            treeNode13.SelectedImageKey = "arizona_maki_b.png";
            treeNode13.StateImageKey = "(none)";
            treeNode13.Text = "Суши";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView1.SelectedImageIndex = 71;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(324, 308);
            this.treeView1.TabIndex = 10;
            this.treeView1.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView1_NodeMouseHover);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "spicy_tekka_maki_b.png");
            this.imageList1.Images.SetKeyName(1, "syace_maki_b.png");
            this.imageList1.Images.SetKeyName(2, "arizona_maki_b.png");
            this.imageList1.Images.SetKeyName(3, "asahi_maki_b.png");
            this.imageList1.Images.SetKeyName(4, "atami_maki_b.png");
            this.imageList1.Images.SetKeyName(5, "avocado_maki_b.png");
            this.imageList1.Images.SetKeyName(6, "bacon_cerry_maki.png");
            this.imageList1.Images.SetKeyName(7, "bacon_maki.png");
            this.imageList1.Images.SetKeyName(8, "bacon_tai_maki.png");
            this.imageList1.Images.SetKeyName(9, "bacon_teriyaki_maki.png");
            this.imageList1.Images.SetKeyName(10, "bunsai_maki_b.png");
            this.imageList1.Images.SetKeyName(11, "california_maki_b.png");
            this.imageList1.Images.SetKeyName(12, "carada_maki_b.png");
            this.imageList1.Images.SetKeyName(13, "cheese_cunsei_maki.png");
            this.imageList1.Images.SetKeyName(14, "chuka_maki.png");
            this.imageList1.Images.SetKeyName(15, "cunsei_maki.png");
            this.imageList1.Images.SetKeyName(16, "daisen_maki_b.png");
            this.imageList1.Images.SetKeyName(17, "ebi_fresh_maki.png");
            this.imageList1.Images.SetKeyName(18, "Ensecu_maki_b.png");
            this.imageList1.Images.SetKeyName(19, "filla1plus1.jpg");
            this.imageList1.Images.SetKeyName(20, "fuji_maki_b.png");
            this.imageList1.Images.SetKeyName(21, "hokkaido_maki_b.png");
            this.imageList1.Images.SetKeyName(22, "hokku_maki.png");
            this.imageList1.Images.SetKeyName(23, "jade_maki.png");
            this.imageList1.Images.SetKeyName(24, "jakitori_maki.png");
            this.imageList1.Images.SetKeyName(25, "jasai_maki.png");
            this.imageList1.Images.SetKeyName(26, "kabuki_maki.png");
            this.imageList1.Images.SetKeyName(27, "kappa_maki_b.png");
            this.imageList1.Images.SetKeyName(28, "karai_maki_b.png");
            this.imageList1.Images.SetKeyName(29, "katori_maki_b.png");
            this.imageList1.Images.SetKeyName(30, "kayso_maki_b.png");
            this.imageList1.Images.SetKeyName(31, "kyari_maki_b.png");
            this.imageList1.Images.SetKeyName(32, "maguro_fresh_maki.png");
            this.imageList1.Images.SetKeyName(33, "mango_syace_maki.png");
            this.imageList1.Images.SetKeyName(34, "mango_tai_maki.png");
            this.imageList1.Images.SetKeyName(35, "marioka1plus1.jpg");
            this.imageList1.Images.SetKeyName(36, "masago_cunsei_maki.png");
            this.imageList1.Images.SetKeyName(37, "masago_tai_maki.png");
            this.imageList1.Images.SetKeyName(38, "mijagi1plus1.jpg");
            this.imageList1.Images.SetKeyName(39, "nara_maki_b.png");
            this.imageList1.Images.SetKeyName(40, "new_filladelphia_maki_b.png");
            this.imageList1.Images.SetKeyName(41, "okinawa_maki.png");
            this.imageList1.Images.SetKeyName(42, "omura_maki.png");
            this.imageList1.Images.SetKeyName(43, "orange_tai_maki.png");
            this.imageList1.Images.SetKeyName(44, "osaka_maki_b.png");
            this.imageList1.Images.SetKeyName(45, "sakura_maki_b.png");
            this.imageList1.Images.SetKeyName(46, "sapporo1plus1.jpg");
            this.imageList1.Images.SetKeyName(47, "sendai_maki_b.png");
            this.imageList1.Images.SetKeyName(48, "shimoda_maki_b.png");
            this.imageList1.Images.SetKeyName(49, "sijakeblack1plus1.jpg");
            this.imageList1.Images.SetKeyName(50, "spicy_kiary_maki.png");
            this.imageList1.Images.SetKeyName(51, "spicy_kunsei_maki_b.png");
            this.imageList1.Images.SetKeyName(52, "spicy_syace_maki_b.png");
            this.imageList1.Images.SetKeyName(53, "spicy_tekka_maki_b.png");
            this.imageList1.Images.SetKeyName(54, "surimi_red_maki.png");
            this.imageList1.Images.SetKeyName(55, "syace_avocado_maki_b.png");
            this.imageList1.Images.SetKeyName(56, "syace_delux_maki.png");
            this.imageList1.Images.SetKeyName(57, "syace_maki_b.png");
            this.imageList1.Images.SetKeyName(58, "syace_origami_maki_b.png");
            this.imageList1.Images.SetKeyName(59, "syace_yasai_maki.png");
            this.imageList1.Images.SetKeyName(60, "tai_maki.png");
            this.imageList1.Images.SetKeyName(61, "tai_teriyaki_maki.png");
            this.imageList1.Images.SetKeyName(62, "tamago_maki.png");
            this.imageList1.Images.SetKeyName(63, "tekka_maki_b.png");
            this.imageList1.Images.SetKeyName(64, "tojama_maki_b.png");
            this.imageList1.Images.SetKeyName(65, "tokyo_maki_b.png");
            this.imageList1.Images.SetKeyName(66, "tori_cunsei_maki.png");
            this.imageList1.Images.SetKeyName(67, "umai_fresh_maki.png");
            this.imageList1.Images.SetKeyName(68, "umai_maki_b.png");
            this.imageList1.Images.SetKeyName(69, "unagi_maki_b.png");
            this.imageList1.Images.SetKeyName(70, "washiki_maki.png");
            this.imageList1.Images.SetKeyName(71, "Maki.png");
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "dddd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(486, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ваш заказ :";
            this.label4.UseWaitCursor = true;
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treeView2.ImageIndex = 0;
            this.treeView2.ImageList = this.imageList1;
            this.treeView2.ItemHeight = 70;
            this.treeView2.Location = new System.Drawing.Point(490, 368);
            this.treeView2.Name = "treeView2";
            this.treeView2.SelectedImageIndex = 0;
            this.treeView2.ShowLines = false;
            this.treeView2.ShowPlusMinus = false;
            this.treeView2.ShowRootLines = false;
            this.treeView2.Size = new System.Drawing.Size(298, 308);
            this.treeView2.TabIndex = 27;
            this.treeView2.DoubleClick += new System.EventHandler(this.treeView2_DoubleClick);
            // 
            // products
            // 
            this.products.AutoSize = true;
            this.products.BackColor = System.Drawing.Color.WhiteSmoke;
            this.products.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.products.Location = new System.Drawing.Point(13, 337);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(132, 28);
            this.products.TabIndex = 28;
            this.products.Text = "Продукция :";
            // 
            // barProgressText
            // 
            this.barProgressText.AutoSize = true;
            this.barProgressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.barProgressText.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barProgressText.Location = new System.Drawing.Point(11, 679);
            this.barProgressText.Name = "barProgressText";
            this.barProgressText.Size = new System.Drawing.Size(325, 28);
            this.barProgressText.TabIndex = 29;
            this.barProgressText.Text = "Прогресс заполненности полей :";
            // 
            // truePurchaseBox
            // 
            this.truePurchaseBox.AutoSize = true;
            this.truePurchaseBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.truePurchaseBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.truePurchaseBox.Location = new System.Drawing.Point(487, 284);
            this.truePurchaseBox.Name = "truePurchaseBox";
            this.truePurchaseBox.Size = new System.Drawing.Size(276, 25);
            this.truePurchaseBox.TabIndex = 30;
            this.truePurchaseBox.Text = "Заказать суши по настоящему?";
            this.truePurchaseBox.UseVisualStyleBackColor = false;
            this.truePurchaseBox.CheckedChanged += new System.EventHandler(this.truePurchaseBox_CheckedChanged);
            // 
            // SushiBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Sushi_bot.Properties.Resources.depositphotos_78368972_stock_illustration_sushi_and_rolls_seamless_pattern;
            this.ClientSize = new System.Drawing.Size(796, 757);
            this.Controls.Add(this.truePurchaseBox);
            this.Controls.Add(this.barProgressText);
            this.Controls.Add(this.products);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelMoneySdacha);
            this.Controls.Add(this.textBoxMoneySum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelQuarter);
            this.Controls.Add(this.textBoxHome);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.comboBoxPayment);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.CommenLabel);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.contactInformation);
            this.Controls.Add(this.textBoxTelNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChahgeOrganization);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CompleteOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 800);
            this.MinimumSize = new System.Drawing.Size(816, 800);
            this.Name = "SushiBot";
            this.Text = "Суши Бот";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CompleteOrder;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBoxChahgeOrganization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTelNumber;
        private System.Windows.Forms.Label contactInformation;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label CommenLabel;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.TextBox textBoxHome;
        private System.Windows.Forms.Label labelQuarter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxMoneySum;
        private System.Windows.Forms.Label labelMoneySdacha;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label products;
        private System.Windows.Forms.Label barProgressText;
        private System.Windows.Forms.CheckBox truePurchaseBox;
    }
}

