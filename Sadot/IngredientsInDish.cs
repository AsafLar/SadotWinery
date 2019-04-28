/*
 * IngredientsInDish class code
 * class of ingredients of dish properties and functions
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    class IngredientsInDish
    {
        private int dishID;
        private int ingredientID;
        private string name;
        private double quantity;

        /// <summary>
        /// Constractor function
        /// </summary>
        public IngredientsInDish(int dID, int iID, int iQ)
        {
            DishID = dID;
            IngredientID = iID;
            Quantity = iQ;
        }

        /// <summary>
        /// Constractor function
        /// </summary>
        public IngredientsInDish()
        {
            dishID = -1;
        }

        /// <summary>
        /// DishID ( get , set )
        /// </summary>
        public int DishID
        {
            get { return dishID; }
            set { dishID = value; }
        }

        /// <summary>
        /// IngredientID ( get , set )
        /// </summary>
        public int IngredientID
        {
            get { return ingredientID; }
            set { ingredientID = value; }
        }

        /// <summary>
        /// Quantity ( get , set )
        /// </summary>
        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        /// <summary>
        /// Name ( get , set )
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
