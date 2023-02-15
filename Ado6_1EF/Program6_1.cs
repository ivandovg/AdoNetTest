using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado6_1EF
{
    internal class Program6_1
    {
        static void Main(string[] args)
        {
            Console.Title = "Test EF - CodeFirst";

            // создаем контекст для работы с БД
            NewsDb db = new NewsDb();

            //// добавим автора
            //Author author = AddAuthor(db);
            ////// добавим статью
            ////AddArticle(db, author);

            //// изменить информацию про автора
            //ChangeAuthor(db);
            //PrintAllAuthors(db);
            //// удалить автора
            //DeleteAuthor(db);
            //PrintAllAuthors(db);

            // отобразить список статей
            //PrintAllArticles(db);

            // отобразить всех авторов и их публикации - безотложная загрузка
            //PrintAllAuthorsAllArticles(db);

            // отобразить всех авторов и их публикации - явная загрузка
            //PrintAllAuthorsAllArticlesExplicit(db);

            // отобразить всех авторов и их публикации - явная загрузка (#2)
            PrintAllAuthorsAllArticlesExplicit2(db);

            Console.WriteLine("\npress Enter key...");
            Console.ReadLine();
        }
        private static void DeleteAuthor(NewsDb db)
        {
            PrintAllAuthors(db);
            Console.Write("\nEnter Id >> ");
            int id = int.Parse(Console.ReadLine());

            // получем объект из БД
            Author author = db.Authors.Where(a => a.Id == id).FirstOrDefault();

            if (author == null)
            {
                Console.WriteLine("\nNot found!!!\npress any key...");
                Console.ReadKey();
            }

            // удаляем объект из БД
            db.Authors.Remove(author);

            // сохранить изменения в БД
            db.SaveChanges();
        }
        private static void ChangeAuthor(NewsDb db)
        {
            PrintAllAuthors(db);
            Console.Write("\nEnter Id >> ");
            int id = int.Parse(Console.ReadLine());

            // получем объект из БД
            Author author = db.Authors.Where(a => a.Id == id).FirstOrDefault();

            if (author == null)
            {
                Console.WriteLine("\nNot found!!!\npress any key...");
                Console.ReadKey();
            }

            Console.Write("Firstname >> ");
            author.Firstname = Console.ReadLine();
            Console.Write("Lastname >> ");
            author.Lastname = Console.ReadLine();
            Console.Write("Birth >> ");
            author.Birth = Convert.ToDateTime(Console.ReadLine());

            // сохранить изменения в БД
            db.SaveChanges();
        }
        private static Author AddAuthor(NewsDb db)
        {
            // создаем новый объект
            Author a = new Author();
            Console.Write("Firstname >> ");
            a.Firstname = Console.ReadLine();
            Console.Write("Lastname >> ");
            a.Lastname = Console.ReadLine();
            Console.Write("Birth >> ");
            a.Birth = Convert.ToDateTime(Console.ReadLine());
            // добавлям в БД
            db.Authors.Add(a);
            // сохранить изменения в БД
            db.SaveChanges();

            return a;
        }
        private static void AddArticle(NewsDb db, Author author)
        {
            // создаем новый объект
            Article article = new Article();
            Console.Write("Title >> ");
            article.Title = Console.ReadLine();
            Console.Write("Description >> ");
            article.Description = Console.ReadLine();
            // добавлям в БД
            db.Articles.Add(article);
            // связываем автора и статью
            article.Author = author;
            // сохранить изменения в БД
            db.SaveChanges();
        }

        private static void PrintAllArticles(NewsDb db)
        {
            Console.WriteLine("All articles:");
            foreach (Article article in db.Articles)
            {
                Console.WriteLine(article);
            }
        }

        private static void PrintAllAuthors(NewsDb db)
        {
            Console.WriteLine("All Authors:");
            foreach (Author a in db.Authors)
            {
                Console.WriteLine($"{a.Id}) {a}");
            }
        }

        private static void PrintAllAuthorsAllArticles(NewsDb db)
        {
            Console.WriteLine("All publications: ");
            var authors = db.Authors.Include("Articles").ToList();
            foreach (Author author in authors)
            {

                Console.WriteLine(author);
                Console.WriteLine("Publication: ");
                foreach (Article article in author.Articles.ToList())
                {
                    Console.WriteLine($"\t{article.Title} - {article.PublishDate.ToShortDateString()}");
                }
            }
        }

        private static void PrintAllAuthorsAllArticlesExplicit(NewsDb db)
        {
            Console.WriteLine("All publications (explicit loading): ");
            var authors = db.Authors.ToList();
            foreach (Author author in authors)
            {

                Console.WriteLine(author);
                Console.WriteLine("Publication: ");

                // explicit loading (явная загрузка)
                db.Entry(author).Collection("Articles").Load();

                foreach (Article article in author.Articles.ToList())
                {
                    Console.WriteLine($"\t{article.Title} - {article.PublishDate.ToShortDateString()}");
                }
            }
        }

        private static void PrintAllAuthorsAllArticlesExplicit2(NewsDb db)
        {
            Console.WriteLine("All publications (explicit loading): ");
            var articles = db.Articles.ToList();
            foreach (Article article in articles)
            {
                // explicit loading (явная загрузка)
                db.Entry(article).Reference("Author").Load();

                // отображаем публикацию и автора
                Console.WriteLine($"{article.Title} ({article.Author.Firstname} {article.Author.Lastname})");
            }
        }
    }
}
