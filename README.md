# MWKWGA-Project-UI 
* Want to support project ? https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=2GM9ENW842ZES&source=url
Make Winform Great Again

Main Features :

* -Native Blur Effect
* -Custom Winform
* -Native Animations

Detail Features (and how to use it) :

* -Native Blur Effect : MKWFGA.Aero.SetAero10(Me.Handle) / Must to be set in Load event / Choose Black Color to get full blur effect (others colors work but the real color to get this effect is black)

Note : MKWFGA.Aero.SetAero7(Me.Handle) must not be used.

* -Custom Winforms :

Properties :
* -Sizeable Property (enable or disable)
* -Custom BackColor
* -Custom Theme (must be selected in order to use Custom BackColor)
* -ThemeControlBox (dark or light choose depending on your UI)
* -Hide Icon
* -TextAlign : Middle , Left (adaptive with hide Icon) , right , custom
* -TextFont Property
* -Draggable Property
* -Icon Property
* -Theme : Dark / Light
* -Corrected UI Bugs
* -BorderColor(bottom lines included)
* -Hide Bottom Line
* -TextColor
* -Resize features (left , bottom ,right)
* -Draggable
* -Customizable txt
* -Hide or Show MinimizeBox
* -Hide or Show CloseBox
* -Hide or Show MaximizeBox
* -Hide or Show BottomLine
* -How to use : go to your form designer and replace "Inherits Form" by "MKWFGA.MKWFGA_Theme"

-Native Animations :

* -Blend
* -Hide
* -Center
* -SlideLTR (slide left to right)
* -SlideRTL (slide right to left)
* -SlideTTB (slide top to bottom)
* -SlideBTT (slide bottom to top)

How to use :

* If you want to start the form / control using an animation use like : MKWFGA.Animations.Animation(Me.Handle, 7000, AnimtedFlags.SlideBTT) must be set in Load Event

* If you want to close the form / control using an animation use like : MKWFGA.Animations.Animation(Me.Handle, 7000, AnimtedFlags.Hide Or AnimtedFlags.SlideBTT, True)

* If you want to hide a control using an animation use like : MKWFGA.Animations.Animation(Me.Handle, 7000, AnimtedFlags.Hide Or AnimtedFlags.SlideBTT)



MIT License

Copyright (c) [2020] [Arsium]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
