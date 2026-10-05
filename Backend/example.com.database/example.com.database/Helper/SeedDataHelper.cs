using example.com.database.Mock;
using Microsoft.EntityFrameworkCore;

namespace example.com.database.Helper;

public static class SeedDataHelper
{
    public static async Task<bool> ResetData(this DataContext dataContext)
    {
        try
        {
            using ( var transaction = dataContext.Database.BeginTransaction() )
            {
                await dataContext.Approvals.ExecuteDeleteAsync();
                var data = ApprovalSeed.GetMockData();
                await dataContext.Approvals.AddRangeAsync(data);
                await dataContext.SaveChangesAsync();
                await transaction.CommitAsync();
                return true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }
}