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

namespace Objectivity.Test.Automation.Tests.PageObjects
{
    using System.Collections.Generic;

    using Objectivity.Test.Automation.Common;
    using Objectivity.Test.Automation.Common.Extensions;

    using OpenQA.Selenium;

    public enum PageTitles
    {
        HomePage,
        SearchResultsPage,
        TechnologiesBusinessPage
    }

    public class ProjectPageBase
    {
        /// <summary>
        /// The page title dictionary
        /// </summary>
        private readonly Dictionary<string, string> pageTitleDictionary = new Dictionary<string, string>
        {
            { "Home", "MSDN-the microsoft developer network" },
            { "Search Results", "objectivity - MSDN Search" },
            { "Technologies Business", "Business and Enterprise Application Development" }
        };

        public ProjectPageBase(DriverContext driverContext)
        {
            this.DriverContext = driverContext;
            this.Driver = driverContext.Driver;
        }

        protected IWebDriver Driver { get; set; }

        protected DriverContext DriverContext { get; set; }

        public bool IsPageTitle(string expectedPageTitle)
        {
            return this.Driver.IsPageTitle(expectedPageTitle, BaseConfiguration.MediumTimeout);
        }

        public string GetPageTitle(string pageName)
        {
            return this.pageTitleDictionary[pageName];
        }
    }
}
