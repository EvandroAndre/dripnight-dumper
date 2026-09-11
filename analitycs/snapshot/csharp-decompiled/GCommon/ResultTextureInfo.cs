using UnityEngine;

namespace GCommon;

public class ResultTextureInfo : CDNDownloadBaseInfo
{
	public Texture2D TextureImage;

	public string BeforeModifyUrl;

	public int TextureHeight;

	public int TextureWidth;

	public TextureSizeOtherInfo TextureOtherInfo;

	public bool IsGif;

	public bool isDownload;

	public bool isCDNIcon;

	private uint Count;

	public ResultTextureInfo(Texture2D texture2d, string textureUrl)
	{
	}

	public ResultTextureInfo(Texture2D texture2d, string textureUrl, int textureFFWidth, int textureFFHeight, string beforeModifyUrl, bool isIconCDN)
	{
	}

	public void UnRegisterTexture()
	{
	}

	public void RegisterOtherTexture()
	{
	}

	public void SetRefCount(uint refCount)
	{
	}

	public void AddRefCount(uint count)
	{
	}

	public bool TextureIsUnUse()
	{
		return false;
	}
}
