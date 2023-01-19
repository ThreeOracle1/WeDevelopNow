using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using Moq;
using FluentAssertions;
using WeDevelopNowApplicationMain;

namespace WeDevelopNowMain.Tests
{
    [TestClass]
    public class WeDevelopNowUnitTests
    {
        [TestMethod]
        public void MenGerneratesValidSqlStatementTemplate()
        {
            var MensSearchScreen = new UserControlMenSearchScreen();

            var MensSearchResultScreen = new UserControlMenSearchResultScreen();

            string MensSqlQuery = MensSearchScreen.FindTableSearchQueryMen();

            MensSearchResultScreen.BindDataGridMenFindResult(MensSqlQuery);

            string exampleSQLQuery = "SELECT [Product Discription], Brands , Quantity, Location FROM OurProducts WHERE [Product Type] ='' AND [Mens Sizes] like '%%' AND Colour = '' AND Price BETWEEN '0' AND '0' AND Brands = ''";

            MensSqlQuery.Should().Be(exampleSQLQuery);

        }
    }
}
