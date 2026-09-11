using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIUGCHudEditListController : UIPopupWindowController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<NLNAMPBAGDC> _003C_003E9__29_0;

		internal int _003CUpdateHudPrefabList_003Eb__29_0(NLNAMPBAGDC a, NLNAMPBAGDC b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public UIUGCHudEditorController editorUI;

		public UIUGCHudEditListController _003C_003E4__this;

		internal void _003COnClickEditPrefab_003Eb__0()
		{
		}
	}

	private sealed class _003CGenerateHudTemplateImage_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCHudEditListController _003C_003E4__this;

		private UITutorialIndicatorController _003CtutorialIndicator_003E5__2;

		private bool _003CisTutorialIndicatorHided_003E5__3;

		private RenderTexture _003CrenderTexture_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGenerateHudTemplateImage_003Ed__46(int _003C_003E1__state)
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

	public static bool ShowHudTemplateTutorial;

	private UIUGCHudEditListView m_View;

	private UIModelUGCHudEdit m_Model;

	private UIModelSceneEdit m_ModelScene;

	private UIModelUGCResourceSelect m_ResourceModel;

	private UGCAssetExplorer m_Explorer;

	private NLNAMPBAGDC m_CurrentHudData;

	private NGIALHFGCPL m_CurrentEditState;

	private List<NLNAMPBAGDC> m_Prefabs;

	private UIUGCHudEditPopupMenuPanelController m_MenuPanel;

	private UIUGCHudEditPopupMenuPanelController.MenuItemData[] m_MenuItemDatas;

	private UGCHudPrefabRoot m_PrefabPreview;

	private int m_SelectedIndex;

	private GameObject m_ScreenshotCameraObject;

	private Camera m_ScreenshotCamera;

	private const int m_ScreenshotWidth = 172;

	private const int m_ScreenshotHeight = 100;

	private bool m_OpenEditUI;

	private HNDHJGJILHC m_SceneEditGame;

	private ulong m_StartTime;

	private HashSet<string> NamesForDuplicationCheck;

	private Color m_DefaultButtonHoverColor;

	private Color m_DefaultButtonPressedColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private NLNAMPBAGDC CreateGuideHudPrefab()
	{
		return null;
	}

	private NLNAMPBAGDC CreateEmptyHudPrefab()
	{
		return null;
	}

	private void RefreshHudList()
	{
	}

	private void UpdateHudPrefabList()
	{
	}

	private void RebuildPrefab()
	{
	}

	private void OnEntityGetter(object[] data)
	{
	}

	private void OnNewBtnClick()
	{
	}

	private void OnFinalSelected(string assetKey, int itemID)
	{
	}

	public void InstantiateHudTemplate(UGCAssetMetadata metaData)
	{
	}

	private void OnClickUseTemplate()
	{
	}

	private string GetNewHudNameFromTemplate(NLNAMPBAGDC templateHudData)
	{
		return null;
	}

	private void OnLayoutGuide(object[] data)
	{
	}

	private void OnCloseHudEditList(object[] data)
	{
	}

	private void OnClickEditPrefab()
	{
	}

	private void OnClickScript()
	{
	}

	private void DoMenuRename()
	{
	}

	private void DoMenuCopy()
	{
	}

	private string GetNewHudNameForCopy(string baseName)
	{
		return null;
	}

	private void DoMenuSaveTemplate()
	{
	}

	private IEnumerator GenerateHudTemplateImage()
	{
		return null;
	}

	private void DoMenuDelete()
	{
	}

	private void ForceSelectItem(int index)
	{
	}

	private void SelectItem(int index)
	{
	}

	private void LongPressItem(int index, Vector3 position)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void UpdateEditState()
	{
	}

	private void UpdateClickScriptButtonLable(object[] data)
	{
	}

	private void RefreshItemView()
	{
	}

	private void _003CDoMenuRename_003Eb__41_0(string newName)
	{
	}

	private void _003CDoMenuDelete_003Eb__47_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
