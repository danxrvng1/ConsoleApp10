namespace laba_1
{
    public class Library
    {
        public Library(string name, string adress, int year)
        {
            Name = name;
            Adress = adress;
            Year = year;
        }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Year { get; set; }
    }
}