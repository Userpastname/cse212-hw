public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        else if (value == Data)
        {
            return;
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if(value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            // Insert to the left
            if(Left is not null)
            {
                 return Left.Contains(value);
            }
            else
            {
                return false;
            }
        }
        else if(value > Data)
        {
            // Insert to the right
            if(Right is not null)
            {
                 return Right.Contains(value);
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }

    }

    public int GetHeight(int height = 1)
    {
        // TODO Start Problem 4
        if(Right is null && Left is null)
        {
            return height;
        }
        else if(Left is not null&& Right is not null)
        {
            height++;
            int rig = Right.GetHeight(height);
            int lef = Left.GetHeight(height);
            return Math.Max(rig, lef);
        }
        else
        {
            if (Left is not null)
            {
                height++;
                return Left.GetHeight(height);
            }
            else if(Right is not null)
            {
                height++;
                return Right.GetHeight(height);
            }
            else return height;
        }
// Replace this line with the correct return statement(s)
    }
}