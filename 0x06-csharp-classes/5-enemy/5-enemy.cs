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
        /// private field int type and have no value.
        /// </summary>
        private int health;
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
        /// <summary>
        /// "name" private field string type and have default value.
        /// </summary>
        private string name = "(No name)";
        /// <summary>
        /// public property Name
        ///     * get: retrieve name
        ///     * set: set name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        /// <summary>
        /// GetHealth public method that returns the value of health
        /// of the Zombie object.
        /// </summary>
        public int GetHealth() => this.health;
        /// <summary>
        /// .toString public override that prints the Zombie object’s 
        /// attributes to stdout.
        /// </summary>
        public override string ToString()
        {
            return $"Zombie Name: {this.name} / Total Health: {this.health}";
        }
    }
}
