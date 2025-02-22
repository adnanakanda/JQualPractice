using Reqnroll;

namespace SeleniumKP1_2.Framework.StepDefinitions
{
    [Binding]
    internal class DataTableSteps
    {
        [When(@"I find '(.*)' in the second table")]
        public void FindTheEmail(string email)
        {
            throw new PendingStepException();
        }

        [When(@"I remember emails Web Site value")]
        public void RememeberTheValue()
        {
            throw new PendingStepException();
        }

        [When(@"I sort the table by First Name")]
        public void SortTheTable()
        {
            throw new PendingStepException();
        }

        [When(@"Check that Web Site value saved on step 2 is still present in the table")]
        public void CheckTheTableForValueSaved()
        {
            throw new PendingStepException();
        }

        [When(@"Check that Last Name are present on the column:")]
        public void CheckTheTableForLastName(Table lname)
        {
            throw new PendingStepException();
        }

        [Then(@"The value is found and saved")]
        public void IsValueSaved()
        {
            throw new PendingStepException();
        }

        [Then(@"Data Tables page is open")]
        public void PageIsOpened()
        {
            throw new PendingStepException();
        }

        [Then(@"The saved value is still present")]
        public void IsSaveedValueFound()
        {
            throw new PendingStepException();
        }

        [Then(@"The table is sorted")]
        public void IsTableSorted()
        {
            throw new PendingStepException();
        }

        [Then(@"Values are present")]
        public void IsValuePresent()
        {
            throw new PendingStepException();
        }
    }
}
