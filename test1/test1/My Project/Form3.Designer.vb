<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.search = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.searchbar = New System.Windows.Forms.TextBox()
        Me.srcplus = New System.Windows.Forms.Button()
        Me.Lv01 = New System.Windows.Forms.ListView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.src1x = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.src1 = New System.Windows.Forms.Label()
        Me.src1p = New System.Windows.Forms.FlowLayoutPanel()
        Me.Lbpanel = New System.Windows.Forms.Panel()
        Me.L5 = New System.Windows.Forms.Label()
        Me.L4 = New System.Windows.Forms.Label()
        Me.L3 = New System.Windows.Forms.Label()
        Me.L2 = New System.Windows.Forms.Label()
        Me.L1 = New System.Windows.Forms.Label()
        Me.src2p = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.src2 = New System.Windows.Forms.Label()
        Me.src2x = New System.Windows.Forms.Button()
        Me.src3p = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.src3 = New System.Windows.Forms.Label()
        Me.src3x = New System.Windows.Forms.Button()
        Me.src4p = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.src4 = New System.Windows.Forms.Label()
        Me.src4x = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.src1p.SuspendLayout()
        Me.Lbpanel.SuspendLayout()
        Me.src2p.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.src3p.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.src4p.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(552, 12)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(83, 20)
        Me.search.TabIndex = 0
        Me.search.Text = "검색"
        Me.search.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(178, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 1
        '
        'searchbar
        '
        Me.searchbar.Location = New System.Drawing.Point(305, 12)
        Me.searchbar.Multiline = True
        Me.searchbar.Name = "searchbar"
        Me.searchbar.Size = New System.Drawing.Size(231, 20)
        Me.searchbar.TabIndex = 2
        '
        'srcplus
        '
        Me.srcplus.Location = New System.Drawing.Point(641, 12)
        Me.srcplus.Name = "srcplus"
        Me.srcplus.Size = New System.Drawing.Size(83, 20)
        Me.srcplus.TabIndex = 3
        Me.srcplus.Text = "속성추가"
        Me.srcplus.UseVisualStyleBackColor = True
        '
        'Lv01
        '
        Me.Lv01.HideSelection = False
        Me.Lv01.Location = New System.Drawing.Point(12, 95)
        Me.Lv01.Name = "Lv01"
        Me.Lv01.Size = New System.Drawing.Size(810, 262)
        Me.Lv01.TabIndex = 4
        Me.Lv01.UseCompatibleStateImageBehavior = False
        Me.Lv01.View = System.Windows.Forms.View.Details
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(743, 398)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "확인"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'src1x
        '
        Me.src1x.ForeColor = System.Drawing.Color.Red
        Me.src1x.Location = New System.Drawing.Point(67, 3)
        Me.src1x.Name = "src1x"
        Me.src1x.Size = New System.Drawing.Size(25, 23)
        Me.src1x.TabIndex = 6
        Me.src1x.Text = "X"
        Me.src1x.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.src1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(58, 23)
        Me.Panel1.TabIndex = 7
        '
        'src1
        '
        Me.src1.AutoSize = True
        Me.src1.Location = New System.Drawing.Point(3, 5)
        Me.src1.Name = "src1"
        Me.src1.Size = New System.Drawing.Size(42, 12)
        Me.src1.TabIndex = 0
        Me.src1.Text = "Label1"
        '
        'src1p
        '
        Me.src1p.Controls.Add(Me.Panel1)
        Me.src1p.Controls.Add(Me.src1x)
        Me.src1p.Location = New System.Drawing.Point(223, 48)
        Me.src1p.Name = "src1p"
        Me.src1p.Size = New System.Drawing.Size(99, 29)
        Me.src1p.TabIndex = 0
        '
        'Lbpanel
        '
        Me.Lbpanel.Controls.Add(Me.L5)
        Me.Lbpanel.Controls.Add(Me.L4)
        Me.Lbpanel.Controls.Add(Me.L3)
        Me.Lbpanel.Controls.Add(Me.L2)
        Me.Lbpanel.Controls.Add(Me.L1)
        Me.Lbpanel.Location = New System.Drawing.Point(305, 380)
        Me.Lbpanel.Name = "Lbpanel"
        Me.Lbpanel.Size = New System.Drawing.Size(200, 41)
        Me.Lbpanel.TabIndex = 6
        '
        'L5
        '
        Me.L5.AutoSize = True
        Me.L5.Location = New System.Drawing.Point(157, 13)
        Me.L5.Name = "L5"
        Me.L5.Size = New System.Drawing.Size(11, 12)
        Me.L5.TabIndex = 4
        Me.L5.Text = "5"
        '
        'L4
        '
        Me.L4.AutoSize = True
        Me.L4.Location = New System.Drawing.Point(124, 13)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(11, 12)
        Me.L4.TabIndex = 3
        Me.L4.Text = "4"
        '
        'L3
        '
        Me.L3.AutoSize = True
        Me.L3.Location = New System.Drawing.Point(92, 13)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(11, 12)
        Me.L3.TabIndex = 2
        Me.L3.Text = "3"
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Location = New System.Drawing.Point(55, 13)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(11, 12)
        Me.L2.TabIndex = 1
        Me.L2.Text = "2"
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Location = New System.Drawing.Point(26, 13)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(11, 12)
        Me.L1.TabIndex = 0
        Me.L1.Text = "1"
        '
        'src2p
        '
        Me.src2p.Controls.Add(Me.Panel2)
        Me.src2p.Controls.Add(Me.src2x)
        Me.src2p.Location = New System.Drawing.Point(333, 48)
        Me.src2p.Name = "src2p"
        Me.src2p.Size = New System.Drawing.Size(99, 29)
        Me.src2p.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.src2)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(58, 23)
        Me.Panel2.TabIndex = 7
        '
        'src2
        '
        Me.src2.AutoSize = True
        Me.src2.Location = New System.Drawing.Point(3, 5)
        Me.src2.Name = "src2"
        Me.src2.Size = New System.Drawing.Size(42, 12)
        Me.src2.TabIndex = 0
        Me.src2.Text = "Label1"
        '
        'src2x
        '
        Me.src2x.ForeColor = System.Drawing.Color.Red
        Me.src2x.Location = New System.Drawing.Point(67, 3)
        Me.src2x.Name = "src2x"
        Me.src2x.Size = New System.Drawing.Size(25, 23)
        Me.src2x.TabIndex = 6
        Me.src2x.Text = "X"
        Me.src2x.UseVisualStyleBackColor = True
        '
        'src3p
        '
        Me.src3p.Controls.Add(Me.Panel3)
        Me.src3p.Controls.Add(Me.src3x)
        Me.src3p.Location = New System.Drawing.Point(438, 48)
        Me.src3p.Name = "src3p"
        Me.src3p.Size = New System.Drawing.Size(99, 29)
        Me.src3p.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.src3)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(58, 23)
        Me.Panel3.TabIndex = 7
        '
        'src3
        '
        Me.src3.AutoSize = True
        Me.src3.Location = New System.Drawing.Point(3, 5)
        Me.src3.Name = "src3"
        Me.src3.Size = New System.Drawing.Size(42, 12)
        Me.src3.TabIndex = 0
        Me.src3.Text = "Label1"
        '
        'src3x
        '
        Me.src3x.ForeColor = System.Drawing.Color.Red
        Me.src3x.Location = New System.Drawing.Point(67, 3)
        Me.src3x.Name = "src3x"
        Me.src3x.Size = New System.Drawing.Size(25, 23)
        Me.src3x.TabIndex = 6
        Me.src3x.Text = "X"
        Me.src3x.UseVisualStyleBackColor = True
        '
        'src4p
        '
        Me.src4p.Controls.Add(Me.Panel4)
        Me.src4p.Controls.Add(Me.src4x)
        Me.src4p.Location = New System.Drawing.Point(543, 48)
        Me.src4p.Name = "src4p"
        Me.src4p.Size = New System.Drawing.Size(99, 29)
        Me.src4p.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.src4)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(58, 23)
        Me.Panel4.TabIndex = 7
        '
        'src4
        '
        Me.src4.AutoSize = True
        Me.src4.Location = New System.Drawing.Point(3, 5)
        Me.src4.Name = "src4"
        Me.src4.Size = New System.Drawing.Size(42, 12)
        Me.src4.TabIndex = 0
        Me.src4.Text = "Label1"
        '
        'src4x
        '
        Me.src4x.ForeColor = System.Drawing.Color.Red
        Me.src4x.Location = New System.Drawing.Point(67, 3)
        Me.src4x.Name = "src4x"
        Me.src4x.Size = New System.Drawing.Size(25, 23)
        Me.src4x.TabIndex = 6
        Me.src4x.Text = "X"
        Me.src4x.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 433)
        Me.Controls.Add(Me.Lbpanel)
        Me.Controls.Add(Me.src1p)
        Me.Controls.Add(Me.src4p)
        Me.Controls.Add(Me.src3p)
        Me.Controls.Add(Me.src2p)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Lv01)
        Me.Controls.Add(Me.srcplus)
        Me.Controls.Add(Me.searchbar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.search)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.src1p.ResumeLayout(False)
        Me.Lbpanel.ResumeLayout(False)
        Me.Lbpanel.PerformLayout()
        Me.src2p.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.src3p.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.src4p.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents search As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents searchbar As TextBox
    Friend WithEvents srcplus As Button
    Friend WithEvents Lv01 As ListView
    Friend WithEvents Button3 As Button
    Friend WithEvents src1x As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents src1 As Label
    Friend WithEvents src1p As FlowLayoutPanel
    Friend WithEvents Lbpanel As Panel
    Friend WithEvents L3 As Label
    Friend WithEvents L2 As Label
    Friend WithEvents L1 As Label
    Friend WithEvents L5 As Label
    Friend WithEvents L4 As Label
    Friend WithEvents src2p As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents src2 As Label
    Friend WithEvents src2x As Button
    Friend WithEvents src3p As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents src3 As Label
    Friend WithEvents src3x As Button
    Friend WithEvents src4p As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents src4 As Label
    Friend WithEvents src4x As Button
End Class
