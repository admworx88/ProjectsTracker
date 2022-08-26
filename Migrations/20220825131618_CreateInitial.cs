using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectsTracker.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    RecordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Company = table.Column<string>(type: "varchar(250)", nullable: false),
                    Project = table.Column<string>(type: "varchar(100)", nullable: false),
                    Role = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.RecordID);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "RecordID", "Company", "Name", "Project", "Role" },
                values: new object[,]
                {
                    { 1, "IBM", "Ankur", "Payroll", "Software Engineer" },
                    { 2, "IBM", "Akash", "Chatbot", "Software Engineer" },
                    { 3, "HP", "Priya", "VR Gaming", "Project Manager" },
                    { 4, "Microsoft", "Asha", "Payroll", "Solutions Architect" },
                    { 5, "HP", "Nandini", "Payroll", "Software Engineer" },
                    { 6, "Microsoft", "Piyush", "Payroll", "Delivery Manager" },
                    { 7, "HP", "Ankur", "Chatbot", "Lead Engineer" },
                    { 8, "HP", "Akash", "VR Gaming", "Software Engineer" },
                    { 9, "IBM", "Priya", "Payroll", "Software Engineer" },
                    { 10, "HP", "Asha", "Chatbot", "Delivery Manager" },
                    { 11, "IBM", "Nandini", "VR Gaming", "Lead Engineer" },
                    { 12, "Microsoft", "Piyush", "Chatbot", "Delivery Manager" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
