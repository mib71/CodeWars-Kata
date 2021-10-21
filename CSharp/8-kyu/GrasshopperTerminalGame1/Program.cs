using System;
using System.Reflection;

namespace GrasshopperTerminalGame1
{
    #region Details
    /*
    8 kyu Grasshopper - Terminal Game #1
     
    Terminal Game - Create Hero Class
    attribute	type	value
    Name	    string	user argument or "Hero"
    Position	string	"00"
    Health	    float	100
    Damage	    float	5
    Experience	int	    0

    https://www.codewars.com/kata/55e8aba23d399a59500000ce/csharp
     */
    #endregion
    #region Main
    class Program
    {
        static void Main(string[] args)
        {
            var hero = new Hero { };

            foreach (PropertyInfo property in hero.GetType().GetProperties())
            {
                Console.WriteLine($"{ property.Name }  { property.GetValue(hero) }");
            }                        
        }
    }
    #endregion

    #region Kata
    public class Hero
    {
        public Hero(string name = "Hero", string position = "00", float health = 100, float damage = 5, int experience = 0)
        {
            Name = name;
            Position = position;
            Health = health;
            Damage = damage;
            Experience = experience;
        }

        public string Name { get; set; }
        public string Position { get; set; }
        public float Health { get; set; }
        public float Damage { get; set; }
        public int Experience { get; set; }
    }
    #endregion
}
