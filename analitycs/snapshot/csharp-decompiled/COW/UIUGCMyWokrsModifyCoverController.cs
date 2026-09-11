using System;
using GCommon;

namespace COW;

public class UIUGCMyWokrsModifyCoverController : UIPopupWindowController
{
	public Action OnCoverChanged;

	public Action OnScenePhoto;

	private UIUGCMyWokrsModifyCoverView m_View;

	private SceneEditSlotInfo m_Info;

	private UIWorkshopMapItemController m_MapItemController;

	private UIModelSceneEdit m_ModelSceneEdit;

	private bool m_EnableEditLocal;

	private bool m_EnableScreenShot;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(SceneEditSlotInfo slotInfo, bool enableEditLocal, bool enableScreenShot)
	{
	}

	private void OnBtnScenePhoto()
	{
	}

	private void OnBtnUploadLocal()
	{
	}

	private void SelectImageFromAlbum()
	{
	}

	private void DeleteCustomCover()
	{
	}

	private void OnBtnDel()
	{
	}

	private void Refresh()
	{
	}

	private void _003COnBtnUploadLocal_003Eb__12_0()
	{
	}

	private void _003CSelectImageFromAlbum_003Eb__13_0(string path)
	{
	}

	private void _003CSelectImageFromAlbum_003Eb__13_1()
	{
	}

	private void _003CDeleteCustomCover_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
