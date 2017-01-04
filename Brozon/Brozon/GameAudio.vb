' Brozon - a cannonball game.
' (c)2016 Trevor D. Brown and Travis Anderson. All rights reserved.
' CS 396 - Fall 2016 - Dr. Wang
' Project 4
'
' This program was written for partial fulfilment of requirements for
' CS 396 (Fall 2016), Project 4.

' GameAudio - this class allows the program to play multiple streams of audio at once.

' -------------------------------------------------------------------------

Public Class GameAudio

    ' Declare a Function that allows the program to utilize multiples stream of audio through mciSendString
    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    ' Declare a variable to define the common name of a stream.
    Private AudioName As String = ""

    ' Name Property of a GameAudio instance
    Public Property Name As String

        ' Set the common name of the instance.
        Set(value As String)
            AudioName = value
        End Set

        ' Get the common name of the instance.
        Get
            Return AudioName
        End Get

    End Property

    ' Play - Subroutine for starting and playing an audio stream.
    Public Sub Play(ByVal id As Integer, ByVal repeat As Boolean)
        ' If Repeat is set to true, 
        ' Open and play the desired audio stream, on repeat.
        ' Otherwise,
        ' Open and play the desired audio stream, not on repeat.
        If repeat = True Then
            mciSendString("Open " & GetAudioFile(id) & " alias " & AudioName, CStr(0), 0, 0)
            mciSendString("Play " & AudioName & " repeat", CStr(0), 0, 0)
        Else
            mciSendString("Open " & GetAudioFile(id) & " alias " & AudioName, CStr(0), 0, 0)
            mciSendString("Play " & AudioName, CStr(0), 0, 0)
        End If

        ' Set the audio volume to 1000.
        mciSendString("setaudio " & AudioName & " volume to 1000", CStr(0), 0, 0)

    End Sub

    ' ChangeVolume - subroutine to allow an existing audio stream's volume to be adjusted.
    Public Sub ChangeVolume(ByVal name As String, ByVal volumeLevel As Integer)
        mciSendString("setaudio " & name & " volume to " + volumeLevel.ToString, CStr(0), 0, 0)
    End Sub

    ' Pause - subroutine to allow an existing audio stream to be paused.
    Public Sub Pause(ByVal name As String, ByVal pause As Boolean)
        If (pause = True) Then
            'Pause the Audio
            mciSendString("pause " & name, CStr(0), 0, 0)
        Else
            'Unpause the audio
            mciSendString("resume " & name, CStr(0), 0, 0)
        End If

    End Sub

    ' CloseAudioStream - subroutine to close an existing audio stream.
    Public Sub CloseAudioStream(ByVal name As String)
        mciSendString("Close " & name, CStr(0), 0, 0)
    End Sub

    ' GetAudioFile - function to allow a specified audio file.
    Private Function GetAudioFile(ByVal id As Integer) As String

        ' Begin specifying the audio path.
        Dim AudioFilePath As String = ""
        Dim RelativePath As String = IO.Path.GetFullPath(My.Application.Info.DirectoryPath)

        ' Select Statements
        Select Case id
            ' Cases for each audio file name here:
            ' Example:
            ' Case 0
            ' AudioFilePath = IO.Path.Combine(RelativePath, "theme.mp3")
        End Select

        ' Insert the specified file into the audio file path.
        AudioFilePath = Chr(34) & AudioFilePath & Chr(34)

        ' Return the full path.
        Return AudioFilePath

    End Function

End Class
