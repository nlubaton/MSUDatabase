﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomerInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCustomerInfo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextboxFN = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextboxLN = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextboxAddress = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextboxAge = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextboxIC = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BunifuMetroTextboxContact = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextboxEmail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UpdateButton = New FontAwesome.Sharp.IconButton()
        Me.BunifuMetroTextboxGender = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextboxID = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.SaveButton = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 209)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(456, 209)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 260)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(445, 260)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date of Birth:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 367)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Age:"
        '
        'BunifuMetroTextboxFN
        '
        Me.BunifuMetroTextboxFN.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxFN.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxFN.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxFN.BorderThickness = 3
        Me.BunifuMetroTextboxFN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxFN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxFN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxFN.isPassword = False
        Me.BunifuMetroTextboxFN.Location = New System.Drawing.Point(136, 196)
        Me.BunifuMetroTextboxFN.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextboxFN.Name = "BunifuMetroTextboxFN"
        Me.BunifuMetroTextboxFN.Size = New System.Drawing.Size(277, 41)
        Me.BunifuMetroTextboxFN.TabIndex = 5
        Me.BunifuMetroTextboxFN.Text = "Initial"
        Me.BunifuMetroTextboxFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextboxLN
        '
        Me.BunifuMetroTextboxLN.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxLN.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxLN.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxLN.BorderThickness = 3
        Me.BunifuMetroTextboxLN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxLN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxLN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxLN.isPassword = False
        Me.BunifuMetroTextboxLN.Location = New System.Drawing.Point(547, 196)
        Me.BunifuMetroTextboxLN.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextboxLN.Name = "BunifuMetroTextboxLN"
        Me.BunifuMetroTextboxLN.Size = New System.Drawing.Size(277, 41)
        Me.BunifuMetroTextboxLN.TabIndex = 6
        Me.BunifuMetroTextboxLN.Text = "Surname"
        Me.BunifuMetroTextboxLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextboxAddress
        '
        Me.BunifuMetroTextboxAddress.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxAddress.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxAddress.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxAddress.BorderThickness = 3
        Me.BunifuMetroTextboxAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxAddress.isPassword = False
        Me.BunifuMetroTextboxAddress.Location = New System.Drawing.Point(136, 246)
        Me.BunifuMetroTextboxAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextboxAddress.Name = "BunifuMetroTextboxAddress"
        Me.BunifuMetroTextboxAddress.Size = New System.Drawing.Size(277, 98)
        Me.BunifuMetroTextboxAddress.TabIndex = 7
        Me.BunifuMetroTextboxAddress.Text = "Address"
        Me.BunifuMetroTextboxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextboxAge
        '
        Me.BunifuMetroTextboxAge.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxAge.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxAge.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxAge.BorderThickness = 3
        Me.BunifuMetroTextboxAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxAge.isPassword = False
        Me.BunifuMetroTextboxAge.Location = New System.Drawing.Point(136, 354)
        Me.BunifuMetroTextboxAge.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextboxAge.Name = "BunifuMetroTextboxAge"
        Me.BunifuMetroTextboxAge.Size = New System.Drawing.Size(100, 41)
        Me.BunifuMetroTextboxAge.TabIndex = 8
        Me.BunifuMetroTextboxAge.Text = "Age"
        Me.BunifuMetroTextboxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(477, 367)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Gender:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(457, 159)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "IC Number:"
        '
        'BunifuMetroTextboxIC
        '
        Me.BunifuMetroTextboxIC.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxIC.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxIC.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxIC.BorderThickness = 3
        Me.BunifuMetroTextboxIC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxIC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxIC.isPassword = False
        Me.BunifuMetroTextboxIC.Location = New System.Drawing.Point(547, 146)
        Me.BunifuMetroTextboxIC.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextboxIC.Name = "BunifuMetroTextboxIC"
        Me.BunifuMetroTextboxIC.Size = New System.Drawing.Size(277, 41)
        Me.BunifuMetroTextboxIC.TabIndex = 11
        Me.BunifuMetroTextboxIC.Text = "IC"
        Me.BunifuMetroTextboxIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(547, 260)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(276, 22)
        Me.DateTimePicker1.TabIndex = 12
        '
        'BunifuMetroTextboxContact
        '
        Me.BunifuMetroTextboxContact.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxContact.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxContact.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxContact.BorderThickness = 3
        Me.BunifuMetroTextboxContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxContact.isPassword = False
        Me.BunifuMetroTextboxContact.Location = New System.Drawing.Point(136, 405)
        Me.BunifuMetroTextboxContact.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextboxContact.Name = "BunifuMetroTextboxContact"
        Me.BunifuMetroTextboxContact.Size = New System.Drawing.Size(277, 41)
        Me.BunifuMetroTextboxContact.TabIndex = 13
        Me.BunifuMetroTextboxContact.Text = "Phone"
        Me.BunifuMetroTextboxContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 416)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Contact Number:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(436, 416)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Email Address:"
        '
        'BunifuMetroTextboxEmail
        '
        Me.BunifuMetroTextboxEmail.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxEmail.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxEmail.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxEmail.BorderThickness = 3
        Me.BunifuMetroTextboxEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxEmail.isPassword = False
        Me.BunifuMetroTextboxEmail.Location = New System.Drawing.Point(547, 405)
        Me.BunifuMetroTextboxEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextboxEmail.Name = "BunifuMetroTextboxEmail"
        Me.BunifuMetroTextboxEmail.Size = New System.Drawing.Size(277, 41)
        Me.BunifuMetroTextboxEmail.TabIndex = 16
        Me.BunifuMetroTextboxEmail.Text = "Email"
        Me.BunifuMetroTextboxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(45, 103)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(192, 25)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "CUSTOMER INFO"
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Transparent
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.Color.Black
        Me.UpdateButton.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.UpdateButton.IconColor = System.Drawing.Color.Black
        Me.UpdateButton.IconSize = 16
        Me.UpdateButton.Location = New System.Drawing.Point(283, 502)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Rotation = 0R
        Me.UpdateButton.Size = New System.Drawing.Size(131, 50)
        Me.UpdateButton.TabIndex = 22
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'BunifuMetroTextboxGender
        '
        Me.BunifuMetroTextboxGender.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxGender.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxGender.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxGender.BorderThickness = 3
        Me.BunifuMetroTextboxGender.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxGender.isPassword = False
        Me.BunifuMetroTextboxGender.Location = New System.Drawing.Point(547, 354)
        Me.BunifuMetroTextboxGender.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextboxGender.Name = "BunifuMetroTextboxGender"
        Me.BunifuMetroTextboxGender.Size = New System.Drawing.Size(100, 41)
        Me.BunifuMetroTextboxGender.TabIndex = 23
        Me.BunifuMetroTextboxGender.Text = "Gender"
        Me.BunifuMetroTextboxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(76, 46)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Name:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(135, 42)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 159)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Customer ID:"
        '
        'BunifuMetroTextboxID
        '
        Me.BunifuMetroTextboxID.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxID.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxID.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxID.BorderThickness = 3
        Me.BunifuMetroTextboxID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxID.isPassword = False
        Me.BunifuMetroTextboxID.Location = New System.Drawing.Point(136, 145)
        Me.BunifuMetroTextboxID.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextboxID.Name = "BunifuMetroTextboxID"
        Me.BunifuMetroTextboxID.Size = New System.Drawing.Size(277, 41)
        Me.BunifuMetroTextboxID.TabIndex = 27
        Me.BunifuMetroTextboxID.Text = "ID"
        Me.BunifuMetroTextboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.Black
        Me.SaveButton.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.SaveButton.IconColor = System.Drawing.Color.Black
        Me.SaveButton.IconSize = 16
        Me.SaveButton.Location = New System.Drawing.Point(136, 502)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Rotation = 0R
        Me.SaveButton.Size = New System.Drawing.Size(131, 50)
        Me.SaveButton.TabIndex = 28
        Me.SaveButton.Text = "Insert New"
        Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Firebrick
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconSize = 16
        Me.IconButton1.Location = New System.Drawing.Point(693, 502)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(131, 50)
        Me.IconButton1.TabIndex = 29
        Me.IconButton1.Text = "Delete"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'FormCustomerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1128, 585)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.BunifuMetroTextboxID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BunifuMetroTextboxGender)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BunifuMetroTextboxEmail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BunifuMetroTextboxContact)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BunifuMetroTextboxIC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BunifuMetroTextboxAge)
        Me.Controls.Add(Me.BunifuMetroTextboxAddress)
        Me.Controls.Add(Me.BunifuMetroTextboxLN)
        Me.Controls.Add(Me.BunifuMetroTextboxFN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormCustomerInfo"
        Me.Text = "Customer Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuMetroTextboxFN As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextboxLN As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextboxAddress As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextboxAge As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BunifuMetroTextboxIC As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BunifuMetroTextboxContact As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BunifuMetroTextboxEmail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents UpdateButton As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuMetroTextboxGender As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BunifuMetroTextboxID As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents SaveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
