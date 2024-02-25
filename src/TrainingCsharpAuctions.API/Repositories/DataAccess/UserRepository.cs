using TrainingCsharpAuctions.API.Contracts;
using TrainingCsharpAuctions.API.Entities;

namespace TrainingCsharpAuctions.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly TrainingCsharpAuctionsDbContext _dbContext;
    public UserRepository(TrainingCsharpAuctionsDbContext dbContext) => _dbContext = dbContext;

    public bool ExistUserWithEmail(string email)
    {
        return _dbContext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(string email) => _dbContext.Users.First(user => user.Email.Equals(email));
}