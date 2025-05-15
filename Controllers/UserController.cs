using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Realtime_signalR.Data;
using Realtime_signalR.Models;

namespace Realtime_signalR.Controllers;

    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
    IUserRepository _userRepository;
    IMapper _mapper;
    public UserController(IUserRepository userRepository)
    {
      _userRepository = userRepository;
      _mapper = new Mapper(new MapperConfiguration(cfg =>
        {
        cfg.CreateMap<Models.User, Dtos.UserDto>();
      }));
    }
    [HttpGet("GetUser")]
    public IEnumerable<User> GetUsers()
    {
       IEnumerable<User> users = _userRepository.GetUsers();
       return users;
    }
    }
