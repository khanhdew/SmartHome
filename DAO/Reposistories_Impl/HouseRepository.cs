using DAO.BaseModels;
using DAO.Context;
using DAO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Reposistories_Impl
{
    public class HouseRepository : IHouseRepository
    {
        private readonly SmartHomeContext _context;

        public HouseRepository(SmartHomeContext context)
        {
            _context = context;
        }

        public House AddHouse(House house)
        {
            try
            {
                _context.Houses.Add(house);
                _context.SaveChanges();
                return house;
            }
            catch (Exception e)
            {
                throw new Exception("Error while adding house");
            }
        }

        public House GetHouseById(int houseId)
        {
            var house = _context.Houses.FirstOrDefault(h => h.ID == houseId);
            if (house == null)
            {
                throw new Exception("House not found");
            }
            return house;
        }

        public void AddHouseMember(string userId, int houseId, string role)
        {
            try
            {
                var house = _context.Houses.FirstOrDefault(h => h.ID == houseId);
                if (house == null)
                {
                    throw new Exception("House not found");
                }

                var user = _context.Users.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                {
                    throw new Exception("User not found");
                }

                var houseMember = new HouseMember
                {
                    UserID = userId,
                    HouseID = houseId,
                    Role = role,
                    House = house,
                    User = user
                };

                _context.HouseMembers.Add(houseMember);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Error while adding house member");
            }
        }

        public Room AddRoomToHouse(int houseId, Room room)
        {
            try
            {
                var house = _context.Houses.FirstOrDefault(h => h.ID == houseId);
                if (house == null)
                {
                    throw new Exception("House not found");
                }
                house.Rooms.Add(room);
                _context.SaveChanges();
                return room;
            }
            catch (Exception e)
            {
                throw new Exception("Error while adding room to house");
            }
        }

        public void DeleteHouse(int houseId)
        {
            var house = _context.Houses.FirstOrDefault(h => h.ID == houseId);
            if (house == null)
            {
                throw new Exception("House not found");
            }
            _context.Houses.Remove(house);
            _context.SaveChanges();
        }

        public IEnumerable<House> GetAllHouses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<House> GetHouseByUserID(string userId)
        {
            var houses = _context.HouseMembers.Where(hm => hm.UserID == userId).ToList();
            List<House> result = new List<House>();
            foreach (var house in houses)
            {
                result.Add(_context.Houses.FirstOrDefault(h => h.ID == house.HouseID));
            }
            return result;
        }

        public IEnumerable<Room> GetRoomsByHouseId(int houseId)
        {
            var house = _context.Houses.FirstOrDefault(h => h.ID == houseId);
            if (house == null)
            {
                throw new Exception("House not found");
            }
            return house.Rooms;
        }

        public void RemoveHouseMember(string userId, int houseId)
        {
            var houseMember = _context.HouseMembers.FirstOrDefault(hm => hm.UserID == userId && hm.HouseID == houseId);
            if (houseMember == null)
            {
                throw new Exception("House member not found");
            }
            _context.HouseMembers.Remove(houseMember);
            _context.SaveChanges();
        }

        public void RemoveRoomFromHouse(int houseId, int roomId)
        {
            var house = _context.Houses.FirstOrDefault(h => h.ID == houseId);
            if (house == null)
            {
                throw new Exception("House not found");
            }
            var room = house.Rooms.FirstOrDefault(r => r.ID == roomId);
            if (room == null)
            {
                throw new Exception("Room not found");
            }
            house.Rooms.Remove(room);
            _context.SaveChanges();
        }

        public House UpdateHouse(House house)
        {
            var houseToUpdate = _context.Houses.FirstOrDefault(h => h.ID == house.ID);
            if (houseToUpdate == null)
            {
                throw new Exception("House not found!");
            }
            // Update only the modified properties
            // no update for id, null properties
            var properties = house.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.Name == "ID" || property.GetValue(house) == null)
                {
                    continue;
                }
                property.SetValue(houseToUpdate, property.GetValue(house));
            }
            _context.SaveChanges();
            return houseToUpdate;
        }

       
    }
}
