using GCommon;
using UnityEngine;

namespace COW;

public class PreviewTabInfo
{
	public UIToggleButton tb;

	public uint id;

	public UIAtlas Atlas;

	public string SpriteName;

	public UISprite equip;

	public GameObject normal;

	public UISprite icon;

	public UISprite highLight;

	public UIButton unDressBtn;

	public PreviewTabInfo(UIToggleButton tb, uint id)
	{
	}
}
