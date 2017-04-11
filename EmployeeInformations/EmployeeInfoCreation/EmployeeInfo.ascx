<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %><%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %><%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %><%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %><%@ Import Namespace="Microsoft.SharePoint" %><%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %><%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmployeeInfo.ascx.cs" Inherits="EmployeeInformations.EmployeeInfo.EmployeeInfo" %><asp:Label ID="lblstatus" runat="server"></asp:Label>


<link type="text/css" rel="stylesheet" href="http://devsp13:42535/SiteAssets/Design/css/bootstrap.min.css" />
<link type="text/css" rel="stylesheet" href="http://devsp13:42535/SiteAssets/Design/css/main.css" />
<link href="http://devsp13:42535/SiteAssets/Design/css/tab.css" rel="stylesheet" />
<asp:HiddenField ID="hdnEmpType" runat="server" />

<div class="tab">

        <asp:Button ID="btn_permanentTab" runat="server" class="EmployeeSwitch tablinks" Text="Permanent" OnClick="Permanent" />
        <asp:Button ID="btn_contractTab" runat="server" class="EmployeeSwitch tablinks" Text="Contract" OnClick="Contract" />



    </div>

<div class="container wrapper">

    


    <div class="row">
        <div class="col-md-12">
            <div class="headerbg" id="div_HeadingPermanentEmployee" runat="server">
                <h2>Permanent Employee Information Form</h2>
            </div>
            <div class="headerbg" id="div_HeadingContractEmployee" runat="server">
                <h2>Contract Employee Information Form</h2>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="compcont">
            <div class="col-md-2 nopad">

                <img src="http://devsp13:42535/SiteAssets/Design/images/logo.png" class="img-responsive" />
            </div>
            <div class="col-md-8">
                <div class="companyinfo">
                    <ul>
                        <li>Tillid Software Solutions Pvt. Ltd.</li>
                        <li>Arut Jothi Towers (II floor),</li>
                        <li>No: 2 &amp; 9, Shakthi Nagar,</li>
                        <li>Mt. Poonamallee Rd,</li>
                        <li>Porur</li>
                        <li>Chennai - 600 116.</li>
                        <li><span>Phone</span>-<span>044 4505 2443</span><span> Wesbite : <a href="http://www.tillidsoftware.com/" target="_blank">http://www.tillidsoftware.com</a></span></li>
                    </ul>
                </div>
            </div>
            <div class="col-md-2 nopad emp_image">
                <asp:FileUpload ID="file_EmployeePhoto" runat="server" class="filesubmit" />
                <%--<asp:RequiredFieldValidator ID="required_Empphoto" runat="server"
                            ControlToValidate="file_EmployeePhoto" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>--%>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="innerheadbg">
                <h5>Personal Information</h5>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="table-responsive personinfotable">
                <table class="table tablenobrdr">
                    <tr>
                        <td>First name</td>
                        <td>
                            <asp:TextBox class="form-control" runat="server" ID="txt_FirstName"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="required_Firstname" runat="server"
                                ControlToValidate="txt_FirstName" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                        <td>Last Name</td>
                        <td>
                            <asp:TextBox class="form-control" runat="server" ID="txt_LastName"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="required_Lastname" runat="server"
                                ControlToValidate="txt_LastName" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Date of Birth</td>
                        <td>
                            <SharePoint:DateTimeControl runat="server" ID="txt_DateOfBirth" DateOnly="true" />
                            <%--<asp:RequiredFieldValidator ID="required_DOB" runat="server"
                            ControlToValidate="txt_DateOfBirth" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>--%>
                        </td>
                        <td>Gender</td>
                        <td>
                            <asp:RadioButtonList ID="txt_Gender" class="radio-inline" runat="server">
                                <asp:ListItem Text="Male" Value="Male" />
                                <asp:ListItem Text="Female" Value="Female" />
                            </asp:RadioButtonList>

                        </td>
                    </tr>
                    <tr>
                        <td>Present Address</td>
                        <td colspan="3">
                            <asp:TextBox ID="txt_PersentAddress" runat="server" class="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="required_PresentAddress" runat="server"
                                ControlToValidate="txt_PersentAddress" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Permanent Address</td>
                        <td colspan="3">
                            <asp:TextBox ID="txt_PermanentAddress" class="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="required_PermanentAddress" runat="server"
                                ControlToValidate="txt_PermanentAddress" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Residence Contact No:</td>
                        <td colspan="3">
                            <table width="100%">
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txt_FirstResiNo" runat="server" class="form-control" placeholder="Residence Contact Number 1"></asp:TextBox>
                                    </td>
                                    <td class="padclass">
                                        <asp:TextBox ID="txt_SecondResiNo" runat="server" class="form-control" placeholder="Residence Contact Number 2"></asp:TextBox>
                                    </td>
                                    <td>Mobile No:</td>
                                    <td>
                                        <asp:TextBox ID="txt_MobileNo" runat="server" class="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="required_EmpMobileNo" runat="server"
                                            ControlToValidate="txt_MobileNo" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>Martial Status:</td>
                        <td colspan="3">
                            <table width="100%">
                                <tr>
                                    <td colspan="2">
                                        <table width="100%">
                                            <tr>
                                                <td>

                                                    <asp:RadioButtonList ID="txt_MartialStatus" class="radio-inline" runat="server">
                                                        <asp:ListItem>Single</asp:ListItem>
                                                        <asp:ListItem>Married</asp:ListItem>
                                                    </asp:RadioButtonList>

                                                </td>
                                                <td>
                                                    <asp:Label ID="lbl_MarriageDate" runat="server" Text="Marriage Date:"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td colspan="2">
                                        <table width="100%">
                                            <tr>
                                                <td>
                                                    <SharePoint:DateTimeControl ID="txt_MarriageDate" runat="server" DateOnly="true" />
                                                </td>
                                                <td class="padclass">
                                                    <asp:Label ID="lbl_kids" runat="server" Text="Kids (in numbers)"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txt_Kids" runat="server" class="form-control"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="innerheadbg">
                <h5>Family Details</h5>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="table-responsive customtab">
                <table class="table">
                    <thead>
                        <tr>
                            <th width="10%">Sr No</th>
                            <th width="25%">Name</th>
                            <th width="15%">Date of birth</th>
                            <th width="10%">Gender</th>
                            <th width="20%">Relationship</th>
                            <th width="20%">Occupation</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td align="center">1</td>
                            <td>
                                <asp:TextBox ID="txt_Family_FirstName1" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="txt_Family_DOB1" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_Family_Gender1" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_Family_Relationship1" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_Family_Occupation1" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">2</td>
                            <td>
                                <asp:TextBox ID="txt_Family_FirstName2" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="txt_Family_DOB2" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_Family_Gender2" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_Family_Relationship2" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_Family_Occupation2" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">3</td>
                            <td>
                                <asp:TextBox ID="txt_Family_FirstName3" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="txt_Family_DOB3" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_Family_Gender3" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_Family_Relationship3" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_Family_Occupation3" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">4</td>
                            <td>
                                <asp:TextBox ID="txt_Family_FirstName4" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="txt_Family_DOB4" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_Family_Gender4" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_Family_Relationship4" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_Family_Occupation4" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">5</td>
                            <td>
                                <asp:TextBox ID="txt_Family_FirstName5" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="txt_Family_DOB5" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_Family_Gender5" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_Family_Relationship5" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_Family_Occupation5" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="innerheadbg">
                <h5>Medical Condition</h5>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="table-responsive customtab">
                <table class="table">
                    <tr>
                        <td width="30%">Blood Group</td>
                        <td width="70%">
                            <div class="col-md-4 nopad">
                            <asp:TextBox ID="txt_Bloodgroup" runat="server" class="form-control"></asp:TextBox>
                                </div>
                        </td>
                    </tr>
                    <tr>
                        <td width="30%">Ailments (Heart condition, BP, Sugar, etc.,)</td>
                        <td width="70%">
                            <div class="col-md-4 nopad">
                            <asp:TextBox ID="txt_ailments" runat="server" class="form-control"></asp:TextBox></div></td>
                    </tr>
                    <tr>
                        <td width="30%">Allergies (Drug, food, etc.,)</td>
                        <td width="70%">
                            <div class="col-md-4 nopad">
                            <asp:TextBox ID="txt_Allergies" runat="server" class="form-control"></asp:TextBox></div></td>
                    </tr>
                    <tr>
                        <td width="30%">Undergoing any other medications?</td>
                        <td width="70%">
                            <div class="col-md-4 nopad">
                            <asp:TextBox ID="txt_othermedications" runat="server" class="form-control"></asp:TextBox></div></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="innerheadbg">
                <h5>Emergency Contact Details</h5>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="table-responsive customtab">
                <table class="table">
                    <thead>
                        <tr>
                            <th width="10%">Sr No</th>
                            <th width="25%">Contact Person Name</th>
                            <th width="35%">Relation</th>
                            <th width="15%">Mobile No</th>
                            <th width="15%">Alternative Mobile No</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td align="center">1</td>
                            <td>
                                <asp:TextBox ID="txt_ContactPersonName1" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_Relation1" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_EmergencylandlineNo1" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_EmergencyMobileNo1" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">2</td>
                            <td>
                                <asp:TextBox ID="txt_ContactPersonName2" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_Relation2" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_EmergencylandlineNo2" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_EmergencyMobileNo2" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>

                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="innerheadbg">
                <h5>Educational Qualification</h5>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="table-responsive customtab">
                <table class="table">
                    <thead>
                        <tr>
                            <th width="10%">Sr No</th>
                            <th width="25%">School/Degree/Diploma/Certificate</th>
                            <th width="25%">Institute/University</th>
                            <th width="15%">From</th>
                            <th width="15%">To</th>
                            <th width="10%">Percentage</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td align="center">1</td>
                            <td>
                                <asp:TextBox ID="txt_Degree1" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_University1" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_From1" runat="server" DateOnly="true" />
                            </td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_To1" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_Percentage1" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">2</td>
                            <td>
                                <asp:TextBox ID="txt_Degree2" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_University2" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_From2" runat="server" DateOnly="true" />
                            </td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_To2" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_Percentage2" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">3</td>
                            <td>
                                <asp:TextBox ID="txt_Degree3" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_University3" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_From3" runat="server" DateOnly="true" />
                            </td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_To3" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_Percentage3" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">4</td>
                            <td>
                                <asp:TextBox ID="txt_Degree4" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_University4" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_From4" runat="server" DateOnly="true" />
                            </td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_To4" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_Percentage4" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">5</td>
                            <td>
                                <asp:TextBox ID="txt_Degree5" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_University5" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_From5" runat="server" DateOnly="true" />
                            </td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_To5" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_Percentage5" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="innerheadbg">
                <h5>Other Dossier</h5>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="table-responsive customtab">
                <table class="table">
                    <tr>
                        <td width="20%">Aadhar Card Number:</td>
                        <td width="80%">
                            <div class="col-md-4 nopad">
                                <asp:TextBox ID="txt_Aadharno" runat="server" class="form-control"></asp:TextBox>

                                <asp:RequiredFieldValidator ID="required_AadharNumber" runat="server"
                                    ControlToValidate="txt_Aadharno" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td width="20%">PAN Card Number:</td>
                        <td width="80%">
                            <div class="col-md-4 nopad">
                                <asp:TextBox ID="txt_PANno" runat="server" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="required_PANno" runat="server"
                                    ControlToValidate="txt_PANno" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td width="20%">Passport Number :</td>

                        <td width="80%">
                            <div class="col-md-4 nopad">
                                <asp:TextBox ID="txt_Passportno" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </td>

                    </tr>
                    <tr id="tr_Bankacc" runat="server">
                        <td width="20%">Bank A/C No you want your salary to be credited (if from HDFC) with Branch Name :</td>

                        <td width="80%">
                            <div class="col-md-4 nopad">
                                <asp:TextBox ID="txt_BankAc" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </td>

                    </tr>
                    <tr id="tr_PFno" runat="server">
                        <td width="20%">PF A/C No :</td>

                        <td width="80%">
                            <div class="col-md-4 nopad">
                                <asp:TextBox ID="txt_PfAc" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </td>
                    </tr>
                    <tr id="tr_UANno" runat="server">
                        <td width="20%">UAN No :</td>

                        <td width="80%">
                            <div class="col-md-4 nopad">
                                <asp:TextBox ID="txt_UANno" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </td>
                    </tr>
                    <tr id="tr_ESICno" runat="server">
                        <td width="20%">ESIC No :</td>
                        <td width="80%">
                            <div class="col-md-4 nopad">
                                <asp:TextBox ID="txt_ESICno" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </td>

                    </tr>
                    <tr>
                        <td width="20%">Mode of Transport – Vehicle No :</td>
                        <td width="80%">
                            <table width="100%" class="innertable">
                                <tr>
                                    <td>Two wheeler</td>
                                    <td>
                                        <div class="col-md-4 nopad">
                                            <asp:TextBox ID="txt_twowheeler" runat="server" class="form-control"></asp:TextBox>
                                        </div>
                                    </td>

                                    <td class="padclass">Four Wheeler</td>
                                    <td>
                                        <div class="col-md-4 nopad">
                                            <asp:TextBox ID="txt_Fourwheeler" runat="server" class="form-control"></asp:TextBox>
                                        </div>
                                    </td>

                                    <td class="padclass">Public Transport</td>
                                    <td>  <div class="col-md-4 nopad">
                                        <asp:TextBox ID="txt_Publictransport" runat="server" class="form-control"></asp:TextBox></div></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
<div class="row">
    <div class="col-md-12">
        <div class="innerheadbg">
            <h5>References (other than family members)</h5>
        </div>
    </div>
</div>
<div class="row">
    <div class="col-md-12">
        <div class="table-responsive customtab">
            <table class="table">
                <thead>
                    <tr>
                        <th width="10%">Sr No</th>
                        <th width="20%">Name</th>
                        <th width="27%">Working In</th>
                        <th width="27%">Working As</th>
                        <th width="16%">Contact No</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td align="center">1</td>
                        <td>
                            <asp:TextBox ID="txt_ReferenceName1" runat="server" class="form-control"></asp:TextBox></td>
                        <asp:RequiredFieldValidator ID="required_ReferenceName1" runat="server"
                            ControlToValidate="txt_ReferenceName1" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <td>
                            <asp:TextBox ID="txt_ReferenceWorkingIn1" runat="server" class="form-control"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="txt_ReferenceWorkingAs1" runat="server" class="form-control"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="txt_RefrenceContactNo1" runat="server" class="form-control"></asp:TextBox></td>
                        <asp:RequiredFieldValidator ID="required_ReferenceMobileNo1" runat="server"
                            ControlToValidate="txt_RefrenceContactNo1" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </tr>
                    <tr>
                        <td align="center">2</td>
                        <td>
                            <asp:TextBox ID="txt_ReferenceName2" runat="server" class="form-control"></asp:TextBox></td>

                        <td>
                            <asp:TextBox ID="txt_ReferenceWorkingIn2" runat="server" class="form-control"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="txt_ReferenceWorkingAs2" runat="server" class="form-control"></asp:TextBox></td>
                        <td>
                            <asp:TextBox ID="txt_ReferenceContactNo2" runat="server" class="form-control"></asp:TextBox></td>
                    </tr>



                </tbody>
            </table>
        </div>
    </div>
</div>
<%-- Permanent Employee --%>

<div id="div_EmployeeType_Permanent_PreviousExperience" class="Employee-Permanent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="innerheadbg">
                <h5>Previous Experience(s)</h5>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="table-responsive customtab">
                <table class="table">
                    <thead>
                        <tr>
                            <th width="5%">Sr No</th>
                            <th width="15%">Company Name</th>
                            <th width="15%">Designation</th>
                            <th width="15%">Date Of Joining</th>
                            <th width="15%">Date Of Relieving</th>
                            <th width="15%">Contact No</th>
                            <th width="20%">Reason</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td align="center">1</td>
                            <td>
                                <asp:TextBox ID="txt_PrevCompanyName1" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_PrevDesignation1" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_PrevDOJ1" runat="server" DateOnly="true" />
                            </td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_PrevDOR1" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_PrevContactNo1" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_PrevReason1" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">2</td>
                            <td>
                                <asp:TextBox ID="txt_PrevCompanyName2" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_PrevDesignation2" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_PrevDOJ2" runat="server" DateOnly="true" />
                            </td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_PrevDOR2" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_PrevContactNo2" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_PrevReason2" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">3</td>
                            <td>
                                <asp:TextBox ID="txt_PrevCompanyName3" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_PrevDesignation3" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_PrevDOJ3" runat="server" DateOnly="true" />
                            </td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_PrevDOR3" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_PrevContactNo3" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_PrevReason3" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">4</td>
                            <td>
                                <asp:TextBox ID="txt_PrevCompanyName4" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_PrevDesignation4" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_PrevDOJ4" runat="server" DateOnly="true" />
                            </td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_PrevDOR4" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_PrevContactNo4" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_PrevReason4" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">5</td>
                            <td>
                                <asp:TextBox ID="txt_PrevCompanyName5" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_PrevDesignation5" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_PrevDOJ5" runat="server" DateOnly="true" />
                            </td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_PrevDOR5" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_PrevContactNo5" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_PrevReason5" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

<%-- End of Permanent Employee --%>

<%-- Contract Employee --%>
<div id="div_EmployeeType_Contract_Details" class="Employee-Contract" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="innerheadbg">
                <h5>Contract Details</h5>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="table-responsive customtab">
                <table class="table">
                    <thead>
                        <tr>
                            <th width="5%">Sr No</th>
                            <th width="15%">Company Name</th>
                            <th width="15%">Designation</th>
                            <th width="15%">Date Of Joining</th>
                            <th width="15%">Duration</th>
                            <th width="15%">Contact Person</th>
                            <th width="20%">Contact No</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td align="center">1</td>
                            <td>
                                <asp:TextBox ID="txt_ContractCompany1" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractDesignation1" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_contractDOJ1" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_ContractDuration1" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractContactPerson1" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractContactNo1" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">2</td>
                            <td>
                                <asp:TextBox ID="txt_ContractCompany2" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractDesignation2" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_contractDOJ2" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_ContractDuration2" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractContactPerson2" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractContactNo2" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">3</td>
                            <td>
                                <asp:TextBox ID="txt_ContractCompany3" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractDesignation3" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_contractDOJ3" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_ContractDuration3" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractContactPerson3" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractContactNo3" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">4</td>
                            <td>
                                <asp:TextBox ID="txt_ContractCompany4" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractDesignation4" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_contractDOJ4" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_ContractDuration4" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractContactPerson4" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractContactNo4" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center">5</td>
                            <td>
                                <asp:TextBox ID="txt_ContractCompany5" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractDesignation5" runat="server" class="form-control"></asp:TextBox></td>
                            <td class="calendar">
                                <SharePoint:DateTimeControl ID="date_contractDOJ5" runat="server" DateOnly="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="txt_ContractDuration5" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractContactPerson5" runat="server" class="form-control"></asp:TextBox></td>
                            <td>
                                <asp:TextBox ID="txt_ContractContactNo5" runat="server" class="form-control"></asp:TextBox></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>


<%-- End of Contract Employee --%>

<div class="row">
    <div class="col-md-12">
        <p>I hereby affirm that the aforementioned information given by me is true and correct and that I have not held back any information. Any information given here is found to be false, I shall be liable for dismissal.</p>
        <div class="decalration">
            <p>This is to acknowledge that Tillid Software Solutions does not hold any of my original documents.  And the company no longer responsible for the same in case of any loss.</p>
        </div>
        <p class="redtxt">* In case any changes in personal information should be intimate to HR department within 24 hrs.</p>
    </div>
</div>
<div class="row">
    <div class="col-md-12">
        <div class="table-responsive customtab">
            <table class="table">
                <tr>
                    <td width="30%">Date:</td>
                    <td width="70%" class="calendar">
                        <SharePoint:DateTimeControl ID="txt_dateSigned" runat="server" DateOnly="true" />
                        <%-- <asp:RequiredFieldValidator ID="required_Datesigned" runat="server"
                            ControlToValidate="txt_dateSigned" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
                <tr>
                    <td width="30%">Place:</td>
                    <td width="70%">
                        <div class="col-md-4 nopad">
                        <asp:TextBox ID="txt_placeSigned" runat="server" class="form-control"></asp:TextBox></div></td>
                    <asp:RequiredFieldValidator ID="required_Placesigned" runat="server"
                        ControlToValidate="txt_placeSigned" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </tr>
                <tr>
                    <td colspan="2" align="right">
                        <p></p>
                        <p><strong>Siganture</strong></p>
                        <asp:FileUpload ID="fileupload_signature" runat="server" />
                        <%-- <asp:RequiredFieldValidator ID="required_EmpSignature" runat="server"
                            ControlToValidate="fileupload_signature" Display="Dynamic" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</div>
    <div class="row">
        <div class="col-md-12">
     <asp:Button ID="Save" runat="server" class="btn pull-right" Text="Submit" OnClick="Save_Click" />
        </div>
        </div>
</div>
   




<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>

<script>



    //$('.EmployeeSwitch').click(function () {
    //    var set = $(this).attr('data-target');
    //    if (set == "Permanent") {
    //        $('.Employee-Permanent').show();
    //        $('.Employee-Contract').hide();
    //    }
    //    if (set == "Contract") {
    //        $('.Employee-Permanent').hide();
    //        $('.Employee-Contract').show();
    //    }
    //});
</script>
