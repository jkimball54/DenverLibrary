namespace DenverLibrary.UnitTests
{
    public class LibraryTest
    {
        [Fact]
        public void Name_Get_Set_Tests()
        {
            var library1 = new Library("Test Library");
            Assert.Equal("Test Library", library1.Name);

            library1.Name = "Test2 Library";
            Assert.Equal("Test2 Library", library1.Name);
        }
        [Fact]
        public void BranchList_Get_Set_Tests()
        {
            var library1 = new Library("Test Library");
            Assert.Equal(new List<Branch>(), library1.Branches);

            var branch1 = new Branch("Branch1");
            var branch2 = new Branch("Branch2");
            var branches1 = new List<Branch>();
            branches1.Add(branch1);
            branches1.Add(branch2);

            library1.Branches = branches1;
            Assert.Equal(branches1, library1.Branches);
        }
        [Fact]
        public void Library_Constructor_Test()
        {
            Library testLibrary = new Library("Test Library");
            Assert.Equal("Test Library", testLibrary.Name);
            Assert.Equal(new List<Branch>(), testLibrary.Branches);
        }
        [Fact]
        public void BranchNames_Method_Test()
        {
            var branch1 = new Branch("Branch 1");
            var branch2 = new Branch("Branch 2");

            var library1 = new Library("Test Library");
            library1.Branches.Add(branch1);
            library1.Branches.Add(branch2);

            Assert.Equal(new List<string> { "Branch 1", "Branch 2" },
            library1.BranchNames());
        }
        [Fact]
        public void AllBooks_Method_Test()
        {
            var branch1 = new Branch("Branch 1");
            branch1.Books.Add(new Book("Book 1", "Author 1"));
            var branch2 = new Branch("Branch 2");
            branch2.Books.Add(new Book("Book 2", "Author 2"));

            var library1 = new Library("Test Library");
            library1.Branches.Add(branch1);
            library1.Branches.Add(branch2);

            Assert.Equal(new List<string> { "Book 1", "Book 2" },
            library1.AllBooks());
        }

    }

}