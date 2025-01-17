using System;

namespace exercise.wwwapi.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int NumPages { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
}
