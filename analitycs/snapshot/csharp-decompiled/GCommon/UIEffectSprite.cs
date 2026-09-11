using UnityEngine;

namespace GCommon;

public class UIEffectSprite : UISprite
{
	public GameObject Effect;

	public float EffectScale;

	public bool FollowParentAlpha;

	private const int HEADSPRITE_WIDTH = 60;

	private const int HEADSPRITE_HEIGHT = 60;

	private ResourceID resId;

	private uint loadingTicket;

	private ResourceID loadingRid;

	private bool loadingResetRot;

	protected override void Awake()
	{
	}

	public void SetEffect(ResourceID effectResID, bool needResetRot = false, bool asyncload = false)
	{
	}

	private void OnEffectLoaded(uint ticket, bool ret, Object obj)
	{
	}

	private void SetEffectClip(GameObject effect)
	{
	}

	public void SetEffect(GameObject effect, bool needRemove = true, bool needResetRot = false)
	{
	}

	private void SetEffectScale()
	{
	}

	private void SetEffeectPosition()
	{
	}

	private void CancelLoadingEffect()
	{
	}

	public void RemoveEffect()
	{
	}
}
