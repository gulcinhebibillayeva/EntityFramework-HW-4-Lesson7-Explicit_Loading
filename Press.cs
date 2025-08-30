using System;
using System.Collections.Generic;

namespace ADO_NET_07_Homework_Explicit_Method;

public partial class Press
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
