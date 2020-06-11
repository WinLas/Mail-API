﻿// <auto-generated />
using System;
using Mail_API.Models.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mail_API.Migrations
{
    [DbContext(typeof(MailDbContext))]
    partial class MailDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mail_API.Models.Db.AttachmentFiles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("FileBytes")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("MailId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DbFiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FileBytes = new byte[] { 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100, 115, 100, 97, 97, 100, 115, 100, 97, 97, 100, 97, 115, 100, 97, 100 },
                            MailId = 1,
                            Name = "Attachment.txt"
                        });
                });

            modelBuilder.Entity("Mail_API.Models.Db.Mail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Attachments")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ErrorStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IPAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OpenTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Receiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReplyTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SentTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrackerId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DbMails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "FirstBody",
                            CreatedTime = new DateTime(2020, 6, 11, 11, 4, 11, 412, DateTimeKind.Local).AddTicks(6396),
                            ExternalId = "Test1",
                            IPAddress = "FirstIPAddress",
                            OpenTime = new DateTime(2020, 6, 11, 11, 4, 11, 414, DateTimeKind.Local).AddTicks(9740),
                            Receiver = "robin.eskilsson@winlas.se",
                            ReplyTo = "FirstReplyTo",
                            Sender = "no-reply@winlas.se",
                            SentTime = new DateTime(2020, 6, 11, 11, 4, 11, 414, DateTimeKind.Local).AddTicks(8931),
                            Status = 0,
                            Subject = "FirstSubject",
                            TrackerId = "FirstTrackerId"
                        },
                        new
                        {
                            Id = 2,
                            Body = "SecondBody",
                            CreatedTime = new DateTime(2020, 6, 11, 11, 4, 11, 415, DateTimeKind.Local).AddTicks(1351),
                            ExternalId = "Test2",
                            IPAddress = "SecondIPAddress",
                            OpenTime = new DateTime(2020, 6, 11, 11, 4, 11, 415, DateTimeKind.Local).AddTicks(1388),
                            Receiver = "SecondReceiver",
                            ReplyTo = "SecondReplyTo",
                            Sender = "SecondSender",
                            SentTime = new DateTime(2020, 6, 11, 11, 4, 11, 415, DateTimeKind.Local).AddTicks(1369),
                            Status = 0,
                            Subject = "SecondSubject",
                            TrackerId = "SecondTrackerId"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
