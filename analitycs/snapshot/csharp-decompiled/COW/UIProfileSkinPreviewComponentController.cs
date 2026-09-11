using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileSkinPreviewComponentController : UIBaseController
{
	private UIProfileSkinPreviewComponentView m_View;

	private Dictionary<uint, UIProfileSkinPreviewItemController> m_DictPreviewTypeToCtrl;

	private List<UIProfileSkinPreviewItemController> m_SkinPreviewItemCtrlList;

	private Dictionary<uint, Transform> m_DictPreivewTypeToTransform;

	private Dictionary<uint, GameObject> m_DictPreviewTypeToDefaultSprite;

	private UIModelWishList m_ModelWishList;

	private List<uint> m_ClothIDList;

	private uint m_WeaponSkinID;

	private uint m_GroupAnimID;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(List<uint> clothIDList, uint weaponSkinID, uint groupAnimID)
	{
	}

	public void UnselectAllItem()
	{
	}

	private void InitDictPreivewTypeToTransform()
	{
	}

	private void InitDictPreviewTypeToDefaultSprite()
	{
	}

	private void InitCtrlList()
	{
	}

	private void RefreshArcItemList()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
