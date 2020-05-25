using System;

namespace Menu_Builder.MyClasses
{
    abstract class MenuItem
    {
        public string name { set; get; }
        public string composition { set; get; }
        public int cost { set; get; }
        public MenuItem()
        {
            name = composition = "Empty";
            cost = 0;
        }
    }

    class Dish : MenuItem
    {
        public int calories { set; get; }
        public Dish() : base()
        {
            name = "Dish";
            calories = 0;
        }
    }

    class ColdDish : Dish
    {
        public string prepositions { set; get; }
        public ColdDish() : base()
        {
            name = "ColdDish";
            prepositions = "None";
        }
    }

    class HotDish : Dish
    {
        public string type_of_meet { set; get; }
        public HotDish() : base()
        {
            name = "HotDish";
            type_of_meet = "None";
        }

    }

    class BarItem : MenuItem
    {
        public int capacity { set; get; }
        public BarItem() : base()
        {
            name = "BarItem";
            capacity = 0;
        }
    }

    class AlcoholDrink : BarItem
    {
        int how_spirit { set; get; }
        public AlcoholDrink() : base()
        {
            name = "AlcoholDrink";
            how_spirit = 0;
        }
    }

    class Drink : BarItem
    {
        public bool is_tonic { set; get; }
        public bool is_hot { set; get; }
        public bool is_carbonated { set; get; }
        public Drink() : base()
        {
            name = "Drink";
            is_carbonated = false;
            is_hot = false;
            is_tonic = false;
        }
    }

    abstract class Staff
    {
        public string name { get; set; }
        public int expirience { get; set; }
        public Staff()
        {
            name = "empty";
            expirience = 0;
        }
    }

    class Waiter : Staff
    {
        public int service_level { get; set; }
        public Waiter() : base()
        {
            service_level = 0;
            name = "Waiter";
        }

    }

    class ChieffCook : Staff
    {
        public MenuItem menu_item { get; set; }
        public ChieffCook() : base()
        {
            name = "ChieffCook";
            menu_item = null;
        }
    }

    class Bartender : Staff
    {
        public MenuItem menu_item { get; set; }
        public  Bartender() : base()
        {
            name = "Bartender";
            menu_item = null;
        }
    }
}
