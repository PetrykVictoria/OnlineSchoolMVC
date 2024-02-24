using System;
using System.Collections.Generic;

namespace OnlineSchoolDomain.Model;

public partial class TeacherSpecialization: Entity
{

    public int TeacherId { get; set; }

    public int SpecializationId { get; set; }

    public DateOnly StartDate { get; set; }

    public virtual Specialization Specialization { get; set; } = null!;

    public virtual ICollection<StudentTeacher> StudentTeachers { get; set; } = new List<StudentTeacher>();

    public virtual Teacher Teacher { get; set; } = null!;
}
