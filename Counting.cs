using System;
using System.Collections.Generic;
using System.Text;

namespace KvadrFunkce
{
    public class Counting
    {
        public static double Discriminant(double a, double b, double c)
        {
            return b * b - 4.0 * a * c;
        }
        public static double AnswerDbigernullX1(double D, double a ,double b)
        {            
            D = Math.Sqrt(D) / (2 * a); 
            b = -b / (2 * a);
            return Math.Round(b + D,3);
        }
        public static double AnswerDbigernullX2(double D, double a, double b)
        {
            D = Math.Sqrt(D) / (2 * a);
            b = -b / (2 * a);
            return Math.Round(b - D, 3);
        }
        public static string AnswerDSmallernullResoltX1(double D, double a, double b)
        {
            D = Math.Abs(D);
            D = Math.Round(Math.Sqrt(D)/ (2 * a),3);
            b = Math.Round(-b / (2 * a),3);      
            return  $"{b} + {D}i" ;
        }
        public static string AnswerDSmallernullResoltX2(double D, double a, double b)
        {
            D = Math.Abs(D);
            D = Math.Round(Math.Sqrt(D) / (2 * a), 3);
            b = Math.Round(-b / (2 * a),3);
            return $"{b} - {D}i";
        }
    }
}
