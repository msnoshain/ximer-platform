// See https://aka.ms/new-console-template for more information
using CommunityToolkit.Diagnostics;
using XimerGame.Shared.Models.Entities;

User user = User.NoneUserInstance;
User user1 = new User();
User user2 = User.NoneUserInstance;
Console.WriteLine(user==user1);
Console.WriteLine(user==user2);
