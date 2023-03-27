using DragAndDrop.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragAndDrop.Components
{
    public partial class JobsContainer : ComponentBase
    {
        [Parameter]
        public List<Job> Jobs { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public EventCallback<Job> OnJobUpdated { get; set; }
        
        public Job Job { get; set; }

        public async Task UpdateJobAsync(JobStatus status)
        {
            var task = Jobs.SingleOrDefault(t => t.Id == Job.Id);

            if(task is null) return;

            task.Status = status;
            task.LastUpdated = DateTime.Now;

            await OnJobUpdated.InvokeAsync(Job);
        }
    }
}
