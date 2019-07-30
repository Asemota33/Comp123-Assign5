
CREATE TABLE [dbo].[products](
	[productID] [smallint] IDENTITY(1,1) NOT NULL,
	[cost] [money] NULL,
	[manufacturer] [nvarchar](255) NULL,
	[model] [nvarchar](255) NULL,
	[RAM_type] [nvarchar](255) NULL,
	[RAM_size] [nvarchar](255) NULL,
	[displaytype] [nvarchar](255) NULL,
	[screensize] [nvarchar](255) NULL,
	[resolution] [nvarchar](255) NULL,
	[CPU_Class] [nvarchar](255) NULL,
	[CPU_brand] [nvarchar](255) NULL,
	[CPU_type] [nvarchar](255) NULL,
	[CPU_speed] [nvarchar](255) NULL,
	[CPU_number] [nvarchar](255) NULL,
	[condition] [nvarchar](255) NULL,
	[OS] [nvarchar](255) NULL,
	[platform] [nvarchar](255) NULL,
	[HDD_size] [nvarchar](255) NULL,
	[HDD_speed] [nvarchar](255) NULL,
	[GPU_Type] [nvarchar](255) NULL,
	[optical_drive] [nvarchar](255) NULL,
	[Audio_type] [nvarchar](255) NULL,
	[LAN] [nvarchar](255) NULL,
	[WIFI] [nvarchar](255) NULL,
	[width] [nvarchar](255) NULL,
	[height] [nvarchar](255) NULL,
	[depth] [nvarchar](255) NULL,
	[weight] [nvarchar](255) NULL,
	[moust_type] [nvarchar](255) NULL,
	[power] [nvarchar](255) NULL,
	[webcam] [nvarchar](255) NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
