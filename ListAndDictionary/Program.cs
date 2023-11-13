using System.Reflection.Metadata.Ecma335;

namespace ListAndDictionary
{
    internal class Program
    {
        // List variable containing names of persons
        private static List<string> personList = new List<string>();

        // Dictionary containing person name and age where the string TKey is for name and the int TValue is for age
        private static Dictionary<string, int> personAgeDictionary = new Dictionary<string, int>();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Person Manager!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add New Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Find Person");
                Console.WriteLine("4. List All Persons");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        RemovePerson();
                        break;
                    case "3":
                        FindPerson();
                        break;
                    case "4":
                        DisplayAllPersons();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public static void AddPerson()
        {
            // TODO 1: Request user input for the person's name.
            Console.WriteLine("Please enter a name");
            string personname = Console.ReadLine();
            // TODO 2: Validate if the person already exists in the personList.
            int excheck = personList.IndexOf(personname);

            // TODO 3: Add the person to the personList if they don't already exist.
            if (excheck == -1)
            {
                personList.Add(personname);
                Console.WriteLine("Person has been added");
            }
            // TODO 4: Provide user feedback for successful addition or if the person already exists in personList.
            else
            {
                Console.WriteLine("Person already exists");
                return;
            }
            // TODO 5: Validate if the person already exists in the personAgeDictionary.
            bool excheck1 = personAgeDictionary.ContainsKey(personname);


            // TODO 6: If they don't exist, request age input and add the person to the personAgeDictionary.
            //         NOTE!: Remember to add both TKey and TValue\
            // TODO 7: Provide user feedback for successful addition or if the person already exists in personAgeDictionary.
            if (excheck1 == false)
            {
                Console.WriteLine("Please enter age of person");
                int age1 = Convert.ToInt32(Console.ReadLine());
                personAgeDictionary.Add(personname,age1);
                Console.WriteLine("Person and age has been added");
            }
            
            else
            {
                Console.WriteLine("Person already exists in dictionary");
            }
        }

        public static void RemovePerson()
        {
            // TODO 8: Request user input for the name of the person to remove.
            Console.WriteLine("Enter name to remove");
            string removename = Console.ReadLine();
            // TODO 9: Remove the person from personList if they exist.
            int excheck = personList.IndexOf(removename);
            if (excheck == -1)
            {
                Console.WriteLine("Person does not exist");
                return;
            }
            else
            {
                personList.Remove(removename);
                Console.WriteLine(removename+" has been removed");
            }
            // TODO 10: Provide user feedback for successful removal or if the person doesn't exist in personList.
            // TODO 11: Remove the person from personAgeDictionary if they exist.
            // TODO 12: Provide user feedback for successful removal or if the person doesn't exist in personAgeDictionary.
            bool excheck2 = personAgeDictionary.ContainsKey(removename);
            if (excheck2 == true)
            {
                personAgeDictionary.Remove(removename);
                Console.WriteLine(removename+" has been removed from dictionary");
            }
            else
            {
                Console.WriteLine(removename+" does not exists in dictionary");
            }
            
        }

        public static void FindPerson()
        {
            // TODO 13: Request user input for the name of the person to find.
            Console.WriteLine("Enter name of person to find");
            string findname1= Console.ReadLine();
            // TODO 14: Check if the person is in personList and provide appropriate feedback.
            int excheck3 = personList.IndexOf(findname1);
            if (excheck3 == -1)
            {
                Console.WriteLine(findname1+" does not exist");
                return;
            }
            else
            {
                Console.WriteLine(findname1+" exists in index number: "+excheck3);
            }
            // TODO 15: Check if the person is in personAgeDictionary and provide appropriate feedback.
            bool excheck4 = personAgeDictionary.ContainsKey(findname1);
            if (excheck4 == true)
            {
                int age = Convert.ToInt32(personAgeDictionary[findname1]);
                Console.WriteLine(findname1+" exists in dictionary, age "+age);
            }
            else
            {
                Console.WriteLine(findname1+" does not exists in dictionary");
            }
        }

        public static void DisplayAllPersons()
        {
            // TODO 16: Iterate over personList and display each person's name.
            foreach (string names in personList)
            {
                Console.WriteLine(names);
            }
            // TODO 17: Iterate over personAgeDictionary and display each person's name and age.
            foreach (KeyValuePair<string, int> names in personAgeDictionary)
            {
                Console.WriteLine("Name: {0}, Age: {1}", names.Key, names.Value);
            }
            // TODO 18: Consider handling the case where the lists are empty by providing feedback to the user.
            if (personList.Count ==0)
            {
                Console.WriteLine("Name list is empty");
            }
            if (personAgeDictionary.Count ==0)
            {
                Console.WriteLine("Dictionary is empty");
            }
        }
    }
}
