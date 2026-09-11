using GCommon;
using message;

namespace COW;

public class UICrossMatchModeBannerController : UIBaseController
{
	private UICrossMatchModeBannerView m_View;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private UIModelLadderMatch m_ModelLadderBR;

	private DLBMPCCFKKM m_CurMatchMode;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void OnCrossMatchModeBtnClick()
	{
	}

	public void SetViewData(DLBMPCCFKKM matchMode)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
