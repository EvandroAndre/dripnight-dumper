using message;

namespace COW.Gameplay.UGC;

public sealed class UGCQuery
{
	public string SearchText;

	public bool QueryAllResourceType;

	public IHDACHNBFNG ResourceType;

	public string[] RequiredTags;

	public bool IsReferencedByMap;

	public bool FilterCanUpload;

	public EUGCAssetProviderType ProviderType;
}
