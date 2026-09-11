using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIMileStoneNavigationController : UINavigationController, IUIModelDataChangeObserver, ITipsDelegate
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__17_0;

		public static Action _003C_003E9__18_0;

		internal void _003COnWeaponProficiencyEntranceClicked_003Eb__17_0()
		{
		}

		internal void _003COnAchievementEntranceClicked_003Eb__18_0()
		{
		}
	}

	private UIMileStoneNavigationView m_View;

	private uint m_VfxDelayCallId;

	private UIModelAchievement m_ModelAchievement;

	private UIModelWeaponProficiency m_ModelWeaponProficiency;

	private Animator m_WeaponProfAnimator;

	private GameObject m_WeaponProfClickVFX;

	private Animator m_AchieveAnimmator;

	private GameObject m_AchieveClickVFX;

	private bool m_IsLow;

	private UITipsNormalController m_AchievementTipsCtrl;

	private UITipsNormalController m_ProficiencyTipsCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void UpdateWeaponProficiencyInfo()
	{
	}

	private void UpdateAchievementInfo()
	{
	}

	private void OnWeaponProficiencyEntranceClicked()
	{
	}

	private void OnAchievementEntranceClicked()
	{
	}

	private void ShowSystemNotOpenMsg()
	{
	}

	private void StopClickVfx()
	{
	}

	private void LoadAnimAndVFX()
	{
	}

	private void PlayAnimOnNavigationShowed()
	{
	}

	private void PlayAnimOnAchievementEntranceClick()
	{
	}

	private void PlayAnimOnWeaponProfEntranceClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void TryInitTips()
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
