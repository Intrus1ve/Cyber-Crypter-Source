<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaControlBox3 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.Guna2ResizeForm1 = New Guna.UI2.WinForms.Guna2ResizeForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaButton6 = New Guna.UI.WinForms.GunaButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(289, 259)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 213
        Me.PictureBox4.TabStop = False
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(32, 259)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.OnPressedDepth = 0
        Me.GunaButton1.Radius = 1
        Me.GunaButton1.Size = New System.Drawing.Size(89, 26)
        Me.GunaButton1.TabIndex = 212
        Me.GunaButton1.Text = "Browse"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(29, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 211
        Me.Label4.Text = "Select Icon : "
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GunaTextBox1.BorderSize = 0
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GunaTextBox1.Location = New System.Drawing.Point(32, 227)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Radius = 2
        Me.GunaTextBox1.SelectedText = ""
        Me.GunaTextBox1.Size = New System.Drawing.Size(297, 26)
        Me.GunaTextBox1.TabIndex = 210
        '
        'GunaButton4
        '
        Me.GunaButton4.Animated = True
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GunaButton4.Image = Nothing
        Me.GunaButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton4.ImageSize = New System.Drawing.Size(18, 18)
        Me.GunaButton4.Location = New System.Drawing.Point(32, 312)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.OnPressedDepth = 0
        Me.GunaButton4.Radius = 1
        Me.GunaButton4.Size = New System.Drawing.Size(105, 33)
        Me.GunaButton4.TabIndex = 220
        Me.GunaButton4.Text = "Settings"
        Me.GunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaControlBox3
        '
        Me.GunaControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox3.Animated = True
        Me.GunaControlBox3.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox3.AnimationSpeed = 0.03!
        Me.GunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GunaControlBox3.IconSize = 15.0!
        Me.GunaControlBox3.Location = New System.Drawing.Point(249, 12)
        Me.GunaControlBox3.Name = "GunaControlBox3"
        Me.GunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaControlBox3.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox3.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaControlBox3.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox3.TabIndex = 222
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.Animated = True
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(300, 12)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 221
        '
        'GunaButton5
        '
        Me.GunaButton5.Animated = True
        Me.GunaButton5.AnimationHoverSpeed = 0.07!
        Me.GunaButton5.AnimationSpeed = 0.03!
        Me.GunaButton5.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GunaButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GunaButton5.Image = Nothing
        Me.GunaButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton5.ImageSize = New System.Drawing.Size(18, 18)
        Me.GunaButton5.Location = New System.Drawing.Point(32, 351)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverImage = Nothing
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton5.OnPressedDepth = 0
        Me.GunaButton5.Radius = 1
        Me.GunaButton5.Size = New System.Drawing.Size(105, 33)
        Me.GunaButton5.TabIndex = 223
        Me.GunaButton5.Text = "Assembly"
        Me.GunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(529, 336)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(10, 96)
        Me.RichTextBox1.TabIndex = 225
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(583, 336)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(10, 96)
        Me.RichTextBox2.TabIndex = 226
        Me.RichTextBox2.Text = ""
        Me.RichTextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.TextBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TextBox1.BorderSize = 0
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(30, 160)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.Radius = 2
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(262, 26)
        Me.TextBox1.TabIndex = 208
        '
        'GunaButton3
        '
        Me.GunaButton3.Animated = True
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(18, 18)
        Me.GunaButton3.Location = New System.Drawing.Point(32, 437)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.OnPressedDepth = 0
        Me.GunaButton3.Radius = 1
        Me.GunaButton3.Size = New System.Drawing.Size(105, 33)
        Me.GunaButton3.TabIndex = 229
        Me.GunaButton3.Text = "Protect"
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 523)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 75)
        Me.Panel1.TabIndex = 232
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(47, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 30)
        Me.Label1.TabIndex = 232
        Me.Label1.Text = "By Signing in, You are agreeing to the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cyber Crypter terms of use and privacy po" &
    "licy."
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Timer1
        '
        Me.Timer1.Interval = 90000
        '
        'Timer2
        '
        Me.Timer2.Interval = 30000
        '
        'GunaButton2
        '
        Me.GunaButton2.Animated = True
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton2.ImageSize = New System.Drawing.Size(18, 18)
        Me.GunaButton2.Location = New System.Drawing.Point(32, 476)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.OnPressedDepth = 0
        Me.GunaButton2.Radius = 1
        Me.GunaButton2.Size = New System.Drawing.Size(105, 33)
        Me.GunaButton2.TabIndex = 237
        Me.GunaButton2.Text = "Support"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(29, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 15)
        Me.Label3.TabIndex = 238
        Me.Label3.Text = "Software Version v10.4.0 "
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GunaTextBox2.BorderSize = 0
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.Enabled = False
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.Color.White
        Me.GunaTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaTextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.GunaTextBox2.Location = New System.Drawing.Point(365, 381)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.Radius = 2
        Me.GunaTextBox2.SelectedText = ""
        Me.GunaTextBox2.Size = New System.Drawing.Size(46, 26)
        Me.GunaTextBox2.TabIndex = 239
        Me.GunaTextBox2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(29, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 15)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "Download URL : "
        '
        'GunaButton6
        '
        Me.GunaButton6.Animated = True
        Me.GunaButton6.AnimationHoverSpeed = 0.07!
        Me.GunaButton6.AnimationSpeed = 0.03!
        Me.GunaButton6.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GunaButton6.BorderColor = System.Drawing.Color.Black
        Me.GunaButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GunaButton6.Image = Nothing
        Me.GunaButton6.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton6.Location = New System.Drawing.Point(298, 160)
        Me.GunaButton6.Name = "GunaButton6"
        Me.GunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.GunaButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton6.OnHoverImage = Nothing
        Me.GunaButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton6.OnPressedDepth = 0
        Me.GunaButton6.Radius = 1
        Me.GunaButton6.Size = New System.Drawing.Size(31, 26)
        Me.GunaButton6.TabIndex = 240
        Me.GunaButton6.Text = "?"
        Me.GunaButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 430)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 87)
        Me.PictureBox1.TabIndex = 228
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(357, 600)
        Me.Controls.Add(Me.GunaButton6)
        Me.Controls.Add(Me.GunaTextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaButton3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GunaButton5)
        Me.Controls.Add(Me.GunaControlBox3)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.GunaButton4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cyber Crypter Private"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaControlBox3 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna2ResizeForm1 As Guna.UI2.WinForms.Guna2ResizeForm
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GunaButton6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
