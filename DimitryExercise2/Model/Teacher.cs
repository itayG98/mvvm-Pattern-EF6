//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DimitryExercise2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Teacher : Person, INotifyPropertyChanged
    {
        private Courses courses;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher()
        {
            this.Students = new HashSet<Student>();
        }

        public Courses Courses
        {
            get => courses; set
            {
                courses = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Courses)));
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
