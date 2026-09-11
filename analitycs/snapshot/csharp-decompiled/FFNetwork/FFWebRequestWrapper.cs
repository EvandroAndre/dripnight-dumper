using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FFNetwork;

internal static class FFWebRequestWrapper
{
	public delegate void OnDownloaded(IntPtr data, IntPtr request_ptr, int data_size, int error_code);

	public static void GlobalInit()
	{
	}

	public static void GlobalUnInit()
	{
	}

	public static int RequestWebDownload(string url, List<string> header_list, IntPtr request_ptr, OnDownloaded onDownloaded)
	{
		return 0;
	}

	[PreserveSig]
	private static extern void Init();

	[PreserveSig]
	private static extern void UnInit();

	[PreserveSig]
	private static extern int DownloadTargetUrl(string url, string[] headers, int header_length, IntPtr request_ptr, OnDownloaded download_call_back);
}
