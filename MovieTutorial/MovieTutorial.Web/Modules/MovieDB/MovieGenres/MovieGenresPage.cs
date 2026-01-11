namespace MovieTutorial.MovieDB.Pages;

[PageAuthorize(typeof(MovieGenresRow))]
public class MovieGenresPage : Controller
{
    [Route("MovieDB/MovieGenres")]
    public ActionResult Index()
    {
        return this.GridPage<MovieGenresRow>("@/MovieDB/MovieGenres/MovieGenresPage");
    }
}