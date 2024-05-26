public class Video
{
    // Video attributes.
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    // Get / Set Methods.
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public int Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public List<Comment> Comments
    {
        get { return _comments; }
        set { _comments = value; }
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}