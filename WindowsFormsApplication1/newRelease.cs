using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class newRelease : businessTier
    {
        // 
        private const decimal _NEW_RELEASE_PRICE_DECIMAL = 0.75m; // BASE PRICE FOR NEW RELEASE

        public newRelease(decimal price, int nights) // Constructor
                        :base(price, nights) // Pass Parameters to base
        {

        }

        protected override void Calculate()

        {

            _priceOneMovieDecimal = _numNightsInteger * _priceOneMovieDecimal; // TOTAL PRICE OF ONE MOVIE

            _priceExtendedDecimal = _priceOneMovieDecimal + _NEW_RELEASE_PRICE_DECIMAL; // EXTENDED PRICE IF NEW RELEASE CHECKBOX IS CHECKED

        }


    }
}
