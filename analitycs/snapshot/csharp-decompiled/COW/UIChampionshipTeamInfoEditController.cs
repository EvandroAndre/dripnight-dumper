using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIChampionshipTeamInfoEditController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private NationFlagData m_SelectNationFlag;

	private HeadPicBaseInfo m_ClanAvatarInfo;

	private BannerBaseInfo m_ClanBannerInfo;

	private UIChampionshipTeamCreateFormView m_View;

	private UIModelChampionship m_ModelChampionship;

	private UIModelCollection m_ModelCollection;

	private int m_SelectChannelID;

	private List<uint> m_WaitModelPropIDs;

	private bool m_HasErr;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override string CustomTitle()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitContactInfo()
	{
	}

	private void Confirm()
	{
	}

	private string GetFixContactInfo()
	{
		return null;
	}

	private void SelectFlag()
	{
	}

	private void SelectChannel()
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

	private void ChannelSelectHandler(object[] args)
	{
	}

	private void _003COnUIInit_003Eb__11_0()
	{
	}

	public string _003C_003EiFixBaseProxy_CustomTitle()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
