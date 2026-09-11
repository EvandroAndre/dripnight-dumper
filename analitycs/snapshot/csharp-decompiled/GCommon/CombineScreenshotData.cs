using COW;

namespace GCommon;

public struct CombineScreenshotData
{
	public bool hasTopBar = false;

	public bool hasLeftBar = false;

	public bool isHideFFlogo = false;

	public EShareFFLogoAnchorPos ffLogoAnchorPos = EShareFFLogoAnchorPos.None;

	public CombineScreenshotData(bool hasTopBar, bool hasLeftBar, bool isHideFFlogo)
	{
	}

	public CombineScreenshotData(bool hasTopBar, bool hasLeftBar, bool isHideFFlogo, EShareFFLogoAnchorPos ffLogoAnchorPos)
	{
	}
}
