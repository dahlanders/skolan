// Syfte: använd SqlParameter för att förhindra sql-injections

public class Demo2
{
    private string conString = @"Server = (localdb)\mssqllocaldb; Database = BlogDb; Trusted_Connection = True";

    public void Test(string title)
    {
        var sql = @"SELECT [Author], [Description]
                    FROM BlogPost 
                    WHERE Title=@Title";

        using (SqlConnection connection = new SqlConnection(conString))
        using (SqlCommand command = new SqlCommand(sql, connection))
        {
            connection.Open();
            command.Parameters.Add(new SqlParameter("Title", title));

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var author = reader.GetString(0);
                var description = reader.GetString(1);

                System.Console.WriteLine($"Författare: {author}");
                System.Console.WriteLine($"Innehåll: {description}");
            };

        }
    }
}
