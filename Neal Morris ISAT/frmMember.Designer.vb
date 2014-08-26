<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMember
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
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDS = New Neal_Morris_ISAT.mainDS()
        Me.MemberDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnWeighIn = New System.Windows.Forms.Button()
        Me.MemberWeighInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberTableAdapter = New Neal_Morris_ISAT.mainDSTableAdapters.MemberTableAdapter()
        Me.TableAdapterManager = New Neal_Morris_ISAT.mainDSTableAdapters.TableAdapterManager()
        Me.WeighInTableAdapter = New Neal_Morris_ISAT.mainDSTableAdapters.WeighInTableAdapter()
        Me.MainDS1 = New Neal_Morris_ISAT.mainDS()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberWeighInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "Member"
        Me.MemberBindingSource.DataSource = Me.MainDS
        '
        'MainDS
        '
        Me.MainDS.DataSetName = "mainDS"
        Me.MainDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberDataGridView
        '
        Me.MemberDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemberDataGridView.AutoGenerateColumns = False
        Me.MemberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MemberDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.MemberDataGridView.DataSource = Me.MemberBindingSource
        Me.MemberDataGridView.Location = New System.Drawing.Point(12, 86)
        Me.MemberDataGridView.Name = "MemberDataGridView"
        Me.MemberDataGridView.Size = New System.Drawing.Size(919, 227)
        Me.MemberDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Join Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Join Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Contact"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Contact"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Height(cm)"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Height(cm)"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Member Type"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Member Type"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TrainerID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TrainerID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'btnWeighIn
        '
        Me.btnWeighIn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnWeighIn.Location = New System.Drawing.Point(288, 319)
        Me.btnWeighIn.Name = "btnWeighIn"
        Me.btnWeighIn.Size = New System.Drawing.Size(134, 39)
        Me.btnWeighIn.TabIndex = 2
        Me.btnWeighIn.Text = "View latest weigh-in"
        Me.btnWeighIn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnWeighIn.UseVisualStyleBackColor = True
        '
        'MemberWeighInBindingSource
        '
        Me.MemberWeighInBindingSource.DataMember = "MemberWeighIn"
        Me.MemberWeighInBindingSource.DataSource = Me.MemberBindingSource
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LoginAuthTableAdapter = Nothing
        Me.TableAdapterManager.MemberTableAdapter = Me.MemberTableAdapter
        Me.TableAdapterManager.TrainerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Neal_Morris_ISAT.mainDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeighInTableAdapter = Nothing
        '
        'WeighInTableAdapter
        '
        Me.WeighInTableAdapter.ClearBeforeFill = True
        '
        'MainDS1
        '
        Me.MainDS1.DataSetName = "mainDS"
        Me.MainDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.Location = New System.Drawing.Point(148, 319)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(134, 39)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Location = New System.Drawing.Point(428, 319)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 39)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save changes"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDel.Location = New System.Drawing.Point(568, 319)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(134, 39)
        Me.btnDel.TabIndex = 7
        Me.btnDel.Text = "Delete Record"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(361, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 44)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Member list"
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.Location = New System.Drawing.Point(12, 319)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(130, 39)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "&Back"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 365)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnWeighIn)
        Me.Controls.Add(Me.MemberDataGridView)
        Me.Name = "frmMember"
        Me.Text = "Members"
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberWeighInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainDS As Neal_Morris_ISAT.mainDS
    Friend WithEvents MemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MemberTableAdapter As Neal_Morris_ISAT.mainDSTableAdapters.MemberTableAdapter
    Friend WithEvents TableAdapterManager As Neal_Morris_ISAT.mainDSTableAdapters.TableAdapterManager
    Friend WithEvents MemberDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnWeighIn As System.Windows.Forms.Button
    Friend WithEvents MemberWeighInBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WeighInTableAdapter As Neal_Morris_ISAT.mainDSTableAdapters.WeighInTableAdapter
    Friend WithEvents MainDS1 As Neal_Morris_ISAT.mainDS
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
