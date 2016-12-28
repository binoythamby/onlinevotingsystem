<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="voting.aspx.cs" Inherits="voting" enableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Voting Panel</h3>
<br />
<div>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        EnableModelValidation="True" Width="100%" 
        onrowcommand="GridView1_RowCommand" DataKeyNames="userid" 
        onrowdatabound="GridView1_RowDataBound" 
        onrowupdating="GridView1_RowUpdating">
        <Columns>
            <asp:TemplateField HeaderText="#" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#9B1C2E" HeaderStyle-ForeColor="White">
            <ItemTemplate>
            
            <%#Container.DataItemIndex+1 %>
            </ItemTemplate>
            
<ItemStyle HorizontalAlign="Center"></ItemStyle>
            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Logo" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#9B1C2E" HeaderStyle-ForeColor="White">
            <ItemTemplate>
            
            <img src='logos/<%#logo(Eval("userid").ToString()) %>' height="100px" width="100px" />
            
            </ItemTemplate>
            
<ItemStyle HorizontalAlign="Center"></ItemStyle>
            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#9B1C2E" HeaderStyle-ForeColor="White">
            
            <ItemTemplate>
            <%#Eval("fname")+" "+Eval("lname") %>
            
            </ItemTemplate>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Vote" ItemStyle-HorizontalAlign="Center" HeaderStyle-BackColor="#9B1C2E" HeaderStyle-ForeColor="White">
            
            <ItemTemplate>
           <!--     <asp:Button ID="Button1" runat="server" Text="Vote"  Width="100px" CommandName="vote"/> -->
                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="update">Voting</asp:LinkButton>
            </ItemTemplate>
            
<ItemStyle HorizontalAlign="Center"></ItemStyle>
            
            </asp:TemplateField>
        </Columns>
    </asp:GridView>




</div>

</asp:Content>

