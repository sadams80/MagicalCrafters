using AutoMapper;
using MagicalCrafters.BLL.Models.BLL;
using MagicalCrafters.Models;

namespace MagicalCrafters.Mappers
{
    public class Mappers_BLL
    {
        MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Announcements, AnnouncementsBLL>().ReverseMap();
            cfg.CreateMap<Comments, CommentsBLL>().ReverseMap();
            cfg.CreateMap<Completed_Projects, Completed_ProjectsBLL>().ReverseMap();
            cfg.CreateMap<Crafts, CraftsBLL>().ReverseMap();
            cfg.CreateMap<Favorite_Projects, Favorite_ProjectsBLL>().ReverseMap();
            cfg.CreateMap<Flagged_Items, Flagged_ItemsBLL>().ReverseMap();
            cfg.CreateMap<Houses, HousesBLL>().ReverseMap();
            cfg.CreateMap<Ongoing_Projects, Ongoing_ProjectsBLL>().ReverseMap();
            cfg.CreateMap<Projects, ProjectsBLL>().ReverseMap();
            cfg.CreateMap<Roles, RolesBLL>().ReverseMap();
            cfg.CreateMap<Skill_Levels, Skill_LevelsBLL>().ReverseMap();
            cfg.CreateMap<Sources, SourcesBLL>().ReverseMap();
            cfg.CreateMap<Users, UsersBLL>().ReverseMap();
            cfg.CreateMap<Users_Info, Users_InfoBLL>().ReverseMap();
        });
    }
}