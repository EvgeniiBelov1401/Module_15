namespace M15U03Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>
            {
            new Contact("Игорь", 79990000001, "igor@example.com"),
            new Contact("Сергей", 79990000010, "serge@example.com"),
            new Contact("Анатолий", 79990000011, "anatoly@example.com"),
            new Contact("Валерий", 79990000012, "valera@example.com"),
            new Contact("Сергей", 799900000013, "serg@gmail.com"),
            new Contact("Иннокентий", 799900000013, "innokentii@example.com")
            };

            var groupingByEmail=phoneBook.GroupBy(x => x.Email.Split('@').Last());

            foreach (var grouping in groupingByEmail)
            {
                if (grouping.Key.Contains("example"))
                {
                    Console.WriteLine("Фейковые адреса: ");
                    foreach (var contact in grouping)
                    {
                        Console.WriteLine(contact.Name+" - "+contact.Email);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Реальные адреса: ");
                    foreach (var contact in grouping)
                    {
                        Console.WriteLine(contact.Name + " - " + contact.Email);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
