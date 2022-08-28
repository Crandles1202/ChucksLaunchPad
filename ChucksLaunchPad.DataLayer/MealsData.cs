using Dapper.Database;

namespace ChucksLaunchPad.DataLayer;

public interface IMealsData : ISqlDatabase
{
}

public class MealsData : SqlDatabase, IMealsData
{
    public MealsData(IConnectionService connectionService) : base(connectionService)
    {
    }
}