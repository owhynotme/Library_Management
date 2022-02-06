
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim con As New MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim ds As DataSet
    Dim counts, i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            con.ConnectionString = "server = localhost;user=root;password=root324;database=library"

            con.Open()

            con.Close()
            refreshs()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Public Class Library

        Dim Membid, Phone_num As Integer
        Dim Memb_Name, Email As String




    End Class

    Public Sub refreshs()

        If con.State = ConnectionState.Closed Then

            con.Open()
        End If

        cmd = New MySqlCommand("select * from members", con)

        ds = New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "Members")

        counts = ds.Tables(0).Rows.Count
        i = 0
        display()
        DataGridView1.DataSource = ds.Tables(0)

        con.Close()

    End Sub
    Public Sub display()


        ID_txt.Text = ds.Tables(0).Rows(i).Item(0)
        fst_name_txt.Text = ds.Tables(0).Rows(i).Item(1)
        lst_name_txt.Text = ds.Tables(0).Rows(i).Item(2)
        ph_num.Text = ds.Tables(0).Rows(i).Item(3)
        email_txt.Text = ds.Tables(0).Rows(i).Item(4)

    End Sub

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click

        Try

            Dim s As MsgBoxResult = MsgBox("Do you want to Delete ", MsgBoxStyle.YesNo)
            If s = MsgBoxResult.Yes Then

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                cmd = New MySqlCommand("delete from members where id = @id ", con)
                cmd.Parameters.Add(New MySqlParameter("@id", ID_txt.Text))

                da.DeleteCommand = cmd
                da.DeleteCommand.ExecuteNonQuery()
                MsgBox("Deleted Successfully")

            Else

                MsgBox("Not deleted")

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        refreshs()


    End Sub

    Private Sub nxt_bt_Click(sender As Object, e As EventArgs) Handles nxt_bt.Click
        If i < counts - 1 Then

            i += 1
            display()
        Else
            i = 0
            display()
        End If
    End Sub

    Private Sub Edit_bt_Click(sender As Object, e As EventArgs) Handles Edit_bt.Click

        Update_btn.Visible = True
        ph_num.Clear()
        ph_num.Enabled = True
        Edit_bt.Visible = False

    End Sub

    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles Save_btn.Click

        Dim designation As String

        Save_btn.Visible = False
        Add_bt.Visible = True

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Try

            cmd = New MySqlCommand("insert into members(id,first_name,last_name,phone_num,email,designation) values(@id,@first_name,@last_name,@phone,@email,@designation )", con)

            cmd.Parameters.Add(New MySqlParameter("@id", ID_txt.Text))
            cmd.Parameters.Add(New MySqlParameter("@first_name", fst_name_txt.Text))
            cmd.Parameters.Add(New MySqlParameter("@last_name", lst_name_txt.Text))
            cmd.Parameters.Add(New MySqlParameter("@phone", ph_num.Text))
            cmd.Parameters.Add(New MySqlParameter("@email", email_txt.Text))

            If RadioButton1.Checked Then

                designation = RadioButton1.Text

            Else
                designation = RadioButton2.Text
            End If
            cmd.Parameters.Add(New MySqlParameter("@designation", designation))

            da.InsertCommand = cmd
            da.InsertCommand.ExecuteNonQuery()
            MsgBox("Inserted")

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        End Try

        con.Close()
        refreshs()

        ID_txt.Enabled = False
        fst_name_txt.Enabled = False
        lst_name_txt.Enabled = False
        ph_num.Enabled = False
        email_txt.Enabled = False

    End Sub

    Private Sub Add_bt_Click(sender As Object, e As EventArgs) Handles Add_bt.Click

        Save_btn.Visible = True
        Add_bt.Visible = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True

        'Clear

        ID_txt.Clear()
        fst_name_txt.Clear()
        lst_name_txt.Clear()
        ph_num.Clear()
        email_txt.Clear()


        ID_txt.Enabled = True
        fst_name_txt.Enabled = True
        lst_name_txt.Enabled = True
        ph_num.Enabled = True
        email_txt.Enabled = True

    End Sub

    Private Sub Search_bt_Click(sender As Object, e As EventArgs) Handles Search_bt.Click

        Dim dt As DataTable

        If con.State = ConnectionState.Closed Then

            con.Open()
        End If

        'cmd = New MySqlCommand("select * from members where id=@no or phone_num=@no", con)
        'cmd.Parameters.Add(New MySqlParameter("@no", InputBox("Enter Contact Number/Id")))

        'ds = New DataSet("Search")
        'da.SelectCommand = cmd

        'da.Fill(ds)
        'Filling another dataset
        'da.Fill(LibraryDataSet)

        'DataGridView1.DataSource = ds.Tables("Search")


    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        cmd = New MySqlCommand("update members set phone_num = @ph_num where id = @id", con)
        cmd.Parameters.Add(New MySqlParameter("@ph_num", ph_num.Text))
        cmd.Parameters.Add(New MySqlParameter("@id", ID_txt.Text))
        da.UpdateCommand = cmd
        da.UpdateCommand.ExecuteNonQuery()
        MsgBox("Updated Successfully")
        refreshs()
        con.Close()


        Update_btn.Visible = False
        Edit_bt.Visible = True

    End Sub
End Class
