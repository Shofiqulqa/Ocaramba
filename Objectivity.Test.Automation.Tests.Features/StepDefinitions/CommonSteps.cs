﻿/*
The MIT License (MIT)

Copyright (c) 2015 Objectivity Bespoke Software Specialists

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace Objectivity.Test.Automation.Tests.Features.StepDefinitions
{
    using Objectivity.Test.Automation.Common;
    using Objectivity.Test.Automation.Tests.PageObjects.PageObjects.TheInternet;
    using TechTalk.SpecFlow;

    [Binding]
    public class CommonSteps
    {
        private readonly DriverContext driverContext;

        public CommonSteps()
        {
            this.driverContext = ScenarioContext.Current["DriverContext"] as DriverContext;
        }

        [Given(@"I log on and default page is opened")]
        public void GivenILogOnAndDefaultPageIsOpened()
        {
            new InternetPage(this.driverContext).OpenHomePage();
        }

        [Given(@"I navigate to ""(.*)"" link")]
        public void GivenINavigateToLink(string nameOfThePage)
        {
            new InternetPage(this.driverContext).GoToPage(nameOfThePage);
        }

        [Given(@"I have dropdown page")]
        public void GivenIHaveDropdownPage()
        {
            var page = new DropdownPage(this.driverContext);
            ScenarioContext.Current.Set(page, "DropdownPage");
        }
    }
}
