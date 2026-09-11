using UnityEngine;

namespace COW;

public class AvatarEffectExtralInfo : MonoBehaviour
{
	public UILabel[] ShowLabels;

	public UISprite icon;

	public EEmoteInfoType InfoType;

	public const string DefaultClanName = "T_50_SY_PEAK_MUTIGUILD";

	public const string DefaultClanIconName = "FF_UI_Clan_Icon_03";

	public const string DefaultClanFrameName = "FF_UI_Clan_Frame_1_s";

	public const string DefaultPlayerName = "T_51_SY_PEAK_PEAKPLAYER";

	public const string DefaultCreateDay = "T_50_SY_PEAK_MUTIDAYS";

	public const uint DefaultPrimeLevel = 4u;

	private UIModelPrime m_ModelPrime;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelPrime ModelPrime => null;

	private UIModelCustomRoom ModelCustomRoom => null;

	public void SetInfo(EmoteExtralInfo extralInfo)
	{
	}
}
