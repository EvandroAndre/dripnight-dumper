using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudNewSceneEditItemContainerController : UIEasyListItemController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<int> _003C_003E9__54_0;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__54_0(int codeOfLoadingCustomRes)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public UIHudNewSceneEditItemContainerController _003C_003E4__this;

		public List<ResourceID> remainIds;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__1()
		{
		}
	}

	private UIHudNewSceneEditItemContainerView m_View;

	private int m_DataIndex;

	private SceneEditPrefabConfigData _003CPrefabData_003Ek__BackingField;

	private KCJDEKIJAKH _003CTemplateData_003Ek__BackingField;

	private GNHAFLDPNJI _003CTemplateResourceRef_003Ek__BackingField;

	private UIHudSceneEditItem SceneEditItem;

	private bool m_IsCurModeForbidden;

	private bool m_IsCurItemNew;

	private UINewDownloadInfoController m_OptionalResDownloader;

	private bool m_NeedCheckAutoDownload;

	private bool m_NeedCheckAutoDownloadForDownloadTask;

	private UIModelOptionalDownload m_ModelDownload;

	private UGCSimpleDownloadTask m_DownloadTask;

	private List<ResourceID> m_ResList;

	private UGCCustomLevelObjectEditorPackageInfo m_CustomLevelObjectPackageInfo;

	private Texture2D m_Texture2D;

	private int m_OriTextureWidth;

	private int m_OriTextureHeight;

	private HNDHJGJILHC m_Game;

	private SceneEditAgent m_Agent;

	public SceneEditPrefabConfigData PrefabData
	{
		get
		{
			return _003CPrefabData_003Ek__BackingField;
		}
		private set
		{
			_003CPrefabData_003Ek__BackingField = value;
		}
	}

	public KCJDEKIJAKH TemplateData
	{
		get
		{
			return _003CTemplateData_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateData_003Ek__BackingField = value;
		}
	}

	public GNHAFLDPNJI TemplateResourceRef
	{
		get
		{
			return _003CTemplateResourceRef_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateResourceRef_003Ek__BackingField = value;
		}
	}

	public bool IsFromAIAssist => false;

	public bool IsFromSearch => false;

	public EUGCAssetProviderType Type => EUGCAssetProviderType.None;

	public WorkShopPrefabResourceContentConfigData ConfigData => null;

	public bool IsSelected => false;

	public SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void ClearTexture()
	{
	}

	private void ClearData()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public void ShowTipsPop()
	{
	}

	private void OnEditButtonClick()
	{
	}

	private void OnShopStatusButtonClick()
	{
	}

	public void TutorialSelectDesignatedItem()
	{
	}

	public bool RefreshOptionalMapResDownloader()
	{
		return false;
	}

	private void CollectNecessaryOptionalRes()
	{
	}

	private void OnUGCResDownloaderClick(List<ResourceID> resList)
	{
	}

	private void OnUGCResDownloaderClickForCustomLevelObject()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnAddPrefabInPointDragMode()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnResourceDataChange(object[] data)
	{
	}

	private void RefreshTemplateShopStatus()
	{
	}

	public void OnPaintModeChange(bool value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
