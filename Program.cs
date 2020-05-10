using System;
using System.Linq;

namespace HelloApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                tester user1 = new tester { FIO_tester = ""};
                tester user2 = new tester { FIO_tester = "Alice"};
             
                // добавляем их в бд
                db.tester.Add(user1);
                db.tester.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.tester.ToList();
                Console.WriteLine("Список объектов:");
                foreach (tester u in users)
                {
                    Console.WriteLine($"{u.Id_tester}.{u.FIO_tester}");
                }
            }
            Console.Read();
        }
    }
}