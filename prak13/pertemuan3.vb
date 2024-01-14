Public Class pertemuan3
    Public hrgmakanan, hrgminuman As Integer
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Mie Ayam"
                makanan.Text = "Rp. 10000"
                hrgmakanan = 10000
            Case "Mie Ayam Bakso"
                makanan.Text = "Rp. 15000"
                hrgmakanan = 15000
            Case "Bakso Urat"
                makanan.Text = "Rp. 12000"
                hrgmakanan = 12000
            Case "Mie Telur"
                makanan.Text = "Rp. 10000"
                hrgmakanan = 10000
        End Select
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Air Mineral"
                minuman.Text = "Rp. 5000"
                hrgminuman = 5000
            Case "Es Teh Manis"
                minuman.Text = "Rp. 10000"
                hrgminuman = 10000
            Case "Es Teh Tawar"
                minuman.Text = "Rp. 2000"
                hrgminuman = 2000
            Case "Teh Manis Hangat"
                minuman.Text = "Rp. 7000"
                hrgminuman = 7000
            Case "Teh Tawar Hangat"
                minuman.Text = "Rp. 0"
                hrgminuman = 0
        End Select
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim porsimkn, porsimnm, jumlah As Integer
        porsimkn = TextBox1.Text
        porsimnm = TextBox2.Text
        jumlah = (hrgmakanan * porsimkn) + (hrgminuman * porsimnm)
        Label8.Text = "Rp. " & jumlah.ToString
    End Sub
End Class