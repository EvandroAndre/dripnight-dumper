namespace COW.Gameplay.UGC;

public sealed class UGCPreviewOptions
{
	public string Locale;

	public string FallbackLocale;

	public UGCAssetPreviewKind[] AllowedKinds;

	public int MaxTextureSize;

	public bool UseCache;
}
