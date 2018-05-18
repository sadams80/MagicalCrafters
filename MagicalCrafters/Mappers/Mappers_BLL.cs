using AutoMapper;
using MagicalCrafters.BLL.Models.BLL;
using MagicalCrafters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicalCrafters.Mappers
{
    public class Mappers_BLL
    {
        var config = new MapperConfiguration(cfg => {

            cfg.CreateMap<Users, UsersBLL>().ReverseMap();

        });
    }
}