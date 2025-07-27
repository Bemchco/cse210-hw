public class Video
{
    public string Title;
    public string Description;
    public int Length;
    public List<Comment> Comments;
    public void add_comment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int get_comment_count()
    {
        return Comments.Count;
    }



}