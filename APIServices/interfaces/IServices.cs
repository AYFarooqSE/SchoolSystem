namespace SchoolSystem.interfaces
{
    public interface IServices
    {
        Task<T> GetServiceAsync<T>();
    }
}
