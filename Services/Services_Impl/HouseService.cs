﻿using DAO.BaseModels;
using DAO.Repositories;
using Services.Services;

namespace Services.Services_Impl;

public class HouseService: IHouseService
{
    private readonly IHouseRepository _houseRepository;
    public HouseService(IHouseRepository houseRepository)
    {
        _houseRepository = houseRepository;
    }
    public House CreateHouse(string name, string address)
    {
        House house = new House()
        {
            Name = name,
            Location = address
        };
        _houseRepository.AddHouse(house);
        return house;
    }

    public House EditHouse(House house)
    {
        House houseToUpdate;
        // if (houseToUpdate == null)
        // {
        //     throw new HouseNotFoundException("House not found");
        // }
        
        houseToUpdate = house;
        _houseRepository.UpdateHouse(houseToUpdate);
        return houseToUpdate;
    }

    public IEnumerable<House> GetHousesByUserId(string userId)
    {
        return _houseRepository.GetHouseByUserID(userId);
    }

    public IEnumerable<Room> GetRooms(int houseId)
    {
        return _houseRepository.GetRoomsByHouseId(houseId);
    }

    public Room GetRoom(int roomId)
    {
        throw new NotImplementedException();
    }

    public Room AddRoomToHouse(int houseId, Room room)
    {
        return _houseRepository.AddRoomToHouse(houseId, room);
    }

    public void RemoveRoomFromHouse(int houseId, int roomId)
    {
        _houseRepository.RemoveRoomFromHouse(houseId, roomId);
    }

    public void AddHouseMember(string userId, int houseId)
    {
        _houseRepository.AddHouseMember(userId, houseId);
    }

    public void RemoveHouseMember(string userId, int houseId)
    {
        _houseRepository.RemoveHouseMember(userId, houseId);
    }
}