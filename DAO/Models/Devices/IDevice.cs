﻿using DAO.BaseModels;

namespace DAO.Models.Devices;

public interface IDevice  
{
    object TurnOn();
    object TurnOff();
}