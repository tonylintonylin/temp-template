using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace temp.Data.Migrations
{
    public partial class projectEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 30, nullable: true),
                    TotalOrders = table.Column<int>(nullable: false),
                    Interest = table.Column<string>(maxLength: 500, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(nullable: true),
                    ChangedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ChangedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Alias = table.Column<string>(maxLength: 20, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    EmployeeNumber = table.Column<string>(maxLength: 40, nullable: true),
                    Department = table.Column<string>(maxLength: 40, nullable: true),
                    LastLoginDate = table.Column<DateTime>(nullable: true),
                    TotalThingsA = table.Column<int>(nullable: false),
                    TotalThingsB = table.Column<int>(nullable: false),
                    TotalThingsC = table.Column<int>(nullable: false),
                    TotalThingsD = table.Column<int>(nullable: false),
                    TotalThingsE = table.Column<int>(nullable: false),
                    Role = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "(user_name())"),
                    IdentityId = table.Column<string>(maxLength: 50, nullable: true),
                    IdentityName = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ActivationCode = table.Column<string>(maxLength: 30, nullable: true),
                    ActivationDate = table.Column<DateTime>(nullable: true),
                    ResetCode = table.Column<string>(maxLength: 30, nullable: true),
                    ResetDate = table.Column<DateTime>(nullable: true),
                    AppKey = table.Column<string>(maxLength: 50, nullable: true),
                    AppSecret = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(nullable: true),
                    ChangedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ChangedBy = table.Column<int>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Error",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: true),
                    ErrorDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Message = table.Column<string>(maxLength: 600, nullable: false),
                    Exception = table.Column<string>(nullable: true),
                    IpAddress = table.Column<string>(maxLength: 40, nullable: true),
                    Url = table.Column<string>(maxLength: 400, nullable: true),
                    HttpReferer = table.Column<string>(maxLength: 400, nullable: true),
                    UserAgent = table.Column<string>(maxLength: 400, nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(nullable: true),
                    ChangedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ChangedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Error", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ERROR_REFERENCE_USER",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    LoginDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Result = table.Column<string>(maxLength: 10, nullable: false),
                    IpAddress = table.Column<string>(maxLength: 40, nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(nullable: true),
                    ChangedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ChangedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LOGIN_REFERENCE_USER",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThingB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Text = table.Column<string>(maxLength: 40, nullable: true),
                    Lookup = table.Column<string>(maxLength: 40, nullable: true),
                    Money = table.Column<decimal>(type: "decimal(16, 2)", nullable: true),
                    DateTime = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(maxLength: 40, nullable: true),
                    Integer = table.Column<int>(nullable: true),
                    Boolean = table.Column<bool>(nullable: true),
                    LongText = table.Column<string>(nullable: true),
                    TotalThingsA = table.Column<int>(nullable: false),
                    OwnerId = table.Column<int>(nullable: false),
                    OwnerAlias = table.Column<string>(maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(nullable: true),
                    ChangedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ChangedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThingB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_THINGB_REFERENCE_USER",
                        column: x => x.OwnerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThingC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Text = table.Column<string>(maxLength: 40, nullable: true),
                    Lookup = table.Column<string>(maxLength: 40, nullable: true),
                    Money = table.Column<decimal>(type: "decimal(16, 2)", nullable: true),
                    DateTime = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(maxLength: 40, nullable: true),
                    Integer = table.Column<int>(nullable: true),
                    Boolean = table.Column<bool>(nullable: true),
                    LongText = table.Column<string>(nullable: true),
                    TotalThingsA = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    OwnerId = table.Column<int>(nullable: false),
                    OwnerAlias = table.Column<string>(maxLength: 20, nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(nullable: true),
                    ChangedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ChangedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThingC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAMPAIGN_REF2_USER",
                        column: x => x.OwnerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThingD",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Text = table.Column<string>(maxLength: 40, nullable: true),
                    Lookup = table.Column<string>(maxLength: 40, nullable: true),
                    Money = table.Column<decimal>(type: "decimal(16, 2)", nullable: true),
                    DateTime = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(maxLength: 40, nullable: true),
                    Integer = table.Column<int>(nullable: true),
                    Boolean = table.Column<bool>(nullable: true),
                    LongText = table.Column<string>(nullable: true),
                    TotalThingsE = table.Column<int>(nullable: false),
                    OwnerId = table.Column<int>(nullable: false),
                    OwnerAlias = table.Column<string>(maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(nullable: true),
                    ChangedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ChangedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThingD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_THINGD_REFERENCE_USER",
                        column: x => x.OwnerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Viewed",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    WhatId = table.Column<int>(nullable: false),
                    WhatType = table.Column<string>(maxLength: 20, nullable: false),
                    WhatName = table.Column<string>(maxLength: 120, nullable: true),
                    ViewDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(nullable: true),
                    ChangedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ChangedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viewed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VIEWED_REFERENCE_USER",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThingA",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ThingBId = table.Column<int>(nullable: true),
                    ThingBName = table.Column<string>(maxLength: 100, nullable: true),
                    ThingCId = table.Column<int>(nullable: true),
                    ThingCName = table.Column<string>(maxLength: 100, nullable: true),
                    Text = table.Column<string>(maxLength: 40, nullable: true),
                    Lookup = table.Column<string>(maxLength: 40, nullable: true),
                    Money = table.Column<decimal>(type: "decimal(16, 2)", nullable: true),
                    DateTime = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(maxLength: 40, nullable: true),
                    Integer = table.Column<int>(nullable: true),
                    Boolean = table.Column<bool>(nullable: true),
                    LongText = table.Column<string>(nullable: true),
                    TotalThingsE = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    OwnerId = table.Column<int>(nullable: false),
                    OwnerAlias = table.Column<string>(maxLength: 20, nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(nullable: true),
                    ChangedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ChangedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThingA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAMPAIGN_REF1_USER",
                        column: x => x.OwnerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_THINGA_REFERENCE_THINGB",
                        column: x => x.ThingBId,
                        principalTable: "ThingB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_THINGA_REFERENCE_THINGC",
                        column: x => x.ThingCId,
                        principalTable: "ThingC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThingE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ThingAId = table.Column<int>(nullable: true),
                    ThingAName = table.Column<string>(maxLength: 100, nullable: true),
                    ThingDId = table.Column<int>(nullable: true),
                    ThingDName = table.Column<string>(maxLength: 100, nullable: true),
                    Text = table.Column<string>(maxLength: 40, nullable: true),
                    Lookup = table.Column<string>(maxLength: 40, nullable: true),
                    Money = table.Column<decimal>(type: "decimal(16, 2)", nullable: true),
                    DateTime = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(maxLength: 40, nullable: true),
                    Integer = table.Column<int>(nullable: true),
                    Boolean = table.Column<bool>(nullable: true),
                    LongText = table.Column<string>(nullable: true),
                    OwnerId = table.Column<int>(nullable: false),
                    OwnerAlias = table.Column<string>(maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(nullable: true),
                    ChangedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ChangedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThingE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_THINGE_REFERENCE_USER",
                        column: x => x.OwnerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_THINGE_REFERENCE_THINGA",
                        column: x => x.ThingAId,
                        principalTable: "ThingA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_THINGE_REFERENCE_THINGD",
                        column: x => x.ThingDId,
                        principalTable: "ThingD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IndexCustomerCity",
                table: "Customer",
                column: "City");

            migrationBuilder.CreateIndex(
                name: "IndexCustomerCountry",
                table: "Customer",
                column: "Country");

            migrationBuilder.CreateIndex(
                name: "IndexCustomerEmail",
                table: "Customer",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IndexCustomerLastName",
                table: "Customer",
                column: "LastName");

            migrationBuilder.CreateIndex(
                name: "IndexCustomerPhone",
                table: "Customer",
                column: "Phone");

            migrationBuilder.CreateIndex(
                name: "IndexCustomerTotalOrders",
                table: "Customer",
                column: "TotalOrders");

            migrationBuilder.CreateIndex(
                name: "IndexErrorErrorDate",
                table: "Error",
                column: "ErrorDate");

            migrationBuilder.CreateIndex(
                name: "IX_Error_UserId",
                table: "Error",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IndexLoginLoginDate",
                table: "Login",
                column: "LoginDate");

            migrationBuilder.CreateIndex(
                name: "IndexLoginUserIdLoginDate",
                table: "Login",
                columns: new[] { "UserId", "LoginDate" });

            migrationBuilder.CreateIndex(
                name: "IndexThingALookup",
                table: "ThingA",
                column: "Lookup");

            migrationBuilder.CreateIndex(
                name: "IndexThingAName",
                table: "ThingA",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IndexThingAOwnerAlias",
                table: "ThingA",
                column: "OwnerAlias");

            migrationBuilder.CreateIndex(
                name: "IX_ThingA_OwnerId",
                table: "ThingA",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IndexThingAStatus",
                table: "ThingA",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IndexThingAText",
                table: "ThingA",
                column: "Text");

            migrationBuilder.CreateIndex(
                name: "IndexThingAThingBId",
                table: "ThingA",
                column: "ThingBId");

            migrationBuilder.CreateIndex(
                name: "IndexThingAThingBName",
                table: "ThingA",
                column: "ThingBName");

            migrationBuilder.CreateIndex(
                name: "IndexThingAThingCId",
                table: "ThingA",
                column: "ThingCId");

            migrationBuilder.CreateIndex(
                name: "IndexThingAThingCName",
                table: "ThingA",
                column: "ThingCName");

            migrationBuilder.CreateIndex(
                name: "IndexThingBDateTime",
                table: "ThingB",
                column: "DateTime");

            migrationBuilder.CreateIndex(
                name: "IndexThingBLookup",
                table: "ThingB",
                column: "Lookup");

            migrationBuilder.CreateIndex(
                name: "IndexThingBMoney",
                table: "ThingB",
                column: "Money");

            migrationBuilder.CreateIndex(
                name: "IndexThingBName",
                table: "ThingB",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IndexThingBOwnerAlias",
                table: "ThingB",
                column: "OwnerAlias");

            migrationBuilder.CreateIndex(
                name: "IX_ThingB_OwnerId",
                table: "ThingB",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IndexThingBStatus",
                table: "ThingB",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IndexThingBText",
                table: "ThingB",
                column: "Text");

            migrationBuilder.CreateIndex(
                name: "IndexThingCDateTime",
                table: "ThingC",
                column: "DateTime");

            migrationBuilder.CreateIndex(
                name: "IndexThingCLookup",
                table: "ThingC",
                column: "Lookup");

            migrationBuilder.CreateIndex(
                name: "IndexThingCMoney",
                table: "ThingC",
                column: "Money");

            migrationBuilder.CreateIndex(
                name: "IndexThingCName",
                table: "ThingC",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IndexThingCOwnerAlias",
                table: "ThingC",
                column: "OwnerAlias");

            migrationBuilder.CreateIndex(
                name: "IX_ThingC_OwnerId",
                table: "ThingC",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IndexThingCStatus",
                table: "ThingC",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IndexThingCText",
                table: "ThingC",
                column: "Text");

            migrationBuilder.CreateIndex(
                name: "IndexThingDDateTime",
                table: "ThingD",
                column: "DateTime");

            migrationBuilder.CreateIndex(
                name: "IndexThingDLookup",
                table: "ThingD",
                column: "Lookup");

            migrationBuilder.CreateIndex(
                name: "IndexThingDMoney",
                table: "ThingD",
                column: "Money");

            migrationBuilder.CreateIndex(
                name: "IndexThingDName",
                table: "ThingD",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IndexThingDOwnerAlias",
                table: "ThingD",
                column: "OwnerAlias");

            migrationBuilder.CreateIndex(
                name: "IX_ThingD_OwnerId",
                table: "ThingD",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IndexThingDStatus",
                table: "ThingD",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IndexThingDText",
                table: "ThingD",
                column: "Text");

            migrationBuilder.CreateIndex(
                name: "IndexThingELookup",
                table: "ThingE",
                column: "Lookup");

            migrationBuilder.CreateIndex(
                name: "IndexThingEMoney",
                table: "ThingE",
                column: "Money");

            migrationBuilder.CreateIndex(
                name: "IndexThingEName",
                table: "ThingE",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IndexThingEOwnerAlias",
                table: "ThingE",
                column: "OwnerAlias");

            migrationBuilder.CreateIndex(
                name: "IX_ThingE_OwnerId",
                table: "ThingE",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IndexThingEStatus",
                table: "ThingE",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IndexThingEText",
                table: "ThingE",
                column: "Text");

            migrationBuilder.CreateIndex(
                name: "IndexThingEObject1Id",
                table: "ThingE",
                column: "ThingAId");

            migrationBuilder.CreateIndex(
                name: "IndexThingEObjectAName",
                table: "ThingE",
                column: "ThingAName");

            migrationBuilder.CreateIndex(
                name: "IndexThingEObjectDId",
                table: "ThingE",
                column: "ThingDId");

            migrationBuilder.CreateIndex(
                name: "IndexThingEObjectDName",
                table: "ThingE",
                column: "ThingDName");

            migrationBuilder.CreateIndex(
                name: "IndexUserAlias",
                table: "User",
                column: "Alias",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IndexUserDepartment",
                table: "User",
                column: "Department");

            migrationBuilder.CreateIndex(
                name: "IndexUserEmail",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IndexUserEmployeeNumber",
                table: "User",
                column: "EmployeeNumber");

            migrationBuilder.CreateIndex(
                name: "IndexUserIdentityId",
                table: "User",
                column: "IdentityId");

            migrationBuilder.CreateIndex(
                name: "IndexUserIdentityName",
                table: "User",
                column: "IdentityName");

            migrationBuilder.CreateIndex(
                name: "IndexUserLastLoginDate",
                table: "User",
                column: "LastLoginDate");

            migrationBuilder.CreateIndex(
                name: "IndexUserLastName",
                table: "User",
                column: "LastName");

            migrationBuilder.CreateIndex(
                name: "IndexViewedWhatWhat",
                table: "Viewed",
                columns: new[] { "WhatId", "WhatType" });

            migrationBuilder.CreateIndex(
                name: "IndexViewedUserWhatWhat",
                table: "Viewed",
                columns: new[] { "UserId", "WhatId", "WhatType" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Error");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "ThingE");

            migrationBuilder.DropTable(
                name: "Viewed");

            migrationBuilder.DropTable(
                name: "ThingA");

            migrationBuilder.DropTable(
                name: "ThingD");

            migrationBuilder.DropTable(
                name: "ThingB");

            migrationBuilder.DropTable(
                name: "ThingC");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
