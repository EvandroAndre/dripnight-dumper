using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditItemAttributeTextureController : UISceneEditItemAttributeControllerBase, IUISceneEditItemAttributeRefreshView
{
	public enum EItemType
	{
		Texture,
		Sprite
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<GameObject> _003C_003E9__17_0;

		internal void _003CGenerateContainer_003Eb__17_0(GameObject data)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public GameObject centerGo;

		internal bool _003CGetCenterItem_003Eb__0(GameObject data)
		{
			return false;
		}
	}

	private UIHudSceneEditItemAttributeTextureView m_View;

	private int mIndex;

	private List<GameObject> mGridContainers;

	private List<UIHudSceneEditActionAttributeItem> mItems;

	private List<GameObject> mCachedDotList;

	private SceneEditObjectBase mCurrentFocusObj;

	private EItemType mCurType;

	private string mCurValue;

	private string CurValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ClockMaskClick()
	{
	}

	public override void Show()
	{
	}

	private void Clear()
	{
	}

	private void GenerateContainer()
	{
	}

	private void OnClickItem(int index, string name)
	{
	}

	private void GetCenterItem(GameObject centerGo)
	{
	}

	private void ShowDotSelected(int index)
	{
	}

	public override void InitShowData(ItemEditAttributeUIData_V2 data)
	{
	}

	public void RefreshView(ItemEditAttributeUIData_V2 data)
	{
	}

	public void SetEditMode(UISceneEditItemAttributeEditMode mode)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_InitShowData(ItemEditAttributeUIData_V2 P0)
	{
	}
}
