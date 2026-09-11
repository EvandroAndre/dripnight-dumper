using GCommon;

namespace COW;

public class UIClanContributionItemController : UIBaseController
{
	private UIClanContributionItemView m_View;

	private UIModelClan m_ModelClan;

	private float VFXDelayPlay;

	private float VFXDuring;

	private bool m_HasShowVFX;

	private uint m_PlayVFXDelayCall;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetData(MessageInfo record)
	{
	}

	private void SetLabel(ClanTrendMsgInfo info)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
