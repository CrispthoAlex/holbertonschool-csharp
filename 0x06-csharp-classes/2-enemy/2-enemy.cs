using System;

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
        /// <summary>
        /// Zombie public constructor with int argument and 
        /// raise a exception.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when value parameter is
        /// less than 0.</exception>
        public Zombie(int value)
        {
            if (value >= 0)
            {
                this.health = value;
            }
            else
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
    }
}
