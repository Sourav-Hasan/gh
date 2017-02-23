<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Sourav.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
   <br />
    <asp:GridView ID="GridView_student" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="GridView_student_PageIndexChanging" OnRowCancelingEdit="GridView_student_RowCancelingEdit" OnRowDeleting="GridView_student_RowDeleting" OnRowEditing="GridView_student_RowEditing" OnRowUpdating="GridView_student_RowUpdating" PageSize="3" HorizontalAlign="Center" AllowPaging="True" BackColor="YellowGreen" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="5px" CellPadding="10">
        <Columns>
            <asp:TemplateField HeaderText="Student Id">
                
                <ItemTemplate>
                    <asp:Label ID="Label_id" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Name">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox_name" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Phone">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox_phone" runat="server" Text='<%# Bind("phone") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("phone") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Address">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox_address" runat="server" Text='<%# Bind("address") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("address") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="True" ButtonType="Button" EditText="পরিবর্তন" ControlStyle-CssClass="but"  ControlStyle-ForeColor="White" FooterStyle-BackColor="Black" ControlStyle-BackColor="#009900" />
            <asp:CommandField ShowDeleteButton="True" ButtonType="Button" DeleteText="মুছুন" ControlStyle-CssClass="but"  ControlStyle-ForeColor="White" FooterStyle-BackColor="Black" ControlStyle-BackColor="#009900" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
</asp:Content>
