using System;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UIHudSceneEditCustomAttributeMainTab : MonoBehaviour
{
	public UIButton BtnMainTab;

	public UILabel LabelMainTab;

	public UISprite SpriteCollapsed;

	public UITable TableSubTab;

	public UISprite SelectedSprite;

	public UISprite UnselectedSprite;

	public Action<UIHudSceneEditCustomAttributeMainTab> OnClick;

	private bool _003CIsExpand_003Ek__BackingField;

	private string _003CTitle_003Ek__BackingField;

	public bool IsExpand
	{
		get
		{
			return _003CIsExpand_003Ek__BackingField;
		}
		private set
		{
			_003CIsExpand_003Ek__BackingField = value;
		}
	}

	public string Title
	{
		get
		{
			return _003CTitle_003Ek__BackingField;
		}
		private set
		{
			_003CTitle_003Ek__BackingField = value;
		}
	}

	public void SetViewData(string title, Action<UIHudSceneEditCustomAttributeMainTab> onClick)
	{
	}

	private void OnExpand()
	{
	}

	public void SetExpand(bool isExpand)
	{
	}
}
