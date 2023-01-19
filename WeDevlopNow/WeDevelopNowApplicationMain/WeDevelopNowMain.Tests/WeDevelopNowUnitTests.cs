using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using Moq;
using FluentAssertions;
using WeDevelopNowApplicationMain;
using System.Windows.Forms;

namespace WeDevelopNowMain.Tests
{
    [TestClass]
    public class WeDevelopNowUnitTests
    {
        [TestMethod]
        public void MenGerneratesValidSqlStatementTemplate()
        {
            var mensSearchScreen = new UserControlMenSearchScreen();

            var mensSearchResultScreen = new UserControlMenSearchResultScreen();

            string mensSqlQuery = mensSearchScreen.FindTableSearchQueryMen();

            mensSearchResultScreen.BindDataGridMenFindResult(mensSqlQuery);

            string exampleSQLQuery = "SELECT [Product Discription], Brands , Quantity, Location FROM OurProducts WHERE [Product Type] ='' AND [Mens Sizes] like '%%' AND Colour = '' AND Price BETWEEN '0' AND '0' AND Brands = ''";

            mensSqlQuery.Should().Be(exampleSQLQuery);

        }
        [TestMethod]
        public void WomenHomeButtonReturnsToHomepage()
        {
            var womensSearchScreen = new UserControlWomenSearchScreen();

            var homepageScreen = new UserControlHomepage();

            var formInstance1 = Form.ActiveForm as Form1;

            formInstance1.WomenToHomeControlVisable();

            formInstance1.userControlWomenSearchScreen1.Visible.Should().Be(false);

            formInstance1.userControlHomepage1.Visible.Should().Be(true);
        }

        [TestMethod]

        public void BoysBackButtonReturnsToSearchPage()
        {
            var boysSearchScreen = new UserControlBoysSearchScreen();

            var boysSearchResultScreen = new UserControlBoysSearchResultScreen();

            var formInstance1 = Form.ActiveForm as Form1;

            formInstance1.BackToBoysControlVisable();

            formInstance1.userControlBoysSearchResultScreen1.Visible.Should().Be(false);

            formInstance1.userControlBoysSearchScreen1.Visible.Should().Be(true);
        }


    }
}
