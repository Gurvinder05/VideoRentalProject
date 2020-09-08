CREATE TABLE [dbo].[RentedMovies](
	[RentedMovieId] [int] IDENTITY(1,1) NOT NULL,
	[MovieId] [int] NULL,
	[CustId] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
 CONSTRAINT [PK_RentedMovies] PRIMARY KEY CLUSTERED 
(
	[RentedMovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD  CONSTRAINT [FK_RentedMovies_RentedMovies] FOREIGN KEY([RentedMovieId])
REFERENCES [dbo].[RentedMovies] ([RentedMovieId])
GO

ALTER TABLE [dbo].[RentedMovies] CHECK CONSTRAINT [FK_RentedMovies_RentedMovies]