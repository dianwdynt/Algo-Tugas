Public Class pertemuan9

    Function factorial(ByVal n As Integer) As String
        If n = 1 Then
            factorial = 1
        Else
            factorial = n * factorial(n - 1)
        End If
    End Function
    Function GetFactorialseries(ByVal n As Integer) As String

        'Buat String yang akan menampung daftar
        Dim series As New System.Text.StringBuilder()

        'Mulai dengan menggabungkan 3 nilai pertama yang mana selalu konstan
        series.Append("!")
        series.Append(n)
        series.Append("=")

        ' Hitung Factorial setiap elemen dan tambahkan tambahkan ke daftar
        For i = n To 1 Step -1
            'dan menambahkannya ke daftar
            series.Append(i)
            If i > 1 Then
                series.Append(" * ")
            Else
                series.Append(" = ")
            End If
        Next
        ' Dapatkan hasil dari Metode Faktorial dan menambahkannya ke akhir daftar
        series.Append(factorial(n))
        Return series.ToString()
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        n = Integer.Parse(TextBox1.Text)
        Label1.Text = GetFactorialseries(n)
        Console.WriteLine(GetFactorialseries(n))
    End Sub

    Private Sub pertemuan9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class