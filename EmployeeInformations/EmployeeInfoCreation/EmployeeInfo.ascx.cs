

namespace EmployeeInformations.EmployeeInfo
{
    using EmployeeInformations;
    using Microsoft.SharePoint;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;



    [ToolboxItemAttribute(false)]
    public partial class EmployeeInfo : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public EmployeeInfo()
        {
        }

        //public string flag_EmployeeType = string.Empty;


        // Collections
        public List<Employee_FamilyEntity> collection_FamilyDetails = new List<Employee_FamilyEntity>();

        public List<Emergency_ContactDatils> collection_EmergencyContactDetails = new List<Emergency_ContactDatils>();

        public List<Education_Qualification> collection_EducationQualifications = new List<Education_Qualification>();

        public List<Employee_References> collection_EmployeeReferences = new List<Employee_References>();

        public List<Employee_PreviousExperience> collection_EmployeePreviousExperience = new List<Employee_PreviousExperience>();

        public List<Employee_ContractDetails> collection_ContractDetails = new List<Employee_ContractDetails>();


        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
            ChromeType = PartChromeType.None;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                div_HeadingPermanentEmployee.Visible = true;
                div_HeadingContractEmployee.Visible = false;
                div_EmployeeType_Permanent_PreviousExperience.Visible = true;
                div_EmployeeType_Contract_Details.Visible = false;
                hdnEmpType.Value = Constant.EmployeeType_Permanent;

            }


        }
        /// <summary>
        /// This is to retrieve the Employee Family Member Details
        /// </summary>
        private void Get_FamilyMemberDetails()
        {
            if (txt_Family_FirstName1.Text != string.Empty)
            {
                collection_FamilyDetails.Add(new Employee_FamilyEntity
                {
                    FamilyName = txt_Family_FirstName1.Text,
                    FamilyDateOfBirth = txt_Family_DOB1.SelectedDate.ToString(),
                    FamilyGender = txt_Family_Gender1.Text,
                    FamilyRelationship = txt_Family_Relationship1.Text,
                    FamilyOccupation = txt_Family_Occupation1.Text
                });
            }
            if (txt_Family_FirstName2.Text != string.Empty)
            {
                collection_FamilyDetails.Add(new Employee_FamilyEntity
                {
                    FamilyName = txt_Family_FirstName2.Text,
                    FamilyDateOfBirth = txt_Family_DOB2.SelectedDate.ToString(),
                    FamilyGender = txt_Family_Gender2.Text,
                    FamilyRelationship = txt_Family_Relationship2.Text,
                    FamilyOccupation = txt_Family_Occupation2.Text

                });
            }
            if (txt_Family_FirstName3.Text != string.Empty)
            {
                collection_FamilyDetails.Add(new Employee_FamilyEntity
                {
                    FamilyName = txt_Family_FirstName3.Text,
                    FamilyDateOfBirth = txt_Family_DOB3.SelectedDate.ToString(),
                    FamilyGender = txt_Family_Gender3.Text,
                    FamilyRelationship = txt_Family_Relationship3.Text,
                    FamilyOccupation = txt_Family_Occupation3.Text

                });
            }
            if (txt_Family_FirstName4.Text != string.Empty)
            {
                collection_FamilyDetails.Add(new Employee_FamilyEntity
                {
                    FamilyName = txt_Family_FirstName4.Text,
                    FamilyDateOfBirth = txt_Family_DOB4.SelectedDate.ToString(),
                    FamilyGender = txt_Family_Gender4.Text,
                    FamilyRelationship = txt_Family_Relationship4.Text,
                    FamilyOccupation = txt_Family_Occupation4.Text

                });
            }
            if (txt_Family_FirstName5.Text != string.Empty)
            {
                collection_FamilyDetails.Add(new Employee_FamilyEntity
                {
                    FamilyName = txt_Family_FirstName5.Text,
                    FamilyDateOfBirth = txt_Family_DOB5.SelectedDate.ToString(),
                    FamilyGender = txt_Family_Gender5.Text,
                    FamilyRelationship = txt_Family_Relationship5.Text,
                    FamilyOccupation = txt_Family_Occupation5.Text

                });
            }
        }

        private void Get_EmergencyContactDetails()
        {
            if (txt_ContactPersonName1.Text != string.Empty)
            {
                collection_EmergencyContactDetails.Add(new Emergency_ContactDatils
                {
                    ContactPersonName = txt_ContactPersonName1.Text,
                    ContactRelations = txt_Relation1.Text,
                    EmergencyLandlineno = txt_EmergencylandlineNo1.Text,
                    EmergencyMobileNumber = txt_EmergencyMobileNo1.Text

                });
            }
            if (txt_ContactPersonName2.Text != string.Empty)
            {
                collection_EmergencyContactDetails.Add(new Emergency_ContactDatils
                {
                    ContactPersonName = txt_ContactPersonName2.Text,
                    ContactRelations = txt_Relation2.Text,
                    EmergencyLandlineno = txt_EmergencylandlineNo2.Text,
                    EmergencyMobileNumber = txt_EmergencyMobileNo2.Text

                });
            }

        }

        private void Get_EducationQualifications()
        {
            if (txt_Degree1.Text != string.Empty)
            {
                collection_EducationQualifications.Add(new Education_Qualification
                {
                    Degree = txt_Degree1.Text,
                    university = txt_University1.Text,
                    From = date_From1.SelectedDate.ToString(),
                    To = date_To1.SelectedDate.ToString(),
                    Percentage = txt_Percentage1.Text


                });
            }

            if (txt_Degree2.Text != string.Empty)
            {
                collection_EducationQualifications.Add(new Education_Qualification
                {
                    Degree = txt_Degree2.Text,
                    university = txt_University2.Text,
                    From = date_From2.SelectedDate.ToString(),
                    To = date_To2.SelectedDate.ToString(),
                    Percentage = txt_Percentage2.Text


                });
            }
            if (txt_Degree3.Text != string.Empty)
            {
                collection_EducationQualifications.Add(new Education_Qualification
                {
                    Degree = txt_Degree3.Text,
                    university = txt_University3.Text,
                    From = date_From3.SelectedDate.ToString(),
                    To = date_To3.SelectedDate.ToString(),
                    Percentage = txt_Percentage3.Text


                });
            }
            if (txt_Degree4.Text != string.Empty)
            {
                collection_EducationQualifications.Add(new Education_Qualification
                {
                    Degree = txt_Degree4.Text,
                    university = txt_University4.Text,
                    From = date_From4.SelectedDate.ToString(),
                    To = date_To4.SelectedDate.ToString(),
                    Percentage = txt_Percentage4.Text


                });
            }
            if (txt_Degree5.Text != string.Empty)
            {
                collection_EducationQualifications.Add(new Education_Qualification
                {
                    Degree = txt_Degree5.Text,
                    university = txt_University5.Text,
                    From = date_From5.SelectedDate.ToString(),
                    To = date_To5.SelectedDate.ToString(),
                    Percentage = txt_Percentage5.Text


                });
            }

        }

        private void Get_EmployeeReferences()
        {

            if (txt_ReferenceName1.Text != string.Empty)
            {
                collection_EmployeeReferences.Add(new Employee_References
                {
                    ReferenceName = txt_ReferenceName1.Text,
                    ReferenceWorkingIn = txt_ReferenceWorkingIn1.Text,
                    ReferenceWorkingAs = txt_ReferenceWorkingAs1.Text,
                    ReferenceContactNo = txt_RefrenceContactNo1.Text
                });
            }
            if (txt_ReferenceName2.Text != string.Empty)
            {
                collection_EmployeeReferences.Add(new Employee_References
                {
                    ReferenceName = txt_ReferenceName2.Text,
                    ReferenceWorkingIn = txt_ReferenceWorkingIn2.Text,
                    ReferenceWorkingAs = txt_ReferenceWorkingAs2.Text,
                    ReferenceContactNo = txt_ReferenceContactNo2.Text
                });
            }
        }

        private void Get_EmployeePreviousExperience()
        {
            if (txt_PrevCompanyName1.Text != string.Empty)
            {
                collection_EmployeePreviousExperience.Add(new Employee_PreviousExperience
                {
                    PreviousCompany = txt_PrevCompanyName1.Text,
                    PreviousDesignation = txt_PrevDesignation1.Text,
                    PreviousDateofjoining = date_PrevDOJ1.SelectedDate.ToString(),
                    PreviousDateofRelieving = date_PrevDOR1.SelectedDate.ToString(),
                    PreviousContactNo = txt_PrevContactNo1.Text,
                    PreviousReason = txt_PrevReason1.Text
                });
            }

            if (txt_PrevCompanyName2.Text != string.Empty)
            {
                collection_EmployeePreviousExperience.Add(new Employee_PreviousExperience
                {
                    PreviousCompany = txt_PrevCompanyName2.Text,
                    PreviousDesignation = txt_PrevDesignation2.Text,
                    PreviousDateofjoining = date_PrevDOJ2.SelectedDate.ToString(),
                    PreviousDateofRelieving = date_PrevDOR2.SelectedDate.ToString(),
                    PreviousContactNo = txt_PrevContactNo2.Text,
                    PreviousReason = txt_PrevReason2.Text
                });
            }
            if (txt_PrevCompanyName3.Text != string.Empty)
            {
                collection_EmployeePreviousExperience.Add(new Employee_PreviousExperience
                {
                    PreviousCompany = txt_PrevCompanyName3.Text,
                    PreviousDesignation = txt_PrevDesignation3.Text,
                    PreviousDateofjoining = date_PrevDOJ3.SelectedDate.ToString(),
                    PreviousDateofRelieving = date_PrevDOR3.SelectedDate.ToString(),
                    PreviousContactNo = txt_PrevContactNo3.Text,
                    PreviousReason = txt_PrevReason3.Text
                });
            }
            if (txt_PrevCompanyName4.Text != string.Empty)
            {
                collection_EmployeePreviousExperience.Add(new Employee_PreviousExperience
                {
                    PreviousCompany = txt_PrevCompanyName4.Text,
                    PreviousDesignation = txt_PrevDesignation4.Text,
                    PreviousDateofjoining = date_PrevDOJ4.SelectedDate.ToString(),
                    PreviousDateofRelieving = date_PrevDOR4.SelectedDate.ToString(),
                    PreviousContactNo = txt_PrevContactNo4.Text,
                    PreviousReason = txt_PrevReason4.Text
                });
            }
            if (txt_PrevCompanyName5.Text != string.Empty)
            {
                collection_EmployeePreviousExperience.Add(new Employee_PreviousExperience
                {
                    PreviousCompany = txt_PrevCompanyName5.Text,
                    PreviousDesignation = txt_PrevDesignation5.Text,
                    PreviousDateofjoining = date_PrevDOJ5.SelectedDate.ToString(),
                    PreviousDateofRelieving = date_PrevDOR5.SelectedDate.ToString(),
                    PreviousContactNo = txt_PrevContactNo5.Text,
                    PreviousReason = txt_PrevReason5.Text
                });
            }
        }

        private void Get_ContractDetails()
        {
            if (txt_ContractCompany1.Text != string.Empty)
            {
                collection_ContractDetails.Add(new Employee_ContractDetails
                {
                    ContractCompany = txt_ContractCompany1.Text,
                    ContractDesignation = txt_ContractDesignation1.Text,
                    ContractDOJ = date_contractDOJ1.SelectedDate.ToString(),
                    ContractContactPerson = txt_ContractContactPerson1.Text,
                    ContractDuration = txt_ContractDuration1.Text,
                    ContractContactNo = txt_ContractContactNo1.Text
                });
            }
            if (txt_ContractCompany2.Text != string.Empty)
            {
                collection_ContractDetails.Add(new Employee_ContractDetails
                {
                    ContractCompany = txt_ContractCompany2.Text,
                    ContractDesignation = txt_ContractDesignation2.Text,
                    ContractDOJ = date_contractDOJ2.SelectedDate.ToString(),
                    ContractContactPerson = txt_ContractContactPerson2.Text,
                    ContractDuration = txt_ContractDuration2.Text,
                    ContractContactNo = txt_ContractContactNo2.Text
                });
            }
            if (txt_ContractCompany3.Text != string.Empty)
            {
                collection_ContractDetails.Add(new Employee_ContractDetails
                {
                    ContractCompany = txt_ContractCompany3.Text,
                    ContractDesignation = txt_ContractDesignation3.Text,
                    ContractDOJ = date_contractDOJ3.SelectedDate.ToString(),
                    ContractContactPerson = txt_ContractContactPerson3.Text,
                    ContractDuration = txt_ContractDuration3.Text,
                    ContractContactNo = txt_ContractContactNo3.Text
                });
            }
            if (txt_ContractCompany4.Text != string.Empty)
            {
                collection_ContractDetails.Add(new Employee_ContractDetails
                {
                    ContractCompany = txt_ContractCompany4.Text,
                    ContractDesignation = txt_ContractDesignation4.Text,
                    ContractDOJ = date_contractDOJ4.SelectedDate.ToString(),
                    ContractContactPerson = txt_ContractContactPerson4.Text,
                    ContractDuration = txt_ContractDuration4.Text,
                    ContractContactNo = txt_ContractContactNo4.Text
                });
            }
            if (txt_ContractCompany5.Text != string.Empty)
            {
                collection_ContractDetails.Add(new Employee_ContractDetails
                {
                    ContractCompany = txt_ContractCompany5.Text,
                    ContractDesignation = txt_ContractDesignation5.Text,
                    ContractDOJ = date_contractDOJ5.SelectedDate.ToString(),
                    ContractContactPerson = txt_ContractContactPerson5.Text,
                    ContractDuration = txt_ContractDuration5.Text,
                    ContractContactNo = txt_ContractContactNo5.Text
                });
            }

        }

        //private void MartialStatus_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (txt_MartialStatus.SelectedItem.Text == "Married")
        //    {

        //        txt_MarriageDate.Visible = true;
        //        txt_Kids.Visible = true;
        //        lbl_MarriageDate.Visible = true;
        //        lbl_kids.Visible = true;

        //    }
        //    else
        //    {
        //        txt_MarriageDate.Visible = false;
        //        txt_Kids.Visible = false;
        //        lbl_MarriageDate.Visible = false;
        //        lbl_kids.Visible = false;
        //    }
        //}
        protected void Save_Click(object sender, EventArgs e)
        {

            string MainSite = "/Pages/Home.aspx";
            int Emp_Id;
            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    using (SPSite site = new SPSite(SPContext.Current.Web.Url))
                    {
                        using (SPWeb web = site.OpenWeb())
                        {
                            //Required Field  validations

                            
                            if (txt_FirstName.Text != null)
                            {
                                TextBox tx = (TextBox)this.FindControl(
                                required_Firstname.ControlToValidate);
                                if (string.IsNullOrEmpty(tx.Text))
                                {
                                    required_Firstname.ErrorMessage =
                                        "Please Enter the First Name";
                                }
                            }

                            if (txt_LastName.Text != null)
                            {
                                TextBox tx = (TextBox)this.FindControl(
                                required_Lastname.ControlToValidate);
                                if (string.IsNullOrEmpty(tx.Text))
                                {
                                    required_Lastname.ErrorMessage =
                                        "Please Enter the Last Name";
                                }
                            }



                            if (txt_PersentAddress.Text != null)
                            {
                                TextBox tx = (TextBox)this.FindControl(
                                required_PresentAddress.ControlToValidate);
                                if (string.IsNullOrEmpty(tx.Text))
                                {
                                    required_PresentAddress.ErrorMessage =
                                        "Please Enter the Present Address";
                                }
                            }

                            if (txt_PermanentAddress.Text != null)
                            {
                                TextBox tx = (TextBox)this.FindControl(
                                required_PermanentAddress.ControlToValidate);
                                if (string.IsNullOrEmpty(tx.Text))
                                {
                                    required_PermanentAddress.ErrorMessage =
                                        "Please Enter the Permanent Address";
                                }
                            }

                            if (txt_MobileNo.Text != null)
                            {
                                TextBox tx = (TextBox)this.FindControl(
                                required_EmpMobileNo.ControlToValidate);
                                if (string.IsNullOrEmpty(tx.Text))
                                {
                                    required_EmpMobileNo.ErrorMessage =
                                        "Please Enter the Mobile Number";
                                }
                            }

                            if (txt_Aadharno.Text != null)
                            {
                                TextBox tx = (TextBox)this.FindControl(
                                required_AadharNumber.ControlToValidate);
                                if (string.IsNullOrEmpty(tx.Text))
                                {
                                    required_AadharNumber.ErrorMessage =
                                        "Please Enter the Aadhar Number";
                                }
                            }
                                
                            if (txt_PANno.Text != null)
                            { 
                                TextBox tx = (TextBox)this.FindControl(
                                required_PANno.ControlToValidate);
                                if (string.IsNullOrEmpty(tx.Text))
                                {
                                    required_PANno.ErrorMessage =
                                        "Please Enter the PAN Number";
                                }
                            }

                            if (txt_ReferenceName1.Text != null)
                            {
                                TextBox tx = (TextBox)this.FindControl(
                                required_ReferenceName1.ControlToValidate);
                                if (string.IsNullOrEmpty(tx.Text))
                                {
                                    required_ReferenceName1.ErrorMessage =
                                        "Please Enter the Reference Name";
                                }
                            }

                             if (txt_RefrenceContactNo1.Text != null)
                            {
                                TextBox tx = (TextBox)this.FindControl(
                                required_ReferenceMobileNo1.ControlToValidate);
                                if (string.IsNullOrEmpty(tx.Text))
                                {
                                    required_ReferenceMobileNo1.ErrorMessage =
                                        "Please Enter the Reference Mobile Number";
                                }
                            }
                            
                            //if (file_EmployeePhoto.f != null)
                            //{
                            //    TextBox tx = (TextBox)this.FindControl(
                            //    required_Empphoto.ControlToValidate);
                            //    if (string.IsNullOrEmpty(tx.Text))
                            //    {
                            //        required_Firstname.ErrorMessage =
                            //            "Please Enter the First Name";
                            //    }
                            //}



                             if (txt_placeSigned.Text != null)
                            {
                                TextBox tx = (TextBox)this.FindControl(
                                required_Placesigned.ControlToValidate);
                                if (string.IsNullOrEmpty(tx.Text))
                                {
                                    required_Placesigned.ErrorMessage =
                                        "Please Enter the Place";
                                }
                            }

                            // Get Form Entries

                            Get_FormInputCollections();

                            web.AllowUnsafeUpdates = true;                         
                            var EmpInfo = web.Lists.TryGetList(Constant.EmployeeInformation);
                            var FamilyDetails = web.Lists.TryGetList(Constant.FamilyDetails);
                            var MedicalCondition = web.Lists.TryGetList(Constant.MedicalCondition);
                            var EmergencyContactDetails = web.Lists.TryGetList(Constant.EmergencyContactDetails);
                            var EducationQualification = web.Lists.TryGetList(Constant.EducationQualification);
                            var EmployeeIdentityandAddressProofs = web.Lists.TryGetList(Constant.EmployeeIdentityandAddressProofs);
                            var EmployeeReferences = web.Lists.TryGetList(Constant.EmployeeReferences);
                            var EmployeePreviousWorkingDetails = web.Lists.TryGetList(Constant.EmployeePreviousExperience);
                            var EmployeesPhotos = web.Lists.TryGetList(Constant.EmployeesPhotos);
                            var EmployeesSignature = web.Lists.TryGetList(Constant.EmployeesSignature);
                            var Employeetype = web.Lists.TryGetList(Constant.EmployementType);

                            // Employee Information List

                            if (EmpInfo != null)
                            {
                                
                                SPListItem newItem_EmployeeInformation = EmpInfo.Items.Add();
                                newItem_EmployeeInformation[Constant.EmployementType] = hdnEmpType.Value;
                                newItem_EmployeeInformation[Constant.FirstName] = txt_FirstName.Text;
                                newItem_EmployeeInformation[Constant.LastName] = txt_LastName.Text;
                                newItem_EmployeeInformation[Constant.EmployeeName] = web.CurrentUser.LoginName;
                                newItem_EmployeeInformation[Constant.DateOfBirth] = Convert.ToDateTime(txt_DateOfBirth.SelectedDate.ToString());
                                newItem_EmployeeInformation[Constant.Gender] = txt_Gender.SelectedValue.ToString();
                                newItem_EmployeeInformation[Constant.persentAddress] = txt_PersentAddress.Text;
                                newItem_EmployeeInformation[Constant.permanentAddress] = txt_PermanentAddress.Text;
                                newItem_EmployeeInformation[Constant.ResidenceNo] = txt_SecondResiNo.Text;
                                newItem_EmployeeInformation[Constant.ResidenceNo1] = txt_FirstResiNo.Text;
                                newItem_EmployeeInformation[Constant.MobileNo] = txt_MobileNo.Text;


                                newItem_EmployeeInformation[Constant.MartialStatus] = txt_MartialStatus.SelectedValue.ToString();
                                newItem_EmployeeInformation[Constant.MarriageDate] = Convert.ToDateTime(txt_MarriageDate.SelectedDate.ToString());
                                newItem_EmployeeInformation[Constant.NoOfkids] = txt_Kids.Text;

                                newItem_EmployeeInformation[Constant.DateSigned] = Convert.ToDateTime(txt_dateSigned.SelectedDate.ToString());
                                newItem_EmployeeInformation[Constant.PlaceSigned] = txt_placeSigned.Text;
                                newItem_EmployeeInformation.Update();
                                Emp_Id = newItem_EmployeeInformation.ID;

                                SPListItem toUpdateEmpItem = EmpInfo.Items.GetItemById(Emp_Id);
                                SPFieldUrlValue hyperLink = new SPFieldUrlValue();
                                hyperLink.Description = Constant.RedirectionLink_Description;
                                hyperLink.Url = Constant.RedirectionLink + Emp_Id.ToString();
                                toUpdateEmpItem[Constant.ViewDetailLink] = hyperLink;
                                toUpdateEmpItem.Update();

                                //Employee Photos Details

                                if (EmployeesPhotos != null)
                                {
                                    SPDocumentLibrary documentLib = web.Lists[Constant.EmployeesPhotos] as SPDocumentLibrary;
                                    //SPListItem newItem_employeesPhotos = EmployeesPhotos.Items.Add();
                                    Stream fStream = file_EmployeePhoto.PostedFile.InputStream;
                                    byte[] _byteArray = new byte[fStream.Length];
                                    fStream.Read(_byteArray, 0, (int)fStream.Length);
                                    fStream.Close();


                                    string filepath = file_EmployeePhoto.FileName.Split(',')[0];
                                    string _fileUrl = documentLib.RootFolder.Url + "/" + file_EmployeePhoto.FileName;
                                    string candidateResumeLink = documentLib.RootFolder.ServerRelativeUrl + "/" + file_EmployeePhoto.FileName;

                                    bool IsOverwriteFile = true;
                                    SPFile file = documentLib.RootFolder.Files.Add(_fileUrl, _byteArray, IsOverwriteFile);

                                    SPListItem item = file.Item;
                                    SPFieldLookupValue lookupvalues = new SPFieldLookupValue(Emp_Id, web.CurrentUser.Name);
                                    item["Title"] = file_EmployeePhoto.FileName.Split('.')[0];
                                    item["Name"] = file_EmployeePhoto.FileName;
                                    item[Constant.EmployeeName] = lookupvalues;
                                    item.Update();
                                    file.Update();
                                }




                                // Push Family Details
                                if (collection_FamilyDetails.Count > 0)
                                {
                                    foreach (var item in collection_FamilyDetails)
                                    {
                                        SPListItem newItem_FamilyDetail = FamilyDetails.Items.Add();

                                        //string lookUpValue = web.CurrentUser.LoginName;

                                        SPFieldLookupValue lookupvalues = new SPFieldLookupValue(Emp_Id, web.CurrentUser.Name);
                                        newItem_FamilyDetail[Constant.EmployeeName] = lookupvalues;
                                        newItem_FamilyDetail[Constant.FamilyName] = item.FamilyName;
                                        newItem_FamilyDetail[Constant.FamilyDateOfBirth] = item.FamilyDateOfBirth;
                                        newItem_FamilyDetail[Constant.FamilyGender] = item.FamilyGender;
                                        newItem_FamilyDetail[Constant.FamilyRelationship] = item.FamilyRelationship;
                                        newItem_FamilyDetail[Constant.FamilyOccupation] = item.FamilyOccupation;
                                        newItem_FamilyDetail.Update();

                                    }

                                }
                                // Medical List

                                if (MedicalCondition != null)
                                {

                                    SPListItem newItem_MedicalCondition = MedicalCondition.Items.Add();

                                    SPFieldLookupValue lookupvalues = new SPFieldLookupValue(Emp_Id, web.CurrentUser.Name);
                                    newItem_MedicalCondition[Constant.EmployeeName] = lookupvalues;
                                    newItem_MedicalCondition[Constant.BloodGroup] = txt_Bloodgroup.Text;
                                    newItem_MedicalCondition[Constant.Ailments] = txt_ailments.Text;
                                    newItem_MedicalCondition[Constant.Allergies] = txt_Allergies.Text;
                                    newItem_MedicalCondition[Constant.OtherMedical] = txt_othermedications.Text;
                                    newItem_MedicalCondition.Update();

                                }

                                // Push Emergency Contact Details

                                if (collection_EmergencyContactDetails.Count > 0)
                                {
                                    foreach (var item in collection_EmergencyContactDetails)
                                    {
                                        SPListItem newItem_EmergencyDetails = EmergencyContactDetails.Items.Add();

                                        //string lookUpValue = web.CurrentUser.LoginName;

                                        SPFieldLookupValue lookupvalues = new SPFieldLookupValue(Emp_Id, web.CurrentUser.Name);
                                        newItem_EmergencyDetails[Constant.EmployeeName] = lookupvalues;
                                        newItem_EmergencyDetails[Constant.ContactPersonName] = item.ContactPersonName;
                                        newItem_EmergencyDetails[Constant.ContactRelations] = item.ContactRelations;
                                        newItem_EmergencyDetails[Constant.EmergencyLandlineno] = item.EmergencyLandlineno;
                                        newItem_EmergencyDetails[Constant.EmergencyMobileNumber] = item.EmergencyMobileNumber;
                                        newItem_EmergencyDetails.Update();


                                    }

                                }
                                // Education Qualification List

                                if (collection_EducationQualifications.Count > 0)
                                {
                                    foreach (var item in collection_EducationQualifications)
                                    {

                                        SPListItem newItem_EducationQualifications = EducationQualification.Items.Add();

                                        //string lookUpValue = web.CurrentUser.LoginName;

                                        SPFieldLookupValue lookupvalues = new SPFieldLookupValue(Emp_Id, web.CurrentUser.Name);
                                        newItem_EducationQualifications[Constant.EmployeeName] = lookupvalues;
                                        newItem_EducationQualifications[Constant.Degree] = item.Degree;
                                        newItem_EducationQualifications[Constant.university] = item.university;
                                        newItem_EducationQualifications[Constant.From] = item.From;
                                        newItem_EducationQualifications[Constant.To] = item.To;
                                        newItem_EducationQualifications[Constant.Percentage] = item.Percentage;
                                        newItem_EducationQualifications.Update();


                                    }

                                }

                                //Permanent Employee Identity and Address Proofs
                                if (hdnEmpType.Value == Constant.EmployeeType_Permanent)
                                {
                                    if (EmployeeIdentityandAddressProofs != null)
                                    {

                                        SPListItem newItem_EmployeeIdentityandAddressProofs = EmployeeIdentityandAddressProofs.Items.Add();

                                        SPFieldLookupValue lookupvalues = new SPFieldLookupValue(Emp_Id, web.CurrentUser.Name);

                                        newItem_EmployeeIdentityandAddressProofs[Constant.EmployeeName] = lookupvalues;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.AadharNumber] = txt_Aadharno.Text;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.PancardNumber] = txt_PANno.Text;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.PassportNumber] = txt_Passportno.Text;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.BankAc] = txt_BankAc.Text;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.PF] = txt_PfAc.Text;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.UAN] = txt_UANno.Text;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.ESIC] = txt_ESICno.Text;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.twowheeler] = txt_twowheeler.Text;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.fourwheeler] = txt_Fourwheeler.Text;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.PublicTransport] = txt_Publictransport.Text;

                                        newItem_EmployeeIdentityandAddressProofs.Update();

                                    }
                                }
                                //Contract Employee Identity and Address Proofs
                                if (hdnEmpType.Value == Constant.EmployeeType_Contract)
                                {
                                    if (EmployeeIdentityandAddressProofs != null)
                                    {

                                        SPListItem newItem_EmployeeIdentityandAddressProofs = EmployeeIdentityandAddressProofs.Items.Add();

                                        SPFieldLookupValue lookupvalues = new SPFieldLookupValue(Emp_Id, web.CurrentUser.Name);

                                        newItem_EmployeeIdentityandAddressProofs[Constant.EmployeeName] = lookupvalues;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.AadharNumber] = txt_Aadharno.Text;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.PancardNumber] = txt_PANno.Text;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.PassportNumber] = txt_Passportno.Text;
                                       
                                        newItem_EmployeeIdentityandAddressProofs[Constant.twowheeler] = txt_twowheeler.Text;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.fourwheeler] = txt_Fourwheeler.Text;
                                        newItem_EmployeeIdentityandAddressProofs[Constant.PublicTransport] = txt_Publictransport.Text;

                                        newItem_EmployeeIdentityandAddressProofs.Update();

                                    }
                                }

                                //Push Employee Reference Details

                                if (collection_EmployeeReferences.Count > 0)
                                {
                                    foreach (var item in collection_EmployeeReferences)
                                    {
                                        SPListItem newItem_EmployeeReference = EmployeeReferences.Items.Add();

                                        //string lookUpValue = web.CurrentUser.LoginName;

                                        SPFieldLookupValue lookupvalues = new SPFieldLookupValue(Emp_Id, web.CurrentUser.Name);
                                        newItem_EmployeeReference[Constant.EmployeeName] = lookupvalues;
                                        newItem_EmployeeReference[Constant.ReferenceName] = item.ReferenceName;
                                        newItem_EmployeeReference[Constant.ReferenceWorkingIn] = item.ReferenceWorkingIn;
                                        newItem_EmployeeReference[Constant.ReferenceWorkingAs] = item.ReferenceWorkingAs;
                                        newItem_EmployeeReference[Constant.ReferenceContactNo] = item.ReferenceContactNo;
                                        newItem_EmployeeReference.Update();


                                    }

                                }

                                //Push Employee Previous Company Details

                                if (hdnEmpType.Value == Constant.EmployeeType_Permanent)
                                {
                                    if (collection_EmployeePreviousExperience.Count > 0)
                                    {
                                        foreach (var item in collection_EmployeePreviousExperience)
                                        {
                                            SPListItem newItem_EmployeePreviousExperience = EmployeePreviousWorkingDetails.Items.Add();

                                            //string lookUpValue = web.CurrentUser.LoginName;

                                            SPFieldLookupValue lookupvalues = new SPFieldLookupValue(Emp_Id, web.CurrentUser.Name);
                                            newItem_EmployeePreviousExperience[Constant.EmployeeName] = lookupvalues;
                                            newItem_EmployeePreviousExperience[Constant.PreviousCompany] = item.PreviousCompany;
                                            newItem_EmployeePreviousExperience[Constant.PreviousDesignation] = item.PreviousDesignation;
                                            newItem_EmployeePreviousExperience[Constant.PreviousDateofjoining] = item.PreviousDateofjoining;
                                            newItem_EmployeePreviousExperience[Constant.PreviousDateofRelieving] = item.PreviousDateofRelieving;
                                            newItem_EmployeePreviousExperience[Constant.PreviousContactNo] = item.PreviousContactNo;
                                            newItem_EmployeePreviousExperience[Constant.PreviousReason] = item.PreviousReason;
                                            newItem_EmployeePreviousExperience.Update();


                                        }

                                    }
                                }


                                if (hdnEmpType.Value == Constant.EmployeeType_Contract)
                                {

                                    if (collection_ContractDetails.Count > 0)
                                    {
                                        foreach (var item in collection_ContractDetails)
                                        {
                                            SPListItem newItem_ContractDetails = EmployeePreviousWorkingDetails.Items.Add();
                                            SPFieldLookupValue lookupvalues = new SPFieldLookupValue(Emp_Id, web.CurrentUser.Name);
                                            newItem_ContractDetails[Constant.EmployeeName] = lookupvalues;
                                            newItem_ContractDetails[Constant.PreviousCompany] = item.ContractCompany;
                                            newItem_ContractDetails[Constant.PreviousDesignation] = item.ContractDesignation;
                                            newItem_ContractDetails[Constant.PreviousDateofjoining] = item.ContractDOJ;
                                            newItem_ContractDetails[Constant.ContractDuration] = item.ContractDuration;
                                            newItem_ContractDetails[Constant.ContractContactPerson] = item.ContractContactPerson;
                                            newItem_ContractDetails[Constant.PreviousContactNo] = item.ContractContactNo;
                                            newItem_ContractDetails.Update();
                                        }
                                    }

                                }

                                //Employee Signature Details
                                if (EmployeesSignature != null)
                                {
                                    SPDocumentLibrary documentLib = web.Lists[Constant.EmployeesSignature] as SPDocumentLibrary;

                                    Stream fStream = fileupload_signature.PostedFile.InputStream;
                                    byte[] _byteArray = new byte[fStream.Length];
                                    fStream.Read(_byteArray, 0, (int)fStream.Length);
                                    fStream.Close();


                                    string filepath = fileupload_signature.FileName.Split(',')[0];
                                    string _fileUrl = documentLib.RootFolder.Url + "/" + fileupload_signature.FileName;
                                    string candidateResumeLink = documentLib.RootFolder.ServerRelativeUrl + "/" + fileupload_signature.FileName;

                                    bool IsOverwriteFile = true;
                                    SPFile file = documentLib.RootFolder.Files.Add(_fileUrl, _byteArray, IsOverwriteFile);

                                    SPListItem item = file.Item;
                                    SPFieldLookupValue lookupvalues = new SPFieldLookupValue(Emp_Id, web.CurrentUser.Name);
                                    item["Title"] = fileupload_signature.FileName.Split('.')[0];
                                    item["Name"] = fileupload_signature.FileName;
                                    item[Constant.EmployeeName] = lookupvalues;
                                    item.Update();
                                    file.Update();
                                }


                            }
                            web.AllowUnsafeUpdates = false;
                            Page.Response.Redirect(SPContext.Current.Site.Url + MainSite, false);
                        }
                    }
                });



            }

            catch (Exception ex)
            {

            }
        }

        protected void Permanent(object sender, EventArgs e)
        {
            //string flag_EmployeeType = hdnEmpType.Value;
            hdnEmpType.Value = Constant.EmployeeType_Permanent;
            div_HeadingPermanentEmployee.Visible = true;
            div_HeadingContractEmployee.Visible = false;
            tr_Bankacc.Visible = true;
            tr_PFno.Visible = true;
            tr_ESICno.Visible = true;
            tr_UANno.Visible = true;
            div_EmployeeType_Contract_Details.Visible = false;
            div_EmployeeType_Permanent_PreviousExperience.Visible = true;
        }

        protected void Contract(object sender, EventArgs e)
        {
            /// string flag_EmployeeType = hdnEmpType.Value;
            hdnEmpType.Value = Constant.EmployeeType_Contract;
            div_HeadingPermanentEmployee.Visible = false;
            div_HeadingContractEmployee.Visible = true;
            tr_Bankacc.Visible = false;
            tr_PFno.Visible = false;
            tr_ESICno.Visible = false;
            tr_UANno.Visible = false;
            div_EmployeeType_Contract_Details.Visible = true;
            div_EmployeeType_Permanent_PreviousExperience.Visible = false;

        }

        private void Get_FormInputCollections()
        {
            Get_FamilyMemberDetails();
            Get_EmergencyContactDetails();
            Get_EducationQualifications();
            Get_EmployeeReferences();
            if (hdnEmpType.Value == Constant.EmployeeType_Permanent)
            {
                Get_EmployeePreviousExperience();
            }
            if (hdnEmpType.Value == Constant.EmployeeType_Contract)
            {
                Get_ContractDetails();
            }
        }


        

    }
}
