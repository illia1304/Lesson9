namespace Lesson9
{
    // 0. SAVE IT TO THE FILE WITH ".CSV"
    // 1. Writes to console currently available contacts in the file
    // 2. Add new contact
    // 3. Edit contact
    // 4. Search contacts
    // 5. Calculates the contact age
    // 6. Save database
    internal class Program
    {
        static string database = "db.txt";
        static (string name, string phone, DateTime birth)[] contacts;
        static void Main(string[] args)
        {
            string[] records = ReadFile(database);
            contacts = ConvertStringsToContacts(records);

            while (true)
            {
                UserInteraction();
            }
        }

        static string[] ReadFile(string file)
        {
            if (!File.Exists(file))
            {
                File.WriteAllText(file, "");
            }

            return File.ReadAllLines(file);
        }

        static (string, string, DateTime)[] ConvertStringsToContacts(string[] records)
        {
            var contacts = new(string name, string phone, DateTime birth)[records.Length];

            for(int i = 0; i < records.Length; i++)
            {
                string[] array = records[i].Split(",");
                
                if(array.Length != 3)
                {
                    Console.WriteLine($"Contact{i + 1} can't be parsed");
                    continue;
                }

                contacts[i].name = array[0];
                contacts[i].phone = array[1];
                contacts[i].birth = DateTime.Parse(array[2]);
            }

            return contacts;
        }


        static void UserInteraction()
        {
            Console.WriteLine("1. Write all contacts");
            Console.WriteLine("2. Add new contact");
            Console.WriteLine("3. Edit contact");
            Console.WriteLine("4. Search by name");
            Console.WriteLine("6. Save");

            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: break;
                case 6: break;
                default: 
                    Console.WriteLine("From 1 to 6");
                    break;
            }
        }
        static void WriteAllContactsToConsole()
        {
            for(int i =0; i < contacts.Length; i++)
            {
                int age = DateTime.Now.Year - contacts[i].birth.Year;
                Console.WriteLine($"#{i + 1}: Name: {contacts[i].Item1}, Phone: {contacts[i].Item2}, Age: {age}");
            }
        }
        static void AddNewContact()
        {

        }

        static void EditContact()
        {

        }

        static void SearchContactByName()
        {

        }

        static void SearchContactByPhone()
        {

        }

        static void SaveDateBase()
        {
            string[] lines = new string[contacts.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = $"{contacts[i].Item1},{contacts[i].Item2},{contacts[i].Item3}";
            }
            File.WriteAllLines(database, lines);
        }

    }
}