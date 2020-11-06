using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ereader.Models
{
    public partial class eReaderNoLoginContext : DbContext
    {
        public eReaderNoLoginContext()
        {
        }

        public eReaderNoLoginContext(DbContextOptions<eReaderNoLoginContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<BanIp> BanIp { get; set; }
        public virtual DbSet<DeviceActive> DeviceActive { get; set; }
        public virtual DbSet<Level> Level { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<PageWhenExit> PageWhenExit { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<RightCategories> RightCategories { get; set; }
        public virtual DbSet<RightCategoryTypes> RightCategoryTypes { get; set; }
        public virtual DbSet<Rights> Rights { get; set; }
        public virtual DbSet<RolesInRights> RolesInRights { get; set; }
        public virtual DbSet<Score> Score { get; set; }
        public virtual DbSet<SentenceInPage> SentenceInPage { get; set; }
        public virtual DbSet<Theme> Theme { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<VersionApp> VersionApp { get; set; }
        public virtual DbSet<VersionInfo> VersionInfo { get; set; }
        public virtual DbSet<WebpagesMembershipss> WebpagesMembershipss { get; set; }
        public virtual DbSet<WebpagesRoles> WebpagesRoles { get; set; }
        public virtual DbSet<WebpagesRolesLocation> WebpagesRolesLocation { get; set; }
        public virtual DbSet<WebpagesUsersInRoles> WebpagesUsersInRoles { get; set; }
        public virtual DbSet<WordInPage> WordInPage { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ptud.dtponline.vn;Database=eReaderNoLogin;User Id=sa;Password=sa;Trusted_Connection=false;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.Property(e => e.Answer1)
                    .HasColumnName("Answer")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(13);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(13);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdQuestionNavigation)
                    .WithMany(p => p.Answer)
                    .HasForeignKey(d => d.IdQuestion)
                    .HasConstraintName("FK_Answer_Question");
            });

            modelBuilder.Entity<BanIp>(entity =>
            {
                entity.ToTable("BanIP");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.Ipadress)
                    .HasColumnName("IPAdress")
                    .HasMaxLength(20);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DeviceActive>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.IdDevice).HasMaxLength(100);

                entity.Property(e => e.KeyActive).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.Property(e => e.BgColor).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(13);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImageFile).HasColumnType("image");

                entity.Property(e => e.ImageName).HasMaxLength(255);

                entity.Property(e => e.ImageType).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(13);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdProduct).HasMaxLength(200);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(13);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImageFile).HasColumnType("image");

                entity.Property(e => e.ImageName).HasMaxLength(255);

                entity.Property(e => e.ImageType).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(13);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.VideoFile).HasColumnType("image");

                entity.Property(e => e.VideoName).HasMaxLength(255);

                entity.Property(e => e.VideoType).HasMaxLength(100);

                entity.HasOne(d => d.IdThemeNavigation)
                    .WithMany(p => p.Page)
                    .HasForeignKey(d => d.IdTheme)
                    .HasConstraintName("FK_Page_Theme");
            });

            modelBuilder.Entity<PageWhenExit>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.MobileId)
                    .HasColumnName("MobileID")
                    .HasMaxLength(50);

                entity.Property(e => e.NameTheme).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(200);

                entity.Property(e => e.AppName).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.ImageName).HasMaxLength(50);

                entity.Property(e => e.ImageType).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(13);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GameFile).HasColumnType("image");

                entity.Property(e => e.GameFolder).HasMaxLength(255);

                entity.Property(e => e.GameName).HasMaxLength(255);

                entity.Property(e => e.GameType).HasMaxLength(100);

                entity.Property(e => e.ImageFile).HasColumnType("image");

                entity.Property(e => e.ImageName).HasMaxLength(255);

                entity.Property(e => e.ImageType).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(13);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Question1).HasColumnName("Question");

                entity.HasOne(d => d.IdThemeNavigation)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.IdTheme)
                    .HasConstraintName("FK_Question_Theme");
            });

            modelBuilder.Entity<RightCategories>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("Type_Id");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.RightCategories)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_RightCategories_RightCategoryTypes");
            });

            modelBuilder.Entity<RightCategoryTypes>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Rights>(entity =>
            {
                entity.Property(e => e.RightsId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.Property(e => e.Controller).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.Label).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderIndex).HasDefaultValueSql("((0))");

                entity.Property(e => e.RightsDescription).HasMaxLength(500);

                entity.Property(e => e.RightsName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Rights)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Rights_RightCategories");
            });

            modelBuilder.Entity<RolesInRights>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Rights)
                    .WithMany(p => p.RolesInRights)
                    .HasForeignKey(d => d.RightsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolesInRights_Rights");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolesInRights)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolesInRights_webpages_Roles");
            });

            modelBuilder.Entity<Score>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.MobileId)
                    .HasColumnName("MobileID")
                    .HasMaxLength(50);

                entity.Property(e => e.NameTheme).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<SentenceInPage>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(13);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(13);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SoundFile).HasColumnType("image");

                entity.Property(e => e.SoundName).HasMaxLength(255);

                entity.Property(e => e.SoundType).HasMaxLength(100);

                entity.HasOne(d => d.IdPageNavigation)
                    .WithMany(p => p.SentenceInPage)
                    .HasForeignKey(d => d.IdPage)
                    .HasConstraintName("FK_SentenceInPage_Page");
            });

            modelBuilder.Entity<Theme>(entity =>
            {
                entity.Property(e => e.Author).HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(13);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.IdProduct).HasMaxLength(200);

                entity.Property(e => e.ImageFile).HasColumnType("image");

                entity.Property(e => e.ImageName).HasMaxLength(255);

                entity.Property(e => e.ImageType).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(13);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.PublishingHouse).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.IdLevelNavigation)
                    .WithMany(p => p.Theme)
                    .HasForeignKey(d => d.IdLevel)
                    .HasConstraintName("FK_Theme_Level");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(13);

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.ContentType).HasMaxLength(300);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.Images).HasColumnType("image");

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatusId).HasColumnName("Marital_Status_Id");

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.NameLogin).HasMaxLength(50);

                entity.Property(e => e.PassportIdNo)
                    .HasColumnName("Passport_IdNo")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.Property(e => e.UserEmailAddress).HasMaxLength(50);
            });

            modelBuilder.Entity<VersionApp>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(13);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(13);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<WebpagesMembershipss>(entity =>
            {
                entity.HasKey(e => e.MembershipId);

                entity.ToTable("webpages_Membershipss");

                entity.Property(e => e.MembershipId).HasMaxLength(13);

                entity.Property(e => e.ConfirmationToken).HasMaxLength(128);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastPasswordFailureDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordChangedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordVerificationToken).HasMaxLength(128);

                entity.Property(e => e.PasswordVerificationTokenExpirationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Membership)
                    .WithOne(p => p.WebpagesMembershipss)
                    .HasForeignKey<WebpagesMembershipss>(d => d.MembershipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_webpages_Membershipss_User");
            });

            modelBuilder.Entity<WebpagesRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("webpages_Roles");

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultAction)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Login')");

                entity.Property(e => e.DefaultController)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Account')");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RoleDescription).HasMaxLength(500);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoleOder).HasColumnName("roleOder");
            });

            modelBuilder.Entity<WebpagesRolesLocation>(entity =>
            {
                entity.ToTable("webpages_RolesLocation");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<WebpagesUsersInRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.ToTable("webpages_UsersInRoles");

                entity.Property(e => e.UserRoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.WebpagesUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_webpages_UsersInRoles_webpages_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebpagesUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_webpages_UsersInRoles_User");
            });

            modelBuilder.Entity<WordInPage>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(13);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(13);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Word).HasMaxLength(200);

                entity.HasOne(d => d.IdSentenceNavigation)
                    .WithMany(p => p.WordInPage)
                    .HasForeignKey(d => d.IdSentence)
                    .HasConstraintName("FK_WordInPage_SentenceInPage");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
