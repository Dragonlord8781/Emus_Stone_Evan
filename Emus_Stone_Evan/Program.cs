namespace Emus_Stone_Evan
{

    enum Months //sets up enum Months
    {
        Jan = 1, //lists the months, starting with Jan, and sets the value starting at 1 instead of 0
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program 19"); //writes program number

            //sets and assigns myBirthdayMonth - Jun, myBirthDay - 3, myBirthYear - 2008 
            int myBirthdayMonth = (int)Months.Jun;
            int myBirthDay = 3;
            int myBirthYear = 2008;

            //creates the string myBirthDate and assigns a string that states the date of my birthday using myBirthdayMonth, myBirthDay, & myBirthYear
            string myBirthDate = $"My birthday is on {myBirthdayMonth}/{myBirthDay}/{myBirthYear}";

            //creates myFile and writes a string in it, then reads all text in myFile
            File.WriteAllText("myFile.txt", "File formed\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            //adds another string to myFile, then reads all text in myFile
            File.AppendAllText("myFile.txt", "File missing birthdate\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            //if the file newFile exists then copy myFile to newFile, else replace myFile with newFile along with backupFile
            if (!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }

            //adds myBirthDate to newFile, then reads text in myFile
            File.AppendAllText("newfile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("myFile.txt"));
        }
    }
}