﻿
/*
 * 
 * 创建人：李林峰
 * 
 * 时  间：2009-05-04
 * 
 * 描  述：弹出对话框类
 *  
 */

using System;
using System.Text;

namespace Web
{
    public class MessageBox
    {
        private MessageBox()
        {
        }

        /// <summary>
        /// 显示消息提示对话框
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        public static void Show(System.Web.UI.Page page, string msg)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "", "<script language='javascript' defer>alert('" + msg.ToString() + "');</script>");
        }

        /// <summary>
        /// 控件点击 消息确认提示框
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        public static void ShowConfirm(System.Web.UI.WebControls.WebControl Control, string msg)
        {
            //Control.Attributes.Add("onClick","if (!window.confirm('"+msg+"')){return false;}");
            Control.Attributes.Add("onclick", "return confirm('" + msg + "');");
        }
        /// <summary>
        /// 显示消息提示对话框，并回到前一页面
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        public static void ShowGoHistory(System.Web.UI.Page page, string msg)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script language='javascript' defer>alert('" + msg.ToString() + "');window.history.go(-1);</script>");
        }

        /// <summary>
        /// 显示消息提示对话框，并进行页面跳转
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        /// <param name="url">跳转的目标URL</param>
        public static void ShowAndRedirect(System.Web.UI.Page page, string msg, string url)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.Append("<script language='javascript' defer>");
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.AppendFormat("location.href='{0}'", url);
            Builder.Append("</script>");
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", Builder.ToString());
        }

        /// <summary>
        /// 打开新窗口
        /// </summary>
        /// <param name="page"></param>
        /// <param name="url"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public static void OpenNewWindow(System.Web.UI.Page page, string url, string w, string h)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.Append("<script language='javascript' defer>");
            Builder.AppendFormat("form = window.open('" + url + "','','toolbar=no,menubar=no,titlebar=no,directories=no,resizable=no,status=no,fullscreen=no,center=yes,width=" + w + ",height=" + h + "');window.opener=null;");
            //form.resizeTo(screen.availWidth,screen.availHeight);
            Builder.Append("</script>");
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", Builder.ToString());
        }

        /// <summary>
        /// 输出自定义脚本信息
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="script">输出脚本</param>
        public static void ResponseScript(System.Web.UI.Page page, string script)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script language='javascript' defer>" + script + "</script>");
        }
    }
}
