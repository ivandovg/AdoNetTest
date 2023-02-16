CREATE PROCEDURE [dbo].[DeleteManufacturer]
	@Id int
AS
	delete from Manufacturers where Id = @Id
RETURN @@ROWCOUNT
