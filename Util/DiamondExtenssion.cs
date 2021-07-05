using DiamondPricePrediction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondPricePrediction.Util
{
    public static class DiamondExtenssion
    {
        public static  int XWeight => 1;
        public static double XAbsolute => 10.74 / 100d;


        public static int YWeight => 1;
        public static double YAbsolute => 58.9 / 100d;

        public static int ZWeight => 1;
        public static double ZAbsolute => 31.8 / 100d;



        public static int CutWeight => 10;
        public static double CutAbsolute => 4 / 100d;


        public static int ColorWeight => 6;
        public static double ColorAbsolute => 6 / 100d;



        public static int CaratWeight => 4;
        public static double CaratAbsolute => (5.01 - 0.2) / 100d;



        public static int ClarityWeight => 8;
        public static double ClarityAbsolute => 7 / 100d;




        public static int DepthWeight => 3;
        public static double DepthAbsolute => (79 - 43) / 100d;



        public static int TableWeight => 3;
        public static double TableAbsolute => (95 - 43) / 100d;



        public static int PriceWeight => 7;
        public static double PriceAbsolute => (18823 - 326) / 100d;


        //public static double TotalWeight => 1 / 37d;


        public static double TotalWeight => 1 / (
            ( XWeight 
             + YWeight
             + ZWeight
             + CutWeight
             + ColorWeight
             + CaratWeight
             + ClarityWeight
             + DepthWeight
             + TableWeight
             //+PriceWeight //  hide price
            ) * 1.0);


        public static double ToPercent(this double d)
        {
            return d / 100d;
        }


        public static (double, Diamond) GetMax(this (double oldmax, Diamond olddiamond) d, double maybemax, Diamond diamond )
        {
            return d.oldmax> maybemax? d : (maybemax , diamond);
        }

    }
}
