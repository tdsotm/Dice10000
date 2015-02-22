using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice10000
{
    class ComparableValues
    {


        public static List<int> UNU { get; set; }

        public static List<int> CINCI { get; set; }
        public static List<int> TREI_1 { get; set; }
        public static List<int> PATRU_1 { get; set; }
        public static List<int> CINCI_1 { get; set; }
        public static List<int> SASE_1 { get; set; }
        public static List<int> TREI_2 { get; set; }
        public static List<int> PATRU_2 { get; set; }
        public static List<int> CINCI_2 { get; set; }
        public static List<int> SASE_2 { get; set; }
        public static List<int> TREI_3 { get; set; }
        public static List<int> PATRU_3 { get; set; }
        public static List<int> CINCI_3 { get; set; }
        public static List<int> SASE_3 { get; set; }
        public static List<int> TREI_4 { get; set; }
        public static List<int> PATRU_4 { get; set; }
        public static List<int> CINCI_4 { get; set; }
        public static List<int> SASE_4 { get; set; }
        public static List<int> TREI_5 { get; set; }
        public static List<int> PATRU_5 { get; set; }
        public static List<int> CINCI_5 { get; set; }
        public static List<int> SASE_5 { get; set; }
        public static List<int> TREI_6 { get; set; }
        public static List<int> PATRU_6 { get; set; }
        public static List<int> CINCI_6 { get; set; }
        public static List<int> SASE_6 { get; set; }
        public static List<int> BACCARAT { get; set; }
        public static List<List<int>> listaValoriComparabile { get; set; }
        public static Dictionary<String, int> punctaj { get; set; }


        public static void comparableValues()
        {
            CINCI = new List<int>();
            TREI_1 = new List<int>();
            PATRU_1 = new List<int>();
            CINCI_1 = new List<int>();
            SASE_1 = new List<int>();
            TREI_2 = new List<int>();
            PATRU_2 = new List<int>();
            CINCI_2 = new List<int>();
            SASE_2 = new List<int>();
            TREI_3 = new List<int>();
            PATRU_3 = new List<int>();
            CINCI_3 = new List<int>();
            SASE_3 = new List<int>();
            TREI_4 = new List<int>();
            PATRU_4 = new List<int>();
            CINCI_4 = new List<int>();
            SASE_4 = new List<int>();
            TREI_5 = new List<int>();
            PATRU_5 = new List<int>();
            CINCI_5 = new List<int>();
            SASE_5 = new List<int>();
            TREI_6 = new List<int>();
            PATRU_6 = new List<int>();
            CINCI_6 = new List<int>();
            SASE_6 = new List<int>();
            BACCARAT = new List<int>();
            listaValoriComparabile = new List<List<int>>();
            punctaj = new Dictionary<string, int>();

            punctaj.Add("unu", 100);
            punctaj.Add("cinci", 50);
            punctaj.Add("3deunu", 1000);
            punctaj.Add("4deunu", 2000);
            punctaj.Add("5deunu", 4000);
            punctaj.Add("6deunu", 8000);
            punctaj.Add("3dedoi", 200);
            punctaj.Add("4dedoi", 400);
            punctaj.Add("5dedoi", 800);
            punctaj.Add("6dedoi", 1600);
            punctaj.Add("3detrei", 300);
            punctaj.Add("4detrei", 600);
            punctaj.Add("5detrei", 1200);
            punctaj.Add("6detrei", 2400);
            punctaj.Add("3depatru", 400);
            punctaj.Add("4depatru", 800);
            punctaj.Add("5depatru", 1600);
            punctaj.Add("6depatru", 3200);
            punctaj.Add("3decinci", 500);
            punctaj.Add("4decinci", 1000);
            punctaj.Add("5decinci", 2000);
            punctaj.Add("6decinci", 4000);
            punctaj.Add("3desase", 600);
            punctaj.Add("4desase", 1200);
            punctaj.Add("5desase", 2400);
            punctaj.Add("6desase", 4800);
            punctaj.Add("bacarrat", 2500);

            BACCARAT.Add(1);
            BACCARAT.Add(2);
            BACCARAT.Add(3);
            BACCARAT.Add(4);
            BACCARAT.Add(5);
            BACCARAT.Add(6);


            UNU.Add(1);
            CINCI.Add(5);
            TREI_1.Add(1);
            TREI_1.Add(1);
            TREI_1.Add(1);
            PATRU_1.Add(1);
            PATRU_1.Add(1);
            PATRU_1.Add(1);
            PATRU_1.Add(1);
            CINCI_1.Add(1);
            CINCI_1.Add(1);
            CINCI_1.Add(1);
            CINCI_1.Add(1);
            CINCI_1.Add(1);
            SASE_1.Add(1);
            SASE_1.Add(1);
            SASE_1.Add(1);
            SASE_1.Add(1);
            SASE_1.Add(1);
            SASE_1.Add(1);

            TREI_2.Add(2);
            TREI_2.Add(2);
            TREI_2.Add(2);
            PATRU_2.Add(2);
            PATRU_2.Add(2);
            PATRU_2.Add(2);
            PATRU_2.Add(2);
            CINCI_2.Add(2);
            CINCI_2.Add(2);
            CINCI_2.Add(2);
            CINCI_2.Add(2);
            CINCI_2.Add(2);
            SASE_2.Add(2);
            SASE_2.Add(2);
            SASE_2.Add(2);
            SASE_2.Add(2);
            SASE_2.Add(2);
            SASE_2.Add(2);

            TREI_3.Add(3);
            TREI_3.Add(3);
            TREI_3.Add(3);
            PATRU_3.Add(3);
            PATRU_3.Add(3);
            PATRU_3.Add(3);
            PATRU_3.Add(3);
            CINCI_3.Add(3);
            CINCI_3.Add(3);
            CINCI_3.Add(3);
            CINCI_3.Add(3);
            CINCI_3.Add(3);
            SASE_3.Add(3);
            SASE_3.Add(3);
            SASE_3.Add(3);
            SASE_3.Add(3);
            SASE_3.Add(3);
            SASE_3.Add(3);

            TREI_4.Add(4);
            TREI_4.Add(4);
            TREI_4.Add(4);
            PATRU_4.Add(4);
            PATRU_4.Add(4);
            PATRU_4.Add(4);
            PATRU_4.Add(4);
            CINCI_4.Add(4);
            CINCI_4.Add(4);
            CINCI_4.Add(4);
            CINCI_4.Add(4);
            CINCI_4.Add(4);
            SASE_4.Add(4);
            SASE_4.Add(4);
            SASE_4.Add(4);
            SASE_4.Add(4);
            SASE_4.Add(4);
            SASE_4.Add(4);

            TREI_5.Add(5);
            TREI_5.Add(5);
            TREI_5.Add(5);
            PATRU_5.Add(5);
            PATRU_5.Add(5);
            PATRU_5.Add(5);
            PATRU_5.Add(5);
            CINCI_5.Add(5);
            CINCI_5.Add(5);
            CINCI_5.Add(5);
            CINCI_5.Add(5);
            CINCI_5.Add(5);
            SASE_5.Add(5);
            SASE_5.Add(5);
            SASE_5.Add(5);
            SASE_5.Add(5);
            SASE_5.Add(5);
            SASE_5.Add(5);

            TREI_6.Add(6);
            TREI_6.Add(6);
            TREI_6.Add(6);
            PATRU_6.Add(6);
            PATRU_6.Add(6);
            PATRU_6.Add(6);
            PATRU_6.Add(6);
            CINCI_6.Add(6);
            CINCI_6.Add(6);
            CINCI_6.Add(6);
            CINCI_6.Add(6);
            CINCI_6.Add(6);
            SASE_6.Add(6);
            SASE_6.Add(6);
            SASE_6.Add(6);
            SASE_6.Add(6);
            SASE_6.Add(6);
            SASE_6.Add(6);

            listaValoriComparabile.Add(UNU);
            listaValoriComparabile.Add(CINCI);
            listaValoriComparabile.Add(TREI_1);
            listaValoriComparabile.Add(TREI_2);
            listaValoriComparabile.Add(TREI_3);
            listaValoriComparabile.Add(TREI_4);
            listaValoriComparabile.Add(TREI_5);
            listaValoriComparabile.Add(TREI_6);
            listaValoriComparabile.Add(PATRU_1);
            listaValoriComparabile.Add(PATRU_2);
            listaValoriComparabile.Add(PATRU_3);
            listaValoriComparabile.Add(PATRU_4);
            listaValoriComparabile.Add(PATRU_5);
            listaValoriComparabile.Add(PATRU_6);
            listaValoriComparabile.Add(CINCI_1);
            listaValoriComparabile.Add(CINCI_2);
            listaValoriComparabile.Add(CINCI_3);
            listaValoriComparabile.Add(CINCI_4);
            listaValoriComparabile.Add(CINCI_5);
            listaValoriComparabile.Add(CINCI_6);
            listaValoriComparabile.Add(SASE_1);
            listaValoriComparabile.Add(SASE_2);
            listaValoriComparabile.Add(SASE_3);
            listaValoriComparabile.Add(SASE_4);
            listaValoriComparabile.Add(SASE_5);
            listaValoriComparabile.Add(SASE_6);
            listaValoriComparabile.Add(BACCARAT);

        }

    }
}
