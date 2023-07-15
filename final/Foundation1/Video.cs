using System;
using System.Collections.Generic;

public class Video
{
    string _title;

    string _author;

    double _length;

    public List<Comment> comments;

    public string title
    {
        get { return _title; }
        set {_title = value;}
    }

    public string author
    {
        get { return _author; }
        set {_author = value;}
    }

    public double length
    {
        get { return _length; }
        set {_length = value;}
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

}