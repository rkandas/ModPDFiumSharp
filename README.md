# ModPDFiumSharp
Subset of <a href="https://github.com/ArgusMagnus/PDFiumSharp">PDFiumSharp</a> repo with fixes for Page Bitmap rotation and added few additional wrapper methods. 

## Changes from original repo:
1. Updated FPDF_RenderPageBitmapWithMatrix method to Marshal the Structs into IntPtr before making the Native call
2. Added wrapper methods to return IntPtr instead of structs, FPDFBitmap_Create, FPDFBitmap_FillRect, FPDFBitmap_GetBuffer, FPDFBitmap_GetStride, FPDF_LoadPage, FPDF_PageToDevice, FPDFText_LoadPage, FPDFText_GetCharBox, FPDFText_FindStart, FPDFText_FindNext, FPDFText_GetSchCount, FPDFText_GetSchResultIndex, FPDF_GetPageSizeByIndex
