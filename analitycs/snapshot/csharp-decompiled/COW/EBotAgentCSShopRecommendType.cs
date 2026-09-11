namespace COW;

public enum EBotAgentCSShopRecommendType : uint
{
	None = 0u,
	Round1_BuyPistol = 1u,
	Round2To6_BuyMainWeapon = 10u,
	Round2To6_BuyArmor = 11u,
	Round2To6_RepairArmor = 12u,
	Round2To6_BuyGlooWall = 13u,
	Round2To6_BuyGrenadeOrMushroom = 14u,
	Round2To6_AskTeammate = 15u,
	Round7_BuyFreely = 20u
}
