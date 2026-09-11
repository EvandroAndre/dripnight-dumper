using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudFloatingLandProgressBarController : UIBaseController
{
	private UIHudFloatingLandProgressBarView m_View;

	private LevelFloatingLand m_floatingLand;

	private StringBuilder m_Timer;

	private Player m_localPlayer;

	private uint m_preProgressValue;

	private int m_duration;

	private int m_leftTime;

	private int m_barEffectSpeed;

	private uint m_addScoreDelay;

	private float m_addScoreDelayTime;

	private Queue<TweenPositionArc> m_FlyObjectPool;

	private List<TweenPositionArc> m_AllFlyObj;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	private void UpdateProgress(uint value)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnHideFloatingLand(object[] data)
	{
	}

	private void OnFloatingLandSuccess(object[] data)
	{
	}

	private void OnPlaySuccessCountDown(int option)
	{
	}

	private void OnPlayBeKill(object[] data)
	{
	}

	private void OnAddMoreScore(object[] data)
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	private void OnMatchEnd(object[] data)
	{
	}

	public void PlayFly(float flySpeed = 1f)
	{
	}

	private void OnFlyObjEnd(TweenPositionArc flyObj)
	{
	}

	private void _003CUpdate_003Eb__14_0()
	{
	}

	private void _003COnPlaySuccessCountDown_003Eb__19_0()
	{
	}

	private void _003COnPlayBeKill_003Eb__20_0()
	{
	}

	private void _003COnAddMoreScore_003Eb__21_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}
}
