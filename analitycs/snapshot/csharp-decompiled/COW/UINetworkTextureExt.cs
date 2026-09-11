using System;
using GCommon;

namespace COW;

public class UINetworkTextureExt : UINetworkTexture
{
	public UISprite LoadingMask;

	public UISprite Loading;

	public Action<ResultTextureInfo> Callback;

	public void SetAsyncImageFromUrl(string url, bool isMakePerfect = false, bool showLoading = false, bool adjustLoadingDepth = false, uint endTime = uint.MaxValue)
	{
	}

	public override void OnDowloadFinished(ResultTextureInfo info)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDowloadFinished(ResultTextureInfo P0)
	{
	}
}
