using UnityEngine;
using proto;

namespace COW;

public interface IBigEventTemplateLobbyIconBanner
{
	BigEventTemplateLobbyIconBannerStatus BannerStatus { get; }

	void PlayFlyEffect(CustomEventLobbyIconDesc desc, Vector3 position);
}
