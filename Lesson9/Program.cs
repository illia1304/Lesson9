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

        static void WriteAllContactsToConsole()
        {
            
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

        static void CalculateAge()
        {

        }

        static void SaveDateBase()
        {

        }

    }
}