using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Le_Tien_Dat
{
    public class Calculator
    {
        private double a;
		public bool CanErease;

		public Calculator()
        {
            a = 0.0;
			CanErease = false;
		}
		public double Percent(double b, char op)
		{
			if (a != 0.0)
			{
				if (op == '+')
					return a + ((a * b) / 100.0);
				else if (op == '-')
					return a - ((a * b) / 100.0);
				else if (op == '×')
					return a * ((a * b) / 100.0);
				else if (op == '÷')
					return a / ((a * b) / 100.0);
			}
			return 0.0;
		}
	}
}
