USE [DatabaseWeDevlopNow]
GO
/****** Object:  Table [dbo].[OurProducts]    Script Date: 20/01/2023 08:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
