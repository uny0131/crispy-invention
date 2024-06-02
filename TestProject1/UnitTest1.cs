namespace TestProject1;

public class Tests
{
    [Test]
    public void Test1()
    {
        int a = 10;
        Assert.That(a, Is.EqualTo(10));
    }
}
