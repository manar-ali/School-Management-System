//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class StudentTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentTable()
        {
            this.SchoolLeavingTables = new HashSet<SchoolLeavingTable>();
            this.StudentPromoteTables = new HashSet<StudentPromoteTable>();
            this.SubmissionFeeTables = new HashSet<SubmissionFeeTable>();
            this.ExamMarksTables = new HashSet<ExamMarksTable>();
            this.AttendanceTables = new HashSet<AttendanceTable>();
            this.TBL_SETEXAM = new HashSet<TBL_SETEXAM>();
            this.TBL_Scoe = new HashSet<TBL_Scoe>();
        }
        [NotMapped]
        [Required(ErrorMessage = "Please Select Student Photo  ")]
        public HttpPostedFileBase PhotoFile { get; set; }
        public int StudentID { get; set; }
        [Required(ErrorMessage = "Please Select Session")]
        public int SessionID { get; set; }
        [Required(ErrorMessage = "Please Select Programe")]
        public int ProgrameID { get; set; }
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please Select Current Class")]
        public int ClassID { get; set; }
        [Required(ErrorMessage = "Please Enter Student Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Father Name")]
        public string FatherName { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime DateofBirth { get; set; }
        [Required(ErrorMessage = "Please Enter Gender ")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Enter Contact No ")]
        public string ContactNo { get; set; }
        [Required(ErrorMessage = "Please Enter CNIC ")]
        public string CNIC { get; set; }
        [Required(ErrorMessage = "Please Enter Fther CNIC ")]
        public string FNIC { get; set; }
        public string Photo { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime AddimissionDate { get; set; }
        [Required(ErrorMessage = "Please Enter Previous School ")]
        public string PreviousSchool { get; set; }
        public Nullable<double> PreviousPercentage { get; set; }
        [Required(ErrorMessage = "Please Enter Email Address  ")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Please Enter Permanent Address  ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter Father Occupationo  ")]
        public string FathersGuardinasOccupationofProffision { get; set; }
        [Required(ErrorMessage = "Please Enter Nationality  ")]
        public string Nationality { get; set; }
        [Required(ErrorMessage = "Please Enter Religion  ")]
        public string Religion { get; set; }
        [Required(ErrorMessage = "Please Enter Caste  ")]
        public string TribeorCaste { get; set; }
        [Required(ErrorMessage = "Please Enter  Postal Adress  ")]
        public string FathersGuardinasPostalAdress { get; set; }
        [Required(ErrorMessage = "Please Enter  Phone Office ")]
        public string PhoneOffice { get; set; }
        [Required(ErrorMessage = "Please Enter Resident ")]
        public string PhoneResident { get; set; }
    
        public virtual ClassTable ClassTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchoolLeavingTable> SchoolLeavingTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentPromoteTable> StudentPromoteTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubmissionFeeTable> SubmissionFeeTables { get; set; }
        public virtual ProgrameTable ProgrameTable { get; set; }
        public virtual SessionTable SessionTable { get; set; }
        public virtual UserTable UserTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamMarksTable> ExamMarksTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttendanceTable> AttendanceTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SETEXAM> TBL_SETEXAM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Scoe> TBL_Scoe { get; set; }
    }
}
