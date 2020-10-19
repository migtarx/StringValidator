Public Class 
    ''' <summary>
    ''' Checks if the entered string matches the valid characters set.
    ''' </summary>
    ''' <param name="validCharacters"></param>
    ''' <param name="text"></param>
    ''' <returns></returns>
    Public Shared Function CheckValid(ByVal validCharacters As String, ByVal text As String) As Boolean
        For i = 0 To text.Length - 1
            If Not validCharacters.Contains(text.Chars(i)) Then
                Return False
            End If
        Next
        Return True
    End Function
    ''' <summary>
    ''' Checks if the entered string matches the valid characters set. Case sensitive can be selected.
    ''' </summary>
    ''' <param name="validCharacters"></param>
    ''' <param name="text"></param>
    ''' <param name="caseSensitive"></param>
    ''' <returns></returns>
    Public Shared Function CheckValid(ByVal validCharacters As String, ByVal text As String, caseSensitive As Boolean) As Boolean
        If caseSensitive = False Then
            Return CheckValid(validCharacters.ToLower, text.ToLower)
        Else
            Return CheckValid(validCharacters, text)
        End If
    End Function
End Class
