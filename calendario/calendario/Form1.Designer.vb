<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.calendarioDate = New System.Windows.Forms.DateTimePicker()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.txtFECHA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRango = New System.Windows.Forms.TextBox()
        Me.txtiNicio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFIN = New System.Windows.Forms.TextBox()
        Me.btnCAPTURA = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FECHA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 3
        '
        'calendarioDate
        '
        Me.calendarioDate.Location = New System.Drawing.Point(83, 9)
        Me.calendarioDate.Name = "calendarioDate"
        Me.calendarioDate.Size = New System.Drawing.Size(200, 20)
        Me.calendarioDate.TabIndex = 4
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(83, 41)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 5
        '
        'txtFECHA
        '
        Me.txtFECHA.Location = New System.Drawing.Point(403, 12)
        Me.txtFECHA.Name = "txtFECHA"
        Me.txtFECHA.Size = New System.Drawing.Size(100, 20)
        Me.txtFECHA.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(346, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rango de Fecha"
        '
        'txtRango
        '
        Me.txtRango.Location = New System.Drawing.Point(349, 87)
        Me.txtRango.Name = "txtRango"
        Me.txtRango.Size = New System.Drawing.Size(154, 20)
        Me.txtRango.TabIndex = 8
        '
        'txtiNicio
        '
        Me.txtiNicio.Location = New System.Drawing.Point(349, 141)
        Me.txtiNicio.Name = "txtiNicio"
        Me.txtiNicio.Size = New System.Drawing.Size(100, 20)
        Me.txtiNicio.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(362, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "inicio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(362, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "FIN"
        '
        'txtFIN
        '
        Me.txtFIN.Location = New System.Drawing.Point(349, 190)
        Me.txtFIN.Name = "txtFIN"
        Me.txtFIN.Size = New System.Drawing.Size(100, 20)
        Me.txtFIN.TabIndex = 12
        '
        'btnCAPTURA
        '
        Me.btnCAPTURA.Location = New System.Drawing.Point(385, 254)
        Me.btnCAPTURA.Name = "btnCAPTURA"
        Me.btnCAPTURA.Size = New System.Drawing.Size(118, 36)
        Me.btnCAPTURA.TabIndex = 13
        Me.btnCAPTURA.Text = "CAPTURAR"
        Me.btnCAPTURA.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 403)
        Me.Controls.Add(Me.btnCAPTURA)
        Me.Controls.Add(Me.txtFIN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtiNicio)
        Me.Controls.Add(Me.txtRango)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFECHA)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.calendarioDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "temporizador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents calendarioDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents txtFECHA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRango As System.Windows.Forms.TextBox
    Friend WithEvents txtiNicio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFIN As System.Windows.Forms.TextBox
    Friend WithEvents btnCAPTURA As System.Windows.Forms.Button

End Class
