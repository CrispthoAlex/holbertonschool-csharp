﻿using System;

namespace Enemies
{
    /// <summary>
    /// Zombie class that define a zombie by:
    ///  * public field health
    ///  * health should be an int and have no value
    ///  * public constructor: public Zombie()
    ///      * sets the value of health to 0
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// public field, int and have no value.
        /// </summary>
        public int health;
        /// <summary>
        /// Zombie public constructor to set the value of 
        /// health field.
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }
    }
}
