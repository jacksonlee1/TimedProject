create TABLE Users
(
    [Id] int not null PRIMARY KEY IDENTITY(1,1),
    [Email] NVARCHAR(100) not null,
    [Password] NVARCHAR(100) not null,
    [FirstName] NVARCHAR(100),
    [LastName] NVARCHAR(100)
)
GO

create TABLE Posts
(
    [Id] int not null PRIMARY KEY IDENTITY(1,1),
    [Title] NVARCHAR(100) not null,
    [Text] NVARCHAR(250) not null,
    [AuthorId] int FOREIGN KEY REFERENCES Users(Id),
)
GO

create TABLE Comments
(
    [Id] int not null primary key IDENTITY(1,1),
    [Text] NVARCHAR(250) not NULL,
    [AuthorId] int FOREIGN KEY REFERENCES Users(Id),
    [PostId] int FOREIGN KEY REFERENCES Posts(Id)
)
GO

create TABLE Replies
(
    [Id] int not null PRIMARY KEY IDENTITY(1,1),
    [Text] NVARCHAR(250) not null,
    [ParentId] int FOREIGN KEY REFERENCES Comments(Id),
    [AuthorId] int FOREIGN KEY REFERENCES Users(Id)
)
GO

create TABLE Likes
(
    [Id] int not null PRIMARY KEY IDENTITY(1,1),
    [PostId] int not null,
    [UserId] int FOREIGN KEY REFERENCES Posts(Id)
)
GO