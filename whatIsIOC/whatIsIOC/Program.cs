using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Translation;
using Google.Cloud.Translation.V2;

namespace whatIsIOC
{
    class Program
    {
        static void Main(string[] args)
        {
            //what is Dependency Inversion Principle Explained Practically in C#
            // Dependence Inversion Principle
            //依赖倒置原则


            //Interface Segregation Principle。
            //接口隔离原则

            //Single Responsibility Principle
            //单一职责原则

            //Open Closed Principle
            //开闭原则
            //var client = TranslationClient.Create();
            //var text = "MM년dd월";

            //Console.WriteLine(client.TranslateText(text,LanguageCodes.Serbian));

            Console.WriteLine(DateTime.Now.ToString("MM/dd"));

            //string text = "我喜欢跑步。";
            //string translated = Translator.Translate(text, Language.Chinese_Simplified, Language.English);
            //Console.WriteLine(translated);
            string[] a = new string[] { "管理员1", "112", "2121", "管理员", "管理员" };
            string juese = "管理员";
            var b = a.Contains<string>(juese);
            //if (b)
            //{
            //    Console.WriteLine("1");
            //}


        }

        private static bool IsRightRole(string[] rolename)
        {
            string juese = "管理员";
            if (rolename.Select(x => x == juese).FirstOrDefault())
            {
                return true;   
            }
            return false;
        }
    }
}
