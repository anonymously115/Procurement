namespace Procurement.Models
{
    public class EmployeeBelonging
    {
        public int Id { get; set; }
        public int EmployeeCode { get; set; }
        public string? EmployeeFullName { get; set; }
        public int EmployeeAffiliationOrganizationCode { get; set; }
        public string? EmployeeAffiliationOrganizationName { get; set; }
        public int EmployeeAffiliationUpperOrganizationCode { get; set; }
        public string? EmployeeAffiliationUpperOrganizationName { get; set; }
        public int EmployeeJobTitleCode { get; set; }
        public string? EmployeeHandJobTitle { get; set; }
        public int ReportTargetEmployeeCode { get; set; }
        public string? ReportTargetEmployeeFullName { get; set; }

    }
}
