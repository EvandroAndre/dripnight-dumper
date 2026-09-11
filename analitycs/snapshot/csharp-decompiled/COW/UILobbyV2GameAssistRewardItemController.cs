using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UILobbyV2GameAssistRewardItemController : UILobbyV2GameAssistNormalItemController
{
	private UILobbyV2GameAssistRewardItemView m_View;

	private AssistMemberShipCardInfo m_Info;

	private UIModelGameAssistantIntroduction m_ModelGameAssistantIntroduction;

	private UIStandardItemMiniController m_GemItemCtrl;

	private UIModelMemberShip m_ModelMemberShip;

	private List<UISprite> m_CardSpriteList;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void SetRead()
	{
	}

	private void BtnClaimAllOnClick()
	{
	}

	private void RefreshRewardView()
	{
	}

	private void RefreshCard()
	{
	}

	private void RefreshReward()
	{
	}

	protected override void SetViewData(object data, int index)
	{
	}

	public void SetBtnClaimAllState(bool show)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetRead()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
