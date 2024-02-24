using System;
using System.Collections.Generic;

namespace OnlineSchoolDomain.Model;

public partial class Specialization: Entity
{

    public string SpecializationName { get; set; } = null!;

    public virtual ICollection<TeacherSpecialization> TeacherSpecializations { get; set; } = new List<TeacherSpecialization>();
}
