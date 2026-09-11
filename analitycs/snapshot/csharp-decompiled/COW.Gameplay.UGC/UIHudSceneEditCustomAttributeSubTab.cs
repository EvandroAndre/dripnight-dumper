using System;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UIHudSceneEditCustomAttributeSubTab : MonoBehaviour
{
	public UIButton BtnSubTab;

	public UILabel LabelSubTab;

	public UIColor TabColor;

	public long Type;

	public InspectorCraftlandConfig_Default Config;

	public string NameKey;

	public Action<UIHudSceneEditCustomAttributeSubTab> OnSelect;

	public UIHudSceneEditCustomAttributeMainTab MainTab;

	public void SetViewData(long type, Action<UIHudSceneEditCustomAttributeSubTab> onSelect, UIHudSceneEditCustomAttributeMainTab mainTab, string labelName)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	private void OnSubTabClick()
	{
	}
}
