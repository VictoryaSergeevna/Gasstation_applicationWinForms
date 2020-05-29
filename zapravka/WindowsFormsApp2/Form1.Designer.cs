namespace WindowsFormsApp2
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
            this.grBoxRefueling = new System.Windows.Forms.GroupBox();
            this.labelGrn = new System.Windows.Forms.Label();
            this.lblLit = new System.Windows.Forms.Label();
            this.lblgrn = new System.Windows.Forms.Label();
            this.txtBoxSum = new System.Windows.Forms.TextBox();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.grBoxQuantity = new System.Windows.Forms.GroupBox();
            this.radButSum = new System.Windows.Forms.RadioButton();
            this.radButQuantity = new System.Windows.Forms.RadioButton();
            this.comboBoxPetrol = new System.Windows.Forms.ComboBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPetrol = new System.Windows.Forms.Label();
            this.grBoxPaymentPet = new System.Windows.Forms.GroupBox();
            this.lblSumGrn = new System.Windows.Forms.Label();
            this.txtBoxToPayGasSt = new System.Windows.Forms.TextBox();
            this.grBoxCafe = new System.Windows.Forms.GroupBox();
            this.txtBoxColaQuant = new System.Windows.Forms.TextBox();
            this.txtBoxFriQuant = new System.Windows.Forms.TextBox();
            this.txtBoxGambQuant = new System.Windows.Forms.TextBox();
            this.txtBoxHotDogQuant = new System.Windows.Forms.TextBox();
            this.txtBoxColaPrice = new System.Windows.Forms.TextBox();
            this.txtBoxFriPrice = new System.Windows.Forms.TextBox();
            this.txtBoxGambPrice = new System.Windows.Forms.TextBox();
            this.txtBoxHotDogPrice = new System.Windows.Forms.TextBox();
            this.lblCafeQuantyty = new System.Windows.Forms.Label();
            this.lblCafePrice = new System.Windows.Forms.Label();
            this.chBoxCola = new System.Windows.Forms.CheckBox();
            this.chBoxFri = new System.Windows.Forms.CheckBox();
            this.chBoxGamb = new System.Windows.Forms.CheckBox();
            this.chBoxHotDog = new System.Windows.Forms.CheckBox();
            this.grBoxPaymentCafe = new System.Windows.Forms.GroupBox();
            this.labCafeGrn = new System.Windows.Forms.Label();
            this.txtBoxToPayCafe = new System.Windows.Forms.TextBox();
            this.grBoxAll = new System.Windows.Forms.GroupBox();
            this.trackBarAllSum = new System.Windows.Forms.TrackBar();
            this.trackBarBestOil = new System.Windows.Forms.TrackBar();
            this.picBoxSmile = new System.Windows.Forms.PictureBox();
            this.lblPicture = new System.Windows.Forms.Label();
            this.lblScoreGrn = new System.Windows.Forms.Label();
            this.txtBoxToPayTotal = new System.Windows.Forms.TextBox();
            this.butToCount = new System.Windows.Forms.Button();
            this.trackBarCafe = new System.Windows.Forms.TrackBar();
            this.grBoxRefueling.SuspendLayout();
            this.grBoxQuantity.SuspendLayout();
            this.grBoxPaymentPet.SuspendLayout();
            this.grBoxCafe.SuspendLayout();
            this.grBoxPaymentCafe.SuspendLayout();
            this.grBoxAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAllSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBestOil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSmile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCafe)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxRefueling
            // 
            this.grBoxRefueling.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grBoxRefueling.Controls.Add(this.labelGrn);
            this.grBoxRefueling.Controls.Add(this.lblLit);
            this.grBoxRefueling.Controls.Add(this.lblgrn);
            this.grBoxRefueling.Controls.Add(this.txtBoxSum);
            this.grBoxRefueling.Controls.Add(this.txtBoxQuantity);
            this.grBoxRefueling.Controls.Add(this.grBoxQuantity);
            this.grBoxRefueling.Controls.Add(this.comboBoxPetrol);
            this.grBoxRefueling.Controls.Add(this.txtBoxPrice);
            this.grBoxRefueling.Controls.Add(this.lblPrice);
            this.grBoxRefueling.Controls.Add(this.lblPetrol);
            this.grBoxRefueling.Controls.Add(this.grBoxPaymentPet);
            this.grBoxRefueling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxRefueling.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grBoxRefueling.Location = new System.Drawing.Point(13, 12);
            this.grBoxRefueling.Name = "grBoxRefueling";
            this.grBoxRefueling.Size = new System.Drawing.Size(334, 306);
            this.grBoxRefueling.TabIndex = 0;
            this.grBoxRefueling.TabStop = false;
            this.grBoxRefueling.Text = "Автозаправка";
            // 
            // labelGrn
            // 
            this.labelGrn.AutoSize = true;
            this.labelGrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelGrn.Location = new System.Drawing.Point(268, 177);
            this.labelGrn.Name = "labelGrn";
            this.labelGrn.Size = new System.Drawing.Size(27, 13);
            this.labelGrn.TabIndex = 11;
            this.labelGrn.Text = "грн.";
            // 
            // lblLit
            // 
            this.lblLit.AutoSize = true;
            this.lblLit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblLit.Location = new System.Drawing.Point(268, 144);
            this.lblLit.Name = "lblLit";
            this.lblLit.Size = new System.Drawing.Size(16, 13);
            this.lblLit.TabIndex = 10;
            this.lblLit.Text = "л.";
            // 
            // lblgrn
            // 
            this.lblgrn.AutoSize = true;
            this.lblgrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblgrn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblgrn.Location = new System.Drawing.Point(285, 78);
            this.lblgrn.Name = "lblgrn";
            this.lblgrn.Size = new System.Drawing.Size(27, 13);
            this.lblgrn.TabIndex = 8;
            this.lblgrn.Text = "грн.";
            // 
            // txtBoxSum
            // 
            this.txtBoxSum.Enabled = false;
            this.txtBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxSum.Location = new System.Drawing.Point(182, 170);
            this.txtBoxSum.Name = "txtBoxSum";
            this.txtBoxSum.Size = new System.Drawing.Size(79, 22);
            this.txtBoxSum.TabIndex = 7;
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxQuantity.Location = new System.Drawing.Point(182, 138);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(79, 22);
            this.txtBoxQuantity.TabIndex = 6;
            // 
            // grBoxQuantity
            // 
            this.grBoxQuantity.Controls.Add(this.radButSum);
            this.grBoxQuantity.Controls.Add(this.radButQuantity);
            this.grBoxQuantity.Location = new System.Drawing.Point(6, 127);
            this.grBoxQuantity.Name = "grBoxQuantity";
            this.grBoxQuantity.Size = new System.Drawing.Size(131, 66);
            this.grBoxQuantity.TabIndex = 5;
            this.grBoxQuantity.TabStop = false;
            // 
            // radButSum
            // 
            this.radButSum.AutoSize = true;
            this.radButSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radButSum.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radButSum.Location = new System.Drawing.Point(7, 43);
            this.radButSum.Name = "radButSum";
            this.radButSum.Size = new System.Drawing.Size(69, 20);
            this.radButSum.TabIndex = 1;
            this.radButSum.TabStop = true;
            this.radButSum.Text = "Сумма";
            this.radButSum.UseVisualStyleBackColor = true;
            // 
            // radButQuantity
            // 
            this.radButQuantity.AutoSize = true;
            this.radButQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radButQuantity.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radButQuantity.Location = new System.Drawing.Point(7, 11);
            this.radButQuantity.Name = "radButQuantity";
            this.radButQuantity.Size = new System.Drawing.Size(104, 20);
            this.radButQuantity.TabIndex = 0;
            this.radButQuantity.TabStop = true;
            this.radButQuantity.Text = "Количество";
            this.radButQuantity.UseVisualStyleBackColor = true;
            // 
            // comboBoxPetrol
            // 
            this.comboBoxPetrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPetrol.FormattingEnabled = true;
            this.comboBoxPetrol.Location = new System.Drawing.Point(140, 39);
            this.comboBoxPetrol.Name = "comboBoxPetrol";
            this.comboBoxPetrol.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPetrol.TabIndex = 4;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Enabled = false;
            this.txtBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPrice.Location = new System.Drawing.Point(140, 71);
            this.txtBoxPrice.Multiline = true;
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.txtBoxPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPrice.Location = new System.Drawing.Point(20, 78);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Цена";
            // 
            // lblPetrol
            // 
            this.lblPetrol.AutoSize = true;
            this.lblPetrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPetrol.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPetrol.Location = new System.Drawing.Point(17, 38);
            this.lblPetrol.Name = "lblPetrol";
            this.lblPetrol.Size = new System.Drawing.Size(57, 16);
            this.lblPetrol.TabIndex = 1;
            this.lblPetrol.Text = "Бензин";
            // 
            // grBoxPaymentPet
            // 
            this.grBoxPaymentPet.Controls.Add(this.lblSumGrn);
            this.grBoxPaymentPet.Controls.Add(this.txtBoxToPayGasSt);
            this.grBoxPaymentPet.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grBoxPaymentPet.Location = new System.Drawing.Point(6, 199);
            this.grBoxPaymentPet.Name = "grBoxPaymentPet";
            this.grBoxPaymentPet.Size = new System.Drawing.Size(322, 100);
            this.grBoxPaymentPet.TabIndex = 0;
            this.grBoxPaymentPet.TabStop = false;
            this.grBoxPaymentPet.Text = "К оплате:";
            this.grBoxPaymentPet.Enter += new System.EventHandler(this.grBoxPaymentPet_Enter);
            // 
            // lblSumGrn
            // 
            this.lblSumGrn.AutoSize = true;
            this.lblSumGrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSumGrn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblSumGrn.Location = new System.Drawing.Point(275, 56);
            this.lblSumGrn.Name = "lblSumGrn";
            this.lblSumGrn.Size = new System.Drawing.Size(41, 13);
            this.lblSumGrn.TabIndex = 1;
            this.lblSumGrn.Text = "грн./л.";
            // 
            // txtBoxToPayGasSt
            // 
            this.txtBoxToPayGasSt.Enabled = false;
            this.txtBoxToPayGasSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxToPayGasSt.Location = new System.Drawing.Point(153, 34);
            this.txtBoxToPayGasSt.Name = "txtBoxToPayGasSt";
            this.txtBoxToPayGasSt.Size = new System.Drawing.Size(102, 35);
            this.txtBoxToPayGasSt.TabIndex = 0;
            // 
            // grBoxCafe
            // 
            this.grBoxCafe.Controls.Add(this.txtBoxColaQuant);
            this.grBoxCafe.Controls.Add(this.txtBoxFriQuant);
            this.grBoxCafe.Controls.Add(this.txtBoxGambQuant);
            this.grBoxCafe.Controls.Add(this.txtBoxHotDogQuant);
            this.grBoxCafe.Controls.Add(this.txtBoxColaPrice);
            this.grBoxCafe.Controls.Add(this.txtBoxFriPrice);
            this.grBoxCafe.Controls.Add(this.txtBoxGambPrice);
            this.grBoxCafe.Controls.Add(this.txtBoxHotDogPrice);
            this.grBoxCafe.Controls.Add(this.lblCafeQuantyty);
            this.grBoxCafe.Controls.Add(this.lblCafePrice);
            this.grBoxCafe.Controls.Add(this.chBoxCola);
            this.grBoxCafe.Controls.Add(this.chBoxFri);
            this.grBoxCafe.Controls.Add(this.chBoxGamb);
            this.grBoxCafe.Controls.Add(this.chBoxHotDog);
            this.grBoxCafe.Controls.Add(this.grBoxPaymentCafe);
            this.grBoxCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxCafe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grBoxCafe.Location = new System.Drawing.Point(382, 13);
            this.grBoxCafe.Name = "grBoxCafe";
            this.grBoxCafe.Size = new System.Drawing.Size(341, 305);
            this.grBoxCafe.TabIndex = 1;
            this.grBoxCafe.TabStop = false;
            this.grBoxCafe.Text = "Мини-кафе";
            // 
            // txtBoxColaQuant
            // 
            this.txtBoxColaQuant.Enabled = false;
            this.txtBoxColaQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxColaQuant.Location = new System.Drawing.Point(261, 105);
            this.txtBoxColaQuant.Name = "txtBoxColaQuant";
            this.txtBoxColaQuant.Size = new System.Drawing.Size(67, 22);
            this.txtBoxColaQuant.TabIndex = 14;
            // 
            // txtBoxFriQuant
            // 
            this.txtBoxFriQuant.Enabled = false;
            this.txtBoxFriQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxFriQuant.Location = new System.Drawing.Point(261, 81);
            this.txtBoxFriQuant.Name = "txtBoxFriQuant";
            this.txtBoxFriQuant.Size = new System.Drawing.Size(67, 22);
            this.txtBoxFriQuant.TabIndex = 13;
            // 
            // txtBoxGambQuant
            // 
            this.txtBoxGambQuant.Enabled = false;
            this.txtBoxGambQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxGambQuant.Location = new System.Drawing.Point(261, 58);
            this.txtBoxGambQuant.Name = "txtBoxGambQuant";
            this.txtBoxGambQuant.Size = new System.Drawing.Size(67, 22);
            this.txtBoxGambQuant.TabIndex = 12;
            // 
            // txtBoxHotDogQuant
            // 
            this.txtBoxHotDogQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxHotDogQuant.Location = new System.Drawing.Point(261, 34);
            this.txtBoxHotDogQuant.Name = "txtBoxHotDogQuant";
            this.txtBoxHotDogQuant.Size = new System.Drawing.Size(67, 22);
            this.txtBoxHotDogQuant.TabIndex = 11;
            // 
            // txtBoxColaPrice
            // 
            this.txtBoxColaPrice.Enabled = false;
            this.txtBoxColaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxColaPrice.Location = new System.Drawing.Point(161, 105);
            this.txtBoxColaPrice.Name = "txtBoxColaPrice";
            this.txtBoxColaPrice.Size = new System.Drawing.Size(61, 22);
            this.txtBoxColaPrice.TabIndex = 10;
            // 
            // txtBoxFriPrice
            // 
            this.txtBoxFriPrice.Enabled = false;
            this.txtBoxFriPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxFriPrice.Location = new System.Drawing.Point(161, 82);
            this.txtBoxFriPrice.Name = "txtBoxFriPrice";
            this.txtBoxFriPrice.Size = new System.Drawing.Size(61, 22);
            this.txtBoxFriPrice.TabIndex = 9;
            // 
            // txtBoxGambPrice
            // 
            this.txtBoxGambPrice.Enabled = false;
            this.txtBoxGambPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxGambPrice.Location = new System.Drawing.Point(161, 58);
            this.txtBoxGambPrice.Name = "txtBoxGambPrice";
            this.txtBoxGambPrice.Size = new System.Drawing.Size(61, 22);
            this.txtBoxGambPrice.TabIndex = 8;
            // 
            // txtBoxHotDogPrice
            // 
            this.txtBoxHotDogPrice.Enabled = false;
            this.txtBoxHotDogPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxHotDogPrice.Location = new System.Drawing.Point(161, 36);
            this.txtBoxHotDogPrice.Name = "txtBoxHotDogPrice";
            this.txtBoxHotDogPrice.Size = new System.Drawing.Size(61, 22);
            this.txtBoxHotDogPrice.TabIndex = 7;
            // 
            // lblCafeQuantyty
            // 
            this.lblCafeQuantyty.AutoSize = true;
            this.lblCafeQuantyty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCafeQuantyty.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCafeQuantyty.Location = new System.Drawing.Point(254, 16);
            this.lblCafeQuantyty.Name = "lblCafeQuantyty";
            this.lblCafeQuantyty.Size = new System.Drawing.Size(86, 16);
            this.lblCafeQuantyty.TabIndex = 6;
            this.lblCafeQuantyty.Text = "Количество";
            // 
            // lblCafePrice
            // 
            this.lblCafePrice.AutoSize = true;
            this.lblCafePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCafePrice.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCafePrice.Location = new System.Drawing.Point(158, 16);
            this.lblCafePrice.Name = "lblCafePrice";
            this.lblCafePrice.Size = new System.Drawing.Size(41, 16);
            this.lblCafePrice.TabIndex = 5;
            this.lblCafePrice.Text = "Цена";
            // 
            // chBoxCola
            // 
            this.chBoxCola.AutoSize = true;
            this.chBoxCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBoxCola.ForeColor = System.Drawing.SystemColors.InfoText;
            this.chBoxCola.Location = new System.Drawing.Point(17, 108);
            this.chBoxCola.Name = "chBoxCola";
            this.chBoxCola.Size = new System.Drawing.Size(93, 20);
            this.chBoxCola.TabIndex = 4;
            this.chBoxCola.Text = "Кока-кола";
            this.chBoxCola.UseVisualStyleBackColor = true;
            // 
            // chBoxFri
            // 
            this.chBoxFri.AutoSize = true;
            this.chBoxFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBoxFri.ForeColor = System.Drawing.SystemColors.InfoText;
            this.chBoxFri.Location = new System.Drawing.Point(17, 84);
            this.chBoxFri.Name = "chBoxFri";
            this.chBoxFri.Size = new System.Drawing.Size(121, 20);
            this.chBoxFri.TabIndex = 3;
            this.chBoxFri.Text = "Картошка-фри";
            this.chBoxFri.UseVisualStyleBackColor = true;
            // 
            // chBoxGamb
            // 
            this.chBoxGamb.AutoSize = true;
            this.chBoxGamb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBoxGamb.ForeColor = System.Drawing.SystemColors.InfoText;
            this.chBoxGamb.Location = new System.Drawing.Point(17, 61);
            this.chBoxGamb.Name = "chBoxGamb";
            this.chBoxGamb.Size = new System.Drawing.Size(97, 20);
            this.chBoxGamb.TabIndex = 2;
            this.chBoxGamb.Text = "Гамбургер";
            this.chBoxGamb.UseVisualStyleBackColor = true;
            // 
            // chBoxHotDog
            // 
            this.chBoxHotDog.AutoSize = true;
            this.chBoxHotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBoxHotDog.ForeColor = System.Drawing.SystemColors.InfoText;
            this.chBoxHotDog.Location = new System.Drawing.Point(17, 38);
            this.chBoxHotDog.Name = "chBoxHotDog";
            this.chBoxHotDog.Size = new System.Drawing.Size(76, 20);
            this.chBoxHotDog.TabIndex = 1;
            this.chBoxHotDog.Text = "Хот-дог";
            this.chBoxHotDog.UseVisualStyleBackColor = true;
            // 
            // grBoxPaymentCafe
            // 
            this.grBoxPaymentCafe.Controls.Add(this.labCafeGrn);
            this.grBoxPaymentCafe.Controls.Add(this.txtBoxToPayCafe);
            this.grBoxPaymentCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxPaymentCafe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grBoxPaymentCafe.Location = new System.Drawing.Point(17, 199);
            this.grBoxPaymentCafe.Name = "grBoxPaymentCafe";
            this.grBoxPaymentCafe.Size = new System.Drawing.Size(323, 100);
            this.grBoxPaymentCafe.TabIndex = 0;
            this.grBoxPaymentCafe.TabStop = false;
            this.grBoxPaymentCafe.Text = "К оплате:";
            // 
            // labCafeGrn
            // 
            this.labCafeGrn.AutoSize = true;
            this.labCafeGrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labCafeGrn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labCafeGrn.Location = new System.Drawing.Point(222, 55);
            this.labCafeGrn.Name = "labCafeGrn";
            this.labCafeGrn.Size = new System.Drawing.Size(27, 13);
            this.labCafeGrn.TabIndex = 1;
            this.labCafeGrn.Text = "грн.";
            // 
            // txtBoxToPayCafe
            // 
            this.txtBoxToPayCafe.Enabled = false;
            this.txtBoxToPayCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxToPayCafe.Location = new System.Drawing.Point(126, 40);
            this.txtBoxToPayCafe.Name = "txtBoxToPayCafe";
            this.txtBoxToPayCafe.Size = new System.Drawing.Size(90, 35);
            this.txtBoxToPayCafe.TabIndex = 0;
            // 
            // grBoxAll
            // 
            this.grBoxAll.Controls.Add(this.trackBarCafe);
            this.grBoxAll.Controls.Add(this.trackBarAllSum);
            this.grBoxAll.Controls.Add(this.trackBarBestOil);
            this.grBoxAll.Controls.Add(this.picBoxSmile);
            this.grBoxAll.Controls.Add(this.lblPicture);
            this.grBoxAll.Controls.Add(this.lblScoreGrn);
            this.grBoxAll.Controls.Add(this.txtBoxToPayTotal);
            this.grBoxAll.Controls.Add(this.butToCount);
            this.grBoxAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxAll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grBoxAll.Location = new System.Drawing.Point(19, 324);
            this.grBoxAll.Name = "grBoxAll";
            this.grBoxAll.Size = new System.Drawing.Size(704, 155);
            this.grBoxAll.TabIndex = 4;
            this.grBoxAll.TabStop = false;
            this.grBoxAll.Text = "ВСЕГО к оплате:";
            // 
            // trackBarAllSum
            // 
            this.trackBarAllSum.Location = new System.Drawing.Point(515, 18);
            this.trackBarAllSum.Name = "trackBarAllSum";
            this.trackBarAllSum.Size = new System.Drawing.Size(177, 45);
            this.trackBarAllSum.TabIndex = 6;
            this.trackBarAllSum.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trackBarBestOil
            // 
            this.trackBarBestOil.Location = new System.Drawing.Point(148, 18);
            this.trackBarBestOil.Name = "trackBarBestOil";
            this.trackBarBestOil.Size = new System.Drawing.Size(151, 45);
            this.trackBarBestOil.TabIndex = 5;
            this.trackBarBestOil.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // picBoxSmile
            // 
            this.picBoxSmile.Location = new System.Drawing.Point(-6, 31);
            this.picBoxSmile.Name = "picBoxSmile";
            this.picBoxSmile.Size = new System.Drawing.Size(135, 118);
            this.picBoxSmile.TabIndex = 4;
            this.picBoxSmile.TabStop = false;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(3, 18);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(0, 16);
            this.lblPicture.TabIndex = 3;
            // 
            // lblScoreGrn
            // 
            this.lblScoreGrn.AutoSize = true;
            this.lblScoreGrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScoreGrn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblScoreGrn.Location = new System.Drawing.Point(640, 110);
            this.lblScoreGrn.Name = "lblScoreGrn";
            this.lblScoreGrn.Size = new System.Drawing.Size(27, 13);
            this.lblScoreGrn.TabIndex = 2;
            this.lblScoreGrn.Text = "грн.";
            // 
            // txtBoxToPayTotal
            // 
            this.txtBoxToPayTotal.Enabled = false;
            this.txtBoxToPayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxToPayTotal.Location = new System.Drawing.Point(512, 92);
            this.txtBoxToPayTotal.Name = "txtBoxToPayTotal";
            this.txtBoxToPayTotal.Size = new System.Drawing.Size(122, 38);
            this.txtBoxToPayTotal.TabIndex = 1;
            // 
            // butToCount
            // 
            this.butToCount.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butToCount.Location = new System.Drawing.Point(331, 91);
            this.butToCount.Name = "butToCount";
            this.butToCount.Size = new System.Drawing.Size(146, 51);
            this.butToCount.TabIndex = 0;
            this.butToCount.Text = "Посчитать";
            this.butToCount.UseVisualStyleBackColor = true;
            // 
            // trackBarCafe
            // 
            this.trackBarCafe.Location = new System.Drawing.Point(326, 18);
            this.trackBarCafe.Name = "trackBarCafe";
            this.trackBarCafe.Size = new System.Drawing.Size(151, 45);
            this.trackBarCafe.TabIndex = 7;
            this.trackBarCafe.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(723, 491);
            this.Controls.Add(this.grBoxAll);
            this.Controls.Add(this.grBoxCafe);
            this.Controls.Add(this.grBoxRefueling);
            this.Name = "Form1";
            this.Text = "BestOil";
            this.grBoxRefueling.ResumeLayout(false);
            this.grBoxRefueling.PerformLayout();
            this.grBoxQuantity.ResumeLayout(false);
            this.grBoxQuantity.PerformLayout();
            this.grBoxPaymentPet.ResumeLayout(false);
            this.grBoxPaymentPet.PerformLayout();
            this.grBoxCafe.ResumeLayout(false);
            this.grBoxCafe.PerformLayout();
            this.grBoxPaymentCafe.ResumeLayout(false);
            this.grBoxPaymentCafe.PerformLayout();
            this.grBoxAll.ResumeLayout(false);
            this.grBoxAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAllSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBestOil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSmile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCafe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxRefueling;
        private System.Windows.Forms.Label labelGrn;
        private System.Windows.Forms.Label lblLit;
        private System.Windows.Forms.Label lblgrn;
        private System.Windows.Forms.TextBox txtBoxSum;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.GroupBox grBoxQuantity;
        private System.Windows.Forms.RadioButton radButSum;
        private System.Windows.Forms.RadioButton radButQuantity;
        private System.Windows.Forms.ComboBox comboBoxPetrol;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPetrol;
        private System.Windows.Forms.GroupBox grBoxPaymentPet;
        private System.Windows.Forms.Label lblSumGrn;
        private System.Windows.Forms.TextBox txtBoxToPayGasSt;
        private System.Windows.Forms.GroupBox grBoxCafe;
        private System.Windows.Forms.Label lblCafeQuantyty;
        private System.Windows.Forms.Label lblCafePrice;
        private System.Windows.Forms.CheckBox chBoxCola;
        private System.Windows.Forms.CheckBox chBoxFri;
        private System.Windows.Forms.CheckBox chBoxGamb;
        private System.Windows.Forms.CheckBox chBoxHotDog;
        private System.Windows.Forms.GroupBox grBoxPaymentCafe;
        private System.Windows.Forms.Label labCafeGrn;
        private System.Windows.Forms.TextBox txtBoxToPayCafe;
        private System.Windows.Forms.GroupBox grBoxAll;
        private System.Windows.Forms.Label lblScoreGrn;
        private System.Windows.Forms.TextBox txtBoxToPayTotal;
        private System.Windows.Forms.Button butToCount;
        private System.Windows.Forms.TextBox txtBoxColaQuant;
        private System.Windows.Forms.TextBox txtBoxFriQuant;
        private System.Windows.Forms.TextBox txtBoxGambQuant;
        private System.Windows.Forms.TextBox txtBoxHotDogQuant;
        private System.Windows.Forms.TextBox txtBoxColaPrice;
        private System.Windows.Forms.TextBox txtBoxFriPrice;
        private System.Windows.Forms.TextBox txtBoxGambPrice;
        private System.Windows.Forms.TextBox txtBoxHotDogPrice;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.PictureBox picBoxSmile;
        private System.Windows.Forms.TrackBar trackBarAllSum;
        private System.Windows.Forms.TrackBar trackBarBestOil;
        private System.Windows.Forms.TrackBar trackBarCafe;
    }
}

