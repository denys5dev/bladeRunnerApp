using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BladeRunnerApp.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Users (FirstName, LastName, Email, UserRoleId, CreatedAt, LastVisit, SessionTime) VALUES ('Denys', 'Arkhipenko', 'denys5dev@gmail.com', (SELECT UserRoleId FROM UserRoles Where UserRoleType = '0'), '1990-01-01 00:00:00.0000000', '1990-01-01 00:00:00.0000000', '1990-01-01 00:00:00.0000000')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Users");
        }
    }
}
