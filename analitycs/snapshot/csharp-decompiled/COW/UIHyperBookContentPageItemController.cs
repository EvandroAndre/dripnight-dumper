using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHyperBookContentPageItemController : UIBaseController
{
	private sealed class _003CPlayProgressVarValueUpdateCoroutine_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHyperBookContentPageItemController _003C_003E4__this;

		public float value;

		private float _003Cpass_003E5__2;

		private float _003CbaseValue_003E5__3;

		private float _003CdeltaValue_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayProgressVarValueUpdateCoroutine_003Ed__42(int _003C_003E1__state)
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

	private const string COMMON_PAGE_COLLECTION_BG_NAME = "FF_UI_HyperBook_Frame";

	private const string HIDDEN_PAGE_COLLECTION_BG_NAME = "FF_UI_HyperBook_Frame_Hidden";

	private const string HIDDEN_PAGE_BUBBLE_NAME = "T_36_JH_WS_PRICELIMIT";

	private const string COMMON_PAGE_LABEL_COLOR_STR = "#A5EFFF";

	private const string GRAY_PAGE_LABEL_COLOR_STR = "#939393";

	private const string HIDDEN_PAGE_LABEL_COLOR_STR = "#D15E26";

	private const float COLLECTION_BG_WITH_MASK_ALPHA = 0.4f;

	private const float COLLECTION_BG_NORMAL_ALPHA = 1f;

	private const float PROGRESS_BAR_UPDATE_DURATION = 0.7f;

	private static readonly Vector2Int WEAPON_SPRITE_SIZE;

	private static readonly Vector3 WEAPON_SPRITE_EULER_ANGLES;

	private uint m_BookID;

	private int m_PageIdx;

	private float m_ProgressBarTargetValue;

	private Color m_CommonPageLabelColor;

	private Color m_GrayPageLabelColor;

	private Color m_HiddenPageLabelColor;

	private Coroutine m_ProgressBarValueUpdateCoroutine;

	private CollectionBookItemDesc m_PageItemDesc;

	private UIHyperBookContentPageItemView m_View;

	private HyperBookHiddenPageData m_HiddenPageData;

	private bool m_IsBigReward;

	private bool IsSetup => false;

	private bool IsBigReward
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool IsProgressBarShown => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void SetupItemView()
	{
	}

	private void LoadStaticContent()
	{
	}

	private void RefreshDynamicContent(bool playAnim = false)
	{
	}

	private void OnSelectBtnClick()
	{
	}

	private void AddEventDelegate()
	{
	}

	private CollectionBookItemDesc GetPageItemDesc()
	{
		return null;
	}

	private float GetPageItemProgressValue()
	{
		return 0f;
	}

	private Color GetPageIdxLabelColor(bool lightColor)
	{
		return default(Color);
	}

	private void SetProgressBarValueInternal(float value)
	{
	}

	private IEnumerator PlayProgressVarValueUpdateCoroutine(float value)
	{
		return null;
	}

	private void SetProgressBarValueIfShown(float value, bool playAnim)
	{
	}

	private void PrepareColor()
	{
	}

	private void RefreshCollectionIcon()
	{
	}

	private bool IsMaskNeedShow()
	{
		return false;
	}

	private bool IsHeadBubbleNeedShow()
	{
		return false;
	}

	private bool IsTipsNeedShow()
	{
		return false;
	}

	private bool IsLabelColorLight()
	{
		return false;
	}

	public void RefreshContent()
	{
	}

	public void SetViewData(uint bookID, int pageIdx)
	{
	}

	public void OnSelect()
	{
	}

	public void OnCancelSelect()
	{
	}

	private bool IsSpecialBook(uint bookID)
	{
		return false;
	}

	private void NeedShowGuide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
