namespace MovieMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeCustomerContraints2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Birthday", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthday", c => c.DateTime(nullable: false));
        }
    }
}
