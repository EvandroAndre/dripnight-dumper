using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFrontEndPreviewPrivilegeShowContainerController : UIBaseController, IClothTriggerEffectPreviewContext
{
	public enum EPrivilegeType
	{
		None,
		WeaponPrivilege,
		TriggerEffect
	}

	private sealed class _003C_003Ec__DisplayClass80_0
	{
		public uint featureId;

		internal bool _003CShowSelectedWeaponPrivilegeOnly_003Eb__0(UIFrontEndPreviewPrivilegeShowItemController item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass81_0
	{
		public uint triggerID;

		internal bool _003CShowSelectedTriggerEffectOnly_003Eb__0(UIFrontEndPreviewPrivilegeShowItemController item)
		{
			return false;
		}
	}

	private sealed class _003CStartAutoScroll_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIFrontEndPreviewPrivilegeShowContainerController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartAutoScroll_003Ed__45(int _003C_003E1__state)
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

	private UIFrontEndPreviewPrivilegeShowContainerView m_View;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private uint m_ItemId;

	private uint m_ShowPrivilgeDataID;

	private List<uint> m_ShowPrivilgeDataIDs;

	private EPrivilegeType m_ShowPrivilgeType;

	private int m_Height;

	private const float m_AutoScrollShowTime = 2f;

	private const float m_ShowLoopPrivilegeTime = 10f;

	private UICenterOnChild m_WrapCenter;

	private int m_NextShowIndex;

	private int m_CurrentShowIndex;

	private List<UIFrontEndPreviewPrivilegeShowItemController> m_ItemCtrls;

	private List<UIFrontEndPreviewPrivilegeShowItemController> m_ExpandedItemCtrls;

	private bool m_IsExpanded;

	private bool m_IsShowingSelectedPrivilegeOnly;

	private bool m_IsShowingPrivilegePreview;

	private bool m_IsInlinePrivilegePreviewActive;

	private UIClickMask m_UIClickMask;

	private const int SMALLCELLHEIGHT = 46;

	private int m_CellWidth;

	private const int m_MaxShowCount = 4;

	private bool m_IsScrollRunning;

	private int m_ActiveItemCount;

	private Coroutine m_AutoScrollCoroutine;

	private uint m_DelayCallStopShowPrivilege;

	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	private FrontEndPreviewPrivilegeContextAdapter m_PrivilegeContextAdapter;

	private Vector3 m_TableOriginVector;

	private uint m_ClothOrBundleId;

	private bool m_IsFemaleAvatar;

	private PreviewShowItemParams m_SavedPreviewParams;

	private uint m_SavedClothesSetID;

	private PreviewShowAvatarParams m_SavedAvatarParams;

	private ClothTriggerEffectPreviewHandler m_ClothTriggerEffectPreviewHandler;

	FrontEndPreviewComponent IClothTriggerEffectPreviewContext.FrontEndPreviewComponent => null;

	uint IClothTriggerEffectPreviewContext.ClothOrBundleId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	uint IClothTriggerEffectPreviewContext.ClothesSetID => 0u;

	bool IClothTriggerEffectPreviewContext.IsFemaleAvatar
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void CleanupPreviousItemHandler()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	public uint GetItemId()
	{
		return 0u;
	}

	private void OnFinished()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void SetData(uint itemId, FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	private void RefreshQualityBg()
	{
	}

	private void InitItemCtrlsOriginalPos()
	{
	}

	private IEnumerator StartAutoScroll()
	{
		return null;
	}

	private void OnArrowBtnClick()
	{
	}

	private void OnShowExpandedMenu()
	{
	}

	private void OnCloseExpandedMenu(bool startAutoScroll = true)
	{
	}

	private ResourceID GetTriggerEffectAnimResourceID(uint triggerID)
	{
		return default(ResourceID);
	}

	private float GetAnimationClipDuration(ResourceID animResID)
	{
		return 0f;
	}

	private float GetReturnDelayTime(EPrivilegeType privilegeType, uint privilegeDataID)
	{
		return 0f;
	}

	private bool HasMultiStateCloth(uint itemId)
	{
		return false;
	}

	private void RestorePreviousPreviewState()
	{
	}

	private void OnShowFullScreenPreview(object[] data)
	{
	}

	private void OnClosePrivilegePreview(object[] data)
	{
	}

	private void CleanupInlinePrivilegePreviewResources(bool clearPreviewModelAndCache)
	{
	}

	private void ReturnToIdle()
	{
	}

	private void OnCloseExpandedMenuFromMask()
	{
	}

	private void OnCloseExpandedMenuShowPrivilege()
	{
	}

	public void OnWeaponPrivilegeClick(uint featureId)
	{
	}

	public void OnTriggerEffectClick(uint triggerID)
	{
	}

	private void ShowWeaponPrivilege()
	{
	}

	private void ShowTriggerEffect()
	{
	}

	private void TryMergeKillAndBeKilled(List<uint> effectTriggerIDs)
	{
	}

	private void TryMergeKillAndKnockDown(List<uint> effectTriggerIDs)
	{
	}

	protected override void OnUIDestory()
	{
	}

	void IClothTriggerEffectPreviewContext.SwtichEffectAvatarPreview(bool isAvatarPreview)
	{
	}

	void IClothTriggerEffectPreviewContext.RefreshPreview(uint clothID, int clothEffectTriggerID, bool refreshNow, EPrivilegePreviewType privilegePreviewType)
	{
	}

	private void ShowSelectedWeaponPrivilegeOnly(uint featureId)
	{
	}

	private void ShowSelectedTriggerEffectOnly(uint triggerID)
	{
	}

	private void RestoreOriginalPrivilegeList()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
