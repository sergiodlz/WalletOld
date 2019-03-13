using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wallet.DATA.Migrations
{
    public partial class AccountType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    AccountType = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Enable = table.Column<bool>(nullable: false, defaultValueSql: "1"),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    ModificationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.AccountType);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountType");
        }
    }
}
