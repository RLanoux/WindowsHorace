Public Class Form1

    ' Set global constants
    Const APP_VERSION As [String] = " v1.0"
    Const XLIMIT As Int32 = 12
    Const YLIMIT As Int32 = 12

    ' Establish new global variables
    Dim iNewX As Int32 = 0
    Dim iOldX As Int32 = 0
    Dim iNewY As Int32 = 0
    Dim iOldY As Int32 = 0
    Dim iTries As Int32 = 0
    Dim iKitchenFloor As Int32(,) = New Int32(XLIMIT - 1, YLIMIT - 1) {}
    Dim rnd As New Random()
    Dim bStart As [Boolean] = False

    Private Sub DoWork(ByVal x As Int32, ByVal y As Int32)

        If bStart Then
            ' Increment iTries and display it in the textbox
            'iTries += 1
            'txtTries.Text = iTries.ToString()

            ' if x = iNewX and y = iNewY
            If (x = iNewX) AndAlso (y = iNewY) Then

                '      then player captured Horace
                '      Display a congratulations victory message
                MessageBox.Show("Congratulations!! You have caught the grasshopper that has been terrorizing your kitchen.",
                                "Catching Horace! " & APP_VERSION,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
                '      Sweep the kitchen (set array back to zeroes)
                SweepKitchen()
                ' set iTries to 0 and update the textbox 
                'iTries = 0
                'txtTries.Text = iTries.ToString()
                '      Enable the Start button
                btnStart.Enabled = True
                '      Enable the Exit button
                btnExit.Enabled = True
                'Exit boolean
                bStart = False

                'else randomly select new tile coordinates.
            Else

                iOldX = iNewX
                iOldY = iNewY

                While (iOldX = iNewX) AndAlso (iOldY = iNewY)
                    SetHorace()
                End While

                If (x = iNewX) AndAlso (y = iNewY) Then
                    ' Tell user he lost
                    MessageBox.Show("Oh goodness!! Horace has crawled up your leg and is now hopping around on your clothes!",
                                    "Catching Horace! " & APP_VERSION,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation)
                    '      Sweep the kitchen (set array back to zeroes)
                    SweepKitchen()
                    ' set iTries to 0 and update the textbox 
                    'iTries = 0
                    'txtTries.Text = iTries.ToString()
                    '      Enable the Start button
                    btnStart.Enabled = True
                    '      Enable the Exit button
                    btnExit.Enabled = True
                    'Exit boolean
                    bStart = False
                End If
            End If
        End If
    End Sub

    Private Sub SweepKitchen()
        ' Set the values to zero
        For j As Int32 = 0 To YLIMIT - 1
            For i As Int32 = 0 To XLIMIT - 1
                iKitchenFloor(j, i) = 0
            Next
        Next
    End Sub

    Private Sub SetHorace()
        ' randomly select a tile
        iNewX = rnd.[Next](0, XLIMIT)
        iNewY = rnd.[Next](0, YLIMIT)
    End Sub

    Private Sub lblTile0000_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0000.Click
        DoWork(0, 0)
    End Sub
    Private Sub lblTile0001_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0001.Click
        DoWork(0, 1)
    End Sub
    Private Sub lblTile0002_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0002.Click
        DoWork(0, 2)
    End Sub
    Private Sub lblTile0003_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0003.Click
        DoWork(0, 3)
    End Sub
    Private Sub lblTile0004_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0004.Click
        DoWork(0, 4)
    End Sub
    Private Sub lblTile0005_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0005.Click
        DoWork(0, 5)
    End Sub
    Private Sub lblTile0006_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0006.Click
        DoWork(0, 6)
    End Sub
    Private Sub lblTile0007_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0007.Click
        DoWork(0, 7)
    End Sub
    Private Sub lblTile0008_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0008.Click
        DoWork(0, 8)
    End Sub
    Private Sub lblTile0009_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0009.Click
        DoWork(0, 9)
    End Sub
    Private Sub lblTile0010_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0010.Click
        DoWork(0, 10)
    End Sub
    Private Sub lblTile0011_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0011.Click
        DoWork(0, 11)
    End Sub
    Private Sub lblTile0100_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0100.Click
        DoWork(1, 0)
    End Sub
    Private Sub lblTile0101_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0101.Click
        DoWork(1, 1)
    End Sub
    Private Sub lblTile0102_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0102.Click
        DoWork(1, 2)
    End Sub
    Private Sub lblTile0103_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0103.Click
        DoWork(1, 3)
    End Sub
    Private Sub lblTile0104_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0104.Click
        DoWork(1, 4)
    End Sub
    Private Sub lblTile0105_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0105.Click
        DoWork(1, 5)
    End Sub
    Private Sub lblTile0106_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0106.Click
        DoWork(1, 6)
    End Sub
    Private Sub lblTile0107_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0107.Click
        DoWork(1, 7)
    End Sub
    Private Sub lblTile0108_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0108.Click
        DoWork(1, 8)
    End Sub
    Private Sub lblTile0109_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0109.Click
        DoWork(1, 9)
    End Sub
    Private Sub lblTile0110_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0110.Click
        DoWork(1, 10)
    End Sub
    Private Sub lblTile0111_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0111.Click
        DoWork(1, 11)
    End Sub
    Private Sub lblTile0200_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0200.Click
        DoWork(2, 0)
    End Sub
    Private Sub lblTile0201_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0201.Click
        DoWork(2, 1)
    End Sub
    Private Sub lblTile0202_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0202.Click
        DoWork(2, 2)
    End Sub
    Private Sub lblTile0203_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0203.Click
        DoWork(2, 3)
    End Sub
    Private Sub lblTile0204_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0204.Click
        DoWork(2, 4)
    End Sub
    Private Sub lblTile0205_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0205.Click
        DoWork(2, 5)
    End Sub
    Private Sub lblTile0206_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0206.Click
        DoWork(2, 6)
    End Sub
    Private Sub lblTile0207_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0207.Click
        DoWork(2, 7)
    End Sub
    Private Sub lblTile0208_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0208.Click
        DoWork(2, 8)
    End Sub
    Private Sub lblTile0209_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0209.Click
        DoWork(2, 9)
    End Sub
    Private Sub lblTile0210_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0210.Click
        DoWork(2, 10)
    End Sub
    Private Sub lblTile0211_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0211.Click
        DoWork(2, 11)
    End Sub
    Private Sub lblTile0300_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0300.Click
        DoWork(3, 0)
    End Sub
    Private Sub lblTile0301_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0301.Click
        DoWork(3, 1)
    End Sub
    Private Sub lblTile0302_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0302.Click
        DoWork(3, 2)
    End Sub
    Private Sub lblTile0303_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0303.Click
        DoWork(3, 3)
    End Sub
    Private Sub lblTile0304_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0304.Click
        DoWork(3, 4)
    End Sub
    Private Sub lblTile0305_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0305.Click
        DoWork(3, 5)
    End Sub
    Private Sub lblTile0306_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0306.Click
        DoWork(3, 6)
    End Sub
    Private Sub lblTile0307_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0307.Click
        DoWork(3, 7)
    End Sub
    Private Sub lblTile0308_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0308.Click
        DoWork(3, 8)
    End Sub
    Private Sub lblTile0309_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0309.Click
        DoWork(3, 9)
    End Sub
    Private Sub lblTile0310_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0310.Click
        DoWork(3, 10)
    End Sub
    Private Sub lblTile0311_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0311.Click
        DoWork(3, 11)
    End Sub
    Private Sub lblTile0400_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0400.Click
        DoWork(4, 0)
    End Sub
    Private Sub lblTile0401_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0401.Click
        DoWork(4, 1)
    End Sub
    Private Sub lblTile0402_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0402.Click
        DoWork(4, 2)
    End Sub
    Private Sub lblTile0403_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0403.Click
        DoWork(4, 3)
    End Sub
    Private Sub lblTile0404_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0404.Click
        DoWork(4, 4)
    End Sub
    Private Sub lblTile0405_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0405.Click
        DoWork(4, 5)
    End Sub
    Private Sub lblTile0406_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0406.Click
        DoWork(4, 6)
    End Sub
    Private Sub lblTile0407_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0407.Click
        DoWork(4, 7)
    End Sub
    Private Sub lblTile0408_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0408.Click
        DoWork(4, 8)
    End Sub
    Private Sub lblTile0409_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0409.Click
        DoWork(4, 9)
    End Sub
    Private Sub lblTile0410_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0410.Click
        DoWork(4, 10)
    End Sub
    Private Sub lblTile0411_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0411.Click
        DoWork(4, 11)
    End Sub
    Private Sub lblTile0500_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0500.Click
        DoWork(5, 0)
    End Sub
    Private Sub lblTile0501_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0501.Click
        DoWork(5, 1)
    End Sub
    Private Sub lblTile0502_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0502.Click
        DoWork(5, 2)
    End Sub
    Private Sub lblTile0503_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0503.Click
        DoWork(5, 3)
    End Sub
    Private Sub lblTile0504_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0504.Click
        DoWork(5, 4)
    End Sub
    Private Sub lblTile0505_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0505.Click
        DoWork(5, 5)
    End Sub
    Private Sub lblTile0506_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0506.Click
        DoWork(5, 6)
    End Sub
    Private Sub lblTile0507_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0507.Click
        DoWork(5, 7)
    End Sub
    Private Sub lblTile0508_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0508.Click
        DoWork(5, 8)
    End Sub
    Private Sub lblTile0509_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0509.Click
        DoWork(5, 9)
    End Sub
    Private Sub lblTile0510_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0510.Click
        DoWork(5, 10)
    End Sub
    Private Sub lblTile0511_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0511.Click
        DoWork(5, 11)
    End Sub
    Private Sub lblTile0600_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0600.Click
        DoWork(6, 0)
    End Sub
    Private Sub lblTile0601_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0601.Click
        DoWork(6, 1)
    End Sub
    Private Sub lblTile0602_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0602.Click
        DoWork(6, 2)
    End Sub
    Private Sub lblTile0603_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0603.Click
        DoWork(6, 3)
    End Sub
    Private Sub lblTile0604_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0604.Click
        DoWork(6, 4)
    End Sub
    Private Sub lblTile0605_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0605.Click
        DoWork(6, 5)
    End Sub
    Private Sub lblTile0606_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0606.Click
        DoWork(6, 6)
    End Sub
    Private Sub lblTile0607_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0607.Click
        DoWork(6, 7)
    End Sub
    Private Sub lblTile0608_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0608.Click
        DoWork(6, 8)
    End Sub
    Private Sub lblTile0609_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0609.Click
        DoWork(6, 9)
    End Sub
    Private Sub lblTile0610_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0610.Click
        DoWork(6, 10)
    End Sub
    Private Sub lblTile0611_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0611.Click
        DoWork(6, 11)
    End Sub
    Private Sub lblTile0700_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0700.Click
        DoWork(7, 0)
    End Sub
    Private Sub lblTile0701_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0701.Click
        DoWork(7, 1)
    End Sub
    Private Sub lblTile0702_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0702.Click
        DoWork(7, 2)
    End Sub
    Private Sub lblTile0703_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0703.Click
        DoWork(7, 3)
    End Sub
    Private Sub lblTile0704_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0704.Click
        DoWork(7, 4)
    End Sub
    Private Sub lblTile0705_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0705.Click
        DoWork(7, 5)
    End Sub
    Private Sub lblTile0706_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0706.Click
        DoWork(7, 6)
    End Sub
    Private Sub lblTile0707_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0707.Click
        DoWork(7, 7)
    End Sub
    Private Sub lblTile0708_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0708.Click
        DoWork(7, 8)
    End Sub
    Private Sub lblTile0709_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0709.Click
        DoWork(7, 9)
    End Sub
    Private Sub lblTile0710_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0710.Click
        DoWork(7, 10)
    End Sub
    Private Sub lblTile0711_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0711.Click
        DoWork(7, 11)
    End Sub
    Private Sub lblTile0800_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0800.Click
        DoWork(8, 0)
    End Sub
    Private Sub lblTile0801_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0801.Click
        DoWork(8, 1)
    End Sub
    Private Sub lblTile0802_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0802.Click
        DoWork(8, 2)
    End Sub
    Private Sub lblTile0803_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0803.Click
        DoWork(8, 3)
    End Sub
    Private Sub lblTile0804_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0804.Click
        DoWork(8, 4)
    End Sub
    Private Sub lblTile0805_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0805.Click
        DoWork(8, 5)
    End Sub
    Private Sub lblTile0806_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0806.Click
        DoWork(8, 6)
    End Sub
    Private Sub lblTile0807_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0807.Click
        DoWork(8, 7)
    End Sub
    Private Sub lblTile0808_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0808.Click
        DoWork(8, 8)
    End Sub
    Private Sub lblTile0809_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0809.Click
        DoWork(8, 9)
    End Sub
    Private Sub lblTile0810_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0810.Click
        DoWork(8, 10)
    End Sub
    Private Sub lblTile0811_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0811.Click
        DoWork(8, 11)
    End Sub
    Private Sub lblTile0900_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0900.Click
        DoWork(9, 0)
    End Sub
    Private Sub lblTile0901_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0901.Click
        DoWork(9, 1)
    End Sub
    Private Sub lblTile0902_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0902.Click
        DoWork(9, 2)
    End Sub
    Private Sub lblTile0903_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0903.Click
        DoWork(9, 3)
    End Sub
    Private Sub lblTile0904_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0904.Click
        DoWork(9, 4)
    End Sub
    Private Sub lblTile0905_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0905.Click
        DoWork(9, 5)
    End Sub
    Private Sub lblTile0906_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0906.Click
        DoWork(9, 6)
    End Sub
    Private Sub lblTile0907_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0907.Click
        DoWork(9, 7)
    End Sub
    Private Sub lblTile0908_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0908.Click
        DoWork(9, 8)
    End Sub
    Private Sub lblTile0909_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0909.Click
        DoWork(9, 9)
    End Sub
    Private Sub lblTile0910_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0910.Click
        DoWork(9, 10)
    End Sub
    Private Sub lblTile0911_Click(sender As System.Object, e As System.EventArgs) Handles lblTile0911.Click
        DoWork(9, 11)
    End Sub
    Private Sub lblTile1000_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1000.Click
        DoWork(10, 0)
    End Sub
    Private Sub lblTile1001_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1001.Click
        DoWork(10, 1)
    End Sub
    Private Sub lblTile1002_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1002.Click
        DoWork(10, 2)
    End Sub
    Private Sub lblTile1003_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1003.Click
        DoWork(10, 3)
    End Sub
    Private Sub lblTile1004_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1004.Click
        DoWork(10, 4)
    End Sub
    Private Sub lblTile1005_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1005.Click
        DoWork(10, 5)
    End Sub
    Private Sub lblTile1006_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1006.Click
        DoWork(10, 6)
    End Sub
    Private Sub lblTile1007_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1007.Click
        DoWork(10, 7)
    End Sub
    Private Sub lblTile1008_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1008.Click
        DoWork(10, 8)
    End Sub
    Private Sub lblTile1009_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1009.Click
        DoWork(10, 9)
    End Sub
    Private Sub lblTile1010_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1010.Click
        DoWork(10, 10)
    End Sub
    Private Sub lblTile1011_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1011.Click
        DoWork(10, 11)
    End Sub
    Private Sub lblTile1100_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1100.Click
        DoWork(11, 0)
    End Sub
    Private Sub lblTile1101_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1101.Click
        DoWork(11, 1)
    End Sub
    Private Sub lblTile1102_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1102.Click
        DoWork(11, 2)
    End Sub
    Private Sub lblTile1103_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1103.Click
        DoWork(11, 3)
    End Sub
    Private Sub lblTile1104_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1104.Click
        DoWork(11, 4)
    End Sub
    Private Sub lblTile1105_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1105.Click
        DoWork(11, 5)
    End Sub
    Private Sub lblTile1106_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1106.Click
        DoWork(11, 6)
    End Sub
    Private Sub lblTile1107_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1107.Click
        DoWork(11, 7)
    End Sub
    Private Sub lblTile1108_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1108.Click
        DoWork(11, 8)
    End Sub
    Private Sub lblTile1109_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1109.Click
        DoWork(11, 9)
    End Sub
    Private Sub lblTile1110_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1110.Click
        DoWork(11, 10)
    End Sub
    Private Sub lblTile1111_Click(sender As System.Object, e As System.EventArgs) Handles lblTile1111.Click
        DoWork(11, 11)
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        bStart = True
        btnStart.Enabled = False
        btnExit.Enabled = False
        SweepKitchen()
        SetHorace()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLeave_Click(sender As System.Object, e As System.EventArgs) Handles btnLeave.Click
        MessageBox.Show("Awwww. Are you scared of a little bitty grasshopper?",
                        "Catching Horace!" + APP_VERSION,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop)
        Me.Close()
    End Sub

    Private Sub btnInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnInfo.Click
        frmInfo.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
