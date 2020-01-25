using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopEmployee.Dtos;
using TopEmployee.Models;

namespace TopEmployee.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeDto, Employee>();
            CreateMap<Employee, EmployeeDto>();

            var configuration = new MapperConfiguration(cfg =>
                cfg.CreateMap<EmployeeDto, Employee>().ReverseMap());

            configuration.AssertConfigurationIsValid();

        }

    }
}