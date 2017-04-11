using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;

namespace EmployeeInformations.EmployeeInforetrieve
{
    [ToolboxItemAttribute(false)]
    public partial class EmployeeInforetrieve : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public EmployeeInforetrieve()
        {
        }

       // public string EmployeeType = Constant.EmployeeType_Permanent;


        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
            ChromeType = PartChromeType.None;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate
                {

                    using (SPSite site = new SPSite(SPContext.Current.Web.Url))
                    {
                        using (SPWeb web = site.OpenWeb())
                        {
                            String query_EmpID = Page.Request.QueryString["EmpID"].ToString();
                            SPQuery oquery = new SPQuery();
                            PushData_EmployeeInformation(oquery, query_EmpID);

                        }
                    }
                });
            }
            catch (Exception ex)
            {
            }
        }


        private void PushData_EmployeeInformation(SPQuery qry, string EmpID)
        {
            var EmpInfo = SPContext.Current.Web.Lists.TryGetList(Constant.EmployeeInformation);

            qry.Query = @"<ViewFields>
                                <FieldRef Name='FirstName' />
                                <FieldRef Name='Last_x0020_Name' />
                                <FieldRef Name='Date_x0020_Of_x0020_Birth' />
                                <FieldRef Name='Gender' />
                                <FieldRef Name='Persent_x0020_Address' />
                                <FieldRef Name='Permanent_x0020_Address' />
                                <FieldRef Name='Residence_x0020_Contact_x0020_No' />
                                <FieldRef Name='Residence_x0020_Contact_x0020_No0' />
                                <FieldRef Name='CellPhone' />
                                <FieldRef Name='Martial_x0020_Status' />
                                <FieldRef Name='Marriage_x0020_Date' />
                                <FieldRef Name='No_x0020_of_x0020_Kids' />  
                                <FieldRef Name='Employement_x0020_Type0' />                                          
                                </ViewFields>                                  
                                <Where>                                        
                                <Eq>                                           
                                <FieldRef Name='ID' />                         
                                <Value Type='Counter'>" + int.Parse(EmpID) + @"</Value>               
                                </Eq>                                          
                                </Where>";

            SPListItemCollection coll = EmpInfo.GetItems(qry);
            if (coll != null && coll.Count > 0)
            {
                SPListItem item = coll[0];

                lbl_Firstname.Text = item[Constant.FirstName] != null ? item[Constant.FirstName].ToString() : "";
                lbl_Lastname.Text = item[Constant.LastName] != null ? item[Constant.LastName].ToString() : "";
                lbl_Dateofbirth.Text = item[Constant.DateOfBirth] != null ? Convert.ToDateTime(item[Constant.DateOfBirth].ToString()).ToShortDateString() : "";
                lbl_Gender.Text = item[Constant.Gender] != null ? item[Constant.Gender].ToString() : "";
                lbl_PresentAddress.Text = item[Constant.persentAddress] != null ? item[Constant.persentAddress].ToString() : "";
                lbl_PermanentAddress.Text = item[Constant.permanentAddress] != null ? item[Constant.permanentAddress].ToString() : "";
                lbl_ResicontactNo2.Text = item[Constant.ResidenceNo] != null ? item[Constant.ResidenceNo].ToString() : "";
                lbl_ResicontactNo1.Text = item[Constant.ResidenceNo1] != null ? item[Constant.ResidenceNo1].ToString() : "";
                lbl_MobileNo.Text = item[Constant.MobileNo] != null ? item[Constant.MobileNo].ToString() : "";
                lbl_Martialstatus.Text = item[Constant.MartialStatus] != null ? item[Constant.MartialStatus].ToString() : "";
                lbl_Marriagedate.Text = item[Constant.MarriageDate] != null ? Convert.ToDateTime(item[Constant.MarriageDate].ToString()).ToShortDateString() : "";
                lbl_Noofkids.Text = item[Constant.NoOfkids] != null ? item[Constant.NoOfkids].ToString() : "";
                lbl_datesigned.Text = item[Constant.DateSigned] != null ? Convert.ToDateTime(item[Constant.DateSigned].ToString()).ToShortDateString() : "";
                lbl_placesigned.Text = item[Constant.PlaceSigned] != null ? item[Constant.PlaceSigned].ToString() : "";
                hdnEmpType.Value = item[Constant.EmployementType].ToString();

                
                PushData_EmployeePhotos(item.ID);
                PushData_FamilyDetails(item.ID);
                PushData_Medicalcondition(item.ID);
                PushData_Emergencycontactdetails(item.ID);
                PushData_EducationalQualification(item.ID);
                PushData_EmployeeIdentity(item.ID);
                PushData_EmployeeReference(item.ID);
                PushData_EmployeeSignaturePhotos(item.ID);

                if (hdnEmpType.Value == Constant.EmployeeType_Permanent)
                {
                    div_HeadingPermanentEmployee.Visible = true;
                    div_HeadingContractEmployee.Visible = false;
                    tr_Bankacc.Visible = true;
                    tr_PFno.Visible = true;
                    tr_ESICno.Visible = true;
                    tr_UANno.Visible = true;
                    PushData_EmployeeIdentity(item.ID);
                     div_EmployeeType_Permanent_PreviousExperience.Visible = true;
                     div_EmployeeType_Contract_Details.Visible = false;
                    PushData_EmployeePreviousDetails(item.ID);
                    
                   
                }
                else if (hdnEmpType.Value == Constant.EmployeeType_Contract)
                {
                    div_HeadingPermanentEmployee.Visible = false;
                    div_HeadingContractEmployee.Visible = true;
                    tr_Bankacc.Visible = false;
                    tr_PFno.Visible = false;
                    tr_ESICno.Visible = false;
                    tr_UANno.Visible = false;
                    PushData_EmployeeIdentityContract(item.ID);
                    div_EmployeeType_Contract_Details.Visible = true;
                    div_EmployeeType_Permanent_PreviousExperience.Visible = false;
                    PushData_EmployeeContractDetails(item.ID);
                    PushData_EmployeeIdentityContract(item.ID);
                   
                }


               

               
               
            }



        }
        private void PushData_FamilyDetails(int empid)
        {
            var FamilyDetails = SPContext.Current.Web.Lists.TryGetList(Constant.FamilyDetails);
            SPQuery qry = new SPQuery();
            qry.Query = string.Format(@" <ViewFields>
                            <FieldRef Name='Family_x0020_Name' />
                            <FieldRef Name='Date_x0020_Of_x0020_Birth' />
                            <FieldRef Name='Gender' />
                            <FieldRef Name='Relationship' />
                            <FieldRef Name='Occupation' />
                            </ViewFields>
                            <Where>
                            <Eq>
                            <FieldRef Name='Employee_x002d_Name' LookupId='True' />
                            <Value Type='Lookup'>{0}</Value>
                            </Eq>
                            </Where>", empid);

            SPListItemCollection coll = FamilyDetails.GetItems(qry);
            int flagCount = 1;
            foreach (SPListItem item in coll)
            {

                if (flagCount == 1)
                {
                                        
                    lbl_Familyname1.Text = item[Constant.FamilyName] != null ? item[Constant.FamilyName].ToString() : "";
                    lbl_FamilyDOB1.Text = item[Constant.FamilyDateOfBirth] != null ? Convert.ToDateTime(item[Constant.FamilyDateOfBirth].ToString()).ToShortDateString() : "";
                    lbl_Familygender1.Text = item[Constant.FamilyGender] != null ? item[Constant.FamilyGender].ToString() : "";
                    lbl_Familyrelationship1.Text = item[Constant.FamilyRelationship] != null ? item[Constant.FamilyRelationship].ToString() : "";
                    lbl_Familyoccupation1.Text = item[Constant.FamilyOccupation] != null ? item[Constant.FamilyOccupation].ToString() : "";
                }
                if (flagCount == 2)
                {
                    lbl_Familyname2.Text = item[Constant.FamilyName] != null ? item[Constant.FamilyName].ToString() : "";
                    lbl_FamilyDOB2.Text = item[Constant.FamilyDateOfBirth] != null ? Convert.ToDateTime(item[Constant.FamilyDateOfBirth].ToString()).ToShortDateString() : "";
                    lbl_Familygender2.Text = item[Constant.FamilyGender] != null ? item[Constant.FamilyGender].ToString() : "";
                    lbl_Familyrelationship2.Text = item[Constant.FamilyRelationship] != null ? item[Constant.FamilyRelationship].ToString() : "";
                    lbl_Familyoccupation2.Text = item[Constant.FamilyOccupation] != null ? item[Constant.FamilyOccupation].ToString() : "";
                }
                if (flagCount == 3)
                {
                    lbl_Familyname3.Text = item[Constant.FamilyName] != null ? item[Constant.FamilyName].ToString() : "";
                    lbl_FamilyDOB3.Text = item[Constant.FamilyDateOfBirth] != null ? Convert.ToDateTime(item[Constant.FamilyDateOfBirth].ToString()).ToShortDateString() : "";
                    lbl_Familygender3.Text = item[Constant.FamilyGender] != null ? item[Constant.FamilyGender].ToString() : "";
                    lbl_Familyrelationship3.Text = item[Constant.FamilyRelationship] != null ? item[Constant.FamilyRelationship].ToString() : "";
                    lbl_Familyoccupation3.Text = item[Constant.FamilyOccupation] != null ? item[Constant.FamilyOccupation].ToString() : "";
                }
                if (flagCount == 4)
                {
                    lbl_Familyname4.Text = item[Constant.FamilyName] != null ? item[Constant.FamilyName].ToString() : "";
                    lbl_FamilyDOB4.Text = item[Constant.FamilyDateOfBirth] != null ? Convert.ToDateTime(item[Constant.FamilyDateOfBirth].ToString()).ToShortDateString() : "";
                    lbl_Familygender4.Text = item[Constant.FamilyGender] != null ? item[Constant.FamilyGender].ToString() : "";
                    lbl_Familyrelationship4.Text = item[Constant.FamilyRelationship] != null ? item[Constant.FamilyRelationship].ToString() : "";
                    lbl_Familyoccupation4.Text = item[Constant.FamilyOccupation] != null ? item[Constant.FamilyOccupation].ToString() : "";
                }
                if (flagCount == 5)
                {
                    lbl_Familyname5.Text = item[Constant.FamilyName] != null ? item[Constant.FamilyName].ToString() : "";
                    lbl_FamilyDOB5.Text = item[Constant.FamilyDateOfBirth] != null ? Convert.ToDateTime(item[Constant.FamilyDateOfBirth].ToString()).ToShortDateString() : "";
                    lbl_Familygender5.Text = item[Constant.FamilyGender] != null ? item[Constant.FamilyGender].ToString() : "";
                    lbl_Familyrelationship5.Text = item[Constant.FamilyRelationship] != null ? item[Constant.FamilyRelationship].ToString() : "";
                    lbl_Familyoccupation5.Text = item[Constant.FamilyOccupation] != null ? item[Constant.FamilyOccupation].ToString() : "";
                }

                ++flagCount;
            }
        }

        private void PushData_Medicalcondition(int empid)
        {
            var MedicalCondition = SPContext.Current.Web.Lists.TryGetList(Constant.MedicalCondition);
            SPQuery qry = new SPQuery();
            qry.Query = string.Format(@"    <ViewFields>
                                            <FieldRef Name='Blood_x0020_Group' />
                                            <FieldRef Name='Ailments' />
                                            <FieldRef Name='Allergies' />
                                            <FieldRef Name='Medications' />
                                            </ViewFields>
                                            <Where>
                                            <Eq>
                                            <FieldRef Name='Employee_x002d_Name' LookupId='True' />
                                            <Value Type='Lookup'>{0}</Value>
                                            </Eq>
                                            </Where>", empid);

            SPListItemCollection coll = MedicalCondition.GetItems(qry);
            foreach (SPListItem item in coll)
            {
                lbl_Bloodgroup.Text = item[Constant.BloodGroup] != null ? item[Constant.BloodGroup].ToString() : "";
                lbl_Ailments.Text = item[Constant.Ailments] != null ? item[Constant.Ailments].ToString() : "";
                lbl_Allergies.Text = item[Constant.Allergies] != null ? item[Constant.Allergies].ToString() : "";
                lbl_Othermedications.Text = item[Constant.OtherMedical] != null ? item[Constant.OtherMedical].ToString() : "";

            }

        }
        private void PushData_Emergencycontactdetails(int empid)
        {
            var EmergencyContactDetails = SPContext.Current.Web.Lists.TryGetList(Constant.EmergencyContactDetails);
            SPQuery qry = new SPQuery();
            qry.Query = string.Format(@"   <ViewFields>
                                           <FieldRef Name='Contact_x0020_Person_x0020_Name' />
                                           <FieldRef Name='Relations' />
                                           <FieldRef Name='Landline_x0020_no' />
                                           <FieldRef Name='CellPhone' />
                                           </ViewFields>
                                           <Where>
                                           <Eq>
                                           <FieldRef Name='Employee_x002d_Name' LookupId='True' />
                                           <Value Type='Lookup'>{0}</Value>
                                           </Eq>
                                        </Where>", empid);

            SPListItemCollection coll = EmergencyContactDetails.GetItems(qry);
            int flagCount = 1;
            foreach (SPListItem item in coll)
            {

                if (flagCount == 1)
                {
                    lbl_Contactperson1.Text = item[Constant.ContactPersonName] != null ? item[Constant.ContactPersonName].ToString() : "";
                    lbl_Contactrelation1.Text = item[Constant.ContactRelations] != null ? item[Constant.ContactRelations].ToString() : "";
                    lbl_Contactlandlinno1.Text = item[Constant.EmergencyLandlineno] != null ? item[Constant.EmergencyLandlineno].ToString() : "";
                    lbl_Contactmobileno1.Text = item[Constant.EmergencyMobileNumber] != null ? item[Constant.EmergencyMobileNumber].ToString() : "";
                }
                if (flagCount == 2)
                {
                    lbl_Contactperson2.Text = item[Constant.ContactPersonName] != null ? item[Constant.ContactPersonName].ToString() : "";
                    lbl_Contactrelation2.Text = item[Constant.ContactRelations] != null ? item[Constant.ContactRelations].ToString() : "";
                    lbl_Contactlandlinno2.Text = item[Constant.EmergencyLandlineno] != null ? item[Constant.EmergencyLandlineno].ToString() : "";
                    lbl_Contactmobileno2.Text = item[Constant.EmergencyMobileNumber] != null ? item[Constant.EmergencyMobileNumber].ToString() : "";
                }
                ++flagCount;
            }
        }
        private void PushData_EducationalQualification(int empid)
        {
            var EducationQualification = SPContext.Current.Web.Lists.TryGetList(Constant.EducationQualification);
            SPQuery qry = new SPQuery();
            qry.Query = string.Format(@"      <ViewFields>
                                             <FieldRef Name='Degree' />
                                             <FieldRef Name='university' />
                                             <FieldRef Name='From1' />
                                             <FieldRef Name='To' />
                                             <FieldRef Name='Percentage' />
                                             </ViewFields>
                                             <Where>
                                             <Eq>
                                             <FieldRef Name='Employee_x002d_Name' LookupId='True' />
                                             <Value Type='Lookup'>{0}</Value>
                                             </Eq>
                                             </Where>", empid);

            SPListItemCollection coll = EducationQualification.GetItems(qry);
            int flagCount = 1;
            foreach (SPListItem item in coll)
            {

                if (flagCount == 1)
                {
                    lbl_Degree1.Text = item[Constant.Degree] != null ? item[Constant.Degree].ToString() : "";
                    lbl_University1.Text = item[Constant.university] != null ? item[Constant.university].ToString() : "";
                    lbl_From1.Text = item[Constant.From]!=null? Convert.ToDateTime(item[Constant.From].ToString()).ToShortDateString():"";
                    lbl_To1.Text = item[Constant.To] != null ? Convert.ToDateTime(item[Constant.To].ToString()).ToShortDateString() : "";
                    lbl_Percentage1.Text = item[Constant.Percentage] != null ? item[Constant.Percentage].ToString() : "";

                }
                if (flagCount == 2)
                {
                    lbl_Degree2.Text = item[Constant.Degree] != null ? item[Constant.Degree].ToString() : "";
                    lbl_University2.Text = item[Constant.university] != null ? item[Constant.university].ToString() : "";
                    lbl_From2.Text = item[Constant.From] != null ? Convert.ToDateTime(item[Constant.From].ToString()).ToShortDateString() : "";
                    lbl_To2.Text = item[Constant.To] != null ? Convert.ToDateTime(item[Constant.To].ToString()).ToShortDateString() : "";
                    lbl_Percentage2.Text = item[Constant.Percentage] != null ? item[Constant.Percentage].ToString() : "";
                }
                if (flagCount == 3)
                {
                    lbl_Degree3.Text = item[Constant.Degree] != null ? item[Constant.Degree].ToString() : "";
                    lbl_University3.Text = item[Constant.university] != null ? item[Constant.university].ToString() : "";
                    lbl_From3.Text = item[Constant.From] != null ? Convert.ToDateTime(item[Constant.From].ToString()).ToShortDateString() : "";
                    lbl_To3.Text = item[Constant.To] != null ? Convert.ToDateTime(item[Constant.To].ToString()).ToShortDateString() : "";
                    lbl_Percentage3.Text = item[Constant.Percentage] != null ? item[Constant.Percentage].ToString() : "";
                }
                if (flagCount == 4)
                {
                    lbl_Degree4.Text = item[Constant.Degree] != null ? item[Constant.Degree].ToString() : "";
                    lbl_University4.Text = item[Constant.university] != null ? item[Constant.university].ToString() : "";
                    lbl_From4.Text = item[Constant.From] != null ? Convert.ToDateTime(item[Constant.From].ToString()).ToShortDateString() : "";
                    lbl_To4.Text = item[Constant.To] != null ? Convert.ToDateTime(item[Constant.To].ToString()).ToShortDateString() : "";
                    lbl_Percentage4.Text = item[Constant.Percentage] != null ? item[Constant.Percentage].ToString() : "";
                }
                if (flagCount == 5)
                {
                    lbl_Degree5.Text = item[Constant.Degree] != null ? item[Constant.Degree].ToString() : "";
                    lbl_University5.Text = item[Constant.university] != null ? item[Constant.university].ToString() : "";
                    lbl_From5.Text = item[Constant.From] != null ? Convert.ToDateTime(item[Constant.From].ToString()).ToShortDateString() : "";
                    lbl_To5.Text = item[Constant.To] != null ? Convert.ToDateTime(item[Constant.To].ToString()).ToShortDateString() : "";
                    lbl_Percentage5.Text = item[Constant.Percentage] != null ? item[Constant.Percentage].ToString() : "";
                }
                ++flagCount;
            }
        }
        private void PushData_EmployeeIdentity(int empid)
        {
            var EmployeeIdentity = SPContext.Current.Web.Lists.TryGetList(Constant.EmployeeIdentityandAddressProofs);
            SPQuery qry = new SPQuery();
            qry.Query = string.Format(@"       <ViewFields>
                                               <FieldRef Name='Aadhar_x0020_number' />
                                               <FieldRef Name='Pancard_x0020_number' />
                                               <FieldRef Name='Passport_x0020_number' />
                                               <FieldRef Name='Bank_x0020_Ac' />
                                               <FieldRef Name='PF' />
                                               <FieldRef Name='UAN' />
                                               <FieldRef Name='ESIC' />
                                               <FieldRef Name='Mode_x0020_of_x0020_Transport_x0' />
                                               <FieldRef Name='Mode_x0020_of_x0020_Transport_x00' />
                                               <FieldRef Name='Mode_x0020_of_x0020_Transport_x01' />
                                               </ViewFields>
                                               <Where>
                                               <Eq>
                                               <FieldRef Name='Employee_x002d_Name' LookupId='True' />
                                               <Value Type='Lookup'>{0}</Value>
                                               </Eq>
                                               </Where>", empid);

            SPListItemCollection coll = EmployeeIdentity.GetItems(qry);
            foreach (SPListItem item in coll)
            {
                lbl_Aadharno.Text = item[Constant.AadharNumber] != null ? item[Constant.AadharNumber].ToString() : "";
                lbl_Panno.Text = item[Constant.PancardNumber] != null ? item[Constant.PancardNumber].ToString() : "";
                lbl_Passportno.Text = item[Constant.PassportNumber] != null ? item[Constant.PassportNumber].ToString() : "";
                lbl_bankaccno.Text = item[Constant.BankAc] != null ? item[Constant.BankAc].ToString() : "";
                lbl_Pfaccno.Text = item[Constant.PF] != null ? item[Constant.PF].ToString() : "";
                lbl_Uanno.Text = item[Constant.UAN] != null ? item[Constant.UAN].ToString() : "";
                lbl_Esicno.Text = item[Constant.ESIC] != null ? item[Constant.ESIC].ToString() : "";
                lbl_Twowheeler.Text = item[Constant.twowheeler] != null ? item[Constant.twowheeler].ToString() : "";
                lbl_Fourwheeler.Text = item[Constant.fourwheeler] != null ? item[Constant.fourwheeler].ToString() : "";
                lbl_Publictransport.Text = item[Constant.PublicTransport] != null ? item[Constant.PublicTransport].ToString() : "";

            }

        }
        private void PushData_EmployeeIdentityContract(int empid)
        {
            var EmployeeIdentity = SPContext.Current.Web.Lists.TryGetList(Constant.EmployeeIdentityandAddressProofs);
            SPQuery qry = new SPQuery();
            qry.Query = string.Format(@"       <ViewFields>
                                               <FieldRef Name='Aadhar_x0020_number' />
                                               <FieldRef Name='Pancard_x0020_number' />
                                               <FieldRef Name='Passport_x0020_number' />
                                               <FieldRef Name='Bank_x0020_Ac' />
                                               
                                               <FieldRef Name='Mode_x0020_of_x0020_Transport_x0' />
                                               <FieldRef Name='Mode_x0020_of_x0020_Transport_x00' />
                                               <FieldRef Name='Mode_x0020_of_x0020_Transport_x01' />
                                               </ViewFields>
                                               <Where>
                                               <Eq>
                                               <FieldRef Name='Employee_x002d_Name' LookupId='True' />
                                               <Value Type='Lookup'>{0}</Value>
                                               </Eq>
                                               </Where>", empid);

            SPListItemCollection coll = EmployeeIdentity.GetItems(qry);
            foreach (SPListItem item in coll)
            {
                lbl_Aadharno.Text = item[Constant.AadharNumber] != null ? item[Constant.AadharNumber].ToString() : "";
                lbl_Panno.Text = item[Constant.PancardNumber] != null ? item[Constant.PancardNumber].ToString() : "";
                lbl_Passportno.Text = item[Constant.PassportNumber] != null ? item[Constant.PassportNumber].ToString() : "";
                lbl_bankaccno.Text = item[Constant.BankAc] != null ? item[Constant.BankAc].ToString() : "";
               
                lbl_Twowheeler.Text = item[Constant.twowheeler] != null ? item[Constant.twowheeler].ToString() : "";
                lbl_Fourwheeler.Text = item[Constant.fourwheeler] != null ? item[Constant.fourwheeler].ToString() : "";
                lbl_Publictransport.Text = item[Constant.PublicTransport] != null ? item[Constant.PublicTransport].ToString() : "";

            }

        }
        private void PushData_EmployeeReference(int empid)
        {
            var EmployeeReference = SPContext.Current.Web.Lists.TryGetList(Constant.EmployeeReferences);
            SPQuery qry = new SPQuery();
            qry.Query = string.Format(@"        <ViewFields>
                                                <FieldRef Name='Reference_x0020_Name' />
                                                <FieldRef Name='Working_x0020_In' />
                                                <FieldRef Name='Working_x0020_As' />
                                                <FieldRef Name='Contact_x0020_No' />
                                             </ViewFields>
                                             <Where>
                                                <Eq>
                                                   <FieldRef Name='Employee_x002d_Name' LookupId='True' />
                                                   <Value Type='Lookup'>{0}</Value>
                                                </Eq>
                                             </Where>", empid);

            SPListItemCollection coll = EmployeeReference.GetItems(qry);

            int flagCount = 1;
            foreach (SPListItem item in coll)
            {

                if (flagCount == 1)
                {
                    lbl_ReferenceName1.Text = item[Constant.ReferenceName] != null ? item[Constant.ReferenceName].ToString() : "";
                    lbl_ReferenceWorkingIn1.Text = item[Constant.ReferenceWorkingIn] != null ? item[Constant.ReferenceWorkingIn].ToString() : "";
                    lbl_ReferenceWorkingAs1.Text = item[Constant.ReferenceWorkingAs] != null ? item[Constant.ReferenceWorkingAs].ToString() : "";
                    lbl_ReferenceContactNo1.Text = item[Constant.ReferenceContactNo] != null ? item[Constant.ReferenceContactNo].ToString() : "";

                }
                if (flagCount == 2)
                {
                    lbl_ReferenceName2.Text = item[Constant.ReferenceName] != null ? item[Constant.ReferenceName].ToString() : "";
                    lbl_ReferenceWorkingIn2.Text = item[Constant.ReferenceWorkingIn] != null ? item[Constant.ReferenceWorkingIn].ToString() : "";
                    lbl_ReferenceWorkingAs2.Text = item[Constant.ReferenceWorkingAs] != null ? item[Constant.ReferenceWorkingAs].ToString() : "";
                    lbl_ReferenceContactNo2.Text = item[Constant.ReferenceContactNo] != null ? item[Constant.ReferenceContactNo].ToString() : "";

                }

                ++flagCount;
            }
        }
        private void PushData_EmployeePreviousDetails(int empid)
        {
            var EmployeePreviousDetails = SPContext.Current.Web.Lists.TryGetList(Constant.EmployeePreviousExperience);
            SPQuery qry = new SPQuery();
            qry.Query = string.Format(@"           <ViewFields>
                                                     <FieldRef Name='Company_x0020_Name' />
                                                     <FieldRef Name='Designation' />
                                                     <FieldRef Name='Date_x0020_of_x0020_joining' />
                                                     <FieldRef Name='Date_x0020_of_x0020_Relieving' />
                                                     <FieldRef Name='Contact_x0020_No' />
                                                     <FieldRef Name='Reason' />
                                                  </ViewFields>
                                                  <Where>
                                                     <Eq>
                                                        <FieldRef Name='Employee_x002d_Name' LookupId='True' />
                                                        <Value Type='Lookup'>{0}</Value>
                                                     </Eq>
                                                  </Where>", empid);

            SPListItemCollection coll = EmployeePreviousDetails.GetItems(qry);
            int flagCount = 1;
            foreach (SPListItem item in coll)
            {

                if (flagCount == 1)
                {
                    lbl_Prevcompanyname1.Text = item[Constant.PreviousCompany] != null ? item[Constant.PreviousCompany].ToString() : "";
                    lbl_Prevdesignation1.Text = item[Constant.PreviousDesignation] != null ? item[Constant.PreviousDesignation].ToString() : "";
                    lbl_PrevDOJ1.Text = item[Constant.PreviousDateofjoining] != null ? Convert.ToDateTime(item[Constant.PreviousDateofjoining].ToString()).ToShortDateString() : "";
                    lbl_PrevDOR1.Text = item[Constant.PreviousDateofRelieving]!=null ? Convert.ToDateTime(item[Constant.PreviousDateofRelieving].ToString()).ToShortDateString():"";
                    lbl_Prevcontactno1.Text = item[Constant.PreviousContactNo] != null ? item[Constant.PreviousContactNo].ToString() : "";
                    lbl_Prevreason1.Text = item[Constant.PreviousReason] != null ? item[Constant.PreviousReason].ToString() : "";

                }
                if (flagCount == 2)
                {
                    lbl_Prevcompanyname2.Text = item[Constant.PreviousCompany] != null ? item[Constant.PreviousCompany].ToString() : "";
                    lbl_Prevdesignation2.Text = item[Constant.PreviousDesignation] != null ? item[Constant.PreviousDesignation].ToString() : "";
                    lbl_PrevDOJ2.Text = item[Constant.PreviousDateofjoining] != null ? Convert.ToDateTime(item[Constant.PreviousDateofjoining].ToString()).ToShortDateString() : "";
                    lbl_PrevDOR2.Text = item[Constant.PreviousDateofRelieving] != null ? Convert.ToDateTime(item[Constant.PreviousDateofRelieving].ToString()).ToShortDateString() : "";
                    lbl_Prevcontactno2.Text = item[Constant.PreviousContactNo] != null ? item[Constant.PreviousContactNo].ToString() : "";
                    lbl_Prevreason2.Text = item[Constant.PreviousReason] != null ? item[Constant.PreviousReason].ToString() : "";

                }
                if (flagCount == 3)
                {
                    lbl_Prevcompanyname3.Text = item[Constant.PreviousCompany] != null ? item[Constant.PreviousCompany].ToString() : "";
                    lbl_Prevdesignation3.Text = item[Constant.PreviousDesignation] != null ? item[Constant.PreviousDesignation].ToString() : "";
                    lbl_PrevDOJ3.Text = item[Constant.PreviousDateofjoining] != null ? Convert.ToDateTime(item[Constant.PreviousDateofjoining].ToString()).ToShortDateString() : "";
                    lbl_PrevDOR3.Text = item[Constant.PreviousDateofRelieving] != null ? Convert.ToDateTime(item[Constant.PreviousDateofRelieving].ToString()).ToShortDateString() : "";
                    lbl_Prevcontactno3.Text = item[Constant.PreviousContactNo] != null ? item[Constant.PreviousContactNo].ToString() : "";
                    lbl_Prevreason3.Text = item[Constant.PreviousReason] != null ? item[Constant.PreviousReason].ToString() : "";

                }
                if (flagCount == 4)
                {
                    lbl_Prevcompanyname4.Text = item[Constant.PreviousCompany] != null ? item[Constant.PreviousCompany].ToString() : "";
                    lbl_Prevdesignation4.Text = item[Constant.PreviousDesignation] != null ? item[Constant.PreviousDesignation].ToString() : "";
                    lbl_PrevDOJ4.Text = item[Constant.PreviousDateofjoining] != null ? Convert.ToDateTime(item[Constant.PreviousDateofjoining].ToString()).ToShortDateString() : "";
                    lbl_PrevDOR4.Text = item[Constant.PreviousDateofRelieving] != null ? Convert.ToDateTime(item[Constant.PreviousDateofRelieving].ToString()).ToShortDateString() : "";
                    lbl_Prevcontactno4.Text = item[Constant.PreviousContactNo] != null ? item[Constant.PreviousContactNo].ToString() : "";
                    lbl_Prevreason4.Text = item[Constant.PreviousReason] != null ? item[Constant.PreviousReason].ToString() : "";

                }
                if (flagCount == 5)
                {
                    lbl_Prevcompanyname5.Text = item[Constant.PreviousCompany] != null ? item[Constant.PreviousCompany].ToString() : "";
                    lbl_Prevdesignation5.Text = item[Constant.PreviousDesignation] != null ? item[Constant.PreviousDesignation].ToString() : "";
                    lbl_PrevDOJ5.Text = item[Constant.PreviousDateofjoining] != null ? Convert.ToDateTime(item[Constant.PreviousDateofjoining].ToString()).ToShortDateString() : "";
                    lbl_PrevDOR5.Text = item[Constant.PreviousDateofRelieving] != null ? Convert.ToDateTime(item[Constant.PreviousDateofRelieving].ToString()).ToShortDateString() : "";
                    lbl_Prevcontactno5.Text = item[Constant.PreviousContactNo] != null ? item[Constant.PreviousContactNo].ToString() : "";
                    lbl_Prevreason5.Text = item[Constant.PreviousReason] != null ? item[Constant.PreviousReason].ToString() : "";

                }

                ++flagCount;
            }
        }
        private void PushData_EmployeeContractDetails(int empid)
        {
            var EmployeePreviousDetails = SPContext.Current.Web.Lists.TryGetList(Constant.EmployeePreviousExperience);
            SPQuery qry = new SPQuery();
            qry.Query = string.Format(@"           <ViewFields>
                                                        <FieldRef Name='Company_x0020_Name' />
                                                        <FieldRef Name='Designation' />
                                                        <FieldRef Name='Date_x0020_of_x0020_joining' />
                                                        <FieldRef Name='Duration1' />
                                                        <FieldRef Name='Contact_x0020_Person' />
                                                        
                                                        <FieldRef Name='Contact_x0020_No' />
                                                  </ViewFields>
                                                  <Where>
                                                     <Eq>
                                                        <FieldRef Name='Employee_x002d_Name' LookupId='True' />
                                                        <Value Type='Lookup'>{0}</Value>
                                                     </Eq>
                                                  </Where>", empid);

            SPListItemCollection coll = EmployeePreviousDetails.GetItems(qry);
            int flagCount = 1;
            foreach (SPListItem item in coll)
            {

                if (flagCount == 1)
                {
                    lbl_ContractCompany1.Text = item[Constant.PreviousCompany] != null ? item[Constant.PreviousCompany].ToString() : "";
                    lbl_ContractDesignation1.Text = item[Constant.PreviousDesignation] != null ? item[Constant.PreviousDesignation].ToString() : "";
                    lbl_ContractDOJ1.Text = item[Constant.PreviousDateofjoining] != null ? Convert.ToDateTime(item[Constant.PreviousDateofjoining].ToString()).ToShortDateString() : "";
                    lbl_ContractDuration1.Text = item[Constant.ContractDuration] != null ? item[Constant.ContractDuration].ToString() : "";
                    lbl_ContractContactPerson1.Text = item[Constant.ContractContactPerson] != null ? item[Constant.ContractContactPerson].ToString() : "";
                    lbl_ContractContactNo1.Text = item[Constant.PreviousContactNo] != null ? item[Constant.PreviousContactNo].ToString() : "";


                }
                if (flagCount == 2)
                {
                    txt_ContractCompany2.Text = item[Constant.PreviousCompany] != null ? item[Constant.PreviousCompany].ToString() : "";
                    txt_ContractDesignation2.Text = item[Constant.PreviousDesignation] != null ? item[Constant.PreviousDesignation].ToString() : "";
                    lbl_ContractDOJ2.Text = item[Constant.PreviousDateofjoining] != null ? Convert.ToDateTime(item[Constant.PreviousDateofjoining].ToString()).ToShortDateString() : "";
                    txt_ContractDuration2.Text = item[Constant.ContractDuration] != null ? item[Constant.ContractDuration].ToString() : "";
                    txt_ContractContactPerson2.Text = item[Constant.ContractContactPerson] != null ? item[Constant.ContractContactPerson].ToString() : "";
                    txt_ContractContactNo2.Text = item[Constant.PreviousContactNo] != null ? item[Constant.PreviousContactNo].ToString() : "";


                }
                if (flagCount == 3)
                {
                    txt_ContractCompany3.Text = item[Constant.PreviousCompany] != null ? item[Constant.PreviousCompany].ToString() : "";
                    txt_ContractDesignation3.Text = item[Constant.PreviousDesignation] != null ? item[Constant.PreviousDesignation].ToString() : "";
                    lbl_ContractDOJ3.Text = item[Constant.PreviousDateofjoining] != null ? Convert.ToDateTime(item[Constant.PreviousDateofjoining].ToString()).ToShortDateString() : "";
                    txt_ContractDuration3.Text = item[Constant.ContractDuration] != null ? item[Constant.ContractDuration].ToString() : "";
                    txt_ContractContactPerson3.Text = item[Constant.ContractContactPerson] != null ? item[Constant.ContractContactPerson].ToString() : "";
                    txt_ContractContactNo3.Text = item[Constant.PreviousContactNo] != null ? item[Constant.PreviousContactNo].ToString() : "";


                }
                if (flagCount == 4)
                {
                    txt_ContractCompany4.Text = item[Constant.PreviousCompany] != null ? item[Constant.PreviousCompany].ToString() : "";
                    txt_ContractDesignation4.Text = item[Constant.PreviousDesignation] != null ? item[Constant.PreviousDesignation].ToString() : "";
                    lbl_ContractDOJ4.Text = item[Constant.PreviousDateofjoining] != null ? Convert.ToDateTime(item[Constant.PreviousDateofjoining].ToString()).ToShortDateString() : "";
                    txt_ContractDuration4.Text = item[Constant.ContractDuration] != null ? item[Constant.ContractDuration].ToString() : "";
                    txt_ContractContactPerson4.Text = item[Constant.ContractContactPerson] != null ? item[Constant.ContractContactPerson].ToString() : "";
                    txt_ContractContactNo4.Text = item[Constant.PreviousContactNo] != null ? item[Constant.PreviousContactNo].ToString() : "";


                }
                if (flagCount == 5)
                {
                    txt_ContractCompany5.Text = item[Constant.PreviousCompany] != null ? item[Constant.PreviousCompany].ToString() : "";
                    txt_ContractDesignation5.Text = item[Constant.PreviousDesignation] != null ? item[Constant.PreviousDesignation].ToString() : "";
                    lbl_ContractDOJ5.Text = item[Constant.PreviousDateofjoining] != null ? Convert.ToDateTime(item[Constant.PreviousDateofjoining].ToString()).ToShortDateString() : "";
                    txt_ContractDuration5.Text = item[Constant.ContractDuration] != null ? item[Constant.ContractDuration].ToString() : "";
                    txt_ContractContactPerson5.Text = item[Constant.ContractContactPerson] != null ? item[Constant.ContractContactPerson].ToString() : "";
                    txt_ContractContactNo5.Text = item[Constant.PreviousContactNo] != null ? item[Constant.PreviousContactNo].ToString() : "";


                }

                ++flagCount;
            }
        }
        private void PushData_EmployeePhotos(int empid)
        {
            var EmployeePhotos = SPContext.Current.Web.Lists.TryGetList(Constant.EmployeesPhotos);
            SPQuery qry = new SPQuery();
            qry.Query = string.Format(@"  <Where>
                                               <Eq>
                                                  <FieldRef Name='Employee_x002d_Name' LookupId='True' />
                                                  <Value Type='Lookup'>{0}</Value>
                                               </Eq>
                                               </Where>", empid);

            SPListItemCollection coll = EmployeePhotos.GetItems(qry);
            if (coll != null)
            {
                if (coll.Count > 0)
                {
                    hidden_Empphotos.Value = "../../" + coll[0].Url;
                    img_Empphotos.ImageUrl = "../../" + coll[0].Url;
                }
            }



        }
        
        private void PushData_EmployeeSignaturePhotos(int empid)
        {
            var EmployeeSignPhotos = SPContext.Current.Web.Lists.TryGetList(Constant.EmployeesSignature);
            SPQuery qry = new SPQuery();
            qry.Query = string.Format(@"  <Where>
                                               <Eq>
                                                  <FieldRef Name='Employee_x002d_Name' LookupId='True' />
                                                  <Value Type='Lookup'>{0}</Value>
                                               </Eq>
                                               </Where>", empid);
            
            SPListItemCollection coll = EmployeeSignPhotos.GetItems(qry);
            if (coll != null)
            {
                if (coll.Count > 0)
                { 
                    hidden_Empsignphotos.Value = "../../" + coll[0].Url;
                    img_Employeesignature.ImageUrl = "../../" + coll[0].Url;
                }
            }



        }

        protected void Print_Form(object sender, EventArgs e)
        {
            //PrintDialog dlg = new PrintDialog();
            //dlg.ShowDialog();
        }
    }
}