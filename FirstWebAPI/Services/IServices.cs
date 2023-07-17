using System;
using FirstWebAPI.Models;
using FirstWebAPI.Pagination;
using FirstWebAPI.Repository;
using Microsoft.Extensions.Caching.Memory;

namespace FirstWebAPI.Services;

public interface IServices
{
    ICarServices CarServices { get;}
}