﻿namespace BulkOperations.EntityFramework.Tests.Model
{
    public class UspGetEmployeeManagersReturnModel
    {
        public int? RecursionLevel { get; set; }
        public int? BusinessEntityID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OrganizationNode { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
    }
}