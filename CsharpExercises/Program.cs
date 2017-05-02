using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Exercise1 ex1 = new Exercise1();
            ex1.Run();
            */

            /*Exercise2 ex2 = new Exercise2();
            ex2.Run();
            */

            /*Exercise3 ex3 = new Exercise3();
            ex3.Run();
            */

            /*Exercise4 ex4 = new Exercise4();
            ex4.Run();
            */

            /*Exercise5 ex5 = new Exercise5();
            ex5.Run();
            */

            Exercise6 ex6 = new Exercise6();
            ex6.Run();
            Console.ReadKey();
        }
    }

    class Exercise1
    {
        public void Run()
        {
            String output_text = "";
            for (int j = 1; j < 10; j++)
            {
                for (int i = 9; i > 0; i--)
                {
                    if (i > j)
                    {
                        output_text += '0';
                    }
                    else
                    {
                        output_text += j;
                    }

                }
                Console.WriteLine(output_text);
                output_text = "";
            }

        }
    }

    class Exercise2
    {
        
        public void Run()
        {
            /* Δημιουργώ έναν μονοδιάστατο πίνακα που κρατάει την αξία των χαρτονομισμάτων/νομισμάτων
             * η πρώτη θέση κρατάει τα 50ευρα, η 2η τα 20ευρα... και η τελευταία την ποσότητα των νομισμάτων του ευρώ
             * 50ευρώ=>1η θέση, 20ευρώ=>2η θέση, 10ευρώ=>3η θέση, 5ευρώ=>4η θέση, 2ευρώ=>5η θέση, 1ευρώ=> 6η θέση
             */
            int[] bill_coins = new int[] { 50, 20, 10, 5, 2, 1 };
            String user_input;
            int total_sum = 0, amount;

            //Ζητάμε από τον χρήστη την ποσότητα χαρτονομισμάτων/νομισμάτων που διαθέτει
            for (int i = 0; i < bill_coins.Length; i++)
            {
                if (i < 4)
                {
                    Console.WriteLine($"Enter number of {bill_coins[i]} euro banknotes:");                    
                }
                else {
                    Console.WriteLine($"Enter number of {bill_coins[i]} euro coins:");
                }
                user_input = Console.ReadLine();
                amount = Int32.Parse(user_input);
                total_sum += amount * bill_coins[i];
            }
            Console.WriteLine($"You have {total_sum} euros.");
        }
    }

    class Exercise3
    {
        public void Run()
        {
            int a, b, c;
            double delta,  x1, x2;

            Console.WriteLine("Enter number a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number c: ");
            c = Int32.Parse(Console.ReadLine());
            //ypologise Δ
            delta = Math.Pow(b, 2) - 4 * a * c;
            //έλεγξε αν υπάρχουν πραγματικές λύσεις
            if ((delta) < 0)
            {
                Console.WriteLine("There aren't any real solutions");
            } 
            else if (delta == 0)
            {
                //ypologise x
                x1 = -b / (2 * a);
                Console.WriteLine($"The root of the equation is: {x1}");
            }
            else
            {
                //ypologise x1, x2
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"The roors of the equation are: {x1}, {x2}");
            }
        }
    }

    class Exercise4
    {
        public void Run()
        {
            double harmonic_sequence = 0;
            for (int i = 1; i <= 5; i++)
            {
                harmonic_sequence += (1 / (double) i);
                Console.WriteLine(harmonic_sequence);
            }
        }
    }

    class Exercise5
    {
        public void Run()
        {
            int pronicnumbers_num, pronicnumbers_output;
            String pronicnumbers_outputstring = "";
            //Ζητάμε από τον χρήστη τον αριθμό των pronic numbers
            Console.WriteLine("Enter number of pronic numbers: ");
            pronicnumbers_num = Int32.Parse(Console.ReadLine());

            //Με ένα βρόγχο if υπολογίζω τους pronic numbers
            for (int i = 1; i <= pronicnumbers_num; i++) 
            {
                pronicnumbers_output = i * (i + 1);
                pronicnumbers_outputstring += pronicnumbers_output + " ";
            }

            Console.WriteLine(pronicnumbers_outputstring);
        }
    }

    class Exercise6
    {
        public void Run()
        {
            String user_input;
            //Ζητάμε από τον χρήστη να εισάγει το ΑΦΜ προς έλεγχο
            Console.WriteLine("Enter Tax Identification Number: ");            
            user_input = Console.ReadLine();
            
            //remove the check digit from the array
            int check_digit = Int32.Parse(user_input.Substring(user_input.Length - 1, 1));
            user_input = user_input.Substring(0, user_input.Length - 1);

            //Μετατροπή του string που παίρνουμε ως δεδομένα εισόδου σε ένα μονοδιάστατο πίνακα τύπου char
            char[] afm = user_input.ToCharArray();
            int sum = 0;
            Array.Reverse(afm);
            Console.WriteLine(afm);
            int digit;
            for (int i = 0; i < afm.Length; i++)
            {
                digit = (int)Char.GetNumericValue(afm[i]);
                sum +=  digit * (int)(Math.Pow(2, i + 1));
            }

            if (((sum % 11) % 10 ) == check_digit) 
            {
                Console.WriteLine("Tax Identification Number valid.");
            } else
            {
                Console.WriteLine("Tax Identification Number not valid.");
            }
        }
    }

    class Exercise7
    {
        public void Run()
        {

        }
    }


}
