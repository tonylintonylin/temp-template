using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace temp.Domain
{
    public partial class tempContext : DbContext
    {
        public tempContext()
        {
        }

        public tempContext(DbContextOptions<tempContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Error> Error { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<ThingA> ThingA { get; set; }
        public virtual DbSet<ThingB> ThingB { get; set; }
        public virtual DbSet<ThingC> ThingC { get; set; }
        public virtual DbSet<ThingD> ThingD { get; set; }
        public virtual DbSet<ThingE> ThingE { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Viewed> Viewed { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\tonyl\\Desktop\\temp\\temp\\Data\\temp.mdf;Integrated Security=True;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.City)
                    .HasName("IndexCustomerCity");

                entity.HasIndex(e => e.Country)
                    .HasName("IndexCustomerCountry");

                entity.HasIndex(e => e.Email)
                    .HasName("IndexCustomerEmail");

                entity.HasIndex(e => e.LastName)
                    .HasName("IndexCustomerLastName");

                entity.HasIndex(e => e.Phone)
                    .HasName("IndexCustomerPhone");

                entity.HasIndex(e => e.TotalOrders)
                    .HasName("IndexCustomerTotalOrders");

                entity.Property(e => e.ChangedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Interest).HasMaxLength(500);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(30);
            });

            modelBuilder.Entity<Error>(entity =>
            {
                entity.HasIndex(e => e.ErrorDate)
                    .HasName("IndexErrorErrorDate");

                entity.Property(e => e.ChangedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HttpReferer).HasMaxLength(400);

                entity.Property(e => e.IpAddress).HasMaxLength(40);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(600);

                entity.Property(e => e.Url).HasMaxLength(400);

                entity.Property(e => e.UserAgent).HasMaxLength(400);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Error)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ERROR_REFERENCE_USER");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasIndex(e => e.LoginDate)
                    .HasName("IndexLoginLoginDate");

                entity.HasIndex(e => new { e.UserId, e.LoginDate })
                    .HasName("IndexLoginUserIdLoginDate");

                entity.Property(e => e.ChangedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.IpAddress).HasMaxLength(40);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LoginDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Login)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_LOGIN_REFERENCE_USER");
            });

            modelBuilder.Entity<ThingA>(entity =>
            {
                entity.HasIndex(e => e.Lookup)
                    .HasName("IndexThingALookup");

                entity.HasIndex(e => e.Name)
                    .HasName("IndexThingAName");

                entity.HasIndex(e => e.OwnerAlias)
                    .HasName("IndexThingAOwnerAlias");

                entity.HasIndex(e => e.Status)
                    .HasName("IndexThingAStatus");

                entity.HasIndex(e => e.Text)
                    .HasName("IndexThingAText");

                entity.HasIndex(e => e.ThingBId)
                    .HasName("IndexThingAThingBId");

                entity.HasIndex(e => e.ThingBName)
                    .HasName("IndexThingAThingBName");

                entity.HasIndex(e => e.ThingCId)
                    .HasName("IndexThingAThingCId");

                entity.HasIndex(e => e.ThingCName)
                    .HasName("IndexThingAThingCName");

                entity.Property(e => e.ChangedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lookup).HasMaxLength(40);

                entity.Property(e => e.Money).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerAlias)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(40);

                entity.Property(e => e.Text).HasMaxLength(40);

                entity.Property(e => e.ThingBName).HasMaxLength(100);

                entity.Property(e => e.ThingCName).HasMaxLength(100);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.ThingA)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CAMPAIGN_REF1_USER");

                entity.HasOne(d => d.ThingB)
                    .WithMany(p => p.ThingA)
                    .HasForeignKey(d => d.ThingBId)
                    .HasConstraintName("FK_THINGA_REFERENCE_THINGB");

                entity.HasOne(d => d.ThingC)
                    .WithMany(p => p.ThingA)
                    .HasForeignKey(d => d.ThingCId)
                    .HasConstraintName("FK_THINGA_REFERENCE_THINGC");
            });

            modelBuilder.Entity<ThingB>(entity =>
            {
                entity.HasIndex(e => e.DateTime)
                    .HasName("IndexThingBDateTime");

                entity.HasIndex(e => e.Lookup)
                    .HasName("IndexThingBLookup");

                entity.HasIndex(e => e.Money)
                    .HasName("IndexThingBMoney");

                entity.HasIndex(e => e.Name)
                    .HasName("IndexThingBName");

                entity.HasIndex(e => e.OwnerAlias)
                    .HasName("IndexThingBOwnerAlias");

                entity.HasIndex(e => e.Status)
                    .HasName("IndexThingBStatus");

                entity.HasIndex(e => e.Text)
                    .HasName("IndexThingBText");

                entity.Property(e => e.ChangedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lookup).HasMaxLength(40);

                entity.Property(e => e.Money).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerAlias)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(40);

                entity.Property(e => e.Text).HasMaxLength(40);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.ThingB)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_THINGB_REFERENCE_USER");
            });

            modelBuilder.Entity<ThingC>(entity =>
            {
                entity.HasIndex(e => e.DateTime)
                    .HasName("IndexThingCDateTime");

                entity.HasIndex(e => e.Lookup)
                    .HasName("IndexThingCLookup");

                entity.HasIndex(e => e.Money)
                    .HasName("IndexThingCMoney");

                entity.HasIndex(e => e.Name)
                    .HasName("IndexThingCName");

                entity.HasIndex(e => e.OwnerAlias)
                    .HasName("IndexThingCOwnerAlias");

                entity.HasIndex(e => e.Status)
                    .HasName("IndexThingCStatus");

                entity.HasIndex(e => e.Text)
                    .HasName("IndexThingCText");

                entity.Property(e => e.ChangedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lookup).HasMaxLength(40);

                entity.Property(e => e.Money).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.OwnerAlias)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(40);

                entity.Property(e => e.Text).HasMaxLength(40);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.ThingC)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CAMPAIGN_REF2_USER");
            });

            modelBuilder.Entity<ThingD>(entity =>
            {
                entity.HasIndex(e => e.DateTime)
                    .HasName("IndexThingDDateTime");

                entity.HasIndex(e => e.Lookup)
                    .HasName("IndexThingDLookup");

                entity.HasIndex(e => e.Money)
                    .HasName("IndexThingDMoney");

                entity.HasIndex(e => e.Name)
                    .HasName("IndexThingDName");

                entity.HasIndex(e => e.OwnerAlias)
                    .HasName("IndexThingDOwnerAlias");

                entity.HasIndex(e => e.Status)
                    .HasName("IndexThingDStatus");

                entity.HasIndex(e => e.Text)
                    .HasName("IndexThingDText");

                entity.Property(e => e.ChangedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lookup).HasMaxLength(40);

                entity.Property(e => e.Money).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerAlias)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(40);

                entity.Property(e => e.Text).HasMaxLength(40);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.ThingD)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_THINGD_REFERENCE_USER");
            });

            modelBuilder.Entity<ThingE>(entity =>
            {
                entity.HasIndex(e => e.Lookup)
                    .HasName("IndexThingELookup");

                entity.HasIndex(e => e.Money)
                    .HasName("IndexThingEMoney");

                entity.HasIndex(e => e.Name)
                    .HasName("IndexThingEName");

                entity.HasIndex(e => e.OwnerAlias)
                    .HasName("IndexThingEOwnerAlias");

                entity.HasIndex(e => e.Status)
                    .HasName("IndexThingEStatus");

                entity.HasIndex(e => e.Text)
                    .HasName("IndexThingEText");

                entity.HasIndex(e => e.ThingAId)
                    .HasName("IndexThingEObject1Id");

                entity.HasIndex(e => e.ThingAName)
                    .HasName("IndexThingEObjectAName");

                entity.HasIndex(e => e.ThingDId)
                    .HasName("IndexThingEObjectDId");

                entity.HasIndex(e => e.ThingDName)
                    .HasName("IndexThingEObjectDName");

                entity.Property(e => e.ChangedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lookup).HasMaxLength(40);

                entity.Property(e => e.Money).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerAlias)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(40);

                entity.Property(e => e.Text).HasMaxLength(40);

                entity.Property(e => e.ThingAName).HasMaxLength(100);

                entity.Property(e => e.ThingDName).HasMaxLength(100);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.ThingE)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_THINGE_REFERENCE_USER");

                entity.HasOne(d => d.ThingA)
                    .WithMany(p => p.ThingE)
                    .HasForeignKey(d => d.ThingAId)
                    .HasConstraintName("FK_THINGE_REFERENCE_THINGA");

                entity.HasOne(d => d.ThingD)
                    .WithMany(p => p.ThingE)
                    .HasForeignKey(d => d.ThingDId)
                    .HasConstraintName("FK_THINGE_REFERENCE_THINGD");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_USER")
                    .IsClustered(false);

                entity.HasIndex(e => e.Alias)
                    .HasName("IndexUserAlias")
                    .IsUnique();

                entity.HasIndex(e => e.Department)
                    .HasName("IndexUserDepartment");

                entity.HasIndex(e => e.Email)
                    .HasName("IndexUserEmail")
                    .IsUnique();

                entity.HasIndex(e => e.EmployeeNumber)
                    .HasName("IndexUserEmployeeNumber");

                entity.HasIndex(e => e.IdentityId)
                    .HasName("IndexUserIdentityId");

                entity.HasIndex(e => e.IdentityName)
                    .HasName("IndexUserIdentityName");

                entity.HasIndex(e => e.LastLoginDate)
                    .HasName("IndexUserLastLoginDate");

                entity.HasIndex(e => e.LastName)
                    .HasName("IndexUserLastName");

                entity.Property(e => e.ActivationCode).HasMaxLength(30);

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AppKey).HasMaxLength(50);

                entity.Property(e => e.AppSecret).HasMaxLength(100);

                entity.Property(e => e.ChangedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Department).HasMaxLength(40);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeNumber).HasMaxLength(40);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdentityId).HasMaxLength(50);

                entity.Property(e => e.IdentityName).HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ResetCode).HasMaxLength(30);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(user_name())");
            });

            modelBuilder.Entity<Viewed>(entity =>
            {
                entity.HasIndex(e => new { e.WhatId, e.WhatType })
                    .HasName("IndexViewedWhatWhat");

                entity.HasIndex(e => new { e.UserId, e.WhatId, e.WhatType })
                    .HasName("IndexViewedUserWhatWhat");

                entity.Property(e => e.ChangedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ViewDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WhatName).HasMaxLength(120);

                entity.Property(e => e.WhatType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Viewed)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VIEWED_REFERENCE_USER");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
