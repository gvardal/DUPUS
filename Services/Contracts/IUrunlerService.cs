﻿using Entities.Models;

namespace Services.Contracts
{
    public interface IUrunlerService
    {
        IEnumerable<UYUrunler> GetUrunlerList();
        UYUrunler? GetUrunById(int id);
    }
}
