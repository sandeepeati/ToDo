using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Models
{
    public class TaskModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public class ViewTaskModel : TaskModel
    {
        public int Percent { get; set; }
    }
}
