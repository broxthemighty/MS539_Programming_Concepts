using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WH40K_GUI_UAT_MS539_ML
{
    internal class RandomNumber
    {
        //this class is for the creation and return of a random number
        //need to add a default constructor that returns a random number from 1-100
        //need an overloaded constructor that takes in two int values to return a random number between the two
        //this class can use built ins to accomplish the needed code, but I am making my own to be specific to this project

        private int _rando = 0;
        public int getRandomNumber() { return _rando; }

        public RandomNumber()
        {
            Random random = new Random();
            _rando = random.Next(0, 100);
        }

        public RandomNumber(int startingValue, int endingValue) 
        {
            Random random = new Random();
            _rando = random.Next(startingValue, endingValue);
        }
    }
}
