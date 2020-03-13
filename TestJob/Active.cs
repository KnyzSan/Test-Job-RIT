using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZadanie
{
    public class Active
    {
        public string Title;
        public ActiveType Type;
        public Dictionary<string, string> AdditionalData;

        #region Count
        public decimal Count;
        #endregion

        #region Count is unknown

        public decimal StartPrice;
        public decimal ResidualPrice;
        public decimal EstimatedPrice;

        #endregion

        public override string ToString()
        {
            var addContent = "";
            if (Type.KnownCount)
            {
                addContent = $"{Count}";
            }
            else
            {
                addContent = $"нач. стоимость: {StartPrice}";
            }

            return $"{Title} ({Type}, {addContent})";
        }
    }
}
