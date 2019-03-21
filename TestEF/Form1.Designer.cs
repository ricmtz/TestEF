namespace TestEF
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
            this.tabCRUD = new System.Windows.Forms.TabControl();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHomePage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.tabRead = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtUpdateHomeP = new System.Windows.Forms.TextBox();
            this.txtUpdateFax = new System.Windows.Forms.TextBox();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.txtUpdateCountry = new System.Windows.Forms.TextBox();
            this.txtUpdatePostalC = new System.Windows.Forms.TextBox();
            this.txtUpdateRegion = new System.Windows.Forms.TextBox();
            this.txtUpdateCity = new System.Windows.Forms.TextBox();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateContactT = new System.Windows.Forms.TextBox();
            this.txtUpdateContactN = new System.Windows.Forms.TextBox();
            this.txtUpdateCompanyN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearchId = new System.Windows.Forms.Button();
            this.txtIdSearchUpdate = new System.Windows.Forms.TextBox();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.txtIdDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabCRUD.SuspendLayout();
            this.tabCreate.SuspendLayout();
            this.tabRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSuppliers)).BeginInit();
            this.tabUpdate.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCRUD
            // 
            this.tabCRUD.Controls.Add(this.tabCreate);
            this.tabCRUD.Controls.Add(this.tabRead);
            this.tabCRUD.Controls.Add(this.tabUpdate);
            this.tabCRUD.Controls.Add(this.tabDelete);
            this.tabCRUD.Location = new System.Drawing.Point(12, 12);
            this.tabCRUD.Name = "tabCRUD";
            this.tabCRUD.SelectedIndex = 0;
            this.tabCRUD.Size = new System.Drawing.Size(667, 426);
            this.tabCRUD.TabIndex = 0;
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.btnCreate);
            this.tabCreate.Controls.Add(this.label11);
            this.tabCreate.Controls.Add(this.txtHomePage);
            this.tabCreate.Controls.Add(this.label10);
            this.tabCreate.Controls.Add(this.txtFax);
            this.tabCreate.Controls.Add(this.label9);
            this.tabCreate.Controls.Add(this.label8);
            this.tabCreate.Controls.Add(this.label7);
            this.tabCreate.Controls.Add(this.label6);
            this.tabCreate.Controls.Add(this.label5);
            this.tabCreate.Controls.Add(this.label4);
            this.tabCreate.Controls.Add(this.label3);
            this.tabCreate.Controls.Add(this.label2);
            this.tabCreate.Controls.Add(this.label1);
            this.tabCreate.Controls.Add(this.txtPhone);
            this.tabCreate.Controls.Add(this.txtCountry);
            this.tabCreate.Controls.Add(this.txtPostalCode);
            this.tabCreate.Controls.Add(this.txtRegion);
            this.tabCreate.Controls.Add(this.txtCity);
            this.tabCreate.Controls.Add(this.txtAddress);
            this.tabCreate.Controls.Add(this.txtContactTitle);
            this.tabCreate.Controls.Add(this.txtContactName);
            this.tabCreate.Controls.Add(this.txtCompanyName);
            this.tabCreate.Location = new System.Drawing.Point(4, 22);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreate.Size = new System.Drawing.Size(659, 400);
            this.tabCreate.TabIndex = 0;
            this.tabCreate.Text = "Create";
            this.tabCreate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(540, 364);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 30);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Home Page";
            // 
            // txtHomePage
            // 
            this.txtHomePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomePage.ForeColor = System.Drawing.Color.Black;
            this.txtHomePage.Location = new System.Drawing.Point(135, 330);
            this.txtHomePage.Name = "txtHomePage";
            this.txtHomePage.Size = new System.Drawing.Size(480, 24);
            this.txtHomePage.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.ForeColor = System.Drawing.Color.Black;
            this.txtFax.Location = new System.Drawing.Point(135, 300);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(480, 24);
            this.txtFax.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Postal Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Region";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contact Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contact Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Company Name";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(135, 270);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(480, 24);
            this.txtPhone.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.Color.Black;
            this.txtCountry.Location = new System.Drawing.Point(135, 240);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(480, 24);
            this.txtCountry.TabIndex = 7;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.ForeColor = System.Drawing.Color.Black;
            this.txtPostalCode.Location = new System.Drawing.Point(135, 210);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(480, 24);
            this.txtPostalCode.TabIndex = 6;
            // 
            // txtRegion
            // 
            this.txtRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegion.ForeColor = System.Drawing.Color.Black;
            this.txtRegion.Location = new System.Drawing.Point(135, 180);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(480, 24);
            this.txtRegion.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(135, 150);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(480, 24);
            this.txtCity.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(135, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(480, 24);
            this.txtAddress.TabIndex = 3;
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactTitle.ForeColor = System.Drawing.Color.Black;
            this.txtContactTitle.Location = new System.Drawing.Point(135, 90);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(480, 24);
            this.txtContactTitle.TabIndex = 2;
            // 
            // txtContactName
            // 
            this.txtContactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactName.ForeColor = System.Drawing.Color.Black;
            this.txtContactName.Location = new System.Drawing.Point(135, 60);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(480, 24);
            this.txtContactName.TabIndex = 1;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyName.Location = new System.Drawing.Point(135, 30);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(480, 24);
            this.txtCompanyName.TabIndex = 0;
            // 
            // tabRead
            // 
            this.tabRead.Controls.Add(this.btnRefresh);
            this.tabRead.Controls.Add(this.gridViewSuppliers);
            this.tabRead.Location = new System.Drawing.Point(4, 22);
            this.tabRead.Name = "tabRead";
            this.tabRead.Padding = new System.Windows.Forms.Padding(3);
            this.tabRead.Size = new System.Drawing.Size(659, 400);
            this.tabRead.TabIndex = 1;
            this.tabRead.Text = "Read All";
            this.tabRead.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(553, 365);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridViewSuppliers
            // 
            this.gridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSuppliers.Location = new System.Drawing.Point(6, 6);
            this.gridViewSuppliers.Name = "gridViewSuppliers";
            this.gridViewSuppliers.Size = new System.Drawing.Size(647, 352);
            this.gridViewSuppliers.TabIndex = 0;
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.btnUpdate);
            this.tabUpdate.Controls.Add(this.label13);
            this.tabUpdate.Controls.Add(this.label14);
            this.tabUpdate.Controls.Add(this.label15);
            this.tabUpdate.Controls.Add(this.label16);
            this.tabUpdate.Controls.Add(this.label17);
            this.tabUpdate.Controls.Add(this.label18);
            this.tabUpdate.Controls.Add(this.label19);
            this.tabUpdate.Controls.Add(this.label20);
            this.tabUpdate.Controls.Add(this.label21);
            this.tabUpdate.Controls.Add(this.label22);
            this.tabUpdate.Controls.Add(this.label23);
            this.tabUpdate.Controls.Add(this.txtUpdateHomeP);
            this.tabUpdate.Controls.Add(this.txtUpdateFax);
            this.tabUpdate.Controls.Add(this.txtUpdatePhone);
            this.tabUpdate.Controls.Add(this.txtUpdateCountry);
            this.tabUpdate.Controls.Add(this.txtUpdatePostalC);
            this.tabUpdate.Controls.Add(this.txtUpdateRegion);
            this.tabUpdate.Controls.Add(this.txtUpdateCity);
            this.tabUpdate.Controls.Add(this.txtUpdateAddress);
            this.tabUpdate.Controls.Add(this.txtUpdateContactT);
            this.tabUpdate.Controls.Add(this.txtUpdateContactN);
            this.tabUpdate.Controls.Add(this.txtUpdateCompanyN);
            this.tabUpdate.Controls.Add(this.label12);
            this.tabUpdate.Controls.Add(this.btnSearchId);
            this.tabUpdate.Controls.Add(this.txtIdSearchUpdate);
            this.tabUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Size = new System.Drawing.Size(659, 400);
            this.tabUpdate.TabIndex = 2;
            this.tabUpdate.Text = "Update";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(277, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 18);
            this.label13.TabIndex = 33;
            this.label13.Text = "Home Page";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 322);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 18);
            this.label14.TabIndex = 32;
            this.label14.Text = "Fax";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 18);
            this.label15.TabIndex = 31;
            this.label15.Text = "Phone";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 18);
            this.label16.TabIndex = 30;
            this.label16.Text = "Country";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 18);
            this.label17.TabIndex = 29;
            this.label17.Text = "Postal Code";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 202);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 18);
            this.label18.TabIndex = 28;
            this.label18.Text = "Region";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 18);
            this.label19.TabIndex = 27;
            this.label19.Text = "City";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 18);
            this.label20.TabIndex = 26;
            this.label20.Text = "Address";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 112);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 18);
            this.label21.TabIndex = 25;
            this.label21.Text = "Contact Title";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(16, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 18);
            this.label22.TabIndex = 24;
            this.label22.Text = "Contact Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(16, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 18);
            this.label23.TabIndex = 23;
            this.label23.Text = "Company Name";
            // 
            // txtUpdateHomeP
            // 
            this.txtUpdateHomeP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateHomeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateHomeP.Location = new System.Drawing.Point(195, 347);
            this.txtUpdateHomeP.Name = "txtUpdateHomeP";
            this.txtUpdateHomeP.Size = new System.Drawing.Size(433, 24);
            this.txtUpdateHomeP.TabIndex = 14;
            // 
            // txtUpdateFax
            // 
            this.txtUpdateFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateFax.Location = new System.Drawing.Point(195, 317);
            this.txtUpdateFax.Name = "txtUpdateFax";
            this.txtUpdateFax.Size = new System.Drawing.Size(433, 24);
            this.txtUpdateFax.TabIndex = 12;
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePhone.Location = new System.Drawing.Point(195, 287);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(433, 24);
            this.txtUpdatePhone.TabIndex = 11;
            // 
            // txtUpdateCountry
            // 
            this.txtUpdateCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateCountry.Location = new System.Drawing.Point(195, 257);
            this.txtUpdateCountry.Name = "txtUpdateCountry";
            this.txtUpdateCountry.Size = new System.Drawing.Size(433, 24);
            this.txtUpdateCountry.TabIndex = 10;
            // 
            // txtUpdatePostalC
            // 
            this.txtUpdatePostalC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdatePostalC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePostalC.Location = new System.Drawing.Point(195, 227);
            this.txtUpdatePostalC.Name = "txtUpdatePostalC";
            this.txtUpdatePostalC.Size = new System.Drawing.Size(433, 24);
            this.txtUpdatePostalC.TabIndex = 9;
            // 
            // txtUpdateRegion
            // 
            this.txtUpdateRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateRegion.Location = new System.Drawing.Point(195, 197);
            this.txtUpdateRegion.Name = "txtUpdateRegion";
            this.txtUpdateRegion.Size = new System.Drawing.Size(433, 24);
            this.txtUpdateRegion.TabIndex = 8;
            // 
            // txtUpdateCity
            // 
            this.txtUpdateCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateCity.Location = new System.Drawing.Point(195, 167);
            this.txtUpdateCity.Name = "txtUpdateCity";
            this.txtUpdateCity.Size = new System.Drawing.Size(433, 24);
            this.txtUpdateCity.TabIndex = 7;
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateAddress.Location = new System.Drawing.Point(195, 137);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(433, 24);
            this.txtUpdateAddress.TabIndex = 6;
            // 
            // txtUpdateContactT
            // 
            this.txtUpdateContactT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateContactT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateContactT.Location = new System.Drawing.Point(195, 107);
            this.txtUpdateContactT.Name = "txtUpdateContactT";
            this.txtUpdateContactT.Size = new System.Drawing.Size(433, 24);
            this.txtUpdateContactT.TabIndex = 5;
            // 
            // txtUpdateContactN
            // 
            this.txtUpdateContactN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateContactN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateContactN.Location = new System.Drawing.Point(195, 77);
            this.txtUpdateContactN.Name = "txtUpdateContactN";
            this.txtUpdateContactN.Size = new System.Drawing.Size(433, 24);
            this.txtUpdateContactN.TabIndex = 4;
            // 
            // txtUpdateCompanyN
            // 
            this.txtUpdateCompanyN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateCompanyN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateCompanyN.Location = new System.Drawing.Point(195, 47);
            this.txtUpdateCompanyN.Name = "txtUpdateCompanyN";
            this.txtUpdateCompanyN.Size = new System.Drawing.Size(433, 24);
            this.txtUpdateCompanyN.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Id:";
            // 
            // btnSearchId
            // 
            this.btnSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchId.Location = new System.Drawing.Point(195, 8);
            this.btnSearchId.Name = "btnSearchId";
            this.btnSearchId.Size = new System.Drawing.Size(75, 30);
            this.btnSearchId.TabIndex = 1;
            this.btnSearchId.Text = "Search";
            this.btnSearchId.UseVisualStyleBackColor = true;
            this.btnSearchId.Click += new System.EventHandler(this.btnSearchId_Click);
            // 
            // txtIdSearchUpdate
            // 
            this.txtIdSearchUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdSearchUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSearchUpdate.Location = new System.Drawing.Point(45, 11);
            this.txtIdSearchUpdate.Name = "txtIdSearchUpdate";
            this.txtIdSearchUpdate.Size = new System.Drawing.Size(142, 24);
            this.txtIdSearchUpdate.TabIndex = 0;
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.label24);
            this.tabDelete.Controls.Add(this.txtIdDelete);
            this.tabDelete.Controls.Add(this.btnDelete);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(659, 400);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(15, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 18);
            this.label24.TabIndex = 2;
            this.label24.Text = "Id";
            // 
            // txtIdDelete
            // 
            this.txtIdDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDelete.Location = new System.Drawing.Point(40, 22);
            this.txtIdDelete.Name = "txtIdDelete";
            this.txtIdDelete.Size = new System.Drawing.Size(163, 24);
            this.txtIdDelete.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(209, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.tabCRUD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCRUD.ResumeLayout(false);
            this.tabCreate.ResumeLayout(false);
            this.tabCreate.PerformLayout();
            this.tabRead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSuppliers)).EndInit();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCRUD;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.TabPage tabRead;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHomePage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.DataGridView gridViewSuppliers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearchId;
        private System.Windows.Forms.TextBox txtIdSearchUpdate;
        private System.Windows.Forms.TextBox txtUpdateHomeP;
        private System.Windows.Forms.TextBox txtUpdateFax;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.TextBox txtUpdateCountry;
        private System.Windows.Forms.TextBox txtUpdatePostalC;
        private System.Windows.Forms.TextBox txtUpdateRegion;
        private System.Windows.Forms.TextBox txtUpdateCity;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.TextBox txtUpdateContactT;
        private System.Windows.Forms.TextBox txtUpdateContactN;
        private System.Windows.Forms.TextBox txtUpdateCompanyN;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtIdDelete;
        private System.Windows.Forms.Button btnDelete;
    }
}

