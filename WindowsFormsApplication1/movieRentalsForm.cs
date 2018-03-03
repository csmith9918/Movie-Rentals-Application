
/*
-------------------------------------------------------------------------------------------------------------------------
BUSINESS POINT OF VIEW
-------------------------------------------------------------------------------------------------------------------------
This program is designed to calculate the amount due for Movie Rentals. In the Form we have a list box with 6 Customers
already added in. Below the List box is a text box where the user can add a new customer. To add a new customer enter the name,
and press "Add Name". You can also remove a customer by pressing "Remove Name". Next to the Customer information, we have the Movie
Rental information. You will see a group box that lists 3 types of Movie Formats. The formats are Blue-Ray, DVD, and Online/VHS. The user
can select one of these formats and the Cost of that type is also visible. Below that we have a Group box with a check box that asks the user
to input whether or not the movie is a new release. If the movie is a new release then there is a .75 cent additional charge. Below the checkbox,
is a text box that asks for the number of nights the movie will be rented out.

To the right of the Movie rental information we have the actual Movie Information. This is where the user will input the Movie that will be rented.
Similar to the Name List box, we have a combo box set up with 6 movies already added in. Below that is a "Add movie" Text box, where the user can
add the name of the movie by typing in the movie and clicking the "Add Movie" Button. Again, the user can press the "Remove Movie" Button to remove
the selected movie.

Both of the textboxes include validation, so if the user forgets to enter text then they will get an error message and the cursor will automatically
focus on the spot that needs attention. Also, an error is displayed if the number of nights entered in the text box is less than 1 and greater 
than 7.

When the user successfully fills out all input values, and no errors occur. They can click the "Add a Rental" Button. This will then output a reciept to the user
where they can view all of the choices they have selected. Including the extended price due for the items. All of the input values they have selected will reset except for the users
name so that the user can add another movie if the wish to.

Once the user clicks the 'Add a Rental' button the 'End order' button is enabled. If the user clicks 'End Order' then the final amount dues, number of movies, and 
date of return is appened to the Receipt! 

Below the newly appened information, is a game that the user can play in order to claim their free movie rental. Depending on the number of movies the user rented
they have a limited amount of attempts to guess the correct number between 1 and 10. If the user guesses wrong a message box will display telling them to guess again.
If they guess it correctly they are entitled to 1 free movie added on to their bill at no additional charge. 

Once the user is all done with their order, they must select the 'New Order / Save' Button. When this button is clicked, a dialog box appears prompting the user to save
the customers information to a text file. The information is written to the text file in a comma delimited format. This allows the Movie shop the ability to keep
track of all customer records. 

If the user wants to view this data, they can press the 'Report' Button. This button opens another dialog box, and when the file is clicked it appends the data in a
nice and neat format. Appened to the bottom of the label is the number of items in the text file. 

Also, there is a Management Totals button that calculates all of the customers, and the total of money made in that day. 

Finally, we have a Reset button, to clear all input. And an exit button, to exit the application.

-------------------------------------------------------------------------------------------------------------------------
CLASSROOM POINT OF VIEW ( New Things Learned )
-------------------------------------------------------------------------------------------------------------------------
Error Providers
    - Used for validation. Even though I didnt use an error provider for this project
      I thought I should add it in here anyway, because I know how to. 

           - PROOF : Move Error provider to component tray.

           - CODE  :       if (customerNameListBox == null)
                            {
                             errorProvider1.SetError(customerNameListBox, "CHOOSE A CUSTOMER NAME!");
                             inputBoolean = false;
                            }

Shared Events 
    - Used shared events to pass data from one control to another. And used them for Calculations /
      Decisions with Tag. In order to avoid null exception errors, you must go into the Events
      panel and add the CheckedChanged Property.

File Work
        - System.IO
              Used to get the input/output classes used for working with files.

        - StreamReader
              Neccessary class used to read output from a data file

        - StreamWriter
             Neccassary class used to write data to a text file

        - Arrays
             We used arrays to store comma delimited data in the .txt files

        - Dialog Windows
             Used the open & save dialog boxes to store and view data from .txt files

        - Parse
             Parsed integer variables into an array field to read files

        - Read File
             Used while (!inputMoviesFile.EndOfStream) with report button to loop through data

        - Write Comma Delimited Files
             Used outputMoviesFile to save data to a text file.

Random Numbers
        -   Random generator = new Random();  (USED TO GENERATE A RANDOM NUMBER FOR THE GUESSING GAME)
            randomNumberInteger = generator.Next(0, 11);  (USED TO GET RANDOM NUMBERS BETWEEN THIS RANGE)

Methods or Sub Procedures / Functions
        - Using the void method I passed in 2 arguments to the calculate method from the add order button
          and those new variables are used when the calculation method takes place.

TryParse
    - Even though we used tryParse in previous projects I got extra familiar with it
      this project because I kept getting Unhandled Exception errors. And TryParse was
      usually the solution rather than using int.Parse !

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                // ADDED TO WORK WITH FILES

namespace WindowsFormsApplication1
{
    public partial class movieRentalsForm : Form
    {
        //INTITIALIZE ALL VARIABLES

        // CALCULATED FIELDS
         int randomNumberInteger;  // VARIABLE TO STORE THE RANDOM NUMBER GENERATED
         int guessInteger;

        // CONSTANTS
          private const decimal BLUERAY_TYPE_DECIMAL = 2.25m;      // BASE PRICES FOR MOVIE TYPES
          private const decimal DVD_TYPE_DECIMAL = 1.25m;
          private const decimal VHS_TYPE_DECIMAL = 0.75m;


        //CONTROL & BOOLEAsN VARIABLES FOR OUTPUT & RADIO BUTTON
        private Boolean validationBoolean;

        private RadioButton movieTypeRadioButton;  // RADIO BUTTON FOR SHARED EVENT

        // ACCUMULATORS
        private decimal orderAmountDueDecimal = 0;
        private decimal totalManagementIncomeDecimal = 0;
        private int totalManagementMoviesInteger = 0;

        int buttonCountInteger = 0; // COUNT THE NUMBER OF TIMES THE ADD TO ORDER BUTTON WAS CLICKED (FOR NUMBER OF MOVIES RENTED)
        int guessButtonCountInteger = 0; // COUNT THE NUMBER OF TIMES THE GUESS BUTTON IS CLICKED

        // WORKING VARIABLE
        int numberOfGuessesInteger;
        int quantityOfMoviesInteger;



        public movieRentalsForm()
        {
            InitializeComponent();
        }

        StreamReader inputMoviesFile;           // creates an readable filename
        StreamWriter outputMoviesFile;          // files name used in program

        Boolean searchBoolean;

        businessTier calculation;
        private int Nights;


        // SET UP STRING FOR MOVIE TYPE, THEN TAG PROPERTY ASSIGNMENT OF PRICE (FOR SHARED EVENT HANDLER) 
        // AND CLEAR DEFAULT LABEL NAME
        private void movieRentalsForm_Load(object sender, EventArgs e)
        {
            blueRayRadioButton.Text += " @ " + BLUERAY_TYPE_DECIMAL.ToString("C") + " ea.";    // SET THE TEXT PROPERTY FOR RADIO BUTTONS W/ PRICE
            dvdRadioButton.Text += " @ " + DVD_TYPE_DECIMAL.ToString("C") + " ea.";
            onlineVhsRadioButton.Text += " @ " + VHS_TYPE_DECIMAL.ToString("C") + " ea.";

            blueRayRadioButton.Tag = BLUERAY_TYPE_DECIMAL;     // SET RADIO BUTTON TAG PROPERTY WITH BASE PRICES OF EACH TYPE
            dvdRadioButton.Tag = DVD_TYPE_DECIMAL;
            onlineVhsRadioButton.Tag = VHS_TYPE_DECIMAL;

            outputLabel.Text = string.Empty; //CLEAR DEFAULT LABEL TEXT
            reportLabel.Text = string.Empty; //CLEAR DEFUALT LABEL TEXT

            endOrderButton.Enabled = false;
            newOrderButton.Enabled = false;



        }

        // ADD TO RENTAL BUTTON CONTROLS ALL ACTIVITIES FOR EACH LINE ITEM & ACCUMULATES FOR CUSTOMER TOTALS
        private void addRentalButton_Click(object sender, EventArgs e)
        {
            validationBoolean = false;  // DEFAULT BOOLEAN IS FALSE UNTIL SAID OTHERWISE
            Validation();
            if (validationBoolean)
            {
                Calculate(); // DO CALCULATION WITH PASSED VALUES          
                AccumulateCustomerTotals();
                OutputReciept();                        // CALL PROCESSES IN ORDER FOR A SINGLE LINE ITEM
                clearInputsForNewMovie();

                endOrderButton.Enabled = true;  // ENABLE END ORDER BUTTON
                customerNameListBox.Enabled = false; //DISABLE ABILITY TO CHANGE CUSTOMER NAME UNTIL END OF ORDER

                totalManagementMoviesInteger++; // INCREMENT NUMBER OF MOVIES FOR MANAGEMENT TOTALS
               


            }
        }

        private void Validation() // VALIDATION OF INPUT FIELDS FOR CALCULATION
        {
            movieFormatsGroupBox.BackColor = Color.Transparent; // CLEAR COLOR IF PREVIOUSLY AN ERROR


            // VALIDATION FOR NAME SELECTION
            if (customerNameListBox.SelectedItem != null) //CHECK IF NAME IS SELECTED 
            {
                validationBoolean = true;

                // VALIDATION FOR MOVIE SELECTION
                if (movieComboBox.SelectedItem != null) //CHECK IF MOVIE IS SELECTED
                {
                    validationBoolean = true;

                    // VALIDATION FOR MOVIE FORMAT
                    if (blueRayRadioButton.Checked || dvdRadioButton.Checked || onlineVhsRadioButton.Checked) // TEST THAT VIDEO FORMAT IS SELECTED
                    {
                        validationBoolean = true; //SET BOOLEAN TO TRUE IF A RADIO BUTTON HAS BEEN SELECTED

                        // VALIDATION FOR NIGHTS RENTED TEXTBOX


                        int moviesRented; // CREATED FOR TRY PARSE VALUE (KEPT GETTING AN UNHANDLED EXCEPTION ERROR WHEN NOTHING WAS IN THE TEXTBOX - TRY PARSE WORKED!!)
                        if (int.TryParse(nightsRentedTextBox.Text, out moviesRented))
                             {
                                quantityOfMoviesInteger = int.Parse(nightsRentedTextBox.Text);
                             }

                        if (quantityOfMoviesInteger > 0 && quantityOfMoviesInteger < 7) //CHECK IF TEXTBOX IS EMPTY
                        {
                            validationBoolean = true;
                        }

                        else
                        {
                            validationBoolean = false;
                            MessageBox.Show("Quantity must be Between 1 - 7", "DAYS RENTED INPUT ERROR", // OUTPUT ERROR MESSAGE
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            nightsRentedTextBox.Focus();  // FOCUS USER ATTENTION TO THE ERROR SO IF CAN BE FIXED
                            nightsRentedTextBox.SelectAll();   
                        }
                    }

                    else
                    {
                        validationBoolean = false;
                        MessageBox.Show("Please Select a Movie Format!", "MOVIE FORMAT INPUT ERROR", // OUTPUT ERROR MESSAGE
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        movieFormatsGroupBox.Focus(); // FOCUS USER ATTENTION TO THE ERROR SO IF CAN BE FIXED
                        movieFormatsGroupBox.Select();
                        movieFormatsGroupBox.BackColor = Color.IndianRed; // SHOW WHERE ERROR WITH COLOR 
                    }
                }

                else
                {
                validationBoolean = false;
                MessageBox.Show("Don't Forget to Select A Movie!", "MOVIE INPUT ERROR", // OUTPUT ERROR MESSAGE
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerNameTextBox.Focus(); // FOCUS USER ATTENTION TO THE ERROR SO IF CAN BE FIXED
                    customerNameTextBox.SelectAll();
  
                 }
             }
 
             else
             {
                validationBoolean = false;
                MessageBox.Show("Don't Forget to Select A Customer!", "CUSTOMER INPUT ERROR", // OUTPUT ERROR MESSAGE
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerNameTextBox.Focus(); // FOCUS USER ATTENTION TO THE ERROR SO IF CAN BE FIXED
                customerNameTextBox.SelectAll();

             }
         }

    private void addNameButton_Click(object sender, EventArgs e)
        {
            // VALIDATION TO SEE IF NAME HAS BEEN ENTERED IN TEXTBOX
            if (customerNameTextBox.Text.Trim() != string.Empty) //Check textbox is empty
            {
                SearchForCustomer(); // Call the search for customer method

                if (searchBoolean)  // when true - not found in list so add the name

                    customerNameListBox.Items.Insert(customerNameListBox.Items.Count, customerNameTextBox.Text);  // ADD TEXT TO BOTTOM OF LIST BOX
                else
                    MessageBox.Show("WAIT! ...Customer already exists!", "DUPLICATE CUSTOMER ERROR");

                customerNameTextBox.Clear();

            }

            // DISPLAY ERROR IF NOTHING IS ENTERED
            else
            {
                MessageBox.Show("Enter a Customer Name first", "CUSTOMER NAME INPUT ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerNameTextBox.Focus();
                customerNameTextBox.SelectAll();
            }
        }


        private void SearchForCustomer()    // Search for duplicate customer name
        {     // set searchBoolean == true when no match (add) else false = match (error)

            int indexInt = 0;     // local variable for indexing (pointing to item in listbox)
            searchBoolean = true;


            // loop while (no match) & 
            // customer name to compare - not at end of the listbox items
            while (searchBoolean == true && indexInt < customerNameListBox.Items.Count)
            {
                if (customerNameTextBox.Text.ToUpper() == customerNameListBox.Items[indexInt].ToString().ToUpper())   // compare input w/item in listbox
                {
                    searchBoolean = false;
                }
                indexInt++;             // increment the index integer by 1 with each iteration
            }
        }

        private void removeNameButton_Click(object sender, EventArgs e)
        {
            if (customerNameListBox.SelectedItem != null) //IF STATEMENT NOT EQUAL TO NULL 
                customerNameListBox.Items.Remove(customerNameListBox.SelectedItem);  //REMOVE METHOD          
            else
                MessageBox.Show("Select a Customer First!", "SELECTION ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerNameTextBox.Focus();
                    customerNameTextBox.SelectAll();
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            // VALIDATION TO SEE IF MOVIE HAS BEEN ENTERED IN TEXTBOX
            if (movieComboBox.Text.Trim() != string.Empty)
            {

                SearchForMovies(); // Call the search for movie method

                if (searchBoolean)  // when true - not found in list so add the movie

                    movieComboBox.Items.Insert(movieComboBox.Items.Count, movieComboBox.Text);  // ADD TEXT TO BOTTOM OF LIST BOX
                else 
                    MessageBox.Show("HEY! ... That movie already exists here!", "DUPLICATE MOVIE ERROR"); // GET YELLED AT

                movieComboBox.ResetText();

            }

            // DISPLAY ERROR IF NOTHING IS ENTERED
            else
            {
                MessageBox.Show("Enter a Movie First", "MOVIE TITLE INPUT ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                movieComboBox.Focus();
                movieComboBox.SelectAll();
            }

        }


        private void SearchForMovies()    // Search for duplicate customer name
        {     // set searchBoolean == true when no match (add) else false = match (error)

            int indexInt = 0;     // local variable for indexing (pointing to item in listbox)
            searchBoolean = true;


            // loop while (no match) & 
            // customer name to compare - not at end of the listbox items
            while (searchBoolean == true && indexInt < movieComboBox.Items.Count)
            {
                if (movieComboBox.Text.ToUpper() == movieComboBox.Items[indexInt].ToString().ToUpper())   // compare input w/item in listbox
                {
                    searchBoolean = false;
                }
                indexInt++;             // increment the index integer by 1 with each iteration
            }
        }



        private void removeMovieButton_Click(object sender, EventArgs e)
        {
            if (movieComboBox.SelectedItem != null) //IF STATEMENT NOT EQUAL TO NULL 
                movieComboBox.Items.Remove(movieComboBox.SelectedItem);  //REMOVE METHOD          
            else
                MessageBox.Show("Select a Customer First!","SELECTION ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    movieComboBox.Focus();
                    movieComboBox.SelectAll();

        }
 

        // CALCULATION FOR PRICE OF ONE INLINE MOVIE ITEM
        private void Calculate() // 2 ARGUMENTS ARE PASSED IN USING VOID METHOD ON ADD NEW ORDER BUTTON CLICK
        {
            // TRY PARSE BECAUSE IT WORKED BETTER THAN INT.PARSE

            if (int.TryParse(nightsRentedTextBox.Text, out Nights))
            {
                //USE BUSINESSTIER CLASS FOR CALC
                calculation = new businessTier((decimal)movieTypeRadioButton.Tag, Nights);
        
            }

            // USED THE VOID METHOD HERE TO PASS 2 ARGUMENTS TO DO THE CALCULATION

            if (newReleaseCheckBox.Checked) // IF STATEMENT TO CHECK WETHER OR NOT THE CHECKBOX HAS BEEN SELECTED
            {
                //USE NEWRELEASE CLASS FOR CALC
                calculation = new newRelease((decimal)movieTypeRadioButton.Tag, Nights);
            }
            else
            {
                //ELSE PRICE IS THE SAME
               calculation = new businessTier((decimal)movieTypeRadioButton.Tag, Nights);
            }

        
    }

      


        // OUTPUT OF ALL INFORMATION TO GO ON THE RECIEPT
        private void OutputReciept()
        {
            if (outputLabel.Text == string.Empty)  //CHECKS TO SEE IF THE LABEL IS EMPTY BEFORE OUTPUTTING MAKING SURE IT DOESNT OUTPUT TWICE
            {
                outputLabel.Text = "Money Man Movie Rentals" + Environment.NewLine +
                    DateTime.Now.ToShortDateString() + Environment.NewLine +
                    "For " + customerNameListBox.SelectedItem + Environment.NewLine +
                    "Thank you for Renting From us Today!" +
                    Environment.NewLine + Environment.NewLine +
                    "Movie".PadRight(20) +
                    "Media && Price".PadRight(30) +
                    "Cost".PadRight(10) +
                    "Days Rented".PadRight(15) +
                    "Total Cost".PadRight(10) +
                    Environment.NewLine+
                    "-".PadRight(84, '-') +
                    Environment.NewLine + Environment.NewLine;

            }
                outputLabel.Text += movieComboBox.SelectedItem.ToString().PadRight(20) +  // ADD MULTIPLE INLINE ITEMS TO THE RECIEPT LABEL
                movieTypeRadioButton.Text.PadRight(30) +
                calculation.Price.ToString("c").PadRight(10) +
                quantityOfMoviesInteger.ToString().PadRight(15) +
                calculation.MoviePriceExtended.ToString("c").PadRight(10) +
                Environment.NewLine;
           
        }

        private void clearInputsForNewMovie()
        {
            movieTypeRadioButton.Checked = true;
            movieTypeRadioButton.Checked = false;  //CLEAR RADIOBUTTONS
            movieTypeRadioButton.TabStop = true;
            movieComboBox.SelectedIndex = -1; // CLEAR COMBO BOX LIST ITEM, COULD ALSO USE ( movieComboBox.SelectedItem = null;)
            newReleaseCheckBox.Checked = false; //CLEAR CHECKBOX
            nightsRentedTextBox.Text = "0";

        }

        // SHARED EVENTS

        private void movieTypeRadioButtons_CheckedChanged(object sender, EventArgs e) //SHARED EVENT HANDLER FOR MOVIE TYPE RADIO BUTTONS
        {
            movieTypeRadioButton = (RadioButton)sender; 
            movieFormatsGroupBox.BackColor = Color.Transparent;

        }

        // ACCUMULATE CUSTOMER TOTALS AND THE NUMBER OF GUESSES A USER GETS FOR A FREE MOVIE
        // USER BUSINESS TIER TO GET THE NUMBER OF GUESSES

        private void AccumulateCustomerTotals()
        {

            // DETERMINE NUMBER OF TIMES A USER CAN GUESS THE RANDOM NUMBER FOR A CHANCE TO WIN A FREE RENTAL
            if (businessTier.ButtonCount == 1)  // IF USER BUYS 1 MOVIE THEY GET 1 GUESS
            {
                numberOfGuessesInteger = 1;
            }
            if (businessTier.ButtonCount == 2 || businessTier.ButtonCount == 3)  // IF USER BUYS 2 or 3 MOVIES THEY GET 2 GUESSES
            {
                numberOfGuessesInteger = 2;
            }
            if (businessTier.ButtonCount == 4 || businessTier.ButtonCount == 5) // IF USER BUYS 4 or 5 MOVIES THEY GET 3 GUESSES
            {
                numberOfGuessesInteger = 3;
            }
            if (businessTier.ButtonCount > 5)  // IF USER BUYS MORE THAN 5 MOVIES THEY GET 4 GUESSES
            {
                numberOfGuessesInteger = 4;
            }
        }

        // OUTPUT THE FINAL ORDER DETAILS AND THE RANDOM NUMBER GENERATOR GAME FOR A FREE MOVIE RENTAL
        private void endOrderButton_Click(object sender, EventArgs e)
        {
               
            //FINAL CALCULATIONS
            //OUTPUT FINAL CALCULATIONS TO END OF RECIEPT UPON END ORDER BUTTON CLICK

            outputLabel.Text += Environment.NewLine + Environment.NewLine +
                "Order Amount Due: " + businessTier.OrderAmount.ToString("c") + Environment.NewLine +  // OUTPUT TOTAL AMOUNT DUE DECIMAL
                "Number of Movies: " + businessTier.ButtonCount + Environment.NewLine +  // OUTPUT NUMBER OF MOVIES RENTED
                "Date of Return: " + DateTime.Now.AddDays(quantityOfMoviesInteger).ToShortDateString() + //Get the current time and add the number of nights rented 
                Environment.NewLine + Environment.NewLine +
                "THANK YOU FOR YOUR ORDER!" +
                Environment.NewLine + Environment.NewLine +
                "YOU ARE ELIGIBLE FOR " + numberOfGuessesInteger + " CHANCES TO WIN ONE FREE MOVIE RENTAL." + Environment.NewLine +
                "YOU MUST GUESS THE CORRECT NUMBER BETWEEN 1 - 10" + Environment.NewLine;

                newOrderButton.Enabled = true;
                addRentalButton.Enabled = false;
                endOrderButton.Enabled = false;
                customerNameListBox.Enabled = true; // ALLOW USER TO CHANGE CUSTOMER NAME
        }
           
        // CREATE RANDOM NUMBER AND TEST TO SEE IF RANDOM NUMBER MATCHES THE USERS GUESS
        // DISPLAY WETHER OR NOT USER GUESSED CORRECTLY
        // DISABLE BUTTON IF USER RUNS OUT OF GUESSES.
        private void submitRandomNumber_Click(object sender, EventArgs e)
        {

            

            Random generator = new Random(); // Generate random number
            randomNumberInteger = generator.Next(0, 11); // Between this range

            guessButtonCountInteger++;  // INCREMENT NUMBER OF TIMES GUESS BUTTON IS CLICKED
            

            int.TryParse(randomNumberTextbox.Text, out guessInteger);
            {
                if (guessInteger > randomNumberInteger)
                {
                    MessageBox.Show("Sorry, The Correct Number Was " + randomNumberInteger + "!" + Environment.NewLine + "Guess Again");
                }
                else if (guessInteger < randomNumberInteger)
                {
                    MessageBox.Show("Sorry, The Correct Number Was " + randomNumberInteger + "!" + Environment.NewLine + "Guess Again");  // OUTPUT GUESS AGAIN
                }

                if (guessButtonCountInteger == numberOfGuessesInteger)
                {
                    MessageBox.Show("Sorry, But you are out of guesses");
                    submitRandomNumber.Enabled = false;  // DIABLE BUTTON IF USER HAS NO MORE GUESSES LEFT
                }

                if (guessInteger == randomNumberInteger)
                {
                    MessageBox.Show("Congrats, You Recieve A Free Rental!"); // OUTPUT USER WINS
                }

            }

    }

        // TEST BUTTON FOR EASIER TESTING
        private void testButton_Click(object sender, EventArgs e)
        {

            customerNameListBox.SelectedItem = "Rudolph";   // OUTPUT TEST NAME
            movieComboBox.SelectedItem = "Happy Gilmore"; // OUTPUT TEST MOVIE
            onlineVhsRadioButton.Checked = true;  // CHECK RADIO BUTTON
            nightsRentedTextBox.Text = "2"; // OUTPUT NUMBER OF NIGHTS
        }

        
        // EXIT PROGRAM EXECUTION
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // CLEAR INPUTS FOR NEW CUSTOMER
        private void newOrderButton_Click(object sender, EventArgs e)
        {


            // ******************* FILE WORK *******************//
            // PLACED INSIDE THE NEW ORDER BUTTON SO THAT THE FILE MUST BE SAVED BEFORE NEW CUSTOMER CAN BE ADDED
            try
            {

                saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
                saveFileDialog1.FileName = "name.txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    outputMoviesFile = File.AppendText(saveFileDialog1.FileName); // WRITE FILE NAME ON DISC

                    outputMoviesFile.WriteLine(customerNameListBox.SelectedItem + "," + // WRITE ONLY THE SELECTED ITEM TO FILE
                        DateTime.Now.ToShortDateString() + "," +  // WRITE DATE TO FILE
                        buttonCountInteger);  // WRITE NUMBER OF MOVIES TO FILE

                    outputMoviesFile.Close(); // CLOSE DIALOG
                }
                else
                {
                    MessageBox.Show("Save was Canceled!");
                }
            }
            catch (Exception err)  // ERROR
            {
                MessageBox.Show(err.Message);
            }



            newReleaseCheckBox.Checked = false; //CLEAR CHECKBOX

            outputLabel.Text = string.Empty; // CLEAR OUTPUT

            clearInputsForNewMovie(); // CALL METHOD TO CLEAR RADIOBUTTON AND NUMBER OF MOVIES TEXTBOX

            customerNameTextBox.Focus(); 
            customerNameTextBox.Clear();
            movieComboBox.Text = string.Empty; //CLEAR COMBOBOX TEXT

            endOrderButton.Enabled = false;  //DISABLE END ORDER BUTTON
            newOrderButton.Enabled = false; //DISABLE NEW ORDER BUTTON
            addRentalButton.Enabled = true;

            buttonCountInteger = 0;  // RESET NUMBER OF MOVIES RENTED 
            orderAmountDueDecimal = 0; // RESET AMOUNT DUE 

            customerNameListBox.SelectedItem = null;  //CLEAR LIST BOX
            movieComboBox.SelectedItem = null; //CLEAR COMBOBOX


        }


        private void managementTotalButton_Click(object sender, EventArgs e)
        {

            // OUTPUT FOR MANAGEMENT TOTALS
            string managementTotalString = "Total Income Today is " + businessTier.TotalManagementIncome.ToString("C") + Environment.NewLine +
                "For a Total of " + totalManagementMoviesInteger.ToString() + " Customers" + Environment.NewLine + Environment.NewLine +
                "Click YES to Reset Totals";

            //RESET FOR MANAGEMENT TOTALS
            if (MessageBox.Show(managementTotalString, "MANAGEMENT TOTALS", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)== DialogResult.Yes)
            {
                totalManagementIncomeDecimal = 0;
                totalManagementMoviesInteger = 0;
            }
        }

        // ************REPORT BUTTON************//
        // OPENS DIALOG TO OPEN FILE WHEN THE REPORT BUTTON IS CLICKED
        private void reportButton_Click(object sender, EventArgs e)
        {
            reportLabel.Text = "Money Man's Daily Reports" + Environment.NewLine + Environment.NewLine +
                "Customer".PadRight(18) + "Date".PadRight(15) + "# Movies Rented" + Environment.NewLine + Environment.NewLine;

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "name.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)    // DISPLAYS OPEN DIALOG, TESTS FOR FILE INPUT, AND OK BUTTON
            {
                inputMoviesFile = File.OpenText(openFileDialog1.FileName);   // OPENS FILE

                while (!inputMoviesFile.EndOfStream)
                {
                    string inputRecordString = inputMoviesFile.ReadLine();  // READ AND STORES INPUT RECORD

                    var inputFields = inputRecordString.Split(',');

                    
                    string customerNameString = inputFields[0];    //  brackets[] - used for array
                    
                    string date = DateTime.Parse(inputFields[1].Trim()).ToShortDateString();

                    int numberOfMoviesDecimal = int.Parse(inputFields[2]);

                   
                    // OUTPUT REPORT LABEL TEXT IN NEAT AND ORDERLY DESIGN
                    reportLabel.Text += customerNameString.PadRight(18) + 
                                        date.ToString().PadRight(15) +
                                        numberOfMoviesDecimal.ToString() + Environment.NewLine;
                }

                // GET THE LENGTH OF THE LINES IN THE TEXT FILE AND OUTPUT AS THE NUMBER OF RECORDS
                int numberOfRecordsInteger = File.ReadAllLines("name.txt").Length; // GET THE NUMBER OF LINES IN THE TEXT DOCUMENT
                reportLabel.Text += Environment.NewLine + "Number of Records: " + numberOfRecordsInteger;  // ADD TO THE BOTTOM OF THE LABEL

                //TO GET THE NUMBER OF LINES I COULD HAVE ALSO USED A WHILE LOOP (EXAMPLE BELOW)
                // I CHOSE THE OTHER METHOD BECAUSE IT IS A ONE LINER

                //int count = 0;
                //string numberOfRecordsString;
                //TextReader reader = new StreamReader("name.txt");
                //while ((numberOfRecordsString = reader.ReadLine()) != null)
                //{
                //    count++;
                //}
                //reader.Close();

            }
        }

        //RESET EVERYTHING IN THE APPLICATION TO DEFAULTS
        private void clearButton_Click(object sender, EventArgs e)
        {
            newReleaseCheckBox.Checked = false; //CLEAR CHECKBOX
            outputLabel.Text = string.Empty; // CLEAR OUTPUT
            customerNameTextBox.Clear(); //CLEAR CUST NAME
            movieComboBox.Text = string.Empty; //CLEAR COMBOBOX TEXT
            endOrderButton.Enabled = false;  //DISABLE END ORDER BUTTON
            newOrderButton.Enabled = false; //DISABLE NEW ORDER BUTTON
            addRentalButton.Enabled = true; //ENABLE ONLY ADD RENTAL BUTTON
            orderAmountDueDecimal = 0; // RESET AMOUNT DUE 
            quantityOfMoviesInteger = 0; // RESET TO 0
            totalManagementIncomeDecimal = 0;// RESET TO 0
            totalManagementMoviesInteger = 0;// RESET TO 0
            buttonCountInteger = 0; // RESET TO 0
            guessButtonCountInteger = 0; // RESET TO 0
            customerNameListBox.SelectedItem = null;  //CLEAR LIST BOX
            movieComboBox.SelectedItem = null; //CLEAR COMBOBOX
            reportLabel.Text = ""; //EMPTY REPORT LABEL
        }
    }
}
