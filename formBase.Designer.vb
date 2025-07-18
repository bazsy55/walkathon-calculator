<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formBase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formBase))
        lblAllKM = New Label()
        btnStartKM = New Button()
        nudStartKM = New NumericUpDown()
        lblStartKM = New Label()
        pnlStartKM = New Panel()
        pnlDonations = New Panel()
        btnOtherMinus = New Button()
        btnOtherAdd = New Button()
        lblOther = New Label()
        nudOther = New NumericUpDown()
        btnReset = New Button()
        btnBit = New Button()
        lblBit = New Label()
        nudBit = New NumericUpDown()
        btnEuro = New Button()
        lblEuro = New Label()
        nudEuro = New NumericUpDown()
        btnLuckyCheck = New Button()
        lblLuckyCheck = New Label()
        nudLuckyCheck = New NumericUpDown()
        btnSLSub = New Button()
        lblSLSub = New Label()
        nudSLSub = New NumericUpDown()
        CType(nudStartKM, ComponentModel.ISupportInitialize).BeginInit()
        pnlStartKM.SuspendLayout()
        pnlDonations.SuspendLayout()
        CType(nudOther, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudBit, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudEuro, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudLuckyCheck, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSLSub, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblAllKM
        ' 
        lblAllKM.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(238))
        lblAllKM.Location = New Point(131, 33)
        lblAllKM.Name = "lblAllKM"
        lblAllKM.Size = New Size(176, 44)
        lblAllKM.TabIndex = 0
        lblAllKM.Text = "0,000 km"
        lblAllKM.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnStartKM
        ' 
        btnStartKM.Location = New Point(199, 38)
        btnStartKM.Name = "btnStartKM"
        btnStartKM.Size = New Size(75, 23)
        btnStartKM.TabIndex = 1
        btnStartKM.Text = "Beállítás"
        btnStartKM.UseVisualStyleBackColor = True
        ' 
        ' nudStartKM
        ' 
        nudStartKM.Location = New Point(73, 38)
        nudStartKM.Name = "nudStartKM"
        nudStartKM.Size = New Size(120, 23)
        nudStartKM.TabIndex = 2
        ' 
        ' lblStartKM
        ' 
        lblStartKM.Location = New Point(73, 12)
        lblStartKM.Name = "lblStartKM"
        lblStartKM.Size = New Size(201, 23)
        lblStartKM.TabIndex = 3
        lblStartKM.Text = "Induló km:"
        lblStartKM.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlStartKM
        ' 
        pnlStartKM.Controls.Add(lblStartKM)
        pnlStartKM.Controls.Add(btnStartKM)
        pnlStartKM.Controls.Add(nudStartKM)
        pnlStartKM.Location = New Point(46, 177)
        pnlStartKM.Name = "pnlStartKM"
        pnlStartKM.Size = New Size(347, 73)
        pnlStartKM.TabIndex = 4
        ' 
        ' pnlDonations
        ' 
        pnlDonations.Controls.Add(btnOtherMinus)
        pnlDonations.Controls.Add(btnOtherAdd)
        pnlDonations.Controls.Add(lblOther)
        pnlDonations.Controls.Add(nudOther)
        pnlDonations.Controls.Add(btnReset)
        pnlDonations.Controls.Add(btnBit)
        pnlDonations.Controls.Add(lblBit)
        pnlDonations.Controls.Add(nudBit)
        pnlDonations.Controls.Add(btnEuro)
        pnlDonations.Controls.Add(lblEuro)
        pnlDonations.Controls.Add(nudEuro)
        pnlDonations.Controls.Add(btnLuckyCheck)
        pnlDonations.Controls.Add(lblLuckyCheck)
        pnlDonations.Controls.Add(nudLuckyCheck)
        pnlDonations.Controls.Add(btnSLSub)
        pnlDonations.Controls.Add(lblSLSub)
        pnlDonations.Controls.Add(nudSLSub)
        pnlDonations.Location = New Point(46, 100)
        pnlDonations.Name = "pnlDonations"
        pnlDonations.Size = New Size(347, 229)
        pnlDonations.TabIndex = 5
        pnlDonations.Visible = False
        ' 
        ' btnOtherMinus
        ' 
        btnOtherMinus.Location = New Point(156, 180)
        btnOtherMinus.Name = "btnOtherMinus"
        btnOtherMinus.Size = New Size(55, 23)
        btnOtherMinus.TabIndex = 16
        btnOtherMinus.Text = "-"
        btnOtherMinus.UseVisualStyleBackColor = True
        ' 
        ' btnOtherAdd
        ' 
        btnOtherAdd.Location = New Point(95, 180)
        btnOtherAdd.Name = "btnOtherAdd"
        btnOtherAdd.Size = New Size(55, 23)
        btnOtherAdd.TabIndex = 15
        btnOtherAdd.Text = "+"
        btnOtherAdd.UseVisualStyleBackColor = True
        ' 
        ' lblOther
        ' 
        lblOther.Location = New Point(13, 154)
        lblOther.Name = "lblOther"
        lblOther.Size = New Size(137, 23)
        lblOther.TabIndex = 14
        lblOther.Text = "Egyéb (méter)"
        lblOther.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' nudOther
        ' 
        nudOther.Location = New Point(13, 180)
        nudOther.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        nudOther.Name = "nudOther"
        nudOther.Size = New Size(76, 23)
        nudOther.TabIndex = 13
        ' 
        ' btnReset
        ' 
        btnReset.ForeColor = Color.Firebrick
        btnReset.Location = New Point(255, 178)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(78, 23)
        btnReset.TabIndex = 12
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnBit
        ' 
        btnBit.Location = New Point(278, 116)
        btnBit.Name = "btnBit"
        btnBit.Size = New Size(55, 23)
        btnBit.TabIndex = 11
        btnBit.Text = "+"
        btnBit.UseVisualStyleBackColor = True
        ' 
        ' lblBit
        ' 
        lblBit.Location = New Point(196, 90)
        lblBit.Name = "lblBit"
        lblBit.Size = New Size(137, 23)
        lblBit.TabIndex = 10
        lblBit.Text = "Bit"
        lblBit.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' nudBit
        ' 
        nudBit.Location = New Point(196, 116)
        nudBit.Name = "nudBit"
        nudBit.Size = New Size(76, 23)
        nudBit.TabIndex = 9
        ' 
        ' btnEuro
        ' 
        btnEuro.Location = New Point(95, 116)
        btnEuro.Name = "btnEuro"
        btnEuro.Size = New Size(55, 23)
        btnEuro.TabIndex = 8
        btnEuro.Text = "+"
        btnEuro.UseVisualStyleBackColor = True
        ' 
        ' lblEuro
        ' 
        lblEuro.Location = New Point(13, 90)
        lblEuro.Name = "lblEuro"
        lblEuro.Size = New Size(137, 23)
        lblEuro.TabIndex = 7
        lblEuro.Text = "Euro €"
        lblEuro.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' nudEuro
        ' 
        nudEuro.Location = New Point(13, 116)
        nudEuro.Name = "nudEuro"
        nudEuro.Size = New Size(76, 23)
        nudEuro.TabIndex = 6
        ' 
        ' btnLuckyCheck
        ' 
        btnLuckyCheck.Location = New Point(278, 51)
        btnLuckyCheck.Name = "btnLuckyCheck"
        btnLuckyCheck.Size = New Size(55, 23)
        btnLuckyCheck.TabIndex = 5
        btnLuckyCheck.Text = "+"
        btnLuckyCheck.UseVisualStyleBackColor = True
        ' 
        ' lblLuckyCheck
        ' 
        lblLuckyCheck.Location = New Point(196, 25)
        lblLuckyCheck.Name = "lblLuckyCheck"
        lblLuckyCheck.Size = New Size(137, 23)
        lblLuckyCheck.TabIndex = 4
        lblLuckyCheck.Text = "StreamLoots láda"
        lblLuckyCheck.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' nudLuckyCheck
        ' 
        nudLuckyCheck.Location = New Point(196, 51)
        nudLuckyCheck.Name = "nudLuckyCheck"
        nudLuckyCheck.Size = New Size(76, 23)
        nudLuckyCheck.TabIndex = 3
        ' 
        ' btnSLSub
        ' 
        btnSLSub.Location = New Point(95, 51)
        btnSLSub.Name = "btnSLSub"
        btnSLSub.Size = New Size(55, 23)
        btnSLSub.TabIndex = 2
        btnSLSub.Text = "+"
        btnSLSub.UseVisualStyleBackColor = True
        ' 
        ' lblSLSub
        ' 
        lblSLSub.Location = New Point(13, 25)
        lblSLSub.Name = "lblSLSub"
        lblSLSub.Size = New Size(137, 23)
        lblSLSub.TabIndex = 1
        lblSLSub.Text = "StreamLoots feliratkozás"
        lblSLSub.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' nudSLSub
        ' 
        nudSLSub.Location = New Point(13, 51)
        nudSLSub.Name = "nudSLSub"
        nudSLSub.Size = New Size(76, 23)
        nudSLSub.TabIndex = 0
        ' 
        ' formBase
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(438, 355)
        Controls.Add(lblAllKM)
        Controls.Add(pnlStartKM)
        Controls.Add(pnlDonations)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "formBase"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Walkathon Calculator"
        CType(nudStartKM, ComponentModel.ISupportInitialize).EndInit()
        pnlStartKM.ResumeLayout(False)
        pnlDonations.ResumeLayout(False)
        CType(nudOther, ComponentModel.ISupportInitialize).EndInit()
        CType(nudBit, ComponentModel.ISupportInitialize).EndInit()
        CType(nudEuro, ComponentModel.ISupportInitialize).EndInit()
        CType(nudLuckyCheck, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSLSub, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblAllKM As Label
    Friend WithEvents btnStartKM As Button
    Friend WithEvents nudStartKM As NumericUpDown
    Friend WithEvents lblStartKM As Label
    Friend WithEvents pnlStartKM As Panel
    Friend WithEvents pnlDonations As Panel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnBit As Button
    Friend WithEvents lblBit As Label
    Friend WithEvents nudBit As NumericUpDown
    Friend WithEvents btnEuro As Button
    Friend WithEvents lblEuro As Label
    Friend WithEvents nudEuro As NumericUpDown
    Friend WithEvents btnLuckyCheck As Button
    Friend WithEvents lblLuckyCheck As Label
    Friend WithEvents nudLuckyCheck As NumericUpDown
    Friend WithEvents btnSLSub As Button
    Friend WithEvents lblSLSub As Label
    Friend WithEvents nudSLSub As NumericUpDown
    Friend WithEvents btnOtherAdd As Button
    Friend WithEvents lblOther As Label
    Friend WithEvents nudOther As NumericUpDown
    Friend WithEvents btnOtherMinus As Button

End Class
