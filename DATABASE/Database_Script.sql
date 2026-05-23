CREATE TABLE [dbo].[DeliveryPool] (
    [RequestID]       INT             IDENTITY (1, 1) NOT NULL,
    [FoodRequest]     VARCHAR (255)   NOT NULL,
    [DeliveryFee]     DECIMAL (18, 2) NOT NULL,
    [DropoffLocation] VARCHAR (150)   NOT NULL,
    [RunnerStatus]    VARCHAR (20)    DEFAULT ('Pending') NOT NULL,
    [SealCode]        NCHAR (50)      NULL,
    PRIMARY KEY CLUSTERED ([RequestID] ASC)
);

CREATE TABLE [dbo].[Marketplace] (
    [ListingID]      INT             IDENTITY (1, 1) NOT NULL,
    [ProductName]    VARCHAR (100)   NOT NULL,
    [Price]          DECIMAL (18, 2) NOT NULL,
    [SellerLocation] VARCHAR (150)   NOT NULL,
    [ItemStatus]     VARCHAR (20)    DEFAULT ('Available') NOT NULL,
    PRIMARY KEY CLUSTERED ([ListingID] ASC)
);

CREATE TABLE [dbo].[OrderTracking] (
    [OrderID]          INT           IDENTITY (1, 1) NOT NULL,
    [OrderDescription] VARCHAR (255) NOT NULL,
    [SecurePasscode]   VARCHAR (4)   NOT NULL,
    [OrderStatus]      VARCHAR (30)  DEFAULT ('Out for Delivery') NOT NULL,
    [RunnerRating]     INT           NULL,
    PRIMARY KEY CLUSTERED ([OrderID] ASC)
);

CREATE TABLE [dbo].[Ratings] (
    [RatingID]      INT            IDENTITY (1, 1) NOT NULL,
    [StudentID]     NVARCHAR (50)  NULL,
    [Comment]       NVARCHAR (500) NULL,
    [RatingValue]   INT            NULL,
    [DateSubmitted] DATETIME       DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([RatingID] ASC)
);

CREATE TABLE [dbo].[User] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [StudentID]     NVARCHAR (50)  NOT NULL,
    [Password]      NVARCHAR (50)  NOT NULL,
    [FullName]      NVARCHAR (100) NULL,
    [AccountStatus] VARCHAR (20)   DEFAULT ('Active') NOT NULL,
    [UserRole]      NVARCHAR (50)  DEFAULT ('Student') NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

