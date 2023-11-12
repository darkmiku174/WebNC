namespace PM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        MaSP = c.String(nullable: false, maxLength: 128),
                        TenSP = c.String(),
                        GiaTien = c.Double(nullable: false),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSP);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        MaNXS = c.String(nullable: false, maxLength: 128),
                        TenNXS = c.String(),
                    })
                .PrimaryKey(t => t.MaNXS);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
        }
    }
}
