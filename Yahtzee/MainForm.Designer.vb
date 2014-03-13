<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.picYahtzeeLogo = New System.Windows.Forms.PictureBox()
        Me.chkDice1 = New System.Windows.Forms.CheckBox()
        Me.chkDice2 = New System.Windows.Forms.CheckBox()
        Me.chkDice3 = New System.Windows.Forms.CheckBox()
        Me.chkDice4 = New System.Windows.Forms.CheckBox()
        Me.chkDice5 = New System.Windows.Forms.CheckBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblAces = New System.Windows.Forms.Label()
        Me.lblTwos = New System.Windows.Forms.Label()
        Me.lblThrees = New System.Windows.Forms.Label()
        Me.lblFours = New System.Windows.Forms.Label()
        Me.lblFives = New System.Windows.Forms.Label()
        Me.lblSixes = New System.Windows.Forms.Label()
        Me.lblChance = New System.Windows.Forms.Label()
        Me.lblLgStraight = New System.Windows.Forms.Label()
        Me.lblSmStraight = New System.Windows.Forms.Label()
        Me.lblFull = New System.Windows.Forms.Label()
        Me.lbl4Kind = New System.Windows.Forms.Label()
        Me.lbl3Kind = New System.Windows.Forms.Label()
        Me.gboScores = New System.Windows.Forms.GroupBox()
        Me.lblYahtzee = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gboControls = New System.Windows.Forms.GroupBox()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.lblName3 = New System.Windows.Forms.Label()
        Me.lblName4 = New System.Windows.Forms.Label()
        Me.ScoreTimer = New System.Windows.Forms.Timer(Me.components)
        Me.picFireworks = New System.Windows.Forms.PictureBox()
        Me.Dice5 = New YahtzeeDice.Dice()
        Me.Dice4 = New YahtzeeDice.Dice()
        Me.Dice3 = New YahtzeeDice.Dice()
        Me.Dice2 = New YahtzeeDice.Dice()
        Me.Dice1 = New YahtzeeDice.Dice()
        Me.FinalScoresUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.gboUpper = New System.Windows.Forms.GroupBox()
        Me.gboLower = New System.Windows.Forms.GroupBox()
        Me.gboUpper_TotalScore = New System.Windows.Forms.GroupBox()
        Me.gboUpper_Bonus = New System.Windows.Forms.GroupBox()
        Me.gboTotal = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblTOtal2 = New System.Windows.Forms.Label()
        CType(Me.picYahtzeeLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboScores.SuspendLayout()
        Me.gboControls.SuspendLayout()
        CType(Me.picFireworks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboUpper.SuspendLayout()
        Me.gboUpper_TotalScore.SuspendLayout()
        Me.gboUpper_Bonus.SuspendLayout()
        Me.gboTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'picYahtzeeLogo
        '
        Me.picYahtzeeLogo.BackColor = System.Drawing.Color.Transparent
        Me.picYahtzeeLogo.Image = CType(resources.GetObject("picYahtzeeLogo.Image"), System.Drawing.Image)
        Me.picYahtzeeLogo.Location = New System.Drawing.Point(12, 3)
        Me.picYahtzeeLogo.Name = "picYahtzeeLogo"
        Me.picYahtzeeLogo.Size = New System.Drawing.Size(212, 131)
        Me.picYahtzeeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYahtzeeLogo.TabIndex = 6
        Me.picYahtzeeLogo.TabStop = False
        '
        'chkDice1
        '
        Me.chkDice1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDice1.Location = New System.Drawing.Point(239, 109)
        Me.chkDice1.Name = "chkDice1"
        Me.chkDice1.Size = New System.Drawing.Size(100, 17)
        Me.chkDice1.TabIndex = 7
        Me.chkDice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDice1.UseVisualStyleBackColor = True
        '
        'chkDice2
        '
        Me.chkDice2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDice2.Location = New System.Drawing.Point(345, 109)
        Me.chkDice2.Name = "chkDice2"
        Me.chkDice2.Size = New System.Drawing.Size(100, 17)
        Me.chkDice2.TabIndex = 8
        Me.chkDice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDice2.UseVisualStyleBackColor = True
        '
        'chkDice3
        '
        Me.chkDice3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDice3.Location = New System.Drawing.Point(451, 109)
        Me.chkDice3.Name = "chkDice3"
        Me.chkDice3.Size = New System.Drawing.Size(100, 17)
        Me.chkDice3.TabIndex = 9
        Me.chkDice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDice3.UseVisualStyleBackColor = True
        '
        'chkDice4
        '
        Me.chkDice4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDice4.Location = New System.Drawing.Point(557, 109)
        Me.chkDice4.Name = "chkDice4"
        Me.chkDice4.Size = New System.Drawing.Size(100, 17)
        Me.chkDice4.TabIndex = 10
        Me.chkDice4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDice4.UseVisualStyleBackColor = True
        '
        'chkDice5
        '
        Me.chkDice5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDice5.Location = New System.Drawing.Point(663, 109)
        Me.chkDice5.Name = "chkDice5"
        Me.chkDice5.Size = New System.Drawing.Size(100, 17)
        Me.chkDice5.TabIndex = 11
        Me.chkDice5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDice5.UseVisualStyleBackColor = True
        '
        'btnRoll
        '
        Me.btnRoll.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnRoll.Location = New System.Drawing.Point(3, 556)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(230, 100)
        Me.btnRoll.TabIndex = 13
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblAces
        '
        Me.lblAces.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAces.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAces.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAces.Location = New System.Drawing.Point(9, 16)
        Me.lblAces.Name = "lblAces"
        Me.lblAces.Size = New System.Drawing.Size(103, 40)
        Me.lblAces.TabIndex = 20
        Me.lblAces.Text = "Aces"
        Me.lblAces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTwos
        '
        Me.lblTwos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTwos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTwos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTwos.Location = New System.Drawing.Point(9, 62)
        Me.lblTwos.Name = "lblTwos"
        Me.lblTwos.Size = New System.Drawing.Size(103, 40)
        Me.lblTwos.TabIndex = 21
        Me.lblTwos.Text = "Twos"
        Me.lblTwos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblThrees
        '
        Me.lblThrees.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblThrees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThrees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblThrees.Location = New System.Drawing.Point(9, 108)
        Me.lblThrees.Name = "lblThrees"
        Me.lblThrees.Size = New System.Drawing.Size(103, 40)
        Me.lblThrees.TabIndex = 22
        Me.lblThrees.Text = "Threes"
        Me.lblThrees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFours
        '
        Me.lblFours.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFours.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblFours.Location = New System.Drawing.Point(9, 154)
        Me.lblFours.Name = "lblFours"
        Me.lblFours.Size = New System.Drawing.Size(103, 40)
        Me.lblFours.TabIndex = 23
        Me.lblFours.Text = "Fours"
        Me.lblFours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFives
        '
        Me.lblFives.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFives.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFives.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblFives.Location = New System.Drawing.Point(9, 200)
        Me.lblFives.Name = "lblFives"
        Me.lblFives.Size = New System.Drawing.Size(103, 40)
        Me.lblFives.TabIndex = 24
        Me.lblFives.Text = "Fives"
        Me.lblFives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSixes
        '
        Me.lblSixes.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSixes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSixes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblSixes.Location = New System.Drawing.Point(9, 246)
        Me.lblSixes.Name = "lblSixes"
        Me.lblSixes.Size = New System.Drawing.Size(103, 40)
        Me.lblSixes.TabIndex = 25
        Me.lblSixes.Text = "Sixes"
        Me.lblSixes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChance
        '
        Me.lblChance.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblChance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChance.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblChance.Location = New System.Drawing.Point(118, 246)
        Me.lblChance.Name = "lblChance"
        Me.lblChance.Size = New System.Drawing.Size(103, 40)
        Me.lblChance.TabIndex = 37
        Me.lblChance.Text = "Chance"
        Me.lblChance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLgStraight
        '
        Me.lblLgStraight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLgStraight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLgStraight.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblLgStraight.Location = New System.Drawing.Point(118, 200)
        Me.lblLgStraight.Name = "lblLgStraight"
        Me.lblLgStraight.Size = New System.Drawing.Size(103, 40)
        Me.lblLgStraight.TabIndex = 36
        Me.lblLgStraight.Text = "Large Straight"
        Me.lblLgStraight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSmStraight
        '
        Me.lblSmStraight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSmStraight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSmStraight.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblSmStraight.Location = New System.Drawing.Point(118, 154)
        Me.lblSmStraight.Name = "lblSmStraight"
        Me.lblSmStraight.Size = New System.Drawing.Size(103, 40)
        Me.lblSmStraight.TabIndex = 35
        Me.lblSmStraight.Text = "Small Straight"
        Me.lblSmStraight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFull
        '
        Me.lblFull.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFull.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFull.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblFull.Location = New System.Drawing.Point(118, 108)
        Me.lblFull.Name = "lblFull"
        Me.lblFull.Size = New System.Drawing.Size(103, 40)
        Me.lblFull.TabIndex = 34
        Me.lblFull.Text = "Full House"
        Me.lblFull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl4Kind
        '
        Me.lbl4Kind.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl4Kind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl4Kind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl4Kind.Location = New System.Drawing.Point(118, 62)
        Me.lbl4Kind.Name = "lbl4Kind"
        Me.lbl4Kind.Size = New System.Drawing.Size(103, 40)
        Me.lbl4Kind.TabIndex = 33
        Me.lbl4Kind.Text = "4 of a Kind"
        Me.lbl4Kind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3Kind
        '
        Me.lbl3Kind.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl3Kind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl3Kind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl3Kind.Location = New System.Drawing.Point(118, 16)
        Me.lbl3Kind.Name = "lbl3Kind"
        Me.lbl3Kind.Size = New System.Drawing.Size(103, 40)
        Me.lbl3Kind.TabIndex = 32
        Me.lbl3Kind.Text = "3 of a Kind"
        Me.lbl3Kind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gboScores
        '
        Me.gboScores.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gboScores.Controls.Add(Me.lblYahtzee)
        Me.gboScores.Controls.Add(Me.lblChance)
        Me.gboScores.Controls.Add(Me.lblLgStraight)
        Me.gboScores.Controls.Add(Me.lblSmStraight)
        Me.gboScores.Controls.Add(Me.lblFull)
        Me.gboScores.Controls.Add(Me.lbl4Kind)
        Me.gboScores.Controls.Add(Me.lbl3Kind)
        Me.gboScores.Controls.Add(Me.lblSixes)
        Me.gboScores.Controls.Add(Me.lblFives)
        Me.gboScores.Controls.Add(Me.lblFours)
        Me.gboScores.Controls.Add(Me.lblThrees)
        Me.gboScores.Controls.Add(Me.lblTwos)
        Me.gboScores.Controls.Add(Me.lblAces)
        Me.gboScores.Location = New System.Drawing.Point(3, 177)
        Me.gboScores.Name = "gboScores"
        Me.gboScores.Size = New System.Drawing.Size(230, 373)
        Me.gboScores.TabIndex = 40
        Me.gboScores.TabStop = False
        Me.gboScores.Text = "Scoring"
        '
        'lblYahtzee
        '
        Me.lblYahtzee.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblYahtzee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYahtzee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblYahtzee.Location = New System.Drawing.Point(9, 286)
        Me.lblYahtzee.Name = "lblYahtzee"
        Me.lblYahtzee.Size = New System.Drawing.Size(212, 84)
        Me.lblYahtzee.TabIndex = 38
        Me.lblYahtzee.Text = "Yahtzee"
        Me.lblYahtzee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMin
        '
        Me.btnMin.Location = New System.Drawing.Point(6, 19)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(25, 25)
        Me.btnMin.TabIndex = 42
        Me.btnMin.Text = "-"
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(37, 18)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 25)
        Me.btnExit.TabIndex = 41
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gboControls
        '
        Me.gboControls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gboControls.Controls.Add(Me.btnMin)
        Me.gboControls.Controls.Add(Me.btnExit)
        Me.gboControls.Location = New System.Drawing.Point(1288, 12)
        Me.gboControls.Name = "gboControls"
        Me.gboControls.Size = New System.Drawing.Size(70, 48)
        Me.gboControls.TabIndex = 43
        Me.gboControls.TabStop = False
        Me.gboControls.Text = "Yahtzee"
        '
        'lblName1
        '
        Me.lblName1.AutoSize = True
        Me.lblName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName1.Location = New System.Drawing.Point(769, 3)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(56, 13)
        Me.lblName1.TabIndex = 44
        Me.lblName1.Text = "{Name1}"
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.Location = New System.Drawing.Point(769, 32)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(49, 13)
        Me.lblName2.TabIndex = 45
        Me.lblName2.Text = "{Name2}"
        '
        'lblName3
        '
        Me.lblName3.AutoSize = True
        Me.lblName3.Location = New System.Drawing.Point(769, 61)
        Me.lblName3.Name = "lblName3"
        Me.lblName3.Size = New System.Drawing.Size(49, 13)
        Me.lblName3.TabIndex = 46
        Me.lblName3.Text = "{Name3}"
        Me.lblName3.Visible = False
        '
        'lblName4
        '
        Me.lblName4.AutoSize = True
        Me.lblName4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.lblName4.Location = New System.Drawing.Point(769, 90)
        Me.lblName4.Name = "lblName4"
        Me.lblName4.Size = New System.Drawing.Size(49, 13)
        Me.lblName4.TabIndex = 47
        Me.lblName4.Text = "{Name4}"
        Me.lblName4.Visible = False
        '
        'ScoreTimer
        '
        Me.ScoreTimer.Enabled = True
        Me.ScoreTimer.Interval = 1
        '
        'picFireworks
        '
        Me.picFireworks.Image = CType(resources.GetObject("picFireworks.Image"), System.Drawing.Image)
        Me.picFireworks.Location = New System.Drawing.Point(239, 134)
        Me.picFireworks.Name = "picFireworks"
        Me.picFireworks.Size = New System.Drawing.Size(806, 549)
        Me.picFireworks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFireworks.TabIndex = 48
        Me.picFireworks.TabStop = False
        Me.picFireworks.Visible = False
        '
        'Dice5
        '
        Me.Dice5.BackColor = System.Drawing.Color.Transparent
        Me.Dice5.BackgroundImage = CType(resources.GetObject("Dice5.BackgroundImage"), System.Drawing.Image)
        Me.Dice5.Location = New System.Drawing.Point(663, 3)
        Me.Dice5.Name = "Dice5"
        Me.Dice5.Size = New System.Drawing.Size(100, 100)
        Me.Dice5.TabIndex = 53
        '
        'Dice4
        '
        Me.Dice4.BackColor = System.Drawing.Color.Transparent
        Me.Dice4.BackgroundImage = CType(resources.GetObject("Dice4.BackgroundImage"), System.Drawing.Image)
        Me.Dice4.Location = New System.Drawing.Point(557, 3)
        Me.Dice4.Name = "Dice4"
        Me.Dice4.Size = New System.Drawing.Size(100, 100)
        Me.Dice4.TabIndex = 52
        '
        'Dice3
        '
        Me.Dice3.BackColor = System.Drawing.Color.Transparent
        Me.Dice3.BackgroundImage = CType(resources.GetObject("Dice3.BackgroundImage"), System.Drawing.Image)
        Me.Dice3.Location = New System.Drawing.Point(451, 3)
        Me.Dice3.Name = "Dice3"
        Me.Dice3.Size = New System.Drawing.Size(100, 100)
        Me.Dice3.TabIndex = 51
        '
        'Dice2
        '
        Me.Dice2.BackColor = System.Drawing.Color.Transparent
        Me.Dice2.BackgroundImage = CType(resources.GetObject("Dice2.BackgroundImage"), System.Drawing.Image)
        Me.Dice2.Location = New System.Drawing.Point(345, 3)
        Me.Dice2.Name = "Dice2"
        Me.Dice2.Size = New System.Drawing.Size(100, 100)
        Me.Dice2.TabIndex = 50
        '
        'Dice1
        '
        Me.Dice1.BackColor = System.Drawing.Color.Transparent
        Me.Dice1.BackgroundImage = CType(resources.GetObject("Dice1.BackgroundImage"), System.Drawing.Image)
        Me.Dice1.Location = New System.Drawing.Point(239, 3)
        Me.Dice1.Name = "Dice1"
        Me.Dice1.Size = New System.Drawing.Size(100, 100)
        Me.Dice1.TabIndex = 49
        '
        'FinalScoresUpdater
        '
        Me.FinalScoresUpdater.Enabled = True
        Me.FinalScoresUpdater.Interval = 1
        '
        'gboUpper
        '
        Me.gboUpper.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gboUpper.Controls.Add(Me.gboTotal)
        Me.gboUpper.Controls.Add(Me.gboUpper_Bonus)
        Me.gboUpper.Controls.Add(Me.gboUpper_TotalScore)
        Me.gboUpper.Location = New System.Drawing.Point(12, 677)
        Me.gboUpper.Name = "gboUpper"
        Me.gboUpper.Size = New System.Drawing.Size(559, 100)
        Me.gboUpper.TabIndex = 54
        Me.gboUpper.TabStop = False
        Me.gboUpper.Text = "Upper"
        '
        'gboLower
        '
        Me.gboLower.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gboLower.Location = New System.Drawing.Point(689, 677)
        Me.gboLower.Name = "gboLower"
        Me.gboLower.Size = New System.Drawing.Size(669, 100)
        Me.gboLower.TabIndex = 55
        Me.gboLower.TabStop = False
        Me.gboLower.Text = "Lower"
        '
        'gboUpper_TotalScore
        '
        Me.gboUpper_TotalScore.Controls.Add(Me.lblTotal)
        Me.gboUpper_TotalScore.Location = New System.Drawing.Point(6, 19)
        Me.gboUpper_TotalScore.Name = "gboUpper_TotalScore"
        Me.gboUpper_TotalScore.Size = New System.Drawing.Size(176, 72)
        Me.gboUpper_TotalScore.TabIndex = 0
        Me.gboUpper_TotalScore.TabStop = False
        Me.gboUpper_TotalScore.Text = "First Total"
        '
        'gboUpper_Bonus
        '
        Me.gboUpper_Bonus.Controls.Add(Me.lblBonus)
        Me.gboUpper_Bonus.Location = New System.Drawing.Point(188, 19)
        Me.gboUpper_Bonus.Name = "gboUpper_Bonus"
        Me.gboUpper_Bonus.Size = New System.Drawing.Size(176, 72)
        Me.gboUpper_Bonus.TabIndex = 1
        Me.gboUpper_Bonus.TabStop = False
        Me.gboUpper_Bonus.Text = "Bonus"
        '
        'gboTotal
        '
        Me.gboTotal.Controls.Add(Me.lblTOtal2)
        Me.gboTotal.Location = New System.Drawing.Point(370, 19)
        Me.gboTotal.Name = "gboTotal"
        Me.gboTotal.Size = New System.Drawing.Size(176, 72)
        Me.gboTotal.TabIndex = 2
        Me.gboTotal.TabStop = False
        Me.gboTotal.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Minecraft", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(6, 16)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(164, 46)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBonus
        '
        Me.lblBonus.Font = New System.Drawing.Font("Minecraft", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonus.Location = New System.Drawing.Point(6, 16)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(164, 46)
        Me.lblBonus.TabIndex = 1
        Me.lblBonus.Text = "0"
        Me.lblBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTOtal2
        '
        Me.lblTOtal2.Font = New System.Drawing.Font("Minecraft", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTOtal2.Location = New System.Drawing.Point(12, 16)
        Me.lblTOtal2.Name = "lblTOtal2"
        Me.lblTOtal2.Size = New System.Drawing.Size(164, 46)
        Me.lblTOtal2.TabIndex = 2
        Me.lblTOtal2.Text = "0"
        Me.lblTOtal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 780)
        Me.Controls.Add(Me.gboUpper)
        Me.Controls.Add(Me.gboLower)
        Me.Controls.Add(Me.Dice5)
        Me.Controls.Add(Me.Dice4)
        Me.Controls.Add(Me.Dice3)
        Me.Controls.Add(Me.Dice2)
        Me.Controls.Add(Me.Dice1)
        Me.Controls.Add(Me.picFireworks)
        Me.Controls.Add(Me.lblName4)
        Me.Controls.Add(Me.lblName3)
        Me.Controls.Add(Me.lblName2)
        Me.Controls.Add(Me.lblName1)
        Me.Controls.Add(Me.gboControls)
        Me.Controls.Add(Me.gboScores)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.chkDice5)
        Me.Controls.Add(Me.chkDice4)
        Me.Controls.Add(Me.chkDice3)
        Me.Controls.Add(Me.chkDice2)
        Me.Controls.Add(Me.chkDice1)
        Me.Controls.Add(Me.picYahtzeeLogo)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.picYahtzeeLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboScores.ResumeLayout(False)
        Me.gboControls.ResumeLayout(False)
        CType(Me.picFireworks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboUpper.ResumeLayout(False)
        Me.gboUpper_TotalScore.ResumeLayout(False)
        Me.gboUpper_Bonus.ResumeLayout(False)
        Me.gboTotal.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picYahtzeeLogo As System.Windows.Forms.PictureBox
    Friend WithEvents chkDice1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDice2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDice3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDice4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDice5 As System.Windows.Forms.CheckBox
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents lblAces As System.Windows.Forms.Label
    Friend WithEvents lblTwos As System.Windows.Forms.Label
    Friend WithEvents lblThrees As System.Windows.Forms.Label
    Friend WithEvents lblFours As System.Windows.Forms.Label
    Friend WithEvents lblFives As System.Windows.Forms.Label
    Friend WithEvents lblSixes As System.Windows.Forms.Label
    Friend WithEvents lblChance As System.Windows.Forms.Label
    Friend WithEvents lblLgStraight As System.Windows.Forms.Label
    Friend WithEvents lblSmStraight As System.Windows.Forms.Label
    Friend WithEvents lblFull As System.Windows.Forms.Label
    Friend WithEvents lbl4Kind As System.Windows.Forms.Label
    Friend WithEvents lbl3Kind As System.Windows.Forms.Label
    Friend WithEvents gboScores As System.Windows.Forms.GroupBox
    Friend WithEvents btnMin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents gboControls As System.Windows.Forms.GroupBox
    Friend WithEvents lblName1 As System.Windows.Forms.Label
    Friend WithEvents lblName2 As System.Windows.Forms.Label
    Friend WithEvents lblName3 As System.Windows.Forms.Label
    Friend WithEvents lblName4 As System.Windows.Forms.Label
    Friend WithEvents ScoreTimer As System.Windows.Forms.Timer
    Friend WithEvents picFireworks As System.Windows.Forms.PictureBox
    Friend WithEvents lblYahtzee As System.Windows.Forms.Label
    Friend WithEvents Dice1 As YahtzeeDice.Dice
    Friend WithEvents Dice2 As YahtzeeDice.Dice
    Friend WithEvents Dice3 As YahtzeeDice.Dice
    Friend WithEvents Dice4 As YahtzeeDice.Dice
    Friend WithEvents Dice5 As YahtzeeDice.Dice
    Friend WithEvents FinalScoresUpdater As System.Windows.Forms.Timer
    Friend WithEvents gboUpper As System.Windows.Forms.GroupBox
    Friend WithEvents gboLower As System.Windows.Forms.GroupBox
    Friend WithEvents gboUpper_Bonus As System.Windows.Forms.GroupBox
    Friend WithEvents gboUpper_TotalScore As System.Windows.Forms.GroupBox
    Friend WithEvents gboTotal As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTOtal2 As System.Windows.Forms.Label
    Friend WithEvents lblBonus As System.Windows.Forms.Label
End Class
