Public Class frmStopWatch

    Dim dStartTime As Date
    Dim stStoppedTime As String
    Dim dStopTime As Date

    Private Function ConvData(iTime As Integer) As String 'iTime = total second
        Dim iOre As Integer, iMin As Integer, iSec As Integer

        iOre = iTime \ 3600 'cause in 1 hour there's 3600sec
        iMin = (iTime - iOre * 3600) \ 60
        iSec = iTime - iOre * 3600 - iMin * 60

        Return (Format(iOre, "00") & ":" & Format(iMin, "00") & ":" & Format(iSec, "00"))
    End Function


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblRunning_Click(sender As Object, e As EventArgs) Handles lblRunning.Click

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If btnStart.Text.ToUpper = "START" Then

            dStartTime = Now
            stStoppedTime = 0
            timDisplay.Enabled = True
            btnStart.Text = "Stop"
            btnExit.Enabled = False

        ElseIf btnStart.Text.ToUpper = "STOP" Then

            dStopTime = Now
            btnStart.Text = "Restart"
            timDisplay.Enabled = False
            btnReset.Enabled = True
            btnExit.Enabled = True

        ElseIf btnStart.Text.ToUpper = "RESTART" Then

            stStoppedTime += DateDiff(DateInterval.Second, dStopTime, Now)
            timDisplay.Enabled = True
            btnStart.Text = "Stop"
            btnReset.Enabled = False
            btnExit.Enabled = False


        End If



    End Sub

    Private Sub timDisplay_Tick(sender As Object, e As EventArgs) Handles timDisplay.Tick

        Dim dCurTime As Date
        Dim iTotTime As Integer
        Dim iRunningTime As Integer

        dCurTime = Now
        iTotTime = DateDiff(DateInterval.Second, dStartTime, dCurTime)
        iRunningTime = iTotTime - stStoppedTime
        'display times
        lblRunning.Text = ConvData(iRunningTime)
        lblTotal.Text = ConvData(iTotTime)


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        lblRunning.Text = "00:00:00"
        lblTotal.Text = "00:00:00"
        btnStart.Text = "Start"
        btnReset.Enabled = False

    End Sub
End Class
