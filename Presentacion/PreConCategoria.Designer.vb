<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreConCategoria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreConCategoria))
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GBoxBuscar = New System.Windows.Forms.GroupBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.RbDesc = New System.Windows.Forms.RadioButton()
        Me.RbCod = New System.Windows.Forms.RadioButton()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Modificar, Me.Eliminar})
        Me.Dg.Location = New System.Drawing.Point(18, 220)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(619, 150)
        Me.Dg.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Modificar
        '
        Me.Modificar.HeaderText = "Accion"
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseColumnTextForButtonValue = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Accion"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        '
        'GBoxBuscar
        '
        Me.GBoxBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GBoxBuscar.Controls.Add(Me.TxtBuscar)
        Me.GBoxBuscar.Controls.Add(Me.RbDesc)
        Me.GBoxBuscar.Controls.Add(Me.RbCod)
        Me.GBoxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxBuscar.Location = New System.Drawing.Point(18, 123)
        Me.GBoxBuscar.Name = "GBoxBuscar"
        Me.GBoxBuscar.Size = New System.Drawing.Size(356, 79)
        Me.GBoxBuscar.TabIndex = 14
        Me.GBoxBuscar.TabStop = False
        Me.GBoxBuscar.Text = "Buscar"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(132, 45)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(196, 22)
        Me.TxtBuscar.TabIndex = 8
        '
        'RbDesc
        '
        Me.RbDesc.AutoSize = True
        Me.RbDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDesc.Location = New System.Drawing.Point(6, 47)
        Me.RbDesc.Name = "RbDesc"
        Me.RbDesc.Size = New System.Drawing.Size(109, 20)
        Me.RbDesc.TabIndex = 1
        Me.RbDesc.Text = "Descripción"
        Me.RbDesc.UseVisualStyleBackColor = True
        '
        'RbCod
        '
        Me.RbCod.AutoSize = True
        Me.RbCod.Checked = True
        Me.RbCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbCod.Location = New System.Drawing.Point(6, 21)
        Me.RbCod.Name = "RbCod"
        Me.RbCod.Size = New System.Drawing.Size(76, 20)
        Me.RbCod.TabIndex = 0
        Me.RbCod.TabStop = True
        Me.RbCod.Text = "Código"
        Me.RbCod.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.75!)
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(564, 44)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(73, 72)
        Me.BtnSalir.TabIndex = 68
        Me.BtnSalir.Text = "SALIR"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresar.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BtnIngresar.Image = CType(resources.GetObject("BtnIngresar.Image"), System.Drawing.Image)
        Me.BtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngresar.Location = New System.Drawing.Point(18, 44)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(119, 52)
        Me.BtnIngresar.TabIndex = 69
        Me.BtnIngresar.Text = "NUEVO"
        Me.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Wheat
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(511, 28)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "CONSULTA DE CATEGORIA"
        '
        'PreConCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(649, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GBoxBuscar)
        Me.Controls.Add(Me.Dg)
        Me.Name = "PreConCategoria"
        Me.Text = "PreConCategoria"
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxBuscar.ResumeLayout(False)
        Me.GBoxBuscar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GBoxBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents RbDesc As System.Windows.Forms.RadioButton
    Friend WithEvents RbCod As System.Windows.Forms.RadioButton
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnIngresar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
End Class
