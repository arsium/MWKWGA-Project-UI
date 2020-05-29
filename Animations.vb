Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms

Public Class Animations
    <DllImport("user32.dll")>
    Private Shared Function AnimateWindow(ByVal hwnd As IntPtr, ByVal time As Integer, ByVal flags As AnimtedFlags) As Boolean
    End Function
    Public Enum AnimtedFlags
        ''' <summary>
        ''' Uses a fade effect. This flag can be used only if hwnd is a top-level window.
        ''' </summary>
        Blend = &H80000
        ''' <summary>
        ''' Makes the windows appearing from its center | Makes the windows hiding to its center
        ''' Can be used with hide flag like this: dwFlags.Center Or dwFlags.Hide.
        ''' </summary>
        Center = &H10


        ''' <summary>
        ''' Must be used with another animation (doesn't work alone). Works with Me.Hide
        ''' </summary>

        Hide = &H10000


        ''' <summary>
        ''' Makes a slide from left to right
        ''' </summary>

        SlideLTR = &H1


        ''' <summary>
        ''' Makes a slide from right to left
        ''' </summary>

        SlideRTL = &H2


        ''' <summary>
        ''' Makes a slide from top to bottom
        ''' </summary>

        SlideTTB = &H4


        ''' <summary>
        ''' Makes a slide from bottom to top
        ''' </summary>

        SlideBTT = &H8

    End Enum
    Shared Sub Animation(ByVal hWnd As IntPtr, ByVal timeDuration As Integer, ByVal Flags As AnimtedFlags, Optional ClosingFormAfterHidinAnim As Boolean = False)

        Dim k As New Thread(Sub() Ani_Sb(hWnd, timeDuration, Flags, ClosingFormAfterHidinAnim))

        k.IsBackground = True

        k.Start()

    End Sub

    Private Shared Sub Ani_Sb(ByVal hWnd As IntPtr, ByVal timeDuration As Integer, ByVal Flags As AnimtedFlags, Optional ClosingFormAfterHidinAnim As Boolean = False)

        AnimateWindow(hWnd, timeDuration, Flags)

        If ClosingFormAfterHidinAnim = True Then

            Application.Exit()

        End If

    End Sub

End Class
