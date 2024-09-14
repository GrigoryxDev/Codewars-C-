using System;
using NUnit.Framework;

[TestFixture]
public class ConvertStringToCamelCaseTests
{
    [Test]
    public void LaunchTests()
    {
        Assert.AreEqual("theStealthWarrior", ConvertStringToCamelCase.ToCamelCase("the_stealth_warrior"), "ConvertStringToCamelCaseTests.ToCamelCase('the_stealth_warrior') did not return correct value");
        Assert.AreEqual("TheStealthWarrior", ConvertStringToCamelCase.ToCamelCase("The-Stealth-Warrior"), "ConvertStringToCamelCaseTests.ToCamelCase('The-Stealth-Warrior') did not return correct value");
    }
}