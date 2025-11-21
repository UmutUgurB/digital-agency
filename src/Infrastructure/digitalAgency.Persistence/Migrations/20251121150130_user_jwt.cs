using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace digitalAgency.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class user_jwt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Tags",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tags",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Tags",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "SocialMedias",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SocialMedias",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "SocialMedias",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SocialMediaIcon",
                table: "SocialMedias",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "SocialMedias",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SocialMedias",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Sliders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Sliders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sliders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Services",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Services",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Services",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Services",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Services",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Services",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "References",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "References",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "IconUrl",
                table: "References",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "References",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "References",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "References",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "References",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "References",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "References",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Infos",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Infos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "Infos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Infos",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Infos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Infos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Comments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Comments",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Blogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "BlogCategories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "BlogCategories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "BlogCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "BlogCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "BlogCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BlogCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "BlogCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Abouts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Abouts",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Abouts",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Abouts",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Abouts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Abouts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Contacts",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Contacts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Contacts",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contacts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsSystemRole = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FailedLoginAttempts = table.Column<int>(type: "int", nullable: false),
                    LockoutEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Description", "ImageUrl", "IsDeleted", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("ab000001-0001-0001-0001-000000000001"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 589, DateTimeKind.Utc).AddTicks(9100), null, null, "2014'ten bu yana dijital pazarlama alanında hizmet veren Digital Agency, 150'den fazla markaya danışmanlık vermiş, 250'den fazla başarılı projeye imza atmıştır. SEO, sosyal medya yönetimi, Google Ads ve web tasarım konularında uzman kadromuzla işletmenizin dijital dünyadaki yolculuğuna rehberlik ediyoruz.", "https://images.unsplash.com/photo-1522071820081-009f0129c71c?w=800", false, "Hakkımızda - Digital Agency", null, null });

            migrationBuilder.InsertData(
                table: "BlogCategories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Description", "IsDeleted", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("ca000001-0001-0001-0001-000000000001"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 590, DateTimeKind.Utc).AddTicks(874), null, null, "Dijital pazarlama stratejileri ve güncel trendler hakkında bilgiler", false, "Dijital Pazarlama", null, null },
                    { new Guid("ca000001-0001-0001-0001-000000000002"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 590, DateTimeKind.Utc).AddTicks(883), null, null, "Arama motoru optimizasyonu teknikleri ve ipuçları", false, "SEO", null, null },
                    { new Guid("ca000001-0001-0001-0001-000000000003"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 590, DateTimeKind.Utc).AddTicks(888), null, null, "Sosyal medya yönetimi ve içerik stratejileri", false, "Sosyal Medya", null, null },
                    { new Guid("ca000001-0001-0001-0001-000000000004"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 590, DateTimeKind.Utc).AddTicks(891), null, null, "Modern web tasarım trendleri ve kullanıcı deneyimi", false, "Web Tasarım", null, null },
                    { new Guid("ca000001-0001-0001-0001-000000000005"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 590, DateTimeKind.Utc).AddTicks(895), null, null, "Etkili içerik üretimi ve içerik pazarlama stratejileri", false, "İçerik Pazarlama", null, null },
                    { new Guid("ca000001-0001-0001-0001-000000000006"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 590, DateTimeKind.Utc).AddTicks(899), null, null, "E-ticaret çözümleri ve online satış stratejileri", false, "E-Ticaret", null, null }
                });

            migrationBuilder.InsertData(
                table: "Infos",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "Mail", "PhoneNumber", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("10f00001-0001-0001-0001-000000000001"), "Maslak Mahallesi, Büyükdere Caddesi No:123, Sarıyer/İstanbul", "System", new DateTime(2025, 5, 21, 15, 1, 29, 590, DateTimeKind.Utc).AddTicks(6375), null, null, false, "info@digitalagency.com", "+90 212 555 1234", null, null });

            migrationBuilder.InsertData(
                table: "References",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Description", "IconUrl", "IsDeleted", "IsShown", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0ef00001-0001-0001-0001-000000000001"), "System", new DateTime(2025, 6, 21, 15, 1, 29, 590, DateTimeKind.Utc).AddTicks(7765), null, null, "SEO ve içerik pazarlama projesi", "https://via.placeholder.com/300x200?text=TechCorp", false, true, "TechCorp A.Ş.", null, null },
                    { new Guid("0ef00001-0001-0001-0001-000000000002"), "System", new DateTime(2025, 7, 21, 15, 1, 29, 590, DateTimeKind.Utc).AddTicks(7777), null, null, "Sosyal medya yönetimi ve influencer marketing", "https://via.placeholder.com/300x200?text=Fashion", false, true, "FashionBrand", null, null },
                    { new Guid("0ef00001-0001-0001-0001-000000000003"), "System", new DateTime(2025, 8, 21, 15, 1, 29, 590, DateTimeKind.Utc).AddTicks(7782), null, null, "Google Ads ve e-ticaret optimizasyonu", "https://via.placeholder.com/300x200?text=ECommerce", false, true, "E-Commerce Plus", null, null },
                    { new Guid("0ef00001-0001-0001-0001-000000000004"), "System", new DateTime(2025, 9, 21, 15, 1, 29, 590, DateTimeKind.Utc).AddTicks(7786), null, null, "Web tasarım ve dijital pazarlama stratejisi", "https://via.placeholder.com/300x200?text=Healthcare", false, true, "HealthCare Solutions", null, null },
                    { new Guid("0ef00001-0001-0001-0001-000000000005"), "System", new DateTime(2025, 10, 21, 15, 1, 29, 590, DateTimeKind.Utc).AddTicks(7790), null, null, "Yerel SEO ve sosyal medya kampanyaları", "https://via.placeholder.com/300x200?text=Restaurant", false, true, "RestaurantChain", null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Description", "IsDeleted", "IsSystemRole", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "System", new DateTime(2025, 11, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(1205), null, null, "System Administrator", false, true, "Admin", null, null },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "System", new DateTime(2025, 11, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(1210), null, null, "Content Editor", false, true, "Editor", null, null },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "System", new DateTime(2025, 11, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(1213), null, null, "Regular User", false, true, "User", null, null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Description", "ImageUrl", "IsDeleted", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("50000001-0001-0001-0001-000000000001"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(2811), null, null, "Google'da üst sıralarda yer alın. Organik trafiğinizi artırın ve daha fazla müşteriye ulaşın.", "https://images.unsplash.com/photo-1571677208715-0ca4e1d2b1b1?w=400", false, "SEO Optimizasyonu", null, null },
                    { new Guid("50000001-0001-0001-0001-000000000002"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(2823), null, null, "Instagram, Facebook, LinkedIn ve Twitter'da profesyonel içerik yönetimi ve strateji danışmanlığı.", "https://images.unsplash.com/photo-1611162616305-c69b3fa7fbe0?w=400", false, "Sosyal Medya Yönetimi", null, null },
                    { new Guid("50000001-0001-0001-0001-000000000003"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(2828), null, null, "Hedef kitlenize doğrudan ulaşın. ROI odaklı reklam kampanyaları ile satışlarınızı artırın.", "https://images.unsplash.com/photo-1460925895917-afdab827c52f?w=400", false, "Google Ads Yönetimi", null, null },
                    { new Guid("50000001-0001-0001-0001-000000000004"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(2832), null, null, "Modern, hızlı ve kullanıcı dostu web siteleri. Mobil uyumlu ve SEO optimizasyonlu.", "https://images.unsplash.com/photo-1467232004584-a241de8bcf5d?w=400", false, "Web Tasarım & Geliştirme", null, null },
                    { new Guid("50000001-0001-0001-0001-000000000005"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(2836), null, null, "Blog yazıları, infografikler ve video içerikleri ile markanızı güçlendirin.", "https://images.unsplash.com/photo-1542435503-956c469947f6?w=400", false, "İçerik Pazarlama", null, null },
                    { new Guid("50000001-0001-0001-0001-000000000006"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(2842), null, null, "Online mağazanızı büyütün. Satış hunisi optimizasyonu ve pazaryeri yönetimi.", "https://images.unsplash.com/photo-1556742049-0cfed4f6a45d?w=400", false, "E-Ticaret Danışmanlığı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Button", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Description", "ImageUrl", "IsDeleted", "IsShown", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("51d00001-0001-0001-0001-000000000001"), "Hemen Başla", "System", new DateTime(2025, 6, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(4019), null, null, "Profesyonel dijital pazarlama stratejileri ile markanızı zirveye taşıyın", "https://images.unsplash.com/photo-1460925895917-afdab827c52f?w=1200", false, true, "Dijital Pazarlama ile İşinizi Büyütün", null, null },
                    { new Guid("51d00001-0001-0001-0001-000000000002"), "Detaylı Bilgi", "System", new DateTime(2025, 7, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(4029), null, null, "Google'ın ilk sayfasında yer alın", "https://images.unsplash.com/photo-1432888622747-4eb9a8f2c1e?w=1200", false, true, "SEO ile Organik Trafiğinizi Artırın", null, null },
                    { new Guid("51d00001-0001-0001-0001-000000000003"), "İletişime Geç", "System", new DateTime(2025, 8, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(4033), null, null, "Hedef kitlenize ulaşın", "https://images.unsplash.com/photo-1611162617474-5b21e879e113?w=1200", false, true, "Sosyal Medyada Fark Yaratın", null, null }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "IsShown", "SocialMediaIcon", "Title", "UpdatedBy", "UpdatedDate", "Url" },
                values: new object[,]
                {
                    { new Guid("a0c00001-0001-0001-0001-000000000001"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(5422), null, null, false, true, "fab fa-facebook", "Facebook", null, null, "https://facebook.com/digitalagency" },
                    { new Guid("a0c00001-0001-0001-0001-000000000002"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(5433), null, null, false, true, "fab fa-instagram", "Instagram", null, null, "https://instagram.com/digitalagency" },
                    { new Guid("a0c00001-0001-0001-0001-000000000003"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(5438), null, null, false, true, "fab fa-twitter", "Twitter", null, null, "https://twitter.com/digitalagency" },
                    { new Guid("a0c00001-0001-0001-0001-000000000004"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(5441), null, null, false, true, "fab fa-linkedin", "LinkedIn", null, null, "https://linkedin.com/company/digitalagency" },
                    { new Guid("a0c00001-0001-0001-0001-000000000005"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(5445), null, null, false, true, "fab fa-youtube", "YouTube", null, null, "https://youtube.com/@digitalagency" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Description", "IsDeleted", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0a600001-0001-0001-0001-000000000000"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6843), null, null, "Arama motoru optimizasyonu", false, "SEO", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000001"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6868), null, null, "Google reklam kampanyaları", false, "Google Ads", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000002"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6872), null, null, "Facebook reklam kampanyaları", false, "Facebook Ads", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000003"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6875), null, null, "Instagram pazarlama ve yönetimi", false, "Instagram", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000004"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6879), null, null, "LinkedIn profesyonel ağ pazarlaması", false, "LinkedIn", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000005"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6884), null, null, "İçerik pazarlama stratejileri", false, "Content Marketing", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000006"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6888), null, null, "E-posta pazarlama kampanyaları", false, "Email Marketing", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000007"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6891), null, null, "Veri analizi ve raporlama", false, "Analytics", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000008"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6894), null, null, "Dönüşüm optimizasyonu", false, "Conversion", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000009"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6898), null, null, "Kullanıcı deneyimi tasarımı", false, "UX Design", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000010"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6902), null, null, "Mobil pazarlama stratejileri", false, "Mobile Marketing", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000011"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6905), null, null, "Video içerik pazarlaması", false, "Video Marketing", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000012"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6908), null, null, "Influencer pazarlama kampanyaları", false, "Influencer", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000013"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6911), null, null, "E-ticaret çözümleri", false, "E-commerce", null, null },
                    { new Guid("0a600001-0001-0001-0001-000000000014"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 591, DateTimeKind.Utc).AddTicks(6914), null, null, "Marka kimliği ve konumlandırma", false, "Branding", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsActive", "IsDeleted", "LastLoginDate", "LastName", "LockoutEnd", "PasswordHash", "PhoneNumber", "RefreshToken", "RefreshTokenExpiryTime", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "System", new DateTime(2025, 5, 21, 15, 1, 29, 592, DateTimeKind.Utc).AddTicks(157), null, null, "admin@digitalagency.com", true, 0, "Admin", true, false, null, "User", null, "50000.Y3p0Z8vYGkW6hVvZw3x8Qg==.kYF3bZPJGZHvX2mL9sN4pQ1wR5tU8xV0yA7bC3dE6fF=", "+90 555 111 1111", null, null, null, null },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), "System", new DateTime(2025, 8, 21, 15, 1, 29, 592, DateTimeKind.Utc).AddTicks(167), null, null, "editor@digitalagency.com", true, 0, "Editor", true, false, null, "User", null, "50000.bYn3Z9vYGkW7hVvZw3x9Rh==.lZG4caPKHaIwY3nM0tO5qR2xS6uV9yW1zA8cD4eF7gG=", "+90 555 222 2222", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "RoleId", "UpdatedBy", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("aaaa0001-0001-0001-0001-000000000001"), "System", new DateTime(2025, 11, 21, 15, 1, 29, 592, DateTimeKind.Utc).AddTicks(2649), null, null, false, new Guid("11111111-1111-1111-1111-111111111111"), null, null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                    { new Guid("eeee0001-0001-0001-0001-000000000001"), "System", new DateTime(2025, 11, 21, 15, 1, 29, 592, DateTimeKind.Utc).AddTicks(2654), null, null, false, new Guid("22222222-2222-2222-2222-222222222222"), null, null, new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId_RoleId",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: new Guid("ab000001-0001-0001-0001-000000000001"));

            migrationBuilder.DeleteData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca000001-0001-0001-0001-000000000001"));

            migrationBuilder.DeleteData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca000001-0001-0001-0001-000000000002"));

            migrationBuilder.DeleteData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca000001-0001-0001-0001-000000000003"));

            migrationBuilder.DeleteData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca000001-0001-0001-0001-000000000004"));

            migrationBuilder.DeleteData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca000001-0001-0001-0001-000000000005"));

            migrationBuilder.DeleteData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca000001-0001-0001-0001-000000000006"));

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: new Guid("10f00001-0001-0001-0001-000000000001"));

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: new Guid("0ef00001-0001-0001-0001-000000000001"));

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: new Guid("0ef00001-0001-0001-0001-000000000002"));

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: new Guid("0ef00001-0001-0001-0001-000000000003"));

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: new Guid("0ef00001-0001-0001-0001-000000000004"));

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: new Guid("0ef00001-0001-0001-0001-000000000005"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("50000001-0001-0001-0001-000000000001"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("50000001-0001-0001-0001-000000000002"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("50000001-0001-0001-0001-000000000003"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("50000001-0001-0001-0001-000000000004"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("50000001-0001-0001-0001-000000000005"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("50000001-0001-0001-0001-000000000006"));

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: new Guid("51d00001-0001-0001-0001-000000000001"));

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: new Guid("51d00001-0001-0001-0001-000000000002"));

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: new Guid("51d00001-0001-0001-0001-000000000003"));

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: new Guid("a0c00001-0001-0001-0001-000000000001"));

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: new Guid("a0c00001-0001-0001-0001-000000000002"));

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: new Guid("a0c00001-0001-0001-0001-000000000003"));

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: new Guid("a0c00001-0001-0001-0001-000000000004"));

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: new Guid("a0c00001-0001-0001-0001-000000000005"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000000"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000001"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000002"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000003"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000004"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000005"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000006"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000007"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000008"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000009"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000010"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000011"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000012"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000013"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a600001-0001-0001-0001-000000000014"));

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "References");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "References");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "References");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "References");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "References");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Infos");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Infos");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Infos");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Infos");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Infos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "BlogCategories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "BlogCategories");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "BlogCategories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BlogCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "BlogCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Contacts");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "SocialMediaIcon",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "References",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "References",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "IconUrl",
                table: "References",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "References",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "BlogCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "BlogCategories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");
        }
    }
}
