﻿using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace HorizonPDFAPI.Types
{
    
	/// <summary>Handle to a FPDF_ACTION</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_ACTION : IHandle<FPDF_ACTION>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_ACTION: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_ACTION Null => new FPDF_ACTION();

		FPDF_ACTION(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_ACTION IHandle<FPDF_ACTION>.SetToNull() => new FPDF_ACTION(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_BITMAP</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_BITMAP : IHandle<FPDF_BITMAP>
	{
		IntPtr _ptr;

		public IntPtr Instance => _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_BITMAP: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_BITMAP Null => new FPDF_BITMAP();

		public FPDF_BITMAP(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_BITMAP IHandle<FPDF_BITMAP>.SetToNull() => new FPDF_BITMAP(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_BOOKMARK</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_BOOKMARK : IHandle<FPDF_BOOKMARK>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_BOOKMARK: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_BOOKMARK Null => new FPDF_BOOKMARK();

		FPDF_BOOKMARK(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_BOOKMARK IHandle<FPDF_BOOKMARK>.SetToNull() => new FPDF_BOOKMARK(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_CLIPPATH</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_CLIPPATH : IHandle<FPDF_CLIPPATH>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_CLIPPATH: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_CLIPPATH Null => new FPDF_CLIPPATH();

		FPDF_CLIPPATH(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_CLIPPATH IHandle<FPDF_CLIPPATH>.SetToNull() => new FPDF_CLIPPATH(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_DEST</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_DEST : IHandle<FPDF_DEST>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_DEST: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_DEST Null => new FPDF_DEST();

		FPDF_DEST(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_DEST IHandle<FPDF_DEST>.SetToNull() => new FPDF_DEST(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_DOCUMENT</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_DOCUMENT : IHandle<FPDF_DOCUMENT>
	{
		public IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_DOCUMENT: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_DOCUMENT Null => new FPDF_DOCUMENT();

		FPDF_DOCUMENT(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_DOCUMENT IHandle<FPDF_DOCUMENT>.SetToNull() => new FPDF_DOCUMENT(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_FONT</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_FONT : IHandle<FPDF_FONT>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_FONT: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_FONT Null => new FPDF_FONT();

		FPDF_FONT(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_FONT IHandle<FPDF_FONT>.SetToNull() => new FPDF_FONT(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_LINK</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_LINK : IHandle<FPDF_LINK>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_LINK: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_LINK Null => new FPDF_LINK();

		FPDF_LINK(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_LINK IHandle<FPDF_LINK>.SetToNull() => new FPDF_LINK(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_PAGE</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_PAGE : IHandle<FPDF_PAGE>
	{
		private IntPtr _ptr;
		public IntPtr Instance => _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_PAGE: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_PAGE Null => new FPDF_PAGE();

		public FPDF_PAGE(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_PAGE IHandle<FPDF_PAGE>.SetToNull() => new FPDF_PAGE(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_PAGELINK</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_PAGELINK : IHandle<FPDF_PAGELINK>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_PAGELINK: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_PAGELINK Null => new FPDF_PAGELINK();

		FPDF_PAGELINK(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_PAGELINK IHandle<FPDF_PAGELINK>.SetToNull() => new FPDF_PAGELINK(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_PAGEOBJECT</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_PAGEOBJECT : IHandle<FPDF_PAGEOBJECT>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_PAGEOBJECT: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_PAGEOBJECT Null => new FPDF_PAGEOBJECT();

		FPDF_PAGEOBJECT(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_PAGEOBJECT IHandle<FPDF_PAGEOBJECT>.SetToNull() => new FPDF_PAGEOBJECT(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_PAGERANGE</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_PAGERANGE : IHandle<FPDF_PAGERANGE>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_PAGERANGE: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_PAGERANGE Null => new FPDF_PAGERANGE();

		FPDF_PAGERANGE(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_PAGERANGE IHandle<FPDF_PAGERANGE>.SetToNull() => new FPDF_PAGERANGE(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_RECORDER</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_RECORDER : IHandle<FPDF_RECORDER>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_RECORDER: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_RECORDER Null => new FPDF_RECORDER();

		FPDF_RECORDER(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_RECORDER IHandle<FPDF_RECORDER>.SetToNull() => new FPDF_RECORDER(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_SCHHANDLE</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_SCHHANDLE : IHandle<FPDF_SCHHANDLE>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_SCHHANDLE: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_SCHHANDLE Null => new FPDF_SCHHANDLE();

		FPDF_SCHHANDLE(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_SCHHANDLE IHandle<FPDF_SCHHANDLE>.SetToNull() => new FPDF_SCHHANDLE(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_STRUCTELEMENT</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_STRUCTELEMENT : IHandle<FPDF_STRUCTELEMENT>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_STRUCTELEMENT: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_STRUCTELEMENT Null => new FPDF_STRUCTELEMENT();

		FPDF_STRUCTELEMENT(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_STRUCTELEMENT IHandle<FPDF_STRUCTELEMENT>.SetToNull() => new FPDF_STRUCTELEMENT(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_STRUCTTREE</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_STRUCTTREE : IHandle<FPDF_STRUCTTREE>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_STRUCTTREE: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_STRUCTTREE Null => new FPDF_STRUCTTREE();

		FPDF_STRUCTTREE(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_STRUCTTREE IHandle<FPDF_STRUCTTREE>.SetToNull() => new FPDF_STRUCTTREE(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_TEXTPAGE</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_TEXTPAGE : IHandle<FPDF_TEXTPAGE>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_TEXTPAGE: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_TEXTPAGE Null => new FPDF_TEXTPAGE();

		FPDF_TEXTPAGE(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_TEXTPAGE IHandle<FPDF_TEXTPAGE>.SetToNull() => new FPDF_TEXTPAGE(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_STRINGHANDLE</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_STRINGHANDLE : IHandle<FPDF_STRINGHANDLE>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_STRINGHANDLE: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_STRINGHANDLE Null => new FPDF_STRINGHANDLE();

		FPDF_STRINGHANDLE(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_STRINGHANDLE IHandle<FPDF_STRINGHANDLE>.SetToNull() => new FPDF_STRINGHANDLE(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}


	/// <summary>Handle to a FPDF_WIDGET</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_WIDGET : IHandle<FPDF_WIDGET>
	{
		IntPtr _ptr;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _ptr == IntPtr.Zero;

		public override string ToString() => "FPDF_WIDGET: 0x" + _ptr.ToString("X16");

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_WIDGET Null => new FPDF_WIDGET();

		FPDF_WIDGET(IntPtr ptr)
		{
			_ptr = ptr;
		}

		FPDF_WIDGET IHandle<FPDF_WIDGET>.SetToNull() => new FPDF_WIDGET(Interlocked.Exchange(ref _ptr, IntPtr.Zero));
	}

}