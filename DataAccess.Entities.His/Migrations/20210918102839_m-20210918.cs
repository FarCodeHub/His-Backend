using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Entities.His.Migrations
{
    public partial class m20210918 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "MedicalStaff",
                newName: "TypeBaseId");

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "UserCardCode",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CardCodeId",
                table: "User",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "Rh",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ReceptionId",
                table: "RequestService",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Reception",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Reception",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "PrescriptionServiceResult",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "PrescriptionDetailService",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "PrescriptionDetailDrug",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "Prescription",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "PatientExtraInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "Patient",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "MedicalStaffCertificate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "MedicalStaff",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "MedicalStaff",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CostVisit",
                table: "MedicalCenter",
                type: "decimal(18,0)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "MedicalCenter",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "DataTransferConvert",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "Certificate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "CenterStaff",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "CenterLocation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "CardCode",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "BaseValue",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserCardCode_UserId",
                table: "UserCardCode",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reception_DoctorId",
                table: "Reception",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_ReceptionId",
                table: "Prescription",
                column: "ReceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalStaffCertificate_CertificateId",
                table: "MedicalStaffCertificate",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalStaffCertificate_MedicalStaffId",
                table: "MedicalStaffCertificate",
                column: "MedicalStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalStaff_TypeBaseId",
                table: "MedicalStaff",
                column: "TypeBaseId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "([NormalizedUserName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "([NormalizedName] IS NOT NULL)");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalStaff_BaseValue",
                table: "MedicalStaff",
                column: "TypeBaseId",
                principalTable: "BaseValue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalStaffCertificate_Certificate",
                table: "MedicalStaffCertificate",
                column: "CertificateId",
                principalTable: "Certificate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalStaffCertificate_MedicalStaff",
                table: "MedicalStaffCertificate",
                column: "MedicalStaffId",
                principalTable: "MedicalStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Reception",
                table: "Prescription",
                column: "ReceptionId",
                principalTable: "Reception",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reception_MedicalStaff",
                table: "Reception",
                column: "DoctorId",
                principalTable: "MedicalStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCardCode_User",
                table: "UserCardCode",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalStaff_BaseValue",
                table: "MedicalStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalStaffCertificate_Certificate",
                table: "MedicalStaffCertificate");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalStaffCertificate_MedicalStaff",
                table: "MedicalStaffCertificate");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Reception",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Reception_MedicalStaff",
                table: "Reception");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCardCode_User",
                table: "UserCardCode");

            migrationBuilder.DropIndex(
                name: "IX_UserCardCode_UserId",
                table: "UserCardCode");

            migrationBuilder.DropIndex(
                name: "IX_Reception_DoctorId",
                table: "Reception");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_ReceptionId",
                table: "Prescription");

            migrationBuilder.DropIndex(
                name: "IX_MedicalStaffCertificate_CertificateId",
                table: "MedicalStaffCertificate");

            migrationBuilder.DropIndex(
                name: "IX_MedicalStaffCertificate_MedicalStaffId",
                table: "MedicalStaffCertificate");

            migrationBuilder.DropIndex(
                name: "IX_MedicalStaff_TypeBaseId",
                table: "MedicalStaff");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "UserCardCode");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "Rh");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Reception");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "PrescriptionServiceResult");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "PrescriptionDetailService");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "PrescriptionDetailDrug");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "PatientExtraInfo");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "MedicalStaffCertificate");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "MedicalStaff");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "MedicalStaff");

            migrationBuilder.DropColumn(
                name: "CostVisit",
                table: "MedicalCenter");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "MedicalCenter");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "DataTransferConvert");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "Certificate");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "CenterStaff");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "CenterLocation");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "CardCode");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "BaseValue");

            migrationBuilder.RenameColumn(
                name: "TypeBaseId",
                table: "MedicalStaff",
                newName: "Type");

            migrationBuilder.AlterColumn<int>(
                name: "CardCodeId",
                table: "User",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReceptionId",
                table: "RequestService",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Reception",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");
        }
    }
}
