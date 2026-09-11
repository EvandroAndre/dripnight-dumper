using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class WeaponSkinFeaturePreviewHandler
{
	private sealed class _003CSelectPrivilegeItemAfterInit_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIChangeWeaponPreviewMainController ctrl;

		public int weaponSkinFeature;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSelectPrivilegeItemAfterInit_003Ed__14(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private IWeaponSkinFeaturePreviewContext m_Context;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIMaleAvatar m_ManagedAvatar;

	private List<GameObject> m_BackEffects;

	private WeaponSkinData m_SkinDataForBackEffect;

	private int m_Weapon2DSoundLoop;

	private GameObject m_FireSoundAudioSource;

	private bool m_LastKillAnimTransformApplied;

	private Vector3 m_SavedAvatarLocalPos;

	private Quaternion m_SavedAvatarLocalRot;

	private Vector3 m_SavedAvatarLocalScale;

	public WeaponSkinFeaturePreviewHandler(IWeaponSkinFeaturePreviewContext context)
	{
	}

	public void RefreshFeatureView(uint weaponSkinID, WeaponSkinFeature weaponSkinFeature)
	{
	}

	private static void OpenPrivilegePreviewWindow(uint weaponSkinID, int weaponSkinFeature)
	{
	}

	private static IEnumerator SelectPrivilegeItemAfterInit(UIChangeWeaponPreviewMainController ctrl, int weaponSkinFeature)
	{
		return null;
	}

	private bool ShouldOpenPrivilegePreviewWindow(WeaponSkinFeature weaponSkinFeature, WeaponSkinData weaponSkinData)
	{
		return false;
	}

	private void HandleAnnouncementAdd(uint weaponSkinID, WeaponSkinData weaponSkinData, WeaponSkinFeature weaponSkinFeature)
	{
	}

	private void HandleEmoteObtain(uint weaponSkinID, WeaponSkinData weaponSkinData)
	{
	}

	private void HandleReloadWeaponSound(uint weaponSkinID, WeaponSkinData weaponSkinData)
	{
	}

	private void HandleReloadAnim(uint weaponSkinID, WeaponSkinData weaponSkinData)
	{
	}

	private void HandleMeleeModelModify(uint weaponSkinID)
	{
	}

	private void HandleMeleeFiringEffectAdd(uint weaponSkinID, WeaponSkinData weaponSkinData, WeaponSkinFeature weaponSkinFeature)
	{
	}

	private void HandleEffectTriggerAnim(uint weaponSkinID, WeaponSkinData weaponSkinData)
	{
	}

	private void HandleLastKillAnim(uint weaponSkinID, WeaponSkinData weaponSkinData)
	{
	}

	private void HandleChangeAppearance(uint weaponSkinID, WeaponSkinData weaponSkinData)
	{
	}

	private void HandleMultiAppearance(uint weaponSkinID, WeaponSkinData weaponSkinData)
	{
	}

	private void HandleFinishMove(WeaponSkinData weaponSkinData)
	{
	}

	private void HandleChangeWeaponSound(uint weaponSkinID, WeaponSkinData weaponSkinData)
	{
	}

	private void HandleChangeWeaponAnim(uint weaponSkinID, WeaponSkinData weaponSkinData)
	{
	}

	private void HandleKillUIFX(uint weaponSkinID)
	{
	}

	private void HandleBackEffect(uint weaponSkinID, WeaponSkinData weaponSkinData, WeaponSkinFeature weaponSkinFeature)
	{
	}

	private void SetBackEffect(UIStatedAvatar s)
	{
	}

	private void ClearBackEffects()
	{
	}

	public void CleanupPrivilegeResources()
	{
	}

	public void Cleanup()
	{
	}

	private bool IsDualWeild(WeaponSkinData data)
	{
		return false;
	}

	private bool IsLoopKillNotify()
	{
		return false;
	}

	private void HandleSightReskin(uint weaponSkinID, WeaponSkinData weaponSkinData)
	{
	}

	private void HandleHUDHitEffectAdd(WeaponSkinData weaponSkinData)
	{
	}
}
