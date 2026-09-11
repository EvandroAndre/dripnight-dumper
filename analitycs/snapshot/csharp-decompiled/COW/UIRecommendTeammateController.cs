using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIRecommendTeammateController : UIBaseController
{
	private UIRecommendTeammateView m_View;

	private const int AUTO_SHOW_DETAIL_COUNTDOWN = 10;

	private ulong m_UserID;

	private TeammateStats m_Target;

	private bool m_Confirm;

	private const string PRIMENICKNAMEKEY = "[x1.5][S0][-]{0}";

	private float m_CountDownTime;

	private bool m_IsInvite;

	private bool m_IsLeaderBoardTitleShowed;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void Update()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void CloseUI(bool isConfirm = false)
	{
	}

	private void SendEventLog(bool isClick)
	{
	}

	private void OnClickConfirmBtn()
	{
	}

	private void SendJoin()
	{
	}

	private void SendInvite()
	{
	}

	private bool CanUpdateCountDown()
	{
		return false;
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnClickClose()
	{
	}

	public void SetData(TeammateStats res, bool isTargetSingle, uint gameMode)
	{
	}

	private string BuildText(CriticalBehaviorInfo behavior)
	{
		return null;
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
