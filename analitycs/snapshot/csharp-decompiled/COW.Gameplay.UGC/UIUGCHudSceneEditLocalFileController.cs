using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UIUGCHudSceneEditLocalFileController : UIPopupWindowController, IEasyList
{
	public enum EOpenMode
	{
		Normal,
		Upload
	}

	private enum EViewMode
	{
		Details,
		Preview
	}

	public enum ESortFliterType
	{
		Name,
		Date,
		Type,
		Size
	}

	private enum EFilterType
	{
		All,
		MapRef
	}

	public class FileTypeTabData
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Comparison<UGCAssetMetadata> _003C_003E9__12_1;

			public static Comparison<UGCAssetMetadata> _003C_003E9__12_2;

			public static Comparison<UGCAssetMetadata> _003C_003E9__12_3;

			internal int _003CSortFileList_003Eb__12_1(UGCAssetMetadata a, UGCAssetMetadata b)
			{
				return 0;
			}

			internal int _003CSortFileList_003Eb__12_2(UGCAssetMetadata a, UGCAssetMetadata b)
			{
				return 0;
			}

			internal int _003CSortFileList_003Eb__12_3(UGCAssetMetadata a, UGCAssetMetadata b)
			{
				return 0;
			}
		}

		private sealed class _003C_003Ec__DisplayClass12_0
		{
			public string locale;

			internal int _003CSortFileList_003Eb__0(UGCAssetMetadata a, UGCAssetMetadata b)
			{
				return 0;
			}
		}

		public IHDACHNBFNG Type;

		private ESortFliterType m_eSortFliterType;

		private List<UGCAssetMetadata> _003CTypeAssets_003Ek__BackingField;

		public Action<IHDACHNBFNG, UGCAssetMetadata> OnClick;

		public string Name => null;

		public int Count => 0;

		public List<UGCAssetMetadata> TypeAssets
		{
			get
			{
				return _003CTypeAssets_003Ek__BackingField;
			}
			private set
			{
				_003CTypeAssets_003Ek__BackingField = value;
			}
		}

		public void RefreshAssets(List<UGCAssetMetadata> assetDataList)
		{
		}

		public void Sort(ESortFliterType eSortFliterType)
		{
		}

		private void SortFileList()
		{
		}

		public FileTypeTabData(IHDACHNBFNG type, Action<IHDACHNBFNG, UGCAssetMetadata> onClick)
		{
		}
	}

	private UIHudSceneEditLocalFilePanelView m_View;

	private EOpenMode m_OpenMode;

	private IHDACHNBFNG m_ResourceType;

	private EViewMode m_CurrentViewMode;

	private List<int> m_TabList;

	private Dictionary<int, FileTypeTabData> m_TabDataDictionary;

	private ESortFliterType m_CurrentSelectdSortFliter;

	private EFilterType m_CurrentSelectdFilterType;

	private List<UIUGCHudSceneEditLocalFileTypeItemController> m_FileTypeTabItemCache;

	private UIClickMask m_ClickMask;

	private GameObject[] m_SortHighLightArray;

	private UILabel[] m_SortLabelsArray;

	private GameObject[] m_FilterHighLightArray;

	private UILabel[] m_FilterLabelsArray;

	private UGCAssetExplorer m_Explorer;

	private HNDHJGJILHC m_Game;

	private SceneEditResourceShopManager m_ShopManager;

	private UGCAssetMetadata m_SelectedAssetMetadata;

	private UINewDownloadInfoController mDownloadCtrl;

	private ShowPreview m_ShowPreview;

	private Vector2Int m_PreviewTextureSize;

	private bool m_IsReferencedByMap;

	private List<string> m_TipsData;

	private UGCQuery m_Query;

	private bool IsSearch => false;

	private List<UGCAssetMetadata> CurrTypeAssetList => null;

	public static void OpenLocalFile(EOpenMode openMode = EOpenMode.Normal, IHDACHNBFNG resourceType = IHDACHNBFNG.GameObject, string uuidWithVersion = "")
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private List<UGCAssetMetadata> RefreshQuery()
	{
		return null;
	}

	private void OnBtnFilterAllClicked()
	{
	}

	private void OnBtnFilterMapRefClicked()
	{
	}

	private void RefreshRefFilterState()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(EOpenMode openMode, IHDACHNBFNG resourceType, string uuidWithVersion = "")
	{
	}

	private UGCAssetMetadata GetAssetMetaData(List<UGCAssetMetadata> list, string uuidWithVersion)
	{
		return null;
	}

	private void RefreshFilterButtonState(EFilterType eFilterType)
	{
	}

	private void RefreshSortButtonState(ESortFliterType sort)
	{
	}

	private void RefreshFileTypeTabDataList(bool showAllType = true)
	{
	}

	private void RefreshFileTypeCount()
	{
	}

	private void RefreshSelectButtonState(IHDACHNBFNG type)
	{
	}

	private void OnCloseBtnClicked()
	{
	}

	private void OnBtnModeClicked()
	{
	}

	private void RefreshTableData(List<UGCAssetMetadata> list)
	{
	}

	private void RefreshViewMode(List<UGCAssetMetadata> list, UGCAssetMetadata selected = null)
	{
	}

	private void OnHelpBtnClicked()
	{
	}

	private void OnBtnFilterClicked()
	{
	}

	private void OnBtnSortClicked()
	{
	}

	private void OnBtnGoToStoreClicked()
	{
	}

	private void OnBtnSortNameClicked()
	{
	}

	private void OnBtnSortDateClicked()
	{
	}

	private void OnBtnSortTypeClicked()
	{
	}

	private void OnBtnSortSizeClicked()
	{
	}

	private void OnBtnClearClicked()
	{
	}

	private void OnSearchInputChange()
	{
	}

	private void OnSearchInputSubmit()
	{
	}

	private void OnBtnUseClicked()
	{
	}

	private void OnBtnUploadClicked()
	{
	}

	private void OnBtnDeleteClicked()
	{
	}

	private void OnFileInputSubmit()
	{
	}

	private void OnBtnRenameClicked()
	{
	}

	private void SetSelectedTypeData(IHDACHNBFNG type, UGCAssetMetadata selected = null)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void EmptyDetailsView()
	{
	}

	private void OnItemClicked(UGCAssetMetadata assetMetadata)
	{
	}

	private void ShowFileDetails(UGCAssetMetadata assetMetadata)
	{
	}

	private void _003COnBtnUploadClicked_003Eb__64_0()
	{
	}

	private void _003COnBtnDeleteClicked_003Eb__65_0()
	{
	}

	private void _003COnBtnDeleteClicked_003Eb__65_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
