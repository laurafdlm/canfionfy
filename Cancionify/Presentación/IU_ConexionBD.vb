Public Class IU_ConexionBD
    Private Sub BotonSiguiente_Click(sender As Object, e As EventArgs) Handles BtSiguiente.Click
        IU_VentanaPrincipal.Show() ' Al dar clic sobre el botón 1 queremos que se habrá el formulario 2'
        Me.Close()  'Cuando se de clic en el botón 1 el formulario 1 debe cerrarse'
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BotonConectarBD_Click(sender As Object, e As EventArgs) Handles BotonConectarBD.Click

        Try
            BtSiguiente.Enabled = True
            LabelEstado.ForeColor = Color.Green
            LabelEstado.Text = "OK!!"
            BotonConectarBD.Enabled = False
            BotonRutaBD.Enabled = False
            Dim agente = AgenteBD.getAgente(TextBoxRuta.Text)
            Dim comprobarBaseDatos As GestorBaseDatos
            comprobarBaseDatos = New GestorBaseDatos

        Catch ex As Exception
            LabelEstado.Text = "ERROR"
            LabelEstado.ForeColor = Color.Red
            BtSiguiente.Enabled = False
            BotonConectarBD.Enabled = True
            BotonRutaBD.Enabled = True
            MessageBox.Show("Debe selecionar la base de datos de canciones valida")
        End Try





    End Sub

    Private Sub BotonRutaBD_Click(sender As Object, e As EventArgs) Handles BotonRutaBD.Click
        Try
            Dim ruta_archivo As New OpenFileDialog
            ruta_archivo.InitialDirectory = "c:\"
            ruta_archivo.Filter = "Ficheros de bases de datos (*.accdb)|*.accdb|All files(*.*)|*.*"
            If (ruta_archivo.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                TextBoxRuta.Text = ruta_archivo.FileName()
                BotonConectarBD.Enabled = True



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)

        End Try

    End Sub


End Class
