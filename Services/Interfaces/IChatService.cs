﻿using SimpleSocialApp.Data.Models;

namespace SimpleSocialApp.Services.Interfaces
{
    public interface IChatService
    {
        public Task<Chat?> GetConversationAsync(string id);
        public Task<List<Chat>> GetConversationsForUserAsync(string userId);
        public Task CreateConversationAsync(Chat conversation);

        public Task CreatePrivateChatAsync(AppUser? first, AppUser? second);
        public Task UpdateConversationAsync(Chat conversation);
        public Task DeleteConversationAsync(string conversationId);
        public Task AddUserAsync(Chat chat, AppUser user);
        public Task<bool> RemoveUserAsync(Chat chat, AppUser user);
        public Task<List<AppUser>> GetAllUsers(Chat chat);

        public List<Chat> GetLast(string userdId, int count);
        public Task<List<Chat>> SearchChat(string userId, string query);
        public string GetFriendName(Chat chat, string currentUserId);

        public Task<bool> AnyAsync();

    }
}
