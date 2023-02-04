﻿namespace BlazorMyRide.Client.Services
{
    public interface ICutomService
    {
        List<Custom> Customs { get; set; }
        Task GetCustoms();
        Task<Custom?> GetCustomById(int id);
        Task AddCustom(Custom custom);
        Task UpdateCustom(int id, Custom custom);
        Task DeleteCustom(int id);
    }
}
