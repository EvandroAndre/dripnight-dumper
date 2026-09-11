using System;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

public class UIUGCHudSceneEditLocalFileDetialsItemController : UIEasyListItemController
{
	private UIHudSceneEditLocalFileDetialsItemView m_View;

	private Action<UGCAssetMetadata> m_ClickCallback;

	private UGCAssetMetadata m_AssetMetadata;

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

	public override void OnItemBtnClick()
	{
	}

	public void RegisterClickCallback(Action<UGCAssetMetadata> callback)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void SetViewData(object data, int data_index)
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
