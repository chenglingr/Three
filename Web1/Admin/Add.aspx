<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Web.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
          
          <div class="form-horizontal">
                  <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="id" CssClass="col-md-2 control-label">用户名</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="id"  CssClass="form-control" />
                        </div>
                 </div>
                  <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">密码</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                        </div>
                 </div>
                <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="realname" CssClass="col-md-2 control-label">真实姓名</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="realname"  CssClass="form-control" />
                        </div>
                 </div>
                <div class="form-group">

                    <label class="radio-inline">
  
                       <asp:RadioButton ID="sexm" GroupName="sex" runat="server" Checked="false" Text="男"  CssClass="form-control"/>
                         
                    </label>
                    <label class="radio-inline">
                        <asp:RadioButton ID="sexf" GroupName="sex" runat="server"  Text="女"  CssClass="form-control" />
    
                    </label>
      
                </div>
               <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" id="submit" Text="增加" CssClass="btn btn-default" OnClick="submit_Click" />
                            
                        </div>
               </div>

          </div>
    

   

</asp:Content>
