using Bogus;
using Weighter.Core.Enums;
using Weighter.Core.Models.Database;

namespace Weighter.Tests.Factories
{
    public static class UserModelFactory
    {
        public static UserModel GetModel()
        {
            return GetModels(1).First();
        }

        public static IEnumerable<UserModel> GetModels(int count = 5)
        {
            return new Faker<UserModel>()
                .RuleFor(x => x.Id, f => f.IndexFaker)
                .RuleFor(x => x.Gender, f => f.PickRandomParam<Gender>())
                .RuleFor(x => x.Nickname, f => f.Person.UserName)
                .RuleFor(x => x.LastName, f => f.Person.LastName)
                .RuleFor(x => x.FirstName, f => f.Person.FirstName)
                .RuleFor(x => x.LastLogin, f => f.Date.Recent())
                .RuleFor(x => x.DateOfBirth, f => f.Date.Past())
                .Generate(count);
        }
    }
}