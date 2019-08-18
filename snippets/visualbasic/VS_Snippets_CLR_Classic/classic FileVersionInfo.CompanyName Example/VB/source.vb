﻿
Imports System.Windows.Forms
Imports System.Diagnostics

Public Class Form1
    Inherits Form
    Protected textBox1 As TextBox

    ' <Snippet1>
    Private Sub GetCompanyName()
        ' Get the file version for the notepad.
        Dim myFileVersionInfo As FileVersionInfo = _
            FileVersionInfo.GetVersionInfo(Environment.SystemDirectory + "\Notepad.exe")

        ' Print the company name.
        textBox1.Text = "The company name: " & myFileVersionInfo.CompanyName
    End Sub 'GetCompanyName
    ' </Snippet1>
End Class 'Form1 

