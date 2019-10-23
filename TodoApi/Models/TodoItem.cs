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
        /// <example>Conquer the world</example>
        [Required]
        public string Name { get; set; }

        /// <example>Design an advanced control system that will allow you to control the world</example>
        public string Description { get; set; }

        /// <example>John Smith</example>
        public string AssignedPerson { get; set; }

        /// <summary>
        /// Flag is set, when task is done
        /// </summary>
        /// <example>false</example>
        [DefaultValue(false)]
        public bool IsComplete { get; set; }

        /// <summary>
        /// time restriction - when the task has to be accomplished.
        /// </summary>
        /// <example>2020-12-31T00:00:00.000Z</example>
        public DateTime? Deadline { get; set; }

        /// <example>Urgent</example>
        [DefaultValue(TodoPriority.Normal)]
        public TodoPriority Priority { get; set; }

    }
}