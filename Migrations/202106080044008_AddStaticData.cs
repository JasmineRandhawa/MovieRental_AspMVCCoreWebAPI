namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStaticData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.MembershipTypes(Name, DurationInMonths, Price,DiscountRate) VALUES( 'PayAsYouGo', 0 , 0 , 0)");
            Sql("INSERT INTO dbo.MembershipTypes(Name, DurationInMonths, Price,DiscountRate) VALUES( 'Monthly', 1 , 30 , 10)");
            Sql("INSERT INTO dbo.MembershipTypes(Name, DurationInMonths, Price,DiscountRate) VALUES( 'Quarterly', 3  , 90 , 15)");
            Sql("INSERT INTO dbo.MembershipTypes(Name, DurationInMonths, Price,DiscountRate) VALUES( 'Yearly', 12 , 300 , 20)");

            Sql("INSERT INTO dbo.Genres(Name) VALUES( 'Fiction')");
            Sql("INSERT INTO dbo.Genres(Name) VALUES( 'Comedy')");
            Sql("INSERT INTO dbo.Genres(Name) VALUES('Thriller')");
            Sql("INSERT INTO dbo.Genres(Name) VALUES('Romantic')");
        }
        
        public override void Down()
        {
        }
    }
}
