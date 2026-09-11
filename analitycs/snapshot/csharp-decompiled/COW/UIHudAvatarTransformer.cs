using GCommon;

namespace COW;

public class UIHudAvatarTransformer : UIHudAvatarTransformerBaseController
{
	protected UIHudAvatarTransformerView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void RefreshTransformerSprite()
	{
	}

	protected override EAvatarModelIngameType GetTargetTransformType(EAvatarModelIngameType curAvatarModelType)
	{
		return EAvatarModelIngameType.Normal;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshTransformerSprite()
	{
	}

	public EAvatarModelIngameType _003C_003EiFixBaseProxy_GetTargetTransformType(EAvatarModelIngameType P0)
	{
		return EAvatarModelIngameType.Normal;
	}
}
