﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad

Public Class Clientes
    Private conn As New SqlConnection(ConfigurationManager.ConnectionStrings("db").ConnectionString)

    Public Function CD_BuscarPais(texto As String) As DataTable
        Dim cmd As New SqlCommand("[dbo].[Get_Departamento]", conn)
        conn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", texto)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function



    Public Sub CD_InsertarCliente(CEDatos As PersonaRegistro)
        Dim cmd As New SqlCommand("[dbo].[set_inserta_cliente]", conn)
        conn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("nombreDireccion", CEDatos.nombreDireccion)
        cmd.Parameters.AddWithValue("id_distrito", CEDatos.id_distrito)
        cmd.Parameters.AddWithValue("dni", CEDatos.dni)
        cmd.Parameters.AddWithValue("nombres", CEDatos.nombres)
        cmd.Parameters.AddWithValue("apellidos", CEDatos.apellidos)
        cmd.Parameters.AddWithValue("fecha_nacimiento", CEDatos.fecha_nacimiento)
        cmd.Parameters.AddWithValue("id_genero", CEDatos.id_genero)
        cmd.Parameters.AddWithValue("id_es", CEDatos.id_estado)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        conn.Close()
    End Sub


    Public Function CD_BuscarCliente(texto As String) As DataTable
        Dim cmd As New SqlCommand("[dbo].[Get_BuscarCliente]", conn)
        conn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", texto)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt

    End Function

    Public Function CD_ListarClientes() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("[dbo].[Get_listaPersona]", conn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function

End Class
