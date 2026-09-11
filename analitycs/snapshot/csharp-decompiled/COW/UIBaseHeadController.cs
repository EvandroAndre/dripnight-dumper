using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBaseHeadController : UIBaseController, IUIModelDataChangeObserver
{
	private UIBaseHeadView m_View;

	private BaseProfileInfo m_ProfileData;

	private GameObject m_AvatarFrame;

	private ResourceID m_AvatarFrameRes;

	private UIModelPrime m_ModelPrime;

	private bool m_ForceFakeHead;

	public Action BtnCallBack;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(BaseProfileInfo data, bool forceFakeHead = false)
	{
	}

	public void UpdateHeadPic(HeadPicData data)
	{
	}

	private void ShowFakeHead()
	{
	}

	private void RefreshAvatarFrame()
	{
	}

	private ResourceID GetAvatarFrameRes(BaseProfileInfo data)
	{
		return default(ResourceID);
	}

	private void HideAvatarFrame()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
