CREATE TABLE [dbo].[Department] (
    [DepartmentID] INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NULL,
    [Budget]       MONEY         NOT NULL,
    [StartDate]    DATETIME      NOT NULL,
    [InstructorID] INT           NULL,
    [RowVersion]   ROWVERSION    NULL,
    [DateModified] DATETIME      NULL,
    [IsDeleted]    BIT           NULL,
    CONSTRAINT [PK_dbo.Department] PRIMARY KEY CLUSTERED ([DepartmentID] ASC),
    CONSTRAINT [FK_dbo.Department_dbo.Instructor_InstructorID] FOREIGN KEY ([InstructorID]) REFERENCES [dbo].[Person] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_InstructorID]
    ON [dbo].[Department]([InstructorID] ASC);

