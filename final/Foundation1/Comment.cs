using System;

public class Comment
{
    string _commenterName;

    string _text;

    public string commenterName
    {
        get { return _commenterName; }
        set { _commenterName = value;}
    }

    public string text
    {
        get { return _text; }
        set { _text = value;}
    }
}