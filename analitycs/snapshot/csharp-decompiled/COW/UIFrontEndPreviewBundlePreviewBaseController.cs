using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIFrontEndPreviewBundlePreviewBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewBundlePreviewBaseView>, IEasyList
{
	private Vector3 m_PreviewScrollViewOriginalPos;

	private Vector4 m_PreviewScrollViewBaseClipRegion;

	private uint m_ClothesSetID;

	public uint ClothesSetID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	protected override void InitView()
	{
	}

	public virtual void OnSetOriginal()
	{
	}

	public virtual void OnCloseUIExceptMagn()
	{
	}

	public virtual void OnCloseAllUI()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public virtual void RefreshCratePreviewTab(List<BaseItemInfo> list)
	{
	}

	public virtual void RefreshViewData<DataType>(List<DataType> dataList, bool needResort = true, uint clothesSetID = 0u)
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	public void RefreshBundlePreviewTab(CSSharedItemDataManager.ItemType type)
	{
	}

	public virtual void RefreshBundleTitle(bool showBundleTitle)
	{
	}

	public virtual void ReRearrangePreviewTab()
	{
	}

	public virtual void ResetPreviewScrollViewBaseClipRegion()
	{
	}

	protected override void OnSetFrontEndPreviewUIConfigData()
	{
	}

	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public virtual void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void SetScrollViewPanelDepth(int depth)
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetFrontEndPreviewUIConfigData()
	{
	}
}
