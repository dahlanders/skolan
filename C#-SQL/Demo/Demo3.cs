// Syfte: en metod som returnerar en lista av BlogPosts

public class Demo3
{
    private string conString = @"Server = (localdb)\mssqllocaldb; Database = BlogDb; Trusted_Connection = True";

    public List<BlogPost> Get(string title)
    {
        var sql = @"SELECT [Id], [Author], [Title], [Description], [Created] 
                    FROM BlogPost 
                    WHERE Title=@Title";

        using (SqlConnection connection = new SqlConnection(conString))
        using (SqlCommand command = new SqlCommand(sql, connection))
        {
            connection.Open();
            command.Parameters.Add(new SqlParameter("Title", title));

            SqlDataReader reader = command.ExecuteReader();
            var list = new List<BlogPost>();

            while (reader.Read())
            {
                var bp = new BlogPost()
                {
                    Id = reader.GetGuid(0),
                    Author = reader.GetString(1),
                    Title = reader.GetString(2),
                    Description = reader.GetString(3),
                    Created = reader.GetDateTime(4)
                };

                list.Add(bp);
            }
            return list;
        }
    }
}
