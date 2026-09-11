using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class UISparkPetDialogueController : UIBaseController
{
	private UISparkPetDialogueView m_View;

	private UISparkPetTemperChooseController m_TemperChooseController;

	private Action m_CallBack;

	private ESparkPetDialogueType m_DialogueType;

	private UIModelSparkPet m_ModelSparkPet;

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

	protected override void OnVisibilityChanged()
	{
	}

	public void SetViewData(ESparkPetDialogueType type)
	{
	}

	public void SetCloseAction(Action callBack)
	{
	}

	public void SetPos(UISparkPetAvatar sparkPet, Camera uiCamera, float screenToUIRatio)
	{
	}

	private void OnGoposClick()
	{
	}

	public void CloseWithNoTemperChooseOpen()
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
