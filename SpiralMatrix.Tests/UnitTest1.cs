namespace SpiralMatrix.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1() 
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int[][] matrix = new int[3][];
        matrix[0] = new int[] { 1, 2, 3 };
        matrix[1] = new int[] { 4, 5, 6 };
        matrix[2] = new int[] { 7, 8, 9 };
        IList<int> result = _test.SpiralOrder(matrix);
        IList<int> expected = new List<int>() { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
        Assert.IsTrue(result.SequenceEqual(expected));
    }    
    
    [TestMethod]
    public void TestMethod2()
    {
        int[][] matrix = new int[3][];
        matrix[0] = new int[] { 1, 2, 3, 4 };
        matrix[1] = new int[] { 5, 6, 7, 8 };
        matrix[2] = new int[] { 9, 10, 11, 12 };
        IList<int> result = _test.SpiralOrder(matrix);
        IList<int> expected = new List<int>() { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };
        Assert.IsTrue(result.SequenceEqual(expected));
    }
}