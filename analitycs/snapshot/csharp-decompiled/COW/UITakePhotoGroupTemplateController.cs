using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UITakePhotoGroupTemplateController : UITakePhotoGroupTemplateBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<PhotoBackGroundData> _003C_003E9__31_0;

		internal bool _003CRefreshPhotoBgTab_003Eb__31_0(PhotoBackGroundData photoBgData)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public uint templateId;

		internal bool _003CRefreshTemplateList_003Eb__0(GroupPhotoTemplateData x)
		{
			return false;
		}
	}

	private sealed class _003CRefreshAnchor_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITakePhotoGroupTemplateController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshAnchor_003Ed__23(int _003C_003E1__state)
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

	private sealed class _003CRefreshBigEventGroundList_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITakePhotoGroupTemplateController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshBigEventGroundList_003Ed__34(int _003C_003E1__state)
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

	private sealed class _003CRefreshGroundEditList_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITakePhotoGroupTemplateController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshGroundEditList_003Ed__22(int _003C_003E1__state)
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

	private sealed class _003CRefreshTemplateList_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint templateId;

		public UITakePhotoGroupTemplateController _003C_003E4__this;

		public List<GroupPhotoTemplateData> list;

		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshTemplateList_003Ed__21(int _003C_003E1__state)
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

	private UITakePhotoGroupTemplateView m_View;

	private List<GroupPhotoTemplateData> m_TemplateDataList;

	private List<GroupPhotoTemplateData> m_ShowTemplateDataList;

	private List<PhotoEditBackgroundData> m_EditBackGroundDatas;

	private uint m_SelectedTemplateId;

	private uint m_SelectedBackGroundId;

	private UIModelTakePhoto m_ModelTakePhoto;

	private bool m_IsSquadTreasure;

	private ETemplateType m_TemplateType;

	private UITipsNormalController m_TipsCtrlPhotoTemplate;

	private UITipsNormalController m_TipsCtrlPhotoEditBackGround;

	private List<PhotoBackGroundData> m_BigEventBackGroundDatas;

	private uint m_SelectedPhotoBgId;

	private string m_CurrentFrontBgCdnUrl;

	private uint m_CurrentFrontBgEndTime;

	private Action m_CurrentFrontBgCallBack;

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

	protected override UIEasyListItemController OpenItemControllerInteral(Transform parent)
	{
		return null;
	}

	protected override void InitView()
	{
	}

	protected override string GetExpandAnimStr(bool isExpand)
	{
		return null;
	}

	public void SetIsSquadTreasure(bool isSquadTreasure)
	{
	}

	public override void SetData(List<GroupPhotoTemplateData> list, uint templateId = 0u, uint templateType = 0u)
	{
	}

	private void RefreshTabButtonStates()
	{
	}

	private void InitEditBackGroundDatas()
	{
	}

	private IEnumerator RefreshTemplateList(List<GroupPhotoTemplateData> list, uint templateId = 0u)
	{
		return null;
	}

	private IEnumerator RefreshGroundEditList()
	{
		return null;
	}

	private IEnumerator RefreshAnchor()
	{
		return null;
	}

	public void HideCheckContainer()
	{
	}

	private void OnBackGrouundEditBtnClick()
	{
	}

	private void OnPhotoTemplateBtnClick()
	{
	}

	private void OnInitPhotoBgTab()
	{
	}

	public void ClearPhotoBgData()
	{
	}

	public void RefreshPhotoBgTab()
	{
	}

	private void OnBigEventGroundBtnClick()
	{
	}

	private void InitBigEventBackGroundDatas()
	{
	}

	protected IEnumerator RefreshBigEventGroundList()
	{
		return null;
	}

	public void OnSelectBigEventGround(PhotoBackGroundData bigEventBackGroundData, Action successCallBack = null)
	{
	}

	protected void SetBgFrontEndScene(string frontBgCdn, uint endTime, Action successCallBack = null)
	{
	}

	protected void ClearBgFrontEndScene()
	{
	}

	private Vector3 CalculateBottomAnchoredPosition()
	{
		return default(Vector3);
	}

	private void SetFrontBgCdnTexture(string url, uint endTime)
	{
	}

	private void ClearFrontBgCdnTexture()
	{
	}

	public void OnFrontBgDownloadFailed(CDNDownloadFailedInfo info)
	{
	}

	private void OnFrontBgDowloadFinished(ResultTextureInfo texture)
	{
	}

	private void CheckFrontBgCdnTextureIsCorrect(string url, uint endTime)
	{
	}

	public override void OnSelectTemplate(GroupPhotoTemplateData templateData)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshTemplateListAfterDownload()
	{
	}

	private void RefreshGroupTemplateRedTipsWhenUIClose()
	{
	}

	private bool _003CRefreshPhotoBgTab_003Eb__31_1(GroupPhotoTemplateData x)
	{
		return false;
	}

	private bool _003CRefreshBigEventGroundList_003Eb__34_0(PhotoBackGroundData x)
	{
		return false;
	}

	private bool _003CRefreshTemplateListAfterDownload_003Eb__50_0(GroupPhotoTemplateData x)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(List<GroupPhotoTemplateData> P0, uint P1, uint P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSelectTemplate(GroupPhotoTemplateData P0)
	{
	}
}
