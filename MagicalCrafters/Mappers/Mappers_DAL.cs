using AutoMapper;
using MagicalCrafters.DAL.Models.DAL;
using MagicalCrafters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicalCrafters.Mappers
{
    public class Mappers_DAL
    {
        var config = new MapperConfiguration(cfg => {

            cfg.CreateMap<Users, UsersDAL>().ReverseMap();

        });
    }
}