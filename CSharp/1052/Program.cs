using System;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        Dictionary<int, string> month = new Dictionary<int, string>
        {
            {1, "January"},
            {2, "February"},
            {3, "March"},
            {4,"April"},
            {5,"May"},
            {6, "June"},
            {7, "July"},
            {8, "August"},
            {9, "September"},
            {10, "October"},
            {11, "November"},
            {12, "December"}
        };
        
        int monthInput = int.Parse(Console.ReadLine());
        System.Console.WriteLine(month[monthInput]);

    }

}
