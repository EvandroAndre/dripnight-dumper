using System;
using GCommon;
using proto;

namespace COW;

public class UIChampionshipTeamCreateFormController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private NationFlagData m_SelectNationFlag;

	private HeadPicBaseInfo m_ClanAvatarInfo;

	private BannerBaseInfo m_ClanBannerInfo;

	private UIChampionshipTeamCreateFormView m_View;

	private UIModelChampionship m_ModelChampionship;

	private UIModelCollection m_ModelCollection;

	private int m_SelectChannelID;

	private EChampionship.TeamScaleType m_TeamScaleType;

	public Action CancelAction;

	private bool m_IsCreatTing;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void InitUI(EChampionship.TeamScaleType teamScaleType)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Confirm()
	{
	}

	private void CancelCallBack()
	{
	}

	private string GetFixContactInfo()
	{
		return null;
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

	private void SelectChannel()
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

	private void ChannelSelectHandler(object[] args)
	{
	}

	private void _003CInitUI_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
