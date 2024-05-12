Public Class Form1
    Dim selected As String
    Dim lv As ListViewItem

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopListview()
        DisableInputs()
        ToggleButtons(False)

    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If HallName.Text = "" Or Address.Text = "" Or TelNo.Text = "" Or HallMngr.Text = "" Then
            MsgBox("Please complete all data before saving ", 48, Me.Text)
        Else
            If save.Text = "Save" Then
                If MsgBox("Are you sure to save this record ?", vbYesNo, Me.Text) = vbYes Then
                    openCon()
                    sql = "INSERT INTO tblhall (hallname, halladdr,halltel, hallman) VALUES" & "('" & Me.HallName.Text & "','" & Me.Address.Text & "','" & Me.TelNo.Text & "','" & Me.HallMngr.Text & "')"

                    cmd = New Odbc.OdbcCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Record saved!", 64, Me.Text)

                    Poplistview()
                    '' resetForm()

                End If

            Else
                If MsgBox("Are you sure to update this record? ", vbYesNo + vbQuestion, Me.Text) = vbYes Then
                    openCon()
                    sql = "UPDATE tblhall SET hallname = '" & Me.HallName.Text & "', halladdr = '" & Me.Address.Text & "', halltel = '" & Me.TelNo.Text & "', hallman = '" & Me.HallMngr.Text & "' WHERE idhall = '" & selected & "'"


                    cmd = New Odbc.OdbcCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Record updated!", 64, Me.Text)
                    Poplistview()
                    ''resetForm()
                End If
            End If

            DisableInputs()
            ToggleButtons(False)

            HallName.Clear()
            Address.Clear()
            TelNo.Clear()
            HallMngr.Clear()
        End If
    End Sub

    Private Sub PopListview()
        ListView1.Clear()

        With ListView1
            .View = View.Details
            .GridLines = True
            .Columns.Add("ID", 40)
            .Columns.Add("Residence Hall", 129)
            .Columns.Add("Address", 130)
            .Columns.Add("Telephone", 80)
            .Columns.Add("Manager", 100)

        End With
        openCon()
        sql = "Select * from tblhall order by idhall"
        cmd = New Odbc.OdbcCommand(sql, cn)
        dr = cmd.ExecuteReader

        Do While dr.Read() = True
            lv = New ListViewItem(dr("idhall").ToString)
            lv.SubItems.Add(dr("hallname"))
            lv.SubItems.Add(dr("halladdr"))
            lv.SubItems.Add(dr("halltel"))
            lv.SubItems.Add(dr("hallman"))
            ListView1.Items.Add(lv)
        Loop
        cn.Close()
    End Sub


    Private Sub EnableInputs()
        HallName.Enabled = True
        Address.Enabled = True
        TelNo.Enabled = True
        HallMngr.Enabled = True
    End Sub

    Private Sub DisableInputs()
        HallName.Enabled = False
        Address.Enabled = False
        TelNo.Enabled = False
        HallMngr.Enabled = False
    End Sub

    Private Sub ToggleButtons(enable As Boolean)
        save.Enabled = enable
        Close.Enabled = enable
        Newbtn.Enabled = Not enable
        Delete.Enabled = Not enable
        Edit.Enabled = Not enable
    End Sub

    Private Sub Newbtn_Click(sender As Object, e As EventArgs) Handles Newbtn.Click
        EnableInputs()
        ToggleButtons(True)
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        DisableInputs()
        ToggleButtons(False)
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Me.Dispose()
    End Sub
End Class
