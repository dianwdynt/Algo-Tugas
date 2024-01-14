Public Class pertemuan5
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim Arr(4) As String
        Arr(0) = ComboBox1.Text
        Arr(1) = ComboBox2.Text
        Arr(2) = ComboBox3.Text
        Arr(3) = TextBox1.Text
        Arr(4) = TextBox2.Text

    End Sub

    Private Sub pertemuan5_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim arrTanggal() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "19", "30", "31"}

        Dim arrBulan(11) As String
        arrBulan(0) = "Januari"
        arrBulan(1) = "Februari"
        arrBulan(2) = "Maret"
        arrBulan(3) = "April"
        arrBulan(4) = "Mei"
        arrBulan(5) = "Juni"
        arrBulan(6) = "Juli"
        arrBulan(7) = "Agustus"
        arrBulan(8) = "September"
        arrBulan(9) = "Oktober"
        arrBulan(10) = "November"
        arrBulan(11) = "Desember"

        Dim arrTahun() As String = {"1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"}

        ComboBox1.Items.AddRange(arrTanggal)
        ComboBox2.Items.AddRange(arrBulan)
        ComboBox3.Items.AddRange(arrTahun)

    End Sub
End Class