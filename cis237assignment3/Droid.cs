using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        private string _material;
        private string _model;
        private string _color;

        private decimal _baseCost;
        private decimal _totalCost;

        public decimal TotalCost
        {
            get
            {
                return _totalCost;
            }

            set
            {
                _totalCost = value;
            }
        }

        

        public Droid(string material, string model, string color)
        {
            _material = material;
            _model = model;
            _color = color;
        }

        public virtual void CalculateTotalCost()
        {
            _totalCost = _baseCost;
        }

        public override string ToString()
        {
            return "Model: " + _model + " - Material: " + _material + "- Color: " + _color;
        }

        public void CalculateBaseCost(string material, string model)
        {
            switch (model)
            {
                case "protocol":
                    _baseCost = 80m;
                    break;
                case "utility":
                    _baseCost = 100m;
                    break;
                case "janitor":
                    _baseCost = 120m;
                    break;
                case "astromech":
                    _baseCost = 150m;
                    break;
            }

            switch (material)
            {
                case "titanium":
                    _baseCost += 50m;
                    break;
                case "gold":
                    _baseCost += 80m;
                    break;
                case "steel":
                    _baseCost += 20m;
                    break;
            }
        }
    }
}
