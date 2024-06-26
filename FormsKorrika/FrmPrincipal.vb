﻿Imports Entidades
Imports GestionKorrika

Public Class FrmPrincipal
    Private Sub btnCrearKorrika_Click(sender As Object, e As EventArgs) Handles btnCrearKorrika.Click
        Dim comprobarNumeros As Integer
        If String.IsNullOrWhiteSpace(txtNumKorrika.Text) Then
            MessageBox.Show("El número de la korrika no puede quedar vacio")
            Exit Sub
        End If
        If Not Integer.TryParse(txtNumKorrika.Text, comprobarNumeros) OrElse comprobarNumeros <= 0 Then
            MessageBox.Show("El número de la korrika tiene que ser un número positivo")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtAnyo.Text) Then
            MessageBox.Show("El año de la korrika no puede quedar vacio")
            Exit Sub
        End If
        If Not Integer.TryParse(txtAnyo.Text, comprobarNumeros) OrElse comprobarNumeros <= 2000 Then
            MessageBox.Show("El año de la korrika tiene que ser un año mayor al 2000")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtEslogan.Text) Then
            MessageBox.Show("El eslogan no puede quedar vacio")
            Exit Sub
        End If
        Dim comprobarFechas As Date
        If String.IsNullOrWhiteSpace(txtFechaInicio.Text) Then
            MessageBox.Show("La fecha de inicio no puede quedar vacia")
            Exit Sub
        End If
        If Not Date.TryParse(txtFechaInicio.Text, comprobarFechas) Then
            MessageBox.Show("La fecha de inicio tiene que ser realmente una fecha")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtFechaFin.Text) Then
            MessageBox.Show("La fecha de fin no puede quedar vacia")
            Exit Sub
        End If
        If Not Date.TryParse(txtFechaFin.Text, comprobarFechas) OrElse txtFechaInicio.Text >= comprobarFechas Then
            MessageBox.Show("La fecha de fin tiene que ser realmente una fecha mayor a la de inicio")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtNumKorrika.Text) Then
            MessageBox.Show("Tiene que haber un número de kilometros")
            Exit Sub
        End If
        If Not Integer.TryParse(txtNumKorrika.Text, comprobarNumeros) OrElse comprobarNumeros <= 0 Then
            MessageBox.Show("El número de kilometros tiene que ser un número positivo")
            Exit Sub
        End If
        If korrika IsNot Nothing Then
            If MessageBox.Show($"Ya has creado una korrika {korrika.ToString}", "Atencion", MessageBoxButtons.YesNo) = DialogResult.No Then
                Exit Sub
            End If
        End If
        korrika = New Korrika(txtNumKorrika.Text, txtAnyo.Text, txtEslogan.Text, txtFechaInicio.Text, txtFechaFin.Text, txtCantKms.Text) ' todo Deberían ser las variables y llamar al de errores

    End Sub

    Private Sub DefinirKmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefinirKmToolStripMenuItem.Click, FinanciarKmToolStripMenuItem.Click
        If korrika Is Nothing Then
            MessageBox.Show("Antes debes crear una korrika")
            Exit Sub
        End If
        If sender Is DefinirKmToolStripMenuItem Then
            Dim frmDefinirKm As New FrmDefinirKms
            frmDefinirKm.Show()
        End If
        If sender Is FinanciarKmToolStripMenuItem Then
            Dim frmFinanciacion As New FrmFinanciacion
            frmFinanciacion.Show()
        End If

    End Sub


    Private Sub FinalizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalizarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class