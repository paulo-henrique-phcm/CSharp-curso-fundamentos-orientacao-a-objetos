using System;
using Balta.ContextContent;
using Balta.SubscriptionContext;

class Program
{
    static void Main()
    {
        Console.Clear();
        var course = new Course("", "");
        course.Level = EContentLevel.Iniciante;
        Career career = new Career("", "");

        foreach (var item in course.Modules)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(career);


        var articles = new List<Article>();
        articles.Add(new Article("Mão na massa sobre OOP1", "url-rientacao-objetos1"));
        articles.Add(new Article("Mão na massa sobre OOP2", "url-rientacao-objetos2"));
        articles.Add(new Article("Mão na massa sobre OOP3", "url-rientacao-objetos3"));

        foreach (var item in articles)
        {
            Console.WriteLine(item.Id + item.Title + item.Url);
        }

        Console.Clear();


        var curso1 = new Course("curso 1", "curso-1");
        var curso2 = new Course("curso 2", "curso-2");
        var curso3 = new Course("curso 3", "curso-3");


        var careerList = new List<Career>();
        var career1 = new Career("Carreira dev C#", "carreira-dev-c#");
        career1.Items.Add(new CareerItem(3, "continuando", "terceiro item da carreira", curso1));
        career1.Items.Add(new CareerItem(1, "comece aqui", "primeiro item da carreira", null));
        career1.Items.Add(new CareerItem(2, "depois aqui", "segundo item da carreira", curso3));
        careerList.Add(career1);

        foreach (var career_i in careerList)
        {
            Console.WriteLine("Titulo da carreira: " + career_i.Title);
            foreach (var item in career_i.Items.OrderBy(x => x.Order))
            {
                Console.WriteLine($"item de carreira: {item.Order} - {item.Title}");
                Console.WriteLine(item.Course?.Title);
                Console.WriteLine(item.Course?.Url);

                // percorre todas as notifications
                foreach (var notification in item.Notifications)
                {
                    Console.WriteLine($"Ocorrereu algum erro: {notification.Property} - {notification.Message}");
                }
            }
        }

        var payPalSubscription = new PayPalSubscription();
        var student = new Student();
        student.CreateSubscription(payPalSubscription);
        student.CreateSubscription(payPalSubscription);
    }
}
