// Document 클래스.
using System;

public sealed class Document
{
    // Docuemt의 텍스트.
    public string Text { get; set; }

    // Document의 날짜.
    public DateTime DocumentDate { get; set; }

    // Document의 저자.
    public string Author { get; set; }
}