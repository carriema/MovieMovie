namespace MovieMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Releasedate", c => c.DateTime());
            AddColumn("dbo.Movies", "UpdateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "UpdateTime");
            DropColumn("dbo.Movies", "Releasedate");
        }
    }
}
