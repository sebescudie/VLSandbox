# Visual Studio Forms in VL

This is a small POC on how to load and handle Forms created with Visual Studio in VL. I tried to do as much as possible in VL, the only things that were done in VS are :

- Creation of the Form
- Creation of a function that returns the Form
- Creation of a function that returns the ColorDialog (for some reason I could not manage to do that in VL ..)

The demo is pretty simple, just open `VSForms.vl`, and a Form should pop. Check out `GetFormValues` to see how you can retrieve values from the said Form. 

## Known issues

For some reason, the Form seems to be pretty picky. If it's open and you try to tweak the patch (for try, just try to move a node inside `GetFormValues`), VL will switch to 'Hot Swapping' (little red indicator under the quad menu), and the Form will have to be closed and re-opened to be interacted with again.

## Tested with

- VS 2019
- VVVV Gamma 273