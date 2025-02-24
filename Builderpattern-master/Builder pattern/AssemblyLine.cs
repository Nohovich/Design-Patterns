﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    /// <summary>
    /// The Director
    /// </summary>
    class AssemblyLine
    {
        /// <summary>
        /// passing a concrete builder that implemented all the method below
        /// </summary>
        /// <param name="sandwichBuilder"></param>
        public void Assemble(SandwichBuilder sandwichBuilder)
        {
            // Builder uses a complex series of steps
            sandwichBuilder.AddBread();
            sandwichBuilder.AddMeats();
            sandwichBuilder.AddCheese();
            sandwichBuilder.AddVeggies();
            sandwichBuilder.AddCondiments();
        }
    }

    /// <summary>
    /// The Builder abstract class
    /// </summary>
    abstract class SandwichBuilder
    {
        // The Product
        protected Sandwich sandwich;

        // Gets sandwich instance
        public Sandwich Sandwich
        {
            get { return sandwich; }
        }

        // Abstract build methods
        public abstract void AddBread();
        public abstract void AddMeats();
        public abstract void AddCheese();
        public abstract void AddVeggies();
        public abstract void AddCondiments();
    }

    /// <summary>
    /// A Concrete Builder class
    /// </summary>
    class TurkeyClub : SandwichBuilder
    {
        /// <summary>
        /// implementing the filed of the abstract class of Sandwich
        /// </summary>
        public TurkeyClub()
        {
            // creating a new Sandwich and passing it the name of the class as the Sandwich type
            sandwich = new Sandwich("Turkey Club");
        }

        /// <summary>
        /// implementing the abstract method
        /// </summary>
        public override void AddBread()
        {
            // adding to this sandwich dictionary _ingredients a key and a value
            sandwich["bread"] = "12-Grain";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Turkey";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "Swiss";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "Lettuce, Tomato";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo";
        }
    }


    /// <summary>
    /// A Concrete Builder class
    /// </summary>
    class BLT : SandwichBuilder
    {
        public BLT()
        {
            sandwich = new Sandwich("BLT");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "Wheat";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Bacon";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "None";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "Lettuce, Tomato";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo, Mustard";
        }
    }

    /// <summary>
    /// A Concrete Builder class
    /// </summary>
    class HamAndCheese : SandwichBuilder
    {
        public HamAndCheese()
        {
            sandwich = new Sandwich("Ham and Cheese");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "White";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Ham";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "American";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "None";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo";
        }
    }

    /// <summary>
    /// The Product class
    /// </summary>
    class Sandwich
    {
        // the name of our concert builder
        private string _sandwichType;
        // a dictionary for keep track on the ingredients the key is the type of the ingredient and the value is the actual ingredient
        private Dictionary<string, string> _ingredients = new Dictionary<string, string>();

        // Constructor
        public Sandwich(string sandwichType)
        {
            this._sandwichType = sandwichType;
        }

        // Indexer
        public string this[string key]
        {
            get { return _ingredients[key]; }
            set { _ingredients[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Sandwich: {0}", _sandwichType);
            Console.WriteLine(" Bread: {0}", _ingredients["bread"]);
            Console.WriteLine(" Meat: {0}", _ingredients["meat"]);
            Console.WriteLine(" Cheese: {0}", _ingredients["cheese"]);
            Console.WriteLine(" Veggies: {0}", _ingredients["veggies"]);
            Console.WriteLine(" Condiments: {0}", _ingredients["condiments"]);
        }
    }
}