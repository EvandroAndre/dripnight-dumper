using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCBlockTemplateWndController : UIPopupWindowController, IEasyList
{
	private sealed class _003CRefreshMaskCoroutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudUGCBlockTemplateWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshMaskCoroutine_003Ed__22(int _003C_003E1__state)
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

	public static bool IsOpenedFromLocalFileManager;

	private UIHudUGCBlockTemplateWndView m_View;

	private UGCAssetExplorer m_Explorer;

	private List<BlockTemplateData> m_CustomDataList;

	private List<BlockTemplateData> m_LibraryDataList;

	private BlockTemplateData m_CurrentData;

	private string m_CustomSelectedID;

	private string m_LibrarySelectedID;

	private int m_TipPadding;

	private int m_TipDescBgMinHeight;

	private int m_TipDescBgPadding;

	private UIRoot m_UIRoot;

	private Transform m_TipTrs;

	private List<UIWorkshopModeTagController> m_Tags;

	private Dictionary<int, string> m_TagData;

	protected UIClickMask m_UIClickMask;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void ShowTutorial()
	{
	}

	private void RefreshTipPosition()
	{
	}

	private void RefreshMask()
	{
	}

	private IEnumerator RefreshMaskCoroutine()
	{
		return null;
	}

	private void RefreshTipContent()
	{
	}

	public void OnItemSelect(BlockTemplateData blockTemplateData = null, Transform tipTrs = null)
	{
	}

	public void UnSelectItem()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnWebViewBtnClick()
	{
	}

	private void OnTipEditBtnClick()
	{
	}

	private void OnTipDeleteBtnClick()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnToggleSelect(UIToggleButton btn)
	{
	}

	private void OnBlockTemplateDragOut()
	{
	}

	private void OnUIBlockTemplateSave()
	{
	}

	public void SelectCustomTemplateById(string assetId)
	{
	}

	private bool _003CUnSelectItem_003Eb__25_0(BlockTemplateData item)
	{
		return false;
	}

	private bool _003CUnSelectItem_003Eb__25_1(BlockTemplateData item)
	{
		return false;
	}

	private void _003COnTipDeleteBtnClick_003Eb__29_0()
	{
	}

	private void _003COnTipDeleteBtnClick_003Eb__29_1()
	{
	}

	private void _003COnTipDeleteBtnClick_003Eb__29_2()
	{
	}

	private bool _003COnToggleSelect_003Eb__32_0(BlockTemplateData item)
	{
		return false;
	}

	private bool _003COnToggleSelect_003Eb__32_1(BlockTemplateData item)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
