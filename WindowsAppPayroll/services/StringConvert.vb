Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Public Class StringConvert

    Private enc As System.Text.UTF8Encoding
    Private encryptor As ICryptoTransform
    Private decryptor As ICryptoTransform

    Public Sub New()
        Dim KEY_128 As Byte() = {42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23}
        Dim IV_128 As Byte() = {234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78}
        Dim symmetricKey As RijndaelManaged = New RijndaelManaged()
        symmetricKey.Mode = CipherMode.CBC

        Me.enc = New System.Text.UTF8Encoding
        Me.encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128)
        Me.decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128)
    End Sub

    Public Function encrypt(ByVal plainText As String) As String
        Dim memoryStream As MemoryStream = New MemoryStream()
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.encryptor, CryptoStreamMode.Write)
        cryptoStream.Write(Me.enc.GetBytes(plainText), 0, plainText.Length)
        cryptoStream.FlushFinalBlock()
        Dim encryptedString As String = Convert.ToBase64String(memoryStream.ToArray())
        memoryStream.Close()
        cryptoStream.Close()
        Return encryptedString
    End Function

    Public Function decrypt(ByVal encryptedText As String) As String
        Dim cypherTextBytes As Byte() = Convert.FromBase64String(encryptedText)
        Dim memoryStream As MemoryStream = New MemoryStream(cypherTextBytes)
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.decryptor, CryptoStreamMode.Read)
        Dim plainTextBytes(cypherTextBytes.Length) As Byte
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
        memoryStream.Close()
        cryptoStream.Close()
        Return Me.enc.GetString(plainTextBytes, 0, decryptedByteCount)
    End Function



End Class
