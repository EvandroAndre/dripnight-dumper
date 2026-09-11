using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIClothPrivilegePopController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<EventClothEffectsData> _003C_003E9__11_0;

		public static Predicate<EventClothEffectsData> _003C_003E9__12_0;

		internal bool _003CSetDataCloth_003Eb__11_0(EventClothEffectsData effect)
		{
			return false;
		}

		internal bool _003CSetDataBundle_003Eb__12_0(EventClothEffectsData effect)
		{
			return false;
		}
	}

	private UIClothPrivilegePopView m_View;

	private int BottomBorder;

	private int RightBorder;

	private uint m_ItemId;

	private List<UIClothPrivilegeController> m_UIClothPrivilegeControllers;

	private UIModelCollectionCustom m_ModelCollectionCustom;

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

	public void SetData(Vector3 pos, uint Id)
	{
	}

	private void SetPos(Vector3 target, int height, bool inCollectionTrial = false)
	{
	}

	public void SetDataCloth(Vector3 pos, uint itemId)
	{
	}

	public void SetDataBundle(Vector3 pos, List<uint> id_list)
	{
	}

	public void SetDataEmote(Vector3 pos, uint Id)
	{
	}

	public int CalcBgHeigh()
	{
		return 0;
	}

	public void SetDataFlight(Vector3 pos, uint Id)
	{
	}

	public void SetDataTransform(Vector3 pos, uint Id)
	{
	}

	public void SetDataSuperEmote(Vector3 pos, uint Id)
	{
	}

	public void SetDataFinishMove(Vector3 pos, uint Id)
	{
	}

	public void SetDataGroupAnim(Vector3 pos, uint Id)
	{
	}

	public void SetDataBackpack(Vector3 pos, uint Id)
	{
	}

	public void SetDataByList(Vector3 pos, uint Id, List<ResourceID> iconList, List<string> descList, bool inCollectionTrial = false)
	{
	}

	public void DisableGoToPrivilegePreviewBtn()
	{
	}

	private void OnGoToPrivilegeBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
