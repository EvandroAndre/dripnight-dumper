using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UISparkPetAppearanceSettingPopupController : UIPopupWindowController
{
	private UISparkPetAppearanceSettingPopupView m_View;

	private ESparkPetTemper m_SparkPetTemper;

	private ESparkPetStage m_SparkPetStage;

	private UIModelSparkPet m_ModelSparkPet;

	private UIButton[] temperButtonArray;

	private GameObject[] temperSelectArray;

	private ESparkPetTemper[] sparkPetTempers;

	private UIButton[] stageButtonArray;

	private GameObject[] stageSelectArray;

	private UISprite[] stageSpriteArray;

	private ESparkPetStage[] sparkPetStages;

	private UISparkPetAvatar[] m_SelfSparkPetAvatars;

	private List<SparkColorWheelDesc> m_SparkColorWheelDescs;

	private UISparkPetDyeColorBtnController[] dyeColorBtnControllers;

	private uint m_SelectedColorID;

	private uint m_AsyncCreateSparkPetTicket;

	private bool m_IsCoveredByPopupWnd;

	private const int DyeColorButtonCount = 12;

	private const float DyeColorButtonAngleDegree = 30f;

	private const float DyeColorButtonAngleStartOffset = 60f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnSparkPetCreated(uint ticket, UISparkPetAvatar sparkPetAvatar, uint sparkAvatarType)
	{
	}

	private void CleanupSparkPetAvatar()
	{
	}

	private void InitToggleGroup()
	{
	}

	private void OnAppearanceToggleSelected(UIToggleButton selectedButton)
	{
	}

	private void InitDyeColorButtons()
	{
	}

	private void LayoutDyeColorButtons()
	{
	}

	private void OnDyeColorClick(uint colorID)
	{
	}

	private int GetVisibleDyeColorCount()
	{
		return 0;
	}

	private void RefreshDyeColorButtons()
	{
	}

	private void RefreshDyeIconColor(string colorStr)
	{
	}

	private void ApplyDyeColorToPreviewAvatars()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void OnPopupWindowListChange()
	{
	}

	private void RefreshSparkPetAvatarVisibilityByPopup()
	{
	}

	private void HideAllSparkPetAvatars()
	{
	}

	public void InitUI()
	{
	}

	private void OnBackButtonClick()
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

	private void OnTemperInfoClick()
	{
	}

	private void ShowAvatarByStage(ESparkPetStage stage)
	{
	}

	private void HideAvatarByStage(ESparkPetStage stage)
	{
	}

	private void OnStage1Click()
	{
	}

	private void OnStage2Click()
	{
	}

	private void OnStage3Click()
	{
	}

	private void RefreshInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
