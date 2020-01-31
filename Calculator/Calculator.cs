using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        // Adds two integers and returns the result
        /// <summary>
        /// Adds two integers <paramref name="a"/> and <paramref name="b"/> and returns the result.
        /// </summary>
        /// <returns>
        /// The sum of two integers.
        /// </returns>
        /// <exception cref="System.OverflowException">Thrown when one parameter is max 
        /// and the other is greater than 0.</exception
        /// <param name="a">An integer.</param>
        /// <param name="b">An integer.</param>
        public static int Add(int a, int b)
        {
            try
            {
                if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                    throw new System.OverflowException();//Throwing System Exception
                if ((a < 0) || (b < 0))
                {
                    throw new NegitiveNumberException();//Throwing Application Exception
                }
                
            }
            //System Exception
            catch(System.OverflowException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            //Application Exception
            catch(NegitiveNumberException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return a + b;

        }
        // Adds two doubles and returns the result
        /// <summary>
        /// Adds two doubles <paramref name="a"/> and <paramref name="b"/> and returns the result.
        /// </summary>
        /// <returns>
        /// The sum of two doubles.
        /// </returns>
        /// <exception cref="System.OverflowException">Thrown when one parameter is max 
        /// and the other is greater than 0.</exception>
        /// <param name="a">A double precision number.</param>
        /// <param name="b">A double precision number.</param>
        public static double Add(double a, double b)
        {
            // If any parameter is equal to the max value of an integer
            // and the other is greater than zero
            try
            {
                if ((a == double.MaxValue && b > 0) || (b == double.MaxValue && a > 0))
                    throw new System.OverflowException();
                if ((a < 0) || (b < 0))
                {
                    throw new NegitiveNumberException();
                }
            }
            //System Exception
            catch (System.OverflowException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            //Application Exception
            catch (NegitiveNumberException ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return a + b;
        }
        // Subtracts an integer from another and returns the result
        /// <summary>
        /// Subtracts <paramref name="b"/> from <paramref name="a"/> and returns the result.
        /// </summary>
        /// <returns>
        /// The difference between two integers.
        /// </returns>
        /// <param name="a">An integer.</param>
        /// <param name="b">An integer.</param>
        public static int Subtract(int a, int b)
        {
            try
            {
                if ((a < 0) || (b < 0))
                {
                    throw new NegitiveNumberException();
                }
            }
            //Application Exception
            catch (NegitiveNumberException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return a - b;
        }
        // Subtracts a double from another and returns the result
        /// <summary>
        /// Subtracts a double <paramref name="b"/> from another double <paramref name="a"/> and returns the result.
        /// </summary>
        /// <returns>
        /// The difference between two doubles.
        /// </returns>
        /// <param name="a">A double precision number.</param>
        /// <param name="b">A double precision number.</param>
        public static double Subtract(double a, double b)
        {
            try
            {
                if ((a < 0) || (b < 0))
                {
                    throw new NegitiveNumberException();
                }
            }
            //Application Exception
            catch (NegitiveNumberException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return a - b;
        }
        // Multiplies two integers and returns the result
        /// <summary>
        /// Multiplies two integers <paramref name="a"/> and <paramref name="b"/> and returns the result.
        /// </summary>
        /// <returns>
        /// The product of two integers.
        /// </returns>
        /// <param name="a">An integer.</param>
        /// <param name="b">An integer.</param>
        public static int Multiply(int a, int b)
        {
            try
            {
                if ((a < 0) || (b < 0))
                {
                    throw new NegitiveNumberException();
                }
            }
            //Application Exception
            catch (NegitiveNumberException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return a*b;
        }
        // Multiplies two doubles and returns the result
        /// <summary>
        /// Multiplies two doubles <paramref name="a"/> and <paramref name="b"/> and returns the result.
        /// </summary>
        /// <returns>
        /// The product of two doubles.
        /// </returns>
        /// <param name="a">A double precision number.</param>
        /// <param name="b">A double precision number.</param>
        public static double Multiply(double a, double b)
        {
            try
            {
                if ((a < 0) || (b < 0))
                {
                    throw new NegitiveNumberException();
                }
            }
            //Application Exception
            catch (NegitiveNumberException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return a * b;
        }
        // Divides an integer by another and returns the result
        /// <summary>
        /// Divides an integer <paramref name="a"/> by another integer <paramref name="b"/> and returns the result.
        /// </summary>
        /// <returns>
        /// The quotient of two integers.
        /// </returns>
        /// <exception cref="System.DivideByZeroException">Thrown when <paramref name="b"/> is equal to 0.</exception>
        /// <param name="a">An integer dividend.</param>
        /// <param name="b">An integer divisor.</param>
        public static int Divide(int a, int b)
        {
            
            try 
            {
                if ((a < 0) || (b < 0))
                {
                    throw new NegitiveNumberException();
                }
                return a / b;

            }
            //System Exception
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            //Application Exception
            catch (NegitiveNumberException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        // Divides a double by another and returns the result
        /// <summary>
        /// Divides a double <paramref name="a"/> by another double <paramref name="b"/> and returns the result.
        /// </summary>
        /// <returns>
        /// The quotient of two doubles.
        /// </returns>
        /// <exception cref="System.DivideByZeroException">Thrown when <paramref name="b"/> is equal to 0.</exception>
        /// <param name="a">A double precision dividend.</param>
        /// <param name="b">A double precision divisor.</param>
        public static double Divide(double a, double b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                if ((a < 0) || (b < 0))
                {
                    throw new NegitiveNumberException();
                }
                return a / b;
            }
            //System Exception
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            //Application Exception
            catch (NegitiveNumberException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        public static void Main(String[] args)
        {

            Console.WriteLine("Enter two numbers");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("Choose an option from above Menu");
            int choice = Convert.ToInt32(Console.ReadLine());
            try
            {

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Sum of " + a + " and " + b + " is " + Calculator.Add(a, b));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Subtraction of " + a + " and " + b + " is " + Calculator.Subtract(a, b));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Multiplication of " + a + " and " + b + " is " + Calculator.Multiply(a, b));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Division of " + a + " and " + b + " is " + Calculator.Divide(a, b));
                            break;
                        }

                }
            }
            catch (NegitiveNumberException ex)
            {
                Console.WriteLine(ex);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
