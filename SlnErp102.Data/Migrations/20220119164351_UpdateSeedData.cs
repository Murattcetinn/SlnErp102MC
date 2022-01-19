using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlnErp102.Data.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4532), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4537), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4539), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4143), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4147), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4149), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4151), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4153), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4155), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4642), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4643), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4646), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4646), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4648), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4649), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4920), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4922), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4922), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4920), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4926), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4927), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4928), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4926), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4930), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4931), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4931), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4929), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4012), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4016), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4019), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4021), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4023), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4025), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4027), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4029), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3761), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3763), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3765), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3768), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3770), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3771), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3773), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3775), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3776), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5382), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5384), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5385), "system", new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5386), 100 });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5388), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5389), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5390), "system", new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5391), 200 });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5394), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5395), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5396), "system", new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5396), 50 });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5398), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5399), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5399), "system", new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5400), 150 });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5245), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5240), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5250), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5248), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5253), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5252), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5256), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5255), new DateTime(2022, 1, 19, 19, 43, 50, 758, DateTimeKind.Local).AddTicks(5257) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6626), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6631), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6633), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6107), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6110), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6112), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6114), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6115), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6117), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6789), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6792), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6793), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6794), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6795), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7123), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7124), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7125), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7122), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7127), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7128), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7128), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7127), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7130), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7131), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7131), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7130), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6017), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6021), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6022), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6024), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6026), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6027), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6029), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6031), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5698), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5701), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5703), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5704), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5705), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5707), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5708), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5709), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5711), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7594), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7596), null, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7597), 0 });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7598), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7599), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7599), null, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7600), 0 });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7601), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7602), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7603), null, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7603), 0 });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7604), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7605), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7605), null, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7606), 0 });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7437), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7433), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7440), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7439), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7443), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7442), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7445), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7444), new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7446) });
        }
    }
}
