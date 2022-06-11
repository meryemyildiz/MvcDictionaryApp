﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bir3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "AboutDetails1", c => c.String(maxLength: 1000));
            DropColumn("dbo.Abouts", "AbotDetails1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "AbotDetails1", c => c.String(maxLength: 1000));
            DropColumn("dbo.Abouts", "AboutDetails1");
        }
    }
}
