﻿using System;
using System.Collections.Generic;

namespace ChangeMe.Model.Repository.Abstract
{
    /// <summary>
    /// Interface för Repository
    /// </summary>
    public interface IRepository
    {
        List<Post> GetPosts();
        void AddPost(Post newPost);
        void RemovePost(Guid postID);

        List<User> GetUsers();
        void AddUser(User newUser);
        void RemoveUser(Guid userID);
    }
}
