<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_candlist.aspx.cs" Inherits="admin_candlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h4>Candidates Lists</h4>
<br />
<br />
<div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        EnableModelValidation="True" Width="100%">
        <Columns>
            <asp:TemplateField HeaderText="#" ItemStyle-HorizontalAlign="Center">
            <ItemTemplate>
            <%#Container.DataItemIndex+1 %>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Signature" ItemStyle-HorizontalAlign="Center">
            
            <ItemTemplate>
            <img src='<%# "conimage/"+logo(Eval("userid").ToString()) %>' height="100" width="100" />
            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name" ItemStyle-HorizontalAlign="Center">
            
            <ItemTemplate>
       <a href="admin_canpro.aspx?uid=<%#Eval("userid") %>" style="color:#4A3E33;"><%#Eval("fname")+" "+Eval("lname") %></a>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="City" ItemStyle-HorizontalAlign="Center">
            <ItemTemplate>
            
            <%#Eval("city") %>
            </ItemTemplate>
            
            </asp:TemplateField>
        </Columns>
    </asp:GridView>





</div>


</asp:Content>

