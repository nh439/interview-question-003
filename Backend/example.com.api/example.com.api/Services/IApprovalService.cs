using example.com.api.Repositories;
using example.com.database.Entity;
using example.com.shared.SharedModel;

namespace example.com.api.Services;

public interface IApprovalService
{
    Task<PagedItem<Approval>> ListApprovalAsync(string? searchName = null, int page = 1, int pageSize = 20);
    Task<int> ApproveAsync(IEnumerable<long> approvalIds, bool isApproved, string? approveReason);
    Task<bool> ResetAsync();
}

public class ApprovalService(ApprovalRepository approvalRepository) : IApprovalService
{
    public async Task<PagedItem<Approval>> ListApprovalAsync(string? searchName = null, int page = 1, int pageSize = 20)=>
    await approvalRepository.ListApprovalAsync(searchName, page, pageSize);
    
    public async Task<int> ApproveAsync(IEnumerable<long> approvalIds, bool isApproved, string? approveReason) => 
    await approvalRepository.ApproveAsync(approvalIds, isApproved, approveReason);

    public async Task<bool> ResetAsync() =>
        await approvalRepository.ResetAsync();

}