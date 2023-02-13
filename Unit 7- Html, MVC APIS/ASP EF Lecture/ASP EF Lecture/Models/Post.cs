using System;
using System.Collections.Generic;

namespace ASP_EF_Lecture.Models;

public partial class Post
{
    public int Id { get; set; }

    public string? Author { get; set; }

    public string? Content { get; set; }

    public int? Likes { get; set; }

    public DateTime? DatePosted { get; set; }
}
