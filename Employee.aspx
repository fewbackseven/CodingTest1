<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="CodingTest1.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <section id="main-content">
        <section id="wrapper">
            
                <div class="panel-body">
                    
                    <div class="row">
                        <div class="col-md-4 col-md-offset-1">
                            <div class="form-group">                                
                                <asp:Label Text="Employee ID" runat="server" />
                                <asp:TextBox ID="txtEmpID" runat="server"  CssClass="form-control input-sm" Placeholder="Enter Employee ID"/>  
                            </div>
                        </div>
                        <div class="col-md-4 col-md-offset-1">
                            <div class="form-group">
                                <asp:Label Text="Employee Name" runat="server" />
                                <asp:TextBox ID="txtEmpName" runat="server" Enabled="true" CssClass="form-control input-sm" Placeholder="Enter Employee Name"/>  
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-4 col-md-offset-1">
                            <div class="form-group">
                                <asp:Label Text="Designation" runat="server" />
                                <asp:TextBox ID="txtDesignation" Enabled="true" CssClass="form-control input-sm" Placeholder="Enter Designation" runat="server" />
                            </div>                        
                        </div>
                        <div class="col-md-4 col-md-offset-1">
                            <div class="form-group">
                                <asp:Label Text="Department" runat="server" />
                                <asp:TextBox ID="txtDepartment" CssClass="form-control input-sm" Enabled="true" Placeholder="Enter Department" runat="server" />
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-4 col-md-offset-1">
                            <div class="form-group">
                                <asp:Label Text="Salary" runat="server" />
                                <asp:TextBox  ID="txtSalary" Enabled="true" CssClass="form-control input-sm" Placeholder="Enter Salary" runat="server" />
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-4 col-md-offset-1">
                            <div class="form-group"><br>
                                        <asp:Label ID="statusLbl" Text="" runat="server"/>
                                        <asp:Button Text="Save" ID="BtnSave" CssClass="btn btn-primary" Width="120px" runat="server" OnClick="BtnSave_Click"/> &nbsp;&nbsp;
                                        <asp:Button Text="View Records" ID="Button2" CssClass="btn btn-primary" Width="120px" runat="server" PostBackUrl="~/EmpRecords.aspx"/>
                            </div>                            
                        </div>
                        
                        
                    </div>
                </div>
            
        </section>
    </section>

</asp:Content>
