<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IU_ConexionBD
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BotonRutaBD = New System.Windows.Forms.Button()
        Me.TextBoxRuta = New System.Windows.Forms.TextBox()
        Me.BotonConectarBD = New System.Windows.Forms.Button()
        Me.BtSiguiente = New System.Windows.Forms.Button()
        Me.LabelEstado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BotonRutaBD
        '
        Me.BotonRutaBD.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotonRutaBD.ForeColor = System.Drawing.Color.Turquoise
        Me.BotonRutaBD.Location = New System.Drawing.Point(20, 29)
        Me.BotonRutaBD.Name = "BotonRutaBD"
        Me.BotonRutaBD.Size = New System.Drawing.Size(129, 33)
        Me.BotonRutaBD.TabIndex = 0
        Me.BotonRutaBD.Text = "Ruta BD"
        Me.BotonRutaBD.UseVisualStyleBackColor = False
        '
        'TextBoxRuta
        '
        Me.TextBoxRuta.BackColor = System.Drawing.Color.LightCyan
        Me.TextBoxRuta.Location = New System.Drawing.Point(212, 29)
        Me.TextBoxRuta.Multiline = True
        Me.TextBoxRuta.Name = "TextBoxRuta"
        Me.TextBoxRuta.Size = New System.Drawing.Size(347, 89)
        Me.TextBoxRuta.TabIndex = 5
        '
        'BotonConectarBD
        '
        Me.BotonConectarBD.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BotonConectarBD.ForeColor = System.Drawing.Color.Turquoise
        Me.BotonConectarBD.Location = New System.Drawing.Point(20, 138)
        Me.BotonConectarBD.Name = "BotonConectarBD"
        Me.BotonConectarBD.Size = New System.Drawing.Size(129, 36)
        Me.BotonConectarBD.TabIndex = 2
        Me.BotonConectarBD.Text = "Conectar BD"
        Me.BotonConectarBD.UseVisualStyleBackColor = False
        '
        'BtSiguiente
        '
        Me.BtSiguiente.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BtSiguiente.ForeColor = System.Drawing.Color.Turquoise
        Me.BtSiguiente.Location = New System.Drawing.Point(430, 138)
        Me.BtSiguiente.Name = "BtSiguiente"
        Me.BtSiguiente.Size = New System.Drawing.Size(129, 36)
        Me.BtSiguiente.TabIndex = 3
        Me.BtSiguiente.Text = "Siguiente"
        Me.BtSiguiente.UseVisualStyleBackColor = False
        '
        'LabelEstado
        '
        Me.LabelEstado.AutoSize = True
        Me.LabelEstado.Location = New System.Drawing.Point(193, 150)
        Me.LabelEstado.Name = "LabelEstado"
        Me.LabelEstado.Size = New System.Drawing.Size(0, 13)
        Me.LabelEstado.TabIndex = 6
        '
        'IU_ConexionBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(600, 186)
        Me.Controls.Add(Me.LabelEstado)
        Me.Controls.Add(Me.BtSiguiente)
        Me.Controls.Add(Me.BotonConectarBD)
        Me.Controls.Add(Me.TextBoxRuta)
        Me.Controls.Add(Me.BotonRutaBD)
        Me.ForeColor = System.Drawing.Color.DarkCyan
        Me.Name = "IU_ConexionBD"
        Me.Text = "Conexión a BD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BotonRutaBD As Button
    Friend WithEvents TextBoxRuta As TextBox
    Friend WithEvents BotonConectarBD As Button
    Friend WithEvents BtSiguiente As Button
    Friend WithEvents LabelEstado As Label
End Class
