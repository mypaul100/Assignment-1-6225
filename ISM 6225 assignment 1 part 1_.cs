using System;
using System.Collections;
using System.Collections.Generic;

public class selfdividingnumbers {
    public static void Main(string[] args) {
        Console.WriteLine(String.Join(", ", selfDivNumber(1, 22).ToArray()));
    }

    public static ArrayList selfDivNumber(int left, int right) {
        ArrayList resultlist = new ArrayList();

        if (left < 1) {
            resultlist.Add(0);
            return resultlist;

        }

        for (int num = left; num <= right; num++)
        {
            if (selfdividing(num))
                resultlist.Add(num);

        }
        return resultlist;

    }

    public static Boolean selfdividing(int num)
    {
        int x = num;

        while (x > 0)
        {
            int y = x % 10;

            if (y == 0)
            {
                return false;
            }
            if (num % y != 0)
            {
                return false;
            }

            x = x / 10;
        }

        return true;

    }



}


