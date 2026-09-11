using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaIchis55CollectionController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003E9__79_0;

		internal CommonRewardItemInfo _003CShowClaimRewards_003Eb__79_0(ExchangedAward item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public int slot;

		public UIGachaIchis55CollectionController _003C_003E4__this;

		internal void _003CRefreshItems_003Eb__0()
		{
		}
	}

	private const string PREFS_KEY_FMT_ANIM_BITMASK = "Ichis55_CollectItem_AnimBitmask_{0}";

	private const float ROTATE_SPEED = 0.5f;

	private const int CAMERA_DEPTH = 10;

	private static readonly Vector3 Loot_MODEL_POSITION;

	private static readonly Vector3 PREVIEW_WORLD_OFFSET;

	private UIGachaIchis55CollectionView m_View;

	private UIModelIchis m_ModelIchis;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private string m_PrefsKeyAnimBitmask;

	private List<UIGachaIchis55CollectionItemController> m_ItemCtrls;

	private List<Ichis55CollectionItemData> m_ItemDataList;

	private UIBaseProfileInfoController m_ProfileInfoCtrl;

	private UINewDownloadInfoController m_LootBoxDownloadCtrl;

	private List<ResourceID> m_NeedDownloadRes;

	private GameObject m_ItemCameraGo;

	private GameObject m_LootBoxModel;

	private GameObject m_BoardGo;

	private UIDeadlootBoardController m_BoardCtrl;

	private ResourceID m_BoardResId;

	private int m_AnimShownMask;

	private int m_AllAnimShownMask;

	private uint m_ChestId;

	private uint m_ChestSubId;

	private uint m_CollectRewardUniqueId;

	private uint m_AwardItemId;

	private bool m_AllCollected;

	private bool m_Claimed;

	private bool m_IsFirstShowState;

	private bool m_ItemCameraHiddenByLWResult;

	private RenderTexture m_BgBlurRT;

	private RenderTexture m_BgMountBlurRT;

	private Material m_BgBlurMat;

	private int s_BgBlurDivisor;

	private int s_BgBlurPasses;

	private float s_BgBlurStep;

	private const string BG_BLUR_SHADER = "BRMobile/Internal/SeparableGlassBlur";

	private readonly Color s_BgBlurTint;

	private readonly Color s_BgMountBlurTint;

	private Color m_BgOrigColor;

	private Color m_BgMountOrigColor;

	private bool m_BgColorTinted;

	private bool m_BgMountColorTinted;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override void OnPopupWindowListChange()
	{
	}

	public void SetUIData(uint chestId, uint chestSubId)
	{
	}

	private void SetUIData(List<uint> itemIds)
	{
	}

	private List<uint> BuildItemIdList()
	{
		return null;
	}

	private void ShowFirstShowState()
	{
	}

	private void PlayFirstShowGlow()
	{
	}

	private void RefreshCdnTextures(bool blurBg = false)
	{
	}

	private void OnFirstShowBgLoaded()
	{
	}

	private void OnFirstShowBgMountLoaded()
	{
	}

	private void ApplyBgBlur(UITexture tex, ref RenderTexture rt)
	{
	}

	private Material GetBgBlurMaterial()
	{
		return null;
	}

	private void ReleaseBgBlur()
	{
	}

	private void ApplyBgTint(UITexture tex, Color tint, ref Color orig, ref bool tinted)
	{
	}

	private void RestoreBgTint()
	{
	}

	private static Color HexToColor(int hex)
	{
		return default(Color);
	}

	private void ReleaseRT(ref RenderTexture rt)
	{
	}

	private void ShowCollectionState()
	{
	}

	private void RefreshItems()
	{
	}

	private void ClearItems()
	{
	}

	private void RefreshBottom()
	{
	}

	private void RefreshAwardItemName()
	{
	}

	private void RefreshTimeLabel()
	{
	}

	private void OnItemActivateAnimDone(int slotIndex)
	{
	}

	private void PlayCollectAllAnimation()
	{
	}

	public bool IsAnimShown(int slotIndex)
	{
		return false;
	}

	public void MarkAnimShown(int slotIndex)
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void OnClickCustomizeButton()
	{
	}

	private void OnCustomizeWndClosed()
	{
	}

	private void OnClickShareBtn()
	{
	}

	private void OnClickClaimBtn()
	{
	}

	private void OnClaimRewardChanged(object[] param)
	{
	}

	private void ShowClaimRewards(CSSharedGachaCollectRewardRes response)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public override void BeforeSharePreview()
	{
	}

	public override void AfterSharePreview()
	{
	}

	private void RefreshProfileInfoShow()
	{
	}

	private void EnsurePreviewCamera()
	{
	}

	private ResourceID GetLootBoxPreviewResId()
	{
		return default(ResourceID);
	}

	private void LoadLootPreview()
	{
	}

	private void OnDragRotateModel(GameObject go, Vector2 delta)
	{
	}

	private void DestroyLootBoxModel()
	{
	}

	private void DestroyItemCamera()
	{
	}

	private bool HasCompletedCustomization()
	{
		return false;
	}

	private void InitBoardResource()
	{
	}

	private void LoadBoardPreview()
	{
	}

	private void RefreshBoardPreview()
	{
	}

	private void SetPrimeBoardFacingCamera(GameObject primeBoardGo)
	{
	}

	private void DestroyBoard()
	{
	}

	private bool TryShowDownloadCtrl()
	{
		return false;
	}

	private void RefreshNeedDownloadRes()
	{
	}

	private void AddNeedDownloadRes(ResourceID resId)
	{
	}

	private void CloseDownloadCtrl()
	{
	}

	private void OnDownloadClick()
	{
	}

	private void RefreshPreviewAfterDownload()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeSharePreview()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterSharePreview()
	{
	}
}
