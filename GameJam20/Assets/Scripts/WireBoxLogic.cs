using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireBoxLogic
{
    public static bool CheckWire(string name, string dest,string color, int count)
    {
        return false;
    }
    public static bool CheckWire(int origin, int dest, string color, int count)
    {
        if (count == 5)
        {
            if (color == "red" && origin == dest) return true;
            if (color == "blue")
            {
                if (origin == 1 && dest == 3 || origin == 2 && dest == 2 || origin == 3 && dest == 1 || origin == 4 && dest == 4 || origin == 5 && dest == 5) return true;
            }
            if (color == "green")
            {
                if (origin == 1 && dest == 2 || origin == 2 && dest == 1 || origin == 3 && dest == 3 || origin == 4 && dest == 5 || origin == 5 && dest == 4) return true;
            }
            if (color == "white" && 6 - origin == dest) return true;
        }
        return false;
    }
}
