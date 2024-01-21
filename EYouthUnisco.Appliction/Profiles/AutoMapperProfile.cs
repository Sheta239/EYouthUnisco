using AutoMapper;
using EYouthUnisco.Appliction.Features.Course.Commands.CreateCourse;
using EYouthUnisco.Appliction.Features.Course.Commands.DeleteCourse;
using EYouthUnisco.Appliction.Features.Course.Commands.EnrollCourse;
using EYouthUnisco.Appliction.Features.Course.Commands.UpdateCourse;
using EYouthUnisco.Appliction.Features.Course.Queries.GetCoursesByTag;
using EYouthUnisco.Appliction.Features.Course.Queries.GetCoursesByUser;
using EYouthUnisco.Appliction.Features.CourseType.Commands.CreateCourseType;
using EYouthUnisco.Appliction.Features.CourseType.Commands.DeleteCourseType;
using EYouthUnisco.Appliction.Features.CourseType.Commands.UpdateCourseType;
using EYouthUnisco.Appliction.Features.Payment.Command;
using EYouthUnisco.Appliction.Features.Role.Commands.CreateRole;
using EYouthUnisco.Appliction.Features.Role.Commands.DeleteRole;
using EYouthUnisco.Appliction.Features.Role.Commands.UpdateRole;
using EYouthUnisco.Appliction.Features.Session.Commands.CreateSession;
using EYouthUnisco.Appliction.Features.Session.Commands.DeleteSession;
using EYouthUnisco.Appliction.Features.Session.Commands.UpdateSession;
using EYouthUnisco.Appliction.Features.Tag.Commands.CreateTag;
using EYouthUnisco.Appliction.Features.Tag.Commands.DeleteTag;
using EYouthUnisco.Appliction.Features.Tag.Commands.UpdateTag;
using EYouthUnisco.Appliction.Features.User.Commands.CreateUser;
using EYouthUnisco.Appliction.Features.User.Commands.DeleteUser;
using EYouthUnisco.Appliction.Features.User.Commands.UpdateUser;
using EYouthUnisco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Map User
            CreateMap<User, CreateUserCommand>().ReverseMap();
            CreateMap<User, UpdateUserCommand>().ReverseMap();
            CreateMap<User, DeleteUserCommand>().ReverseMap();
            //Map Tag
            CreateMap<Tag, CreateTagCommand>().ReverseMap();
            CreateMap<Tag, UpdateTagCommand>().ReverseMap();
            CreateMap<Tag, DeleteTagCommand>().ReverseMap();
            //Map Session
            CreateMap<Session, CreateSessionCommand>().ReverseMap();
            CreateMap<Session, UpdateSessionCommand>().ReverseMap();
            CreateMap<Session, DeleteSessionCommand>().ReverseMap();
            //Map Role
            CreateMap<Role, CreateRoleCommand>().ReverseMap();
            CreateMap<Role, UpdateRoleCommand>().ReverseMap();
            CreateMap<Role, DeleteRoleCommand>().ReverseMap();
            //Map CourseType
            CreateMap<CourseType, CreateCourseTypeCommand>().ReverseMap();
            CreateMap<CourseType, UpdateCourseTypeCommand>().ReverseMap();
            CreateMap<CourseType, DeleteCourseTypeCommand>().ReverseMap();
            //Map Course
            CreateMap<Course, CreateCourseCommand>().ReverseMap();
            CreateMap<Course, UpdateCourseCommand>().ReverseMap();
            CreateMap<Course, DeleteCourseCommand>().ReverseMap();
            CreateMap<Course, EnrollCourseCommand>().ReverseMap();

            //Map Pay
            CreateMap<PaymentOrder, InitializePaymentCommand>().ReverseMap();

        }
    }
}
