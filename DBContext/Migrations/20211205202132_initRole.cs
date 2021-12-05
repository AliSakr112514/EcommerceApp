using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DBContext.Migrations
{
    public partial class initRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "AspNetRoles",
               columns: new[] { "Name", "NormalizedName", "ConcurrencyStamp" },
               values: new object[] {  "User", "User".ToUpper(), Guid.NewGuid().ToString() }
           );

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] {"Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] {  "Admin", "Admin".ToUpper(), Guid.NewGuid().ToString() }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [AspNetRoles]");
        }
    }
}
