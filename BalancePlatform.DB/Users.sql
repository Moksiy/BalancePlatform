CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY
	,[UserName] nvarchar(200) not null
	,[Password] nvarchar(100) not null
	,[Descr] nvarchar(500) null
	,[Scores] int null
	,[GroupId] int null
	,[ImgSource] uniqueidentifier null
	--
	,constraint FK_Users_Groups foreign key(GroupId) references Groups(GroupId)
)
