using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIBM26_SYSMissionPopupWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIBM26SysMissionPopupWndView m_View;

	private List<UIBM26_SYSMissionItemController> mItemCtrls;

	private UIModelActivity m_ModelActivity;

	private UIModelBigEvent m_ModelBigEvent;

	private UIModelBM26_SYS m_UIModelBM26_SYS;

	private uint m_DelayKey;

	private bool m_FirstIn;

	private bool m_claimAble;

	private bool m_TweenPlaying;

	private uint m_delayKeyID;

	private uint m_delayEnableKeyID;

	private uint m_delayEnableKeyID2;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClickClose()
	{
	}

	private void PlayTweenInAnimation()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	private void PlayTweenOutAnimation()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	private void OnClickAllClaimedBtn()
	{
	}

	private void InitMissionView()
	{
	}

	private void FreshDailyMissionView()
	{
	}

	private void FreshTokenInGame()
	{
	}

	private void PlayDialogInAni()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnUIInit_003Eb__9_0()
	{
	}

	private void _003CPlayTweenOutAnimation_003Eb__15_0()
	{
	}

	private void _003CPlayDialogInAni_003Eb__24_0()
	{
	}

	private void _003CPlayDialogInAni_003Eb__24_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
