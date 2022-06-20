namespace DIEPHOANVU_BIGSHOOL0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into CATEGORIES (ID, NAME) values (1, 'Development')");
            Sql("insert into CATEGORIES (ID, NAME) values (2, 'Business')");
            Sql("insert into CATEGORIES (ID, NAME) values (3, 'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
