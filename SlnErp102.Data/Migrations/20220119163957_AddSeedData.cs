using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlnErp102.Data.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "tblProductEntries",
                columns: new[] { "Id", "Barcode", "CompanyId", "CreatedOn", "Description", "EntryDate", "EntryTypeId", "ExpirationDate", "InvoiceNumber", "LotSerial", "ModifiedOn", "ModifiedUser", "ProductId", "ProductionDate", "Quantity" },
                values: new object[,]
                {
                    { 1, "AR-1000/1", 1, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7594), "TEST1", new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7595), 1, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7596), "1234", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7597), 0 },
                    { 2, "AR-1000/2", 1, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7598), "TEST1", new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7599), 1, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7599), "1234", "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7600), 0 },
                    { 3, "AR-1001/1", 1, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7601), "TEST1", new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7602), 1, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7603), "1234", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7603), 0 },
                    { 4, "AR-1002/1", 2, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7604), "TEST1", new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7605), 1, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7605), "4321", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2022, 1, 19, 19, 39, 56, 564, DateTimeKind.Local).AddTicks(7606), 0 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6540), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6544), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6546), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6324), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6326), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6328), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6329), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6331), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6333), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6611), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6612), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6614), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6615), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6616), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6617), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6748), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6749), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6750), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6748), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6752), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6753), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6753), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6752), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6755), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6756), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6757), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6755), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6243), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6246), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6248), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6250), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6252), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6253), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6255), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6257), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6045), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6048), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6049), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6051), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6052), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6054), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6055), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6057), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6058), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6928), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6924), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6932), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6934), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6933), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6989), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6987), new DateTime(2022, 1, 19, 18, 26, 50, 467, DateTimeKind.Local).AddTicks(6989) });
        }
    }
}
