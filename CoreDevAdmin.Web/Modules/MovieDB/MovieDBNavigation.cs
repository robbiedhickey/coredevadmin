using Serenity.Navigation;
using MyPages = CoreDevAdmin.MovieDB.Pages;

[assembly: NavigationMenu(7000, "Movie Database", icon: "fa-film")]
[assembly: NavigationLink(int.MaxValue, "Movie Database/Movies", typeof(MyPages.MovieController), icon: "fa-video-camera")]