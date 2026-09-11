using GCommon;

namespace COW;

public class UICupMatchTeamCreateFormController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private NationFlagData m_SelectNationFlag;

	private HeadPicBaseInfo m_ClanAvatarInfo;

	private BannerBaseInfo m_ClanBannerInfo;

	private UICupMatchTeamCreateFormView m_View;

	private UIModelCupMatch m_ModelCupMatch;

	private UIModelCollection m_ModelCollection;

	private int m_CupMatchKey;

	private bool m_IsCreatTing;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void InitUI(int key)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Confirm()
	{
	}

	private void SelectFlag()
	{
	}

	private void SelectAvatar()
	{
	}

	private void SelectBanner()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void NationalFlagSelectHander(object[] args)
	{
	}

	private void ClanAvatarSelectHander(object[] args)
	{
	}

	private void ClanBannerSelectHander(object[] args)
	{
	}

	private void _003CInitUI_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
