import { EntityDialog } from '@serenity-is/corelib';
import { MovieGenresForm, MovieGenresRow, MovieGenresService } from '../../ServerTypes/MovieDB';

export class MovieGenresDialog extends EntityDialog<MovieGenresRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("MovieTutorial.MovieDB.");

    protected override getFormKey() { return MovieGenresForm.formKey; }
    protected override getRowDefinition() { return MovieGenresRow; }
    protected override getService() { return MovieGenresService.baseUrl; }

    protected form = new MovieGenresForm(this.idPrefix);
}