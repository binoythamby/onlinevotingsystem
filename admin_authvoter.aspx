<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_authvoter.aspx.cs" Inherits="admin_authvoter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h4>Authenticate Voter</h4>
<br />
<br />
<div>
  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        EnableModelValidation="True" Width="100%" 
        onrowupdating="GridView1_RowUpdating" DataKeyNames="userid">
        <Columns>
            <asp:TemplateField HeaderText="#" ItemStyle-HorizontalAlign="Center">
            <ItemTemplate>
            
            <%#Container.DataItemIndex+1 %>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Voter Name" ItemStyle-HorizontalAlign="Center">
            <ItemTemplate>
          <a href="admin_voterpro.aspx?uid=<%#Eval("userid") %>" style="color:#3F2F22;"><%#Eval("fname")+" "+Eval("lname") %></a>
            </ItemTemplate>
            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Status" ItemStyle-HorizontalAlign="Center">
            <ItemTemplate>
            
            <%#Eval("status") %>
            </ItemTemplate>
            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center">
            <ItemTemplate>
            
             <asp:LinkButton ID="LinkButton1" runat="server" CommandName="update"  ForeColor="#3F2F22">Authenticate</asp:LinkButton>
            </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>








</div>


</asp:Content>

