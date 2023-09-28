using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ahk.GradeManagement.Data.Entities;
using Ahk.GradeManagement.Data.Entities.StatusTracking;
using Ahk.GradeManagement.Data.Models;
using AutoMapper;
using DTOs;

namespace Ahk.GradeManagement.Helpers
{
    public static class MapperConfig
    {
        public static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Assignment, AssignmentDTO>();
                cfg.CreateMap<Exercise, ExerciseDTO>();
                cfg.CreateMap<Grade, GradeDTO>();
                cfg.CreateMap<Group, GroupDTO>();
                cfg.CreateMap<Point, PointDTO>();
                cfg.CreateMap<Subject, SubjectDTO>();
                cfg.CreateMap<WebhookToken, WebhookTokenDTO>();
                cfg.CreateMap<PullRequestStatus, PullRequestStatusDTO>();
                cfg.CreateMap<WorkflowRunsStatus, WorkflowRunsStatusDTO>();
                cfg.CreateMap<StatusEventBase, StatusEventBaseDTO>();
                cfg.CreateMap<Student, StudentDTO>();
                cfg.CreateMap<Teacher, TeacherDTO>();
                cfg.CreateMap<SubmissionInfo, SubmissionInfoDTO>();
            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
