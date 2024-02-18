using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("0a28ca9c-807b-4fe0-b4c2-f6d4060e7b4c"), "music", "London", new DateTime(2024, 4, 18, 14, 53, 16, 307, DateTimeKind.Utc).AddTicks(7375), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("3e852b44-b830-4caa-8299-b2cd840e4f04"), "drinks", "London", new DateTime(2023, 12, 18, 14, 53, 16, 307, DateTimeKind.Utc).AddTicks(7342), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("51dec12e-ecef-4b6d-b70c-8c7997eedf4d"), "travel", "London", new DateTime(2024, 9, 18, 14, 53, 16, 307, DateTimeKind.Utc).AddTicks(7408), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("5908d63c-088b-4c5d-b1e6-dd70136dfdd9"), "drinks", "London", new DateTime(2024, 6, 18, 14, 53, 16, 307, DateTimeKind.Utc).AddTicks(7380), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("5d58e449-7e22-4fc9-94e8-db401d99f207"), "music", "London", new DateTime(2024, 8, 18, 14, 53, 16, 307, DateTimeKind.Utc).AddTicks(7406), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("af5dc27e-c894-4934-bb87-d21cfe820e78"), "culture", "Paris", new DateTime(2024, 1, 18, 14, 53, 16, 307, DateTimeKind.Utc).AddTicks(7358), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("d67035d8-781a-4e5b-a1ee-b99a9ff14210"), "drinks", "London", new DateTime(2024, 7, 18, 14, 53, 16, 307, DateTimeKind.Utc).AddTicks(7403), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("ddb0c2f0-4111-4be5-b576-9f02394c483d"), "culture", "London", new DateTime(2024, 3, 18, 14, 53, 16, 307, DateTimeKind.Utc).AddTicks(7362), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("de5a0bdf-31f7-4d4a-9d34-782df0f9c4ec"), "film", "London", new DateTime(2024, 10, 18, 14, 53, 16, 307, DateTimeKind.Utc).AddTicks(7410), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("feecb4cb-4ca2-406d-a7a3-bda5f255d9ed"), "drinks", "London", new DateTime(2024, 5, 18, 14, 53, 16, 307, DateTimeKind.Utc).AddTicks(7378), "Activity 3 months in future", "Future Activity 3", "Another pub" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("0a28ca9c-807b-4fe0-b4c2-f6d4060e7b4c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("3e852b44-b830-4caa-8299-b2cd840e4f04"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("51dec12e-ecef-4b6d-b70c-8c7997eedf4d"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("5908d63c-088b-4c5d-b1e6-dd70136dfdd9"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("5d58e449-7e22-4fc9-94e8-db401d99f207"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("af5dc27e-c894-4934-bb87-d21cfe820e78"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("d67035d8-781a-4e5b-a1ee-b99a9ff14210"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("ddb0c2f0-4111-4be5-b576-9f02394c483d"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("de5a0bdf-31f7-4d4a-9d34-782df0f9c4ec"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("feecb4cb-4ca2-406d-a7a3-bda5f255d9ed"));
        }
    }
}
