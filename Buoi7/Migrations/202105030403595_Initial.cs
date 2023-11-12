namespace Buoi7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        NewPassword = c.String(),
                        ConfirmNewPassword = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        PostalCode = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        Profile = c.String(),
                        Photo = c.String(),
                        AdditionalComments = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
