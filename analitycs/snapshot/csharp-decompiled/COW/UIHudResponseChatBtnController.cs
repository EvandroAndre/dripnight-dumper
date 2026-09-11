using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudResponseChatBtnController : UIBaseController
{
	private UIHudResponseChatBtnView m_View;

	private uint m_DisappearCallID;

	private uint m_ResponseChatID;

	private BHGGAEEHJCO m_PlayerID;

	private uint m_LevelObjectType;

	private uint m_ItemID;

	private IngameQuickChatData m_quickChatData;

	private Vector3 m_AutoEnemyMarkPos;

	private EHKLJKOLFBM m_AutoEnemyMarkState;

	private bool m_IsAutoEnemyMarkState;

	private uint m_AutoEnemyMarkDelayCallId;

	private float m_MarkCD;

	private UIHudQuickChatV2ComboController ComboCtrl => null;

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

	private void RefreshTeammateEighthIcon(uint PlayerID, uint iconType)
	{
	}

	private void RefreshEightInLandState()
	{
	}

	private void RefreshIIV1v1BattleSceneLikeHUD(GEvent data)
	{
	}

	private void RefreshIIVFloatingLandHUD(uint PlayerID, uint joinTime)
	{
	}

	private void OnRecvQuickChatMsg(object[] data)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void SetResponseBg(int playerIndex, byte teamId)
	{
	}

	private void OnBtnClick()
	{
	}

	private bool HasTeammateInTeam()
	{
		return false;
	}

	private void OnHitEnemyByServer(object[] data)
	{
	}

	private void OnAutoEnemyMarkBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void NotifyComboShow()
	{
	}

	private void NotifyComboHide()
	{
	}

	private void OnAutoEnemyMarkEnterCD()
	{
	}

	private void OnUGCFactionChange(object[] param)
	{
	}

	private void _003COnRecvQuickChatMsg_003Eb__21_0()
	{
	}

	private void _003COnHitEnemyByServer_003Eb__27_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
