Imports QLGaraDAL
Imports QLGARADTO

Public Class XeBus

    Private xeDAL As XeDAL
        Public Sub New()
            xeDAL = New XeDAL()
        End Sub
        Public Sub New(connectionString As String)
            xeDAL = New XeDAL(connectionString)
        End Sub
    Public Function themxe(ByVal xe As XeDTO) As String
        '1. verify data here!!

        '2. insert to DB
        Return xeDAL.Them(xe)
    End Function
    Public Function tracuuxe(x As String) As DataTable
        '1. verify data here!!

        '2. insert to DB
        Return xeDAL.tracuuxe(x)
    End Function
    Public Function Taidulieu()
        Return xeDAL.Taidulieu()
    End Function
    Public Function Taidulieuhieuxe()
        Return xeDAL.Taidulieuhieuxe()
    End Function
    Public Function xoa(s As String)
        Return xeDAL.xoaxe(s)
    End Function
    Public Function edit(x As XeDTO)
        Return xeDAL.chinhsuaxe(x)
    End Function

End Class

