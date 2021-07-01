<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAdd.aspx.cs" Inherits="Crud_application.UserAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 177px;
        }
        .auto-style2 {
            width: 105px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <thead>
                    <tr>
                    <td class="auto-style2"> Name </td>
                    <td class="auto-style1"> 
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                    <td class="auto-style2"> Phone No </td>  
                        <td class="auto-style1">
                            <asp:TextBox ID="txtPhoneNo" runat="server" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32 );"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2"> Job Role </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtJobRole" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2"> Current Status </td>
                        <td class="auto-style1">
                            <asp:CheckBox ID="cbActive" runat="server"   text="Active"/>                           
                        </td>
                    </tr>
                    <tr>
                         <td class="auto-style2"> Location </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
                         </td>
                    </tr>
                     <tr>
                         <td class="auto-style2"> </td>
                        <td class="auto-style1">
                            <asp:Button ID="btnSave" runat="server" Text="Submit" OnClick="btnSave_Click" />
                         </td>
                    </tr>
                </thead>
            </table>
                <asp:GridView ID="gvDisplay" runat="server" AutoGenerateColumns="false"  
                  AllowPaging="true" PageSize="10" onrowcommand="gvDisplay_RowCommand" onrowdeleting="gvDisplay_RowDeleting"  
                  onselectedindexchanging="gvDisplay_SelectedIndexChanging"  
                  onpageindexchanging="gvDisplay_PageIndexChanging">  
                   <Columns>  
                   <asp:BoundField DataField="Id" HeaderText="Id" />  
                   <asp:BoundField DataField="Name" HeaderText="Name" />  
                   <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" />  
                   <asp:BoundField DataField="JobRole" HeaderText="JobRole" />  
                   <asp:BoundField DataField="CurrentStatus" HeaderText="Current Status" />  
                   <asp:BoundField DataField="Location" HeaderText="Location" />      
                    <asp:CommandField ButtonType="Button" SelectText="Edit" ShowSelectButton="True" />  
                            <asp:TemplateField>  
                                <ItemTemplate>  
                                    <asp:Button runat="server" ID="btnDelete" OnClientClick="return confirm('Are you sure,you want to delete this record ?');" Text="Delete" CommandArgument='  
                                        <%# Eval("Id") %>' CommandName="Delete" />  
                                    </ItemTemplate>  
                            </asp:TemplateField>  
                   </Columns>
                 </asp:GridView>  
        </div>
    </form>
</body>
</html>
