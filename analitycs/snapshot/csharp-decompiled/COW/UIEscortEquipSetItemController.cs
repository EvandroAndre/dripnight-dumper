using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIEscortEquipSetItemController : UIEquipSetItemController
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public UIEscortEquipSetItemController _003C_003E4__this;

		public string name;

		internal void _003CPlayForbidEffect_003Eb__0()
		{
		}
	}

	private UIEScortEquipSetItemView m_View;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public new void SetUIData(int index, LinkEquipSetData data)
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

	public new void Highlight(bool highlight)
	{
	}

	public void SetEscortModeInfo(string info)
	{
	}

	private void PlayForbidEffect(GameObject go, string name)
	{
	}

	private void OnClick()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
