using MyRow = MovieTutorial.Default.GenreRow;

namespace MovieTutorial.Default;

public interface IGenreDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class GenreDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IGenreDeleteHandler
{
}