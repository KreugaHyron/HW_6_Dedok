using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_Dedok
{
    public class Play : IDisposable
    {
        private string title;
        private string authorFullName;
        private string genre;
        private int year;
        private bool disposed = false;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string AuthorFullName
        {
            get { return authorFullName; }
            set { authorFullName = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 0)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentException("Year must be positive.");
                }
            }
        }
        public Play(string title, string authorFullName, string genre, int year)
        {
            Title = title;
            AuthorFullName = authorFullName;
            Genre = genre;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {AuthorFullName}\nGenre: {Genre}\nYear: {Year}");
        }

        ~Play()
        {
            Console.WriteLine("Destructor called for Play.");
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Disposing managed resources.");
                }

                Console.WriteLine("Disposing unmanaged resources.");
                disposed = true;
            }
        }
    }

}
