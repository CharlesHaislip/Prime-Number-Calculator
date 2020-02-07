'Practice... Mode...
Option Strict On : Option Explicit On
Module GlobalVars
    'Used to start the array and initialize neccessary vals
    'Sets Default Refresh Setting
    Public BolRefresh As Boolean = False
    'Indicates if the listbox should list all of the results of the program or only add the most recent findings to the 
    'list.
    Public BolToList As Boolean = True
    'Sets Array
    Public arrayPR%(1)
    'Current Investigative VAlue
    Public intCN% = 3
    'Current Array pos
    Public intCA% = 1
    Public TS As Boolean = False
    'Set High/Low Value for list vals
    Public High% : Public Low%
    'Ensure that the other forms are halted or not
    Public RangeHalt As Boolean = False
    Public Saved As Boolean = True 'Default pos. This is to remove anoyance of launching in accident and then
    'closing
    'Create Version Array
    Public Version$(1, 1)
    'Size of the tolRefresh control text. Set later.
    Public intRefresh%
    Public ErrTitle$ = "A problem as occurred"
    Public NThreads% = 1
End Module

Public Class PrimeN
    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'If the Saved flag is false
        If Not Saved Then
            'Ask user if they still want to quit
            Dim Response As DialogResult = MessageBox.Show(
                "It appears that you have not saved the prime numbers. Do you wish to still exit?",
                            "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If no then
            If Response = DialogResult.No Then
                'Cancel quit
                e.Cancel = True
            End If
        End If
    End Sub
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Sets up array vals when form loads
        arrayPR(0) = 2
        'arrayPR(1) = 3 'This was cheating. Disabled
        'Build Version Array
        ReDim Version(5, 1)
        Version(0, 0) = "1.0" : Version(0, 1) = "3/15/2018"
        Version(1, 0) = "1.0.5" : Version(1, 1) = "3/29/2018"
        Version(2, 0) = "1.1" : Version(2, 1) = "5/1/2018"
        Version(3, 0) = "1.2" : Version(3, 1) = "5/17/2018"
        Version(4, 0) = "1.3" : Version(4, 1) = "6/9/2018"
        Version(5, 0) = "1.4" : Version(5, 1) = "10/4/2018"

        'Output most recent version and completion date.
        lstDisp.Items.Add("Version number: " & Version(UBound(Version), 0))
        lstDisp.Items.Add("Completion Date: " & Version(UBound(Version), 1))
        BolToList = True

    End Sub
    Public Sub Prob(ByVal N%)
        'Displays error message. Designed to make it easier to call errors.
        Dim msg$
        Select Case N
            Case 1
                'Wrong data type error
                msg = "Error 1: please enter an integer value."
            Case 2
                '0 or neggative integer error
                msg = "Error 2: please enter a positive integer greater than zero."
            Case 3
                'I have no idea what to do if this shows up. generic error.
                msg = "Error 3: What ever you did, do not do that."
            Case 4
                'error 4: notify user to use diffrent control
                msg = "This value has already been found. Please use the 'Fetch Prime' button instead."
            Case 5
                'File dose not exist error
                msg = "Error 404(5): File does not exist"
            Case Else
                'Should never appear. If it does... i have no idea. Get help? Burn computer and/or storage? 
                'Switch to Switch?
                msg = "Programmer pulled a stoopie. Blame Him!"
        End Select
        'Begin display
        lstDisp.Items.Clear()
        lstDisp.Items.Add(msg)
        MessageBox.Show(msg, "A problem as occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        BolToList = True
    End Sub
    Public Sub Reset()
        If Not Saved Then
            Dim drInput As DialogResult = MessageBox.Show("You have not saved your work. Are you sure you want to reset?",
                                                          "Attention",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Exclamation)
            If drInput = DialogResult.No Then
                Exit Sub
            End If
        End If
        'Resets program without relaunching. Basicly just resets arrays and variables to default values.
        ReDim arrayPR(1)
        arrayPR(0) = 2
        'arrayPR(1) = 3 'This was technically cheating, so I left only the two.
        lstDisp.Items.Clear()
        intCN = 3
        intCA = 1
        'Clears textboxes
        txtNP.Text = ""
        txtGetArray.Text = ""
        lblTimeS.Text = "0 Seconds"
        'Reset lbls.
        lblLrgID.Text = "ID: 0"
        lblLrgN.Text = "Number: 2"
        'Resets Progress Bar
        progMain.Value = 0
        'Reset List
        BolToList = True
        'Reset Save
        Saved = True
        'Display reset is complete
        lstDisp.Items.Add("Program reset.")
    End Sub
    Public Sub Save()
        Dim FileP$ = Application.StartupPath & "\prime.txt"
        Dim arrayStrPR$(intCA - 1)
        For I = 0 To intCA - 1
            arrayStrPR(I) = CStr(arrayPR(I))
            'Progress Bar
            Dim intProg% = CInt((I / arrayPR.Length) * 100) : progMain.Value = intProg
            If intProg > 0 Then
                progMain.Value = intProg - 1 : progMain.Value = intProg
            End If
        Next
        'Saving...
        IO.File.WriteAllLines(FileP, arrayStrPR)
        'Output completion
        lstDisp.Items.Clear() : lstDisp.Items.Add("Save Complete")
        lstDisp.Items.Add("Saved " & arrayPR.Length - 1 & " numbers.")
        'Mark Save as complete:Mark ToList As true
        Saved = True : BolToList = True
    End Sub
    Public Sub SubPrime(ByVal N%)
        'Sort of like a function.
        'Say Calculations have begun
        radCalculating.Checked = True : radCalculating.Enabled = True
        radCalculating.Refresh()
        'Get Start Time
        Dim datStart As DateTime = Now
        'Initialization Values
        Dim intProg% : progMain.Value = 0 : Dim B As Boolean = False
        'Start Loop for N Times
        For LP = 1 To N
            'Find maximum value that can be used. (So that if two primes are next to eachother, one does not eval the 
            'other. This is designed to streamline the code.)
Start:      Dim dblMax# = Math.Sqrt(intCN)
            'Makes sure that MAX is not div by 3 after array val 2.
            If dblMax = Int(dblMax) And intCA > 2 Then B = True : GoTo NXT
            'Starts loop to find if number is prime
            For i = 0 To (intCA - 1)
                'Use my MOD method instead of my two variable int method
                Dim T# = intCN Mod arrayPR(i)
                'IF the two are equal then not prime
                If T = 0 Then B = True : Exit For
                'Limits the calculations performed
                If arrayPR(i) >= dblMax Then Exit For
            Next
            'Checks if it is not prime

NXT:        If B = True Then
                'Skip to next number, reset Bool
                intCN += 2 : B = False
                GoTo Start 'Loop Back
            Else
                'Resize array WITHOUT earasing data
                ReDim Preserve arrayPR(intCA)
                'Current array val = current investigative val:Change current investigative val and current array
                arrayPR(intCA) = intCN : intCA += 1 : intCN += 2
            End If
            'Progress Bar
            intProg = CInt((LP / N) * 100)
            progMain.Value = intProg
            If intProg > 0 Then
                progMain.Value = intProg - 1 : progMain.Value = intProg
            End If
        Next
        'Get Time
        Dim datStop As DateTime = Now, datDif As TimeSpan = datStop.Subtract(datStart)
        'Output data
        'Say calcualtions have stoped
        radCalculating.Checked = False : radCalculating.Enabled = False
        radCalculating.Refresh()
        'Set Time
        lblTimeS.Text = datDif.TotalSeconds.ToString("0.000") & " Seconds"
        lblTimeMS.Text = datDif.TotalMilliseconds.ToString("000") & " Milliseconds"
        lblTimeMin.Text = datDif.TotalMinutes.ToString("0.0") & " Minutes"
        If BolToList = True Then
            lstDisp.Items.Clear()
            lstDisp.Items.Add("# of Prime #'s: " & UBound(arrayPR) + 1)
            For i = 0 To intCA - 1 : lstDisp.Items.Add(arrayPR(i)) : Next
            'Set BolToList to False
            BolToList = False
        Else
            'Set lsdDisp val 0 to the number of primes
            lstDisp.Items.Item(0) = "# of Prime #'s: " & UBound(arrayPR) + 1
            'lst the last N Primes
            For i = intCA - N To intCA - 1 : lstDisp.Items.Add(arrayPR(i)) : Next
        End If
        'Mark save as no longer uptodate, ask if you wish to save when you exit.
        Saved = False
        'Update Largest prime
        lblLrgID.Text = "ID: " & UBound(arrayPR) : lblLrgN.Text = "Number: " & arrayPR(UBound(arrayPR))
        'End program
        Return
        'Error Handler: Generic
Err:    Prob(3)
    End Sub
    Public Sub SubPrimeThreaded(ByVal N%, NThreads%)

    End Sub
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1P.Click
        'Finds only one prime number
        Dim N As Integer = 1
        SubPrime(N)
    End Sub
    Private Sub btnNP_Click(sender As Object, e As EventArgs) Handles btnNP.Click
        Dim N%
        If Not Integer.TryParse(txtNP.Text, N) Then
            Prob(1)
            Return
        ElseIf N <= 0 Then
            Prob(2)
            Return
        End If
        If cbFindPrime.Text = "Find 'X' Primes" Then
            SubPrime(N)
        Else
            If N > intCA Then
                Dim Temp% = N - intCA
                SubPrime(Temp)
            Else
                MessageBox.Show("This value has already been found. Please use the 'Fetch Prime' button instead.", ErrTitle, MessageBoxButtons.OK)
            End If
        End If
    End Sub
    Private Overloads Sub TxtNPKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtNP.KeyDown
        On Error GoTo Err
        Dim T%
        If e.KeyCode = Keys.Return Then
            Dim N%
            If Not Integer.TryParse(txtNP.Text, N) Then
                Prob(1)
                Return
            ElseIf N <= 0 Then
                Prob(2)
                Return
            End If
            If cbFindPrime.Text = "Find 'X' Primes" Then
                SubPrime(N)
            Else
                If N > intCA Then
                    Dim Temp% = N - intCA
                    SubPrime(Temp)
                Else
                    MessageBox.Show("This value has already been found. Please use the 'Fetch Prime' button instead.", ErrTitle, MessageBoxButtons.OK)
                End If
            End If
        End If
        Return
Err:    Prob(3)
    End Sub
    Private Overloads Sub TxtArrayKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtGetArray.KeyDown
        If e.KeyCode = Keys.Return Then
            On Error GoTo Err
            Dim GA%
            If Not Integer.TryParse(txtGetArray.Text, GA) Then
                Prob(1)
                Return
            ElseIf GA <= 0 Then
                Prob(2)
                Return
            Else
                GA -= 1
            End If
            lstDisp.Items.Clear()
            If intCA - 1 >= GA Then
                lstDisp.Items.Add(arrayPR(GA))
            Else
                lstDisp.Items.Add("Error: I have not found that value yet.")
            End If
            Return
Err:        Prob(3)
        End If
    End Sub
    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        'Just gives credit to me. No, really, that is all it does. Except that it does remove textbox data
        'and what not. All the data in the array is still there, just not vissible. Oh, and it lists the
        'version and the date of creation.
        txtNP.Text = ""
        txtGetArray.Text = ""
        lstDisp.Items.Clear()
        lstDisp.Items.Add("Created by: Charles H")
        lstDisp.Items.Add("First verion: " & Version(0, 1))
        BolToList = True
        'Add Version History
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub
    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Reset()
    End Sub
    Private Sub SaveArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveArrayToolStripMenuItem.Click
        'Save Array
        Save()
    End Sub
    Public Sub LoadArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadArrayToolStripMenuItem.Click
        'Sets Display
        lstDisp.Items.Clear()
        'Loads Array
        'Checks if file exists
        If Not IO.File.Exists("prime.txt") Then
            'Error display: Exit
            Prob(5)
            Return
        End If
        'Loading...
        Dim arrayStrPR$() = IO.File.ReadAllLines("prime.txt")
        intCA = arrayStrPR.Length
        ReDim arrayPR(intCA)
        'Convert Data from string to integer
        For I = 0 To intCA - 1
            arrayPR(I) = CInt(arrayStrPR(I))

            'Progress bar
            Dim intProg% = CInt((I / arrayPR.Length) * 100)
            progMain.Value = intProg
            If intProg > 0 Then
                'Hack to near instantly display the current value. 
                progMain.Value = intProg - 1
                progMain.Value = intProg
            End If
        Next
        'Sets investigative value
        intCN = arrayPR(intCA - 1) + 2
        'Fail safe if the save file Is at the default value.
        If arrayPR.Length = 2 Then
            'Subtracts one from value
            intCN -= 1
        End If
        'Outputs that process Is complete
        lstDisp.Items.Add("Load Complete")
        lstDisp.Items.Add("Loaded " & arrayPR.Length - 1 & " numbers.")
    End Sub
    Private Sub DeleteArrayFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteArrayFileToolStripMenuItem.Click
        Dim FileP$ = Application.StartupPath & "\prime.txt"
        If Not IO.File.Exists(FileP) Then
            Prob(5)
            Return
        End If
        Dim input As DialogResult =
            MessageBox.Show("Are you sure you wish to delete your data? The data will NOT be recoverable.",
                        "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If input = DialogResult.Yes Then
            IO.File.Delete(Application.StartupPath & "\prime.txt")
            MessageBox.Show("Delete complete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Delete aborted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ClearTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearTextToolStripMenuItem.Click
        'Clears all displayed text
        lstDisp.Items.Clear()
        txtNP.Text = ""
        txtGetArray.Text = ""
    End Sub
    Private Sub CreateBackupFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateBackupFileToolStripMenuItem.Click
        'Tests if file exists in application directory
        If IO.File.Exists("prime.txt") Then
            'If so, then overwrite/create backuop of said file
            My.Computer.FileSystem.CopyFile("prime.txt", "prime2.txt", overwrite:=True)
            lstDisp.Items.Clear()
            lstDisp.Items.Add("Backup complete.")
        Else
            'Otherwise, tell use origional file does not exits.
            Prob(5)
        End If
    End Sub
    Private Sub LoadBackupFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadBackupFileToolStripMenuItem.Click
        'Sets Display
        lstDisp.Items.Clear()
        'Loads Array
        Dim FileP$ = Application.StartupPath & "\prime2.txt"
        'Checks if file exists
        If Not IO.File.Exists(FileP) Then
            'Error display: Exit
            Prob(5)
            Return
        End If
        'Loading...
        Dim arrayStrPR$() = IO.File.ReadAllLines(FileP)
        intCA = arrayStrPR.Length
        ReDim arrayPR(intCA)
        'Convert data from string to integer
        For I = 0 To intCA - 1
            arrayPR(I) = CInt(arrayStrPR(I))
            arrayStrPR(I) = CStr(arrayPR(I))
            'Progress bar
            Dim intProg% = CInt((I / arrayPR.Length) * 100)
            progMain.Value = intProg
            If intProg > 0 Then
                'Hack to near instantly display the current value. 
                progMain.Value = intProg - 1
                progMain.Value = intProg
            End If
        Next
        'Sets investigative value
        intCN = arrayPR(intCA - 1) + 2
        'Fail safe if the save file is at the default value.
        If arrayPR.Length = 2 Then
            'Subtracts one from value
            intCN -= 1
        End If
        'Outputs that process is complete
        lstDisp.Items.Add("Load Complete")
        lstDisp.Items.Add("Loaded " & arrayPR.Length - 1 & " numbers.")
    End Sub
    Public Sub LoadRangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadRangeToolStripMenuItem.Click
        'Open load range form
        Dim range As New range
        range.ShowDialog()
        'If range form is not closed manualy by user
        If RangeHalt = False Then
            'Prepare to output data
            lstDisp.Items.Clear()
            lstDisp.Items.Add("Listing prime numbers between ")
            lstDisp.Items.Add(Low & " and " & High & ".")
            'Prepare counter:Set tst flag
            Dim i% = 0, tst As Boolean = False
            'Find the begining of the range.
            Do Until arrayPR(i) >= Low
                i += 1
            Loop
            'Count up until you are outside of range
            Do While arrayPR(i) <= High
                'Turns off the 'no primes' test. This will tell the user there are no primes if this loop does not run.
                tst = True
                'Output primes
                lstDisp.Items.Add(arrayPR(i))
                'Increment var.
                i += 1
            Loop
            'Tell user there are no primes if loop was not encountered.
            If tst = False Then lstDisp.Items.Add("No numbers are within that range.")
            'Reset High/Low
            High = Nothing : Low = Nothing
        End If
    End Sub
    Private Sub LoadIDRangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadIDRangeToolStripMenuItem.Click
        Dim IDRange As New IDRange
        IDRange.ShowDialog()
        'If window was not closed by user to cancel instuction
        If RangeHalt = False Then
            'prepare for Output prime numbers in range
            lstDisp.Items.Clear()
            lstDisp.Items.Add("Listing prime numbers between")
            lstDisp.Items.Add("ID's " & Low & " and " & High & ".")
            'Output prime numbers in range
            For i = Low To High
                lstDisp.Items.Add(arrayPR(i - 1))
            Next
        End If
        'Reset High/Low
        High = Nothing : Low = Nothing
    End Sub
    Private Sub ToDoListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToDoListToolStripMenuItem.Click
        'Todo list
        lstDisp.Items.Add("Add a digital instruction 'booklet'.")
        lstDisp.Items.Add("Further debug program and add performance improvements.")
        lstDisp.Items.Add("Add general improvements.")
        lstDisp.Items.Add("Add multithreading Support (Remember roots as a limiter
            of activation)")
    End Sub
    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click
        'List versions and completion dates
        lstDisp.Items.Clear()
        lstDisp.Items.Add("Versions and dates finished:")
        'Version loop
        For I = UBound(Version) To 0 Step -1
            lstDisp.Items.Add(Version(I, 0)) : lstDisp.Items.Add(Version(I, 1))
        Next
    End Sub
End Class
