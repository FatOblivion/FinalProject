<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeighIn
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
        Me.WeighInDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeighInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDS = New Neal_Morris_ISAT.mainDS()
        Me.grpCalc = New System.Windows.Forms.GroupBox()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.txtHr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnHRmax = New System.Windows.Forms.Button()
        Me.btnIdealBMI = New System.Windows.Forms.Button()
        Me.btnV02max = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.WeighInTableAdapter = New Neal_Morris_ISAT.mainDSTableAdapters.WeighInTableAdapter()
        Me.TableAdapterManager = New Neal_Morris_ISAT.mainDSTableAdapters.TableAdapterManager()
        Me.lblHead = New System.Windows.Forms.Label()
        CType(Me.WeighInDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.WeighInBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MainDS,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpCalc.SuspendLayout
        Me.SuspendLayout
        '
        'WeighInDataGridView
        '
        Me.WeighInDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WeighInDataGridView.AutoGenerateColumns = False
        Me.WeighInDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WeighInDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.WeighInDataGridView.DataSource = Me.WeighInBindingSource
        Me.WeighInDataGridView.Location = New System.Drawing.Point(170, 97)
        Me.WeighInDataGridView.Name = "WeighInDataGridView"
        Me.WeighInDataGridView.Size = New System.Drawing.Size(837, 220)
        Me.WeighInDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Vo2 max"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Vo2 max"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "HR max"
        Me.DataGridViewTextBoxColumn3.HeaderText = "HR max"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "HR rest"
        Me.DataGridViewTextBoxColumn4.HeaderText = "HR rest"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Weigh date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Weigh date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Bmi"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Bmi"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Bmi status"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Bmi status"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Ideal Bmi"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ideal Bmi"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "MemberID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "MemberID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'WeighInBindingSource
        '
        Me.WeighInBindingSource.DataMember = "WeighIn"
        Me.WeighInBindingSource.DataSource = Me.MainDS
        '
        'MainDS
        '
        Me.MainDS.DataSetName = "mainDS"
        Me.MainDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grpCalc
        '
        Me.grpCalc.Controls.Add(Me.btnBMI)
        Me.grpCalc.Controls.Add(Me.txtHr)
        Me.grpCalc.Controls.Add(Me.Label3)
        Me.grpCalc.Controls.Add(Me.Label2)
        Me.grpCalc.Controls.Add(Me.Label1)
        Me.grpCalc.Controls.Add(Me.txtWeight)
        Me.grpCalc.Controls.Add(Me.txtAge)
        Me.grpCalc.Controls.Add(Me.btnHRmax)
        Me.grpCalc.Controls.Add(Me.btnIdealBMI)
        Me.grpCalc.Controls.Add(Me.btnV02max)
        Me.grpCalc.Location = New System.Drawing.Point(12, 97)
        Me.grpCalc.Name = "grpCalc"
        Me.grpCalc.Size = New System.Drawing.Size(152, 279)
        Me.grpCalc.TabIndex = 6
        Me.grpCalc.TabStop = False
        Me.grpCalc.Text = "Update fitness"
        '
        'btnBMI
        '
        Me.btnBMI.Location = New System.Drawing.Point(6, 224)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(140, 43)
        Me.btnBMI.TabIndex = 13
        Me.btnBMI.Text = "Calculate current BMI"
        Me.btnBMI.UseVisualStyleBackColor = True
        '
        'txtHr
        '
        Me.txtHr.Location = New System.Drawing.Point(107, 87)
        Me.txtHr.Name = "txtHr"
        Me.txtHr.Size = New System.Drawing.Size(39, 20)
        Me.txtHr.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Resting HRRate:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Member weight:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Member Age:"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(107, 58)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(39, 20)
        Me.txtWeight.TabIndex = 8
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(107, 32)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(39, 20)
        Me.txtAge.TabIndex = 7
        '
        'btnHRmax
        '
        Me.btnHRmax.Location = New System.Drawing.Point(6, 126)
        Me.btnHRmax.Name = "btnHRmax"
        Me.btnHRmax.Size = New System.Drawing.Size(68, 43)
        Me.btnHRmax.TabIndex = 6
        Me.btnHRmax.Text = "Calculate HR max"
        Me.btnHRmax.UseVisualStyleBackColor = True
        '
        'btnIdealBMI
        '
        Me.btnIdealBMI.Location = New System.Drawing.Point(6, 175)
        Me.btnIdealBMI.Name = "btnIdealBMI"
        Me.btnIdealBMI.Size = New System.Drawing.Size(140, 43)
        Me.btnIdealBMI.TabIndex = 5
        Me.btnIdealBMI.Text = "Calculate Ideal BMI"
        Me.btnIdealBMI.UseVisualStyleBackColor = True
        '
        'btnV02max
        '
        Me.btnV02max.Location = New System.Drawing.Point(80, 126)
        Me.btnV02max.Name = "btnV02max"
        Me.btnV02max.Size = New System.Drawing.Size(66, 43)
        Me.btnV02max.TabIndex = 4
        Me.btnV02max.Text = "Calculate V02 Max"
        Me.btnV02max.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(170, 327)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(175, 49)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.Location = New System.Drawing.Point(351, 327)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(175, 49)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'WeighInTableAdapter
        '
        Me.WeighInTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LoginAuthTableAdapter = Nothing
        Me.TableAdapterManager.MemberTableAdapter = Nothing
        Me.TableAdapterManager.TrainerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Neal_Morris_ISAT.mainDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeighInTableAdapter = Me.WeighInTableAdapter
        '
        'lblHead
        '
        Me.lblHead.AutoSize = True
        Me.lblHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.Location = New System.Drawing.Point(377, 32)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(336, 33)
        Me.lblHead.TabIndex = 9
        Me.lblHead.Text = "Weigh in specifications"
        '
        'frmWeighIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 382)
        Me.Controls.Add(Me.lblHead)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpCalc)
        Me.Controls.Add(Me.WeighInDataGridView)
        Me.Name = "frmWeighIn"
        Me.Text = "frmWeighIn"
        CType(Me.WeighInDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.WeighInBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MainDS,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpCalc.ResumeLayout(false)
        Me.grpCalc.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MainDS As Neal_Morris_ISAT.mainDS
    Friend WithEvents WeighInBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WeighInTableAdapter As Neal_Morris_ISAT.mainDSTableAdapters.WeighInTableAdapter
    Friend WithEvents TableAdapterManager As Neal_Morris_ISAT.mainDSTableAdapters.TableAdapterManager
    Friend WithEvents WeighInDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpCalc As System.Windows.Forms.GroupBox
    Friend WithEvents txtHr As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents btnHRmax As System.Windows.Forms.Button
    Friend WithEvents btnIdealBMI As System.Windows.Forms.Button
    Friend WithEvents btnV02max As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnBMI As System.Windows.Forms.Button
    Friend WithEvents lblHead As System.Windows.Forms.Label
End Class
