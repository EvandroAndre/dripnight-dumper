using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudAvatarTransformerFreeMultiController : UIHudAvatarTransformerBaseController
{
	private UIHudAvatarTransformerFreeMultiView m_View;

	private EAvatarModelIngameType m_TransformerType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetIconRotation(float rotateValue)
	{
	}

	protected void SetRotation(Transform slotTransform, float rotateValue)
	{
	}

	public void SetTransformerType(EAvatarModelIngameType type)
	{
	}

	protected override EAvatarModelIngameType GetTargetTransformType(EAvatarModelIngameType currentTransformType)
	{
		return EAvatarModelIngameType.Normal;
	}

	protected override void RefreshTransformerSprite()
	{
	}

	protected override void RefreshTransformerVFX()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public EAvatarModelIngameType _003C_003EiFixBaseProxy_GetTargetTransformType(EAvatarModelIngameType P0)
	{
		return EAvatarModelIngameType.Normal;
	}

	public void _003C_003EiFixBaseProxy_RefreshTransformerSprite()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshTransformerVFX()
	{
	}
}
