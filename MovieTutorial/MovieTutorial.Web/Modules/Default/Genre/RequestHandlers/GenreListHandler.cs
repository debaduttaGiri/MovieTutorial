using MyRow = MovieTutorial.Default.GenreRow;

namespace MovieTutorial.Default;

public interface IGenreListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class GenreListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IGenreListHandler
{
}