using System;
using System.Collections.Generic;
using Bloggy.Demo.Domain;

namespace Bloggy.Demo
{
    public class App
    {
        DataAccess _dataAccess = new DataAccess();

        public void Run()
        {
            
            PageMainMenu();
        }

        private void PageMainMenu()
        {
            TextFormatting.Header("Huvudmeny");

            ShowAllBlogPostsBrief();

            TextFormatting.MenuItems2("Vad vill du göra?\n");
            TextFormatting.MenuItems("a) Skriv ett nytt blogginlägg");
            TextFormatting.MenuItems("b) Uppdatera ett blogginlägg");
            TextFormatting.MenuItems("c) Ta bort blogginlägg\n");
            TextFormatting.MenuItems("d) Skriv en kommentar");
            TextFormatting.MenuItems("e) Läs kommentarer\n");
            TextFormatting.MenuItems("f) Tagga ett blogginlägg");
            TextFormatting.MenuItems("g) Läs taggar för ett blogginlägg");
            TextFormatting.MenuItems("h) Ta bort tagg från blogginlägg\n");
            TextFormatting.MenuItems2("\nESC) Avsluta");

            ConsoleKey command = Console.ReadKey(true).Key;

            if (command == ConsoleKey.A)
                PageAddPost();

            if (command == ConsoleKey.B)
                PageUpdatePost();

            if (command == ConsoleKey.C)
                PageRemovePost();

            if (command == ConsoleKey.D)
                PageAddComment();

            if (command == ConsoleKey.E)
                PageWatchComments();

            if (command == ConsoleKey.F)
                PageAddTags();

            if (command == ConsoleKey.G)
                PageWatchTags();

            if (command == ConsoleKey.H)
                    PageAddTags();

            if (command == ConsoleKey.Escape)
                ExitBloggy();
            else
            {

                ExitBloggy();

            }
        }


        private void ShowAllBlogPostsBrief()
        {
            List<BlogPost> list = _dataAccess.GetAllBlogPostsBrief();
            TextFormatting.WriteLine("ID:".PadRight(15) + "Inlägg:".PadRight(50) + "Skribent:\n".PadRight(20));
            
            foreach (BlogPost bp in list)
            {
                TextFormatting.WriteLine(bp.Id.ToString().PadRight(15) + bp.Title.PadRight(50) + bp.Author.PadRight(20));
                
            }
            TextFormatting.WriteLine();
            TextFormatting.WriteLine();
            TextFormatting.WriteLine();
        }

        public void PageAddPost()
        {
            TextFormatting.Header("Skriv nytt blogginlägg");

            ShowAllBlogPostsBrief();

            TextFormatting.WriteLine("Vem har skrivit inlägget? ");

            string NewPostText = Console.ReadLine();

            TextFormatting.WriteLine("Vad står det i inlägget? ");

            string NewAuthor = Console.ReadLine();
            



            _dataAccess.CreateNewPost(NewPostText, NewAuthor);

            TextFormatting.WriteLine();

            TextFormatting.MenuItems3("Blogginlägg skapat");
            Console.ReadKey();
            PageMainMenu();


        }

        private void PageUpdatePost()
        {
            TextFormatting.Header("Uppdatera Inlägg");

            ShowAllBlogPostsBrief();

            TextFormatting.Write("Vilken bloggpost vill du uppdatera? ");

            int postId = int.Parse(Console.ReadLine());

            BlogPost blogpost = _dataAccess.GetPostById(postId);

            TextFormatting.WriteLine("Den nuvarande titeln är: " + blogpost.Title);

            TextFormatting.Write("Skriv in ny titel: ");

            string newTitle = Console.ReadLine();

            blogpost.Title = newTitle;

            _dataAccess.UpdateBlogpost(blogpost);

            TextFormatting.MenuItems("Blogginlägg uppdaterat");
            Console.ReadKey();
            PageMainMenu();

        }

        private void PageRemovePost()
        {
            TextFormatting.Header("Ta bort Inlägg");

                ShowAllBlogPostsBrief();

            TextFormatting.Write("Vilket blogginlägg vill du ta bort? ");

            int postId = int.Parse(Console.ReadLine());

            BlogPost blogpost = _dataAccess.GetPostById(postId);
            TextFormatting.WriteLine();

            _dataAccess.RemovePost(blogpost);
            TextFormatting.MenuItems2("Bloggposten är borttagen");
            Console.ReadKey();
            PageMainMenu();


        }

        private void PageAddComment()
        {
            TextFormatting.Header("Skriv en kommentar");

            ShowAllBlogPostsBrief();

            TextFormatting.Write("Vilket inlägg vill du skriva en kommentar till? ");

            int postId = int.Parse(Console.ReadLine());
            TextFormatting.WriteLine("Kommentera blogginlägg: ");
            string Newcomment = Console.ReadLine();

            _dataAccess.AddComment(postId, Newcomment);


            TextFormatting.MenuItems3("Kommentar tillagd");
            Console.ReadKey();
            PageMainMenu();
        }

        private void PageWatchComments()
        {
            TextFormatting.Header("Läs kommentarer");
            ShowAllBlogPostsBrief();
            TextFormatting.MenuItems2("\nESC) Gå tillbaka till huvudmenyn\n");
            TextFormatting.Write("Under vilket inlägg vill du läsa kommentarer? ");
            int PostId = int.Parse(Console.ReadLine());
          


            List<Comments> list = _dataAccess.WatchComments(PostId);
            int counter = 1;
            TextFormatting.MenuItems3($"\nDetta är kommentarerna för blogginlägget\n");
            foreach (Comments item in list)
            {
                TextFormatting.MenuItems($"Kommentar Nr: {counter}\t\t{item.Comment}");
                counter++;
            }
            TextFormatting.WriteLine();
            Console.ReadKey();
            PageMainMenu();
        }

        private void PageAddTags()
        {
            TextFormatting.Header("Tagga blogginlägg.");

            ShowAllBlogPostsBrief();

            TextFormatting.Write("Vilket inlägg vill du tagga?");
            int TagId = int.Parse(Console.ReadLine());

            TextFormatting.WriteLine("Tagga inlägget med #(Din tag här)");
            string Tagstring = Console.ReadLine();


            _dataAccess.AddTagsToPost(TagId, Tagstring);

            TextFormatting.WriteLine("Tag skapad");
            Console.ReadKey();
            PageMainMenu();

        }

        private void PageWatchTags()
        {
            TextFormatting.Header("Läs Taggar");
            ShowAllBlogPostsBrief();
            TextFormatting.Write("Under vilket inlägg vill du läsa taggar? ");
            int PostId = int.Parse(Console.ReadLine());



            List<Tag> list = _dataAccess.WatchTags(PostId);
            int counter = 1;
            TextFormatting.MenuItems3($"\nDetta är kommentarerna för blogginlägget\n");
            foreach (Tag item in list)
            {
                TextFormatting.MenuItems($"Tag Nr: {counter}\t\t {item.Tags}");
                counter++;
            }
            TextFormatting.WriteLine();
            Console.ReadKey();
            PageMainMenu();
        }

        private void ExitBloggy()
        {
            Console.Clear();

            TextFormatting.Header("Avsluta\n\n\n");



            TextFormatting.MenuItems2("Du vill antingen avsluta programmet eller så gjorde du inte ett val i huvudmenyn.\nVill du tillbaka till huvudmenyn klicka 'Enter'\nklicka valfri knapp för att stänga av.");
            ConsoleKey Exit = Console.ReadKey(true).Key;
            if (Exit == ConsoleKey.Enter)
                PageMainMenu();
            else
            {
                Console.Clear();
            }
        }
 

    }
}
