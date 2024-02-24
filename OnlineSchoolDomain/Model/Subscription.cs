using System;
using System.Collections.Generic;

namespace OnlineSchoolDomain.Model;

public partial class Subscription: Entity
{

    public byte NumberOfLessons { get; set; }

    public int Price { get; set; }

    public virtual ICollection<StudentSubscription> StudentSubscriptions { get; set; } = new List<StudentSubscription>();
}
