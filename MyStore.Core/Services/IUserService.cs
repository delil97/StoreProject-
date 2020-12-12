﻿using MyStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Core.Services
{
    public interface IUserService
    {
        Task<User> GetUserWithAdress(int userId);

        Task<User> CreateUser(User user);

        Task<User> UpdateUser(User userToBeUpdated, User user);

        Task DeleteUser(User user);
    }
}