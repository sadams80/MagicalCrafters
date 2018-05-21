using AutoMapper;
using MagicalCrafters.DAL.Models.DAL;
using MagicalCrafters.Models;

namespace MagicalCrafters.Mappers
{
    public class Mappers_DAL
    {
        MapperConfiguration config = new MapperConfiguration(cfg =>
        { 
            cfg.CreateMap<Announcements, AnnouncementsDAL>().ReverseMap();
            cfg.CreateMap<Comments, CommentsDAL>().ReverseMap();
            cfg.CreateMap<Completed_Projects, Completed_ProjectsDAL>().ReverseMap();
            cfg.CreateMap<Crafts, CraftsDAL>().ReverseMap();
            cfg.CreateMap<Favorite_Projects, Favorite_ProjectsDAL>().ReverseMap();
            cfg.CreateMap<Flagged_Items, Flagged_ItemsDAL>().ReverseMap();
            cfg.CreateMap<Houses, HousesDAL>().ReverseMap();
            cfg.CreateMap<Ongoing_Projects, Ongoing_ProjectsDAL>().ReverseMap();
            cfg.CreateMap<Projects, ProjectsDAL>().ReverseMap();
            cfg.CreateMap<Roles, RolesDAL>().ReverseMap();
            cfg.CreateMap<Skill_Levels, Skill_LevelsDAL>().ReverseMap();
            cfg.CreateMap<Sources, SourcesDAL>().ReverseMap();
            cfg.CreateMap<Users, UsersDAL>().ReverseMap();
            cfg.CreateMap<Users_Info, Users_InfoDAL>().ReverseMap();
        });
    }
}