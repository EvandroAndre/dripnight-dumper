using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIClanLevelUpController : UIPopupWindowController
{
	private UIClanLevelUpViewExt m_View;

	private UIModelClan m_ModelClan;

	private UIModelMall m_ModelMall;

	private bool m_IsAnimFinshed;

	private uint m_animFinishDelayCall;

	private List<UIClanWarLeaderboardMemberController> m_MemberList;

	private const int MAX_RANK_COUNT = 3;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void SetLevelData(ClanInfo clanInfo)
	{
	}

	private void TryShowClanActiveInternalRank()
	{
	}

	private void TryShowNoActivenessChange()
	{
	}

	private void OnGotoClanMallBtnClick()
	{
	}

	private void OnGotoActiveBtnClick()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void _003CSetLevelData_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
