using GCommon;
using UnityEngine;

namespace COW;

public class StickerTabView : MonoBehaviour
{
	public UIToggleButton m_Button;

	public UILabel m_NameLabel;

	public UILabel m_UnselectLabel;

	public UISprite m_Icon;

	private uint _003CitemID_003Ek__BackingField;

	public uint itemID
	{
		get
		{
			return _003CitemID_003Ek__BackingField;
		}
		private set
		{
			_003CitemID_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	public void SetStickerTabInfo(ChatStickerPrice chatSticker)
	{
	}

	private void _003CAwake_003Eb__8_0()
	{
	}
}
