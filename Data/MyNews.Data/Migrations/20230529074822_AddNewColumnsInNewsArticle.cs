using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyNews.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnsInNewsArticle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentsCount",
                table: "NewsArticles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TimeForReading",
                table: "NewsArticles",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentsCount",
                table: "NewsArticles");

            migrationBuilder.DropColumn(
                name: "TimeForReading",
                table: "NewsArticles");
        }
    }
}
