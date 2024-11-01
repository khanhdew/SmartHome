using DAO.BaseModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAO.Context;

public class DbInitializer
{
    public static void Initializer(IServiceProvider serviceProvider)
    {
        using (var context = new SmartHomeContext(serviceProvider
                   .GetRequiredService<DbContextOptions<SmartHomeContext>>()))
        {
            context.Database.EnsureCreated();
            if (context.Users.Any())
            {
                return;
            }

            if (context.Roles.Any())
            {
                return;
            }

            var roles = new IdentityRole[]
            {
                new IdentityRole { Id = "ID1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "ID2", Name = "Member", NormalizedName = "MEMBER" }
            };

            foreach (var role in roles)
            {
                context.Roles.Add(role);
            }

            context.SaveChanges();
            // Create admin user
            User adminUser = new User
            {
                Id = "ID1",
                UserName = "admin@rangdong.com.vn",
                NormalizedUserName = "ADMIN@RANGDONG.COM.VN",
                Email = "admin@rangdong.com.vn",
                NormalizedEmail = "ADMIN@RANGDONG.COM.VN",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber = "0123456789",
                PhoneNumberConfirmed = true
            };
            
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "admin");
            context.Users.Add(adminUser);
            context.SaveChanges();
            
            // Add user role with houses
            User houseOwner = new User
            {
                UserName = "user@randong.com.vn",
                NormalizedUserName = "USER@RANGDONG.COM.VN",
                Email = "user@smarthome.com.vn",
                NormalizedEmail = "USER@SMARTHOME.COM.VN",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber = "0987654321",
                PhoneNumberConfirmed = true
            };
            houseOwner.PasswordHash = passwordHasher.HashPassword(houseOwner, "user");
            context.Users.Add(houseOwner);
            context.SaveChanges();
            
            // create guest user
            User gUser = new User
            {
                UserName = "guest@randong.com.vn",
                NormalizedUserName = "GUEST@RANGDONG.COM.VN",
                Email = "guest@randong.com.vn",
                NormalizedEmail = "GUEST@RANGDONG.COM.VN",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber = "0987654321",
                PhoneNumberConfirmed = true
            };
            
            gUser.PasswordHash = passwordHasher.HashPassword(gUser, "user");
            context.Users.Add(gUser);
            context.SaveChanges();
            
            // add houses for house owner
            var house = new House
            {
                Name = "House 1",
                Location = "123 Nguyen Luong Bang"
            };
            
            context.Houses.Add(house);
            context.SaveChanges();
            
            var houseOwnerHouse = new HouseMember()
            {
                HouseID = house.ID,
                UserID = houseOwner.Id
            };
            
            context.HouseMembers.Add(houseOwnerHouse);
            context.SaveChanges();
            
            // add rooms for the house
            var room = new Room
            {
                Name = "Room 1",
                HouseID = house.ID
            };
            
            context.Rooms.Add(room);
            context.SaveChanges();
            
            // add devices for the room
            
            var device = new Device
            {
                Name = "Device 1",
                RoomID = room.ID,
                Type = "Light",
                DeviceToken = "token"
            };
            
            context.Devices.Add(device);
            context.SaveChanges();
            
            
            var userRole = new IdentityUserRole<string>
            {
                RoleId = "ID1",
                UserId = "ID1"
            };
            var userRole2 = new IdentityUserRole<string>
            {
                RoleId = "ID2",
                UserId = "ID2"
            };
            var userRole3 = new IdentityUserRole<string>
            {
                RoleId = "ID2",
                UserId = "ID3"
            };

            context.UserRoles.AddRange(userRole, userRole2, userRole3);
            context.SaveChanges();
        }
    }
    
}