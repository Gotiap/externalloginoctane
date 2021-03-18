/*  
Create CSExternalLogin table
*/

CREATE TABLE [dbo].[CSExternalLogin](
	[ExternalLoginId] [int] IDENTITY(1,1) NOT NULL,
	[ModuleId] [int] NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[CreatedBy] [nvarchar](256) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](256) NOT NULL,
	[ModifiedOn] [datetime] NOT NULL,
  CONSTRAINT [PK_CSExternalLogin] PRIMARY KEY CLUSTERED 
  (
	[ExternalLoginId] ASC
  )
)
GO

/*  
Create foreign key relationships
*/
ALTER TABLE [dbo].[CSExternalLogin] WITH CHECK ADD CONSTRAINT [FK_CSExternalLogin_Module] FOREIGN KEY([ModuleId])
REFERENCES [dbo].Module ([ModuleId])
ON DELETE CASCADE
GO