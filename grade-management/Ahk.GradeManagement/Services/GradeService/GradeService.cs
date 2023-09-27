using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Ahk.GradeManagement.Data;
using Ahk.GradeManagement.Data.Entities;
using Ahk.GradeManagement.ResultProcessing.Dto;

using Microsoft.EntityFrameworkCore;

namespace Ahk.GradeManagement.Services
{
    public class GradeService : IGradeService
    {
        public AhkDbContext Context { get; set; }
        public GradeService(AhkDbContext context)
        {
            Context = context;
        }

        public async Task AddGradeAsync(Grade value)
        {
            Context.Grades.Add(value);
            await Context.SaveChangesAsync();
        }
        public async Task<Grade> GetLastResultOfAsync(string neptun, string gitHubRepoName, int gitHubPrNumber)
        {
            var grades = Context.Grades.Include(g => g.Student).Include(g => g.Assignment)
                .Where(s => s.Student.Neptun == neptun.ToUpperInvariant() && s.GithubRepoName == gitHubRepoName.ToLowerInvariant() && s.GithubPrNumber == gitHubPrNumber)
                .OrderByDescending(s => s.Date);

            return grades.FirstOrDefault();
        }
        public async Task<IReadOnlyCollection<Grade>> ListConfirmedWithRepositoryPrefixAsync(string repoPrefix)
        {
            var confirmedGrades = Context.Grades
                .Where(s => s.IsConfirmed && s.GithubRepoName.StartsWith(repoPrefix));
            return confirmedGrades.ToList().AsReadOnly();
        }

        public async Task DeleteGrade(int id)
        {
            var grade = Context.Grades.Find(id);

            Context.Grades.Remove(grade);
            await Context.SaveChangesAsync();
        }

        public Student FindStudentAsync(string neptun)
        {
            return Context.Students.Where(s => s.Neptun == neptun).FirstOrDefault();
        }

        public Assignment FindAssignment(AhkTaskResult[] results)
        {
            string firstExercise = results[0].ExerciseName;
            var assignment = Context.Exercises.Include(e => e.Assignment).Where(e => e.Name == firstExercise).Select(e => e.Assignment).FirstOrDefault();

            return assignment;
        }

    }
}
