using System;
using System.Collections.Generic;

namespace OnlineSchoolDomain.Model;

public partial class Teacher: Entity
{

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public DateOnly DateBirth { get; set; }

    public virtual ICollection<TeacherSpecialization> TeacherSpecializations { get; set; } = new List<TeacherSpecialization>();
}
