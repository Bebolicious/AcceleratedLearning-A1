using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Bloggy.Demo.Domain;

namespace Bloggy.Demo
{
    public class DataAccess
    {
        private const string conString = "Server=(localdb)\\mssqllocaldb; Database=BlogPostDemo";


        public List<BlogPost> GetAllBlogPostsBrief()
        {
            var sql = @"SELECT [Id], [Author], [Title]
                        FROM BlogPost";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                var list = new List<BlogPost>();

                while (reader.Read())
                {
                    var bp = new BlogPost
                    {
                        Id = reader.GetSqlInt32(0).Value,
                        Author = reader.GetSqlString(1).Value,
                        Title = reader.GetSqlString(2).Value
                    };
                    list.Add(bp);
                }

                return list;

            }
        }

        public BlogPost GetPostById(int postId)
        {
            var sql = @"SELECT [Id], [Author], [Title]
                        FROM BlogPost 
                        WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", postId));

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var bp = new BlogPost
                    {
                        Id = reader.GetSqlInt32(0).Value,
                        Author = reader.GetSqlString(1).Value,
                        Title = reader.GetSqlString(2).Value
                    };
                    return bp;

                }

                return null;

            }
        }

        public List<Comments> WatchComments(int PostId)
        {
            var sql = @"SELECT Id, Comment
                        FROM Comments
                        WHERE PostId=@PostId";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("PostId", PostId));

                SqlDataReader reader = command.ExecuteReader();

                var list = new List<Comments>();

                while (reader.Read())
                {
                    var item = new Comments
                    {               
                        
                        Comment = reader.GetSqlString(1).Value,
                    };
                    list.Add(item);
                }

                return list;

            }
        }

        public void CreateNewPost(string NewAuthor, string CreateNewPost)
        {
            var sql = @"
                        INSERT INTO BlogPost (Author, Title)
                        VALUES (@Title, @Author)";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Title", NewAuthor));
                command.Parameters.Add(new SqlParameter("Author", CreateNewPost));
                command.ExecuteNonQuery();
            }




        }

        internal void AddComment(int PostId, string Newcomment)
        {
            var sql = @"
                        INSERT INTO Comments (Comment, PostId)
                        VALUES (@Comment, @PostId)";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("PostId", PostId));
                command.Parameters.Add(new SqlParameter("Comment", Newcomment));
                command.ExecuteNonQuery();
            }

        }

        internal void AddTagsToPost(int tagId, string tagstring)
        {
            var sql = @"
                        INSERT INTO Tags (Tags, Id)
                        VALUES (@Tags, @PostId";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("PostId", tagId));
                command.Parameters.Add(new SqlParameter("Tags", tagstring));
                command.ExecuteNonQuery();
            }


        }


        public void RemovePost(BlogPost blogPost)
        {
            var sql = @"DELETE  
                        FROM BlogPost
                        WHERE id=@Id";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", blogPost.Id));
                command.ExecuteNonQuery();
            }
        }

        public void UpdateBlogpost(BlogPost blogPost)
        {
            var sql = "UPDATE BlogPost SET Title=@Title WHERE id=@Id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", blogPost.Id));
                command.Parameters.Add(new SqlParameter("Title", blogPost.Title));
                command.ExecuteNonQuery();
            }
        }

        internal List<Tag> WatchTags(int postId)
        {
            var sql = @"select Tags
                        from Tags
                        full join Multipletags ON Tags.Id=Multipletags.TagId
                        Full join BlogPost On BlogPost.Id=PostId
                        WHERE multipletags.PostId=@PostId";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("PostId", postId));

                SqlDataReader reader = command.ExecuteReader();

                var list = new List<Tag>();

                while (reader.Read())
                {
                    var item = new Tag
                    {

                        Tags = reader.GetSqlString(1).Value,
                    };
                    list.Add(item);
                }

                return list;

            }
        }
    }
    
}