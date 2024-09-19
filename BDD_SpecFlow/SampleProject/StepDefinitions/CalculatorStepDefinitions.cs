using NUnit.Framework;

namespace SampleProject.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
       private int firstNumber,secondNumber,sum,difference;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            this.firstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            this.secondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            this.sum= this.firstNumber+this.secondNumber;
        }

        [Then("the sum should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, this.sum);
        }

        [When(@"the second number is subtracted from the first number")]
        public void WhenTheSecondNumberIsSubtractedFromTheFirstNumber()
        {
            this.difference = this.firstNumber - this.secondNumber;  
        }

        [Then(@"the difference should be (.*)")]
        public void ThenTheDifferenceShouldBe(int result)
        {
            Assert.AreEqual(result, this.difference);
        }

    }
}