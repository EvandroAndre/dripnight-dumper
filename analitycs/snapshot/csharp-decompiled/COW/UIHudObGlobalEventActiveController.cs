using System.Text;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudObGlobalEventActiveController : UIBaseController
{
	private UIHudObGlobalEventActiveView m_View;

	private bool isActive;

	private UITimeLabelHelper m_TimeHelper;

	private LGBPPLOIEON m_EventManager;

	private StringBuilder m_EventString;

	private UIDetailTipsInGameController m_DetailTips;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	private void OnEventTakeEffectNtf(object[] data)
	{
	}

	private void RefreshCD()
	{
	}

	private void OnIconClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
