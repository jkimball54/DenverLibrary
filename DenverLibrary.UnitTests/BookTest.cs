namespace DenverLibrary.UnitTests
{
    public class BookTest
    {
        [Fact]
        public void Title_Get()
        {
            Book book1 = new Book("Title", "TestAuthor");
            Assert.Equal("Title", book1.Title);
        }
        [Fact]
        public void Title_Set()
        {
            Book book1 = new Book("Title", "TestAuthor");
            book1.Title = "New Title";
            Assert.Equal("New Title", book1.Title);
        }
        [Fact]
        public void Author_Get()
        {
            Book book1 = new Book("Title", "TestAuthor");
            Assert.Equal("TestAuthor", book1.Author);
        }
        [Fact]
        public void Author_Set()
        {
            Book book1 = new Book("Title", "TestAuthor");
            book1.Author = "New TestAuthor";
            Assert.Equal("New TestAuthor", book1.Author);
        }
        public void Book_Construction_Functions_Properly()
        {
            Book book1 = new Book("Title", "TestAuthor");
            Assert.Equal("Title", book1.Title);
            Assert.Equal("TestAuthor", book1.Author);
        }

    }
}