using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIUGCRecommendationPopController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public enum ERecommendationSrc
	{
		EEditorMainRec,
		EEditorSideRec,
		EHot,
		ESelfdom,
		EExternalDisplay,
		EExternalNewPlayer
	}

	private sealed class _003CReposition_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCRecommendationPopController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CReposition_003Ed__17(int _003C_003E1__state)
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

	private UIUGCRecommendationPopView m_View;

	private UIModelSceneEdit m_Model;

	private ERecommendationSrc m_Src;

	private List<UISceneEditRecommendMapItemController> m_CachedSelfdomMapItemList;

	private List<UIUGCRecommendationPopMapSlotController> m_CachedUnifiedMapSlotList;

	private int CDNTextureHeight;

	private float DescOrginalPosY;

	public Action<SceneEditSlotInfo> OnClickMap;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ERecommendationSrc src, WorkshopEditorChoiceDesc desc, List<UISceneEditRecommendationItemInfo> infos = null)
	{
	}

	private void ProcessEditorChoiceRec(WorkshopEditorChoiceDesc desc)
	{
	}

	private void ProcessHot()
	{
	}

	private void ProcessExternalNewPlayer(WorkshopEditorChoiceDesc desc, List<UISceneEditRecommendationItemInfo> infos)
	{
	}

	private void ProcessExternalDisplay(WorkshopEditorChoiceDesc desc, List<UISceneEditRecommendationItemInfo> infos)
	{
	}

	private void ProcessSelfdomRec()
	{
	}

	private IEnumerator Reposition()
	{
		return null;
	}

	private void OnBlackBGClick()
	{
	}

	private void OnRecomRefreshBtnClick()
	{
	}

	private void RefreshEditorChoiceItems(List<WorkshopEditorChoiceInfo> data)
	{
	}

	private void RefreshSelfdomRecommendMapItems(List<WorkshopPersonalRecommendationInfo> mapDataList)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnUIInit_003Eb__10_0()
	{
	}

	private void _003CProcessEditorChoiceRec_003Eb__12_0()
	{
	}

	private void _003CProcessExternalNewPlayer_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
