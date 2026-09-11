using UnityEngine;

public class ImageTool
{
	private struct TextureParam
	{
		public TextureFormat format;

		public int width;

		public int height;

		public int offset;

		public int length;
	}

	private static readonly byte[] PVR_ID;

	private static readonly byte[] MAGIC_UGC_HEADER;

	private static readonly int MAGIC_UGC_HEADER_Size;

	private static void TryGetTextureParam(byte[] data, out TextureParam param, out int mipmapCount, out bool isReadable)
	{
		param = default(TextureParam);
		mipmapCount = default(int);
		isReadable = default(bool);
	}

	public static Texture2D Reload(Texture2D tex, byte[] data, bool forceReadable, string debugName = null)
	{
		return null;
	}

	public static Texture2D Load(byte[] data, bool forceReadable = false, string debugName = null)
	{
		return null;
	}

	private static int AlignUp(int value, int alignment)
	{
		return 0;
	}

	private static bool IsTextureSizeCompatible(TextureFormat format, int width, int height, out int compatibleWidth, out int compatibleHeight)
	{
		compatibleWidth = default(int);
		compatibleHeight = default(int);
		return false;
	}

	private static bool LoadRawTextureData(Texture2D texture2D, byte[] data, TextureParam param, string debugName)
	{
		return false;
	}

	private static bool TryCopyPixels(Texture2D source, Texture2D target, int width, int height)
	{
		return false;
	}

	private static Texture2D LoadTextureWithFallback(byte[] data, TextureParam param, bool isMipmap, bool isReadable, string debugName)
	{
		return null;
	}
}
