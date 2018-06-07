namespace CoreDevAdmin.MovieDB {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'CoreDevAdmin.MovieDB.MovieKind', 'MovieDB.MovieKind');
}
