using System;
using UnityEngine;

namespace COW;

public class UISceneEditCategoryTabItemView : MonoBehaviour
{
	public GameObject Selected;

	public GameObject UnSelected;

	public UILabel TextLabel;

	public UIButton Button;

	public int Index;

	public bool IsInit;

	public UGCCategoryType Type;

	private bool m_IsSelected;

	public Action<UISceneEditCategoryTabItemView> OnSelect;

	public uint PageId;

	public UIWidget CircleTutorial;

	public bool IsSelected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnClick()
	{
	}
}
