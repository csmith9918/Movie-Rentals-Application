namespace WindowsFormsApplication1
{
    partial class movieRentalsForm
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
            this.customerNameListBox = new System.Windows.Forms.ListBox();
            this.addNameButton = new System.Windows.Forms.Button();
            this.removeNameButton = new System.Windows.Forms.Button();
            this.movieComboBox = new System.Windows.Forms.ComboBox();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.removeMovieButton = new System.Windows.Forms.Button();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.movieFormatsGroupBox = new System.Windows.Forms.GroupBox();
            this.onlineVhsRadioButton = new System.Windows.Forms.RadioButton();
            this.dvdRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRayRadioButton = new System.Windows.Forms.RadioButton();
            this.newReleaseGroupBox = new System.Windows.Forms.GroupBox();
            this.newReleaseCheckBox = new System.Windows.Forms.CheckBox();
            this.numberOfNightsLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.enterMovieLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.addRentalButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.newOrderButton = new System.Windows.Forms.Button();
            this.endOrderButton = new System.Windows.Forms.Button();
            this.randomNumberTextbox = new System.Windows.Forms.TextBox();
            this.randomNumberLabel = new System.Windows.Forms.Label();
            this.submitRandomNumber = new System.Windows.Forms.Button();
            this.managementTotalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.reportButton = new System.Windows.Forms.Button();
            this.reportLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nightsRentedTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.movieFormatsGroupBox.SuspendLayout();
            this.newReleaseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameListBox
            // 
            this.customerNameListBox.FormattingEnabled = true;
            this.customerNameListBox.Items.AddRange(new object[] {
            "John",
            "Frank",
            "Pete",
            "Sam",
            "Trish",
            "Rudolph"});
            this.customerNameListBox.Location = new System.Drawing.Point(80, 69);
            this.customerNameListBox.Name = "customerNameListBox";
            this.customerNameListBox.Size = new System.Drawing.Size(120, 121);
            this.customerNameListBox.TabIndex = 14;
            // 
            // addNameButton
            // 
            this.addNameButton.Location = new System.Drawing.Point(80, 236);
            this.addNameButton.Name = "addNameButton";
            this.addNameButton.Size = new System.Drawing.Size(75, 23);
            this.addNameButton.TabIndex = 17;
            this.addNameButton.TabStop = false;
            this.addNameButton.Text = "Add &Name";
            this.addNameButton.UseVisualStyleBackColor = true;
            this.addNameButton.Click += new System.EventHandler(this.addNameButton_Click);
            // 
            // removeNameButton
            // 
            this.removeNameButton.Location = new System.Drawing.Point(80, 265);
            this.removeNameButton.Name = "removeNameButton";
            this.removeNameButton.Size = new System.Drawing.Size(75, 37);
            this.removeNameButton.TabIndex = 18;
            this.removeNameButton.TabStop = false;
            this.removeNameButton.Text = "Remove Name";
            this.removeNameButton.UseVisualStyleBackColor = true;
            this.removeNameButton.Click += new System.EventHandler(this.removeNameButton_Click);
            // 
            // movieComboBox
            // 
            this.movieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.movieComboBox.FormattingEnabled = true;
            this.movieComboBox.Items.AddRange(new object[] {
            "Harry Potter",
            "Taken",
            "Big Hero 6",
            "Maze Runner",
            "Escape Plan",
            "Happy Gilmore"});
            this.movieComboBox.Location = new System.Drawing.Point(230, 68);
            this.movieComboBox.Name = "movieComboBox";
            this.movieComboBox.Size = new System.Drawing.Size(121, 163);
            this.movieComboBox.TabIndex = 20;
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(230, 236);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(75, 23);
            this.addMovieButton.TabIndex = 21;
            this.addMovieButton.TabStop = false;
            this.addMovieButton.Text = "Add &Movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // removeMovieButton
            // 
            this.removeMovieButton.Location = new System.Drawing.Point(230, 265);
            this.removeMovieButton.Name = "removeMovieButton";
            this.removeMovieButton.Size = new System.Drawing.Size(75, 37);
            this.removeMovieButton.TabIndex = 22;
            this.removeMovieButton.TabStop = false;
            this.removeMovieButton.Text = "Remove Movie";
            this.removeMovieButton.UseVisualStyleBackColor = true;
            this.removeMovieButton.Click += new System.EventHandler(this.removeMovieButton_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(80, 206);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerNameTextBox.TabIndex = 16;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 209);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(66, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Enter Name:";
            // 
            // movieFormatsGroupBox
            // 
            this.movieFormatsGroupBox.Controls.Add(this.onlineVhsRadioButton);
            this.movieFormatsGroupBox.Controls.Add(this.dvdRadioButton);
            this.movieFormatsGroupBox.Controls.Add(this.blueRayRadioButton);
            this.movieFormatsGroupBox.Location = new System.Drawing.Point(383, 68);
            this.movieFormatsGroupBox.Name = "movieFormatsGroupBox";
            this.movieFormatsGroupBox.Size = new System.Drawing.Size(200, 100);
            this.movieFormatsGroupBox.TabIndex = 0;
            this.movieFormatsGroupBox.TabStop = false;
            this.movieFormatsGroupBox.Text = "Movie Formats && Price";
            // 
            // onlineVhsRadioButton
            // 
            this.onlineVhsRadioButton.AutoSize = true;
            this.onlineVhsRadioButton.Location = new System.Drawing.Point(7, 67);
            this.onlineVhsRadioButton.Name = "onlineVhsRadioButton";
            this.onlineVhsRadioButton.Size = new System.Drawing.Size(89, 17);
            this.onlineVhsRadioButton.TabIndex = 2;
            this.onlineVhsRadioButton.TabStop = true;
            this.onlineVhsRadioButton.Text = "Online && VHS";
            this.onlineVhsRadioButton.UseVisualStyleBackColor = true;
            this.onlineVhsRadioButton.CheckedChanged += new System.EventHandler(this.movieTypeRadioButtons_CheckedChanged);
            // 
            // dvdRadioButton
            // 
            this.dvdRadioButton.AutoSize = true;
            this.dvdRadioButton.Location = new System.Drawing.Point(7, 44);
            this.dvdRadioButton.Name = "dvdRadioButton";
            this.dvdRadioButton.Size = new System.Drawing.Size(48, 17);
            this.dvdRadioButton.TabIndex = 1;
            this.dvdRadioButton.TabStop = true;
            this.dvdRadioButton.Text = "DVD";
            this.dvdRadioButton.UseVisualStyleBackColor = true;
            this.dvdRadioButton.CheckedChanged += new System.EventHandler(this.movieTypeRadioButtons_CheckedChanged);
            // 
            // blueRayRadioButton
            // 
            this.blueRayRadioButton.AutoSize = true;
            this.blueRayRadioButton.Location = new System.Drawing.Point(7, 21);
            this.blueRayRadioButton.Name = "blueRayRadioButton";
            this.blueRayRadioButton.Size = new System.Drawing.Size(68, 17);
            this.blueRayRadioButton.TabIndex = 0;
            this.blueRayRadioButton.TabStop = true;
            this.blueRayRadioButton.Text = "Blue Ray";
            this.blueRayRadioButton.UseVisualStyleBackColor = true;
            this.blueRayRadioButton.CheckedChanged += new System.EventHandler(this.movieTypeRadioButtons_CheckedChanged);
            // 
            // newReleaseGroupBox
            // 
            this.newReleaseGroupBox.Controls.Add(this.newReleaseCheckBox);
            this.newReleaseGroupBox.Location = new System.Drawing.Point(383, 174);
            this.newReleaseGroupBox.Name = "newReleaseGroupBox";
            this.newReleaseGroupBox.Size = new System.Drawing.Size(200, 59);
            this.newReleaseGroupBox.TabIndex = 1;
            this.newReleaseGroupBox.TabStop = false;
            this.newReleaseGroupBox.Text = "New Release";
            // 
            // newReleaseCheckBox
            // 
            this.newReleaseCheckBox.AutoSize = true;
            this.newReleaseCheckBox.Location = new System.Drawing.Point(6, 25);
            this.newReleaseCheckBox.Name = "newReleaseCheckBox";
            this.newReleaseCheckBox.Size = new System.Drawing.Size(102, 17);
            this.newReleaseCheckBox.TabIndex = 0;
            this.newReleaseCheckBox.Text = "Additional $0.75";
            this.newReleaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // numberOfNightsLabel
            // 
            this.numberOfNightsLabel.AutoSize = true;
            this.numberOfNightsLabel.Location = new System.Drawing.Point(386, 246);
            this.numberOfNightsLabel.Name = "numberOfNightsLabel";
            this.numberOfNightsLabel.Size = new System.Drawing.Size(130, 13);
            this.numberOfNightsLabel.TabIndex = 2;
            this.numberOfNightsLabel.Text = "Number of Nights Rented:";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(383, 279);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 26;
            this.testButton.TabStop = false;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(677, 195);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(81, 36);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // enterMovieLabel
            // 
            this.enterMovieLabel.AutoSize = true;
            this.enterMovieLabel.Location = new System.Drawing.Point(227, 52);
            this.enterMovieLabel.Name = "enterMovieLabel";
            this.enterMovieLabel.Size = new System.Drawing.Size(67, 13);
            this.enterMovieLabel.TabIndex = 19;
            this.enterMovieLabel.Text = "Enter Movie:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(9, 324);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(82, 11);
            this.outputLabel.TabIndex = 23;
            this.outputLabel.Text = "outputLabel";
            // 
            // addRentalButton
            // 
            this.addRentalButton.Location = new System.Drawing.Point(589, 111);
            this.addRentalButton.Name = "addRentalButton";
            this.addRentalButton.Size = new System.Drawing.Size(81, 36);
            this.addRentalButton.TabIndex = 4;
            this.addRentalButton.Text = "A&dd A Rental";
            this.addRentalButton.UseVisualStyleBackColor = true;
            this.addRentalButton.Click += new System.EventHandler(this.addRentalButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(589, 195);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(81, 36);
            this.newOrderButton.TabIndex = 9;
            this.newOrderButton.Text = "New Order / Sa&ve";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // endOrderButton
            // 
            this.endOrderButton.Location = new System.Drawing.Point(589, 153);
            this.endOrderButton.Name = "endOrderButton";
            this.endOrderButton.Size = new System.Drawing.Size(81, 36);
            this.endOrderButton.TabIndex = 5;
            this.endOrderButton.Text = "&End Order";
            this.endOrderButton.UseVisualStyleBackColor = true;
            this.endOrderButton.Click += new System.EventHandler(this.endOrderButton_Click);
            // 
            // randomNumberTextbox
            // 
            this.randomNumberTextbox.Location = new System.Drawing.Point(589, 558);
            this.randomNumberTextbox.Name = "randomNumberTextbox";
            this.randomNumberTextbox.Size = new System.Drawing.Size(29, 20);
            this.randomNumberTextbox.TabIndex = 7;
            // 
            // randomNumberLabel
            // 
            this.randomNumberLabel.AutoSize = true;
            this.randomNumberLabel.Location = new System.Drawing.Point(482, 563);
            this.randomNumberLabel.Name = "randomNumberLabel";
            this.randomNumberLabel.Size = new System.Drawing.Size(101, 13);
            this.randomNumberLabel.TabIndex = 6;
            this.randomNumberLabel.Text = "Enter Number Here:";
            // 
            // submitRandomNumber
            // 
            this.submitRandomNumber.Location = new System.Drawing.Point(624, 555);
            this.submitRandomNumber.Name = "submitRandomNumber";
            this.submitRandomNumber.Size = new System.Drawing.Size(75, 23);
            this.submitRandomNumber.TabIndex = 8;
            this.submitRandomNumber.Text = "&Submit";
            this.submitRandomNumber.UseVisualStyleBackColor = true;
            this.submitRandomNumber.Click += new System.EventHandler(this.submitRandomNumber_Click);
            // 
            // managementTotalButton
            // 
            this.managementTotalButton.Location = new System.Drawing.Point(676, 111);
            this.managementTotalButton.Name = "managementTotalButton";
            this.managementTotalButton.Size = new System.Drawing.Size(81, 36);
            this.managementTotalButton.TabIndex = 11;
            this.managementTotalButton.Text = "Management &Totals";
            this.managementTotalButton.UseVisualStyleBackColor = true;
            this.managementTotalButton.Click += new System.EventHandler(this.managementTotalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(676, 153);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(81, 36);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(676, 276);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(81, 26);
            this.reportButton.TabIndex = 10;
            this.reportButton.Text = "Re&port";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Location = new System.Drawing.Point(676, 324);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(82, 11);
            this.reportLabel.TabIndex = 24;
            this.reportLabel.Text = "reportLabel";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // nightsRentedTextBox
            // 
            this.nightsRentedTextBox.Location = new System.Drawing.Point(522, 243);
            this.nightsRentedTextBox.Name = "nightsRentedTextBox";
            this.nightsRentedTextBox.Size = new System.Drawing.Size(24, 20);
            this.nightsRentedTextBox.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Lime;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(5, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(374, 33);
            this.titleLabel.TabIndex = 25;
            this.titleLabel.Text = "Money Man Movie Rentals";
            // 
            // movieRentalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 635);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.nightsRentedTextBox);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.managementTotalButton);
            this.Controls.Add(this.submitRandomNumber);
            this.Controls.Add(this.randomNumberLabel);
            this.Controls.Add(this.randomNumberTextbox);
            this.Controls.Add(this.endOrderButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.addRentalButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.enterMovieLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.numberOfNightsLabel);
            this.Controls.Add(this.newReleaseGroupBox);
            this.Controls.Add(this.movieFormatsGroupBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.removeMovieButton);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.movieComboBox);
            this.Controls.Add(this.removeNameButton);
            this.Controls.Add(this.addNameButton);
            this.Controls.Add(this.customerNameListBox);
            this.Name = "movieRentalsForm";
            this.Text = "Movie Rentals Casey Smith Project 3";
            this.Load += new System.EventHandler(this.movieRentalsForm_Load);
            this.movieFormatsGroupBox.ResumeLayout(false);
            this.movieFormatsGroupBox.PerformLayout();
            this.newReleaseGroupBox.ResumeLayout(false);
            this.newReleaseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customerNameListBox;
        private System.Windows.Forms.Button addNameButton;
        private System.Windows.Forms.Button removeNameButton;
        private System.Windows.Forms.ComboBox movieComboBox;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Button removeMovieButton;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox movieFormatsGroupBox;
        private System.Windows.Forms.RadioButton onlineVhsRadioButton;
        private System.Windows.Forms.RadioButton dvdRadioButton;
        private System.Windows.Forms.RadioButton blueRayRadioButton;
        private System.Windows.Forms.GroupBox newReleaseGroupBox;
        private System.Windows.Forms.CheckBox newReleaseCheckBox;
       
        private System.Windows.Forms.Label numberOfNightsLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label enterMovieLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button addRentalButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button endOrderButton;
        private System.Windows.Forms.Label randomNumberLabel;
        private System.Windows.Forms.TextBox randomNumberTextbox;
        private System.Windows.Forms.Button submitRandomNumber;
        private System.Windows.Forms.Button managementTotalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox nightsRentedTextBox;
        private System.Windows.Forms.Label titleLabel;
    }
}

