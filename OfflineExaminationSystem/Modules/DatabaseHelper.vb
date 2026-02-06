Imports MySql.Data.MySqlClient

Namespace Modules
    Module DatabaseHelper
        ' CONNECTION STRING - UPDATE THIS WITH YOUR LOCAL CREDENTIALS
        ' Ensure the database 'offline_exam_system' exists
        Private Const ConnectionString As String = "server=localhost;user id=root;password=;database=offline_exam_system"

        Public Function GetConnection() As MySqlConnection
            Dim conn As New MySqlConnection(ConnectionString)
            Return conn
        End Function

        Public Function ExecuteQuery(ByVal query As String) As DataTable
            Dim dt As New DataTable()
            Using conn As MySqlConnection = GetConnection()
                Try
                    conn.Open()
                    Using cmd As New MySqlCommand(query, conn)
                        Using adapter As New MySqlDataAdapter(cmd)
                            adapter.Fill(dt)
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message)
                End Try
            End Using
            Return dt
        End Function

        Public Function ExecuteNonQuery(ByVal query As String) As Integer
            Dim rowsAffected As Integer = 0
            Using conn As MySqlConnection = GetConnection()
                Try
                    conn.Open()
                    Using cmd As New MySqlCommand(query, conn)
                        rowsAffected = cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message)
                End Try
            End Using
            Return rowsAffected
        End Function
        
        ' Securely Execute NonQuery with Parameters
        Public Function ExecuteNonQueryParams(ByVal query As String, ByVal parameters As Dictionary(Of String, Object)) As Integer
            Dim rowsAffected As Integer = 0
            Using conn As MySqlConnection = GetConnection()
                Try
                    conn.Open()
                    Using cmd As New MySqlCommand(query, conn)
                        If parameters IsNot Nothing Then
                            For Each kvp As KeyValuePair(Of String, Object) In parameters
                                cmd.Parameters.AddWithValue(kvp.Key, kvp.Value)
                            Next
                        End If
                        rowsAffected = cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message)
                End Try
            End Using
            Return rowsAffected
        End Function

        ' Securely Execute Query with Parameters and Return DataTable
        Public Function ExecuteQueryParams(ByVal query As String, ByVal parameters As Dictionary(Of String, Object)) As DataTable
            Dim dt As New DataTable()
            Using conn As MySqlConnection = GetConnection()
                Try
                    conn.Open()
                    Using cmd As New MySqlCommand(query, conn)
                         If parameters IsNot Nothing Then
                            For Each kvp As KeyValuePair(Of String, Object) In parameters
                                cmd.Parameters.AddWithValue(kvp.Key, kvp.Value)
                            Next
                        End If
                        Using adapter As New MySqlDataAdapter(cmd)
                            adapter.Fill(dt)
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message)
                End Try
            End Using
            Return dt
        End Function
    End Module
End Namespace
