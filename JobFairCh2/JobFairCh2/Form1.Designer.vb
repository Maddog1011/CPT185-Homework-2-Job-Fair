<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PBFair = New System.Windows.Forms.PictureBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.Lbl2Details = New System.Windows.Forms.Label()
        Me.Lbl3Date = New System.Windows.Forms.Label()
        Me.Lbl3Location = New System.Windows.Forms.Label()
        Me.Label5Room = New System.Windows.Forms.Label()
        Me.BtnEnter = New System.Windows.Forms.Button()
        Me.BttnExit = New System.Windows.Forms.Button()
        CType(Me.PBFair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBFair
        '
        Me.PBFair.BackgroundImage = CType(resources.GetObject("PBFair.BackgroundImage"), System.Drawing.Image)
        Me.PBFair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBFair.Location = New System.Drawing.Point(224, 26)
        Me.PBFair.Name = "PBFair"
        Me.PBFair.Size = New System.Drawing.Size(164, 310)
        Me.PBFair.TabIndex = 0
        Me.PBFair.TabStop = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(9, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(209, 35)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "Tech Job Fair"
        '
        'Lbl2Details
        '
        Me.Lbl2Details.AutoSize = True
        Me.Lbl2Details.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl2Details.Location = New System.Drawing.Point(39, 62)
        Me.Lbl2Details.Name = "Lbl2Details"
        Me.Lbl2Details.Size = New System.Drawing.Size(148, 18)
        Me.Lbl2Details.TabIndex = 2
        Me.Lbl2Details.Text = "All Students Welcome"
        '
        'Lbl3Date
        '
        Me.Lbl3Date.AutoSize = True
        Me.Lbl3Date.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl3Date.Location = New System.Drawing.Point(56, 182)
        Me.Lbl3Date.Name = "Lbl3Date"
        Me.Lbl3Date.Size = New System.Drawing.Size(91, 18)
        Me.Lbl3Date.TabIndex = 3
        Me.Lbl3Date.Text = "May 6, 2016"
        '
        'Lbl3Location
        '
        Me.Lbl3Location.AutoSize = True
        Me.Lbl3Location.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl3Location.Location = New System.Drawing.Point(56, 226)
        Me.Lbl3Location.Name = "Lbl3Location"
        Me.Lbl3Location.Size = New System.Drawing.Size(154, 18)
        Me.Lbl3Location.TabIndex = 4
        Me.Lbl3Location.Text = "Located in Lochlen Hall"
        '
        'Label5Room
        '
        Me.Label5Room.AutoSize = True
        Me.Label5Room.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5Room.Location = New System.Drawing.Point(81, 254)
        Me.Label5Room.Name = "Label5Room"
        Me.Label5Room.Size = New System.Drawing.Size(75, 18)
        Me.Label5Room.TabIndex = 5
        Me.Label5Room.Text = "Room 101"
        '
        'BtnEnter
        '
        Me.BtnEnter.Enabled = False
        Me.BtnEnter.Location = New System.Drawing.Point(42, 114)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(126, 30)
        Me.BtnEnter.TabIndex = 6
        Me.BtnEnter.Text = "View Job Fair Details"
        Me.BtnEnter.UseVisualStyleBackColor = True
        '
        'BttnExit
        '
        Me.BttnExit.Location = New System.Drawing.Point(42, 308)
        Me.BttnExit.Name = "BttnExit"
        Me.BttnExit.Size = New System.Drawing.Size(126, 34)
        Me.BttnExit.TabIndex = 7
        Me.BttnExit.Text = "Exit Window"
        Me.BttnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 359)
        Me.Controls.Add(Me.BttnExit)
        Me.Controls.Add(Me.BtnEnter)
        Me.Controls.Add(Me.Label5Room)
        Me.Controls.Add(Me.Lbl3Location)
        Me.Controls.Add(Me.Lbl3Date)
        Me.Controls.Add(Me.Lbl2Details)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.PBFair)
        Me.Name = "Form1"
        CType(Me.PBFair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBFair As PictureBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents Lbl2Details As Label
    Friend WithEvents Lbl3Date As Label
    Friend WithEvents Lbl3Location As Label
    Friend WithEvents Label5Room As Label
    Friend WithEvents BtnEnter As Button
    Friend WithEvents BttnExit As Button
End Class
