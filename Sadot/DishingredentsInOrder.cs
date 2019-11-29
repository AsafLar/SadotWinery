/*
 * DishingredientsInOrder form code
 * class with the code of the form of dish ingredents to remove when the user add dish to order
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadot
{
    public partial class DishingredentsInOrder : Form
    {
        private DBSQL db = new DBSQL(); 
        private Ingredients[] ingredients;
        private int dishID;
        private string dishName;
        public string ingredentsToRemove;


        /// <summary>
        /// form Constructor
        /// </summary>
        /// <param name="dishId">the dish id to remove ingredients from</param>
        /// <param name="_dishName">the dish name to remove ingredients from<</param>
        public DishingredentsInOrder(int dishId , string _dishName)
        {
            InitializeComponent();
            dishID = dishId;
            dishName = _dishName;
        }

        /// <summary>
        /// method wich works when the DishingredientsInOrder form loads
        /// the method will fill the dish name header with the spcific dish name
        /// and fill the list of the spcific dish ingredients
        /// </summary>
        private void Dishingredents_Load(object sender, EventArgs e)
        {
            lblDishName.Text = dishName;
            ingredients = db.GetDishIngredientsByID2(dishID);
            for (int i = 0; i < ingredients.Length; i++)
            {
                clbIngredientsOfDish.Items.Add(" בלי " + ingredients[i].Name);
                clbIngredientsOfDish2.Items.Add(ingredients[i].Name + " בצד ");

                //clbIngredientsOfDish.Items.Add(ing0redients[i].Name);
            }


        }

        /// <summary>
        /// method wich works when the user press on the "OK" button
        /// the method check wich ingredient chose to remove and fill the string with it names
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < clbIngredientsOfDish.Items.Count; i++)
            {
                if (clbIngredientsOfDish.GetItemCheckState(i) == CheckState.Checked)
                {
                    ingredentsToRemove += "-" + clbIngredientsOfDish.Items[i].ToString();
                }
                if (clbIngredientsOfDish2.GetItemCheckState(i) == CheckState.Checked)
                {
                    ingredentsToRemove += "-" + clbIngredientsOfDish2.Items[i].ToString();
                }
            }
        }
        
    }
}
