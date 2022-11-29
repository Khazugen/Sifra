using System;
using System.Text;

namespace Sifra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(Vigenerova.Sifrovani(a,b));
            string c = Console.ReadLine();
            Console.WriteLine(Vigenerova.Desifrovani(c,b));
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
    
    public class Vigenerova
    {
        public static string Sifrovani(string a, string b)
        {
            StringBuilder s = new StringBuilder(a);
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < (a.Length/b.Length)+1; i++)
            {
                sb.Append(b);
            }

            for (int i = 0; i < a.Length; i++)
            { 
                int hodnotaA = (int)a[i];
                int hodnotaB = (int)sb[i];
               
                if(hodnotaB+hodnotaA > 126) 
                {
                    int index = (hodnotaA + hodnotaB) - 126;
                    s[i] = (char)index;
                }
                else
                {
                    int index = hodnotaA + hodnotaB;
                    s[i] = (char)index;
                }
            }
            
            return s.ToString();
        }
        public static string Desifrovani(string a, string b)
        {
            StringBuilder s = new StringBuilder(a);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < (a.Length / b.Length) + 1; i++)
            {
                sb.Append(b);
            }

            for (int i = 0; i < a.Length; i++)
            {
                int hodnotaA = (int)a[i];
                int hodnotaB = (int)sb[i];
                

                if (hodnotaB - hodnotaA < 0 )
                {
                    int index = (hodnotaA - hodnotaB) + 126;
                    s[i] = (char)index;
                }
                else
                {
                    int index = hodnotaA - hodnotaB;
                    s[i] = (char)index;
                }
            }

            return s.ToString();
        }
    }

}
