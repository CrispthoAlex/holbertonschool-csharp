using System;
using System.Collections.Generic;
class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> differentList = new List<int>();
        foreach (int ele in list1)
        {
            if(list2.Exists(e => e == ele) == false)
            {
                differentList.Add(ele);
            }
        }
        foreach (int ele in list2)
        {
            if(list1.Exists(e => e == ele) == false)
            {
                differentList.Add(ele);
            }
        }
        differentList.Sort();
        return differentList;
    }
}
