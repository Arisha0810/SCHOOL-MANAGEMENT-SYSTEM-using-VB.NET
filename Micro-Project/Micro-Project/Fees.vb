Imports System.Data.OleDb

Public Class Fees
    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ARISHA\Documents\std 10.mdb")

    Dim com1 As OleDbCommand = New OleDbCommand
    Dim com11 As OleDbCommand = New OleDbCommand
    Dim com2 As OleDbCommand = New OleDbCommand
    Dim com22 As OleDbCommand = New OleDbCommand
    Dim com3 As OleDbCommand = New OleDbCommand
    Dim com33 As OleDbCommand = New OleDbCommand
    Dim com4 As OleDbCommand = New OleDbCommand
    Dim com44 As OleDbCommand = New OleDbCommand
    Dim com5 As OleDbCommand = New OleDbCommand
    Dim com55 As OleDbCommand = New OleDbCommand
    Dim com6 As OleDbCommand = New OleDbCommand
    Dim com66 As OleDbCommand = New OleDbCommand
    Dim com7 As OleDbCommand = New OleDbCommand
    Dim com77 As OleDbCommand = New OleDbCommand
    Dim com8 As OleDbCommand = New OleDbCommand
    Dim com88 As OleDbCommand = New OleDbCommand
    Dim com9 As OleDbCommand = New OleDbCommand
    Dim com99 As OleDbCommand = New OleDbCommand
    Dim com10 As OleDbCommand = New OleDbCommand
    Dim com100 As OleDbCommand = New OleDbCommand

    Dim adpt1 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt2 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt3 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt4 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt5 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt6 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt7 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt8 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt9 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt10 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt11 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt22 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt33 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt44 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt55 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt66 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt77 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt88 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt99 As OleDbDataAdapter = New OleDbDataAdapter
    Dim adpt100 As OleDbDataAdapter = New OleDbDataAdapter

    Dim ds1 As DataSet = New DataSet
    Dim ds2 As DataSet = New DataSet
    Dim ds3 As DataSet = New DataSet
    Dim ds4 As DataSet = New DataSet
    Dim ds5 As DataSet = New DataSet
    Dim ds6 As DataSet = New DataSet
    Dim ds7 As DataSet = New DataSet
    Dim ds8 As DataSet = New DataSet
    Dim ds9 As DataSet = New DataSet
    Dim ds10 As DataSet = New DataSet
    Dim ds11 As DataSet = New DataSet
    Dim ds22 As DataSet = New DataSet
    Dim ds33 As DataSet = New DataSet
    Dim ds44 As DataSet = New DataSet
    Dim ds55 As DataSet = New DataSet
    Dim ds66 As DataSet = New DataSet
    Dim ds77 As DataSet = New DataSet
    Dim ds88 As DataSet = New DataSet
    Dim ds99 As DataSet = New DataSet
    Dim ds100 As DataSet = New DataSet

    Private Sub Fees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ComboBox1.Items.Add("FEES PAID")
        ComboBox1.Items.Add("FEES NOT PAID")
        ComboBox2.Items.Add("STD I")
        ComboBox2.Items.Add("STD II")
        ComboBox2.Items.Add("STD III")
        ComboBox2.Items.Add("STD IV")
        ComboBox2.Items.Add("STD V")
        ComboBox2.Items.Add("STD VI")
        ComboBox2.Items.Add("STD VII")
        ComboBox2.Items.Add("STD VIII")
        ComboBox2.Items.Add("STD IX")
        ComboBox2.Items.Add("STD X")
        con.Open()
        com1 = New OleDbCommand("select * from Table1 where Fees_Status like 'PAID'", con)
        adpt1 = New OleDbDataAdapter(com1)
        adpt1.Fill(ds1, "Table1")

        com2 = New OleDbCommand("select * from Table2 where Fees_Status like 'PAID'", con)
        adpt2 = New OleDbDataAdapter(com2)
        adpt2.Fill(ds2, "Table2")

        com3 = New OleDbCommand("select * from Table3 where Fees_Status like 'PAID'", con)
        adpt3 = New OleDbDataAdapter(com3)
        adpt3.Fill(ds3, "Table3")

        com4 = New OleDbCommand("select * from Table4 where Fees_Status like 'PAID'", con)
        adpt4 = New OleDbDataAdapter(com4)
        adpt4.Fill(ds4, "Table4")

        com5 = New OleDbCommand("select * from Table5 where Fees_Status like 'PAID'", con)
        adpt5 = New OleDbDataAdapter(com5)
        adpt5.Fill(ds5, "Table5")

        com6 = New OleDbCommand("select * from Table6 where Fees_Status like 'PAID'", con)
        adpt6 = New OleDbDataAdapter(com6)
        adpt6.Fill(ds6, "Table6")

        com7 = New OleDbCommand("select * from Table7 where Fees_Status like 'PAID'", con)
        adpt7 = New OleDbDataAdapter(com7)
        adpt7.Fill(ds7, "Table7")

        com8 = New OleDbCommand("select * from Table8 where Fees_Status like 'PAID'", con)
        adpt8 = New OleDbDataAdapter(com8)
        adpt8.Fill(ds8, "Table8")

        com9 = New OleDbCommand("select * from Table9 where Fees_Status like 'PAID'", con)
        adpt9 = New OleDbDataAdapter(com9)
        adpt9.Fill(ds9, "Table9")

        com10 = New OleDbCommand("select * from Table10 where Fees_Status like 'PAID'", con)
        adpt10 = New OleDbDataAdapter(com10)
        adpt10.Fill(ds10, "Table10")

        com11 = New OleDbCommand("select * from table1 where Fees_Status like 'NOT PAID'", con)
        adpt11 = New OleDbDataAdapter(com11)
        adpt11.Fill(ds11, "Table1")

        com22 = New OleDbCommand("select * from Table2 where Fees_Status like 'NOT PAID'", con)
        adpt22 = New OleDbDataAdapter(com22)
        adpt22.Fill(ds22, "Table2")

        com33 = New OleDbCommand("select * from Table3 where Fees_Status like 'NOT PAID'", con)
        adpt33 = New OleDbDataAdapter(com33)
        adpt33.Fill(ds33, "Table3")

        com44 = New OleDbCommand("select * from Table4 where Fees_Status like 'NOT PAID'", con)
        adpt44 = New OleDbDataAdapter(com44)
        adpt44.Fill(ds44, "Table4")

        com55 = New OleDbCommand("select * from Table5 where Fees_Status like 'NOT PAID'", con)
        adpt55 = New OleDbDataAdapter(com55)
        adpt55.Fill(ds55, "Table5")

        com66 = New OleDbCommand("select * from Table6 where Fees_Status like 'NOT PAID'", con)
        adpt66 = New OleDbDataAdapter(com66)
        adpt66.Fill(ds66, "Table6")

        com77 = New OleDbCommand("select * from Table7 where Fees_Status like 'NOT PAID'", con)
        adpt77 = New OleDbDataAdapter(com77)
        adpt77.Fill(ds77, "Table7")

        com88 = New OleDbCommand("select * from Table8 ", con)
        adpt88 = New OleDbDataAdapter(com88)
        adpt88.Fill(ds88, "Table8")

        com99 = New OleDbCommand("select * from Table9 where Fees_Status like 'NOT PAID'", con)
        adpt99 = New OleDbDataAdapter(com99)
        adpt99.Fill(ds99, "Table9")

        com100 = New OleDbCommand("select * from Table10 where Fees_Status like 'NOT PAID'", con)
        adpt100 = New OleDbDataAdapter(com100)
        adpt100.Fill(ds100, "Table10")

        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        con.Open()
        If ComboBox1.Text = "FEES PAID" And ComboBox2.Text = "STD I" Then
            DataGridView1.DataSource = ds1
            DataGridView1.DataMember = "Table1"

        ElseIf ComboBox1.Text = "FEES NOT PAID" And ComboBox2.Text = "STD I" Then
            DataGridView1.DataSource = ds11
            DataGridView1.DataMember = "Table1"

        ElseIf ComboBox1.Text = "FEES PAID" And ComboBox2.Text = "STD II" Then
            DataGridView1.DataSource = ds2
            DataGridView1.DataMember = "Table2"

        ElseIf ComboBox1.Text = "FEES NOT PAID" And ComboBox2.Text = "STD II" Then
            DataGridView1.DataSource = ds22
            DataGridView1.DataMember = "Table2"

        ElseIf ComboBox1.Text = "FEES PAID" And ComboBox2.Text = "STD III" Then
            DataGridView1.DataSource = ds3
            DataGridView1.DataMember = "Table3"

        ElseIf ComboBox1.Text = "FEES NOT PAID" And ComboBox2.Text = "STD III" Then
            DataGridView1.DataSource = ds3
            DataGridView1.DataMember = "Table3"

        ElseIf ComboBox1.Text = "FEES PAID" And ComboBox2.Text = "STD IV" Then
            DataGridView1.DataSource = ds4
            DataGridView1.DataMember = "Table4"

        ElseIf ComboBox1.Text = "FEES NOT PAID" And ComboBox2.Text = "STD IV" Then
            DataGridView1.DataSource = ds44
            DataGridView1.DataMember = "Table4"

        ElseIf ComboBox1.Text = "FEES PAID" And ComboBox2.Text = "STD V" Then
            DataGridView1.DataSource = ds5
            DataGridView1.DataMember = "Table5"

        ElseIf ComboBox1.Text = "FEES NOT PAID" And ComboBox2.Text = "STD V" Then
            DataGridView1.DataSource = ds55
            DataGridView1.DataMember = "Table5"

        ElseIf ComboBox1.Text = "FEES PAID" And ComboBox2.Text = "STD VI" Then
            DataGridView1.DataSource = ds6
            DataGridView1.DataMember = "Table6"

        ElseIf ComboBox1.Text = "FEES NOT PAID" And ComboBox2.Text = "STD II" Then
            DataGridView1.DataSource = ds66
            DataGridView1.DataMember = "Table6"

        ElseIf ComboBox1.Text = "FEES PAID" And ComboBox2.Text = "STD VII" Then
            DataGridView1.DataSource = ds7
            DataGridView1.DataMember = "Table7"

        ElseIf ComboBox1.Text = "FEES NOT PAID" And ComboBox2.Text = "STD VII" Then
            DataGridView1.DataSource = ds77
            DataGridView1.DataMember = "Table7"

        ElseIf ComboBox1.Text = "FEES PAID" And ComboBox2.Text = "STD VIII" Then
            DataGridView1.DataSource = ds8
            DataGridView1.DataMember = "Table8"

        ElseIf ComboBox1.Text = "FEES NOT PAID" And ComboBox2.Text = "STD VIII" Then
            DataGridView1.DataSource = ds88
            DataGridView1.DataMember = "Table8"

        ElseIf ComboBox1.Text = "FEES PAID" And ComboBox2.Text = "STD IX" Then
            DataGridView1.DataSource = ds9
            DataGridView1.DataMember = "Table9"

        ElseIf ComboBox1.Text = "FEES NOT PAID" And ComboBox2.Text = "STD IX" Then
            DataGridView1.DataSource = ds99
            DataGridView1.DataMember = "Table9"

        ElseIf ComboBox1.Text = "FEES PAID" And ComboBox2.Text = "STD X" Then
            DataGridView1.DataSource = ds10
            DataGridView1.DataMember = "Table10"

        ElseIf ComboBox1.Text = "FEES NOT PAID" And ComboBox2.Text = "STD X" Then
            DataGridView1.DataSource = ds100
            DataGridView1.DataMember = "Table10"

        End If
        con.Close()
    End Sub
End Class