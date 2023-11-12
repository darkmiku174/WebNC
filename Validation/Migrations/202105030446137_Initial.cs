namespace Validation.Migrations
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
                        NewPassword = c.String(nullable: false),
                        ConfirmNewPassword = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(nullable: false),
                        PostalCode = c.Int(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Profile = c.String(nullable: false),
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
