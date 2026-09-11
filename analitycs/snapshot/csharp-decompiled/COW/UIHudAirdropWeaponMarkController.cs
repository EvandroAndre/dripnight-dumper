using System;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudAirdropWeaponMarkController : UIHudNameBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__22_0;

		internal void _003CTempHideAirdropWeaponMark_003Eb__22_0()
		{
		}
	}

	private LevelAirdrop m_Target;

	private UIHudAirdropWeaponMarkView m_View;

	private Vector3 m_bindWorldPosition;

	private uint m_MainItemID;

	private uint m_HideOnBeHitDelayCall;

	private uint m_CurrentShowMarkAirdropID;

	private int m_LastAirdropMarkUpdateFrameCount;

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

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override void LateUpdate()
	{
	}

	private void Bind(LevelAirdrop target)
	{
	}

	private void CustomSetVisible(bool visible)
	{
	}

	private void UpdateItemIcon()
	{
	}

	private void ShowAirdropWeaponMark(LevelAirdrop target)
	{
	}

	private void HideAirdropWeaponMark(uint airdropId)
	{
	}

	private void UpdateAirdropWeaponMark()
	{
	}

	private void OnPlayerBeHit(object[] args)
	{
	}

	private void TempHideAirdropWeaponMark()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_LateUpdate()
	{
	}
}
