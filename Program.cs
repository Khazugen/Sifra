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

        }
    }

    public class Cesarova
    {


        public static string CesarSifrovani(string text, int posun)
        {
            string abeceda = "abcčdďeěfghijklmnňopqrřsštťuvqzž";
            StringBuilder s = new StringBuilder(text);
            for (int i = 0; i < text.Length; i++)
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
            return s.ToString();
        }
        public static string CesarDesifrovani(string text, int posun)
        {
            string abeceda = "abcčdďeěfghijklmnňopqrřsštťuvqzž";
            StringBuilder s = new StringBuilder(text);
            for (int i = 0; i < text.Length; i++)
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
            return s.ToString();
        }
    }

        public class Vigenerova
        {
            public static string Sifrovani(string a, string b)
            {
                string abeceda = " abcčdďefghijklmnňopqrřsštťuvwxyzž";
                StringBuilder s = new StringBuilder(a);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < (a.Length / b.Length) + 1; i++)
                {
                    sb.Append(b);
                }

                for (int i = 0; i < a.Length; i++)
                {
                    int hodnotaA = abeceda.IndexOf(s[i]);
                    int hodnotaB = abeceda.IndexOf(sb[i]);

                    if (hodnotaB + hodnotaA > abeceda.Length)
                    {
                        double m = (hodnotaA + hodnotaB) / abeceda.Length;
                        int v = (int)Math.Floor(m);
                        int index = (hodnotaA + hodnotaB) - (abeceda.Length * v);
                        s[i] = abeceda[index];
                    }
                    else
                    {
                        int index = hodnotaA + hodnotaB;
                        s[i] = abeceda[index];
                    }
                }

                return s.ToString();
            }
            public static string Desifrovani(string a, string b)
            {
                string abeceda = "abcčdďefghijklmnňopqrřsštťuvwxyzž";
                StringBuilder s = new StringBuilder(a);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < (a.Length / b.Length) + 1; i++)
                {
                    sb.Append(b);
                }

                for (int i = 0; i < a.Length; i++)
                {
                    int hodnotaA = abeceda.IndexOf(s[i]);
                    int hodnotaB = abeceda.IndexOf(sb[i]);

                    if (hodnotaB - hodnotaA < 0)
                    {
                        int v = a.Length / b.Length;
                        int index = (hodnotaA - hodnotaB) + (abeceda.Length * v);
                        s[i] = abeceda[index];
                    }
                    else
                    {
                        int index = hodnotaA - hodnotaB;
                        s[i] = abeceda[index];
                    }
                }

                return s.ToString();
            }
        }

    }
