using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week09
{
    /*
 * Name: Matthew Watada
 * July 11th 2017
 * Description: This is the abstract class
 * Version: 0.3 Now that I have the "Power" class that I was missing, I can work on this class
     * (finally)
 */
    public class SuperHuman : Human
    {
        // Private Fields
        private List<Power> _powers;

        // Public Properties
        public List<Power> Powers
        {
            get 
            {
                return this._powers;
            }
        }

            /// <summary>
            /// Cannot continue, missin the "power" datatype
            /// </summary>
            /// <param name="name"></param>

        // Constructors
        public SuperHuman(string name)
            :base(name)
        {

        }

        // Private Mthods
        private void _initalize()
        {
            
        }

        // Public Methods
    }
}