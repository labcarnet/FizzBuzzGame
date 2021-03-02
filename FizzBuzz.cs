using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class FizzBuzz
    {
        private string _result;
        public string SetResult(int userDigit)
        {
            if (userDigit % 3 == 0) _result += "Fizz";
            if (userDigit % 5 == 0) _result += "Buzz";
            if (userDigit % 3 != 0 && userDigit % 5 != 0) _result = userDigit.ToString();
            return _result;
        }
    }
}
