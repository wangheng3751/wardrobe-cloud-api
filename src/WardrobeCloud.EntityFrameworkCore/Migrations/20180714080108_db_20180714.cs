using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WardrobeCloud.Migrations
{
    public partial class db_20180714 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClothesCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothesCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DressCollocation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DressCollocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDressCollocationTag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDressCollocationTag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clothes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ClothesCategoryId = table.Column<int>(nullable: true),
                    PictureUrl = table.Column<string>(nullable: true),
                    TrusteeshipPictureUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clothes_ClothesCategory_ClothesCategoryId",
                        column: x => x.ClothesCategoryId,
                        principalTable: "ClothesCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DressCollocationTag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DressCollocationId = table.Column<int>(nullable: true),
                    TagId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DressCollocationTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DressCollocationTag_DressCollocation_DressCollocationId",
                        column: x => x.DressCollocationId,
                        principalTable: "DressCollocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DressCollocationTag_UserDressCollocationTag_TagId",
                        column: x => x.TagId,
                        principalTable: "UserDressCollocationTag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DressCollocationItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DressCollocationId = table.Column<int>(nullable: true),
                    ClothesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DressCollocationItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DressCollocationItem_Clothes_ClothesId",
                        column: x => x.ClothesId,
                        principalTable: "Clothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DressCollocationItem_DressCollocation_DressCollocationId",
                        column: x => x.DressCollocationId,
                        principalTable: "DressCollocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_ClothesCategoryId",
                table: "Clothes",
                column: "ClothesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DressCollocationItem_ClothesId",
                table: "DressCollocationItem",
                column: "ClothesId");

            migrationBuilder.CreateIndex(
                name: "IX_DressCollocationItem_DressCollocationId",
                table: "DressCollocationItem",
                column: "DressCollocationId");

            migrationBuilder.CreateIndex(
                name: "IX_DressCollocationTag_DressCollocationId",
                table: "DressCollocationTag",
                column: "DressCollocationId");

            migrationBuilder.CreateIndex(
                name: "IX_DressCollocationTag_TagId",
                table: "DressCollocationTag",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DressCollocationItem");

            migrationBuilder.DropTable(
                name: "DressCollocationTag");

            migrationBuilder.DropTable(
                name: "Clothes");

            migrationBuilder.DropTable(
                name: "DressCollocation");

            migrationBuilder.DropTable(
                name: "UserDressCollocationTag");

            migrationBuilder.DropTable(
                name: "ClothesCategory");
        }
    }
}
