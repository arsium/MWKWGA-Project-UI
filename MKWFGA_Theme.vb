Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms

Public Class MKWFGA_Theme
    Inherits Form
    'original from : https://www.youtube.com/watch?v=VQbbSdzGMss
    'Adapted and modified by Arsium based on link above

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
        Me.FormBorderStyle = bn
        Me.Controls.Add(Container_)
        Me.Controls.Add(Container_2)
        Me.Controls.Add(Container_3)
        Me.Controls.Add(Container_4)



    End Sub



    Private TextFon As Font = New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
    Property TextFont As Font
        Get
            Return TextFon
        End Get
        Set(value As Font)
            TextFon = value
        End Set
    End Property

    Private bn As FormBorderStyle = FormBorderStyle.None

    <Browsable(False), EditorBrowsable(EditorBrowsableState.Always)>
    Public Overloads Property FormBorderStyle() As FormBorderStyle
        Get
            Return bn
        End Get
        Set(ByVal value As FormBorderStyle)
            bn = value
        End Set
    End Property

    Private PVColor As Color = Color.White
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Always)>
    Public Overloads Property BackColor() As Color
        Get
            Return PVColor
        End Get
        Set(ByVal value As Color)
            PVColor = value
        End Set
    End Property


    Private ForeC As Color = Color.Black
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Always)>
    Public Overloads Property ForeColor() As Color
        Get
            Return ForeC
        End Get
        Set(ByVal value As Color)
            ForeC = value
        End Set
    End Property

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        FindForm.FormBorderStyle = FormBorderStyle.None
        ' Dock = DockStyle.Fill
        ' Container_.FlatAppearance.BorderColor = BDColor

        ' Container_.FlatAppearance =
        Container_.FlatStyle = FlatStyle.Flat
        Container_.Size = New Size(32, 32)
        Container_.Text = "X"
        Container_.Font = New Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold)
        ' Container_.BackColor = Color.FromArgb(30, 30, 30)

        Container_2.FlatStyle = FlatStyle.Flat
        Container_2.Size = New Size(32, 32)
        Container_2.Font = New Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold)
        Container_2.Text = "+"



        Container_3.FlatStyle = FlatStyle.Flat
        Container_3.Size = New Size(32, 32)
        Container_3.Font = New Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold)
        Container_3.Text = "-"
        '  Container_3.BackColor = Color.FromArgb(30, 30, 30)


        Container_4.BackColor = Color.Transparent
        Container_4.Size = New Size(32, 32)
        Container_4.SizeMode = PictureBoxSizeMode.Normal

        '



    End Sub


    ' Private g As Icon = Me.Icon

    '    Container_4.Image = Bitmap.FromHicon(Me.Icon.Handle)
    Private WithEvents Container_ As New Button
    Private WithEvents Container_2 As New Button
    Private WithEvents Container_3 As New Button
    Private WithEvents Container_4 As New PictureBox


    Private HideIc As Boolean = False
    Public Property HideIcon As Boolean
        Get
            Return HideIc
            Me.Refresh()
        End Get
        Set(ByVal value As Boolean)
            HideIc = value
            Me.Refresh()
        End Set
    End Property


    Protected Sub ClickBtnClose(sender As Object, e As EventArgs) Handles Container_.Click
        Me.Close()
    End Sub
    Protected Sub ClickBtnMaximized(sender As Object, e As EventArgs) Handles Container_2.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Protected Sub ClickBtnMinimized(sender As Object, e As EventArgs) Handles Container_3.Click
        Me.WindowState = FormWindowState.Normal
    End Sub
    Public Enum Themed
        Light = 1
        Dark = 2
        Custom = 3
    End Enum

    Public Enum ThemeControlsb
        Light = 1
        Dark = 2
    End Enum


    Public Enum LocText
        Left = 1
        Right = 2
        Middle = 3
        Custom = 4
    End Enum

    Private LocTextP As LocText = LocText.Middle

    Public Property TextPosition As LocText
        Get
            Return LocTextP

            Me.Refresh()

        End Get
        Set(ByVal value As LocText)
            LocTextP = value

            Me.Refresh()

        End Set
    End Property









    Private ThemeBtN As ThemeControlsb = ThemeControlsb.Dark

    Public Property ThemeControlBox As ThemeControlsb
        Get
            Return ThemeBtN

            Me.Refresh()

        End Get
        Set(ByVal value As ThemeControlsb)
            ThemeBtN = value

            Me.Refresh()

        End Set
    End Property





    Private themetest As Themed = Themed.Dark


    Public Property Theme As Themed
        Get
            Return themetest

            Me.Refresh()

        End Get
        Set(ByVal value As Themed)
            themetest = value

            Me.Refresh()

        End Set
    End Property






    Private BDColor As Color = Color.FromArgb(0, 122, 204)

    Public Property BorderColor() As Color
        Get
            Return BDColor
            Me.Refresh()
        End Get
        Set(ByVal value As Color)
            BDColor = value
            Me.Refresh()
        End Set
    End Property



    Private TextC As Color = Color.FromArgb(0, 122, 204)

    Public Property TextColor() As Color
        Get
            Return TextC
            Me.Refresh()
        End Get
        Set(ByVal value As Color)
            TextC = value
            Me.Refresh()
        End Set
    End Property

    Private BKColor As Color = Color.FromArgb(30, 30, 30)
    ''' <summary>
    ''' Choose "Custom Theme" To make this working !
    ''' </summary>
    ''' <returns></returns>
    ''' 
    <System.ComponentModel.Description("Choose Custom Theme To make this working")>
    Public Property FormBackColor() As Color
        Get
            Return BKColor
            Me.Refresh()
        End Get
        Set(ByVal value As Color)
            BKColor = value
            Me.Refresh()
        End Set
    End Property





    Public TextPositionCustomValue As Integer
    Public Property TextPositionCustom As Integer
        Get
            Return TextPositionCustomValue
            Me.Refresh()
        End Get
        Set(ByVal value As Integer)
            TextPositionCustomValue = value
            Me.Refresh()
        End Set
    End Property




    Private SizeableP As Boolean = True
    Public Property Sizeable As Boolean
        Get
            Return SizeableP
            Me.Refresh()
        End Get
        Set(ByVal value As Boolean)
            SizeableP = value
            Me.Refresh()
        End Set
    End Property
    Protected Overrides Sub OnInvalidated(e As InvalidateEventArgs)
        MyBase.OnInvalidated(e)
        Container_4.Image = Bitmap.FromHicon(Me.Icon.Handle)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)



        Container_.Location = New Point(Me.Width - 34, 2)
        Container_2.Location = New Point(Me.Width - 68, 2)
        Container_3.Location = New Point(Me.Width - 102, 2)
        Container_4.Location = New Point(15, 2)


        '   Container_4.Image = New Bitmap(Bitmap.FromHicon(Me.Icon.Handle))

        Container_.FlatAppearance.BorderSize = 1
        Container_2.FlatAppearance.BorderSize = 1
        Container_3.FlatAppearance.BorderSize = 1







        Container_.FlatAppearance.BorderColor = BDColor
        Container_2.FlatAppearance.BorderColor = BDColor
        Container_3.FlatAppearance.BorderColor = BDColor




        Dim MyBitmap As New Bitmap(Width, Height)

        Dim g As Graphics = Graphics.FromImage(MyBitmap)


        If HideIc = True Then
            Container_4.Visible = False
        Else
            Container_4.Visible = True
        End If

        If themetest = Themed.Dark Then

            g.Clear(Color.FromArgb(30, 30, 30))


            Container_.BackColor = Color.FromArgb(30, 30, 30)
            Container_2.BackColor = Color.FromArgb(30, 30, 30)
            Container_3.BackColor = Color.FromArgb(30, 30, 30)



            Container_.ForeColor = Color.FromArgb(254, 254, 254)
            Container_2.ForeColor = Color.FromArgb(254, 254, 254)
            Container_3.ForeColor = Color.FromArgb(254, 254, 254)


        ElseIf themetest = Themed.Light Then


            g.Clear(Color.FromArgb(254, 254, 254))

            Container_2.BackColor = Color.FromArgb(254, 254, 254)
            Container_.BackColor = Color.FromArgb(254, 254, 254)
            Container_3.BackColor = Color.FromArgb(254, 254, 254)



            Container_.ForeColor = Color.FromArgb(30, 30, 30)
            Container_2.ForeColor = Color.FromArgb(30, 30, 30)
            Container_3.ForeColor = Color.FromArgb(30, 30, 30)

        ElseIf themetest = Themed.Custom Then


            g.Clear(BKColor)

            Container_2.BackColor = BKColor
            Container_.BackColor = BKColor
            Container_3.BackColor = BKColor


        End If

        If ThemeBtN = ThemeControlsb.Dark Then


            Container_.ForeColor = Color.FromArgb(254, 254, 254)
            Container_2.ForeColor = Color.FromArgb(254, 254, 254)
            Container_3.ForeColor = Color.FromArgb(254, 254, 254)

        ElseIf ThemeBtN = ThemeControlsb.Light Then


            Container_.ForeColor = Color.FromArgb(30, 30, 30)
            Container_2.ForeColor = Color.FromArgb(30, 30, 30)
            Container_3.ForeColor = Color.FromArgb(30, 30, 30)

        End If



        g.DrawRectangle(New Pen(BDColor, 1), New Rectangle(0, 0, Width - 1, Height - 1))


        g.DrawLine(New Pen(BDColor, 1), 0, 36, Width, 36)


        g.FillRectangle(New SolidBrush(BDColor), New Rectangle(3, 3, 3, 31))

        g.FillRectangle(New SolidBrush(BDColor), New Rectangle(8, 3, 3, 31))

        'New Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular)

        ''TODO : ColorString



        If LocTextP = LocText.Middle Then

            g.DrawString(Me.Text, TextFon, New SolidBrush(TextC), Me.Width / 2 - TextRenderer.MeasureText(Me.Text, TextFon).Width / 2, 36 / 2 - TextRenderer.MeasureText(Me.Text, TextFon).Height / 2)
            ''
        ElseIf LocTextP = LocText.Left And HideIc = False Then
            g.DrawString(Me.Text, TextFon, New SolidBrush(TextC), 52, 36 / 2 - TextRenderer.MeasureText(Me.Text, TextFon).Height / 2)
            '- TextRenderer.MeasureText(Me.Text, TextFon).Width / 2

        ElseIf LocTextP = LocText.Left And HideIc = True Then
            g.DrawString(Me.Text, TextFon, New SolidBrush(TextC), 22, 36 / 2 - TextRenderer.MeasureText(Me.Text, TextFon).Height / 2)


        ElseIf LocTextP = LocText.Right Then

            g.DrawString(Me.Text, TextFon, New SolidBrush(TextC), Me.Width - 112 - TextRenderer.MeasureText(Me.Text, TextFon).Width, 36 / 2 - TextRenderer.MeasureText(Me.Text, TextFon).Height / 2)


        ElseIf LocTextP = LocText.Custom Then
            g.DrawString(Me.Text, TextFon, New SolidBrush(TextC), TextPositionCustomValue, 36 / 2 - TextRenderer.MeasureText(Me.Text, TextFon).Height / 2)

            'TextPositionCustomValue
        End If




        Dim x2 As Single = (Width / 2) + (Width / 3) + (Width / 3) - (Width / 4) + (Width / 20)


        If BTLine Then
            g.DrawLine(New Pen(BDColor, 1), Width - x2, Me.Height - 15, x2, Me.Height - 15)
        End If





        Dim DesktopIntPtr As IntPtr = GetDC(IntPtr.Zero)

        Dim azg As Graphics = Graphics.FromHdc(DesktopIntPtr)


        azg.Dispose()
        ReleaseDC(DesktopIntPtr)





        If ShowCloseBTN Then
            Container_.Show()

        Else
            Container_.Hide()
        End If

        If ShowMaximizeBTN Then
            Container_2.Show()

        Else
            Container_2.Hide()
        End If

        If ShowMinimizeBTN Then

            Container_3.Show()
        Else
            Container_3.Hide()
        End If

        e.Graphics.DrawImage(MyBitmap, 0, 0) : MyBitmap.Dispose() : g.Dispose()


        '   SHChangeNotify(&H8000000, &H0, Nothing, Nothing)

        MyBase.OnPaint(e)


    End Sub


    <DllImport("User32.dll")>
    Public Shared Function GetDC(ByVal hwnd As IntPtr) As IntPtr

    End Function
    <DllImport("User32.dll")>
    Public Shared Sub ReleaseDC(ByVal dc As IntPtr)

    End Sub


    Protected Overrides Sub OnTextChanged(e As EventArgs)

        Me.Refresh()
        MyBase.OnTextChanged(e)
    End Sub

    Private CloseBTN As Boolean = True
    Public Property ShowCloseBTN As Boolean
        Get
            Return CloseBTN
            Me.Refresh()
        End Get
        Set(ByVal value As Boolean)
            CloseBTN = value
            Me.Refresh()
        End Set
    End Property
    Private MaximizeBTN As Boolean = True
    Public Property ShowMaximizeBTN As Boolean
        Get
            Return MaximizeBTN
            Me.Refresh()
        End Get
        Set(ByVal value As Boolean)
            MaximizeBTN = value
            Me.Refresh()
        End Set
    End Property
    Private MinimizeBTN As Boolean = True
    Public Property ShowMinimizeBTN As Boolean
        Get
            Return MinimizeBTN
            Me.Refresh()
        End Get
        Set(ByVal value As Boolean)
            MinimizeBTN = value
            Me.Refresh()
        End Set
    End Property

    Private BTLine As Boolean = True
    Public Property BottomLine As Boolean
        Get
            Return BTLine
            Me.Refresh()
        End Get
        Set(ByVal value As Boolean)
            BTLine = value
            Me.Refresh()
        End Set
    End Property



    Private DragF As Boolean = True
    Public Property Draggable As Boolean
        Get
            Return DragF
            Me.Refresh()
        End Get
        Set(ByVal value As Boolean)
            DragF = value
            Me.Refresh()
        End Set
    End Property


    ''Native API adpated from  : https://github.com/RiyadPathan/DragControl/blob/master/DragControl.vb
    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal a As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        Dim p As Point = Me.PointToClient(Me.MousePosition)

        'SHChangeNotify(&H8000000, &H0, Nothing, Nothing)
        If p.Y < 36 And Draggable = True Then


            ReleaseCapture()

            SendMessage(Me.FindForm().Handle, 161, 2, 0)


        End If


        MyBase.OnMouseDown(e)
    End Sub


    Const WM_NCHITTEST As Integer = &H84


    Const HTBOTTOMRIGHT As Integer = 17

    Const HTBOTTOM As Integer = 15

    Const HTRIGHT As Integer = 11


    Const HTBOTTOMLEFT As Integer = 16

    'Const HTTOPRIGHT As Integer = 14

    Const HTLEFT As Integer = 10


    Const WM_PAINT = &HF

    Const WM_NCPAINT = &H85

    Const WM_PAINTICON = &H26

    'https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest 
    'https://social.msdn.microsoft.com/Forums/vstudio/en-US/0262637f-2448-4da2-a40c-b3232ba798bc/float-a-borderless-form-on-desktop?forum=vbgeneral
    'Second link modified By Arsium reading doc in first link
    Protected Overrides Sub WndProc(ByRef m As Message)

        Select Case m.Msg



                '   If Me.Icon.Width > 0 And Me.Icon.Height > 0 Then

               ' End If


            Case WM_NCHITTEST
                If SizeableP = True Then
                    Dim loc As New Point(m.LParam.ToInt32 And &HFFFF, m.LParam.ToInt32 >> 16)
                    loc = PointToClient(loc)


                    Dim blnRight As Boolean = (loc.X > Width - 9)


                    Dim blnBottom As Boolean = (loc.Y > Height - 9)

                    Dim blnHTLEFT As Boolean = (loc.X < Width - (Width - 9))


                    If blnRight And blnBottom Then

                        m.Result = CType(HTBOTTOMRIGHT, IntPtr)
                        Return


                    ElseIf blnHTLEFT And blnBottom Then

                        m.Result = CType(HTBOTTOMLEFT, IntPtr)
                        Return

                    ElseIf blnRight Then

                        m.Result = CType(HTRIGHT, IntPtr)
                        Return

                    ElseIf blnBottom Then

                        m.Result = CType(HTBOTTOM, IntPtr)
                        Return


                    ElseIf blnHTLEFT Then

                        m.Result = CType(HTLEFT, IntPtr)
                        Return


                    End If
                Else

                End If
        End Select

        MyBase.WndProc(m)

    End Sub









    Private Declare Function SHChangeNotify Lib "Shell32.dll" (ByVal wEventID As Long,
                                                               ByVal uFlags As Long,
                                                               ByVal dwitem1 As Long,
                                                               ByVal deitem2 As Long) As Long




End Class