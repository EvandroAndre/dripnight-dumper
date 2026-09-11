using message;

namespace COW.Gameplay.UGC;

public static class UGCTemplateTypeUtil
{
	public static EShopResourceType ToShopResourceType(LLOFDJACPEJ templateType)
	{
		return EShopResourceType.Unknown;
	}

	public static IHDACHNBFNG ToResourceType(LLOFDJACPEJ templateType)
	{
		return IHDACHNBFNG.GameObject;
	}

	public static LLOFDJACPEJ FromShopResourceType(EShopResourceType shopResourceType)
	{
		return LLOFDJACPEJ.Unknown;
	}

	public static LLOFDJACPEJ FromResourceType(IHDACHNBFNG resourceType)
	{
		return LLOFDJACPEJ.Unknown;
	}
}
