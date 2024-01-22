Imports System.Text.RegularExpressions
Imports System.Windows.Media
Imports Guna.UI2.WinForms

Public Class ValidationString
    Public Shared Function ValidateInputString(control As Object, type As DataInput) As Object()
        Dim stringInput As String = Nothing

        ' They have different properties so we have distinguish them
        Select Case True
            Case TypeOf control Is Guna2TextBox
                stringInput = TryCast(control, Guna2TextBox).Text
            Case TypeOf control Is Guna2ComboBox
                stringInput = TryCast(control, Guna2ComboBox).Text
        End Select

        stringInput = stringInput.Trim()
        If String.IsNullOrEmpty(stringInput) OrElse String.IsNullOrWhiteSpace(stringInput) Then
            control.BorderColor = System.Drawing.Color.Red
            Return {False, ""}
        End If
        control.BorderColor = System.Drawing.Color.SlateGray
        Select Case type
            Case DataInput.STRING_STRING
                If Not String.IsNullOrEmpty(stringInput) AndAlso Not String.IsNullOrWhiteSpace(stringInput) Then
                    Return {True, stringInput}
                End If
            Case DataInput.STRING_NAME
                If stringInput.Count > 1 Then
                    Dim nameString As String() = stringInput.Split(" ")
                    For i = 0 To nameString.Count - 1
                        Dim charArr As Char() = nameString(i).ToArray()
                        charArr(0) = CStr(charArr(0)).ToUpper
                        nameString(i) = String.Join("", charArr)
                    Next
                    Return {True, String.Join(" ", nameString)}
                End If
            Case DataInput.STRING_PASSWORD
                If stringInput.Count > 6 Then
                    Return {True, stringInput}
                End If
            Case DataInput.STRING_PHONE
                If Not Regex.IsMatch(stringInput, ".*[A-Za-z].*") Then
                    Return {True, stringInput}
                End If
            Case DataInput.STRING_USERNAME
                If stringInput.Count > 6 Then
                    Return {True, stringInput}
                End If
            Case DataInput.STRING_INTEGER
                If Not Regex.IsMatch(stringInput, ".*[A-Za-z].*") Then
                    Return {True, stringInput}
                End If
        End Select

        control.BorderColor = System.Drawing.Color.Red
        Return {False, ""}
    End Function
End Class


Public Enum DataInput
    STRING_STRING
    STRING_NAME
    STRING_PASSWORD
    STRING_USERNAME
    STRING_PHONE
    STRING_INTEGER
End Enum