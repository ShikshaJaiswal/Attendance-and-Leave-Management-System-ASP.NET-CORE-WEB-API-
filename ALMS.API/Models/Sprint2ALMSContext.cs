using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ALMS.API.Models
{
    public partial class Sprint2ALMSContext : DbContext
    {
        public Sprint2ALMSContext()
        {
        }

        public Sprint2ALMSContext(DbContextOptions<Sprint2ALMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MsProjectLoginDetail> MsProjectLoginDetails { get; set; }
        public virtual DbSet<MsemployeeDetail> MsemployeeDetails { get; set; }
        public virtual DbSet<MslistOfHoliday> MslistOfHolidays { get; set; }
        public virtual DbSet<MsprojectDetail> MsprojectDetails { get; set; }
        public virtual DbSet<MsuserRegistration> MsuserRegistrations { get; set; }
        public virtual DbSet<TrattendanceDetail> TrattendanceDetails { get; set; }
        public virtual DbSet<TrleaveRequestDetail> TrleaveRequestDetails { get; set; }
        public virtual DbSet<TrprojectAllocation> TrprojectAllocations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8HC3KF0;Initial Catalog=Sprint2ALMS;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<MsProjectLoginDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectPassword)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                //entity.HasOne(d => d.Employee)
                //    .WithMany()
                //    .HasForeignKey(d => d.EmployeeId)
                //    .HasConstraintName("FK__MsProject__Emplo__4F47C5E3");

                //entity.HasOne(d => d.Project)
                //    .WithMany()
                //    .HasForeignKey(d => d.ProjectId)
                //    .HasConstraintName("FK__MsProject__Proje__4E53A1AA");
            });

            modelBuilder.Entity<MsemployeeDetail>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__MSEmploy__7AD04FF19BFCCCA7");

                entity.ToTable("MSEmployeeDetails");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeAge).HasComputedColumnSql("(floor(datediff(day,[EmployeeDOB],getdate())/(365)))", false);

                entity.Property(e => e.EmployeeDesignation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeDob)
                    .HasColumnType("date")
                    .HasColumnName("EmployeeDOB");

                entity.Property(e => e.EmployeeEmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeEmailID");

                entity.Property(e => e.EmployeeJoiningDate).HasColumnType("date");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MslistOfHoliday>(entity =>
            {
                entity.HasKey(e => e.HolidayId)
                    .HasName("PK__MSListOf__2D35D59AA21924E3");

                entity.ToTable("MSListOfHolidays");

                entity.Property(e => e.HolidayId).HasColumnName("HolidayID");

                entity.Property(e => e.HolidayDate).HasColumnType("date");

                entity.Property(e => e.HolidayName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MsprojectDetail>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("PK__MSProjec__761ABED0F9DEA243");

                entity.ToTable("MSProjectDetails");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectEndDate).HasColumnType("date");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectStartDate).HasColumnType("date");

                entity.Property(e => e.ProjectTechnology)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsuserRegistration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSUserRegistration");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                //entity.HasOne(d => d.Employee)
                //    .WithMany()
                //    .HasForeignKey(d => d.EmployeeId)
                //    .HasConstraintName("FK__MSUserReg__Emplo__2EDAF651");
            });

            modelBuilder.Entity<TrattendanceDetail>(entity =>
            {
                entity.HasKey(e => e.AttendanceId)
                    .HasName("PK__TRAttend__8B69263CBD870934");

                entity.ToTable("TRAttendanceDetails");

                entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");

                entity.Property(e => e.AttedanceDate).HasColumnType("datetime");

                entity.Property(e => e.AttendanceStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Pending')");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.StatusUpdateDate).HasColumnType("date");

                //entity.HasOne(d => d.Employee)
                //    .WithMany(p => p.TrattendanceDetails)
                //    .HasForeignKey(d => d.EmployeeId)
                //    .HasConstraintName("FK__TRAttenda__Emplo__3D2915A8");

                //entity.HasOne(d => d.Project)
                //    .WithMany(p => p.TrattendanceDetails)
                //    .HasForeignKey(d => d.ProjectId)
                //    .HasConstraintName("FK__TRAttenda__Proje__3C34F16F");
            });

            modelBuilder.Entity<TrleaveRequestDetail>(entity =>
            {
                entity.HasKey(e => e.LeaveRequestId)
                    .HasName("PK__TRLeaveR__6094218EB505118B");

                entity.ToTable("TRLeaveRequestDetails");

                entity.Property(e => e.LeaveRequestId).HasColumnName("LeaveRequestID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LeaveDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveRequestCreatedDate).HasColumnType("date");

                entity.Property(e => e.LeaveRequestFrom).HasColumnType("date");

                entity.Property(e => e.LeaveRequestTo).HasColumnType("date");

                entity.Property(e => e.LeaveStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Pending')");

                entity.Property(e => e.LeaveStatusUpdateDate).HasColumnType("date");

                //entity.HasOne(d => d.Employee)
                //    .WithMany(p => p.TrleaveRequestDetails)
                //    .HasForeignKey(d => d.EmployeeId)
                //    .HasConstraintName("FK__TRLeaveRe__Emplo__531856C7");
            });

            modelBuilder.Entity<TrprojectAllocation>(entity =>
            {
                entity.HasKey(e => e.AllocationId)
                    .HasName("PK__TRProjec__B3C6D64BA7EFCFED");

                entity.ToTable("TRProjectAllocation");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                //entity.HasOne(d => d.Employee)
                //    .WithMany(p => p.TrprojectAllocations)
                //    .HasForeignKey(d => d.EmployeeId)
                //    .HasConstraintName("FK__TRProject__Emplo__634EBE90");

                //entity.HasOne(d => d.Project)
                //    .WithMany(p => p.TrprojectAllocations)
                //    .HasForeignKey(d => d.ProjectId)
                //    .HasConstraintName("FK__TRProject__Proje__625A9A57");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
