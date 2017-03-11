using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入一隻Pokemon!!!");
            Console.Write("請輸入Pokemon Name:");
            string name = Console.ReadLine();
            Console.Write("請輸入Pokemon NationalNo:");
            string nationalno = Console.ReadLine();

            float height = 0;
            float weight = 0;
            Console.Write("請輸入Pokemon Height:");
            try
            {
                height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Height輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入Pokemon Weight:");
            try
            {
                weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Weight輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入Pokemon Gender:");
            string gender = Console.ReadLine();
            Console.Write("請輸入Pokemon Abilities:");
            string abilities = Console.ReadLine();
            Console.Write("請輸入Pokemon Category:");
            string category = Console.ReadLine();

            Console.WriteLine("Pokemon 基本資料");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("National No:{0}", nationalno);
            Console.WriteLine("身高: {0}", height);
            Console.WriteLine("體重: {0}", weight);
            Console.WriteLine("性別: {0}", gender);
            Console.WriteLine("能力: {0}", abilities);
            Console.WriteLine("屬性: {0}", category);
        }
    }
}