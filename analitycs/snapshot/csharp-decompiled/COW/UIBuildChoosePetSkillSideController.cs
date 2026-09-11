using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBuildChoosePetSkillSideController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public enum SkillTemplateType
	{
		SkillItem,
		SplitLine,
		ActiveEquipped
	}

	private sealed class _003CDisableDragUntilAnimationComplete_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBuildChoosePetSkillSideController _003C_003E4__this;

		private UIScrollView _003CscrollView_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDisableDragUntilAnimationComplete_003Ed__41(int _003C_003E1__state)
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

	private uint m_SkillNum;

	private int m_LastClickIndex;

	private bool m_IsFirstTimeOpen;

	private List<PetInfo> m_PetInfoList;

	private UIBuildChoosePetSkillSideView m_View;

	private UIModelPet m_ModelPet;

	private UIModelLoadout m_ModelLoadout;

	private bool m_IsCSBPMode;

	private const float CSBP_TOP_OFFSET = 42f;

	private const float CSBP_BOTTOM_OFFSET = 36f;

	private const float CSBP_ARROW_EXTRA_OFFSET = 5f;

	private const float CSBP_CLIPREGION_EXTRA_HEIGHT = 5f;

	private const float CSBP_CLIPREGION_CENTER_OFFSET = 2.5f;

	private Vector3 m_OriginalScrollViewPosition;

	private Vector3 m_OriginalPetSkillListPosition;

	private Vector3 m_OriginalRightArrowButtonPosition;

	private Vector3 m_OriginalBgPosition;

	private Vector3 m_OriginalBgScale;

	private Vector3 m_OriginalBgColliderCenter;

	private Vector3 m_OriginalBgColliderSize;

	private Vector4 m_OriginalClipRegion;

	public bool IsCSBPMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void Awake()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	private void BuildCloseSide()
	{
	}

	private void InitPetSkillTemplate()
	{
	}

	private void GetSkillList()
	{
	}

	private void PetInfoListRefresh(List<PetInfo> petInfoList, bool flag = false)
	{
	}

	private void Refresh()
	{
	}

	public void RefreshListDataNotScroll()
	{
	}

	public void SetData()
	{
	}

	public void ScrollToItem()
	{
	}

	public void SetClickIndex(int index)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private IEnumerator DisableDragUntilAnimationComplete()
	{
		return null;
	}

	private void ApplyCSBPLayout()
	{
	}

	private UITable2.IUITable2Item _003CInitPetSkillTemplate_003Eb__31_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitPetSkillTemplate_003Eb__31_1()
	{
		return null;
	}

	private bool _003CGetSkillList_003Eb__32_0(PetInfo a)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
