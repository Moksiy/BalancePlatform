CREATE TABLE [dbo].[Groups]
(
	[Id] INT NOT NULL PRIMARY KEY
	,[GroupName] nvarchar(100) not null
	,[AdminId] int not null
	,[Descr] nvarchar(300) null
	,[ImgSource] uniqueidentifier null
	--
	,constraint FK_Groups_Users foreign key (AdminId) references dbo.Users(UserId)
)
