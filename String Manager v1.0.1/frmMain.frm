VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   1  '단일 고정
   Caption         =   "String Manager v1.0.1"
   ClientHeight    =   6360
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   11415
   BeginProperty Font 
      Name            =   "맑은 고딕"
      Size            =   9
      Charset         =   129
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   6360
   ScaleWidth      =   11415
   StartUpPosition =   1  '소유자 가운데
   Begin VB.Frame fraEtc 
      Caption         =   "ETC"
      Height          =   1575
      Left            =   5760
      TabIndex        =   15
      Top             =   3240
      Width           =   5535
      Begin VB.CommandButton cmdTrim 
         Caption         =   "Trim"
         Height          =   495
         Left            =   1920
         TabIndex        =   21
         Top             =   960
         Width           =   1695
      End
      Begin VB.CommandButton cmdRev 
         Caption         =   "Reverse"
         Height          =   495
         Left            =   1920
         TabIndex        =   20
         Top             =   360
         Width           =   1695
      End
      Begin VB.CommandButton cmdAsciiHex 
         Caption         =   "Hex encode"
         Height          =   495
         Left            =   3720
         TabIndex        =   19
         Top             =   960
         Width           =   1695
      End
      Begin VB.CommandButton cmdAsciiArr 
         Caption         =   "ASCII array"
         Height          =   495
         Left            =   3720
         TabIndex        =   18
         Top             =   360
         Width           =   1695
      End
      Begin VB.CommandButton cmdLower 
         Caption         =   "Lowercase"
         Height          =   495
         Left            =   120
         TabIndex        =   17
         Top             =   960
         Width           =   1695
      End
      Begin VB.CommandButton cmdUpper 
         Caption         =   "Uppercase"
         Height          =   495
         Left            =   120
         TabIndex        =   16
         Top             =   360
         Width           =   1695
      End
   End
   Begin VB.Frame fraOutput 
      Caption         =   "Output"
      Height          =   3015
      Left            =   5760
      TabIndex        =   7
      Top             =   120
      Width           =   5535
      Begin VB.TextBox txtOutput 
         Height          =   2055
         Left            =   120
         Locked          =   -1  'True
         MultiLine       =   -1  'True
         ScrollBars      =   2  '수직
         TabIndex        =   9
         Top             =   360
         Width           =   5295
      End
      Begin VB.CommandButton cmdCopy 
         Caption         =   "Copy to clipboard"
         Height          =   375
         Left            =   3240
         TabIndex        =   8
         Top             =   2520
         Width           =   2175
      End
      Begin VB.Label lblLen2 
         BackStyle       =   0  '투명
         Caption         =   "Length : 0"
         Height          =   255
         Left            =   120
         TabIndex        =   11
         Top             =   2595
         Width           =   1455
      End
      Begin VB.Label lblSize2 
         BackStyle       =   0  '투명
         Caption         =   "Size : 0"
         Height          =   255
         Left            =   1680
         TabIndex        =   10
         Top             =   2595
         Width           =   1455
      End
   End
   Begin VB.Frame fraReplace 
      Caption         =   "Replace"
      Height          =   3015
      Left            =   120
      TabIndex        =   5
      Top             =   3240
      Width           =   5535
      Begin VB.CheckBox chkUL 
         Caption         =   "Ignore case"
         Height          =   255
         Left            =   120
         TabIndex        =   14
         Top             =   2600
         Width           =   1935
      End
      Begin VB.CommandButton cmdReplace 
         Caption         =   "Replace"
         Height          =   375
         Left            =   3240
         TabIndex        =   13
         Top             =   2520
         Width           =   2175
      End
      Begin VB.TextBox txtB 
         Height          =   975
         Left            =   120
         MultiLine       =   -1  'True
         ScrollBars      =   2  '수직
         TabIndex        =   12
         Top             =   1440
         Width           =   5295
      End
      Begin VB.TextBox txtA 
         Height          =   975
         Left            =   120
         MultiLine       =   -1  'True
         ScrollBars      =   2  '수직
         TabIndex        =   6
         Top             =   360
         Width           =   5295
      End
   End
   Begin VB.Frame fraInput 
      Caption         =   "Input"
      Height          =   3015
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   5535
      Begin VB.CommandButton cmdClearInput 
         Caption         =   "Clear"
         Height          =   375
         Left            =   3240
         TabIndex        =   4
         Top             =   2520
         Width           =   2175
      End
      Begin VB.TextBox txtInput 
         Height          =   2055
         Left            =   120
         MultiLine       =   -1  'True
         ScrollBars      =   2  '수직
         TabIndex        =   1
         Top             =   360
         Width           =   5295
      End
      Begin VB.Label lblSize 
         BackStyle       =   0  '투명
         Caption         =   "Size : 0"
         Height          =   255
         Left            =   1680
         TabIndex        =   3
         Top             =   2595
         Width           =   1455
      End
      Begin VB.Label lblLen 
         BackStyle       =   0  '투명
         Caption         =   "Length : 0"
         Height          =   255
         Left            =   120
         TabIndex        =   2
         Top             =   2595
         Width           =   1455
      End
   End
   Begin VB.Label lbl 
      Alignment       =   1  '오른쪽 맞춤
      BackStyle       =   0  '투명
      Caption         =   "Made by Safflower (st4rburst@naver.com)"
      Height          =   255
      Left            =   5760
      TabIndex        =   22
      Top             =   6000
      Width           =   5535
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private Declare Function lstrlen Lib "kernel32.dll" Alias "lstrlenA" (ByVal lpString As String) As Long

Private Sub cmdAsciiArr_Click()
Dim buffer As String, i As Long
For i = 1 To Len(txtInput.Text)
    buffer = buffer & "," & Asc(Mid$(txtInput.Text, i, 1))
Next i
txtOutput.Text = Mid$(buffer, 2)
End Sub

Private Sub cmdAsciiHex_Click()
Dim buffer As String, i As Long
For i = 1 To Len(txtInput.Text)
    buffer = buffer & Right$("0" & Hex$(Asc(Mid$(txtInput.Text, i, 1))), 2)
Next i
txtOutput.Text = buffer
End Sub

Private Sub cmdCopy_Click()
On Error GoTo err
Clipboard.Clear
Clipboard.SetText txtOutput.Text
Exit Sub
err:
MsgBox "Copy to clipboard failed.", 16
End Sub

Private Sub cmdLower_Click()
txtOutput.Text = LCase(txtInput.Text)
End Sub

Private Sub cmdReplace_Click()
txtOutput.Text = Replace(txtInput.Text, txtA.Text, txtB.Text, 1, -1, IIf(chkUL.Value, vbTextCompare, vbBinaryCompare))
End Sub

Private Sub cmdRev_Click()
txtOutput.Text = StrReverse(txtInput.Text)
End Sub

Private Sub cmdTrim_Click()
txtOutput.Text = Trim$(txtInput.Text)
End Sub

Private Sub cmdUpper_Click()
txtOutput.Text = UCase$(txtInput.Text)
End Sub

Private Sub cmdClearInput_Click()
txtInput.Text = vbNullString
End Sub

Private Sub txtInput_Change()
lblLen.Caption = "Length : " & Len(txtInput.Text)
lblSize.Caption = "Size : " & lstrlen(txtInput.Text)
End Sub

Private Sub txtOutput_Change()
lblLen2.Caption = "Length : " & Len(txtOutput.Text)
lblSize2.Caption = "Size : " & lstrlen(txtOutput.Text)
End Sub
