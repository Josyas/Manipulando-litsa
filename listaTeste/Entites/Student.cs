namespace listaTeste.Entites
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Grades { get; set; }

        public Student(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }

        public override string ToString()
        {
            return "Id: " + Id
                 + "\nName: " + Name
                 + "\nLast name: " + LastName;
        }
    }
}
