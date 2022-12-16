using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class MobilePhone:Old
    {
        public string model;
        public int pathYear; 
        public decimal beginPrices;


        public MobilePhone(string _model, int _pathYear, decimal _beingPrices)
        {
            this.model = _model;
            this.pathYear = _pathYear;
            this.beginPrices = _beingPrices;
        }

        public decimal nowPrice //bu prob duz mentiqded? set ve get deyeri ferqlidi
        {
            get
            {
                return beginPrices - PriceDownCalculation(this.pathYear);
            }
            set
            {
                PriceDownCalculation(this.pathYear);
            }
        }

        public void ChangeProporties(string _model)
        {
            this.model= _model;
        }

        public void ChangeProporties(int pathYear)
        {
            this.pathYear = pathYear;
        }

        public void ChangeProporties(decimal _beingPrices)
        {
            this.beginPrices= _beingPrices;
        }

        
    }
}
