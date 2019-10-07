using Microsoft.EntityFrameworkCore.Migrations;

namespace Agenda.Migrations
{
    public partial class ScheduleEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchenduleEvent",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false),
                    schenduleId = table.Column<long>(nullable: true),
                    eventtId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchenduleEvent", x => new { x.ScheduleId, x.EventId });
                    table.ForeignKey(
                        name: "FK_SchenduleEvent_Event_eventtId",
                        column: x => x.eventtId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SchenduleEvent_Schedule_schenduleId",
                        column: x => x.schenduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SchenduleEvent_eventtId",
                table: "SchenduleEvent",
                column: "eventtId");

            migrationBuilder.CreateIndex(
                name: "IX_SchenduleEvent_schenduleId",
                table: "SchenduleEvent",
                column: "schenduleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchenduleEvent");
        }
    }
}
