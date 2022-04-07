using System;
using System.Collections.Generic;
using System.Linq;
using POO.ContentContext;
using POO.SubscriptionContext;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo de OOP", "oop-artigo"));
            articles.Add(new Article("Artigo de C#", "csharp-artigo"));
            articles.Add(new Article("Artigo de .NET", "dotnet-artigo"));

            // foreach (var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url + "\n");

            // }

            var courses = new List<Course>();
            var courseCsharp = new Course("Curso C#", "csharp-course");
            var courseDotnet = new Course("Curso Dotnet", "dotnet-course");
            var courseAspnet = new Course("Curso Aspnet", "aspnet-course");


            courses.Add(courseAspnet);
            courses.Add(courseCsharp);
            courses.Add(courseDotnet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "comece por aqui", "carreira .NET", courseDotnet);
            var careerItem3 = new CareerItem(3, "por fim aqui", "carreira .NET", courseAspnet);
            var careerItem2 = new CareerItem(2, "depois aqui", "carreira .NET", null);


            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);

            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title} - {item.Course?.Title} ");
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }

                }
            }
            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);



        }
    }
}