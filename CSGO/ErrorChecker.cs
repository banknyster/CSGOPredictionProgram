using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO
{
    class ErrorChecker
    {
        private int countDot = 0;
        private String unCheckedData;

        public ErrorChecker(String inputData)
        {
            this.unCheckedData = inputData;
            calculateNumberOfDot(unCheckedData);
        }

        private int calculateNumberOfDot(String data)
        {

            if (data.IndexOf(".") > -1)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == '.')
                    {
                        countDot += 1;
                    }
                }
            }
            return countDot;
        }

        public double castToDouble()
        {
            double result;

            if (Double.TryParse(unCheckedData, out result))
                return result = Double.Parse(unCheckedData, CultureInfo.InvariantCulture);
            else
                return 0;
        }

        public int getCountDot()
        {
            return this.countDot;
        }

    }

}
