using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        
        /// <summary>
        /// Task's Name
        /// </summary>
        [Required]
        public string Name { get; set; }


        public string AssignedPerson { get; set; }

        /// <summary>
        /// Flag is set, when task is done
        /// </summary>
        [DefaultValue(false)]
        public bool IsComplete { get; set; }

        /// <summary>
        /// if the task has some time restriction, it has to be accomplished before some time.
        /// </summary>
        public DateTime Deadline { get; set; }
        
        [DefaultValue(TodoPriority.Normal)]
        public TodoPriority Priority { get; set; }

    }
}