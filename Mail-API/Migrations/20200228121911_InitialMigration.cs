﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mail_API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExternalId = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    SentTime = table.Column<DateTime>(nullable: true),
                    TrackerId = table.Column<string>(nullable: true),
                    OpenTime = table.Column<DateTime>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    Receiver = table.Column<string>(nullable: true),
                    Sender = table.Column<string>(nullable: true),
                    ReplyTo = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    ErrorStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mails", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Mails",
                columns: new[] { "Id", "Body", "CreatedTime", "ErrorStatus", "ExternalId", "IPAddress", "OpenTime", "Receiver", "ReplyTo", "Sender", "SentTime", "Status", "Subject", "TrackerId" },
                values: new object[] { 1, "FirstBody", new DateTime(2020, 2, 28, 13, 19, 11, 546, DateTimeKind.Local).AddTicks(140), null, "FirstExternalId", "FirstIPAddress", new DateTime(2020, 2, 28, 13, 19, 11, 548, DateTimeKind.Local).AddTicks(2835), "FirstReceiver", "FirstReplyTo", "FirstSender", new DateTime(2020, 2, 28, 13, 19, 11, 548, DateTimeKind.Local).AddTicks(2004), 0, "FirstSubject", "FirstTrackerId" });

            migrationBuilder.InsertData(
                table: "Mails",
                columns: new[] { "Id", "Body", "CreatedTime", "ErrorStatus", "ExternalId", "IPAddress", "OpenTime", "Receiver", "ReplyTo", "Sender", "SentTime", "Status", "Subject", "TrackerId" },
                values: new object[] { 2, "SecondBody", new DateTime(2020, 2, 28, 13, 19, 11, 548, DateTimeKind.Local).AddTicks(4523), null, "SecondExternalId", "SecondIPAddress", new DateTime(2020, 2, 28, 13, 19, 11, 548, DateTimeKind.Local).AddTicks(4561), "SecondReceiver", "SecondReplyTo", "SecondSender", new DateTime(2020, 2, 28, 13, 19, 11, 548, DateTimeKind.Local).AddTicks(4544), 0, "SecondSubject", "SecondTrackerId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mails");
        }
    }
}