import { EntityDialog } from '@serenity-is/corelib';
import { GenreForm, GenreRow, GenreService } from '../../ServerTypes/Default';

export class GenreDialog extends EntityDialog<GenreRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("MovieTutorial.Default.");

    protected override getFormKey() { return GenreForm.formKey; }
    protected override getRowDefinition() { return GenreRow; }
    protected override getService() { return GenreService.baseUrl; }

    protected form = new GenreForm(this.idPrefix);
}