using FluentMigrator;
using System;

namespace CoreDevAdmin.Migrations.DefaultDB
{
    [Migration(20180520115100)]
    public class DefaultDB_20160519_115100_MovieTable_AddMovieKind : Migration
    {
        public override void Up()
        {
            Alter.Table("Movie").InSchema("mov")
                .AddColumn("Kind").AsInt32().NotNullable()
                    .WithDefaultValue(1);
        }

        public override void Down()
        {
        }
    }
}