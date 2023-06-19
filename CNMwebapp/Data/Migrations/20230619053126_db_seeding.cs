using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CNMwebapp.Data.Migrations
{
    public partial class db_seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Jobs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Uid", "Date", "Name", "WorkersNeeded" },
                values: new object[,]
                {
                    { "0daca6a7-ff28-4242-ba9b-304cfa4df2b1", new DateTime(2023, 7, 20, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "0dcbac84-0922-4751-8145-23bb2dfd2ce8", new DateTime(2023, 8, 23, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "11ecbd72-6fd0-4ea3-a8c3-e1ed2302217b", new DateTime(2023, 7, 23, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "13089067-26fe-436d-986d-54f14209932a", new DateTime(2023, 8, 13, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "2136e035-17b9-4b29-aa47-fdbd18341e93", new DateTime(2023, 8, 29, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "2506cb9e-d954-432c-8ce0-c286bc6e1e0e", new DateTime(2023, 6, 28, 7, 15, 0, 0, DateTimeKind.Unspecified), "Balaton Sound", 6 },
                    { "2bf2cc34-e31a-4318-8f36-dd0765769c05", new DateTime(2023, 7, 24, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "2ef24374-60b5-476b-9a19-d74daff46b96", new DateTime(2023, 8, 6, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "325c440c-acd3-49c0-8e4b-17eaefd74017", new DateTime(2023, 8, 24, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "329ed365-3ca8-4506-a01b-6e0644e1d9d0", new DateTime(2023, 7, 10, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "34acbdc3-8bfe-4d06-b6c2-8ba4ba8fe70a", new DateTime(2023, 8, 31, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "34cefd03-d722-42a8-ad51-9f096395ff35", new DateTime(2023, 8, 16, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "3c8dee3f-3b14-4d12-92d9-0de8247a8883", new DateTime(2023, 7, 12, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "4387f9ee-5077-4bf7-8260-8007b42fa8d1", new DateTime(2023, 8, 21, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "43a21341-4d2c-49ef-a6e3-5cbdc7ef054f", new DateTime(2023, 8, 20, 7, 15, 0, 0, DateTimeKind.Unspecified), "20.-i tüzijáték", 5 },
                    { "4b61fde1-9772-48a4-af3d-97cdd3ae4205", new DateTime(2023, 8, 26, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "52d1b7c1-f4db-4da0-871a-acb4cd80380b", new DateTime(2023, 8, 2, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "574b4e7e-898a-4a08-9384-c1391517d7dd", new DateTime(2023, 7, 27, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "6195e1cf-5c35-4ac3-8ed9-60d68e4c7de7", new DateTime(2023, 8, 30, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "6338c9f9-95f7-43a3-bc9d-5c5cf712a104", new DateTime(2023, 8, 7, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "689ee8e2-494a-4b8a-9b66-59b31e432918", new DateTime(2023, 7, 14, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "6bf62fd7-d5f8-4034-b7e2-10d375319246", new DateTime(2023, 8, 25, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "7982b9b0-7a55-4290-bac2-7f4804214c78", new DateTime(2023, 8, 9, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "83db01cb-530f-40f1-ab41-7ae40509947a", new DateTime(2023, 8, 10, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "83f75cb3-b671-48ae-b9fc-32776407d196", new DateTime(2023, 8, 14, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "83f8d57c-7776-4dc9-a947-7dc08fc7eb04", new DateTime(2023, 6, 27, 7, 15, 0, 0, DateTimeKind.Unspecified), "Balaton Sound", 6 },
                    { "880e0215-7558-4348-bbe7-25daf0625741", new DateTime(2023, 8, 12, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "8afc6d83-7e85-4db8-be1c-0111a99e7e09", new DateTime(2023, 8, 3, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "8d66581b-14cf-4552-bb0f-fd7f57d54222", new DateTime(2023, 6, 29, 7, 15, 0, 0, DateTimeKind.Unspecified), "Balaton Sound", 6 },
                    { "9cee3e8b-da52-49dd-8063-26787c8f7119", new DateTime(2023, 7, 22, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "9e14ae2f-e84a-4e21-90a1-116cff1bfd34", new DateTime(2023, 7, 16, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "ab13b3a6-ca39-4cf4-bf67-6f24fc8514ce", new DateTime(2023, 8, 4, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "ad2428af-91ac-49f9-8ccc-6a77d0b5c57f", new DateTime(2023, 7, 30, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "addcaa53-5607-407d-b0cd-85b5b76d191d", new DateTime(2023, 7, 15, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "aee36bcf-f5f5-419d-8f4a-d054aa784a67", new DateTime(2023, 7, 28, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "af52012d-29b9-4684-b8c1-516330aa2091", new DateTime(2023, 8, 8, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "b031413c-5c85-44e7-a5a5-864156f425a1", new DateTime(2023, 7, 19, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "b0963d59-b0d4-4364-84b0-cb8ff5702069", new DateTime(2023, 7, 26, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "b448f253-629c-44ac-a5c5-9a4ca140012d", new DateTime(2023, 7, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), "Balaton Sound", 6 },
                    { "b4eb0bbf-1e6c-4e96-93b1-fdc5d22d8ade", new DateTime(2023, 7, 18, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "bee3e114-0c72-46dd-bb79-90a365b9d534", new DateTime(2023, 8, 11, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "c3dfe418-00fd-488e-bd0b-ff68448d2191", new DateTime(2023, 7, 29, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Uid", "Date", "Name", "WorkersNeeded" },
                values: new object[,]
                {
                    { "c40a7466-82ca-4598-9dc4-427ba70440ba", new DateTime(2023, 8, 27, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "c7805efa-f3a6-4e90-930e-24d26c18b0ae", new DateTime(2023, 7, 17, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "c803cb89-f08e-4921-b0a9-b8fbad409216", new DateTime(2023, 8, 17, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "c93cd2a5-82c9-4c1d-8ec2-080defee8d36", new DateTime(2023, 8, 15, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "c94681db-6c76-4db3-ad22-4bcf892faa17", new DateTime(2023, 6, 26, 7, 15, 0, 0, DateTimeKind.Unspecified), "Balaton Sound", 6 },
                    { "cc082745-4759-4182-aa76-48f8965745b7", new DateTime(2023, 7, 21, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "cc2277e2-fb65-4ce0-b82e-57ce03d08fe1", new DateTime(2023, 8, 19, 7, 15, 0, 0, DateTimeKind.Unspecified), "20.-i tüzijáték", 5 },
                    { "d1590569-e1a6-4c84-a5ef-eadf73fda62e", new DateTime(2023, 8, 28, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "d160173f-d19d-496c-bf56-47c6cb259eae", new DateTime(2023, 7, 31, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "d4451f30-0103-4b80-89d2-c7b06a267e98", new DateTime(2023, 8, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "d749cd00-5832-4cae-a9a4-af36c81012b0", new DateTime(2023, 7, 13, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "db39369b-080f-437b-9690-f61e51539063", new DateTime(2023, 7, 25, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "dbaef5c0-0894-41c7-be61-47de30ef75bb", new DateTime(2023, 7, 11, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "deb45ae8-a09e-40ad-8d72-60aa771db235", new DateTime(2023, 8, 18, 7, 15, 0, 0, DateTimeKind.Unspecified), "20.-i tüzijáték", 5 },
                    { "ed50dd9c-fb33-4389-8636-f273707dccd3", new DateTime(2023, 8, 5, 7, 15, 0, 0, DateTimeKind.Unspecified), "Sziget", 8 },
                    { "fb8aac58-ecc6-41fc-badd-6cc0e054bda3", new DateTime(2023, 8, 22, 7, 15, 0, 0, DateTimeKind.Unspecified), "Atlétikai VB", 3 },
                    { "fd68479f-f351-4de7-9006-7c10135ff761", new DateTime(2023, 6, 30, 7, 15, 0, 0, DateTimeKind.Unspecified), "Balaton Sound", 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "0daca6a7-ff28-4242-ba9b-304cfa4df2b1");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "0dcbac84-0922-4751-8145-23bb2dfd2ce8");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "11ecbd72-6fd0-4ea3-a8c3-e1ed2302217b");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "13089067-26fe-436d-986d-54f14209932a");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "2136e035-17b9-4b29-aa47-fdbd18341e93");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "2506cb9e-d954-432c-8ce0-c286bc6e1e0e");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "2bf2cc34-e31a-4318-8f36-dd0765769c05");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "2ef24374-60b5-476b-9a19-d74daff46b96");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "325c440c-acd3-49c0-8e4b-17eaefd74017");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "329ed365-3ca8-4506-a01b-6e0644e1d9d0");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "34acbdc3-8bfe-4d06-b6c2-8ba4ba8fe70a");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "34cefd03-d722-42a8-ad51-9f096395ff35");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "3c8dee3f-3b14-4d12-92d9-0de8247a8883");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "4387f9ee-5077-4bf7-8260-8007b42fa8d1");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "43a21341-4d2c-49ef-a6e3-5cbdc7ef054f");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "4b61fde1-9772-48a4-af3d-97cdd3ae4205");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "52d1b7c1-f4db-4da0-871a-acb4cd80380b");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "574b4e7e-898a-4a08-9384-c1391517d7dd");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "6195e1cf-5c35-4ac3-8ed9-60d68e4c7de7");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "6338c9f9-95f7-43a3-bc9d-5c5cf712a104");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "689ee8e2-494a-4b8a-9b66-59b31e432918");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "6bf62fd7-d5f8-4034-b7e2-10d375319246");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "7982b9b0-7a55-4290-bac2-7f4804214c78");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "83db01cb-530f-40f1-ab41-7ae40509947a");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "83f75cb3-b671-48ae-b9fc-32776407d196");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "83f8d57c-7776-4dc9-a947-7dc08fc7eb04");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "880e0215-7558-4348-bbe7-25daf0625741");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "8afc6d83-7e85-4db8-be1c-0111a99e7e09");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "8d66581b-14cf-4552-bb0f-fd7f57d54222");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "9cee3e8b-da52-49dd-8063-26787c8f7119");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "9e14ae2f-e84a-4e21-90a1-116cff1bfd34");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "ab13b3a6-ca39-4cf4-bf67-6f24fc8514ce");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "ad2428af-91ac-49f9-8ccc-6a77d0b5c57f");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "addcaa53-5607-407d-b0cd-85b5b76d191d");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "aee36bcf-f5f5-419d-8f4a-d054aa784a67");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "af52012d-29b9-4684-b8c1-516330aa2091");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "b031413c-5c85-44e7-a5a5-864156f425a1");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "b0963d59-b0d4-4364-84b0-cb8ff5702069");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "b448f253-629c-44ac-a5c5-9a4ca140012d");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "b4eb0bbf-1e6c-4e96-93b1-fdc5d22d8ade");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "bee3e114-0c72-46dd-bb79-90a365b9d534");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "c3dfe418-00fd-488e-bd0b-ff68448d2191");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "c40a7466-82ca-4598-9dc4-427ba70440ba");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "c7805efa-f3a6-4e90-930e-24d26c18b0ae");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "c803cb89-f08e-4921-b0a9-b8fbad409216");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "c93cd2a5-82c9-4c1d-8ec2-080defee8d36");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "c94681db-6c76-4db3-ad22-4bcf892faa17");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "cc082745-4759-4182-aa76-48f8965745b7");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "cc2277e2-fb65-4ce0-b82e-57ce03d08fe1");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "d1590569-e1a6-4c84-a5ef-eadf73fda62e");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "d160173f-d19d-496c-bf56-47c6cb259eae");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "d4451f30-0103-4b80-89d2-c7b06a267e98");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "d749cd00-5832-4cae-a9a4-af36c81012b0");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "db39369b-080f-437b-9690-f61e51539063");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "dbaef5c0-0894-41c7-be61-47de30ef75bb");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "deb45ae8-a09e-40ad-8d72-60aa771db235");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "ed50dd9c-fb33-4389-8636-f273707dccd3");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "fb8aac58-ecc6-41fc-badd-6cc0e054bda3");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Uid",
                keyValue: "fd68479f-f351-4de7-9006-7c10135ff761");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
