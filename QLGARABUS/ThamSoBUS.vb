Imports QLGARADTO
Imports QLGARADAL
Public Class ThamSoBUS
    Dim tsDAL As ThamSoDAL
    Public Function Taidulieu()
        tsDAL = New ThamSoDAL()
        Return tsDAL.taidulieuthamso()
    End Function
    Public Function themts(ByVal ts As ThamSoDTO) As String
        '1. verify data here!!

        tsDAL = New ThamSoDAL()
        Return tsDAL.Themts(ts)
    End Function
End Class
