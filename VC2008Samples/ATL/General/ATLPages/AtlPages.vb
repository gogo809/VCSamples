
Imports EnvDTE
Imports System.Diagnostics

Public Module AtlPages

    Public Sub Test()
        Dim Helper
        Helper = CreateObject("ATLPages7.Helper.1")

        On Error Resume Next       ' Handle case where there's no active document
        Helper.ShowPage( _
            ActiveDocument.Name, _
            "ATLPages7.DocumentProperties.1", _
            DTE.ActiveDocument _
            )
    End Sub

End Module

