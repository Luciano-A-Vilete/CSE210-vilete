using System;
using System.Collections.Generic;

// Comment class.
public class Comment
{
    // User name.
    private string _userName;
    // Comment text
    private string _text;

    public string UserName
    {
        get { return _userName; }
        set { _userName = value; }
    }

    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }
}