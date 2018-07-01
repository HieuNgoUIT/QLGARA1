Imports QLGARADAL
Imports QLGARADTO

Public Class VatTuBus

    Private vatTuDAL As VatTuDAL
    Public Sub New()
        vatTuDAL = New VatTuDAL()
    End Sub
    Public Sub New(connectionString As String)
        vatTuDAL = New VatTuDAL(connectionString)
    End Sub
    Public Function themmavattu(ByVal vattu As vatTuDTO) As String
        '1. verify data here!!

        '2. insert to DB
        Return vatTuDAL.Them(vattu)
    End Function

    Public Function Taidulieutenvattu()
        Return vatTuDAL.Taidulieutenvattu()
    End Function
    Public Function Taidulieudongia()
        Return vatTuDAL.Taidulieudongia()
    End Function

End Class
