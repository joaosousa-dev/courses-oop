using System;
using POO.NotificationContext;
using POO.SharedContext;

namespace POO.ContentContext
{


    public class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            if (course is null)
                AddNotification(new Notification("Curso", "Curso é nulo!"));
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}