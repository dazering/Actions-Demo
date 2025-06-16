namespace ActionsDemo.Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.That(ActionsDemo.TestedUnit.Test(), Is.EqualTo(1));
    }
}