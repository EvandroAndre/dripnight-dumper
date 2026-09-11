using GCommon;

namespace COW;

internal class UIBooyahPassImportantRewardMaxController : UIBaseController
{
	public enum ERewardType
	{
		StandArdMaxB,
		Privilege
	}

	private BaseItemInfo m_ItemInfo;

	private UIBooyahPassImportantRewardMaxView m_View;

	private UIModelBooyahPass m_ModelBooyahPass;

	private ERewardType m_RewardType;

	private UIStandardItemMAXBController m_MaxCtrl;

	private float m_CountLabelExpandVector;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(BaseItemInfo info, ERewardType type)
	{
	}

	private void RefreshStandArdMaxBView()
	{
	}

	private void RefreshPrivilegeView()
	{
	}

	private void RefreshIconView()
	{
	}

	private void RefreshCdnView()
	{
	}

	private void ShowPrivilegeRewardTips()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
