//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolMGTWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            this.Choices = new HashSet<Choice>();
            this.TestXQuestions = new HashSet<TestXQuestion>();
        }
    
        public int Id { get; set; }
        public int QuestionCategoryId { get; set; }
        public string QuestionType { get; set; }
        public string Question1 { get; set; }
        public Nullable<int> ExhibitId { get; set; }
        public int Points { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Choice> Choices { get; set; }
        public virtual Exhibit Exhibit { get; set; }
        public virtual QuestionCategory QuestionCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestXQuestion> TestXQuestions { get; set; }
    }
}