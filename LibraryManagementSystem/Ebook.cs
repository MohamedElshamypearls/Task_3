namespace LibraryManagementSystem
{
    public class Ebook : Book
    {
        public double FileSize { get; set; } 

        public Ebook(string title, string author, string isbn, double fileSize)
            : base(title, author, isbn)
        {
            FileSize = fileSize;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"File Size: {FileSize} MB");
        }

    }

}
