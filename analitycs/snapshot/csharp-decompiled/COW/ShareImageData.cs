using UnityEngine;

namespace COW;

internal class ShareImageData
{
	public UIUtils.ScreenshotType ScreenshotType;

	public string FilePath;

	public UIUtils.EShareScreenType ShareScreenType;

	public Texture2D ScreenshotTex;

	public bool DontDestroyTexture;

	public string ExtraFilePath;

	public long PicTimeTicks;
}
