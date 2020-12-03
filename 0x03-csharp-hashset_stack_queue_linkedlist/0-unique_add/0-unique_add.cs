using System;
using System.Collections.Generic;
    class List
    {
        public static int Sum(List<int> myList)
        {
            int sumElem = 0;
            List<int> sumList = new List<int>();
            
            for (int i = 0; i < myList.Count; i++)
            {
                if (sumList.Exists(e => e == myList[i]) == false)
                {
                    sumList.Add(myList[i]);
                }
            }
            for (int i = 0; i < sumList.Count; i++)
            {
                sumElem += sumList[i];
            }
            return sumElem;
        }
    }
