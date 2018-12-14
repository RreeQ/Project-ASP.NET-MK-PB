namespace WebApplication10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertSauce : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Sauces ( Name ) VALUES ('W³asny')");
            Sql("INSERT INTO Sauces ( Name ) VALUES ('Ostry')");
            Sql("INSERT INTO Sauces ( Name ) VALUES ('£agodny')");
            Sql("INSERT INTO Sauces ( Name ) VALUES ('Mieszany')");
        }
        
        public override void Down()
        {
        }
    }
}
