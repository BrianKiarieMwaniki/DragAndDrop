using DragAndDrop.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragAndDrop.Pages
{
    public partial class Index : ComponentBase
    {
        private List<Job> _jobs = new();

        protected override void OnInitialized()
        {
            _jobs.Add(new Job { Id = 1, Title = "Lunch", Description = "Cook lunch for young ones", Status = JobStatus.ToDo, LastUpdated = DateTime.Now });
            _jobs.Add(new Job { Id = 1, Title = "Groom", Description = "Groom Wichita the cat", Status = JobStatus.ToDo, LastUpdated = DateTime.Now });
            _jobs.Add(new Job { Id = 1, Title = "Kanban Component", Description = "Build a kanban component in Blazor", Status = JobStatus.OnGoing, LastUpdated = DateTime.Now });
            _jobs.Add(new Job { Id = 1, Title = "Educate", Description = "Educate peers on the benefits of eating healthy", Status = JobStatus.OnGoing, LastUpdated = DateTime.Now });
            _jobs.Add(new Job { Id = 1, Title = "Desktop Sharing App", Description = "Build a desktop sharing app", Status = JobStatus.OnHold, LastUpdated = DateTime.Now });
            _jobs.Add(new Job { Id = 1, Title = "Do Laundry", Description = "Do laundry for all work related attire", Status = JobStatus.Completed, LastUpdated = DateTime.Now });
            _jobs.Add(new Job { Id = 1, Title = "File Taxes", Description = "File taxes for the year 2022-2023", Status = JobStatus.ToDo, LastUpdated = DateTime.Now });
        }

        private void HandleJopUpdated()
        {

        }
    }
}
