using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mail_API.Migrations
{
    public partial class tezta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attachments",
                table: "DbMails");

            migrationBuilder.UpdateData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "OpenTime", "SentTime" },
                values: new object[] { new DateTime(2020, 6, 12, 14, 26, 31, 295, DateTimeKind.Local).AddTicks(8027), new DateTime(2020, 6, 12, 14, 26, 31, 299, DateTimeKind.Local).AddTicks(820), new DateTime(2020, 6, 12, 14, 26, 31, 298, DateTimeKind.Local).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "CreatedTime", "ExternalId", "IPAddress", "OpenTime", "Receiver", "ReplyTo", "Sender", "SentTime", "Subject", "TrackerId" },
                values: new object[] { "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(8627), "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(8712), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(8676), "FirstSubject", "FirstTrackerId" });

            migrationBuilder.InsertData(
                table: "DbMails",
                columns: new[] { "Id", "Body", "CreatedTime", "ErrorStatus", "ExternalId", "IPAddress", "OpenTime", "Receiver", "ReplyTo", "Sender", "SentTime", "Status", "Subject", "TrackerId" },
                values: new object[,]
                {
                    { 99, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6799), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6811), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6806), 0, "FirstSubject", "FirstTrackerId" },
                    { 73, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2885), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2898), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2892), 0, "FirstSubject", "FirstTrackerId" },
                    { 72, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2835), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2848), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2842), 0, "FirstSubject", "FirstTrackerId" },
                    { 71, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2777), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2791), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2785), 0, "FirstSubject", "FirstTrackerId" },
                    { 70, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2665), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2677), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2672), 0, "FirstSubject", "FirstTrackerId" },
                    { 69, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2615), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2627), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2621), 0, "FirstSubject", "FirstTrackerId" },
                    { 68, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2565), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2577), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2572), 0, "FirstSubject", "FirstTrackerId" },
                    { 67, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2514), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2527), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2521), 0, "FirstSubject", "FirstTrackerId" },
                    { 66, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2463), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2477), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2470), 0, "FirstSubject", "FirstTrackerId" },
                    { 65, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2408), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2421), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2415), 0, "FirstSubject", "FirstTrackerId" },
                    { 74, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2949), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2971), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2965), 0, "FirstSubject", "FirstTrackerId" },
                    { 64, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2358), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2371), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2365), 0, "FirstSubject", "FirstTrackerId" },
                    { 62, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2259), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2272), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2266), 0, "FirstSubject", "FirstTrackerId" },
                    { 61, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2207), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2220), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2214), 0, "FirstSubject", "FirstTrackerId" },
                    { 60, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2157), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2169), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2163), 0, "FirstSubject", "FirstTrackerId" },
                    { 59, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2108), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2120), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2114), 0, "FirstSubject", "FirstTrackerId" },
                    { 58, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2058), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2071), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2065), 0, "FirstSubject", "FirstTrackerId" },
                    { 57, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2009), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2021), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2015), 0, "FirstSubject", "FirstTrackerId" },
                    { 56, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1959), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1972), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1966), 0, "FirstSubject", "FirstTrackerId" },
                    { 55, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1909), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1922), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1916), 0, "FirstSubject", "FirstTrackerId" },
                    { 54, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1860), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1872), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1867), 0, "FirstSubject", "FirstTrackerId" },
                    { 63, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2309), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2322), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(2316), 0, "FirstSubject", "FirstTrackerId" },
                    { 75, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3009), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3022), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3016), 0, "FirstSubject", "FirstTrackerId" },
                    { 76, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3060), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3072), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3067), 0, "FirstSubject", "FirstTrackerId" },
                    { 53, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1806), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1820), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1814), 0, "FirstSubject", "FirstTrackerId" },
                    { 98, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6754), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6764), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6759), 0, "FirstSubject", "FirstTrackerId" },
                    { 97, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6709), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6720), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6715), 0, "FirstSubject", "FirstTrackerId" },
                    { 96, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6666), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6677), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6673), 0, "FirstSubject", "FirstTrackerId" },
                    { 95, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6619), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6630), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6626), 0, "FirstSubject", "FirstTrackerId" },
                    { 94, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6536), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6551), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6543), 0, "FirstSubject", "FirstTrackerId" },
                    { 93, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6452), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6473), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6467), 0, "FirstSubject", "FirstTrackerId" },
                    { 92, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(5756), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6169), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6032), 0, "FirstSubject", "FirstTrackerId" },
                    { 91, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(4880), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(4919), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(4903), 0, "FirstSubject", "FirstTrackerId" },
                    { 90, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(4504), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(4631), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(4595), 0, "FirstSubject", "FirstTrackerId" },
                    { 89, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(4059), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(4240), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(4219), 0, "FirstSubject", "FirstTrackerId" },
                    { 88, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3766), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3897), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3869), 0, "FirstSubject", "FirstTrackerId" },
                    { 87, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3721), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3728), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3725), 0, "FirstSubject", "FirstTrackerId" },
                    { 86, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3686), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3696), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3692), 0, "FirstSubject", "FirstTrackerId" },
                    { 85, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3559), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3588), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3574), 0, "FirstSubject", "FirstTrackerId" },
                    { 84, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3499), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3512), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3506), 0, "FirstSubject", "FirstTrackerId" },
                    { 83, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3420), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3459), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3453), 0, "FirstSubject", "FirstTrackerId" },
                    { 82, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3354), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3376), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3363), 0, "FirstSubject", "FirstTrackerId" },
                    { 81, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3304), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3317), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3311), 0, "FirstSubject", "FirstTrackerId" },
                    { 80, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3256), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3268), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3262), 0, "FirstSubject", "FirstTrackerId" },
                    { 79, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3206), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3220), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3213), 0, "FirstSubject", "FirstTrackerId" },
                    { 78, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3158), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3170), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3164), 0, "FirstSubject", "FirstTrackerId" },
                    { 100, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6847), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6857), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(6852), 0, "FirstSubject", "FirstTrackerId" },
                    { 77, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3110), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3123), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(3117), 0, "FirstSubject", "FirstTrackerId" },
                    { 52, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1705), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1717), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1712), 0, "FirstSubject", "FirstTrackerId" },
                    { 50, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1604), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1616), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1611), 0, "FirstSubject", "FirstTrackerId" },
                    { 24, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(181), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(192), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(187), 0, "FirstSubject", "FirstTrackerId" },
                    { 23, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(132), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(143), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(138), 0, "FirstSubject", "FirstTrackerId" },
                    { 22, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(64), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(77), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(71), 0, "FirstSubject", "FirstTrackerId" },
                    { 21, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(16), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(28), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(22), 0, "FirstSubject", "FirstTrackerId" },
                    { 20, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9967), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9980), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9974), 0, "FirstSubject", "FirstTrackerId" },
                    { 19, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9918), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9930), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9925), 0, "FirstSubject", "FirstTrackerId" },
                    { 18, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9868), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9881), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9875), 0, "FirstSubject", "FirstTrackerId" },
                    { 17, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9811), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9824), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9819), 0, "FirstSubject", "FirstTrackerId" },
                    { 16, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9761), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9773), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9767), 0, "FirstSubject", "FirstTrackerId" },
                    { 15, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9710), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9722), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9717), 0, "FirstSubject", "FirstTrackerId" },
                    { 14, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9658), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9671), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9665), 0, "FirstSubject", "FirstTrackerId" },
                    { 13, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9599), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9613), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9607), 0, "FirstSubject", "FirstTrackerId" },
                    { 12, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9487), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9499), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9493), 0, "FirstSubject", "FirstTrackerId" },
                    { 11, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9435), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9449), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9444), 0, "FirstSubject", "FirstTrackerId" },
                    { 10, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9385), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9397), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9392), 0, "FirstSubject", "FirstTrackerId" },
                    { 9, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9330), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9343), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9337), 0, "FirstSubject", "FirstTrackerId" },
                    { 8, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9278), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9291), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9285), 0, "FirstSubject", "FirstTrackerId" },
                    { 7, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9229), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9242), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9236), 0, "FirstSubject", "FirstTrackerId" },
                    { 6, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9182), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9194), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9189), 0, "FirstSubject", "FirstTrackerId" },
                    { 5, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9122), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9135), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9130), 0, "FirstSubject", "FirstTrackerId" },
                    { 4, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9069), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9082), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9076), 0, "FirstSubject", "FirstTrackerId" },
                    { 25, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(245), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(266), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(260), 0, "FirstSubject", "FirstTrackerId" },
                    { 51, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1655), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1669), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1663), 0, "FirstSubject", "FirstTrackerId" },
                    { 26, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(304), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(317), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(311), 0, "FirstSubject", "FirstTrackerId" },
                    { 28, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(405), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(418), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(412), 0, "FirstSubject", "FirstTrackerId" },
                    { 49, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1553), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1566), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1560), 0, "FirstSubject", "FirstTrackerId" },
                    { 48, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1504), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1516), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1511), 0, "FirstSubject", "FirstTrackerId" },
                    { 47, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1453), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1466), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1460), 0, "FirstSubject", "FirstTrackerId" },
                    { 46, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1402), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1415), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1409), 0, "FirstSubject", "FirstTrackerId" },
                    { 45, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1353), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1366), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1360), 0, "FirstSubject", "FirstTrackerId" },
                    { 44, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1304), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1317), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1311), 0, "FirstSubject", "FirstTrackerId" },
                    { 43, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1257), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1269), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1263), 0, "FirstSubject", "FirstTrackerId" },
                    { 42, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1209), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1221), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1215), 0, "FirstSubject", "FirstTrackerId" },
                    { 41, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1158), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1170), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1165), 0, "FirstSubject", "FirstTrackerId" },
                    { 40, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1107), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1120), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1114), 0, "FirstSubject", "FirstTrackerId" },
                    { 39, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1058), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1071), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1066), 0, "FirstSubject", "FirstTrackerId" },
                    { 38, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1007), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1020), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(1015), 0, "FirstSubject", "FirstTrackerId" },
                    { 37, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(958), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(970), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(965), 0, "FirstSubject", "FirstTrackerId" },
                    { 36, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(908), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(921), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(915), 0, "FirstSubject", "FirstTrackerId" },
                    { 35, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(857), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(871), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(864), 0, "FirstSubject", "FirstTrackerId" },
                    { 34, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(805), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(819), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(812), 0, "FirstSubject", "FirstTrackerId" },
                    { 33, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(742), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(757), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(750), 0, "FirstSubject", "FirstTrackerId" },
                    { 32, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(607), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(620), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(614), 0, "FirstSubject", "FirstTrackerId" },
                    { 31, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(555), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(569), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(563), 0, "FirstSubject", "FirstTrackerId" },
                    { 30, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(505), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(518), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(512), 0, "FirstSubject", "FirstTrackerId" },
                    { 29, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(454), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(466), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(461), 0, "FirstSubject", "FirstTrackerId" },
                    { 27, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(354), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(368), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 301, DateTimeKind.Local).AddTicks(362), 0, "FirstSubject", "FirstTrackerId" },
                    { 3, "FirstBody", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9004), null, "Test1", "FirstIPAddress", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9023), "robin.eskilsson@winlas.se", "FirstReplyTo", "no-reply@winlas.se", new DateTime(2020, 6, 12, 14, 26, 31, 300, DateTimeKind.Local).AddTicks(9017), 0, "FirstSubject", "FirstTrackerId" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.AddColumn<byte[]>(
                name: "Attachments",
                table: "DbMails",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "OpenTime", "SentTime" },
                values: new object[] { new DateTime(2020, 6, 11, 11, 4, 11, 412, DateTimeKind.Local).AddTicks(6396), new DateTime(2020, 6, 11, 11, 4, 11, 414, DateTimeKind.Local).AddTicks(9740), new DateTime(2020, 6, 11, 11, 4, 11, 414, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "DbMails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "CreatedTime", "ExternalId", "IPAddress", "OpenTime", "Receiver", "ReplyTo", "Sender", "SentTime", "Subject", "TrackerId" },
                values: new object[] { "SecondBody", new DateTime(2020, 6, 11, 11, 4, 11, 415, DateTimeKind.Local).AddTicks(1351), "Test2", "SecondIPAddress", new DateTime(2020, 6, 11, 11, 4, 11, 415, DateTimeKind.Local).AddTicks(1388), "SecondReceiver", "SecondReplyTo", "SecondSender", new DateTime(2020, 6, 11, 11, 4, 11, 415, DateTimeKind.Local).AddTicks(1369), "SecondSubject", "SecondTrackerId" });
        }
    }
}
