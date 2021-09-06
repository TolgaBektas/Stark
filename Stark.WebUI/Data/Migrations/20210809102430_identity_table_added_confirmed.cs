using Microsoft.EntityFrameworkCore.Migrations;

namespace Stark.WebUI.Data.Migrations
{
    public partial class identity_table_added_confirmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Confirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "Confirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dfd5856-932b-41be-b07c-e83236b2808d", true, "AQAAAAEAACcQAAAAEC7hAhZrLa3kqMUYJKBbhHoKYZbQkNiRO5MuDgIbjTRcse77NtpJ1iGFMTmfEcE4oA==", "094836fe-c7af-453e-9bef-636a08e4f213" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirmed",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d63cd1b-c5dd-409e-87f1-b578f44a56f1", "AQAAAAEAACcQAAAAEKtmWOaDUrQxaE3HW/1PEcdMH73UCjjz4IF+c8TO23e1Hm7Z4KZIHjswvWM5eCfgdg==", "546b6bda-57d0-4ec1-babb-7083eb6c3e39" });
        }
    }
}
