using System;
using System.Collections;
using System.Text;

namespace tekrar_eden_string
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str = "abababab"; 

            check(str);
            

            
        }
        
        static bool check(string s)
        {
            bool againCheck = true;
            string againString = "";
            ArrayList çarpanlar = new ArrayList();
            int number = s.Length;
            

            // Çarpanları bulma işlemi //


            for (int i = number-1; i > 0; i--)
            {
                if (number % i == 0)
                {
                    çarpanlar.Add(i);
                    number /= i;
                }
            }
            


            // Lenght asal sayı ise tüm harfler eşit olmalıdır //

            if (isLenghtPrime(s) == true)
            {
                for (int i = 0; i < number; i++)
                {
                    for (int j = i+1; j < number; j++)
                    {
                        if (s[i] != s[j])
                        {
                            againCheck = false;
                            break;
                        }
                        else
                        {
                            againCheck = true;
                            againString = s[i].ToString();
                        }
                    }

                }
                
            }

            // Çarpanlarına Göre Kontrol Etme //

            else
            {
                

                for (int i = çarpanlar.Count-1; i >= 0; i--)
                {
                    int çarpans = (int)çarpanlar[i];
                    
                    
                    for (int j = 0; j <= number/çarpans; j++)
                    {

                        string referance1 = s.Substring(j, çarpans);
                       string referance2 = s.Substring(çarpans, çarpans );
                        

                        if (referance1 != referance2)
                        {
                            againCheck = false;
                            againString = "";
                            break;

                        }
                        else
                        {
                            againCheck = true;
                            againString = referance1;
                            
                        }

                    }
                    if (againCheck)
                    {
                        break;
                    }
                    

                    


                }





            }
            if (againCheck== true)
            {
                Console.WriteLine("tekrar ediyor : "+ againString);
            }
            else
            {
                Console.WriteLine("tekrar etmez");
            }

            

            return (againCheck == true ? true : false);






           
        }



        static bool isLenghtPrime(string s)
        {
            bool isPrime = false;
            for (int i = 2; i < s.Length; i++)
            {
                if (s.Length % i == 0)
                {
                    isPrime = false;
                    break;

                }
                else
                {
                    isPrime = true;
                }
                
            }
            return isPrime;
        }

        


    }
}
