using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    /// <summary>
    /// The AbstractClass participant which contains the template method.
    /// </summary>
    abstract class Bread
    {
        /// <summary>
        /// this step need to be implement by the concrete class
        /// </summary>
        public abstract void MixIngredients();

        public abstract void Bake();

        /// <summary>
        /// this step is implement by the base class
        /// </summary>
        public virtual void Slice()
        {
            Console.WriteLine("Slicing the " + GetType().Name + " bread!");
        }

        // The template method
        public void Make()
        {
            // step one
            MixIngredients();
            // step two
            Bake();
            // step three
            Slice();
        }
    }

}
