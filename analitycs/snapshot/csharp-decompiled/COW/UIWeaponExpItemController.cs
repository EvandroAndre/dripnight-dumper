using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using proto;
using tcp;

namespace COW;

internal class UIWeaponExpItemController : UIBaseController
{
	protected UIWeaponExpItemView m_View;

	protected WeaponExpUpdateInfo m_Info;

	private HENEHAGJCLI m_ItemData;

	private UIModelWeaponProficiency m_ModelWeaponExp;

	protected uint m_DelayCallId;

	protected const float ShowProgressDelayTime = 0.85f;

	protected bool m_OnlyShowMax;

	protected uint m_NowExp;

	protected uint m_TargetExp;

	protected float m_NowProgressBarValue;

	protected float m_TargetProgressBarValue;

	protected bool m_IsUpdateProgress;

	private readonly List<string> m_LevelIconList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public virtual void SetWeaponExpData(WeaponExpUpdateInfo info)
	{
	}

	protected virtual void UpdateIcon(int level)
	{
	}

	protected void UpdateGoPosBtn()
	{
	}

	protected virtual void OnGoPosBtnCLick()
	{
	}

	public virtual void ShowUpdateProgress()
	{
	}

	public float CalcProgressBarValue(float target, WeaponExpLevelDesc levelDesc)
	{
		return 0f;
	}

	public float CalcProgressBarValue(float target, uint downer_bound, uint upper_bound)
	{
		return 0f;
	}

	public void DisableVFX()
	{
	}

	private void Update()
	{
	}

	private void UpdateWeaponExpV1()
	{
	}

	private void UpdateWeaponExpV2()
	{
	}

	protected void ShowMax()
	{
	}

	private void UpdateRankLabel()
	{
	}

	public void SetOnlyShowMax()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003CShowUpdateProgress_003Eb__19_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
