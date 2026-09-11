namespace COW;

public interface IUIEvoGunComponent
{
	UIEvoGunPageState GetPageState();

	void OnSelectPickItem(SkinOwnAndOpenInfo infoData);

	void SyncSkinOwnAndOpenInfoInMain(SkinOwnAndOpenInfo infoData);
}
