using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Howest.DeVarens.Web.Migrations
{
    public partial class orderSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_FormOfEducation_FormOfEducationId",
                table: "Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "FormOfEducationId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreationDate", "DeletionDate", "IsOpen", "ShippingDate", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 16, 21, 302, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreationDate", "DeletionDate", "OrderId", "ProductId", "ProductPrice", "Quantity", "UpdateDate" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 16.99m, 1, null });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreationDate", "DeletionDate", "OrderId", "ProductId", "ProductPrice", "Quantity", "UpdateDate" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), 79.99m, 3, null });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreationDate", "DeletionDate", "OrderId", "ProductId", "ProductPrice", "Quantity", "UpdateDate" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003"), 29.99m, 2, null });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_FormOfEducation_FormOfEducationId",
                table: "Products",
                column: "FormOfEducationId",
                principalTable: "FormOfEducation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_FormOfEducation_FormOfEducationId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.AlterColumn<Guid>(
                name: "FormOfEducationId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippingDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_FormOfEducation_FormOfEducationId",
                table: "Products",
                column: "FormOfEducationId",
                principalTable: "FormOfEducation",
                principalColumn: "Id");
        }
    }
}
