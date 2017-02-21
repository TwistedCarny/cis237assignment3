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

        private const decimal PROTOCOL_MODEL_COST = 80m;
        private const decimal UTILITY_MODEL_COST = 100m;
        private const decimal JANITOR_MODEL_COST = 120m;
        private const decimal ASTROMECH_MODEL_COST = 150m;

        private const decimal TITANIUM_MATERIAL_COST = 50m;
        private const decimal GOLD_MATERIAL_COST = 80m;
        private const decimal STEEL_MATERIAL_COST = 20m;

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

        

        public Droid(string model, string material, string color)
        {
            _material = material;
            _model = model;
            _color = color;

            CalculateBaseCost(_material, _model);
        }

        public virtual void CalculateTotalCost()
        {
            _totalCost = _baseCost;
        }

        public override string ToString()
        {
            return "Model: " + _model + Environment.NewLine + "Material: " + _material + Environment.NewLine + "Color: " + _color + Environment.NewLine;
        }

        public void CalculateBaseCost(string material, string model)
        {
            switch (model)
            {
                case "protocol":
                    _baseCost = PROTOCOL_MODEL_COST;
                    break;
                case "utility":
                    _baseCost = UTILITY_MODEL_COST;
                    break;
                case "janitor":
                    _baseCost = JANITOR_MODEL_COST;
                    break;
                case "astromech":
                    _baseCost = ASTROMECH_MODEL_COST;
                    break;
            }

            switch (material)
            {
                case "titanium":
                    _baseCost += TITANIUM_MATERIAL_COST;
                    break;
                case "gold":
                    _baseCost += GOLD_MATERIAL_COST;
                    break;
                case "steel":
                    _baseCost += STEEL_MATERIAL_COST;
                    break;
            }
        }
    }
}
