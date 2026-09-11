using GCommon;
using UnityEngine;

namespace COW;

public class SoundTipsView : MonoBehaviour
{
	public UISprite SpriteVehicleSoundTip;

	public UISprite SpriteFootStepSoundTip;

	public UISprite SpriteFireSoundTip;

	public TweenAlpha SoundTipTween;

	public Color WarningTipColor;

	public Color DangerTipColor;

	private UISprite m_SoundTipSprite;

	private Timer m_DelayStopTimer;

	public bool IsInDelayStop => false;

	public void SoundTipInit(ESoundTipsType type)
	{
	}

	public void StartSoundTip()
	{
	}

	public void DelayStopSoundTip(float waitTime)
	{
	}

	public void SetSoundTipColor(Color _color)
	{
	}

	public void StopSoundTip()
	{
	}

	private void LateUpdate()
	{
	}
}
