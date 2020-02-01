public class WireBoxLogic
{
    public static bool CheckWire(int origin, int dest, string color, int count)
    {
        if (count == 3)
        {
            if (color == "red") if (origin == 1 && dest == 5 || origin == 2 && dest == 3 || origin == 3 && dest == 2 || origin == 4 && dest == 10 || origin == 5 && dest == 11 || origin == 6 && origin == 12) return true;
            else if (color == "blue" || color== "green") if (dest == 1 && origin == 5 || dest == 2 && origin == 3 || dest == 3 && origin == 2 || dest == 4 && origin == 10 || dest == 5 && origin == 11 || dest == 6 && origin == 12) return true;
            else if (color == "white") if (dest == 5 && origin == 4 || dest == 3 && origin == 5 || dest == 2 && origin == 4 || dest == 10 && origin == 3 || dest == 11 && origin == 9 || dest == 12 && origin == 1) return true;
        }else if(false)
        {
            if (color == "red") if (origin == 1 && dest == 5 || origin == 2 && dest == 3 || origin == 3 && dest == 2 || origin == 4 && dest == 10 || origin == 5 && dest == 11 || origin == 6 && origin == 12) return true;
            else if (color == "blue" || color == "green") if (dest == 1 && origin == 5 || dest == 2 && origin == 3 || dest == 3 && origin == 2 || dest == 4 && origin == 10 || dest == 5 && origin == 11 || dest == 6 && origin == 12) return true;
            else if (color == "white") if (dest == 5 && origin == 4 || dest == 3 && origin == 5 || dest == 2 && origin == 4 || dest == 10 && origin == 3 || dest == 11 && origin == 9 || dest == 12 && origin == 1) return true;
        }
        else if (count == 5)
        {
            if (color == "red" && origin == dest) return true;
            else if (color == "blue") if (origin == 1 && dest == 3 || origin == 2 && dest == 2 || origin == 3 && dest == 1 || origin == 4 && dest == 4 || origin == 5 && dest == 5) return true;
            else if (color == "green") if (origin == 1 && dest == 2 || origin == 2 && dest == 1 || origin == 3 && dest == 3 || origin == 4 && dest == 5 || origin == 5 && dest == 4) return true;
            else if (color == "white" && 6 - origin == dest) return true;
        }
        return false;
    }
}
