using UnityEngine;

namespace COW.Graphics;

public class CustomEffectBase
{
	protected PostEffectManagerBase m_effectManager;

	private bool m_isEnable;

	public bool Enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual void Start(PostEffectManagerBase manager)
	{
	}

	public void UpdateEffect()
	{
	}

	public void PreRenderEffect()
	{
	}

	public void RenderEffect(RenderTexture source, RenderTexture destination)
	{
	}

	protected virtual void Update()
	{
	}

	protected virtual void PreRender()
	{
	}

	protected virtual void Render(RenderTexture source, RenderTexture destination)
	{
	}

	public virtual void OnEnable()
	{
	}

	public virtual void OnDisable()
	{
	}

	public virtual void RefreshData()
	{
	}

	public virtual bool NeedCallRender()
	{
		return false;
	}
}
