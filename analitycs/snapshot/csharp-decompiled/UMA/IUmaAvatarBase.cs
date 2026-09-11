using UMA.Simple;
using UnityEngine;

namespace UMA;

public interface IUmaAvatarBase
{
	UMAData UmaData { get; }

	GameObject GetGameObject();

	void SetEnableMipMap(bool enableMipMap);

	void SetEnableRenderTexturePool(bool flag);

	void SetTextureScaleFactor(int scale);

	void SetNormalSpecTexScale(float scale);

	void SetUpdateWhenOffSceen(bool flag);

	void SetNeedGenerateMesh(bool needMesh);

	void SetUsingRGB565(bool use);

	void SetAtlasResolutionScale(float scale);

	void SetNoMergeTexture(bool noMerge);

	void SetNoClothMergeTexture(bool noMerge);

	void SetNoSkinMergeWithCondition(bool noMerge);

	void SetUpdateTextureSizeByChannelType(bool update);

	void EnableDebugLog(bool enable);

	void SetVisible(bool visible);

	UMAContextIndividual UseIndividualContextCache(SlotOverlayAssetCache cache);

	void SetOverrideDecalTexture(Texture tex, uint clothId, int recipeHash);
}
