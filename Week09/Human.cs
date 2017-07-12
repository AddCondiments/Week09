using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Matthew Watada
 * July 11th 2017
 * Description: This is the abstract class
 * Version: 0.1 Initial Commit
 */

namespace Week09
{
    public abstract class Human
    {
        // Private Fields
        private string _name;

        // Public Properties --------------------------------------
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        //Constructors

        /// <summary>
        /// Okay, IDK why it let me put a summary in here but not int the other class.
        /// Requires only one parameter...
        /// </summary>
        /// <param name="name"></param>

        public Human(string name)
        {
            this.Name = name;
        }
    }
}