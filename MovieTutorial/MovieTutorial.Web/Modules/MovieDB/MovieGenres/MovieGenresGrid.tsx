import { EntityGrid } from '@serenity-is/corelib';
import { MovieGenresColumns, MovieGenresRow, MovieGenresService } from '../../ServerTypes/MovieDB';
import { MovieGenresDialog } from './MovieGenresDialog';

export class MovieGenresGrid extends EntityGrid<MovieGenresRow> {
    static override [Symbol.typeInfo] = this.registerClass("MovieTutorial.MovieDB.");

    protected override getColumnsKey() { return MovieGenresColumns.columnsKey; }
    protected override getDialogType() { return MovieGenresDialog; }
    protected override getRowDefinition() { return MovieGenresRow; }
    protected override getService() { return MovieGenresService.baseUrl; }
}