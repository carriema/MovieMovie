namespace MovieMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Memberships (MembershipId, MembershipType, MembershipDiscount, SignUpFee, DurationInMonth) VALUES (1,'Regular Account',0,0,0)");
            Sql("INSERT INTO Memberships (MembershipId, MembershipType, MembershipDiscount, SignUpFee, DurationInMonth) VALUES (2,'Monthly Membership Account',10,30,1)");
            Sql("INSERT INTO Memberships (MembershipId, MembershipType, MembershipDiscount, SignUpFee, DurationInMonth) VALUES (3,'Quartly Membership Account',15,70,3)");
            Sql("INSERT INTO Memberships (MembershipId, MembershipType, MembershipDiscount, SignUpFee, DurationInMonth) VALUES (4,'Yearly Membership Account',20,250,12)");
        }

        public override void Down()
        {
        }
    }
}
