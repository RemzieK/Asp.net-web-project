namespace EVA.Models
{
    public class ApodDto
    {
        public DateTime Date { get; set; }
        public string? Title { get; set; }
        public string? Explanation { get; set; }
        public string? Url { get; set; }
    }

    public class ApodDetailDto
    {
        public string? CopyRight { get; set; }
        public DateTime Date { get; set; }
        public string? Explanation { get; set; }
        public string? Hdurl { get; set; }
        public string? MediaType { get; set; }
        public string? ServiceVersion { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }

    }
}
