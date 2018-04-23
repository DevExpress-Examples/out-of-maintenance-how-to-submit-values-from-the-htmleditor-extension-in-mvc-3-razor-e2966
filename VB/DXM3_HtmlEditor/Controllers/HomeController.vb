Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc

Namespace DXM3_HtmlEditor.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function HtmlEditorPartial() As ActionResult
			Return PartialView()
		End Function

		<HttpPost> _
		Public Function SubmitHtml() As ActionResult
			ViewBag.PostedHtml = HtmlEditorExtension.GetHtml("htmlEditor")

			Return View("Index")
		End Function
	End Class
End Namespace
