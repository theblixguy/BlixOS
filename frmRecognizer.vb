Option Strict On

Imports Microsoft.Ink

Public Class Form1

    Private inkOverlay As InkOverlay

    Friend activeRecognizer As Recognizer

    Sub New()
        InitializeComponent()

        inkOverlay = New InkOverlay(Panel1)
        inkOverlay.Enabled = True

        Dim recognizers As New Recognizers()

        Dim defaultReco As Recognizer = recognizers.GetDefaultRecognizer()
        activeRecognizer = defaultReco
        AddRecognizerToMenu(defaultReco, True)
        Dim defaultRecoId As String = defaultReco.Vendor + defaultReco.Name

       
        Dim recognizer As Recognizer
        For Each recognizer In recognizers
            Dim recognizerId As String = recognizer.Vendor + recognizer.Name
           
            If recognizerId <> defaultRecoId Then
                AddRecognizerToMenu(recognizer, False)
            End If
        Next
    End Sub

    Private Sub AddRecognizerToMenu(ByVal recognizer As Recognizer, ByVal selected As Boolean)
       
        Dim recognizerSelector As ToolStripMenuItem = New ToolStripMenuItem(recognizer.Name)

        
        recognizerSelector.CheckOnClick = True
        recognizerSelector.Checked = selected

        
        Dim selectRecognizer As New Recognizerselector(Me, recognizerSelector, recognizer)
        AddHandler recognizerSelector.Click, AddressOf selectRecognizer.SelectRecognizer

        
        RecognizersToolStripMenuItem.DropDownItems.Add(recognizerSelector)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private NotInheritable Class RecognizerSelector
       
        Public Sub New(ByVal form1 As Form1, ByVal recognizerSelector As ToolStripMenuItem, ByVal recognizer As Recognizer)
            Me.form1 = form1
            Me.recognizer = recognizer
            Me.recognizerSelector = recognizerSelector
        End Sub

        Public Sub SelectRecognizer(ByVal sender As Object, ByVal e As EventArgs)
            form1.activeRecognizer = Me.recognizer
            Dim item1 As ToolStripMenuItem
            For Each item1 In form1.RecognizersToolStripMenuItem.DropDownItems
                item1.Checked = False
            Next
            Me.recognizerSelector.Checked = True
        End Sub

      
        Public form1 As Form1
        Public recognizer As Recognizer
        Public recognizerSelector As ToolStripMenuItem
    End Class

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        
        ListBox1.Items.Clear()
        inkOverlay.Ink.DeleteStrokes()

        
        Panel1.Invalidate()
    End Sub

    Private Sub RecognizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecognizeToolStripMenuItem.Click
        
        ListBox1.Items.Clear()

       
        Dim context As RecognizerContext = activeRecognizer.CreateRecognizerContext()

        
        context.Strokes = inkOverlay.Ink.Strokes

        context.EndInkInput()

       
        If context.Strokes Is Nothing Or context.Strokes.Count = 0 Then
            Return
        End If

       
        Dim status As RecognitionStatus
        Dim result As RecognitionResult = context.Recognize(status)

       
        If status = RecognitionStatus.NoError Then
           
            Dim topString As String = result.TopString
            ListBox1.Items.Add(topString)

           
            Dim alternate As RecognitionAlternate
            For Each alternate In result.GetAlternatesFromSelection()
                Dim alternateString As String = alternate.ToString()
                ListBox1.Items.Add(alternateString)
            Next
        End If

       
        ListBox1.Enabled = True
    End Sub
End Class




