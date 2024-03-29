﻿using System;
using System.Collections.Generic;

namespace OnlineSchoolDomain.Model;

public partial class StudentTeacher: Entity
{
    public int StudentId { get; set; }

    public int TeacherSpecializationId { get; set; }

    public DateOnly StartingDate { get; set; }

    public byte NumberOfLessons { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual TeacherSpecialization TeacherSpecialization { get; set; } = null!;
}
