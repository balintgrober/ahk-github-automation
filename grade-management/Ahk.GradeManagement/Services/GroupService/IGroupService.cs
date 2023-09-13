using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ahk.GradeManagement.Data.Entities;

namespace Ahk.GradeManagement.Services.GroupService
{
    public interface IGroupService
    {
        public Task SaveGroupAsync(Group group);
        public Task<List<Group>> ListGroupsAsync(string subject);
        public Task<List<Student>> ListStudentsAsync(int groupId);
        public Task DeleteGroupAsync(int groupId);
        public Task UpdateGroupAsync(Group update);
    }
}
