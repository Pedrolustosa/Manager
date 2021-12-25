
namespace Manager.Infra.Interfaces
{
    public interface IUserRepostory : IBaseRepostory<User>
    {
        Task<User> GetByEmail(string email);
        Task<List<User>> SearchByEmail(string email);
        Task<List<User>> SearchByName(string name);
    }
}