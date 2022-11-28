using System;
using System.Text;

namespace Sifra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(Cesarova.CesarSifrovani(s, 2));    
        }
    }

    public class Cesarova
    {
        

        public static string CesarSifrovani(string text, int posun)
        {
            string abeceda = "abcčdďeěfghijklmnňopqrřďsštťuvqzž";
            string capAbeceda = "ABCČDĎEĚFGHIJKLMNŇOPQRŘSŠTŤUVWZŽ";
            StringBuilder s = new StringBuilder(text);
            for (int i = 0; i < text.Length; i++)
            {   
                int index = abeceda.IndexOf(text[i]);
                if (index + posun > abeceda.Length)
                { 
                    index = (index + posun) - abeceda.Length;
                }
                
                if (Char.IsLower(text[i]))
                {
                    s[i] = abeceda[index+posun];
                }
                else {
                    s[i] = capAbeceda[index + posun];
                }
                
            }
            return s.ToString() ;
        }

    }

}
