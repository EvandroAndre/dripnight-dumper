using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class BaseItemView2 : MonoBehaviour, IUIModelDataChangeObserver
{
	protected bool m_WithoutResize;

	protected bool m_UseBigIconRes;

	protected bool m_MakePixelPerfect;

	protected uint m_ScaleType;

	protected Dictionary<uint, BaseItemViewIconInfo> m_CustomizedIconInfos;

	public bool m_IsItemMini;

	private bool m_UseOrigin;

	private ResourceID m_lastSprite;

	private bool m_ItemIsReady;

	private bool m_IconDownloaded;

	public UILabel m_ItemNameLabel;

	public UISprite m_ItemIconSprite;

	public bool m_OnlyUnDownloadIconShowOptionalIcon;

	public bool m_DontShowItemOptional;

	public UILabel m_QuantityLabel;

	public UILabel m_VoucherLabel;

	public bool m_QuantityIgnoreOne;

	public bool m_ForceShowTime;

	public UILabel m_QuantityLimitLabel;

	public UIWidget[] m_QualityPerformances;

	public GameObject m_ItemOptionalDownloadIcon;

	public GameObject m_FlowLight;

	public List<UISprite> m_ShadowSpriteList;

	protected Vector3 m_DefaultPos;

	protected Quaternion m_DefaultRot;

	protected Vector3 m_DefaultScale;

	protected Vector2 m_DefaultSize;

	protected BaseItemInfo m_Data;

	private Vector3 m_SpecificWeaponRotation;

	private Vector2 m_SpecificWeaponSize;

	private Vector2 m_SpecificWeaponSize2;

	private Vector3 m_SpecificWeaponPosition;

	private Vector2 m_SpecificBonusCardSize;

	private List<UIBaseModel> m_RegisterModel;

	public UINetworkTexture m_ItemIconNetworkTex;

	private UITexture m_ItemIconTex;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	protected void RegisterModel(UIBaseModel model, IUIModelDataChangeObserver observer)
	{
	}

	private void UnRegisterModel()
	{
	}

	public void SetSpecificWeaponRotation(float x, float y, float z)
	{
	}

	public void SetIconPosition(Vector3 position)
	{
	}

	public void SetSpecificWeaponSize(int width, int height)
	{
	}

	public void SetSpecificWeaponSize2(int width, int height)
	{
	}

	public void SetSpecificWeaponPosition(float x, float y, float z)
	{
	}

	public void SetSpecificBonusCardSize(int width, int height)
	{
	}

	public void DisableDiscoloration()
	{
	}

	public bool SetDiscolorationParent(Transform parent)
	{
		return false;
	}

	public void SetItemIconScale(float ratio)
	{
	}

	public void SetItemIconState(bool state)
	{
	}

	public void SetItemTexState(bool state)
	{
	}

	public void SetItemIconSize(int x, int y)
	{
	}

	protected uint MakeSpriteInfoKey(uint itemType, uint subType = 0u, uint additionalFlag = 0u)
	{
		return 0u;
	}

	private BaseItemViewIconInfo GetCustomizedIconInfo(uint itemType, uint itemID = 0u)
	{
		return null;
	}

	private void AdjustCustomizedIcon(CSSharedItemData itemData, out bool foundCustomizedInfo)
	{
		foundCustomizedInfo = default(bool);
	}

	private uint GetSpriteInfoKey(uint itemType, uint itemID)
	{
		return 0u;
	}

	public virtual void SetViewData(BaseItemInfo data, bool useOriginal = true)
	{
	}

	public void SetQuantityLabelZero()
	{
	}

	protected void SetVoucherLabel(BaseItemInfo data)
	{
	}

	protected void SetQualityLabel()
	{
	}

	protected void SetQualityPerformances()
	{
	}

	protected void SetIcon(BaseItemInfo data, bool useOriginal)
	{
	}

	private void SetDownloadIconShowState(ResourceID iconRes)
	{
	}

	private void SetSpriteAlpha(UISprite sprite, float alpha)
	{
	}

	public UISprite GetItemSprite()
	{
		return null;
	}

	public void SetFlowLightEnable(bool b)
	{
	}

	public void AdjustShadowPic(UISprite spr)
	{
	}

	protected void GetIconParamsToBeAdjusted(CSSharedItemData itemData, out Vector3 pos, out Quaternion rot, out Vector2 scale)
	{
		pos = default(Vector3);
		rot = default(Quaternion);
		scale = default(Vector2);
	}

	public void AdjustIconByItem(CSSharedItemData itemData)
	{
	}

	protected virtual void SetDimensionsWithoutCustomized(UISprite icon, Vector2 size)
	{
	}

	protected void SetNetworkTexture(CustomCDNItemInfo info)
	{
	}

	public void SetNetworkTextureDelay(CustomCDNItemInfo info)
	{
	}

	private void SetHippoCrisisItemView(BaseItemInfo data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CSetNetworkTextureDelay_003Eb__71_0()
	{
	}
}
