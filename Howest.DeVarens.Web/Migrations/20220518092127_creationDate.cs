using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Howest.DeVarens.Web.Migrations
{
    public partial class creationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 21, 26, 706, DateTimeKind.Local).AddTicks(2730));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
