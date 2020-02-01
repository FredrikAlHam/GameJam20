public class WireBoxLogic
{
    public static bool CheckWire(int origin, int dest, string color, int count)
    {
        if (origin > 6) origin -= 3;
        if (dest > 6) dest -= 3;
        if (count == 3)
        {
            if (color == "red")
            {
                if (origin == 1 && dest == 5 || origin == 2 && dest == 3 || origin == 3 && dest == 2 || origin == 4 && dest == 10 || origin == 5 && dest == 11 || origin == 6 && dest == 12) return true;
            }
            else if (color == "blue" || color == "green")
            {
                if (dest == 1 && origin == 5 || dest == 2 && origin == 3 || dest == 3 && origin == 2 || dest == 4 && origin == 10 || dest == 5 && origin == 11 || dest == 6 && origin == 12) return true;
            }
            else if (color == "white")
            {
                if (dest == 5 && origin == 4 || dest == 3 && origin == 5 || dest == 2 && origin == 4 || dest == 10 && origin == 3 || dest == 11 && origin == 9 || dest == 12 && origin == 1) return true;
            }
        }
        else if (count == 4)
        {
            if (color == "red")
            {
                if (dest == 1 && origin == 5 || dest == 2 && origin == 3 || dest == 3 && origin == 2 || dest == 4 && origin == 10 || dest == 5 && origin == 11 || dest == 6 && origin == 12 || dest == 0 && origin == 13) return true;
            }
            else if (color == "blue")
            {
                if (dest == 5 && origin == 1 || dest == 3 && origin == 2 || dest == 2 && origin == 3 || dest == 11 && origin == 4 || dest == 5 && origin == 10 || dest == 12 && origin == 6 || dest == 13 && origin == 0) return true;
            }
            else if (color == "green")
            {
                if (dest == 5 && origin == 1 || dest == 3 && origin == 2 || dest == 12 && origin == 3 || dest == 10 && origin == 4 || dest == 11 && origin == 5 || dest == 2 && origin == 6 || dest == 13 && origin == 0) return true;
            }
            else if (color == "white")
            {
                if (dest == 6 && origin == 5 || dest == 5 && origin == 3 || dest == 4 && origin == 2 || dest == 3 && origin == 10 || dest == 2 && origin == 11 || dest == 1 && origin == 12 || dest == 0 && origin == 13) return true;
            }
        }
        else if (count == 5)
        {
            if (color == "red" && origin == dest) return true;
            else if (color == "blue")
            {
                if (origin == 1 && dest == 3 || origin == 2 && dest == 2 || origin == 3 && dest == 1 || origin == 4 && dest == 4 || origin == 5 && dest == 5) return true;
            }
            else if (color == "green")
            {
                if (origin == 1 && dest == 2 || origin == 2 && dest == 1 || origin == 3 && dest == 3 || origin == 4 && dest == 5 || origin == 5 && dest == 4) return true;
            }
            else if (color == "white" && 6 - origin == dest) return true;
        }
        return false;
    }
    public static int GetSolution(int origin, string color, int count)
    {
        if(count == 4)
        {

        }
        return 0;
    }
}
