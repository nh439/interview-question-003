using example.com.database;
using example.com.database.Entity;
using example.com.shared.SharedModel;
using Microsoft.EntityFrameworkCore;

namespace example.com.api.Repositories;

public class ApprovalRepository(DataContext context)
{
    private readonly DbSet<Approval> _entity = context.Approvals;

    public async Task<PagedItem<Approval>> ListApprovalAsync(string? searchName = null, int page = 1, int pageSize = 20)
    {
        var query = _entity.AsQueryable();
        if (!string.IsNullOrEmpty(searchName))
            query = query.Where(w => w.Name.Contains(searchName));
        query = query.OrderBy(w => w.Name);
        var totalItems = await query.CountAsync();
        return new PagedItem<Approval>()
        {
            Items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync(),
            TotalItems = totalItems,
            LastPage = (int)Math.Ceiling((decimal)totalItems / pageSize)
        };
    }
    
}