using FluentMigrator;
using System;

namespace CoreDevAdmin.Migrations.DefaultDB
{
    [Migration(20180523115100)]
    public class DefaultDB_20180523_154700_GenreData : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Genre").InSchema("mov")
                .Row(new
                {
                    Name = "Action"
                })
                .Row(new
                {
                    Name = "Drama"
                })
                .Row(new
                {
                    Name = "Comedy"
                })
                .Row(new
                {
                    Name = "Sci-fi"
                })
                .Row(new
                {
                    Name = "Fantasy"
                })
                .Row(new
                {
                    Name = "Documentary"
                });;
        }

        public override void Down()
        {
        }
    }
}