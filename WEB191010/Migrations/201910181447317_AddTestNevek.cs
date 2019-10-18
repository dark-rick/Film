namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestNevek : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipus_Id) values('Norbi',1, 1);");
            Sql("insert into Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipus_Id) values('Gyurci',0, 2);");
            Sql("insert into Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipus_Id) values('Peti a kaszanova',1, 3);");
            Sql("insert into Ugyfels (Nev, HirlevelFeliratkozas, ElofizetesTipus_Id) values('Kicsi',0, 4);");
        }
        
        public override void Down()
        {
        }
    }
}
