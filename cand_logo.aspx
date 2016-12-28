<%@ Page Title="" Language="C#" MasterPageFile="~/candidate.master" AutoEventWireup="true" CodeFile="cand_logo.aspx.cs" Inherits="cand_logo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h3>Voting Sign</h3>
<br />
<br />
<div>
  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="image" onrowupdating="GridView1_RowUpdating" 
        Width="100%" BackColor="White" BorderColor="#CC9966" BorderStyle="None" 
        BorderWidth="1px" CellPadding="4" EnableModelValidation="True" 
        ForeColor="White" >
                    <Columns>
                    <asp:TemplateField HeaderText="#">
                    <ItemTemplate>
                    
                    <%#Container.DataItemIndex+1 %>
                    </ItemTemplate>
                    
                    </asp:TemplateField>
                        <asp:TemplateField HeaderText="Signatures" ItemStyle-HorizontalAlign="Center" HeaderStyle-ForeColor="White">
                            <ItemTemplate>
                                <img src='<%# "logos/"+Eval("image") %>' height="100" width="100" />
                            </ItemTemplate>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Select" ItemStyle-HorizontalAlign="Center" HeaderStyle-ForeColor="White">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="update">Select</asp:LinkButton>
                            </ItemTemplate>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                </asp:GridView>



</div>


</asp:Content>

