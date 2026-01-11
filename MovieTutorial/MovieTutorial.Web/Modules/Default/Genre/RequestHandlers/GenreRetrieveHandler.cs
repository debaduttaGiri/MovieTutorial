using MyRow = MovieTutorial.Default.GenreRow;

namespace MovieTutorial.Default;

public interface IGenreRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class GenreRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IGenreRetrieveHandler
{
}