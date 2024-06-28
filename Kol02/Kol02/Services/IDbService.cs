using Kol02.DTOs;
using Kol02.Models;

namespace Kol02.Services;

public interface IDbService
{
    public Task<bool> DoesClientExist(int id);
    public Task<bool> DoesCarExist(int id);
    public Task<GetClientDto?> GetClientRentals(int clientId);
    public Task<Car?> GetCarById(int carId);
    public Task<GetClientDto> GetClientData(int id);
    public Task AddNewClientRental(Client client);
}