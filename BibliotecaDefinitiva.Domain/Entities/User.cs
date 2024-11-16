namespace BibliotecaDefinitiva.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? Surname { get; set; } 
        public DateTime BirthDate { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }

    }   

}