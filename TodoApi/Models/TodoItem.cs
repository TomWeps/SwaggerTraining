using Swashbuckle.AspNetCore.XFaker;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {
        [SwaggerXFaker(FakeRandom.Number)]
        public long Id { get; set; }

        /// <summary>
        /// Task's Name
        /// </summary>
        /// <example>Conquer the world</example>
        [Required]
        [SwaggerXFaker(FakeLorem.Words)]
        public string Name { get; set; }

        /// <example>Design an advanced control system that will allow you to control the world</example>
        [SwaggerXFaker(FakeLorem.Paragraph)]        
        public string Description { get; set; }

        /// <example>John Smith</example>
        [SwaggerXFaker(FakeName.FindName)]
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
        [SwaggerXFaker(FakeDate.Future)]
        public DateTime? Deadline { get; set; }

        /// <example>Urgent</example>
        [DefaultValue(TodoPriority.Normal)]
        public TodoPriority Priority { get; set; }

    }
}