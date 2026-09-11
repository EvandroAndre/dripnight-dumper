using UnityEngine;

namespace COW;

public class StickerSpriteView : MonoBehaviour
{
	public UIButton m_Button;

	public UISprite m_StickerSprite;

	public EClickSticherFromType m_ClickSticherFromType;

	private ChatStickerData _003Cm_Data_003Ek__BackingField;

	public ChatStickerData m_Data
	{
		get
		{
			return _003Cm_Data_003Ek__BackingField;
		}
		private set
		{
			_003Cm_Data_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	public void SetData(ChatStickerData data, EClickSticherFromType clickSticherFromType)
	{
	}

	private void _003CAwake_003Eb__7_0()
	{
	}
}
