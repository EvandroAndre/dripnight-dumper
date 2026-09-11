using System.Collections.Generic;
using COW.Gameplay.UGC;

namespace COW;

public class UIHUDUGC_SocialButtonWidgetController : UIHUDUGC_WidgetBaseController
{
	public UGCHudSocialButtonWidget m_SocialButtonWidget;

	private UGCHUDSocialButtonWidgetRepItem m_SocialButtonWidgetRep;

	private static Dictionary<ulong, float> s_AddFriendRequestCDList;

	protected override void OnDestroy()
	{
	}

	protected override void InitEntityData()
	{
	}

	public override void DestroyEntity()
	{
	}

	protected override void RefreshWidgetInfo()
	{
	}

	public override void BindWidget(UGCHudWidget widget)
	{
	}

	public override void RefreshAlpha()
	{
	}

	private void OnFriendRelationChange(object[] args)
	{
	}

	private void OnReportSent(object[] args)
	{
	}

	protected void OnTargetPlayerChangeEvent(string targetPlayer)
	{
	}

	protected void OnBtnTypeChangeEvent(int btnType)
	{
	}

	protected void OnShowTypeChangeEvent(int showType)
	{
	}

	private void OnBtnClick()
	{
	}

	private void CheckAddFriendState()
	{
	}

	private void AddFriendRequest()
	{
	}

	private void CheckReportState()
	{
	}

	private void OpenReportUIReq()
	{
	}

	private void CheckState()
	{
	}

	public void _003C_003EiFixBaseProxy_InitEntityData()
	{
	}

	public new void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshWidgetInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_BindWidget(UGCHudWidget P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshAlpha()
	{
	}
}
