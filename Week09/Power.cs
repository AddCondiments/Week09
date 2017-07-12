using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09
{
    /*
 * Name: Matthew Watada
 * July 12th 2017
 * Description: This is the abstract class
 * Version: 0.2 Now with Power class (holpefully) which is prerequisite to the SuperHuman class
 */
    public class Power // Must be a public class!
    {
        // Public Properties 
        /* For the sake of initializing properties in the constructer, the property names
         * should be capitalized.
         */
        public string Name { get; set; }
        public int Rank { get; set; }


        // Public Constructer
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }

        /// this one takes 2 paramaters, unlikee the one in the human class

    }
}
