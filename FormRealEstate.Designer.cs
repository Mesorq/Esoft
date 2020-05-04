namespace Esoft_Project
{
    partial class FormRealEstate
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
            this.labelAddress_City = new System.Windows.Forms.Label();
            this.labelAddress_Street = new System.Windows.Forms.Label();
            this.labelAddress_House = new System.Windows.Forms.Label();
            this.labelAddress_Number = new System.Windows.Forms.Label();
            this.labelCoordinate_latitude = new System.Windows.Forms.Label();
            this.labelCoordinate_longitude = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelTotalArea = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.labelTotalFloors = new System.Windows.Forms.Label();
            this.listViewRealEstateSet_Apartment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRealEstateSet_House = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRealEstateSet_Land = new System.Windows.Forms.ListView();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAddress_City = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Street = new System.Windows.Forms.TextBox();
            this.textBoxAddress_House = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Number = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_latitude = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_longitude = new System.Windows.Forms.TextBox();
            this.textBoxTotalArea = new System.Windows.Forms.TextBox();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxTotalFloors = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddress_City
            // 
            this.labelAddress_City.AutoSize = true;
            this.labelAddress_City.Location = new System.Drawing.Point(0, 80);
            this.labelAddress_City.Name = "labelAddress_City";
            this.labelAddress_City.Size = new System.Drawing.Size(40, 13);
            this.labelAddress_City.TabIndex = 0;
            this.labelAddress_City.Text = "Город ";
            // 
            // labelAddress_Street
            // 
            this.labelAddress_Street.AutoSize = true;
            this.labelAddress_Street.Location = new System.Drawing.Point(0, 129);
            this.labelAddress_Street.Name = "labelAddress_Street";
            this.labelAddress_Street.Size = new System.Drawing.Size(42, 13);
            this.labelAddress_Street.TabIndex = 1;
            this.labelAddress_Street.Text = "Улица ";
            // 
            // labelAddress_House
            // 
            this.labelAddress_House.AutoSize = true;
            this.labelAddress_House.Location = new System.Drawing.Point(0, 181);
            this.labelAddress_House.Name = "labelAddress_House";
            this.labelAddress_House.Size = new System.Drawing.Size(70, 13);
            this.labelAddress_House.TabIndex = 2;
            this.labelAddress_House.Text = "Номер дома";
            // 
            // labelAddress_Number
            // 
            this.labelAddress_Number.AutoSize = true;
            this.labelAddress_Number.Location = new System.Drawing.Point(0, 236);
            this.labelAddress_Number.Name = "labelAddress_Number";
            this.labelAddress_Number.Size = new System.Drawing.Size(93, 13);
            this.labelAddress_Number.TabIndex = 3;
            this.labelAddress_Number.Text = "Номер квартиры";
            // 
            // labelCoordinate_latitude
            // 
            this.labelCoordinate_latitude.AutoSize = true;
            this.labelCoordinate_latitude.Location = new System.Drawing.Point(228, 80);
            this.labelCoordinate_latitude.Name = "labelCoordinate_latitude";
            this.labelCoordinate_latitude.Size = new System.Drawing.Size(49, 13);
            this.labelCoordinate_latitude.TabIndex = 4;
            this.labelCoordinate_latitude.Text = "Ширина ";
            // 
            // labelCoordinate_longitude
            // 
            this.labelCoordinate_longitude.AutoSize = true;
            this.labelCoordinate_longitude.Location = new System.Drawing.Point(228, 129);
            this.labelCoordinate_longitude.Name = "labelCoordinate_longitude";
            this.labelCoordinate_longitude.Size = new System.Drawing.Size(53, 13);
            this.labelCoordinate_longitude.TabIndex = 5;
            this.labelCoordinate_longitude.Text = "Долгота ";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(228, 181);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(149, 13);
            this.labelType.TabIndex = 6;
            this.labelType.Text = "Тип объекта недвижимости";
            // 
            // labelTotalArea
            // 
            this.labelTotalArea.AutoSize = true;
            this.labelTotalArea.Location = new System.Drawing.Point(474, 80);
            this.labelTotalArea.Name = "labelTotalArea";
            this.labelTotalArea.Size = new System.Drawing.Size(57, 13);
            this.labelTotalArea.TabIndex = 8;
            this.labelTotalArea.Text = "Площадь ";
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Location = new System.Drawing.Point(474, 129);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(106, 13);
            this.labelRooms.TabIndex = 9;
            this.labelRooms.Text = "Количество комнат";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(474, 181);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(36, 13);
            this.labelFloor.TabIndex = 10;
            this.labelFloor.Text = "Этаж ";
            // 
            // labelTotalFloors
            // 
            this.labelTotalFloors.AutoSize = true;
            this.labelTotalFloors.Location = new System.Drawing.Point(474, 129);
            this.labelTotalFloors.Name = "labelTotalFloors";
            this.labelTotalFloors.Size = new System.Drawing.Size(106, 13);
            this.labelTotalFloors.TabIndex = 11;
            this.labelTotalFloors.Text = "Количество этажей";
            this.labelTotalFloors.Visible = false;
            // 
            // listViewRealEstateSet_Apartment
            // 
            this.listViewRealEstateSet_Apartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewRealEstateSet_Apartment.FullRowSelect = true;
            this.listViewRealEstateSet_Apartment.GridLines = true;
            this.listViewRealEstateSet_Apartment.HideSelection = false;
            this.listViewRealEstateSet_Apartment.Location = new System.Drawing.Point(3, 300);
            this.listViewRealEstateSet_Apartment.MultiSelect = false;
            this.listViewRealEstateSet_Apartment.Name = "listViewRealEstateSet_Apartment";
            this.listViewRealEstateSet_Apartment.Size = new System.Drawing.Size(763, 204);
            this.listViewRealEstateSet_Apartment.TabIndex = 23;
            this.listViewRealEstateSet_Apartment.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Apartment.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Apartment.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Apartment_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Город";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Улица";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Номер дома";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Номер квартиры";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Широта";
            this.columnHeader5.Width = 78;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Долгота";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Площадь";
            this.columnHeader7.Width = 67;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Количество комнат";
            this.columnHeader8.Width = 115;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Этаж";
            // 
            // listViewRealEstateSet_House
            // 
            this.listViewRealEstateSet_House.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.listViewRealEstateSet_House.FullRowSelect = true;
            this.listViewRealEstateSet_House.GridLines = true;
            this.listViewRealEstateSet_House.HideSelection = false;
            this.listViewRealEstateSet_House.Location = new System.Drawing.Point(3, 300);
            this.listViewRealEstateSet_House.MultiSelect = false;
            this.listViewRealEstateSet_House.Name = "listViewRealEstateSet_House";
            this.listViewRealEstateSet_House.Size = new System.Drawing.Size(766, 204);
            this.listViewRealEstateSet_House.TabIndex = 24;
            this.listViewRealEstateSet_House.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_House.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_House.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_House_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Город";
            this.columnHeader10.Width = 98;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Улица";
            this.columnHeader11.Width = 76;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Номер дома";
            this.columnHeader12.Width = 84;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Номер квартиры";
            this.columnHeader13.Width = 101;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Широта";
            this.columnHeader14.Width = 76;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Долгота";
            this.columnHeader15.Width = 86;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Площадь";
            this.columnHeader16.Width = 64;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Количество этажей";
            this.columnHeader17.Width = 176;
            // 
            // listViewRealEstateSet_Land
            // 
            this.listViewRealEstateSet_Land.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.listViewRealEstateSet_Land.FullRowSelect = true;
            this.listViewRealEstateSet_Land.GridLines = true;
            this.listViewRealEstateSet_Land.HideSelection = false;
            this.listViewRealEstateSet_Land.Location = new System.Drawing.Point(3, 300);
            this.listViewRealEstateSet_Land.MultiSelect = false;
            this.listViewRealEstateSet_Land.Name = "listViewRealEstateSet_Land";
            this.listViewRealEstateSet_Land.Size = new System.Drawing.Size(773, 204);
            this.listViewRealEstateSet_Land.TabIndex = 25;
            this.listViewRealEstateSet_Land.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Land.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Land.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Land_SelectedIndexChanged);
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Город";
            this.columnHeader18.Width = 99;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Улица";
            this.columnHeader19.Width = 73;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Номер дома";
            this.columnHeader20.Width = 86;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Номер квартиры";
            this.columnHeader21.Width = 101;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Широта";
            this.columnHeader22.Width = 76;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Долгота";
            this.columnHeader23.Width = 87;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Площадь";
            this.columnHeader24.Width = 240;
            // 
            // textBoxAddress_City
            // 
            this.textBoxAddress_City.Location = new System.Drawing.Point(3, 96);
            this.textBoxAddress_City.Name = "textBoxAddress_City";
            this.textBoxAddress_City.Size = new System.Drawing.Size(188, 20);
            this.textBoxAddress_City.TabIndex = 26;
            // 
            // textBoxAddress_Street
            // 
            this.textBoxAddress_Street.Location = new System.Drawing.Point(0, 145);
            this.textBoxAddress_Street.Name = "textBoxAddress_Street";
            this.textBoxAddress_Street.Size = new System.Drawing.Size(191, 20);
            this.textBoxAddress_Street.TabIndex = 27;
            // 
            // textBoxAddress_House
            // 
            this.textBoxAddress_House.Location = new System.Drawing.Point(0, 197);
            this.textBoxAddress_House.Name = "textBoxAddress_House";
            this.textBoxAddress_House.Size = new System.Drawing.Size(191, 20);
            this.textBoxAddress_House.TabIndex = 28;
            // 
            // textBoxAddress_Number
            // 
            this.textBoxAddress_Number.Location = new System.Drawing.Point(0, 252);
            this.textBoxAddress_Number.Name = "textBoxAddress_Number";
            this.textBoxAddress_Number.Size = new System.Drawing.Size(191, 20);
            this.textBoxAddress_Number.TabIndex = 29;
            // 
            // textBoxCoordinate_latitude
            // 
            this.textBoxCoordinate_latitude.Location = new System.Drawing.Point(231, 96);
            this.textBoxCoordinate_latitude.Name = "textBoxCoordinate_latitude";
            this.textBoxCoordinate_latitude.Size = new System.Drawing.Size(206, 20);
            this.textBoxCoordinate_latitude.TabIndex = 30;
            // 
            // textBoxCoordinate_longitude
            // 
            this.textBoxCoordinate_longitude.Location = new System.Drawing.Point(231, 145);
            this.textBoxCoordinate_longitude.Name = "textBoxCoordinate_longitude";
            this.textBoxCoordinate_longitude.Size = new System.Drawing.Size(206, 20);
            this.textBoxCoordinate_longitude.TabIndex = 31;
            // 
            // textBoxTotalArea
            // 
            this.textBoxTotalArea.Location = new System.Drawing.Point(477, 96);
            this.textBoxTotalArea.Name = "textBoxTotalArea";
            this.textBoxTotalArea.Size = new System.Drawing.Size(209, 20);
            this.textBoxTotalArea.TabIndex = 33;
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.Location = new System.Drawing.Point(477, 145);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.Size = new System.Drawing.Size(209, 20);
            this.textBoxRooms.TabIndex = 34;
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(477, 197);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(209, 20);
            this.textBoxFloor.TabIndex = 35;
            // 
            // textBoxTotalFloors
            // 
            this.textBoxTotalFloors.Location = new System.Drawing.Point(477, 145);
            this.textBoxTotalFloors.Name = "textBoxTotalFloors";
            this.textBoxTotalFloors.Size = new System.Drawing.Size(209, 20);
            this.textBoxTotalFloors.TabIndex = 36;
            this.textBoxTotalFloors.Visible = false;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартитра",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(231, 197);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(206, 21);
            this.comboBoxType.TabIndex = 37;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(670, 514);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(106, 23);
            this.buttonDel.TabIndex = 38;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(525, 514);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(106, 23);
            this.buttonEdit.TabIndex = 39;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(384, 514);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 23);
            this.buttonAdd.TabIndex = 40;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FormRealEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxTotalFloors);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.textBoxRooms);
            this.Controls.Add(this.textBoxTotalArea);
            this.Controls.Add(this.textBoxCoordinate_longitude);
            this.Controls.Add(this.textBoxCoordinate_latitude);
            this.Controls.Add(this.textBoxAddress_Number);
            this.Controls.Add(this.textBoxAddress_House);
            this.Controls.Add(this.textBoxAddress_Street);
            this.Controls.Add(this.textBoxAddress_City);
            this.Controls.Add(this.listViewRealEstateSet_Land);
            this.Controls.Add(this.listViewRealEstateSet_House);
            this.Controls.Add(this.listViewRealEstateSet_Apartment);
            this.Controls.Add(this.labelTotalFloors);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.labelTotalArea);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelCoordinate_longitude);
            this.Controls.Add(this.labelCoordinate_latitude);
            this.Controls.Add(this.labelAddress_Number);
            this.Controls.Add(this.labelAddress_House);
            this.Controls.Add(this.labelAddress_Street);
            this.Controls.Add(this.labelAddress_City);
            this.Name = "FormRealEstate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объекты недвижимости";
            this.Load += new System.EventHandler(this.FormRealEstate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddress_City;
        private System.Windows.Forms.Label labelAddress_Street;
        private System.Windows.Forms.Label labelAddress_House;
        private System.Windows.Forms.Label labelAddress_Number;
        private System.Windows.Forms.Label labelCoordinate_latitude;
        private System.Windows.Forms.Label labelCoordinate_longitude;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelTotalArea;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelTotalFloors;
        private System.Windows.Forms.ListView listViewRealEstateSet_Apartment;
        private System.Windows.Forms.ListView listViewRealEstateSet_House;
        private System.Windows.Forms.ListView listViewRealEstateSet_Land;
        private System.Windows.Forms.TextBox textBoxAddress_City;
        private System.Windows.Forms.TextBox textBoxAddress_Street;
        private System.Windows.Forms.TextBox textBoxAddress_House;
        private System.Windows.Forms.TextBox textBoxAddress_Number;
        private System.Windows.Forms.TextBox textBoxCoordinate_latitude;
        private System.Windows.Forms.TextBox textBoxCoordinate_longitude;
        private System.Windows.Forms.TextBox textBoxTotalArea;
        private System.Windows.Forms.TextBox textBoxRooms;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.TextBox textBoxTotalFloors;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}