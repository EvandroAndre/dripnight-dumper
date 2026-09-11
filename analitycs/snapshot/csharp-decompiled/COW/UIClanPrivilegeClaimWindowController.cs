using GCommon;
using proto;

namespace COW;

public class UIClanPrivilegeClaimWindowController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIClanPrivilegeClaimWindowView m_View;

	private UIClanPrivilegeSharePreviewController m_SharePreviewCtrl;

	private UIBaseProfileInfoController m_BaseProfile;

	private UIModelClan m_ModelClan;

	private UIModelClanTrend m_ModelClanTrend;

	private UIModelCollection m_ModelCollection;

	private ulong m_SponsorId;

	private float m_UpPos;

	private float m_CenterPos;

	private bool m_IsTodayNotShowBtnSelected;

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

	protected override void OnUIClose()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnShareBtnClick()
	{
	}

	private void OnShare()
	{
	}

	private void OnEquipBtnClick()
	{
	}

	private void OnClaimBtnClick()
	{
	}

	private void OnDontShowBtnClick()
	{
	}

	private void InitView()
	{
	}

	private void RefreshSponsorContainer()
	{
	}

	private void PreLoadShareCDN()
	{
	}

	private void RefreshCDN()
	{
	}

	private void RefreshButtonView(object[] data)
	{
	}

	private void RefreshClaimedBtn()
	{
	}

	private void RefreshEquipmentBtn()
	{
	}

	private void RefreshClanName()
	{
	}

	private void RefreshBaseProfileInfo()
	{
	}

	private void OnHeadClick()
	{
	}

	private void RefreshRoleTag(ClanMember memberInfo)
	{
	}

	private void RefreshHighLightTag()
	{
	}

	private bool _003CRefreshHighLightTag_003Eb__34_0(ClanHighLightInfo x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
