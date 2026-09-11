using System;
using COW.GamePlay;
using UnityEngine;

namespace COW;

public class UIHudObserverStickerItem : MonoBehaviour
{
	public UIButton m_Button;

	public UISprite m_StickerSprite;

	public GameObject line;

	private Action<string, uint> m_OnEmojiSend;

	private string m_ResName;

	private uint m_SendType;

	private BHGGAEEHJCO m_TargetPlayerID;

	private Animation showAnimation;

	private AnimatedAlpha m_AnimatedAlpha;

	private TweenAlpha m_TweenAlpha;

	private bool m_IsPlayingSendAnim;

	public string GetResName()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public void SetStickerSprite(string resourceName, uint sendType, Action<string, uint> OnEmojiSend)
	{
	}

	private void SendEmoji()
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	public void SetTarget(BHGGAEEHJCO pID)
	{
	}

	public void Hide()
	{
	}

	public void Show()
	{
	}

	private void ResetUI()
	{
	}

	private void OnDestroy()
	{
	}

	private void _003CAwake_003Eb__12_0()
	{
	}
}
