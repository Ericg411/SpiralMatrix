namespace SpiralMatrix;
public class Class1
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        IList<IList<int>> matrixList = new List<IList<int>>();
        IList<int> result = new List<int>();
        int lower = 0;
        int upper = matrix.Length - 1;
        int left = 0;
        int right = matrix[0].Length - 1;
        bool goingDown = true;

        if (matrix[0].Length == 1)
        {
            foreach (int[] arr in matrix)
            {
                foreach (int i in arr)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        if (matrix[0].Length == 2)
        {
            for (int i = 0; i <= matrix.Length - 1; i++)
            {
                if (i == 0)
                {
                    foreach (int j in matrix[i])
                    {
                        result.Add(j);
                    }
                }
                else if (i == matrix.Length - 1)
                {
                    foreach (int j in matrix[i].Reverse())
                    {
                        result.Add(j);
                    }
                }
                else
                {
                    result.Add(matrix[i][1]);
                }
            }
            for (int i = matrix.Length - 2; i >= 1; i--)
            {
                result.Add(matrix[i][0]);
            }
            return result;
        }
        while (lower <= upper)
        {
            if (goingDown)
            {
                for (int i = lower; i <= upper; i++)
                {
                    if (i == lower)
                    {
                        for (int j = (left == 0 ? left : left - 1); j <= right; j++)
                        {
                            result.Add(matrix[i][j]);
                        }
                    }
                    else if (i == upper)
                    {
                        goingDown = false;
                        right--;
                    }
                    else
                    {
                        result.Add(matrix[i][right]);
                    }
                }
                lower++;
            }
            else
            {
                for (int i = upper; i >= lower; i--)
                {
                    if (i == upper)
                    {
                        for (int j = right + 1; j >= left; j--)
                        {
                            result.Add(matrix[i][j]);
                        }
                    }
                    else if (i == lower)
                    {
                        goingDown = true;
                        left++;
                    }
                    else
                    {
                        result.Add(matrix[i][left]);
                    }
                }
                upper--;
            }
        }
        return result;
    }
}
