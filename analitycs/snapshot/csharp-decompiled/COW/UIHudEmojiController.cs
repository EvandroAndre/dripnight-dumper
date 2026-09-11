using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudEmojiController : UIBaseController
{
	private UIHudEmojiView m_View;

	private string m_LastEmojiName;

	private JNGJGOIDOJC m_LastSendType;

	private int m_LastTeammateIndex;

	private float m_ShowEmojiLength;

	private uint m_HideEmojiDelayCall;

	private string m_LastFriendObName;

	private Animation m_NewEmojiAnimation;

	private Animation m_FadeEmojiAnimation;

	private float m_LastReceiveTime;

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestory()
	{
	}

	private void OnReviveBubbleTipsShow()
	{
	}

	private void RefreshGiftView(string friendObName)
	{
	}

	private void RefreshFadeGift()
	{
	}

	private void RefreshEmojiView(string resName, uint playerID, string friendObName)
	{
	}

	private void OnReceiveEmoji(object[] data)
	{
	}

	private void RefershFadeEmoji()
	{
	}

	private void HideEmoji()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
