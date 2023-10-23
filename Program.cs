using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///regex
            /// .+ istalgan belgi
            /// /d istalgan beldi
            /// /w isalgan harf
            /// * -belgi bulsa ham bulmasa ham
            /// 
            string text = "+99893718432760";
            string qolip = @"^[+]{1}[9]{2}[8]{1}[90-99]+[0-9]{3}[0-9]{2}[0-9]{2}$";// qolip ketma ket ishlaydi 
            //birinchi tuzilgan qolib keyin 2 keyin 3 
            Console.WriteLine(Regex.IsMatch(text,qolip) && text.Length==13);
        }
    }
}