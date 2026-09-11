using GCommon;

namespace COW;

public class ReplayKitVideoItemController : UIBaseController
{
	private ReplayKitVideoItemView m_View;

	private ReplayKitVideoInfo videoInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetVideoInfo(ReplayKitVideoInfo info)
	{
	}

	private void DisplayThumbnail()
	{
	}

	private void DisplayVideoInfo()
	{
	}

	public bool OnVideoInfoCallback(string path)
	{
		return false;
	}

	public bool OnThumbnailCallback(string path)
	{
		return false;
	}

	public bool OnVideoDeleteCallback(string path)
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	private void OnClickDeleteBtn()
	{
	}

	private void OnClickPlayBtn()
	{
	}

	private void _003COnClickDeleteBtn_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
