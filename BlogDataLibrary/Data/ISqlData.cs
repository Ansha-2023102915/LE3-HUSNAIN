using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogDataLibrary.Models;

namespace BlogDataLibrary.Data
{
    public interface ISqlData
    {
        UserModel Authenticate(string username, string password);
        void Register(string username, string firstName, string lastName, string password);
        void AddPost(PostModels post);  // Changed from PostModels to PostModel
        List<ListPostModels> ListPosts();  // Changed from ListPostModels to ListPostModel
        PostModels ShowPostDetails(int postId);  // Changed from PostModels to PostModel
    }
}