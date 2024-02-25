using TrainingCsharpAuctions.API.Entities;

namespace TrainingCsharpAuctions.API.Contracts;

public interface IUserRepository
{
    bool ExistUserWithEmail(string email);
    User GetUserByEmail(string email);
}