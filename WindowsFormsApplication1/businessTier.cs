using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class businessTier
    {

        // CREATE BACKING FIELDS

        // CALCULATED FIELDS
        protected decimal _priceOneMovieDecimal; // UNIT PRICE OF MOVIE - 1 RENTAL
        protected decimal _priceExtendedDecimal; // EXTENDED PRICE FOR MULTIPLE RENTALS


        // WORKING VARIABLES
        protected int _numNightsInteger;
        protected int _randomNumberInteger;  // VARIABLE TO STORE THE RANDOM NUMBER GENERATED
        protected int _guessInteger;
        protected int _numberOfGuessesInteger;
        protected int _quantityOfMoviesInteger;




        // CONSTANTS
        private const decimal _BLUERAY_TYPE_DECIMAL = 2.25m;      // BASE PRICES FOR MOVIE TYPES
        private const decimal _DVD_TYPE_DECIMAL = 1.25m;
        private const decimal _VHS_TYPE_DECIMAL = 0.75m;
       

        // ACCUMULATORS
        private static decimal _orderAmountDueDecimal = 0;
        private static decimal _totalManagementIncomeDecimal = 0;
        private static int _totalManagementMoviesInteger = 0;
        private static int _buttonCountInteger = 0; // COUNT THE NUMBER OF TIMES THE ADD TO ORDER BUTTON WAS CLICKED (FOR NUMBER OF MOVIES RENTED)
        private static int _guessButtonCountInteger = 0; // COUNT THE NUMBER OF TIMES THE GUESS BUTTON IS CLICKED
        private decimal _newReleasePrice;

        public businessTier(decimal price, int nights)
        {
            Nights = nights;
            Price = price;



            Calculate();
            AccumulateCustomerTotals();
            AccumulateManagementTotals();
        
        }




        public decimal Price
        {
            get { return _priceOneMovieDecimal; }
            set { _priceOneMovieDecimal = value; }
        }

        public int Nights
        {
            get { return _numNightsInteger; }
            set { _numNightsInteger = value; }
        }





        public decimal MoviePriceExtended
        {
            get { return _priceExtendedDecimal; }
        }

        //ACCUMULATED TOTAL PROPERTIES AS STATIC PROPERTIES

            public static decimal OrderAmount
        {
            get { return _orderAmountDueDecimal; }
        }

        public static int ButtonCount
        {
            get { return _buttonCountInteger; }
        }

        public static decimal TotalManagementIncome
        {
            get { return _totalManagementIncomeDecimal; }
        }

        public static decimal orderAmountDue
        {
            get { return _orderAmountDueDecimal; }
        }




        // CALCULATION FOR PRICE OF ONE INLINE MOVIE ITEM
        protected virtual void Calculate() 
        {
            // TRY PARSE BECAUSE IT WORKED BETTER THAN INT.PARSE
          
                _priceOneMovieDecimal = _numNightsInteger * _priceOneMovieDecimal;
            
                _priceExtendedDecimal = _priceOneMovieDecimal + _newReleasePrice; 
            }







        // ACCUMULATE CUSTOMER TOTALS AND THE NUMBER OF GUESSES A USER GETS FOR A FREE MOVIE
        private void AccumulateCustomerTotals()
        {
            _orderAmountDueDecimal += _priceExtendedDecimal; // ACCUMULATE THE TOTAL AMOUNT DUE DECIMAL TO OUTPUT WHEN END ORDER BUTTON IS CLICKED

            _buttonCountInteger++;  // INCREMENT THE NUMBER OF TIMES THE ADD TO ORDER BUTTON WAS CLICKED (DETERMINES NUMBER OF MOVIES RENTED)


            // DETERMINE NUMBER OF TIMES A USER CAN GUESS THE RANDOM NUMBER FOR A CHANCE TO WIN A FREE RENTAL
            if (_buttonCountInteger == 1)  // IF USER BUYS 1 MOVIE THEY GET 1 GUESS
            {
                _numberOfGuessesInteger = 1;
            }
            if (_buttonCountInteger == 2 || _buttonCountInteger == 3)  // IF USER BUYS 2 or 3 MOVIES THEY GET 2 GUESSES
            {
                _numberOfGuessesInteger = 2;
            }
            if (_buttonCountInteger == 4 || _buttonCountInteger == 5) // IF USER BUYS 4 or 5 MOVIES THEY GET 3 GUESSES
            {
                _numberOfGuessesInteger = 3;
            }
            if (_buttonCountInteger > 5)  // IF USER BUYS MORE THAN 5 MOVIES THEY GET 4 GUESSES
            {
                _numberOfGuessesInteger = 4;
            }

        }

                      // ACCUMULATE MANAGEMNT TOTALS
        private void AccumulateManagementTotals()
        {
            _totalManagementIncomeDecimal += _orderAmountDueDecimal;  // ACCUMULATE INCOME DECIMAL


        }











    }
    
}
