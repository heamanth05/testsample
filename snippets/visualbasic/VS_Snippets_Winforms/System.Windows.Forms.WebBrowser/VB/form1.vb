﻿'<Snippet0>
Imports System
Imports System.Windows.Forms
Imports System.Security.Permissions

<PermissionSet(SecurityAction.Demand, Name:="FullTrust")> _
Public Class Form1
    Inherits Form

    Public Sub New()

        ' Create the form layout. If you are using Visual Studio, 
        ' you can replace this code with code generated by the designer. 
        InitializeForm()

        ' Load the user's home page.
        webBrowser1.GoHome()

    End Sub


    '<Snippet1>
    ' Displays the Save dialog box.
    Private Sub saveAsToolStripMenuItem_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles saveAsToolStripMenuItem.Click

        webBrowser1.ShowSaveAsDialog()

    End Sub
    '</Snippet1>

    '<Snippet2>
    ' Displays the Page Setup dialog box.
    Private Sub pageSetupToolStripMenuItem_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles pageSetupToolStripMenuItem.Click

        webBrowser1.ShowPageSetupDialog()

    End Sub
    '</Snippet2>

    '<Snippet3>
    ' Displays the Print dialog box.
    Private Sub printToolStripMenuItem_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles printToolStripMenuItem.Click

        webBrowser1.ShowPrintDialog()

    End Sub
    '</Snippet3>

    '<Snippet4>
    ' Displays the Print Preview dialog box.
    Private Sub printPreviewToolStripMenuItem_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles printPreviewToolStripMenuItem.Click

        webBrowser1.ShowPrintPreviewDialog()

    End Sub
    '</Snippet4>

    '<Snippet5>
    ' Displays the Properties dialog box.
    Private Sub propertiesToolStripMenuItem_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles propertiesToolStripMenuItem.Click

        webBrowser1.ShowPropertiesDialog()

    End Sub
    '</Snippet5>

    ' Selects all the text in the text box when the user clicks it. 
    Private Sub toolStripTextBox1_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles toolStripTextBox1.Click

        toolStripTextBox1.SelectAll()

    End Sub
    '<Snippet6>

    ' Navigates to the URL in the address box when 
    ' the ENTER key is pressed while the ToolStripTextBox has focus.
    Private Sub toolStripTextBox1_KeyDown( _
        ByVal sender As Object, ByVal e As KeyEventArgs) _
        Handles toolStripTextBox1.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            Navigate(toolStripTextBox1.Text)
        End If

    End Sub

    ' Navigates to the URL in the address box when 
    ' the Go button is clicked.
    Private Sub goButton_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles goButton.Click

        Navigate(toolStripTextBox1.Text)

    End Sub

    ' Navigates to the given URL if it is valid.
    Private Sub Navigate(ByVal address As String)

        If String.IsNullOrEmpty(address) Then Return
        If address.Equals("about:blank") Then Return
        If Not address.StartsWith("http://") And _
            Not address.StartsWith("https://") Then
            address = "http://" & address
        End If

        Try
            webBrowser1.Navigate(New Uri(address))
        Catch ex As System.UriFormatException
            Return
        End Try

    End Sub

    ' Updates the URL in TextBoxAddress upon navigation.
    Private Sub webBrowser1_Navigated(ByVal sender As Object, _
        ByVal e As WebBrowserNavigatedEventArgs) _
        Handles webBrowser1.Navigated

        toolStripTextBox1.Text = webBrowser1.Url.ToString()

    End Sub
    '</Snippet6>

    '<Snippet7>
    ' Navigates webBrowser1 to the previous page in the history.
    Private Sub backButton_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles backButton.Click

        webBrowser1.GoBack()

    End Sub

    ' Disables the Back button at the beginning of the navigation history.
    Private Sub webBrowser1_CanGoBackChanged( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles webBrowser1.CanGoBackChanged

        backButton.Enabled = webBrowser1.CanGoBack

    End Sub
    '</Snippet7>

    '<Snippet8>
    ' Navigates webBrowser1 to the next page in history.
    Private Sub forwardButton_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles forwardButton.Click

        webBrowser1.GoForward()

    End Sub

    ' Disables the Forward button at the end of navigation history.
    Private Sub webBrowser1_CanGoForwardChanged( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles webBrowser1.CanGoForwardChanged

        forwardButton.Enabled = webBrowser1.CanGoForward

    End Sub
    '</Snippet8>

    '<Snippet9>
    ' Halts the current navigation and any sounds or animations on 
    ' the page.
    Private Sub stopButton_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles stopButton.Click

        webBrowser1.Stop()

    End Sub
    '</Snippet9>

    '<Snippet10>
    ' Reloads the current page.
    Private Sub refreshButton_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles refreshButton.Click

        ' Skip refresh if about:blank is loaded to avoid removing
        ' content specified by the DocumentText property.
        If Not webBrowser1.Url.Equals("about:blank") Then
            webBrowser1.Refresh()
        End If

    End Sub
    '</Snippet10>

    '<Snippet11>
    ' Navigates webBrowser1 to the home page of the current user.
    Private Sub homeButton_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles homeButton.Click

        webBrowser1.GoHome()

    End Sub
    '</Snippet11>

    '<Snippet12>
    ' Navigates webBrowser1 to the search page of the current user.
    Private Sub searchButton_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles searchButton.Click

        webBrowser1.GoSearch()

    End Sub
    '</Snippet12>

    '<Snippet13>
    ' Prints the current document Imports the current print settings.
    Private Sub printButton_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles printButton.Click

        webBrowser1.Print()

    End Sub
    '</Snippet13>

    '<Snippet14>
    ' Updates the status bar with the current browser status text.
    Private Sub webBrowser1_StatusTextChanged( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles webBrowser1.StatusTextChanged

        toolStripStatusLabel1.Text = webBrowser1.StatusText

    End Sub
    '</Snippet14>

    '<Snippet15>
    ' Updates the title bar with the current document title.
    Private Sub webBrowser1_DocumentTitleChanged( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles webBrowser1.DocumentTitleChanged

        Me.Text = webBrowser1.DocumentTitle

    End Sub
    '</Snippet15>

    ' Exits the application.
    Private Sub exitToolStripMenuItem_Click( _
        ByVal sender As Object, ByVal e As EventArgs) _
        Handles exitToolStripMenuItem.Click

        Application.Exit()

    End Sub

    ' The remaining code in this file provides basic form initialization and 
    ' includes a Main method. If you use the Visual Studio designer to create
    ' your form, you can use the designer generated code instead of this code, 
    ' but be sure to use the names shown in the variable declarations here. 

    Private WithEvents webBrowser1 As WebBrowser

    Private menuStrip1 As MenuStrip
    Private WithEvents fileToolStripMenuItem, saveAsToolStripMenuItem, _
        printToolStripMenuItem, printPreviewToolStripMenuItem, _
        exitToolStripMenuItem, pageSetupToolStripMenuItem, _
        propertiesToolStripMenuItem As ToolStripMenuItem
    Private toolStripSeparator1, toolStripSeparator2 As ToolStripSeparator

    Private toolStrip1, toolStrip2 As ToolStrip
    Private WithEvents toolStripTextBox1 As ToolStripTextBox
    Private WithEvents goButton, backButton, forwardButton, _
        stopButton, refreshButton, homeButton, _
        searchButton, printButton As ToolStripButton

    Private statusStrip1 As StatusStrip
    Private toolStripStatusLabel1 As ToolStripStatusLabel

    Private Sub InitializeForm()

        webBrowser1 = New WebBrowser()

        menuStrip1 = New MenuStrip()
        fileToolStripMenuItem = New ToolStripMenuItem()
        saveAsToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator1 = New ToolStripSeparator()
        printToolStripMenuItem = New ToolStripMenuItem()
        printPreviewToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator2 = New ToolStripSeparator()
        exitToolStripMenuItem = New ToolStripMenuItem()
        pageSetupToolStripMenuItem = New ToolStripMenuItem()
        propertiesToolStripMenuItem = New ToolStripMenuItem()

        toolStrip1 = New ToolStrip()
        goButton = New ToolStripButton()
        backButton = New ToolStripButton()
        forwardButton = New ToolStripButton()
        stopButton = New ToolStripButton()
        refreshButton = New ToolStripButton()
        homeButton = New ToolStripButton()
        searchButton = New ToolStripButton()
        printButton = New ToolStripButton()

        toolStrip2 = New ToolStrip()
        toolStripTextBox1 = New ToolStripTextBox()

        statusStrip1 = New StatusStrip()
        toolStripStatusLabel1 = New ToolStripStatusLabel()

        webBrowser1.Dock = DockStyle.Fill

        menuStrip1.Items.Add(fileToolStripMenuItem)

        fileToolStripMenuItem.DropDownItems.AddRange( _
            New ToolStripItem() { _
                saveAsToolStripMenuItem, toolStripSeparator1, _
                pageSetupToolStripMenuItem, printToolStripMenuItem, _
                printPreviewToolStripMenuItem, toolStripSeparator2, _
                propertiesToolStripMenuItem, exitToolStripMenuItem _
            })

        fileToolStripMenuItem.Text = "&File"
        saveAsToolStripMenuItem.Text = "Save &As..."
        pageSetupToolStripMenuItem.Text = "Page Set&up..."
        printToolStripMenuItem.Text = "&Print..."
        printPreviewToolStripMenuItem.Text = "Print Pre&view..."
        propertiesToolStripMenuItem.Text = "Properties"
        exitToolStripMenuItem.Text = "E&xit"

        '<snippet100>
        printToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.P
        '</snippet100>

        toolStrip1.Items.AddRange(New ToolStripItem() { _
            goButton, backButton, forwardButton, stopButton, _
            refreshButton, homeButton, searchButton, printButton})

        goButton.Text = "Go"
        backButton.Text = "Back"
        forwardButton.Text = "Forward"
        stopButton.Text = "Stop"
        refreshButton.Text = "Refresh"
        homeButton.Text = "Home"
        searchButton.Text = "Search"
        printButton.Text = "Print"

        backButton.Enabled = False
        forwardButton.Enabled = False

        toolStrip2.Items.Add(toolStripTextBox1)
        toolStripTextBox1.Size = New System.Drawing.Size(250, 25)

        statusStrip1.Items.Add(toolStripStatusLabel1)

        Controls.AddRange(New Control() { _
            webBrowser1, toolStrip2, toolStrip1, _
            menuStrip1, statusStrip1, menuStrip1})
    End Sub

    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub

End Class
'</Snippet0>