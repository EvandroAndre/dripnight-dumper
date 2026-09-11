using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPlayerSPItem : MonoBehaviour
{
	public enum ESPVisualType
	{
		Default,
		GaaraShield
	}

	public enum ESPEffectType
	{
		SP_None,
		SP_UP,
		SP_DOWN
	}

	private ESPVisualType m_CurVisualType;

	public UISprite PermSP;

	public UISprite TempSP;

	public UISprite BackSP;

	public GameObject EffectSPUp;

	public GameObject EffectSPDown;

	public UISprite EffectSPRecover;

	private Vector3 m_DummyVector;

	private bool m_DefaultWidthInitialized;

	private int m_SpriteDefaultWidth;

	private int m_SpriteMaxWidth;

	private int m_CurMinSP;

	private int m_CurMaxSP;

	private int m_CurPermSP;

	private int m_CurTempSP;

	private Dictionary<uint, VisualInstanceHolder> m_CustomizedUIFXUp;

	private Dictionary<uint, VisualInstanceHolder> m_CustomizedUIFXDown;

	private bool m_SPRecoverPredictShow;

	private int m_SPRecoverPredictValue;

	private void Awake()
	{
	}

	public void Show(bool show)
	{
	}

	public void SetWidth(int width)
	{
	}

	private void TryInitializeDefaultWidth()
	{
	}

	public void SetSPValue(int index, int permSP, int tempSP, int total)
	{
	}

	public void PlayEffect(ESPEffectType effect, uint delta = 0u)
	{
	}

	public void SetSPRecoverValue(bool show, int value)
	{
	}

	private void RefreshRecoverEffect()
	{
	}

	private void SetOriginalRendererEnabled(bool enabled)
	{
	}

	private void Update()
	{
	}
}
