using DragAndDrop.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragAndDrop.Components
{
    public partial class JobsColumn : ComponentBase
    {
        [CascadingParameter]
        public JobsContainer Container { get; set; }

        [Parameter]
        public JobStatus ColumnStatus { get; set; }

        [Parameter]
        public JobStatus[] AllowStatuses { get; set; }

        private List<Job> _jobs = new();

        private string _dropClass = string.Empty;

        protected override void OnParametersSet()
        {

            _jobs.Clear();

            _jobs.AddRange(Container.Jobs.Where(j => j.Status == ColumnStatus));
        }

        private async Task HandleDrop()
        {
            _dropClass = string.Empty;

            if (AllowStatuses != null && !AllowStatuses.Contains(Container.Job.Status)) return;

            await Container.UpdateJobAsync(ColumnStatus);
        }

        private void HandleDragEnter()
        {
            if (ColumnStatus == Container.Job.Status) return;

            if(AllowStatuses != null)
            {
                _dropClass = !AllowStatuses.Contains(Container.Job.Status) ? "no-drop" : "allow-drop";
            }
        }

        private void HandleDragLeave()
        {
            _dropClass = string.Empty;
        }
    }
}
