using System;

public class Comment
{
    private string commenterName;
    private string commentText;

    public Comment(string name, string text)
    {
        commenterName = name;
        commentText = text;
    }

    public string GetCommentInfo()
    {
        return $"{commenterName}: {commentText}";
    }
}
