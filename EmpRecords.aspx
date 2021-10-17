<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EmpRecords.aspx.cs" Inherits="CodingTest1.EmpRecords" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel-body">
        <br />
            <div class="row">
                <div class="col-md-6 col-md-offset-1">
                    <asp:TextBox  ID="getEmpID" Placeholder="Enter Employee ID" runat="server" Width="200px" /> <p> &emsp; </p>
                    <asp:Button  Text="Search Employee" ID="btnSearch" CssClass="btn btn-primary" runat="server" OnClick="BtnSearch_Click" />
                </div>
            </div>
        <br />
        <div class="row">
            <div class="col-md-6 col-md-offset-1">
                <asp:GridView ID="myDataGrid" runat="server" CssClass="table table-striped" AutoGenerateColumns="false" >   
                    <Columns>
                        <asp:BoundField DataField="EmployeeID" HeaderText="Employee ID"/>
                        <asp:BoundField DataField="EmployeeName" HeaderText="Name"/>
                        <asp:BoundField DataField="Designation" HeaderText="Designation"/>
                        <asp:BoundField DataField="Department" HeaderText="Department"/>
                        <asp:BoundField DataField="Salary" HeaderText="Salary"/>
                        
                    </Columns>
                </asp:GridView>
            </div> 
         </div>
    </div>
    

</asp:Content>
