using example.com.database.Entity;
using example.com.shared.Constraint;

namespace example.com.database.Mock;

public static class ApprovalSeed
{
 public  static List<Approval> GetMockData() => new List<Approval>
    {
        new()
        {
            Id = 1, Name = "Purchase Request - Office Chairs", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 1, 9, 15, 0),
            ApproveBy = "admin", Reason = "Replacement for damaged chairs",
            ApproveReason = "Approved within department budget", RequestDate = new DateTime(2026, 8, 30, 14, 20, 0),
            RequestBy = "somchai"
        },
        new()
        {
            Id = 2, Name = "Purchase Request - Developer Laptops", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Rejected, ApproveDate = new DateTime(2026, 9, 1, 10, 30, 0),
            ApproveBy = "manager01", Reason = "New laptops for development team",
            ApproveReason = "Budget exceeded for this quarter", RequestDate = new DateTime(2026, 8, 29, 11, 10, 0),
            RequestBy = "nattapong"
        },
        new()
        {
            Id = 3, Name = "Leave Request - Somchai", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Annual leave", ApproveReason = null, RequestDate = new DateTime(2026, 9, 2, 8, 45, 0),
            RequestBy = "somchai"
        },
        new()
        {
            Id = 4, Name = "Purchase Request - Office Printer", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 2, 11, 20, 0),
            ApproveBy = "manager02", Reason = "Replace old printer",
            ApproveReason = "Approved after reviewing current equipment condition",
            RequestDate = new DateTime(2026, 8, 31, 15, 30, 0), RequestBy = "anan"
        },
        new()
        {
            Id = 5, Name = "Expense Claim - Customer Meeting", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 3, 13, 10, 0),
            ApproveBy = "admin", Reason = "Customer lunch meeting",
            ApproveReason = "Expense is within the approved limit", RequestDate = new DateTime(2026, 9, 1, 16, 40, 0),
            RequestBy = "wichai"
        },
        new()
        {
            Id = 6, Name = "Access Request - Production Database", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Required for production support", ApproveReason = null,
            RequestDate = new DateTime(2026, 9, 3, 14, 30, 0), RequestBy = "kittipong"
        },
        new()
        {
            Id = 7, Name = "Purchase Request - Network Equipment", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Rejected, ApproveDate = new DateTime(2026, 9, 4, 9, 40, 0),
            ApproveBy = "manager01", Reason = "Network upgrade", ApproveReason = "Required documents were not provided",
            RequestDate = new DateTime(2026, 9, 2, 10, 15, 0), RequestBy = "thana"
        },
        new()
        {
            Id = 8, Name = "Leave Request - Anan", IsPending = false, ApproveStatus = ApprovalStatusConstraint.Approved,
            ApproveDate = new DateTime(2026, 9, 4, 15, 5, 0), ApproveBy = "manager02", Reason = "Personal leave",
            ApproveReason = "Approved based on team availability", RequestDate = new DateTime(2026, 9, 2, 9, 20, 0),
            RequestBy = "anan"
        },
        new()
        {
            Id = 9, Name = "Expense Claim - Business Trip", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Travel expenses for client visit", ApproveReason = null,
            RequestDate = new DateTime(2026, 9, 5, 10, 15, 0), RequestBy = "ploy"
        },
        new()
        {
            Id = 10, Name = "Purchase Request - Software License", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 5, 16, 20, 0),
            ApproveBy = "admin", Reason = "Development software license",
            ApproveReason = "Approved for project development requirements",
            RequestDate = new DateTime(2026, 9, 3, 13, 25, 0), RequestBy = "siriporn"
        },

        new()
        {
            Id = 11, Name = "Overtime Request - Development Team", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Rejected, ApproveDate = new DateTime(2026, 9, 8, 9, 0, 0),
            ApproveBy = "manager01", Reason = "Additional development work",
            ApproveReason = "Overtime quota has been reached", RequestDate = new DateTime(2026, 9, 6, 17, 10, 0),
            RequestBy = "somchai"
        },
        new()
        {
            Id = 12, Name = "Access Request - Git Repository", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Required for project source code", ApproveReason = null,
            RequestDate = new DateTime(2026, 9, 8, 10, 45, 0), RequestBy = "nattapong"
        },
        new()
        {
            Id = 13, Name = "Purchase Request - Monitor Displays", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 9, 11, 30, 0),
            ApproveBy = "manager02", Reason = "Additional monitors for developers",
            ApproveReason = "Approved according to workstation requirements",
            RequestDate = new DateTime(2026, 9, 7, 14, 20, 0), RequestBy = "kittipong"
        },
        new()
        {
            Id = 14, Name = "Expense Claim - Transportation", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 9, 14, 15, 0),
            ApproveBy = "admin", Reason = "Transportation for client visit",
            ApproveReason = "Receipt and expense details were verified",
            RequestDate = new DateTime(2026, 9, 8, 9, 30, 0), RequestBy = "wichai"
        },
        new()
        {
            Id = 15, Name = "Leave Request - Wichai", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Vacation leave", ApproveReason = null, RequestDate = new DateTime(2026, 9, 10, 8, 30, 0),
            RequestBy = "wichai"
        },
        new()
        {
            Id = 16, Name = "Purchase Request - Conference Room TV", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Rejected, ApproveDate = new DateTime(2026, 9, 10, 13, 45, 0),
            ApproveBy = "manager01", Reason = "Upgrade conference room equipment",
            ApproveReason = "Request does not meet current equipment policy",
            RequestDate = new DateTime(2026, 9, 8, 15, 10, 0), RequestBy = "anan"
        },
        new()
        {
            Id = 17, Name = "Access Request - VPN Account", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 11, 10, 10, 0),
            ApproveBy = "manager02", Reason = "Remote work access",
            ApproveReason = "Approved for authorized remote access", RequestDate = new DateTime(2026, 9, 9, 11, 15, 0),
            RequestBy = "thana"
        },
        new()
        {
            Id = 18, Name = "Expense Claim - Hotel Accommodation", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Hotel cost during business trip", ApproveReason = null,
            RequestDate = new DateTime(2026, 9, 11, 15, 25, 0), RequestBy = "ploy"
        },
        new()
        {
            Id = 19, Name = "Purchase Request - Barcode Scanner", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 12, 9, 35, 0),
            ApproveBy = "admin", Reason = "Warehouse operation", ApproveReason = "Approved for warehouse operations",
            RequestDate = new DateTime(2026, 9, 10, 10, 40, 0), RequestBy = "kittipong"
        },
        new()
        {
            Id = 20, Name = "Overtime Request - QA Team", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Rejected, ApproveDate = new DateTime(2026, 9, 12, 16, 0, 0),
            ApproveBy = "manager01", Reason = "Additional testing work", ApproveReason = "Duplicate overtime request",
            RequestDate = new DateTime(2026, 9, 11, 16, 20, 0), RequestBy = "siriporn"
        },

        new()
        {
            Id = 21, Name = "Purchase Request - Meeting Room Table", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Replace damaged meeting table", ApproveReason = null,
            RequestDate = new DateTime(2026, 9, 15, 9, 20, 0), RequestBy = "somchai"
        },
        new()
        {
            Id = 22, Name = "Leave Request - Nattapong", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 15, 11, 10, 0),
            ApproveBy = "manager02", Reason = "Annual leave",
            ApproveReason = "Approved based on available leave balance",
            RequestDate = new DateTime(2026, 9, 13, 13, 20, 0), RequestBy = "nattapong"
        },
        new()
        {
            Id = 23, Name = "Expense Claim - Client Dinner", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 16, 13, 30, 0),
            ApproveBy = "admin", Reason = "Dinner with client representatives",
            ApproveReason = "Approved as a valid business expense", RequestDate = new DateTime(2026, 9, 14, 18, 10, 0),
            RequestBy = "anan"
        },
        new()
        {
            Id = 24, Name = "Access Request - Finance System", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Rejected, ApproveDate = new DateTime(2026, 9, 16, 15, 45, 0),
            ApproveBy = "manager01", Reason = "Temporary finance access",
            ApproveReason = "User does not require finance system access",
            RequestDate = new DateTime(2026, 9, 14, 10, 30, 0), RequestBy = "wichai"
        },
        new()
        {
            Id = 25, Name = "Purchase Request - Wireless Keyboard", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Replacement keyboard", ApproveReason = null, RequestDate = new DateTime(2026, 9, 17, 10, 0, 0),
            RequestBy = "thana"
        },
        new()
        {
            Id = 26, Name = "Purchase Request - Backup Storage", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 17, 14, 20, 0),
            ApproveBy = "manager02", Reason = "Additional backup capacity",
            ApproveReason = "Approved for backup infrastructure expansion",
            RequestDate = new DateTime(2026, 9, 15, 15, 40, 0), RequestBy = "kittipong"
        },
        new()
        {
            Id = 27, Name = "Leave Request - Kittipong", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 18, 9, 50, 0),
            ApproveBy = "admin", Reason = "Personal leave", ApproveReason = "Approved after reviewing team schedule",
            RequestDate = new DateTime(2026, 9, 16, 9, 15, 0), RequestBy = "kittipong"
        },
        new()
        {
            Id = 28, Name = "Access Request - HR Portal", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Required for employee management", ApproveReason = null,
            RequestDate = new DateTime(2026, 9, 18, 11, 35, 0), RequestBy = "siriporn"
        },
        new()
        {
            Id = 29, Name = "Expense Claim - Fuel Expenses", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Rejected, ApproveDate = new DateTime(2026, 9, 19, 13, 15, 0),
            ApproveBy = "manager01", Reason = "Fuel expense for customer visit",
            ApproveReason = "Expense details could not be verified", RequestDate = new DateTime(2026, 9, 17, 16, 25, 0),
            RequestBy = "somchai"
        },
        new()
        {
            Id = 30, Name = "Purchase Request - Standing Desks", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 19, 16, 30, 0),
            ApproveBy = "manager02", Reason = "Ergonomic workstation improvement",
            ApproveReason = "Approved for employee workstation improvement",
            RequestDate = new DateTime(2026, 9, 18, 14, 10, 0), RequestBy = "nattapong"
        },

        new()
        {
            Id = 31, Name = "Overtime Request - Support Team", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Weekend system maintenance", ApproveReason = null,
            RequestDate = new DateTime(2026, 9, 20, 9, 15, 0), RequestBy = "anan"
        },
        new()
        {
            Id = 32, Name = "Purchase Request - Air Conditioner", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 20, 10, 40, 0),
            ApproveBy = "admin", Reason = "Replacement of faulty unit",
            ApproveReason = "Approved due to equipment replacement requirement",
            RequestDate = new DateTime(2026, 9, 18, 10, 20, 0), RequestBy = "wichai"
        },
        new()
        {
            Id = 33, Name = "Leave Request - Siriporn", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Rejected, ApproveDate = new DateTime(2026, 9, 21, 11, 25, 0),
            ApproveBy = "manager01", Reason = "Vacation leave", ApproveReason = "Insufficient leave balance",
            RequestDate = new DateTime(2026, 9, 19, 9, 35, 0), RequestBy = "siriporn"
        },
        new()
        {
            Id = 34, Name = "Expense Claim - Parking Fee", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 21, 13, 40, 0),
            ApproveBy = "manager02", Reason = "Parking during client visit",
            ApproveReason = "Approved with valid receipt", RequestDate = new DateTime(2026, 9, 20, 11, 50, 0),
            RequestBy = "ploy"
        },
        new()
        {
            Id = 35, Name = "Access Request - AWS Console", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Cloud infrastructure management", ApproveReason = null,
            RequestDate = new DateTime(2026, 9, 22, 8, 50, 0), RequestBy = "thana"
        },
        new()
        {
            Id = 36, Name = "Purchase Request - Projector", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 22, 14, 10, 0),
            ApproveBy = "admin", Reason = "Presentation equipment",
            ApproveReason = "Approved for meeting and presentation requirements",
            RequestDate = new DateTime(2026, 9, 20, 15, 15, 0), RequestBy = "kittipong"
        },
        new()
        {
            Id = 37, Name = "Overtime Request - Infrastructure Team", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Rejected, ApproveDate = new DateTime(2026, 9, 23, 9, 30, 0),
            ApproveBy = "manager01", Reason = "Infrastructure maintenance", ApproveReason = "Overtime quota exceeded",
            RequestDate = new DateTime(2026, 9, 21, 17, 30, 0), RequestBy = "somchai"
        },
        new()
        {
            Id = 38, Name = "Expense Claim - Office Supplies", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 23, 15, 20, 0),
            ApproveBy = "manager02", Reason = "Stationery and office supplies",
            ApproveReason = "Approved as standard office expense", RequestDate = new DateTime(2026, 9, 22, 10, 10, 0),
            RequestBy = "anan"
        },
        new()
        {
            Id = 39, Name = "Purchase Request - Security Cameras", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Improve office security", ApproveReason = null, RequestDate = new DateTime(2026, 9, 24, 10, 5, 0),
            RequestBy = "nattapong"
        },
        new()
        {
            Id = 40, Name = "Leave Request - Ploy", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 24, 13, 15, 0),
            ApproveBy = "admin", Reason = "Annual leave", ApproveReason = "Approved according to leave policy",
            RequestDate = new DateTime(2026, 9, 22, 13, 30, 0), RequestBy = "ploy"
        },

        new()
        {
            Id = 41, Name = "Access Request - Docker Registry", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Rejected, ApproveDate = new DateTime(2026, 9, 25, 9, 45, 0),
            ApproveBy = "manager01", Reason = "Container deployment access",
            ApproveReason = "Requested access level is too high", RequestDate = new DateTime(2026, 9, 23, 11, 20, 0),
            RequestBy = "wichai"
        },
        new()
        {
            Id = 42, Name = "Purchase Request - Network Switch", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 25, 11, 30, 0),
            ApproveBy = "manager02", Reason = "Network expansion",
            ApproveReason = "Approved for network infrastructure upgrade",
            RequestDate = new DateTime(2026, 9, 23, 14, 40, 0), RequestBy = "thana"
        },
        new()
        {
            Id = 43, Name = "Expense Claim - Training Course", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Technical training course", ApproveReason = null,
            RequestDate = new DateTime(2026, 9, 26, 10, 15, 0), RequestBy = "siriporn"
        },
        new()
        {
            Id = 44, Name = "Purchase Request - Server Rack", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 26, 14, 45, 0),
            ApproveBy = "admin", Reason = "New server room equipment",
            ApproveReason = "Approved for infrastructure expansion", RequestDate = new DateTime(2026, 9, 24, 16, 20, 0),
            RequestBy = "kittipong"
        },
        new()
        {
            Id = 45, Name = "Leave Request - Thana", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Rejected, ApproveDate = new DateTime(2026, 9, 27, 9, 10, 0),
            ApproveBy = "manager01", Reason = "Annual leave",
            ApproveReason = "Request conflicts with critical project deadline",
            RequestDate = new DateTime(2026, 9, 25, 9, 25, 0), RequestBy = "thana"
        },
        new()
        {
            Id = 46, Name = "Access Request - Monitoring Dashboard", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Application monitoring access", ApproveReason = null,
            RequestDate = new DateTime(2026, 9, 27, 11, 50, 0), RequestBy = "somchai"
        },
        new()
        {
            Id = 47, Name = "Expense Claim - Hotel Parking", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 28, 13, 25, 0),
            ApproveBy = "manager02", Reason = "Parking during business trip",
            ApproveReason = "Approved with supporting receipt", RequestDate = new DateTime(2026, 9, 26, 15, 30, 0),
            RequestBy = "anan"
        },
        new()
        {
            Id = 48, Name = "Purchase Request - Employee Tablets", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Approved, ApproveDate = new DateTime(2026, 9, 29, 10, 35, 0),
            ApproveBy = "admin", Reason = "Mobile devices for field employees",
            ApproveReason = "Approved for field operation requirements",
            RequestDate = new DateTime(2026, 9, 27, 10, 45, 0), RequestBy = "nattapong"
        },
        new()
        {
            Id = 49, Name = "Overtime Request - Mobile Team", IsPending = true,
            ApproveStatus = ApprovalStatusConstraint.Pending, ApproveDate = null, ApproveBy = "",
            Reason = "Additional mobile application development", ApproveReason = null,
            RequestDate = new DateTime(2026, 9, 29, 15, 10, 0), RequestBy = "ploy"
        },
        new()
        {
            Id = 50, Name = "Purchase Request - Backup Server", IsPending = false,
            ApproveStatus = ApprovalStatusConstraint.Rejected, ApproveDate = new DateTime(2026, 9, 30, 16, 20, 0),
            ApproveBy = "manager01", Reason = "Additional backup infrastructure",
            ApproveReason = "Project budget is not available", RequestDate = new DateTime(2026, 9, 28, 14, 35, 0),
            RequestBy = "wichai"
        }
    };
}