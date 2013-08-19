BlixOS
======

:: Main source code author: Suyash Srijan                                                      
:: Start date: 18th May 2010                                                                       
:: Lines of code: 10000+

This is the source code of the first version of BlixOS I wrote. It's a mess, I know. I don't have the latest source code
with me at the moment since my old external hard drive got damaged and I've been trying to recover data from that. If I 
am successful, then I'll upload the latest code as well.

The source code **WILL NOT** compile unless you do the following:

1. Install KryptonToolkit (latest version) and add a reference to ComponentFactory.Krypton.Toolkit.dll
2. Put 15 wallpapers in the Resources folder (named wall1, wall2, wall3, ... wall15) in JPG format. Alternatively, you can 
also remove the code to set/load wallpapers from Form3 and Form15
3. Put few missing button image files into the Resources folder (name/type can be found in Error list). Alternatively,
you can open Form3.Designer form and remove/comment out the ImageLarge/Image property code

This was my first attempt at creating/simulating an operating environment with my friend Kshitij. The code is licensed 
under GPL v2: http://www.gnu.org/licenses/gpl-2.0.html
