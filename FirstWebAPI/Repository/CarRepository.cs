using FirstWebAPI.Data;
using FirstWebAPI.Dto;
using FirstWebAPI.Models;
using FirstWebAPI.Pagination;

namespace FirstWebAPI.Repository;

public class CarRepository : RepositoryBase<Car>, ICarRepository
{
    public CarRepository(AppDbContext context) : base(context)
    {
        
    }

    public void DeleteCar(Car car) => Delete(car);

    public Car GetCar(string Id) => 
        FindByCondition(c => c.id.Equals(Id)).FirstOrDefault();

    

    public Car GetCarName(string name) => 
        FindByCondition(c => c.name.Equals(name)).FirstOrDefault();


    public void AddCar(Car car) => Add(car);

    public Task<PagingList<Car>> GetAllCar(PagingParameters pagingParameters)
    {
        return Task.FromResult(PagingList<Car>.GetPagingList(FindAll().OrderBy(c => c.Id), pagingParameters.PageNumber, pagingParameters.PageSize));
    }

    public void UpdateCar(string Id, CarInputDto carInputDto)
    {
        
    }
}
