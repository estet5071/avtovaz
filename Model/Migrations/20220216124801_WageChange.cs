using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class WageChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.CreateTable(
                name: "Wages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaySalary = table.Column<decimal>(type: "money", nullable: false),
                    PrizeRatio = table.Column<double>(type: "float", nullable: false),
                    WorkDays = table.Column<int>(type: "int", nullable: false),
                    TaxDeduction = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wages", x => x.ID);
                    table.UniqueConstraint("AK_Wages_EmployeeID", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK__Wages__EmployeeI__3E52440B",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

         
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
      
            migrationBuilder.DropTable(
                name: "Wages");

        }
    }
}
