using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Howest.DeVarens.Web.Migrations
{
    public partial class fixedCreationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "FormOfEducation",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreationDate",
                value: new DateTime(2022, 5, 18, 11, 28, 8, 372, DateTimeKind.Local).AddTicks(3720));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
