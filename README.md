# ConsoleMusic

I used this page as a reference for defining pitches: 
https://pages.mtu.edu/~suits/notefreqs.html

This is where I figured out how to import the dll to interface with InteropServices so I could get control of the pitch the outboard speaker makes: https://www.pinvoke.net/default.aspx/kernel32.Beep

I discovered that the expoosed Console functionality wrapped InteropServices by decompiling the Console class and poking around:
https://www.c-sharpcorner.com/UploadFile/efa3cf/decompile-an-assembly-in-C-Sharp/  
