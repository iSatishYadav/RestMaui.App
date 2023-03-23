namespace RestMaui.Models
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Content { get; set; }        
    }
}
