using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuComponent
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("Pancake House Menu", "Breakfast");
            MenuComponent dinerMenu = new Menu("Diner Menu", "Lunch");
            MenuComponent cafeMenu = new Menu("Cafe Menu", "Dinner");
            MenuComponent dessertMenu = new Menu("Dessert Menu", "Dessert of course!");
            MenuComponent allMenus = new Menu("All Menus", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            #region 添加dinerMenu里的内容，条目
            dinerMenu.Add(new MenuItem("Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99));
            dinerMenu.Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            dinerMenu.Add(new MenuItem("Soup of the day",
                "Soup of the day, with a side of potato salad", false, 2.99));
            dinerMenu.Add(new MenuItem("Hotdog", "A hot dog, withe saurkraut, relish, onions, topped with cheese",
                false, 3.05));
            dinerMenu.Add(dessertMenu);
            #endregion

            #region 添加dessertMenu里的内容，条目
            dessertMenu.Add(new MenuItem("Apple Pie", 
                "Apple pie with a flakey crust, topped with vanilla ice cream",
                true, 1.59));
            dessertMenu.Add(new MenuItem("Cheesecake",
                "Creamy New York chessecake, with a chocolate graham crust",
                true, 1.99));
            dessertMenu.Add(new MenuItem("Sorbet",
                "A scoop of raspberry and a scoop of lime",
                true, 1.89));
            #endregion

            #region 添加pancakeHouseMenu里的内容，条目
            pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries",
                true,
                3.49));
            pancakeHouseMenu.Add(new MenuItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true, 3.59));
            #endregion

            #region 添加cafeMenu里的内容，条目
            cafeMenu.Add(new MenuItem("Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 3.99));
            cafeMenu.Add(new MenuItem("Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false, 3.69));
            cafeMenu.Add(new MenuItem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true, 4.29));
            #endregion

            Waitress waitress = new Waitress(allMenus);
            waitress.PrintMenu();
            Console.ReadKey();
        }
    }
}
