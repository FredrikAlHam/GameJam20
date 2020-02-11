using System.Collections.Generic;
using System;
public static class WireBoxLogic
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
    public static int GetAnswer(int origin, string color, int count)
    {
        if (count < 6) throw new System.Exception("Feature not inplemented for less than 6 wires");
        if (count >= 6)
        {
            if (color == "red") return (origin + 3) % 11;
            else if (color == "blue") return (origin + 9) % 11;
            else if (color == "green") return (2 * origin + 1) % 11;
            else if (color == "white") return (3 * origin + 3) % 11;
        }
        throw new System.Exception("Character not possible");
    }
    public static int GetAnswer(int origin, int color, int count)
    {
        if (color == 1)
        {
            return GetAnswer(origin, "red", count);
        }
        else if (color == 2)
        {
            return GetAnswer(origin, "blue", count);
        }
        else if (color == 3)
        {
            return GetAnswer(origin, "green", count);
        }
        else if (color == 4)
        {
            return GetAnswer(origin, "white", count);
        }
        throw new System.Exception("Color out of bounds");
    }
    public static int[] GetNecessaryAnswers(WireNode[] nodes)
    {
        List<int> positions = new List<int>();
        List<string> colors = new List<string>();
        int i = 0;
        foreach (WireNode node in nodes)
        {
            positions.Add(i);
            colors.Add(node.color);
            i++;
        }
        return GetNecessaryAnswers(positions.ToArray(), colors.ToArray(), nodes.Length);
    }
    public static int[] GetNecessaryAnswers(int[] origins, string[] colors, int count)
    {
        List<int> newOrigins = new List<int>();
        for (int i = 0; i < origins.Length; i++)
        {
            newOrigins.Add(GetAnswer(origins[i], colors[i], count));
        }
        return newOrigins.ToArray();
    }
    public static int[] GetNecessaryAnswers(int[] origins, int[] colors, int count)
    {
        List<string> stringColors = new List<string>();
        foreach (int color in colors)
        {
            if (color == 1)
            {
                stringColors.Add("red");
            }
            else if (color == 2)
            {
                stringColors.Add("blue");
            }
            else if (color == 3)
            {
                stringColors.Add("green");
            }
            else if (color == 4)
            {
                stringColors.Add("white");
            }
            throw new System.Exception("Color out of bounds");
        }
        return GetNecessaryAnswers(origins, stringColors.ToArray(), count);
    }
    public static WireNode[] GetRandomNodes(int count)
    {
        List<WireNode> wireNodes= new List<WireNode>();
        for (int i = 0; i < count; i++)
        {
            WireNode node = new WireNode();
            node.Color(new Random().Next(4));
            node.character = new Random().Next(10);
            wireNodes.Add(node);
        }
        return wireNodes.ToArray();
    }
    [Serializable]
    public struct WireNode
    {
        public int character;
        public string color;
        public void Color(int cInt)
        {
            if (cInt == 1)
            {
                color = "red";
            }
            else if (cInt == 2)
            {
                color = "blue";
            }
            else if (cInt == 3)
            {
                color = "green";
            }
            else if (cInt == 4)
            {
                color = "white";
            }
            throw new System.Exception("Color out of bounds");
        }
        public WireNode(int ch, string c)
        {
            character = ch;
            color = c;
        }
        public WireNode(int ch)
        {
            character = ch;
            color = null;
        }
    }
    public struct WireBox
    {
        public WireNode[] wires;
        public WireNode[] destinations;
        public WireBox(int count)
        {
            wires = GetRandomNodes(count);
            int[] destChars = GetNecessaryAnswers(wires);
            List<WireNode> dests = new List<WireNode>();
            foreach (int ch in destChars)
            {
                dests.Add(new WireNode(ch));
            }
            destinations = dests.ToArray();
        }
    }
}
