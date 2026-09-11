using System;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

public class UIUGCHudSceneEditLocalFilePreviewItemController : UIEasyListItemController
{
	private UGCAssetMetadata m_AssetMetadata;

	private UIHudSceneEditLocalFilePreviewItemView m_View;

	private Action<UGCAssetMetadata> m_ClickCallback;

	private UGCAssetExplorer m_Explorer;

	private ShowPreview m_ShowPreview;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void RegisterClickCallback(UGCAssetExplorer explorer, Action<UGCAssetMetadata> callback)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
