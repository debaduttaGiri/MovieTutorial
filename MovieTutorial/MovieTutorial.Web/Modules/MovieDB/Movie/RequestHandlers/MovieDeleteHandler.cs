using MyRow = MovieTutorial.MovieDB.MovieRow;

namespace MovieTutorial.MovieDB;

public interface IMovieDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class MovieDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IMovieDeleteHandler
{
}