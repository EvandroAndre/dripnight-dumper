using GCommon;
using UnityEngine;

namespace COW;

internal class UILobbyAvatarTransformerFreeMultiController : UILobbyAvatarTransformerBaseController
{
	private UILobbyAvatarTransformerFreeMultiView m_View;

	private EAvatarModelIngameType m_TransformerType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override EAvatarModelIngameType GetUITransformType()
	{
		return EAvatarModelIngameType.Normal;
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
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

	protected override void RefreshTransformerSprite()
	{
	}

	protected override void RefreshTransformerVFX()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public EAvatarModelIngameType _003C_003EiFixBaseProxy_GetUITransformType()
	{
		return EAvatarModelIngameType.Normal;
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshTransformerSprite()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshTransformerVFX()
	{
	}
}
