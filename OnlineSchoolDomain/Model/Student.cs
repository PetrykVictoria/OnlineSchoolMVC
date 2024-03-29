﻿using System;
using System.Collections.Generic;

namespace OnlineSchoolDomain.Model;

public partial class Student: Entity
{

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly DateBirth { get; set; }

    public byte ClassNumber { get; set; }

    public string? Charasteristic { get; set; }

    public virtual ICollection<StudentSubscription> StudentSubscriptions { get; set; } = new List<StudentSubscription>();

    public virtual ICollection<StudentTeacher> StudentTeachers { get; set; } = new List<StudentTeacher>();
}
