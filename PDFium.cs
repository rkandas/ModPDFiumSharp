using System;
using System.Runtime.InteropServices;
using HorizonPDFAPI.Types;
using UnityEngine;

namespace HorizonPDFAPI
{
    public static class PDFium
    {
        public static bool Initialize()
        {
            try
            {
                FPDF_InitLibrary();
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message + e.StackTrace);
                return false;
            }

            return true;
        }

        #region FPDF_InitLibrary

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDF_InitLibrary();
        }

        public static void FPDF_InitLibrary()
        {
            PlatformInvoke.FPDF_InitLibrary();
        }

        #endregion

        #region FPDF_InitLibraryWithConfig

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDF_InitLibraryWithConfig(ref FPDF_LIBRARY_CONFIG config);
        }

        public static void FPDF_InitLibraryWithConfig(ref FPDF_LIBRARY_CONFIG config)
        {
            PlatformInvoke.FPDF_InitLibraryWithConfig(ref config);
        }

        #endregion

        #region FPDF_DestroyLibrary

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDF_DestroyLibrary();
        }

        public static void FPDF_DestroyLibrary()
        {
            PlatformInvoke.FPDF_DestroyLibrary();
        }

        #endregion

        #region FPDF_LoadDocument

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_DOCUMENT FPDF_LoadDocument([MarshalAs(UnmanagedType.LPStr)] string file_path,
                [MarshalAs(UnmanagedType.LPStr)] string password);
        }

        public static FPDF_DOCUMENT FPDF_LoadDocument([MarshalAs(UnmanagedType.LPStr)] string file_path,
            [MarshalAs(UnmanagedType.LPStr)] string password)
        {
            return PlatformInvoke.FPDF_LoadDocument(file_path, password);
        }

        #endregion

        #region FPDF_LoadMemDocument

        static partial class PlatformInvoke
        {
            [DllImport("pdfium", CharSet = CharSet.Ansi)]
            internal static extern FPDF_DOCUMENT FPDF_LoadMemDocument(byte[] data_buf, int size,
                [MarshalAs(UnmanagedType.LPStr)] string password);
        }

        public static FPDF_DOCUMENT FPDF_LoadMemDocument(byte[] data_buf, int size,
            [MarshalAs(UnmanagedType.LPStr)] string password)
        {
            return PlatformInvoke.FPDF_LoadMemDocument(data_buf, size, password);
        }

        #endregion

        #region FPDF_LoadCustomDocument

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_DOCUMENT FPDF_LoadCustomDocument(FPDF_FILEREAD fileRead,
                [MarshalAs(UnmanagedType.LPStr)] string password);
        }

        public static FPDF_DOCUMENT FPDF_LoadCustomDocument(FPDF_FILEREAD fileRead,
            [MarshalAs(UnmanagedType.LPStr)] string password)
        {
            return PlatformInvoke.FPDF_LoadCustomDocument(fileRead, password);
        }

        #endregion

        #region FPDF_GetFileVersion

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDF_GetFileVersion(FPDF_DOCUMENT doc, out int fileVersion);
        }

        public static bool FPDF_GetFileVersion(FPDF_DOCUMENT doc, out int fileVersion)
        {
            return PlatformInvoke.FPDF_GetFileVersion(doc, out fileVersion);
        }

        #endregion

        #region FPDF_GetLastError

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_ERR FPDF_GetLastError();
        }

        public static FPDF_ERR FPDF_GetLastError()
        {
            return PlatformInvoke.FPDF_GetLastError();
        }

        #endregion

        #region FPDF_GetDocPermissions

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern DocumentPermissions FPDF_GetDocPermissions(FPDF_DOCUMENT document);
        }

        public static DocumentPermissions FPDF_GetDocPermissions(FPDF_DOCUMENT document)
        {
            return PlatformInvoke.FPDF_GetDocPermissions(document);
        }

        #endregion

        #region FPDF_GetSecurityHandlerRevision

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDF_GetSecurityHandlerRevision(FPDF_DOCUMENT document);
        }

        public static int FPDF_GetSecurityHandlerRevision(FPDF_DOCUMENT document)
        {
            return PlatformInvoke.FPDF_GetSecurityHandlerRevision(document);
        }

        #endregion

        #region FPDF_GetPageCount

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDF_GetPageCount(FPDF_DOCUMENT document);
        }

        public static int FPDF_GetPageCount(FPDF_DOCUMENT document)
        {
            return PlatformInvoke.FPDF_GetPageCount(document);
        }

        #endregion

        #region FPDF_LoadPage

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_PAGE FPDF_LoadPage(FPDF_DOCUMENT document, int page_index);
        }

        public static FPDF_PAGE FPDF_LoadPage(FPDF_DOCUMENT document, int page_index)
        {
            return PlatformInvoke.FPDF_LoadPage(document, page_index);
        }

        #endregion

        #region FPDF_GetPageWidth

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern double FPDF_GetPageWidth(FPDF_PAGE page);
        }

        public static double FPDF_GetPageWidth(FPDF_PAGE page)
        {
            return PlatformInvoke.FPDF_GetPageWidth(page);
        }

        #endregion

        #region FPDF_GetPageHeight

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern double FPDF_GetPageHeight(FPDF_PAGE page);
        }

        public static double FPDF_GetPageHeight(FPDF_PAGE page)
        {
            return PlatformInvoke.FPDF_GetPageHeight(page);
        }

        #endregion

        #region FPDF_GetPageSizeByIndex

        private static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDF_GetPageSizeByIndex(FPDF_DOCUMENT document, int page_index,
                out double width, out double height);
        }

        public static bool FPDF_GetPageSizeByIndex(FPDF_DOCUMENT document, int page_index, out double width,
            out double height)
        {
            return PlatformInvoke.FPDF_GetPageSizeByIndex(document, page_index, out width, out height);
        }

        #endregion

        #region FPDF_RenderPageBitmap

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDF_RenderPageBitmap(FPDF_BITMAP bitmap, FPDF_PAGE page, int start_x,
                int start_y, int size_x, int size_y, PageOrientations rotation, RenderingFlags flags);
        }

        public static void FPDF_RenderPageBitmap(FPDF_BITMAP bitmap, FPDF_PAGE page, int start_x, int start_y,
            int size_x, int size_y, PageOrientations rotation, RenderingFlags flags)
        {
            PlatformInvoke.FPDF_RenderPageBitmap(bitmap, page, start_x, start_y, size_x, size_y, rotation, flags);
        }

        #endregion

        #region FPDF_RenderPageBitmapWithMatrix

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDF_RenderPageBitmapWithMatrix(IntPtr bitmap, IntPtr page,
                IntPtr matrix,
                IntPtr clipping, int flags);
        }

        public static void FPDF_RenderPageBitmapWithMatrix(FPDF_BITMAP bitmap, FPDF_PAGE page,
            [MarshalAs(UnmanagedType.LPStruct)] FS_MATRIX matrix, [MarshalAs(UnmanagedType.LPStruct)] FS_RECTF clipping,
            RenderingFlags flags)
        {
            IntPtr matrixPtr = Marshal.AllocHGlobal(Marshal.SizeOf(matrix));
            Marshal.StructureToPtr(matrix, matrixPtr, false);
            IntPtr clipPtr = Marshal.AllocHGlobal(Marshal.SizeOf(clipping));
            Marshal.StructureToPtr(clipping, clipPtr, false);
            PlatformInvoke.FPDF_RenderPageBitmapWithMatrix(bitmap.Instance, page.Instance,  matrixPtr, clipPtr, (int)flags);
        }


        #endregion

        #region FPDF_ClosePage

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDF_ClosePage(FPDF_PAGE page);
        }

        public static void FPDF_ClosePage(FPDF_PAGE page)
        {
            PlatformInvoke.FPDF_ClosePage(page);
        }

        #endregion

        #region FPDF_CloseDocument

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDF_CloseDocument(FPDF_DOCUMENT document);
        }

        public static void FPDF_CloseDocument(FPDF_DOCUMENT document)
        {
            PlatformInvoke.FPDF_CloseDocument(document);
        }

        #endregion

        #region FPDF_DeviceToPage

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDF_DeviceToPage(FPDF_PAGE page, int start_x, int start_y, int size_x,
                int size_y, PageOrientations rotate, int device_x, int device_y, out double page_x, out double page_y);
        }

        public static void FPDF_DeviceToPage(FPDF_PAGE page, int start_x, int start_y, int size_x, int size_y,
            PageOrientations rotate, int device_x, int device_y, out double page_x, out double page_y)
        {
            PlatformInvoke.FPDF_DeviceToPage(page, start_x, start_y, size_x, size_y, rotate, device_x, device_y,
                out page_x, out page_y);
        }

        #endregion

        #region FPDF_PageToDevice

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDF_PageToDevice(FPDF_PAGE page, int start_x, int start_y, int size_x,
                int size_y, PageOrientations rotate, double page_x, double page_y, out int device_x, out int device_y);
        }

        public static void FPDF_PageToDevice(FPDF_PAGE page, int start_x, int start_y, int size_x, int size_y,
            PageOrientations rotate, double page_x, double page_y, out int device_x, out int device_y)
        {
            PlatformInvoke.FPDF_PageToDevice(page, start_x, start_y, size_x, size_y, rotate, page_x, page_y,
                out device_x, out device_y);
        }

        #endregion

        #region FPDFBitmap_CreateEx

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_BITMAP FPDFBitmap_CreateEx(int width, int height, BitmapFormats format,
                IntPtr first_scan, int stride);
        }

        public static FPDF_BITMAP FPDFBitmap_CreateEx(int width, int height, BitmapFormats format, IntPtr first_scan,
            int stride)
        {
            return PlatformInvoke.FPDFBitmap_CreateEx(width, height, format, first_scan, stride);
        }

        #endregion

        #region FPDFBitmap_FillRect

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFBitmap_FillRect(FPDF_BITMAP bitmap, int left, int top, int width,
                int height, FPDF_COLOR color);
        }

        public static void FPDFBitmap_FillRect(FPDF_BITMAP bitmap, int left, int top, int width, int height,
            FPDF_COLOR color)
        {
            PlatformInvoke.FPDFBitmap_FillRect(bitmap, left, top, width, height, color);
        }

        #endregion

        #region FPDFBitmap_GetBuffer

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern IntPtr FPDFBitmap_GetBuffer(FPDF_BITMAP bitmap);
        }

        public static IntPtr FPDFBitmap_GetBuffer(FPDF_BITMAP bitmap)
        {
            return PlatformInvoke.FPDFBitmap_GetBuffer(bitmap);
        }

        #endregion

        #region FPDFBitmap_GetWidth

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFBitmap_GetWidth(FPDF_BITMAP bitmap);
        }

        public static int FPDFBitmap_GetWidth(FPDF_BITMAP bitmap)
        {
            return PlatformInvoke.FPDFBitmap_GetWidth(bitmap);
        }

        #endregion

        #region FPDFBitmap_GetHeight

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFBitmap_GetHeight(FPDF_BITMAP bitmap);
        }

        public static int FPDFBitmap_GetHeight(FPDF_BITMAP bitmap)
        {
            return PlatformInvoke.FPDFBitmap_GetHeight(bitmap);
        }

        #endregion

        #region FPDFBitmap_GetStride

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFBitmap_GetStride(FPDF_BITMAP bitmap);
        }

        public static int FPDFBitmap_GetStride(FPDF_BITMAP bitmap)
        {
            return PlatformInvoke.FPDFBitmap_GetStride(bitmap);
        }

        #endregion

        #region FPDFBitmap_Destroy

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFBitmap_Destroy(FPDF_BITMAP bitmap);
        }

        public static void FPDFBitmap_Destroy(FPDF_BITMAP bitmap)
        {
            PlatformInvoke.FPDFBitmap_Destroy(bitmap);
        }

        #endregion

        #region FPDF_VIEWERREF_GetPrintScaling

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDF_VIEWERREF_GetPrintScaling(FPDF_DOCUMENT document);
        }

        public static bool FPDF_VIEWERREF_GetPrintScaling(FPDF_DOCUMENT document)
        {
            return PlatformInvoke.FPDF_VIEWERREF_GetPrintScaling(document);
        }

        #endregion

        #region FPDF_VIEWERREF_GetNumCopies

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDF_VIEWERREF_GetNumCopies(FPDF_DOCUMENT document);
        }

        public static int FPDF_VIEWERREF_GetNumCopies(FPDF_DOCUMENT document)
        {
            return PlatformInvoke.FPDF_VIEWERREF_GetNumCopies(document);
        }

        #endregion

        #region FPDF_VIEWERREF_GetPrintPageRange

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_PAGERANGE FPDF_VIEWERREF_GetPrintPageRange(FPDF_DOCUMENT document);
        }

        public static FPDF_PAGERANGE FPDF_VIEWERREF_GetPrintPageRange(FPDF_DOCUMENT document)
        {
            return PlatformInvoke.FPDF_VIEWERREF_GetPrintPageRange(document);
        }

        #endregion

        #region FPDF_VIEWERREF_GetDuplex

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern DuplexTypes FPDF_VIEWERREF_GetDuplex(FPDF_DOCUMENT document);
        }

        public static DuplexTypes FPDF_VIEWERREF_GetDuplex(FPDF_DOCUMENT document)
        {
            return PlatformInvoke.FPDF_VIEWERREF_GetDuplex(document);
        }

        #endregion

        #region FPDF_VIEWERREF_GetName

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern uint FPDF_VIEWERREF_GetName(FPDF_DOCUMENT document,
                [MarshalAs(UnmanagedType.LPStr)] string key, ref byte buffer, uint length);
        }

        private static uint FPDF_VIEWERREF_GetName(FPDF_DOCUMENT document, [MarshalAs(UnmanagedType.LPStr)] string key,
            ref byte buffer, uint length)
        {
            return PlatformInvoke.FPDF_VIEWERREF_GetName(document, key, ref buffer, length);
        }

        #endregion

        #region FPDF_CountNamedDests

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDF_CountNamedDests(FPDF_DOCUMENT document);
        }

        public static int FPDF_CountNamedDests(FPDF_DOCUMENT document)
        {
            return PlatformInvoke.FPDF_CountNamedDests(document);
        }

        #endregion

        #region FPDF_GetNamedDestByName

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_DEST FPDF_GetNamedDestByName(FPDF_DOCUMENT document,
                [MarshalAs(UnmanagedType.LPStr)] string name);
        }

        public static FPDF_DEST FPDF_GetNamedDestByName(FPDF_DOCUMENT document,
            [MarshalAs(UnmanagedType.LPStr)] string name)
        {
            return PlatformInvoke.FPDF_GetNamedDestByName(document, name);
        }

        #endregion

        #region FPDF_GetNamedDest

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_DEST FPDF_GetNamedDest(FPDF_DOCUMENT document, int index, IntPtr buffer,
                out int buflen);
        }

        private static FPDF_DEST FPDF_GetNamedDest(FPDF_DOCUMENT document, int index, IntPtr buffer, out int buflen)
        {
            return PlatformInvoke.FPDF_GetNamedDest(document, index, buffer, out buflen);
        }

        #endregion

        #region FPDF_GetNamedDest

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_DEST FPDF_GetNamedDest(FPDF_DOCUMENT document, int index, ref byte buffer,
                ref int buflen);
        }

        private static FPDF_DEST FPDF_GetNamedDest(FPDF_DOCUMENT document, int index, ref byte buffer, ref int buflen)
        {
            return PlatformInvoke.FPDF_GetNamedDest(document, index, ref buffer, ref buflen);
        }

        #endregion

        #region FPDFBookmark_GetFirstChild

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_BOOKMARK FPDFBookmark_GetFirstChild(FPDF_DOCUMENT document,
                FPDF_BOOKMARK bookmark);
        }

        public static FPDF_BOOKMARK FPDFBookmark_GetFirstChild(FPDF_DOCUMENT document, FPDF_BOOKMARK bookmark)
        {
            return PlatformInvoke.FPDFBookmark_GetFirstChild(document, bookmark);
        }

        #endregion

        #region FPDFBookmark_GetNextSibling

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_BOOKMARK FPDFBookmark_GetNextSibling(FPDF_DOCUMENT document,
                FPDF_BOOKMARK bookmark);
        }

        public static FPDF_BOOKMARK FPDFBookmark_GetNextSibling(FPDF_DOCUMENT document, FPDF_BOOKMARK bookmark)
        {
            return PlatformInvoke.FPDFBookmark_GetNextSibling(document, bookmark);
        }

        #endregion

        #region FPDFBookmark_GetTitle

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern uint FPDFBookmark_GetTitle(FPDF_BOOKMARK bookmark, ref byte buffer, uint buflen);
        }

        private static uint FPDFBookmark_GetTitle(FPDF_BOOKMARK bookmark, ref byte buffer, uint buflen)
        {
            return PlatformInvoke.FPDFBookmark_GetTitle(bookmark, ref buffer, buflen);
        }

        #endregion

        #region FPDFBookmark_Find

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_BOOKMARK FPDFBookmark_Find(FPDF_DOCUMENT document,
                [MarshalAs(UnmanagedType.LPWStr)] string title);
        }

        public static FPDF_BOOKMARK FPDFBookmark_Find(FPDF_DOCUMENT document,
            [MarshalAs(UnmanagedType.LPWStr)] string title)
        {
            return PlatformInvoke.FPDFBookmark_Find(document, title);
        }

        #endregion

        #region FPDFBookmark_GetDest

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_DEST FPDFBookmark_GetDest(FPDF_DOCUMENT document, FPDF_BOOKMARK bookmark);
        }

        public static FPDF_DEST FPDFBookmark_GetDest(FPDF_DOCUMENT document, FPDF_BOOKMARK bookmark)
        {
            return PlatformInvoke.FPDFBookmark_GetDest(document, bookmark);
        }

        #endregion

        #region FPDFBookmark_GetAction

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_ACTION FPDFBookmark_GetAction(FPDF_BOOKMARK bookmark);
        }

        public static FPDF_ACTION FPDFBookmark_GetAction(FPDF_BOOKMARK bookmark)
        {
            return PlatformInvoke.FPDFBookmark_GetAction(bookmark);
        }

        #endregion

        #region FPDFAction_GetType

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern ActionTypes FPDFAction_GetType(FPDF_ACTION action);
        }

        public static ActionTypes FPDFAction_GetType(FPDF_ACTION action)
        {
            return PlatformInvoke.FPDFAction_GetType(action);
        }

        #endregion

        #region FPDFAction_GetDest

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_DEST FPDFAction_GetDest(FPDF_DOCUMENT document, FPDF_ACTION action);
        }

        public static FPDF_DEST FPDFAction_GetDest(FPDF_DOCUMENT document, FPDF_ACTION action)
        {
            return PlatformInvoke.FPDFAction_GetDest(document, action);
        }

        #endregion

        #region FPDFAction_GetFilePath

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern uint FPDFAction_GetFilePath(FPDF_ACTION action, ref byte buffer, uint buflen);
        }

        private static uint FPDFAction_GetFilePath(FPDF_ACTION action, ref byte buffer, uint buflen)
        {
            return PlatformInvoke.FPDFAction_GetFilePath(action, ref buffer, buflen);
        }

        #endregion

        #region FPDFAction_GetURIPath

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern uint FPDFAction_GetURIPath(FPDF_DOCUMENT document, FPDF_ACTION action,
                ref byte buffer, uint buflen);
        }

        private static uint FPDFAction_GetURIPath(FPDF_DOCUMENT document, FPDF_ACTION action, ref byte buffer,
            uint buflen)
        {
            return PlatformInvoke.FPDFAction_GetURIPath(document, action, ref buffer, buflen);
        }

        #endregion

        #region FPDFDest_GetPageIndex

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFDest_GetDestPageIndex(FPDF_DOCUMENT document, FPDF_DEST dest);
        }

        public static int FPDFDest_GetPageIndex(FPDF_DOCUMENT document, FPDF_DEST dest)
        {
            return PlatformInvoke.FPDFDest_GetDestPageIndex(document, dest);
        }

        #endregion

        #region FPDFDest_GetLocationInPage

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFDest_GetLocationInPage(FPDF_DEST dest, out bool hasXCoord,
                out bool hasYCoord, out bool hasZoom, out float x, out float y, out float zoom);
        }

        public static bool FPDFDest_GetLocationInPage(FPDF_DEST dest, out bool hasXCoord, out bool hasYCoord,
            out bool hasZoom, out float x, out float y, out float zoom)
        {
            return PlatformInvoke.FPDFDest_GetLocationInPage(dest, out hasXCoord, out hasYCoord, out hasZoom, out x,
                out y, out zoom);
        }

        #endregion

        #region FPDFLink_GetLinkAtPoint

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_LINK FPDFLink_GetLinkAtPoint(FPDF_PAGE page, double x, double y);
        }

        public static FPDF_LINK FPDFLink_GetLinkAtPoint(FPDF_PAGE page, double x, double y)
        {
            return PlatformInvoke.FPDFLink_GetLinkAtPoint(page, x, y);
        }

        #endregion

        #region FPDFLink_GetLinkZOrderAtPoint

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFLink_GetLinkZOrderAtPoint(FPDF_PAGE page, double x, double y);
        }

        public static int FPDFLink_GetLinkZOrderAtPoint(FPDF_PAGE page, double x, double y)
        {
            return PlatformInvoke.FPDFLink_GetLinkZOrderAtPoint(page, x, y);
        }

        #endregion

        #region FPDFLink_GetDest

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_DEST FPDFLink_GetDest(FPDF_DOCUMENT document, FPDF_LINK link);
        }

        public static FPDF_DEST FPDFLink_GetDest(FPDF_DOCUMENT document, FPDF_LINK link)
        {
            return PlatformInvoke.FPDFLink_GetDest(document, link);
        }

        #endregion

        #region FPDFLink_GetAction

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_ACTION FPDFLink_GetAction(FPDF_LINK link);
        }

        public static FPDF_ACTION FPDFLink_GetAction(FPDF_LINK link)
        {
            return PlatformInvoke.FPDFLink_GetAction(link);
        }

        #endregion

        #region FPDFLink_Enumerate

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFLink_Enumerate(FPDF_PAGE page, ref int startPos, out FPDF_LINK linkAnnot);
        }

        private static bool FPDFLink_Enumerate(FPDF_PAGE page, ref int startPos, out FPDF_LINK linkAnnot)
        {
            return PlatformInvoke.FPDFLink_Enumerate(page, ref startPos, out linkAnnot);
        }

        #endregion

        #region FPDFLink_GetAnnotRect

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFLink_GetAnnotRect(FPDF_LINK linkAnnot, out FS_RECTF rect);
        }

        public static bool FPDFLink_GetAnnotRect(FPDF_LINK linkAnnot, out FS_RECTF rect)
        {
            return PlatformInvoke.FPDFLink_GetAnnotRect(linkAnnot, out rect);
        }

        #endregion

        #region FPDFLink_CountQuadPoints

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFLink_CountQuadPoints(FPDF_LINK linkAnnot);
        }

        public static int FPDFLink_CountQuadPoints(FPDF_LINK linkAnnot)
        {
            return PlatformInvoke.FPDFLink_CountQuadPoints(linkAnnot);
        }

        #endregion

        #region FPDFLink_GetQuadPoints

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFLink_GetQuadPoints(FPDF_LINK linkAnnot, int quadIndex,
                out FS_QUADPOINTSF quadPoints);
        }

        public static bool FPDFLink_GetQuadPoints(FPDF_LINK linkAnnot, int quadIndex, out FS_QUADPOINTSF quadPoints)
        {
            return PlatformInvoke.FPDFLink_GetQuadPoints(linkAnnot, quadIndex, out quadPoints);
        }

        #endregion

        #region FPDF_GetMetaText

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern uint FPDF_GetMetaText(FPDF_DOCUMENT document,
                [MarshalAs(UnmanagedType.LPStr)] string tag, ref byte buffer, uint buflen);
        }

        public static uint FPDF_GetMetaText(FPDF_DOCUMENT document, [MarshalAs(UnmanagedType.LPStr)] string tag,
            ref byte buffer, uint buflen)
        {
            return PlatformInvoke.FPDF_GetMetaText(document, tag, ref buffer, buflen);
        }

        #endregion

        #region FPDF_GetPageLabel

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern uint FPDF_GetPageLabel(FPDF_DOCUMENT document, int page_index, ref byte buffer,
                uint buflen);
        }

        private static uint FPDF_GetPageLabel(FPDF_DOCUMENT document, int page_index, ref byte buffer, uint buflen)
        {
            return PlatformInvoke.FPDF_GetPageLabel(document, page_index, ref buffer, buflen);
        }

        #endregion

        #region FPDF_CreateNewDocument

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_DOCUMENT FPDF_CreateNewDocument();
        }

        public static FPDF_DOCUMENT FPDF_CreateNewDocument()
        {
            return PlatformInvoke.FPDF_CreateNewDocument();
        }

        #endregion

        #region FPDFPage_New

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_PAGE FPDFPage_New(FPDF_DOCUMENT document, int page_index, double width,
                double height);
        }

        public static FPDF_PAGE FPDFPage_New(FPDF_DOCUMENT document, int page_index, double width, double height)
        {
            return PlatformInvoke.FPDFPage_New(document, page_index, width, height);
        }

        #endregion

        #region FPDFPage_Delete

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFPage_Delete(FPDF_DOCUMENT document, int page_index);
        }

        public static void FPDFPage_Delete(FPDF_DOCUMENT document, int page_index)
        {
            PlatformInvoke.FPDFPage_Delete(document, page_index);
        }

        #endregion

        #region FPDFPage_GetRotation

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern PageOrientations FPDFPage_GetRotation(FPDF_PAGE page);
        }

        public static PageOrientations FPDFPage_GetRotation(FPDF_PAGE page)
        {
            return PlatformInvoke.FPDFPage_GetRotation(page);
        }

        #endregion

        #region FPDFPage_SetRotation

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFPage_SetRotation(FPDF_PAGE page, PageOrientations rotation);
        }

        public static void FPDFPage_SetRotation(FPDF_PAGE page, PageOrientations rotation)
        {
            PlatformInvoke.FPDFPage_SetRotation(page, rotation);
        }

        #endregion

        #region FPDFPage_InsertObject

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFPage_InsertObject(FPDF_PAGE page, FPDF_PAGEOBJECT page_obj);
        }

        private static void FPDFPage_InsertObject(FPDF_PAGE page, FPDF_PAGEOBJECT page_obj)
        {
            PlatformInvoke.FPDFPage_InsertObject(page, page_obj);
        }

        #endregion

        #region FPDFPage_CountObject

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFPage_CountObject(FPDF_PAGE page);
        }

        public static int FPDFPage_CountObject(FPDF_PAGE page)
        {
            return PlatformInvoke.FPDFPage_CountObject(page);
        }

        #endregion

        #region FPDFPage_GetObject

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_PAGEOBJECT FPDFPage_GetObject(FPDF_PAGE page, int index);
        }

        public static FPDF_PAGEOBJECT FPDFPage_GetObject(FPDF_PAGE page, int index)
        {
            return PlatformInvoke.FPDFPage_GetObject(page, index);
        }

        #endregion

        #region FPDFPage_HasTransparency

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPage_HasTransparency(FPDF_PAGE page);
        }

        public static bool FPDFPage_HasTransparency(FPDF_PAGE page)
        {
            return PlatformInvoke.FPDFPage_HasTransparency(page);
        }

        #endregion

        #region FPDFPage_GetThumbnailAsBitmap

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPage_GetThumbnailAsBitmap(FPDF_PAGE page);
        }

        public static bool FPDFPage_GetThumbnailAsBitmap(FPDF_PAGE page)
        {
            return PlatformInvoke.FPDFPage_GetThumbnailAsBitmap(page);
        }

        #endregion

        #region FPDFPage_GenerateContent

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPage_GenerateContent(FPDF_PAGE page);
        }

        public static bool FPDFPage_GenerateContent(FPDF_PAGE page)
        {
            return PlatformInvoke.FPDFPage_GenerateContent(page);
        }

        #endregion

        #region FPDFPageObj_HasTransparency

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPageObj_HasTransparency(FPDF_PAGEOBJECT pageObject);
        }

        public static bool FPDFPageObj_HasTransparency(FPDF_PAGEOBJECT pageObject)
        {
            return PlatformInvoke.FPDFPageObj_HasTransparency(pageObject);
        }

        #endregion

        #region FPDFPageObj_Transform

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFPageObj_Transform(FPDF_PAGEOBJECT page_object, double a, double b, double c,
                double d, double e, double f);
        }

        public static void FPDFPageObj_Transform(FPDF_PAGEOBJECT page_object, double a, double b, double c, double d,
            double e, double f)
        {
            PlatformInvoke.FPDFPageObj_Transform(page_object, a, b, c, d, e, f);
        }

        #endregion

        #region FPDFPage_TransformAnnots

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFPage_TransformAnnots(FPDF_PAGE page, double a, double b, double c, double d,
                double e, double f);
        }

        public static void FPDFPage_TransformAnnots(FPDF_PAGE page, double a, double b, double c, double d, double e,
            double f)
        {
            PlatformInvoke.FPDFPage_TransformAnnots(page, a, b, c, d, e, f);
        }

        #endregion

        #region FPDFPageObj_NewImageObj

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_PAGEOBJECT FPDFPageObj_NewImageObj(FPDF_DOCUMENT document);
        }

        public static FPDF_PAGEOBJECT FPDFPageObj_NewImageObj(FPDF_DOCUMENT document)
        {
            return PlatformInvoke.FPDFPageObj_NewImageObj(document);
        }

        #endregion

        #region FPDFImageObj_LoadJpegFile

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFImageObj_LoadJpegFile(ref FPDF_PAGE pages, int nCount,
                FPDF_PAGEOBJECT image_object, FPDF_FILEREAD fileRead);
        }

        private static bool FPDFImageObj_LoadJpegFile(ref FPDF_PAGE pages, int nCount, FPDF_PAGEOBJECT image_object,
            FPDF_FILEREAD fileRead)
        {
            return PlatformInvoke.FPDFImageObj_LoadJpegFile(ref pages, nCount, image_object, fileRead);
        }

        #endregion

        #region FPDFImageObj_LoadJpegFileInline

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFImageObj_LoadJpegFileInline(ref FPDF_PAGE pages, int nCount,
                FPDF_PAGEOBJECT image_object, FPDF_FILEREAD fileRead);
        }

        private static bool FPDFImageObj_LoadJpegFileInline(ref FPDF_PAGE pages, int nCount,
            FPDF_PAGEOBJECT image_object, FPDF_FILEREAD fileRead)
        {
            return PlatformInvoke.FPDFImageObj_LoadJpegFileInline(ref pages, nCount, image_object, fileRead);
        }

        #endregion

        #region FPDFImageObj_SetMatrix

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFImageObj_SetMatrix(FPDF_PAGEOBJECT image_object, double a, double b,
                double c, double d, double e, double f);
        }

        public static bool FPDFImageObj_SetMatrix(FPDF_PAGEOBJECT image_object, double a, double b, double c, double d,
            double e, double f)
        {
            return PlatformInvoke.FPDFImageObj_SetMatrix(image_object, a, b, c, d, e, f);
        }

        #endregion

        #region FPDFImageObj_SetBitmap

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFImageObj_SetBitmap(ref FPDF_PAGE pages, int nCount,
                FPDF_PAGEOBJECT image_object, FPDF_BITMAP bitmap);
        }

        public static bool FPDFImageObj_SetBitmap(ref FPDF_PAGE pages, int nCount, FPDF_PAGEOBJECT image_object,
            FPDF_BITMAP bitmap)
        {
            return PlatformInvoke.FPDFImageObj_SetBitmap(ref pages, nCount, image_object, bitmap);
        }

        #endregion

        #region FPDFPageObj_CreateNewPath

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_PAGEOBJECT FPDFPageObj_CreateNewPath(float x, float y);
        }

        public static FPDF_PAGEOBJECT FPDFPageObj_CreateNewPath(float x, float y)
        {
            return PlatformInvoke.FPDFPageObj_CreateNewPath(x, y);
        }

        #endregion

        #region FPDFPageObj_CreateNewRect

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_PAGEOBJECT FPDFPageObj_CreateNewRect(float x, float y, float w, float h);
        }

        public static FPDF_PAGEOBJECT FPDFPageObj_CreateNewRect(float x, float y, float w, float h)
        {
            return PlatformInvoke.FPDFPageObj_CreateNewRect(x, y, w, h);
        }

        #endregion

        #region FPDFPath_SetStrokeColor

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPath_SetStrokeColor(FPDF_PAGEOBJECT path, uint R, uint G, uint B, uint A);
        }

        public static bool FPDFPath_SetStrokeColor(FPDF_PAGEOBJECT path, uint R, uint G, uint B, uint A)
        {
            return PlatformInvoke.FPDFPath_SetStrokeColor(path, R, G, B, A);
        }

        #endregion

        #region FPDFPath_SetStrokeWidth

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPath_SetStrokeWidth(FPDF_PAGEOBJECT path, float width);
        }

        public static bool FPDFPath_SetStrokeWidth(FPDF_PAGEOBJECT path, float width)
        {
            return PlatformInvoke.FPDFPath_SetStrokeWidth(path, width);
        }

        #endregion

        #region FPDFPath_SetFillColor

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPath_SetFillColor(FPDF_PAGEOBJECT path, uint R, uint G, uint B, uint A);
        }

        public static bool FPDFPath_SetFillColor(FPDF_PAGEOBJECT path, uint R, uint G, uint B, uint A)
        {
            return PlatformInvoke.FPDFPath_SetFillColor(path, R, G, B, A);
        }

        #endregion

        #region FPDFPath_MoveTo

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPath_MoveTo(FPDF_PAGEOBJECT path, float x, float y);
        }

        public static bool FPDFPath_MoveTo(FPDF_PAGEOBJECT path, float x, float y)
        {
            return PlatformInvoke.FPDFPath_MoveTo(path, x, y);
        }

        #endregion

        #region FPDFPath_LineTo

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPath_LineTo(FPDF_PAGEOBJECT path, float x, float y);
        }

        public static bool FPDFPath_LineTo(FPDF_PAGEOBJECT path, float x, float y)
        {
            return PlatformInvoke.FPDFPath_LineTo(path, x, y);
        }

        #endregion

        #region FPDFPath_BezierTo

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPath_BezierTo(FPDF_PAGEOBJECT path, float x1, float y1, float x2, float y2,
                float x3, float y3);
        }

        public static bool FPDFPath_BezierTo(FPDF_PAGEOBJECT path, float x1, float y1, float x2, float y2, float x3,
            float y3)
        {
            return PlatformInvoke.FPDFPath_BezierTo(path, x1, y1, x2, y2, x3, y3);
        }

        #endregion

        #region FPDFPath_Close

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPath_Close(FPDF_PAGEOBJECT path);
        }

        public static bool FPDFPath_Close(FPDF_PAGEOBJECT path)
        {
            return PlatformInvoke.FPDFPath_Close(path);
        }

        #endregion

        #region FPDFPath_SetDrawMode

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPath_SetDrawMode(FPDF_PAGEOBJECT path, PathFillModes fillmode, bool stroke);
        }

        public static bool FPDFPath_SetDrawMode(FPDF_PAGEOBJECT path, PathFillModes fillmode, bool stroke)
        {
            return PlatformInvoke.FPDFPath_SetDrawMode(path, fillmode, stroke);
        }

        #endregion

        #region FPDFPageObj_NewTextObj

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_PAGEOBJECT FPDFPageObj_NewTextObj(FPDF_DOCUMENT document,
                [MarshalAs(UnmanagedType.LPStr)] string font, float font_size);
        }

        public static FPDF_PAGEOBJECT FPDFPageObj_NewTextObj(FPDF_DOCUMENT document,
            [MarshalAs(UnmanagedType.LPStr)] string font, float font_size)
        {
            return PlatformInvoke.FPDFPageObj_NewTextObj(document, font, font_size);
        }

        #endregion

        #region FPDFText_SetText

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFText_SetText(FPDF_PAGEOBJECT text_object,
                [MarshalAs(UnmanagedType.LPStr)] string text);
        }

        public static bool FPDFText_SetText(FPDF_PAGEOBJECT text_object, [MarshalAs(UnmanagedType.LPStr)] string text)
        {
            return PlatformInvoke.FPDFText_SetText(text_object, text);
        }

        #endregion

        #region FPDFText_LoadFont

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_FONT FPDFText_LoadFont(FPDF_DOCUMENT document, ref byte data, uint size,
                FontTypes font_type, bool cid);
        }

        private static FPDF_FONT FPDFText_LoadFont(FPDF_DOCUMENT document, ref byte data, uint size,
            FontTypes font_type, bool cid)
        {
            return PlatformInvoke.FPDFText_LoadFont(document, ref data, size, font_type, cid);
        }

        #endregion

        #region FPDFDoc_GetPageMode

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern PageModes FPDFDoc_GetPageMode(FPDF_DOCUMENT document);
        }

        public static PageModes FPDFDoc_GetPageMode(FPDF_DOCUMENT document)
        {
            return PlatformInvoke.FPDFDoc_GetPageMode(document);
        }

        #endregion

        #region FPDFPage_Flatten

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FlattenResults FPDFPage_Flatten(FPDF_PAGE page, FlattenFlags nFlag);
        }

        public static FlattenResults FPDFPage_Flatten(FPDF_PAGE page, FlattenFlags nFlag)
        {
            return PlatformInvoke.FPDFPage_Flatten(page, nFlag);
        }

        #endregion

        #region FPDF_ImportPages

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDF_ImportPages(FPDF_DOCUMENT dest_doc, FPDF_DOCUMENT src_doc,
                [MarshalAs(UnmanagedType.LPStr)] string pagerange, int index);
        }

        public static bool FPDF_ImportPages(FPDF_DOCUMENT dest_doc, FPDF_DOCUMENT src_doc,
            [MarshalAs(UnmanagedType.LPStr)] string pagerange, int index)
        {
            return PlatformInvoke.FPDF_ImportPages(dest_doc, src_doc, pagerange, index);
        }

        #endregion

        #region FPDF_CopyViewerPreferences

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDF_CopyViewerPreferences(FPDF_DOCUMENT dest_doc, FPDF_DOCUMENT src_doc);
        }

        public static bool FPDF_CopyViewerPreferences(FPDF_DOCUMENT dest_doc, FPDF_DOCUMENT src_doc)
        {
            return PlatformInvoke.FPDF_CopyViewerPreferences(dest_doc, src_doc);
        }

        #endregion

        #region FPDF_RenderPageBitmap_Start

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern RenderingStatus FPDF_RenderPageBitmap_Start(FPDF_BITMAP bitmap, FPDF_PAGE page,
                int start_x, int start_y, int size_x, int size_y, PageOrientations rotate, RenderingFlags flags,
                IFSDK_PAUSE pause);
        }

        public static RenderingStatus FPDF_RenderPageBitmap_Start(FPDF_BITMAP bitmap, FPDF_PAGE page, int start_x,
            int start_y, int size_x, int size_y, PageOrientations rotate, RenderingFlags flags, IFSDK_PAUSE pause)
        {
            return PlatformInvoke.FPDF_RenderPageBitmap_Start(bitmap, page, start_x, start_y, size_x, size_y, rotate,
                flags, pause);
        }

        #endregion

        #region FPDF_RenderPage_Continue

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern RenderingStatus FPDF_RenderPage_Continue(FPDF_PAGE page, IFSDK_PAUSE pause);
        }

        public static RenderingStatus FPDF_RenderPage_Continue(FPDF_PAGE page, IFSDK_PAUSE pause)
        {
            return PlatformInvoke.FPDF_RenderPage_Continue(page, pause);
        }

        #endregion

        #region FPDF_RenderPage_Close

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDF_RenderPage_Close(FPDF_PAGE page);
        }

        public static void FPDF_RenderPage_Close(FPDF_PAGE page)
        {
            PlatformInvoke.FPDF_RenderPage_Close(page);
        }

        #endregion

        #region FPDF_SaveAsCopy

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDF_SaveAsCopy(FPDF_DOCUMENT document, FPDF_FILEWRITE fileWrite,
                SaveFlags flags);
        }

        public static bool FPDF_SaveAsCopy(FPDF_DOCUMENT document, FPDF_FILEWRITE fileWrite, SaveFlags flags)
        {
            return PlatformInvoke.FPDF_SaveAsCopy(document, fileWrite, flags);
        }

        #endregion

        #region FPDF_SaveWithVersion

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDF_SaveWithVersion(FPDF_DOCUMENT document, FPDF_FILEWRITE fileWrite,
                SaveFlags flags, int fileVersion);
        }

        public static bool FPDF_SaveWithVersion(FPDF_DOCUMENT document, FPDF_FILEWRITE fileWrite, SaveFlags flags,
            int fileVersion)
        {
            return PlatformInvoke.FPDF_SaveWithVersion(document, fileWrite, flags, fileVersion);
        }

        #endregion

        #region FPDFText_GetCharIndexFromTextIndex

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFText_GetCharIndexFromTextIndex(FPDF_TEXTPAGE text_page, int nTextIndex);
        }

        public static int FPDFText_GetCharIndexFromTextIndex(FPDF_TEXTPAGE text_page, int nTextIndex)
        {
            return PlatformInvoke.FPDFText_GetCharIndexFromTextIndex(text_page, nTextIndex);
        }

        #endregion

        #region FPDFText_GetTextIndexFromCharIndex

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFText_GetTextIndexFromCharIndex(FPDF_TEXTPAGE text_page, int nCharIndex);
        }

        public static int FPDFText_GetTextIndexFromCharIndex(FPDF_TEXTPAGE text_page, int nCharIndex)
        {
            return PlatformInvoke.FPDFText_GetTextIndexFromCharIndex(text_page, nCharIndex);
        }

        #endregion

        #region FPDF_StructTree_GetForPage

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_STRUCTTREE FPDF_StructTree_GetForPage(FPDF_PAGE page);
        }

        public static FPDF_STRUCTTREE FPDF_StructTree_GetForPage(FPDF_PAGE page)
        {
            return PlatformInvoke.FPDF_StructTree_GetForPage(page);
        }

        #endregion

        #region FPDF_StructTree_Close

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDF_StructTree_Close(FPDF_STRUCTTREE struct_tree);
        }

        public static void FPDF_StructTree_Close(FPDF_STRUCTTREE struct_tree)
        {
            PlatformInvoke.FPDF_StructTree_Close(struct_tree);
        }

        #endregion

        #region FPDF_StructTree_CountChildren

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDF_StructTree_CountChildren(FPDF_STRUCTTREE struct_tree);
        }

        public static int FPDF_StructTree_CountChildren(FPDF_STRUCTTREE struct_tree)
        {
            return PlatformInvoke.FPDF_StructTree_CountChildren(struct_tree);
        }

        #endregion

        #region FPDF_StructTree_GetChildAtIndex

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_STRUCTELEMENT FPDF_StructTree_GetChildAtIndex(FPDF_STRUCTTREE struct_tree,
                int index);
        }

        public static FPDF_STRUCTELEMENT FPDF_StructTree_GetChildAtIndex(FPDF_STRUCTTREE struct_tree, int index)
        {
            return PlatformInvoke.FPDF_StructTree_GetChildAtIndex(struct_tree, index);
        }

        #endregion

        #region FPDF_StructElement_GetAltText

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern uint FPDF_StructElement_GetAltText(FPDF_STRUCTELEMENT struct_element,
                ref byte buffer, uint buflen);
        }

        private static uint FPDF_StructElement_GetAltText(FPDF_STRUCTELEMENT struct_element, ref byte buffer,
            uint buflen)
        {
            return PlatformInvoke.FPDF_StructElement_GetAltText(struct_element, ref buffer, buflen);
        }

        #endregion

        #region FPDF_StructElement_CountChildren

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDF_StructElement_CountChildren(FPDF_STRUCTELEMENT struct_element);
        }

        public static int FPDF_StructElement_CountChildren(FPDF_STRUCTELEMENT struct_element)
        {
            return PlatformInvoke.FPDF_StructElement_CountChildren(struct_element);
        }

        #endregion

        #region FPDF_StructElement_GetChildAtIndex

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_STRUCTELEMENT FPDF_StructElement_GetChildAtIndex(
                FPDF_STRUCTELEMENT struct_element, int index);
        }

        public static FPDF_STRUCTELEMENT FPDF_StructElement_GetChildAtIndex(FPDF_STRUCTELEMENT struct_element,
            int index)
        {
            return PlatformInvoke.FPDF_StructElement_GetChildAtIndex(struct_element, index);
        }

        #endregion

        #region FPDFText_LoadPage

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_TEXTPAGE FPDFText_LoadPage(FPDF_PAGE page);
        }

        public static FPDF_TEXTPAGE FPDFText_LoadPage(FPDF_PAGE page)
        {
            return PlatformInvoke.FPDFText_LoadPage(page);
        }

        #endregion

        #region FPDFText_ClosePage

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFText_ClosePage(FPDF_TEXTPAGE text_page);
        }

        public static void FPDFText_ClosePage(FPDF_TEXTPAGE text_page)
        {
            PlatformInvoke.FPDFText_ClosePage(text_page);
        }

        #endregion

        #region FPDFText_CountChars

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFText_CountChars(FPDF_TEXTPAGE text_page);
        }

        public static int FPDFText_CountChars(FPDF_TEXTPAGE text_page)
        {
            return PlatformInvoke.FPDFText_CountChars(text_page);
        }

        #endregion

        #region FPDFText_GetUnicode

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            [return: MarshalAs(UnmanagedType.U4)]
            internal static extern char FPDFText_GetUnicode(FPDF_TEXTPAGE text_page, int index);
        }

        public static char FPDFText_GetUnicode(FPDF_TEXTPAGE text_page, int index)
        {
            return PlatformInvoke.FPDFText_GetUnicode(text_page, index);
        }

        #endregion

        #region FPDFText_GetFontSize

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern double FPDFText_GetFontSize(FPDF_TEXTPAGE text_page, int index);
        }

        public static double FPDFText_GetFontSize(FPDF_TEXTPAGE text_page, int index)
        {
            return PlatformInvoke.FPDFText_GetFontSize(text_page, index);
        }

        #endregion

        #region FPDFText_GetCharBox

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFText_GetCharBox(FPDF_TEXTPAGE text_page, int index, out double left,
                out double right, out double bottom, out double top);
        }

        public static void FPDFText_GetCharBox(FPDF_TEXTPAGE text_page, int index, out double left, out double right,
            out double bottom, out double top)
        {
            PlatformInvoke.FPDFText_GetCharBox(text_page, index, out left, out right, out bottom, out top);
        }

        #endregion

        #region FPDFText_GetCharIndexAtPos

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFText_GetCharIndexAtPos(FPDF_TEXTPAGE text_page, double x, double y,
                double xTolerance, double yTolerance);
        }

        public static int FPDFText_GetCharIndexAtPos(FPDF_TEXTPAGE text_page, double x, double y, double xTolerance,
            double yTolerance)
        {
            return PlatformInvoke.FPDFText_GetCharIndexAtPos(text_page, x, y, xTolerance, yTolerance);
        }

        #endregion

        #region FPDFText_GetText

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFText_GetText(FPDF_TEXTPAGE text_page, int start_index, int count,
                ref byte result);
        }

        private static int FPDFText_GetText(FPDF_TEXTPAGE text_page, int start_index, int count, ref byte result)
        {
            return PlatformInvoke.FPDFText_GetText(text_page, start_index, count, ref result);
        }

        #endregion

        #region FPDFText_CountRects

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFText_CountRects(FPDF_TEXTPAGE text_page, int start_index, int count);
        }

        public static int FPDFText_CountRects(FPDF_TEXTPAGE text_page, int start_index, int count)
        {
            return PlatformInvoke.FPDFText_CountRects(text_page, start_index, count);
        }

        #endregion

        #region FPDFText_GetRect

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFText_GetRect(FPDF_TEXTPAGE text_page, int rect_index, out double left,
                out double top, out double right, out double bottom);
        }

        public static void FPDFText_GetRect(FPDF_TEXTPAGE text_page, int rect_index, out double left, out double top,
            out double right, out double bottom)
        {
            PlatformInvoke.FPDFText_GetRect(text_page, rect_index, out left, out top, out right, out bottom);
        }

        #endregion

        #region FPDFText_GetBoundedText

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFText_GetBoundedText(FPDF_TEXTPAGE text_page, double left, double top,
                double right, double bottom, ref byte buffer, int buflen);
        }

        private static int FPDFText_GetBoundedText(FPDF_TEXTPAGE text_page, double left, double top, double right,
            double bottom, ref byte buffer, int buflen)
        {
            return PlatformInvoke.FPDFText_GetBoundedText(text_page, left, top, right, bottom, ref buffer, buflen);
        }

        #endregion

        #region FPDFText_FindStart

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_SCHHANDLE FPDFText_FindStart(FPDF_TEXTPAGE text_page,
                [MarshalAs(UnmanagedType.LPWStr)] string findwhat, SearchFlags flags, int start_index);
        }

        public static FPDF_SCHHANDLE FPDFText_FindStart(FPDF_TEXTPAGE text_page,
            [MarshalAs(UnmanagedType.LPWStr)] string findwhat, SearchFlags flags, int start_index)
        {
            return PlatformInvoke.FPDFText_FindStart(text_page, findwhat, flags, start_index);
        }

        #endregion

        #region FPDFText_FindNext

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFText_FindNext(FPDF_SCHHANDLE handle);
        }

        public static bool FPDFText_FindNext(FPDF_SCHHANDLE handle)
        {
            return PlatformInvoke.FPDFText_FindNext(handle);
        }

        #endregion

        #region FPDFText_FindPrev

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFText_FindPrev(FPDF_SCHHANDLE handle);
        }

        public static bool FPDFText_FindPrev(FPDF_SCHHANDLE handle)
        {
            return PlatformInvoke.FPDFText_FindPrev(handle);
        }

        #endregion

        #region FPDFText_GetSchResultIndex

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFText_GetSchResultIndex(FPDF_SCHHANDLE handle);
        }

        public static int FPDFText_GetSchResultIndex(FPDF_SCHHANDLE handle)
        {
            return PlatformInvoke.FPDFText_GetSchResultIndex(handle);
        }

        #endregion

        #region FPDFText_GetSchCount

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFText_GetSchCount(FPDF_SCHHANDLE handle);
        }

        public static int FPDFText_GetSchCount(FPDF_SCHHANDLE handle)
        {
            return PlatformInvoke.FPDFText_GetSchCount(handle);
        }

        #endregion

        #region FPDFText_FindClose

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFText_FindClose(FPDF_SCHHANDLE handle);
        }

        public static void FPDFText_FindClose(FPDF_SCHHANDLE handle)
        {
            PlatformInvoke.FPDFText_FindClose(handle);
        }

        #endregion

        #region FPDFLink_LoadWebLinks

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_PAGELINK FPDFLink_LoadWebLinks(FPDF_TEXTPAGE text_page);
        }

        public static FPDF_PAGELINK FPDFLink_LoadWebLinks(FPDF_TEXTPAGE text_page)
        {
            return PlatformInvoke.FPDFLink_LoadWebLinks(text_page);
        }

        #endregion

        #region FPDFLink_CountWebLinks

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFLink_CountWebLinks(FPDF_PAGELINK link_page);
        }

        public static int FPDFLink_CountWebLinks(FPDF_PAGELINK link_page)
        {
            return PlatformInvoke.FPDFLink_CountWebLinks(link_page);
        }

        #endregion

        #region FPDFLink_GetURL

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFLink_GetURL(FPDF_PAGELINK link_page, int link_index, ref byte buffer,
                int buflen);
        }

        private static int FPDFLink_GetURL(FPDF_PAGELINK link_page, int link_index, ref byte buffer, int buflen)
        {
            return PlatformInvoke.FPDFLink_GetURL(link_page, link_index, ref buffer, buflen);
        }

        #endregion

        #region FPDFLink_CountRects

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern int FPDFLink_CountRects(FPDF_PAGELINK link_page, int link_index);
        }

        public static int FPDFLink_CountRects(FPDF_PAGELINK link_page, int link_index)
        {
            return PlatformInvoke.FPDFLink_CountRects(link_page, link_index);
        }

        #endregion

        #region FPDFLink_GetRect

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFLink_GetRect(FPDF_PAGELINK link_page, int link_index, int rect_index,
                out double left, out double top, out double right, out double bottom);
        }

        public static void FPDFLink_GetRect(FPDF_PAGELINK link_page, int link_index, int rect_index, out double left,
            out double top, out double right, out double bottom)
        {
            PlatformInvoke.FPDFLink_GetRect(link_page, link_index, rect_index, out left, out top, out right,
                out bottom);
        }

        #endregion

        #region FPDFLink_CloseWebLinks

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFLink_CloseWebLinks(FPDF_PAGELINK link_page);
        }

        public static void FPDFLink_CloseWebLinks(FPDF_PAGELINK link_page)
        {
            PlatformInvoke.FPDFLink_CloseWebLinks(link_page);
        }

        #endregion

        #region FPDFPage_SetMediaBox

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFPage_SetMediaBox(FPDF_PAGE page, float left, float bottom, float right,
                float top);
        }

        public static void FPDFPage_SetMediaBox(FPDF_PAGE page, float left, float bottom, float right, float top)
        {
            PlatformInvoke.FPDFPage_SetMediaBox(page, left, bottom, right, top);
        }

        #endregion

        #region FPDFPage_SetCropBox

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFPage_SetCropBox(FPDF_PAGE page, float left, float bottom, float right,
                float top);
        }

        public static void FPDFPage_SetCropBox(FPDF_PAGE page, float left, float bottom, float right, float top)
        {
            PlatformInvoke.FPDFPage_SetCropBox(page, left, bottom, right, top);
        }

        #endregion

        #region FPDFPage_GetMediaBox

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPage_GetMediaBox(FPDF_PAGE page, out float left, out float bottom,
                out float right, out float top);
        }

        public static bool FPDFPage_GetMediaBox(FPDF_PAGE page, out float left, out float bottom, out float right,
            out float top)
        {
            return PlatformInvoke.FPDFPage_GetMediaBox(page, out left, out bottom, out right, out top);
        }

        #endregion

        #region FPDFPage_GetCropBox

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPage_GetCropBox(FPDF_PAGE page, out float left, out float bottom,
                out float right, out float top);
        }

        public static bool FPDFPage_GetCropBox(FPDF_PAGE page, out float left, out float bottom, out float right,
            out float top)
        {
            return PlatformInvoke.FPDFPage_GetCropBox(page, out left, out bottom, out right, out top);
        }

        #endregion

        #region FPDFPage_TransFormWithClip

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern bool FPDFPage_TransFormWithClip(FPDF_PAGE page,
                [MarshalAs(UnmanagedType.LPStruct)] FS_MATRIX matrix,
                [MarshalAs(UnmanagedType.LPStruct)] FS_RECTF clipRect);
        }

        public static bool FPDFPage_TransFormWithClip(FPDF_PAGE page,
            [MarshalAs(UnmanagedType.LPStruct)] FS_MATRIX matrix, [MarshalAs(UnmanagedType.LPStruct)] FS_RECTF clipRect)
        {
            return PlatformInvoke.FPDFPage_TransFormWithClip(page, matrix, clipRect);
        }

        #endregion

        #region FPDFPageObj_TransformClipPath

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFPageObj_TransformClipPath(FPDF_PAGEOBJECT page_object, double a, double b,
                double c, double d, double e, double f);
        }

        public static void FPDFPageObj_TransformClipPath(FPDF_PAGEOBJECT page_object, double a, double b, double c,
            double d, double e, double f)
        {
            PlatformInvoke.FPDFPageObj_TransformClipPath(page_object, a, b, c, d, e, f);
        }

        #endregion

        #region FPDF_CreateClipPath

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern FPDF_CLIPPATH FPDF_CreateClipPath(float left, float bottom, float right, float top);
        }

        public static FPDF_CLIPPATH FPDF_CreateClipPath(float left, float bottom, float right, float top)
        {
            return PlatformInvoke.FPDF_CreateClipPath(left, bottom, right, top);
        }

        #endregion

        #region FPDF_DestroyClipPath

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDF_DestroyClipPath(FPDF_CLIPPATH clipPath);
        }

        public static void FPDF_DestroyClipPath(FPDF_CLIPPATH clipPath)
        {
            PlatformInvoke.FPDF_DestroyClipPath(clipPath);
        }

        #endregion

        #region FPDFPage_InsertClipPath

        static partial class PlatformInvoke
        {
            [DllImport("pdfium")]
            internal static extern void FPDFPage_InsertClipPath(FPDF_PAGE page, FPDF_CLIPPATH clipPath);
        }

        public static void FPDFPage_InsertClipPath(FPDF_PAGE page, FPDF_CLIPPATH clipPath)
        {
            PlatformInvoke.FPDFPage_InsertClipPath(page, clipPath);
        }

        #endregion

        #region FPDF_RenderPageBitmap

        [DllImport("pdfium")]
        public static extern void FPDF_RenderPageBitmap(IntPtr bitmap, IntPtr page, int start_x, int start_y,
            int size_x, int size_y, int rotate, int flags);

        #endregion

        #region Bitmap

        [DllImport("pdfium")]
        public static extern IntPtr FPDFBitmap_Create(int width, int height, bool alpha);

        [DllImport("pdfium")]
        public static extern void FPDFBitmap_FillRect(IntPtr bitmap, int left, int top, int width, int height,
            int color);

        [DllImport("pdfium")]
        public static extern IntPtr FPDFBitmap_GetBuffer(IntPtr bitmap);

        [DllImport("pdfium")]
        public static extern int FPDFBitmap_GetStride(IntPtr bitmap);

        #endregion

        #region PdfPage

        [DllImport("pdfium")]
        public static extern IntPtr FPDF_LoadPage(IntPtr document, int page_index);

        [DllImport("pdfium")]
        public static extern void FPDF_PageToDevice(IntPtr page, int start_x, int start_y, int size_x, int size_y,
            int rotate, double page_x, double page_y, out int device_x, out int device_y);

        #endregion

        #region PdfTextPage

        [DllImport("pdfium")]
        public static extern IntPtr FPDFText_LoadPage(IntPtr page);

        [DllImport("pdfium")]
        public static extern void FPDFText_GetCharBox(IntPtr text_page, int index, out double left, out double right,
            out double bottom, out double top);

        #endregion

        #region Search
        [DllImport("pdfium")]
        public static extern IntPtr FPDFText_FindStart(IntPtr text_page, IntPtr buffer, int flags, int start_index);

        [DllImport("pdfium")]
        public static extern bool FPDFText_FindNext(IntPtr handle);

        [DllImport("pdfium")]
        public static extern int FPDFText_GetSchCount(IntPtr handle);

        [DllImport("pdfium")]
        public static extern int FPDFText_GetSchResultIndex(IntPtr handle);

        #endregion

        #region PageSize
        [DllImport("pdfium")]
        public static extern int FPDF_GetPageSizeByIndex(IntPtr document, int page_index, out double width, out double height);
        #endregion
    }
}