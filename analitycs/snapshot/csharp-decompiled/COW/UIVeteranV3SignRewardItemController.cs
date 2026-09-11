using GCommon;
using proto;

namespace COW;

public class UIVeteranV3SignRewardItemController : UIBaseController
{
	private UIVeteranV3SignRewardItemView m_View;

	private UIModelVeteran m_ModelVeteran;

	private VeteranRewardItem m_dailyRewardItem;

	private UIStandardItemMAXBController m_AwardItemMAXCtrl;

	private int m_Index;

	private bool m_IsSpecial;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClaimBtnClick()
	{
	}

	private void SetupDefaultStateOnInit()
	{
	}

	private void LoadStaticContent()
	{
	}

	private void RefreshDynamicContent()
	{
	}

	private void RefreshView()
	{
	}

	private void SetGameObjectActive(VFXCreateHelper go, bool isActive)
	{
	}

	public void SetViewData(VeteranRewardItem dailyRewardItem, int index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
