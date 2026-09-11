using System;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIEquipSetItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public UIEquipSetItemController _003C_003E4__this;

		public string name;

		internal void _003CPlayForbidEffect_003Eb__0()
		{
		}
	}

	private UIEquipSetItemView m_View;

	public int m_Index;

	public Action<int> OnSelect;

	public LinkEquipSetData m_equipSetData;

	public bool m_IsForbid;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(int index, LinkEquipSetData data)
	{
	}

	private void SetEquips(EquipIdCountDataList data, GameObject widget, UILabel nameLabel, UISprite icon, bool bigIcon = false)
	{
	}

	private HENEHAGJCLI SetEquipWidget(EquipIdCountDataList data, GameObject widget)
	{
		return null;
	}

	private void SetEquips(HENEHAGJCLI itemData, UILabel nameLabel, UISprite icon, bool bigIcon)
	{
	}

	private void SetArmor(EquipIdCountDataList data, GameObject widget, UISprite icon)
	{
	}

	public void Highlight(bool highlight)
	{
	}

	private void PlayForbidEffect(GameObject go, string name)
	{
	}

	private void OnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
