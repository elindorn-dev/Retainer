namespace Retainer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.comboBox_head = new System.Windows.Forms.ComboBox();
            this.comboBox_respiratory_tract = new System.Windows.Forms.ComboBox();
            this.comboBox_heart = new System.Windows.Forms.ComboBox();
            this.comboBox_circulatory_system = new System.Windows.Forms.ComboBox();
            this.comboBox_intestines = new System.Windows.Forms.ComboBox();
            this.comboBox_eyes = new System.Windows.Forms.ComboBox();
            this.comboBox_oral_cavity = new System.Windows.Forms.ComboBox();
            this.comboBox_kidneys = new System.Windows.Forms.ComboBox();
            this.comboBox_liver = new System.Windows.Forms.ComboBox();
            this.comboBox_stomach = new System.Windows.Forms.ComboBox();
            this.btnFixing = new System.Windows.Forms.Button();
            this.pictureBox_fixing = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHealth = new System.Windows.Forms.Button();
            this.btnSport = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnNotebook = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.SideMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fixing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фиксатор твоих ежедневных событий";
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.SideMenu.Controls.Add(this.flowLayoutPanel1);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 40);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(200, 560);
            this.SideMenu.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnHealth);
            this.flowLayoutPanel1.Controls.Add(this.btnSport);
            this.flowLayoutPanel1.Controls.Add(this.btnTasks);
            this.flowLayoutPanel1.Controls.Add(this.btnNotebook);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 251);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // timerMain
            // 
            this.timerMain.Interval = 10;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // comboBox_head
            // 
            this.comboBox_head.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_head.FormattingEnabled = true;
            this.comboBox_head.Items.AddRange(new object[] {
            "Головная боль",
            "Головокружение",
            "Ощущение давления или тяжести в голове",
            "Потеря сознания",
            "Предобморочное состояние",
            "Шум или звон в ушах",
            "Нарушение равновесия",
            "Нарушение координации",
            "Помутнение зрения",
            "Двоение в глазах",
            "Онемение лица",
            "Слабость в лице или конечностях",
            "Нарушение речи",
            "Нарушение памяти",
            "Спутанность сознания",
            "Тошнота или рвота",
            "Светобоязнь",
            "Повышенная чувствительность к звукам",
            "Судороги",
            "Нарушение сна"});
            this.comboBox_head.Location = new System.Drawing.Point(206, 87);
            this.comboBox_head.Name = "comboBox_head";
            this.comboBox_head.Size = new System.Drawing.Size(185, 26);
            this.comboBox_head.TabIndex = 3;
            this.comboBox_head.SelectedIndexChanged += new System.EventHandler(this.comboBox_head_SelectedIndexChanged);
            this.comboBox_head.TextUpdate += new System.EventHandler(this.comboBox_head_TextUpdate);
            // 
            // comboBox_respiratory_tract
            // 
            this.comboBox_respiratory_tract.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_respiratory_tract.FormattingEnabled = true;
            this.comboBox_respiratory_tract.Items.AddRange(new object[] {
            "Кашель",
            "Одышка",
            "Затруднённое дыхание",
            "Ощущение нехватки воздуха",
            "Свистящее дыхание",
            "Боль или дискомфорт в груди",
            "Мокрота",
            "Кровь при кашле",
            "Заложенность носа",
            "Насморк",
            "Чихание",
            "Боль или раздражение в горле",
            "Осиплость голоса",
            "Частое дыхание",
            "Шумное дыхание",
            "Приступы удушья",
            "Ощущение сдавленности в груди",
            "Повышенная температура",
            "Озноб",
            "Слабость и утомляемость"});
            this.comboBox_respiratory_tract.Location = new System.Drawing.Point(206, 200);
            this.comboBox_respiratory_tract.Name = "comboBox_respiratory_tract";
            this.comboBox_respiratory_tract.Size = new System.Drawing.Size(183, 26);
            this.comboBox_respiratory_tract.TabIndex = 4;
            this.comboBox_respiratory_tract.SelectedIndexChanged += new System.EventHandler(this.comboBox_respiratory_tract_SelectedIndexChanged);
            this.comboBox_respiratory_tract.TextUpdate += new System.EventHandler(this.comboBox_respiratory_tract_TextUpdate);
            // 
            // comboBox_heart
            // 
            this.comboBox_heart.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_heart.FormattingEnabled = true;
            this.comboBox_heart.Items.AddRange(new object[] {
            "Боль или дискомфорт в груди",
            "Одышка",
            "Учащённое сердцебиение",
            "Перебои в работе сердца",
            "Ощущение сильного сердцебиения",
            "Замедленный пульс",
            "Нерегулярный пульс",
            "Головокружение",
            "Обморок или предобморочное состояние",
            "Слабость и быстрая утомляемость",
            "Отеки ног",
            "Холодный пот",
            "Тошнота",
            "Боль, отдающая в руку, плечо, спину или челюсть",
            "Чувство давления или сжатия в груди",
            "Повышенное артериальное давление",
            "Пониженное артериальное давление",
            "Ощущение нехватки воздуха при нагрузке",
            "Одышка в положении лёжа",
            "Внезапное ухудшение самочувствия"});
            this.comboBox_heart.Location = new System.Drawing.Point(206, 266);
            this.comboBox_heart.Name = "comboBox_heart";
            this.comboBox_heart.Size = new System.Drawing.Size(183, 26);
            this.comboBox_heart.TabIndex = 5;
            this.comboBox_heart.SelectedIndexChanged += new System.EventHandler(this.comboBox_heart_SelectedIndexChanged);
            this.comboBox_heart.TextUpdate += new System.EventHandler(this.comboBox_heart_TextUpdate);
            // 
            // comboBox_circulatory_system
            // 
            this.comboBox_circulatory_system.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_circulatory_system.FormattingEnabled = true;
            this.comboBox_circulatory_system.Items.AddRange(new object[] {
            "Отеки ног или рук",
            "Онемение конечностей",
            "Покалывание в руках или ногах",
            "Ощущение холода в конечностях",
            "Бледность кожи",
            "Посинение кожи или губ",
            "Покраснение конечностей",
            "Боль в ногах при ходьбе",
            "Судороги в ногах",
            "Тяжесть или усталость в ногах",
            "Варикозно расширенные вены",
            "Ощущение пульсации в конечностях",
            "Слабость в конечностях",
            "Медленное заживление ран",
            "Частые носовые кровотечения",
            "Лёгкое появление синяков",
            "Повышенное артериальное давление",
            "Пониженное артериальное давление",
            "Головокружение",
            "Обмороки"});
            this.comboBox_circulatory_system.Location = new System.Drawing.Point(206, 336);
            this.comboBox_circulatory_system.Name = "comboBox_circulatory_system";
            this.comboBox_circulatory_system.Size = new System.Drawing.Size(183, 26);
            this.comboBox_circulatory_system.TabIndex = 6;
            this.comboBox_circulatory_system.SelectedIndexChanged += new System.EventHandler(this.comboBox_circulatory_system_SelectedIndexChanged);
            this.comboBox_circulatory_system.TextUpdate += new System.EventHandler(this.comboBox_circulatory_system_TextUpdate);
            // 
            // comboBox_intestines
            // 
            this.comboBox_intestines.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_intestines.FormattingEnabled = true;
            this.comboBox_intestines.Items.AddRange(new object[] {
            "Боль или спазмы в животе",
            "Вздутие живота",
            "Урчание в животе",
            "Запор",
            "Диарея",
            "Чередование запора и диареи",
            "Частые позывы к дефекации",
            "Ощущение неполного опорожнения кишечника",
            "Кровь в стуле",
            "Слизь в стуле",
            "Изменение цвета стула",
            "Резкий или необычный запах стула",
            "Повышенное газообразование",
            "Тошнота",
            "Рвота",
            "Потеря аппетита",
            "Снижение веса",
            "Повышенная температура",
            "Слабость и утомляемость",
            "Боль или дискомфорт после еды"});
            this.comboBox_intestines.Location = new System.Drawing.Point(206, 416);
            this.comboBox_intestines.Name = "comboBox_intestines";
            this.comboBox_intestines.Size = new System.Drawing.Size(183, 26);
            this.comboBox_intestines.TabIndex = 7;
            this.comboBox_intestines.SelectedIndexChanged += new System.EventHandler(this.comboBox_intestines_SelectedIndexChanged);
            this.comboBox_intestines.TextUpdate += new System.EventHandler(this.comboBox_intestines_TextUpdate);
            // 
            // comboBox_eyes
            // 
            this.comboBox_eyes.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_eyes.FormattingEnabled = true;
            this.comboBox_eyes.Items.AddRange(new object[] {
            "Покраснение",
            "Зуд",
            "Боль",
            "Сухость/жжение",
            "Слезотечение",
            "Светобоязнь",
            "Ощущение инородного тела",
            "Затуманенное зрение",
            "Снижение зрения",
            "«Мушки»/вспышки",
            "Двоение"});
            this.comboBox_eyes.Location = new System.Drawing.Point(781, 87);
            this.comboBox_eyes.Name = "comboBox_eyes";
            this.comboBox_eyes.Size = new System.Drawing.Size(185, 26);
            this.comboBox_eyes.TabIndex = 8;
            this.comboBox_eyes.SelectedIndexChanged += new System.EventHandler(this.comboBox_eyes_SelectedIndexChanged);
            this.comboBox_eyes.TextUpdate += new System.EventHandler(this.comboBox_eyes_TextUpdate);
            // 
            // comboBox_oral_cavity
            // 
            this.comboBox_oral_cavity.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_oral_cavity.FormattingEnabled = true;
            this.comboBox_oral_cavity.Items.AddRange(new object[] {
            "Зубная боль",
            "Чувствительность зубов",
            "Боль при жевании",
            "Кровоточивость дёсен",
            "Боль или болезненность дёсен",
            "Отёк дёсен",
            "Подвижность зубов",
            "Неприятный запах изо рта",
            "Сухость во рту",
            "Язвы/ранки во рту",
            "Белый налёт или пятна",
            "Красные пятна/раздражение слизистой",
            "Боль или жжение языка",
            "Изменение цвета или формы языка",
            "Онемение языка или губ",
            "Изменение вкуса",
            "Повышенное слюноотделение",
            "Затруднение жевания",
            "Затруднение глотания",
            "Боль или дискомфорт в челюсти"});
            this.comboBox_oral_cavity.Location = new System.Drawing.Point(781, 200);
            this.comboBox_oral_cavity.Name = "comboBox_oral_cavity";
            this.comboBox_oral_cavity.Size = new System.Drawing.Size(185, 26);
            this.comboBox_oral_cavity.TabIndex = 9;
            this.comboBox_oral_cavity.SelectedIndexChanged += new System.EventHandler(this.comboBox_oral_cavity_SelectedIndexChanged);
            this.comboBox_oral_cavity.TextUpdate += new System.EventHandler(this.comboBox_oral_cavity_TextUpdate);
            // 
            // comboBox_kidneys
            // 
            this.comboBox_kidneys.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_kidneys.FormattingEnabled = true;
            this.comboBox_kidneys.Items.AddRange(new object[] {
            "Боль в пояснице / боку",
            "Боль или жжение при мочеиспускании",
            "Частое мочеиспускание",
            "Редкое мочеиспускание",
            "Затруднённое мочеиспускание",
            "Кровь в моче",
            "Изменение цвета мочи",
            "Мутная моча",
            "Резкий/необычный запах мочи",
            "Пенистая моча",
            "Отеки ног или лица",
            "Повышенная температура / озноб",
            "Тошнота или рвота",
            "Повышенное артериальное давление",
            "Слабость или повышенная утомляемость",
            "Изменение количества мочи",
            "Ночные позывы к мочеиспусканию",
            "Ощущение неполного опорожнения мочевого пузыря",
            "Сухость во рту / сильная жажда",
            "Головная боль"});
            this.comboBox_kidneys.Location = new System.Drawing.Point(781, 266);
            this.comboBox_kidneys.Name = "comboBox_kidneys";
            this.comboBox_kidneys.Size = new System.Drawing.Size(185, 26);
            this.comboBox_kidneys.TabIndex = 10;
            this.comboBox_kidneys.SelectedIndexChanged += new System.EventHandler(this.comboBox_kidneys_SelectedIndexChanged);
            this.comboBox_kidneys.TextUpdate += new System.EventHandler(this.comboBox_kidneys_TextUpdate);
            // 
            // comboBox_liver
            // 
            this.comboBox_liver.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_liver.FormattingEnabled = true;
            this.comboBox_liver.Items.AddRange(new object[] {
            "Боль или тяжесть в правом подреберье",
            "Тошнота",
            "Рвота",
            "Потеря аппетита",
            "Горечь во рту",
            "Вздутие живота",
            "Слабость и утомляемость",
            "Зуд кожи",
            "Желтизна кожи или глаз",
            "Потемнение мочи",
            "Обесцвеченный/светлый стул",
            "Отеки ног",
            "Увеличение живота",
            "Повышенная температура",
            "Повышенная кровоточивость",
            "Необычные синяки на коже",
            "Сонливость или спутанность сознания",
            "Непереносимость жирной пищи",
            "Снижение веса",
            "Дискомфорт после еды"});
            this.comboBox_liver.Location = new System.Drawing.Point(781, 336);
            this.comboBox_liver.Name = "comboBox_liver";
            this.comboBox_liver.Size = new System.Drawing.Size(185, 26);
            this.comboBox_liver.TabIndex = 11;
            this.comboBox_liver.SelectedIndexChanged += new System.EventHandler(this.comboBox_liver_SelectedIndexChanged);
            this.comboBox_liver.TextUpdate += new System.EventHandler(this.comboBox_liver_TextUpdate);
            // 
            // comboBox_stomach
            // 
            this.comboBox_stomach.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_stomach.FormattingEnabled = true;
            this.comboBox_stomach.Items.AddRange(new object[] {
            "Боль в верхней части живота",
            "Тяжесть в желудке",
            "Изжога",
            "Тошнота",
            "Рвота",
            "Вздутие живота",
            "Отрыжка",
            "Кислый привкус во рту",
            "Потеря аппетита",
            "Быстрое насыщение",
            "Чувство переполнения после еды",
            "Урчание в животе",
            "Дискомфорт после еды",
            "Боль натощак",
            "Боль после еды",
            "Неприятный запах изо рта",
            "Кровь в рвоте",
            "Чёрный или очень тёмный стул",
            "Снижение веса",
            "Общая слабость"});
            this.comboBox_stomach.Location = new System.Drawing.Point(781, 416);
            this.comboBox_stomach.Name = "comboBox_stomach";
            this.comboBox_stomach.Size = new System.Drawing.Size(185, 26);
            this.comboBox_stomach.TabIndex = 12;
            this.comboBox_stomach.SelectedIndexChanged += new System.EventHandler(this.comboBox_stomach_SelectedIndexChanged);
            this.comboBox_stomach.TextUpdate += new System.EventHandler(this.comboBox_stomach_TextUpdate);
            // 
            // btnFixing
            // 
            this.btnFixing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnFixing.FlatAppearance.BorderSize = 0;
            this.btnFixing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixing.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFixing.ForeColor = System.Drawing.Color.White;
            this.btnFixing.Location = new System.Drawing.Point(484, 522);
            this.btnFixing.Name = "btnFixing";
            this.btnFixing.Size = new System.Drawing.Size(225, 40);
            this.btnFixing.TabIndex = 13;
            this.btnFixing.Text = "Фиксировать";
            this.btnFixing.UseVisualStyleBackColor = false;
            this.btnFixing.Click += new System.EventHandler(this.btnFixing_Click);
            // 
            // pictureBox_fixing
            // 
            this.pictureBox_fixing.Image = global::Retainer.Properties.Resources.change;
            this.pictureBox_fixing.Location = new System.Drawing.Point(715, 522);
            this.pictureBox_fixing.Name = "pictureBox_fixing";
            this.pictureBox_fixing.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_fixing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_fixing.TabIndex = 14;
            this.pictureBox_fixing.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Retainer.Properties.Resources.human_health;
            this.pictureBox1.Location = new System.Drawing.Point(375, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnHealth
            // 
            this.btnHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHealth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHealth.FlatAppearance.BorderSize = 2;
            this.btnHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealth.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.btnHealth.Image = ((System.Drawing.Image)(resources.GetObject("btnHealth.Image")));
            this.btnHealth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHealth.Location = new System.Drawing.Point(0, 0);
            this.btnHealth.Margin = new System.Windows.Forms.Padding(0);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(200, 50);
            this.btnHealth.TabIndex = 0;
            this.btnHealth.Text = "Здоровье";
            this.btnHealth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHealth.UseVisualStyleBackColor = false;
            // 
            // btnSport
            // 
            this.btnSport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnSport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSport.FlatAppearance.BorderSize = 2;
            this.btnSport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSport.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.btnSport.Image = global::Retainer.Properties.Resources.iconButton2;
            this.btnSport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSport.Location = new System.Drawing.Point(0, 50);
            this.btnSport.Margin = new System.Windows.Forms.Padding(0);
            this.btnSport.Name = "btnSport";
            this.btnSport.Size = new System.Drawing.Size(200, 50);
            this.btnSport.TabIndex = 1;
            this.btnSport.Text = "Спорт";
            this.btnSport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSport.UseVisualStyleBackColor = false;
            // 
            // btnTasks
            // 
            this.btnTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTasks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTasks.FlatAppearance.BorderSize = 2;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.btnTasks.Image = global::Retainer.Properties.Resources.iconButton3;
            this.btnTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.Location = new System.Drawing.Point(0, 100);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(0);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(200, 50);
            this.btnTasks.TabIndex = 2;
            this.btnTasks.Text = "Задачи";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTasks.UseVisualStyleBackColor = false;
            // 
            // btnNotebook
            // 
            this.btnNotebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnNotebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNotebook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNotebook.FlatAppearance.BorderSize = 2;
            this.btnNotebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotebook.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.btnNotebook.Image = global::Retainer.Properties.Resources.iconButton5;
            this.btnNotebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotebook.Location = new System.Drawing.Point(0, 150);
            this.btnNotebook.Margin = new System.Windows.Forms.Padding(0);
            this.btnNotebook.Name = "btnNotebook";
            this.btnNotebook.Size = new System.Drawing.Size(200, 50);
            this.btnNotebook.TabIndex = 3;
            this.btnNotebook.Text = "Ежедневник";
            this.btnNotebook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotebook.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(967, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::Retainer.Properties.Resources.Hamburger_icon_svg;
            this.btnMenu.Location = new System.Drawing.Point(0, -3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(44, 43);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox_fixing);
            this.Controls.Add(this.btnFixing);
            this.Controls.Add(this.comboBox_stomach);
            this.Controls.Add(this.comboBox_liver);
            this.Controls.Add(this.comboBox_kidneys);
            this.Controls.Add(this.comboBox_oral_cavity);
            this.Controls.Add(this.comboBox_eyes);
            this.Controls.Add(this.comboBox_intestines);
            this.Controls.Add(this.comboBox_circulatory_system);
            this.Controls.Add(this.comboBox_heart);
            this.Controls.Add(this.comboBox_respiratory_tract);
            this.Controls.Add(this.comboBox_head);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SideMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fixing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnHealth;
        private System.Windows.Forms.Button btnSport;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnNotebook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_head;
        private System.Windows.Forms.ComboBox comboBox_respiratory_tract;
        private System.Windows.Forms.ComboBox comboBox_heart;
        private System.Windows.Forms.ComboBox comboBox_circulatory_system;
        private System.Windows.Forms.ComboBox comboBox_intestines;
        private System.Windows.Forms.ComboBox comboBox_eyes;
        private System.Windows.Forms.ComboBox comboBox_oral_cavity;
        private System.Windows.Forms.ComboBox comboBox_kidneys;
        private System.Windows.Forms.ComboBox comboBox_liver;
        private System.Windows.Forms.ComboBox comboBox_stomach;
        private System.Windows.Forms.Button btnFixing;
        private System.Windows.Forms.PictureBox pictureBox_fixing;
    }
}

