using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonProject_Spring2021
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Variables
    {
        public static int chooseReturn;
        public static Ingredient[] ingredientArr;
        public static Object[] theArr;
        public static string[] theSelected;
        public static int count;
    }
    public static class ControlID
    {
        public static int theTotal { get; set; }
    }
    public class Item
    {
        public double cost;
        public string name;
        public Ingredient[] ingredients;

        public Item(double cost, string name, Ingredient[] ingredients)
        {
            this.cost = cost;
            this.name = name;
            this.ingredients = ingredients;
        }
    }
    public class Drink
    {
        public string name;
        public int cost;
        public int size;

        public Drink(string name, int cost, int size)
        {
            this.name = name;
            this.cost = cost;
            this.size = size;
        }
    }
    public class Ingredient
    {
        public string name;
        public double cost;

        public Ingredient(string name, double cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
    public class Side
    {
        public string name;
        public int cost;

        public Side(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
    public class Combo
    {
        public Item item;
        public Drink drink;
        public Side side;

        public Combo(Item item, Drink drink, Side side)
        {
            this.item = item;
            this.drink = drink;
            this.side = side;
        }
    }
    /*
    public class ingredient
    {
        String[] ingredients = { "" };
        int count = 0;
        static void addIngredient(string i)
        {
            ingredient newingredient = new ingredient();
            ingredients[count] = newingredient;
        }
    }
    */


}
