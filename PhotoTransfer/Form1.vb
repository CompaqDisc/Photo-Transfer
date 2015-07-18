Public Class PhotoTransferPanel
    Dim AppStep = 0
    Dim NumSteps = 7
    Dim ProgressMax = 700
    Dim ConfigLoation = "C:\PhotoTransferConfig.ini"

    Private Sub OnFormLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainProgressBar.Maximum = ProgressMax
    End Sub

    Private Sub BeginButton_Click(sender As Object, e As EventArgs) Handles BeginButton.Click
        ' Seven part process
        ' 1. Cam on
        ' 2. Cam copy to tmp
        ' 3. Cam off / eject / manual delete warning
        ' 4. Organize tmp to c:
        ' 5. Plug in HDD
        ' 6. Copy c: to HDD
        ' 7. Eject HDD, done
        FindConfig() ' Double check values
        PlugInCamera() ' Part 1
        CheckCameraReady() ' Check Part One
    End Sub

    Private Sub PlugInCamera()
        Log("Step 1 of 7: Waiting on camera...", True)
        Dim PICTitle = "Camera Setup"
        Dim PICMsg = "Please plug in your camera and turn it on. (Click ok when done.)"
        Dim PICStyle = MsgBoxStyle.OkOnly Or MsgBoxStyle.Information
        Dim NextStep = MessageBox(PICMsg, PICStyle, PICTitle, False)

        If NextStep = MsgBoxResult.Ok Then
            AppStep = 1
            MainProgressBar.Value = (ProgressMax / NumSteps) * AppStep
            'Return to main program
        End If
    End Sub

    Private Sub CheckCameraReady()
        Log("Step 1 of 7: Checking Camera Availability...", True)

    End Sub

    Private Sub FindConfig()
        Log("Finding Configuration File At: " + ConfigLoation + " ...", True)

        If My.Computer.FileSystem.FileExists(ConfigLoation) Then
            Log("Loading Configuration File From: " + ConfigLoation + " ...", True)
        Else
            Log("Missing Configuration File At: " + ConfigLoation + " | Creating file...", True)
            FirstConfigSetup()
        End If
    End Sub

    Private Sub FirstConfigSetup()
        Dim Config As New IniFile
        Config.AddSection("DRIVE").AddKey("CAMERA_DRIVE_LETTER").Value = "F:"
        Config.AddSection("DRIVE").AddKey("HDD_DRIVE_LETTER").Value = "G:"
        Config.AddSection("DRIVE").AddKey("LOCAL_DRIVE_LETTER").Value = "C:"

        Config.AddSection("DRIVE_FOLDER").AddKey("CAMERA").Value = "{CAMERA_DRIVE_LETTER}\DCIM\100ND70S\"
        Config.AddSection("DRIVE_FOLDER").AddKey("HDD").Value = "{HDD_DRIVE_LETTER}\Pictures\{YEAR_FORMAT}\{MONTH_FORMAT}"
        Config.AddSection("DRIVE_FOLDER").AddKey("TEMP").Value = "{LOCAL_DRIVE_LETTER}\Users\Jim and Joyce\Pictures\Joyce's Pictures\TMP"
        Config.AddSection("DRIVE_FOLDER").AddKey("LOCAL").Value = "{LOCAL_DRIVE_LETTER}\Users\Jim and Joyce\Pictures\Joyce's Pictures\{YEAR_FORMAT}\{MONTH_FORMAT}"

        Config.AddSection("RAW_PHOTO_PROPS").AddKey("NAME").Value = "DSC_{NUMBER_SCHEME}"
        Config.AddSection("RAW_PHOTO_PROPS").AddKey("NUMBER_SCHEME").Value = "####"
        Config.AddSection("RAW_PHOTO_PROPS").AddKey("STARTIBG_NUMBER").Value = "0001"
        Config.AddSection("RAW_PHOTO_PROPS").AddKey("FILE_EXT").Value = ".JPG"

        Config.AddSection("FORMAT_STRINGS").AddKey("YEAR_FORMAT").Value = "yyyy"
        Config.AddSection("FORMAT_STRINGS").AddKey("MONTH_FORMAT").Value = "M - MMMM"
    End Sub

    Private Function MessageBox(ByRef Msg As String, ByRef Style As MsgBoxStyle, ByRef Title As String, ByRef AppExit As Boolean)
        Log(Title + ": " + Msg, False)
        Dim MsgOut = MsgBox(Msg, Style, Title)
        If AppExit = True Then
            Application.Exit()
            End
        End If
        Return MsgOut
    End Function

    Private Sub Log(ByRef Msg As String, ByRef ChangeText As Boolean)
        Console.WriteLine(Msg)
        If ChangeText = True Then
            ProgressLabel.Text = Msg
        End If
    End Sub
End Class
