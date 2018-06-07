using Serenity.Navigation;
using MyPages = CoreDevAdmin.MovieDB.Pages;

[assembly: NavigationMenu(7000, "MovieDB", icon: "fa-desktop")]
[assembly: NavigationLink(int.MaxValue, "MovieDB/Movie", typeof(MyPages.MovieController), icon: "fa-desktop")]