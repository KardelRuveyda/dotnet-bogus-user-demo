class Program
{
    static void Main(string[] args)
    {
        #region Statik Metod Kullanarak Faker Nesnesi Tanımlama
        // Statik metod kullanarak sahte kullanıcıları oluşturuyoruz
        var generatorStatic = BogusUserGenerator.CreateFaker(); // Faker<User> nesnesi
        var usersStatic = generatorStatic.Generate(10); // 10 adet sahte kullanıcı oluşturuyoruz

        // Statik metod ile oluşturduğumuz kullanıcıları yazdırıyoruz
        Console.WriteLine("Statik Metod ile Oluşturulan Kullanıcılar:");
        foreach (var user in usersStatic)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName} - {user.Email}");
        }
        #endregion

        #region Faker Sınıfından Türetilmiş Bir Alt Sınıf Kullanma
        // UserGenerator sınıfından nesne oluşturuyoruz
        var generatorSubclass = new UserGenerator(); // UserGenerator nesnesi
        var usersSubclass = generatorSubclass.Generate(10); // 10 adet sahte kullanıcı oluşturuyoruz

        // Alt sınıf ile oluşturduğumuz kullanıcıları yazdırıyoruz
        Console.WriteLine("\nFaker Alt Sınıf ile Oluşturulan Kullanıcılar:");
        foreach (var user in usersSubclass)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName} - {user.Email}");
        }
        #endregion
    }
}
