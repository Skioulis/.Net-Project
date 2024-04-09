using BlazorApp.Shared.Domain.Name;

namespace BlazorApp.Client.Static
{
    public class PersonRepository
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee() {Name = "Kwstas"},
            new Employee() {Name = "Fotis"},
            new Employee() {Name = "Alex"},
            new Employee() {Name = "Giorgos"},
            new Employee() {Name = "John"},
            new Employee() {Name = "William"},
            new Employee() {Name = "Katerina"},
            new Employee() {Name = "Anna"},
            new Employee() {Name = "Jane"},
            new Employee() {Name = "Matina"}

        };

        public static List<Manager> managers = new List<Manager>()
        {
            new Manager() {Name = "Amelia"},
            new Manager() {Name = "Liam"},
            new Manager() {Name = "Sophia"},
            new Manager() {Name = "Noah"},
            new Manager() {Name = "Elijah"},
            new Manager() {Name = "Ava"}
        };
    }
}
