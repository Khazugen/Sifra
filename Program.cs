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
            s = Console.ReadLine();
            Console.WriteLine(Cesarova.CesarDesifrovani(s, 2));
        }
    }

    public class Cesarova
    {
        

        public static string CesarSifrovani(string text, int posun)
        {
            string abeceda = "abcčdďeěfghijklmnňopqrřsštťuvqzž";
            string capAbeceda = "ABCČDĎEĚFGHIJKLMNŇOPQRŘSŠTŤUVWZŽ";
            StringBuilder s = new StringBuilder(text);
            for (int i = 0; i < text.Length; i++)
            {   
                
                
                if (Char.IsLower(text[i]))
                {   
                    int index = abeceda.IndexOf(text[i]);
                    
                    if (index + posun >= abeceda.Length)
                    { 
                        index = (index + posun) - abeceda.Length;
                        s[i] = abeceda[index];
                    }
                    else
                    {
                        s[i] = abeceda[index + posun];
                    }
                }
                else
                {
                    int index = capAbeceda.IndexOf(text[i]);
                    if (index + posun >= capAbeceda.Length)
                    {
                        index = (index + posun) - capAbeceda.Length;
                        s[i] = capAbeceda[index];
                    }
                    else
                    {
                        s[i] = capAbeceda[index + posun];
                    }
                }
                
            }
            return s.ToString() ;
        }
        public static string CesarDesifrovani(string text, int posun)
        {
            string abeceda = "abcčdďeěfghijklmnňopqrřsštťuvqzž";
            string capAbeceda = "ABCČDĎEĚFGHIJKLMNŇOPQRŘSŠTŤUVWZŽ";
            StringBuilder s = new StringBuilder(text);
            for (int i = 0; i < text.Length; i++)
            {


                if (Char.IsLower(text[i]))
                {
                    int index = abeceda.IndexOf(text[i]);

                    if (index - posun < 0)
                    {
                        index = (index - posun) + abeceda.Length;
                        s[i] = abeceda[index];
                    }
                    else
                    {
                        s[i] = abeceda[index - posun];
                    }
                }
                else
                {
                    int index = capAbeceda.IndexOf(text[i]);
                    if (index - posun < 0)
                    {
                        index = (index - posun) + capAbeceda.Length;
                        s[i] = capAbeceda[index];
                    }
                    else
                    {
                        s[i] = capAbeceda[index - posun];
                    }
                }

            }
            return s.ToString();
        }

    }

}
