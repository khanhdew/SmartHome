﻿using DAO.BaseModels;

namespace Services.Services;

public interface IHouseService
{
    public House CreateHouse(string name, string address);
    public House EditHouse(House house);
    public House GetHouseByUserId(string userId);
    public IEnumerable<Room> GetRooms(int houseId);
    public Room GetRoom(int roomId);
    public Room AddRoomToHouse(int houseId, string name);
    public void RemoveRoomFromHouse(int houseId, int roomId);
    public void AddHouseMember(string userId, int houseId);
    public void RemoveHouseMember(string userId, int houseId);
    
}