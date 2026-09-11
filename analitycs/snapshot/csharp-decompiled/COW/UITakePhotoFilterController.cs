using System;
using System.Collections.Generic;
using COW.Graphics;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UITakePhotoFilterController : UIBaseController
{
	private class FxSlot
	{
		public int KeyId;

		public PhotoFilterSettingDesc DefaultData;

		public PhotoFilterSettingDesc VerticalData;

		public PhotoFilterSettingDesc Lobby2DData;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<PhotoFilterSettingDesc> _003C_003E9__34_0;

		public static Comparison<PhotoFilterSettingDesc> _003C_003E9__34_1;

		public static Comparison<PhotoFilterSettingDesc> _003C_003E9__34_2;

		internal int _003CInitItems_003Eb__34_0(PhotoFilterSettingDesc a, PhotoFilterSettingDesc b)
		{
			return 0;
		}

		internal int _003CInitItems_003Eb__34_1(PhotoFilterSettingDesc a, PhotoFilterSettingDesc b)
		{
			return 0;
		}

		internal int _003CInitItems_003Eb__34_2(PhotoFilterSettingDesc a, PhotoFilterSettingDesc b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public int id;

		internal bool _003COnItemBtnClickExternal_003Eb__0(PhotoFilterSettingDesc x)
		{
			return false;
		}
	}

	private UITakePhotoFilterView m_View;

	private PostEffectManager PostEffectMgr;

	private List<PhotoFilterSettingDesc> PhotoFilterSettingDatas;

	private List<PhotoFilterSettingDesc> m_FilterDatas;

	private List<PhotoFilterSettingDesc> m_AllFxDatas;

	private List<FxSlot> m_FxSlots;

	private List<PhotoFilterSettingDesc> m_FxDatas;

	private List<UITakePhotoFilterItemController> m_FilterItems;

	private List<UITakePhotoFilterItemController> m_FxItems;

	public PhotoFilterSettingDesc CurData;

	public PhotoFilterSettingDesc CurFxData;

	private int m_CurFxSlotIndex;

	private UIClickMask m_ClickMask;

	private UIModelTakePhoto m_ModelTakePhoto;

	private UIBaseNavigationController m_NavCtrl;

	private Camera m_TargetCamera;

	private UIHudCameraInGameController m_InGameCameraController;

	private GameObject m_LensFlareGO;

	private bool m_savedFlareLayerEnabled;

	private FlareLayer m_FlareLayer;

	private PhotoFXPlayer m_FxPlayer;

	private EPhotoSettingType m_CurTab;

	private bool m_closedByUIClose;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public int GetCurFilterId()
	{
		return 0;
	}

	public int GetCurFilterPrimaryId()
	{
		return 0;
	}

	public override void Hide()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public override void Show()
	{
	}

	public void AddMaskRegion(UIWidget region)
	{
	}

	public void SetCamera(Camera targetCamera)
	{
	}

	public void SetInGameCameraController(UIHudCameraInGameController controller)
	{
	}

	private void InitItems()
	{
	}

	private static bool IsNoneFx(PhotoFilterSettingDesc data)
	{
		return false;
	}

	private bool HasAvailableFx()
	{
		return false;
	}

	private int GetFxSlotIndex(PhotoFilterSettingDesc data)
	{
		return 0;
	}

	private PhotoFilterSettingDesc GetFxDataByContext(FxSlot slot)
	{
		return null;
	}

	private int GetCurrentFxCacheId()
	{
		return 0;
	}

	private void PlayFx(PhotoFilterSettingDesc data)
	{
	}

	public static string GetFilterTitleLocKey()
	{
		return null;
	}

	private void RefreshTabBar()
	{
	}

	private void OnTabClick(EPhotoSettingType tab)
	{
	}

	public void OnItemBtnClickExternal(int id)
	{
	}

	public void OnItemBtnClick(PhotoFilterSettingDesc data)
	{
	}

	private void OnFilterItemClick(PhotoFilterSettingDesc data)
	{
	}

	private void OnFxItemClick(PhotoFilterSettingDesc data)
	{
	}

	private void UpdateLensFlare(ColorGrading.FilterType filterType)
	{
	}

	private void ChangeFilterIdCache(int id)
	{
	}

	private void ChangeFxIdCache(int id)
	{
	}

	public void ResetSelectUI()
	{
	}

	public void ClearCurrentFilter()
	{
	}

	public void ClearCurrentFx()
	{
	}

	public void ResetFxSelectUI()
	{
	}

	public void RefreshCurrentFx()
	{
	}

	private void RefreshFxGroupByContext()
	{
	}

	public void RecoverCurrentFilter()
	{
	}

	public void RecoverCurrentFx()
	{
	}

	protected override void OnUIClose()
	{
	}

	private new void OnDestroy()
	{
	}

	private void _003COnUIInit_003Eb__25_0()
	{
	}

	private void _003COnUIInit_003Eb__25_1()
	{
	}

	private void _003COnUIInit_003Eb__25_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
