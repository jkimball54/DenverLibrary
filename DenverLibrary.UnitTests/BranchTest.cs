namespace DenverLibrary.UnitTests
{
    public class BranchTest
    {
        [Fact]
        public void Name_Get_Set_Tests()
        {
            var testBranch = new Branch("Test Branch");
            Assert.Equal("Test Branch", testBranch.Name);
            testBranch.Name = "Set Test Branch";
            Assert.Equal("Set Test Branch", testBranch.Name);
        }
        [Fact]
        public void Books_Get_Set_Tests()
        {
            var testBranch = new Branch("Test Branch");
            Assert.Equal(new List<Book>(), testBranch.Books);
            
            var book1 = new Book("Book1", "Author1");
            var book2 = new Book("Book2", "Author2");
            var books1 = new List<Book>();
            books1.Add(book1);
            books1.Add(book1);

            testBranch.Books = books1;
            Assert.Equal(books1, testBranch.Books);
        }
        [Fact]
        public void AllAuthors_Returns_AuthorList()
        {
            var testBranch = new Branch("Test Branch");

            var book1 = new Book("Book1", "Author1");
            var book2 = new Book("Book2", "Author2");

            testBranch.Books.Add(book1);
            testBranch.Books.Add(book2);

            var authorList = new List<string>();
            authorList = testBranch.AllAuthors();

            foreach(var book in testBranch.Books)
            {
                Assert.Equal(true, authorList.Contains(book.Author));
            }

            Assert.Equal(2, testBranch.Books.Count);
        }
    }
}
