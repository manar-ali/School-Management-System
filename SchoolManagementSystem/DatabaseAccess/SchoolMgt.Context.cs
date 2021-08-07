﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolMgtSysDbEntities : DbContext
    {
        public SchoolMgtSysDbEntities()
            : base("name=SchoolMgtSysDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AnnualTable> AnnualTables { get; set; }
        public virtual DbSet<ClassTable> ClassTables { get; set; }
        public virtual DbSet<DesignationTable> DesignationTables { get; set; }
        public virtual DbSet<EmployeeCertificationTable> EmployeeCertificationTables { get; set; }
        public virtual DbSet<EmployeeEducationTable> EmployeeEducationTables { get; set; }
        public virtual DbSet<EmployeeLanguageTable> EmployeeLanguageTables { get; set; }
        public virtual DbSet<EmployeeLeavingTable> EmployeeLeavingTables { get; set; }
        public virtual DbSet<EmployeeResumeTable> EmployeeResumeTables { get; set; }
        public virtual DbSet<EmployeeSalaryTable> EmployeeSalaryTables { get; set; }
        public virtual DbSet<EmployeeSkillTable> EmployeeSkillTables { get; set; }
        public virtual DbSet<EmployeeWorkExperienceTable> EmployeeWorkExperienceTables { get; set; }
        public virtual DbSet<EventTable> EventTables { get; set; }
        public virtual DbSet<ExamTable> ExamTables { get; set; }
        public virtual DbSet<ProgrameSessionTable> ProgrameSessionTables { get; set; }
        public virtual DbSet<ProgrameTable> ProgrameTables { get; set; }
        public virtual DbSet<SchoolLeavingTable> SchoolLeavingTables { get; set; }
        public virtual DbSet<SectionTable> SectionTables { get; set; }
        public virtual DbSet<SessionTable> SessionTables { get; set; }
        public virtual DbSet<StaffAttendanceTable> StaffAttendanceTables { get; set; }
        public virtual DbSet<StudentPromoteTable> StudentPromoteTables { get; set; }
        public virtual DbSet<SubjectTable> SubjectTables { get; set; }
        public virtual DbSet<SubmissionFeeTable> SubmissionFeeTables { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }
        public virtual DbSet<UserTypeTable> UserTypeTables { get; set; }
        public virtual DbSet<v_AllUsers> v_AllUsers { get; set; }
        public virtual DbSet<StaffTable> StaffTables { get; set; }
        public virtual DbSet<StudentTable> StudentTables { get; set; }
        public virtual DbSet<ExamMarksTable> ExamMarksTables { get; set; }
        public virtual DbSet<AttendanceTable> AttendanceTables { get; set; }
        public virtual DbSet<TimeTblTable> TimeTblTables { get; set; }
        public virtual DbSet<ExpensesTable> ExpensesTables { get; set; }
        public virtual DbSet<ExpenseTypeTable> ExpenseTypeTables { get; set; }
        public virtual DbSet<TBL_ADMIN> TBL_ADMIN { get; set; }
        public virtual DbSet<TBL_QUESTIONS> TBL_QUESTIONS { get; set; }
        public virtual DbSet<TBL_SETEXAM> TBL_SETEXAM { get; set; }
        public virtual DbSet<TBL_Scoe> TBL_Scoe { get; set; }
        public virtual DbSet<tbl_category> tbl_category { get; set; }
        public virtual DbSet<ClassSubjectTable> ClassSubjectTables { get; set; }
    }
}
