Imports System.Globalization
Imports Tarea_4___Arreglos____WF_VS.Tarea_2___Segundo_Semestre

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnEstablecer = New System.Windows.Forms.Button()
        Me.txtArregloLenght = New System.Windows.Forms.TextBox()
        Me.lblArregloLenght = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lbContactos = New System.Windows.Forms.ListBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtArreglo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(495, 125)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(201, 22)
        Me.txtFecha.TabIndex = 26
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(79, 121)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(453, 24)
        Me.label1.TabIndex = 25
        Me.label1.Text = "Fecha de Nacimiento (""dd/mm/aaaa""):"
        '
        'btnEstablecer
        '
        Me.btnEstablecer.Location = New System.Drawing.Point(575, -39)
        Me.btnEstablecer.Name = "btnEstablecer"
        Me.btnEstablecer.Size = New System.Drawing.Size(137, 38)
        Me.btnEstablecer.TabIndex = 24
        Me.btnEstablecer.Text = "Establecer"
        Me.btnEstablecer.UseVisualStyleBackColor = True
        '
        'txtArregloLenght
        '
        Me.txtArregloLenght.Location = New System.Drawing.Point(392, -31)
        Me.txtArregloLenght.Name = "txtArregloLenght"
        Me.txtArregloLenght.Size = New System.Drawing.Size(132, 22)
        Me.txtArregloLenght.TabIndex = 23
        '
        'lblArregloLenght
        '
        Me.lblArregloLenght.AutoSize = True
        Me.lblArregloLenght.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArregloLenght.Location = New System.Drawing.Point(96, -31)
        Me.lblArregloLenght.Name = "lblArregloLenght"
        Me.lblArregloLenght.Size = New System.Drawing.Size(247, 16)
        Me.lblArregloLenght.TabIndex = 22
        Me.lblArregloLenght.Text = "Número de Contactos por Agregar:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(79, 212)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(85, 25)
        Me.lblCorreo.TabIndex = 21
        Me.lblCorreo.Text = "Correo:"
        '
        'lblTelefono
        '
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(78, 164)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(126, 26)
        Me.lblTelefono.TabIndex = 20
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(78, 72)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(115, 24)
        Me.lblNombre.TabIndex = 19
        Me.lblNombre.Text = "Nombre:"
        '
        'lbContactos
        '
        Me.lbContactos.FormattingEnabled = True
        Me.lbContactos.ItemHeight = 16
        Me.lbContactos.Location = New System.Drawing.Point(88, 261)
        Me.lbContactos.Name = "lbContactos"
        Me.lbContactos.Size = New System.Drawing.Size(602, 228)
        Me.lbContactos.TabIndex = 18
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(234, 216)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(201, 22)
        Me.txtCorreo.TabIndex = 17
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(234, 168)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(201, 22)
        Me.txtTelefono.TabIndex = 16
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(234, 76)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(201, 22)
        Me.txtNombre.TabIndex = 15
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(553, 191)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(137, 38)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(571, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 38)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Establecer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtArreglo
        '
        Me.txtArreglo.Location = New System.Drawing.Point(366, 36)
        Me.txtArreglo.Name = "txtArreglo"
        Me.txtArreglo.Size = New System.Drawing.Size(132, 22)
        Me.txtArreglo.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Número de Contactos por Agregar:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 529)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtArreglo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnEstablecer)
        Me.Controls.Add(Me.txtArregloLenght)
        Me.Controls.Add(Me.lblArregloLenght)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lbContactos)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "Form1"
        Me.Text = "WF Visual Basic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtFecha As TextBox
    Private WithEvents label1 As Label
    Private WithEvents btnEstablecer As Button
    Private WithEvents txtArregloLenght As TextBox
    Private WithEvents lblArregloLenght As Label
    Private WithEvents lblCorreo As Label
    Private WithEvents lblTelefono As Label
    Private WithEvents lblNombre As Label
    Private WithEvents lbContactos As ListBox
    Private WithEvents txtCorreo As TextBox
    Private WithEvents txtTelefono As TextBox
    Private WithEvents txtNombre As TextBox
    Private WithEvents btnGuardar As Button
    Private WithEvents Button1 As Button
    Private WithEvents txtArreglo As TextBox
    Private WithEvents Label2 As Label


    Private cantidadContactos As Integer
    Private siguienteIndex As Integer = 0
    Private contactos As Contacto()

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If contactos Is Nothing Then
            MessageBox.Show("Establezca el número de contactos por agregar.")
        ElseIf siguienteIndex >= contactos.Length Then
            MessageBox.Show("La cantidad de contactos por agregar se completó.")
        Else
            Dim nuevo As Contacto = New Contacto()
            nuevo.Nombre_ = txtNombre.Text
            nuevo.Telefono_ = txtTelefono.Text
            Dim fechaNacimiento As DateTime

            If DateTime.TryParseExact(txtFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, fechaNacimiento) Then
                nuevo.FechaNacimiento_ = fechaNacimiento
            Else
                MessageBox.Show("La fecha de nacimiento debe tener el formato dd/MM/yyyy")
                Return
            End If

            nuevo.Correo_ = txtCorreo.Text
            contactos(siguienteIndex) = nuevo
            lbContactos.Items.Add(nuevo.ToString())
            siguienteIndex += 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cantidadContactos = Integer.Parse(txtArreglo.Text)
        contactos = New Contacto(cantidadContactos - 1) {}
    End Sub
End Class

