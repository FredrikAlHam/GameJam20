public class WireBoxLogic
{
    public static bool CheckWire(int origin, int dest, string color, int count)
    {
        if (origin > 6) origin += 3;
        if (dest > 6) dest += 3;
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
        else if (count >= 6)
        {
            if (color == "red" && (origin + 3) % 11 == dest)
            {
                return true;
            }
            else if (color == "blue" && (origin + 9) % 11 == dest)
            {
                return true;
            }
            else if (color == "green" && (2 * origin + 1) % 11 == dest)
            {
                return true;
            }
            else if (color == "white" && (3 * origin + 3) % 11 == dest)
            {
                return true;
            }
        }
        else
        {
            throw new System.Exception("Count must be greater than 3");
        }
        return false;

    }
    public static bool CheckWire(int origin, int dest, int color, int count)
    {
        if (color == 1)
        {
            return CheckWire(origin, dest, "red", count);
        }
        else if (color == 2)
        {
            return CheckWire(origin, dest, "blue", count);
        }

        else if (color == 3)
        {
            return CheckWire(origin, dest, "green", count);
        }

        else if (color == 4)
        {
            return CheckWire(origin, dest, "white", count);
        }
        throw new System.Exception("Color out of bounds");
    }
}
