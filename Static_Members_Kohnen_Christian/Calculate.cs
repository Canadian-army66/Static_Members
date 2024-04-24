using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members_Kohnen_Christian
{
    static class Calculate
    {
        public static float result = 0.0f;
        static Calculate()
        {
            result = 0.0f;
        }

        //intigers

        public static int Add(int x, int y) //adding two methods
        {
            return x + y;
        }
        public static int Sub(int x, int y) //subtracting teo methods
        {
            return x - y;
        }
        public static int Mult(int x, int y) //multiplies two methods
        {
            return x * y;
        }
        public static int Div(int x, int y) //divides two methods
        {
            return x / y;
        }

        //floating

        public static float Add(float x, float y) //adding two methods
        {
            return x + y;
        }
        public static float Sub(float x, float y) //subtracting teo methods
        {
            return x - y;
        }
        public static float Mult(float x, float y) //multiplies two methods
        {
            return x * y;
        }
        public static float Div(float x, float y) //divides two methods
        {
            return x / y;
        }
    }
}
