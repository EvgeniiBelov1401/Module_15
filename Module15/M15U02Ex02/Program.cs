namespace M15U02Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 79994500508 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675334 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };

            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.Name+" - "+contact.Phone);
            }

            Console.WriteLine($"Неверных контактов: {contacts.Count(x=>x.Phone.ToString().Length!=11 ||
            !x.Phone.ToString().StartsWith('7'))} шт");
        }
    }
}
