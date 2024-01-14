Public Class pertemuan2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NilaiAbs As Double
        Dim NilaiTugas As Double
        Dim NilaiUTS As Double
        Dim NilaiUAS As Double
        Dim NilaiAkhir As Double
        NilaiAbs = TextBox1.Text
        NilaiAbs = (NilaiAbs * 10) / 100
        TextBox5.Text = NilaiAbs
        NilaiTugas = TextBox2.Text
        NilaiTugas = (NilaiTugas * 20) / 100
        TextBox6.Text = NilaiTugas
        NilaiUTS = TextBox3.Text
        NilaiUTS = (NilaiUTS * 30) / 100
        TextBox7.Text = NilaiUTS
        NilaiUAS = TextBox4.Text
        NilaiUAS = (NilaiUAS * 40) / 100
        TextBox8.Text = NilaiUAS
        NilaiAkhir = NilaiAbs + NilaiTugas + NilaiUTS + NilaiUAS
        TextBox9.Text = NilaiAkhir
    End Sub
End Class