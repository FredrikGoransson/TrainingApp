using FluentMigrator;

namespace TrainingApp.Persistance.Sql.Migrations
{
    [Migration(1)]
    public class CreateTables : Migration
    {
        public override void Up()
        {
            Create.Table("Users")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Name").AsString(255).NotNullable().WithDefaultValue("Anonymous");
        }

        public override void Down()
        {
            Delete.Table("Users");
        }
    }
}
