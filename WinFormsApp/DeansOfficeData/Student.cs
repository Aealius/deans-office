using System;
using System.Collections.Generic;

namespace WinFormsApp.DeansOfficeData;

public partial class Student
{
    public ushort SId { get; set; }

    public string Surname { get; set; } = null!;

    public string Sname { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime BirthYear { get; set; }

    public string Address { get; set; } = null!;

    public string RecBook { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public virtual GroupsOfUni GroupNameNavigation { get; set; } = null!;

    public virtual ICollection<Enrollment> Ens { get; set; } = new List<Enrollment>();

    public virtual ICollection<Pass> Passes { get; set; } = new List<Pass>();
}
