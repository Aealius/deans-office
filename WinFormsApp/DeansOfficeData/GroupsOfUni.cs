using System;
using System.Collections.Generic;

namespace WinFormsApp.DeansOfficeData;

public partial class GroupsOfUni
{
    public ushort Id { get; set; }

    public string NameOfGroup { get; set; } = null!;

    public string Speciality { get; set; } = null!;

    public int YearOfCreation { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
