# WeDevelopNow

// What is this application?: 

A retail Stock Management User Interface application. Allows user to search a database with sql query commands for product details based on search filters, returning the query result table is displayed on screen.

How to set up the local database:

First download Microsoft SQL Server Managment Studio 18 or an equivilant software. Then once the 'Connect to Server' Window is presented, enter fullstop '.' into the database name field and change the authentication type to "Windows Authentication". Click connect. Then expand the database folder in the object explorer and right click the 'databases' folder. Select 'New Database..' from the dropdown menu.

On the New Database window, enter the name of the database 'DatabaseWeDevlopNow' and select a file location for the database to be saved to and select Ok. A new database should have been created.

Importing the table:

A script file called 'TableDesignAndData.sql' has been included with the reposotory. Open this file and it should populate a query window your Microsoft SQL. Select the'execute' button just under the 'new query' button.


Import script not working:

To be done if the previous method does not work or there is an unexpected issue.

If there is a already existing table this may not work, ensure your local database has no other tables if this does not work.

If this further does not work, you can manually create your own table. To do this, right click the tables file under your database and select 'new table'

Once your new table is made, you can populate the table with a query using the following sql command section:

CREATE TABLE [dbo].[OurProducts](
	[Item Code] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Brands] [nvarchar](50) NULL,
	[Product Type] [nvarchar](50) NULL,
	[Colour] [nvarchar](50) NULL,
	[Product Discription] [nvarchar](50) NULL,
	[Mens Sizes] [nvarchar](50) NULL,
	[Womens Sizes] [nvarchar](50) NULL,
	[Boys Sizes] [nvarchar](50) NULL,
	[Girls Sizes] [nvarchar](50) NULL,
	[Quantity] [nvarchar](50) NULL,
	[Location] [nvarchar](50) NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_OurProducts] PRIMARY KEY CLUSTERED 
(
	[Item Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[OurProducts] ([Item Code], [Gender], [Brands], [Product Type], [Colour], [Product Discription], [Mens Sizes], [Womens Sizes], [Boys Sizes], [Girls Sizes], [Quantity], [Location], [Price]) VALUES (N'IC0000001', N'Mens', N'Brand A', N'Fleeces', N'Beige', N'Winter Fleece', N'M', N'M', N'M', N'M', N'10', N'London', 23.5)
INSERT [dbo].[OurProducts] ([Item Code], [Gender], [Brands], [Product Type], [Colour], [Product Discription], [Mens Sizes], [Womens Sizes], [Boys Sizes], [Girls Sizes], [Quantity], [Location], [Price]) VALUES (N'IC0000002', N'Mens', N'Brand A', N'Hoodies', N'Red', N'Front pocket hoodie', N'L', N'L', N'L', N'L', N'56', N'Manchester', 18.99)
INSERT [dbo].[OurProducts] ([Item Code], [Gender], [Brands], [Product Type], [Colour], [Product Discription], [Mens Sizes], [Womens Sizes], [Boys Sizes], [Girls Sizes], [Quantity], [Location], [Price]) VALUES (N'IC0000003', N'Ladies', N'Brand C', N'Dresses & Skirts', N'Blue', N'Brand C Baby Blue Skirt', NULL, N'S/M/L/XL/XXL', NULL, N'S/M/L/XL/XXL', N'7', N'Birmingham', 34)
INSERT [dbo].[OurProducts] ([Item Code], [Gender], [Brands], [Product Type], [Colour], [Product Discription], [Mens Sizes], [Womens Sizes], [Boys Sizes], [Girls Sizes], [Quantity], [Location], [Price]) VALUES (N'IC0000004', N'Ladies', N'Brand B', N'Leggings & Tights', N'Tan', N'Tan tights', NULL, NULL, NULL, NULL, N'89', N'Liverpool', 1.49)
INSERT [dbo].[OurProducts] ([Item Code], [Gender], [Brands], [Product Type], [Colour], [Product Discription], [Mens Sizes], [Womens Sizes], [Boys Sizes], [Girls Sizes], [Quantity], [Location], [Price]) VALUES (N'IC0000005', N'Ladies', N'Brand D', N'Sweatshirts
', N'Pink', N'Ladies Brand D pink sweatshirt', N'S/M/L/XL/XXL', N'S/M/L/XL/XXL', N'S/M/L/XL/XXL', N'S/M/L/XL/XXL', N'1245', N'Newcastle', 17.99)
INSERT [dbo].[OurProducts] ([Item Code], [Gender], [Brands], [Product Type], [Colour], [Product Discription], [Mens Sizes], [Womens Sizes], [Boys Sizes], [Girls Sizes], [Quantity], [Location], [Price]) VALUES (N'IC0000006', N'Boys', N'Brand C', N'Polo Shirts', N'Multi', N'Green and yellow striped polo by Brand A', N'S/M/L/XL/XXL', N'S/M/L/XL/XXL', N'S/M/L/XL/XXL', N'S/M/L/XL/XXL', N'312', N'Sheffield', 9.99)
INSERT [dbo].[OurProducts] ([Item Code], [Gender], [Brands], [Product Type], [Colour], [Product Discription], [Mens Sizes], [Womens Sizes], [Boys Sizes], [Girls Sizes], [Quantity], [Location], [Price]) VALUES (N'IC0000007', N'Boys', N'Brand C', N'Shoes', N'Black', N'Boys black school shoes', N'6/6.5/7/7.5/8/8.5/9/9.5/10/10.5/11/12/13', NULL, N'6/6.5/7/7.5/8/8.5/9/9.5/10/10.5/11/12/13', NULL, N'23', N'Sheffield', 65)
INSERT [dbo].[OurProducts] ([Item Code], [Gender], [Brands], [Product Type], [Colour], [Product Discription], [Mens Sizes], [Womens Sizes], [Boys Sizes], [Girls Sizes], [Quantity], [Location], [Price]) VALUES (N'IC0000008', N'Girls', N'Brand B', N'Shorts', N'Pink', N'Brand B girls shorts (pink with white stripe)', NULL, NULL, NULL, N'S/M/L/XL/XXL', N'132', N'Sheffield', 14.5)
INSERT [dbo].[OurProducts] ([Item Code], [Gender], [Brands], [Product Type], [Colour], [Product Discription], [Mens Sizes], [Womens Sizes], [Boys Sizes], [Girls Sizes], [Quantity], [Location], [Price]) VALUES (N'IC0000009', N'Girls', N'Brand C', N'Sweatshirts', N'Purple', N'Unicorn sequined girls top', NULL, NULL, NULL, N'S/M/L/XL/XXL', N'77', N'Birmingham', 8.99)
INSERT [dbo].[OurProducts] ([Item Code], [Gender], [Brands], [Product Type], [Colour], [Product Discription], [Mens Sizes], [Womens Sizes], [Boys Sizes], [Girls Sizes], [Quantity], [Location], [Price]) VALUES (N'IC0000010', N'Girls', N'Brand A', N'Tracksuit Bottoms', N'Red', N'Brand A track suit pants - girls', NULL, NULL, NULL, N'S/M/L/XL/XXL', N'297', N'Liverpool', 12.95)
GO

How to connect the database to the visual studio application:

For the application to work, the database must be connected correctly. To do this, open the application file and expand the User Controls folder.