﻿using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant newRestaurant);
    }
}
