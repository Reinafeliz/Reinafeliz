namespace API.Dtos
{
    public class CountriesDto
    {
        public int Id { get; set; }
        public string ISO { get; set; }
        public string Name { get; set; }
        public string NiceName { get; set; }
        public string ISO3 { get; set; }
        public int NumCode { get; set; }
        public int PhoneCode { get; set; }
        public bool IsActive { get; set; }
    }
}