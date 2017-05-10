namespace Mod.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembership : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (3, 60, 3, 20)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (4, 90, 12, 30)");
        }
        
        public override void Down()
        {
        }
    }
}
