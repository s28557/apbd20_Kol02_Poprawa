using System.Transactions;
using Kol02.DTOs;
using Kol02.Models;
using Kol02.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kol02.Controllers;

public class RentalsController : ControllerBase
{
    private readonly IDbService _dbService;
    public RentalsController(IDbService dbService)
    {
        _dbService = dbService;
    }
    
    [HttpGet("{clientId}")]
    public async Task<IActionResult> GetOrdersData(int clientId)
    {
        var client = await _dbService.GetClientRentals(clientId);

        if (client == null)
        {
            return NotFound("No such client");
        }
        
        return Ok(client);
    }
    
    [HttpPost]
    public async Task<IActionResult> AddClientAndRental(AddClientRentalDto addClientRentalDto)
    {
        if (!await _dbService.DoesCarExist(addClientRentalDto.CarID))
        {
            return NotFound("car not found");
        }

        if (addClientRentalDto.DateFrom >= addClientRentalDto.DateTo)
        {
            return BadRequest("wrong dates");
        }
        var client = new Client()
        {
            FirstName = addClientRentalDto.Client.FirstName,
            LastName = addClientRentalDto.Client.LastName,
            Address = addClientRentalDto.Client.Address
        };
        
        var rentalDays = (addClientRentalDto.DateTo - addClientRentalDto.DateFrom).Days;
        var car = await _dbService.GetCarById(addClientRentalDto.CarID);
        var totalPrice = rentalDays * car.PricePerDay;
        
        var carRental = new CarRental()
        {
            CarID = addClientRentalDto.CarID,
            DateFrom = addClientRentalDto.DateFrom,
            DateTo = addClientRentalDto.DateTo,
            TotalPrice = totalPrice,
            Client = client
        };
        
        using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
        {
            await _dbService.AddNewClient(client);
            await _dbService.AddCarRental(carRental);
    
            scope.Complete();
        }
        return Created();
    }
}