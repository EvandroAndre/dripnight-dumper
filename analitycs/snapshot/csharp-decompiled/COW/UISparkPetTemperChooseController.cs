using GCommon;
using UnityEngine;

namespace COW;

internal class UISparkPetTemperChooseController : UIPopupWindowController
{
	private UISparkPetTemperChooseView m_View;

	private UIModelSparkPet m_ModelSparkPet;

	private ESparkPetTemper m_SparkPetTemper;

	private UIButton[] temperButtonArray;

	private GameObject[] temperSelectArray;

	private UISprite[] temperSpriteArray;

	private ESparkPetTemper[] sparkPetTempers;

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

	public void SetViewData(bool isFirstChoose = false)
	{
	}

	private void OnBackButtonClick()
	{
	}

	private void OnConfirmButtonClick()
	{
	}

	private void OnTemper2Click()
	{
	}

	private void OnTemper1Click()
	{
	}

	private void OnTemper3Click()
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
