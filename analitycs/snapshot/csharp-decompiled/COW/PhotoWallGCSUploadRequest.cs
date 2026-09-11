using System;

namespace COW;

public class PhotoWallGCSUploadRequest
{
	public string UploadUrl;

	public byte[] PhotoBytes;

	public Action<bool, string> Callback;
}
