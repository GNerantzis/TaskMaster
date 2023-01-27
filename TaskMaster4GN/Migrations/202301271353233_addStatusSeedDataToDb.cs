﻿namespace TaskMaster4GN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStatusSeedDataToDb : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (Name) VALUES ('To Do');");
            Sql("INSERT INTO Status (Name) VALUES ('In Progress');");
            Sql("INSERT INTO Status (Name) VALUES ('Done');");
        }
        
        public override void Down()
        {
        }
    }
}
