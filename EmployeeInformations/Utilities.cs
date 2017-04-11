using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformations
{
    public class Constant
    {
        public static string EmployeeInformation = "Employee Information";
        public static string FirstName = "First Name";
        public static string LastName = "Last Name";
        public static string DateOfBirth = "Date Of Birth";
        public static string Gender = "Gender";
        public static string persentAddress = "Persent Address";
        public static string permanentAddress = "Permanent Address";
        public static string ResidenceNo = "Residence Contact No";
        public static string ResidenceNo1 = "Residence Contact No1";
        public static string MobileNo = "Mobile Number";
        public static string MartialStatus = "Martial Status";
        public static string MarriageDate = "Marriage Date";
        public static string NoOfkids = "No of Kids";
        public static string EmployeeName = "Employee-Name";
        public static string DateSigned = "Date ( Signed )";
        public static string PlaceSigned = "Place ( Signed )";
        public static string EmployementType = "Employement Type";

        public static string FamilyDetails = "Family Details";
        public static string FamilyName = "Family Name";
        public static string FamilyDateOfBirth = "Date Of Birth";
        public static string FamilyGender = "Gender";
        public static string FamilyRelationship = "Relationship";
        public static string FamilyOccupation = "Occupation";

        public static string MedicalCondition = "Medical Condition";
        public static string BloodGroup = "Blood Group";
        public static string Ailments = "Ailments";
        public static string Allergies = "Allergies";
        public static string OtherMedical = "Medications";

        public static string EmergencyContactDetails= "Emergency Contact Details";
        public static string ContactPersonName="Contact Person Name";
        public static string ContactRelations="Contact Relations";
        public static string EmergencyLandlineno = "Landline no";
        public static string EmergencyMobileNumber = "Mobile Number";

        public static string EducationQualification = "Education Qualification";
        public static string Degree = "Degree";
        public static string university = "university";
        public static string From = "From";
        public static string To = "To";
        public static string Percentage = "Percentage";

        public static string EmployeeIdentityandAddressProofs = "Employee Identity and Address Proofs";
        public static string AadharNumber = "Aadhar number";
        public static string PancardNumber = "Pancard number";
        public static string PassportNumber = "Passport number";
        public static string BankAc = "Bank Ac";
        public static string PF = "PF";
        public static string UAN = "UAN";
        public static string ESIC = "ESIC";
        public static string twowheeler = "Mode of Transport - Two Wheeler Vehicle No";
        public static string fourwheeler = "Mode of Transport - Four  Wheeler Vehicle No";
        public static string PublicTransport = "Mode of Transport - Public Transport";

        public static string EmployeeReferences = "Employee References";
        public static string ReferenceName = "Reference Name";
        public static string ReferenceWorkingIn = "Working In";
        public static string ReferenceWorkingAs = "Working As";
        public static string ReferenceContactNo = "Contact No";


        public static string EmployeePreviousExperience = "Employee Previous Experience/Contract Details";
        public static string PreviousCompany="Company Name";
        public static string PreviousDesignation="Designation";
        public static string PreviousDateofjoining="Date of joining";
        public static string PreviousDateofRelieving="Date of Relieving";
        public static string PreviousContactNo="Contact No";
        public static string PreviousReason = "Reason";
        public static string ContractDuration = "Duration";
        public static string ContractContactPerson = "Contact Person";
        

        public static string EmployeesPhotos = "Employees Photos";
        public static string EmployeesSignature = "Employees Signature";


        public static string RedirectionLink = "/Pages/Employee-Information-Retrieve.aspx?EmpID=";
        public static string RedirectionLink_Description = "View Employee Detail";
        public static string ViewDetailLink = "View Detail";


        public static string EmployeeType_Permanent = "Permanent";
        public static string EmployeeType_Contract = "Contract";

    }

    public class Employee_FamilyEntity
    {
      
        public string FamilyName { get; set; }
        public string FamilyDateOfBirth { get; set; }
        public string FamilyGender { get; set; }
        public string FamilyRelationship { get; set; }
        public string FamilyOccupation { get; set; }

    }

    public class Emergency_ContactDatils
    {
        public string ContactPersonName { get; set; }
        public string ContactRelations { get; set; }
        public string EmergencyLandlineno { get; set; }
        public string EmergencyMobileNumber { get; set; }
    }

    public class Education_Qualification
    {
        public string Degree { get; set; }
        public string university { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Percentage { get; set; }
    }

    public class Employee_References
    {
        public string ReferenceName { get; set; }
        public string ReferenceWorkingIn { get; set; }
        public string ReferenceWorkingAs { get; set; }
        public string ReferenceContactNo { get; set; }
    }

    public class Employee_PreviousExperience
    {
        public string PreviousCompany { get; set; }
        public string PreviousDesignation { get; set; }
        public string PreviousDateofjoining { get; set; }
        public string PreviousDateofRelieving { get; set; }
        public string PreviousContactNo { get; set; }
        public string PreviousReason { get; set; }

    }

    public class Employee_ContractDetails
    {
        public string ContractCompany { get; set; }
        public string ContractDesignation { get; set; }
        public string ContractDOJ { get; set; }
        public string ContractDuration { get; set; }
        public string ContractContactPerson { get; set; }
        public string ContractContactNo { get; set; }
    }

  

}
