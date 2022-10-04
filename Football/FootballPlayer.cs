namespace Football
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + Age + " " + ShirtNumber;
        }   

        public void ValidateName()
        {
            if (Name == null)
                throw new ArgumentNullException("Name cannot be null");
            if (Name.Length < 2)
                throw new ArgumentException("Name needs to be at least 2 characters");
        }
        public void ValidateAge()
        {
            if (Age < 1)
                throw new ArgumentOutOfRangeException("Age must be above 1");
        }
        public void ValidateShirtNumber()
        {
            if (ShirtNumber < 1)
                throw new ArgumentOutOfRangeException("Shirt number cannot be below 1");
            if (ShirtNumber > 99)
                throw new ArgumentOutOfRangeException("Shirt number cannot be above 99");


        }
        public void Validate()
        {
            ValidateName();
            ValidateAge();
            ValidateShirtNumber();
        }



    }
}