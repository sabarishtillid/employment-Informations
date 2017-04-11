<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmployeeInforetrieve.ascx.cs" Inherits="EmployeeInformations.EmployeeInforetrieve.EmployeeInforetrieve" %>
<asp:HiddenField ID="hdnEmpType" runat="server" />
<asp:HiddenField ID="hidden_Empsignphotos" runat="server" />
 <asp:HiddenField ID="hidden_Empphotos" runat="server" />
	<link type="text/css" rel="stylesheet" href="http://devsp13:42535/SiteAssets/Design/css/bootstrap.min.css" />
	<link type="text/css" rel="stylesheet" href="http://devsp13:42535/SiteAssets/Design/css/main.css" />


	<div class="container wrapper">
		<div class="row">
			<div class="col-md-12">
				<div class="headerbg" id="div_HeadingPermanentEmployee" runat="server">
					<h2>Permanent Employee Information Form <asp:Button ID="btn_Print" class="btn pull-right" runat="server" Text="Print"  OnClick="Print_Form" /></h2>
				</div>
                <div class="headerbg" id="div_HeadingContractEmployee" runat="server">
					<h2>Contract Employee Information Form <asp:Button ID="Button1" runat="server" class="btn pull-right" Text="Print"  OnClick="Print_Form" /></h2>
				</div>
			</div>
		</div>	
		<div class="row">
			<div class="compcont">
				<div class="col-md-2 nopad">
					<img src="http://devsp13:42535/SiteAssets/Design/images/logo.png" class="img-responsive"/>
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
                    <asp:Image ID="img_Empphotos" runat="server" class="img-responsive" />
					
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
                    
                    <table class="table">
                        <tbody><tr>
                            
							<td><strong>First Name :</strong></td>
							<td><asp:Label ID="lbl_Firstname" runat="server" ></asp:Label></td>
							<td><strong>Last Name :</strong></td>
							<td><asp:Label ID="lbl_Lastname" runat="server" ></asp:Label></td>
						</tr>
                        <tr>
							<td><Strong>Date Of Birth</Strong></td>
							<td><asp:Label ID="lbl_Dateofbirth" runat="server" ></asp:Label> </td>
							<td><Strong>Gender</Strong></td>
							<td><asp:Label ID="lbl_Gender" runat="server" ></asp:Label></td>
						</tr>
                        <tr>
							<td><Strong>Present Address</Strong></td>
							<td colspan="3"><asp:Label ID="lbl_PresentAddress" runat="server" ></asp:Label></td>
						</tr>
                        <tr>
							<td><Strong>Permanent Address</Strong></td>
							<td colspan="3"><asp:Label ID="lbl_PermanentAddress" runat="server" ></asp:Label></td>
						</tr>
                        <tr>
							<td><Strong>Residence Contact No:</Strong></td>
							<td colspan="3" style="padding: 0px;">
                                <table width="100%">
                                    <tbody><tr>
                                        <td><asp:Label ID="lbl_ResicontactNo1" runat="server" ></asp:Label></td>
                                        <td><asp:Label ID="lbl_ResicontactNo2" runat="server" ></asp:Label></td>
                                        <td><Strong>Mobile No:</Strong></td>
                                        <td><asp:Label ID="lbl_MobileNo" runat="server" ></asp:Label></td>
                                    </tr>
                                </tbody></table>
							</td>
						</tr>
                        <tr>
							<td><strong>Martial Status:</strong></td>
							<td colspan="3" style="padding: 0px;">
                                <table width="100%">
                                    <tbody><tr>
                                        <td><asp:Label ID="lbl_Martialstatus" runat="server" ></asp:Label></td>
                                        <td><Strong>Marriage Date :</Strong></td>
                                        <td><asp:Label ID="lbl_Marriagedate" runat="server" ></asp:Label></td>
                                        <td><Strong>Kids in Nos:</Strong></td>
                                        <td><asp:Label ID="lbl_Noofkids" runat="server" ></asp:Label></td>
                                    </tr>
                                </tbody></table>
                            </td>
                    </tr></tbody>

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
							<td><asp:Label ID="lbl_Familyname1" runat="server"></asp:Label></td>
							<td><asp:Label ID="lbl_FamilyDOB1" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Familygender1" runat="server"  ></asp:Label></td>
							<td><asp:Label ID="lbl_Familyrelationship1" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Familyoccupation1" runat="server" ></asp:Label></td>
						</tr>
						<tr>
							<td align="center">2</td>
							<td><asp:Label ID="lbl_Familyname2" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_FamilyDOB2" runat="server"></asp:Label></td>
							<td><asp:Label ID="lbl_Familygender2" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Familyrelationship2" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Familyoccupation2" runat="server" ></asp:Label></td>
						</tr>
						<tr>
							<td align="center">3</td>
							<td><asp:Label ID="lbl_Familyname3" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_FamilyDOB3" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Familygender3" runat="server"></asp:Label></td>
							<td><asp:Label ID="lbl_Familyrelationship3" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Familyoccupation3" runat="server"></asp:Label></td>
						</tr>
						<tr>
							<td align="center">4</td>
							<td><asp:Label ID="lbl_Familyname4" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_FamilyDOB4" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Familygender4" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Familyrelationship4" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Familyoccupation4" runat="server" ></asp:Label></td>
						</tr>
						<tr>
							<td align="center">5</td>
							<td><asp:Label ID="lbl_Familyname5" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_FamilyDOB5" runat="server"></asp:Label></td>
							<td><asp:Label ID="lbl_Familygender5" runat="server"></asp:Label></td>
							<td><asp:Label ID="lbl_Familyrelationship5" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Familyoccupation5" runat="server" ></asp:Label></td>
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
						<td width="70%"><asp:Label ID="lbl_Bloodgroup" runat="server"></asp:Label></td>
					</tr>
					<tr>
						<td width="30%">Ailments (Heart condition, BP, Sugar, etc.,)</td>
						<td width="70%"><asp:Label ID="lbl_Ailments" runat="server" ></asp:Label></td>
					</tr>
					<tr>
						<td width="30%">Allergies (Drug, food, etc.,)</td>
						<td width="70%"><asp:Label ID="lbl_Allergies" runat="server"></asp:Label></td>
					</tr>
					<tr>
						<td width="30%">Undergoing any other medications?</td>
						<td width="70%"><asp:Label ID="lbl_Othermedications" runat="server" ></asp:Label></td>
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
							<td><asp:Label ID="lbl_Contactperson1" runat="server"   ></asp:Label></td>
							<td><asp:Label ID="lbl_Contactrelation1" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Contactlandlinno1" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Contactmobileno1" runat="server"></asp:Label></td>
						</tr>
						<tr>
							<td align="center">2</td>
							<td><asp:Label ID="lbl_Contactperson2" runat="server"  ></asp:Label></td>
							<td><asp:Label ID="lbl_Contactrelation2" runat="server"  ></asp:Label></td>
							<td><asp:Label ID="lbl_Contactlandlinno2" runat="server"  ></asp:Label></td>
							<td><asp:Label ID="lbl_Contactmobileno2" runat="server"  ></asp:Label></td>
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
							<td><asp:Label ID="lbl_Degree1" runat="server"  ></asp:Label></td>
							<td><asp:Label ID="lbl_University1" runat="server"  ></asp:Label></td>
							<td><asp:Label ID="lbl_From1" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_To1" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Percentage1" runat="server" ></asp:Label></td>
						</tr>
						<tr>
							<td align="center">2</td>
							<td><asp:Label ID="lbl_Degree2" runat="server"  ></asp:Label></td>
							<td><asp:Label ID="lbl_University2" runat="server"  ></asp:Label></td>
							<td><asp:Label ID="lbl_From2" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_To2" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Percentage2" runat="server" ></asp:Label></td>
						</tr>
						<tr>
							<td align="center">3</td>
							<td><asp:Label ID="lbl_Degree3" runat="server"  ></asp:Label></td>
							<td><asp:Label ID="lbl_University3" runat="server"  ></asp:Label></td>
							<td><asp:Label ID="lbl_From3" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_To3" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Percentage3" runat="server" ></asp:Label></td>
						</tr>
						<tr>
							<td align="center">4</td>
							<td><asp:Label ID="lbl_Degree4" runat="server"   ></asp:Label></td>
							<td><asp:Label ID="lbl_University4" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_From4" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_To4" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Percentage4" runat="server" ></asp:Label></td>
						</tr>
						<tr>
							<td align="center">5</td>
							<td><asp:Label ID="lbl_Degree5" runat="server"   ></asp:Label></td>
							<td><asp:Label ID="lbl_University5" runat="server"  ></asp:Label></td>
							<td><asp:Label ID="lbl_From5" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_To5" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Percentage5" runat="server" ></asp:Label></td>
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
						<td width="80%"><asp:Label ID="lbl_Aadharno" runat="server"   ></asp:Label></td>
					</tr>
					<tr>
						<td width="20%">PAN Card Number:</td>
						<td width="80%"><asp:Label ID="lbl_Panno" runat="server"   ></asp:Label></td>
					</tr>
					<tr>
						<td width="20%">Passport Number :</td>
						<td width="80%"><asp:Label ID="lbl_Passportno" runat="server"   ></asp:Label></td>
					</tr>
					<tr id="tr_Bankacc" runat="server">
						<td width="20%">Bank A/C No you want your salary to be credited (if from HDFC) with Branch Name :</td>
						<td width="80%"><asp:Label ID="lbl_bankaccno" runat="server"   ></asp:Label></td>
					</tr>
					<tr id="tr_PFno" runat="server">
						<td width="20%">PF A/C No :</td>
						<td width="80%"><asp:Label ID="lbl_Pfaccno" runat="server"   ></asp:Label></td>
					</tr>
					<tr id="tr_UANno" runat="server">
						<td width="20%">UAN No :</td>
						<td width="80%"><asp:Label ID="lbl_Uanno" runat="server"   ></asp:Label></td>
					</tr>
					<tr id="tr_ESICno" runat="server">
						<td width="20%">ESIC No :</td>
						<td width="80%"><asp:Label ID="lbl_Esicno" runat="server"   ></asp:Label></td>
					</tr>	
					<tr>
						<td width="20%">Mode of Transport – Vehicle No :</td>
						<td width="80%">
							<table width="100%" class="innertable">
								<tr>
									<td>Two wheeler</td>
									<td><asp:Label ID="lbl_Twowheeler" runat="server"></asp:Label></td>
									<td class="padclass">Four Wheeler</td>
									<td><asp:Label ID="lbl_Fourwheeler" runat="server"></asp:Label></td>
									<td class="padclass">Public Transport</td>
									<td><asp:Label ID="lbl_Publictransport" runat="server"></asp:Label></td>
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
							<td><asp:Label ID="lbl_ReferenceName1" runat="server"></asp:Label></td>
							<td><asp:Label ID="lbl_ReferenceWorkingIn1" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_ReferenceWorkingAs1" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_ReferenceContactNo1" runat="server" ></asp:Label></td>
						</tr>
						<tr>
							<td align="center">2</td>
							<td><asp:Label ID="lbl_ReferenceName2" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_ReferenceWorkingIn2" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_ReferenceWorkingAs2" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_ReferenceContactNo2" runat="server" ></asp:Label></td>
						</tr>
							
					</tbody>
				</table>
			</div>
		</div>			
	</div>
        <%-- Permanent Employee --%>
    <div id="div_EmployeeType_Permanent_PreviousExperience" class="Employee-Contract" runat="server">
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
							<td><asp:Label ID="lbl_Prevcompanyname1" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Prevdesignation1" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_PrevDOJ1" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_PrevDOR1" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Prevcontactno1" runat="server" ></asp:Label></td>
                            <td><asp:Label ID="lbl_Prevreason1" runat="server" ></asp:Label></td>
						</tr>
						<tr>
							<td align="center">2</td>
							<td><asp:Label ID="lbl_Prevcompanyname2" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Prevdesignation2" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_PrevDOJ2" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_PrevDOR2" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Prevcontactno2" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lbl_Prevreason2" runat="server" ></asp:Label></td>
						</tr>
						<tr>
							<td align="center">3</td>
							<td><asp:Label ID="lbl_Prevcompanyname3" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Prevdesignation3" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_PrevDOJ3" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_PrevDOR3" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Prevcontactno3" runat="server" ></asp:Label></td>
                            <td><asp:Label ID="lbl_Prevreason3" runat="server" ></asp:Label></td>
						</tr>
						<tr>
							<td align="center">4</td>
							<td><asp:Label ID="lbl_Prevcompanyname4" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Prevdesignation4" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_PrevDOJ4" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_PrevDOR4" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Prevcontactno4" runat="server" ></asp:Label></td>
                            <td><asp:Label ID="lbl_Prevreason4" runat="server" ></asp:Label></td>
						</tr>
						<tr>
							<td align="center">5</td>
							<td><asp:Label ID="lbl_Prevcompanyname5" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Prevdesignation5" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_PrevDOJ5" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_PrevDOR5" runat="server" ></asp:Label></td>
							<td><asp:Label ID="lbl_Prevcontactno5" runat="server" ></asp:Label></td>
                            <td><asp:Label ID="lbl_Prevreason5" runat="server" ></asp:Label></td>
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
                                    <asp:Label ID="lbl_ContractCompany1" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="lbl_ContractDesignation1" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="lbl_ContractDOJ1" runat="server" ></asp:Label>
                                    </td>
                                <td>
                                    <asp:Label ID="lbl_ContractDuration1" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="lbl_ContractContactPerson1" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="lbl_ContractContactNo1" runat="server" ></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="center">2</td>
                                <td>
                                    <asp:Label ID="txt_ContractCompany2" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractDesignation2" runat="server" ></asp:Label></td>
                                <td>
                                     <asp:Label ID="lbl_ContractDOJ2" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractDuration2" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractContactPerson2" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractContactNo2" runat="server" ></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="center">3</td>
                                <td>
                                    <asp:Label ID="txt_ContractCompany3" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractDesignation3" runat="server" ></asp:Label></td>
                                <td>
                                     <asp:Label ID="lbl_ContractDOJ3" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractDuration3" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractContactPerson3" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractContactNo3" runat="server" ></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="center">4</td>
                                <td>
                                    <asp:Label ID="txt_ContractCompany4" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractDesignation4" runat="server" ></asp:Label></td>
                                <td>
                                     <asp:Label ID="lbl_ContractDOJ4" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractDuration4" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractContactPerson4" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractContactNo4" runat="server" ></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="center">5</td>
                               <td>
                                    <asp:Label ID="txt_ContractCompany5" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractDesignation5" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="lbl_ContractDOJ5" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractDuration5" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractContactPerson5" runat="server" ></asp:Label></td>
                                <td>
                                    <asp:Label ID="txt_ContractContactNo5" runat="server" ></asp:Label></td>
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
						<td width="70%"><asp:Label ID="lbl_datesigned" runat="server" ></asp:Label></td>
					</tr>
					<tr>
						<td width="30%">Place:</td>
						<td width="70%"><asp:Label ID="lbl_placesigned" runat="server" ></asp:Label></td>
					</tr>
					<tr>
						<td colspan="2" align="right">
							<p> </p>
							<p> <asp:Image ID="img_Employeesignature" runat="server" class="img-responsive" /></p>
						</td>
					</tr>
				</table>
			</div>
		</div>			
	</div>
         <div class="row">
        <div class="col-md-12">
     <asp:Button ID="Button2" class="btn pull-right" runat="server" Text="Print"  OnClick="Print_Form" />
        </div>
        </div>
        </div>
 <script type="text/javascript">
     function GetHiddenValues() {
         var v = document.getElementById('<%= hidden_Empphotos.ClientID %>').value;
                }
            </script>