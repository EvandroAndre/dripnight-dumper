using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class UISparkPetBubbleController : UIBaseController
{
	private UISparkPetBubbleView m_View;

	private Action<Vector3> m_CallBack;

	private UIModelSparkPet m_ModelSparkPet;

	private UIModelSparkPetTest m_ModelSparkPetTest;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(uint[] m_NeedToClaimAwards, bool isStageEvolution = false)
	{
	}

	public void SetPos(UISparkPetAvatar sparkPet, Camera uiCamera, float screenToUIRatio)
	{
	}

	public void SetCloseCallBack(Action<Vector3> callback)
	{
	}

	public UIWidget GetBubbleWidget()
	{
		return null;
	}

	private void OnBubbleBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
