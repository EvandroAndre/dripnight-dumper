namespace COW;

public interface ITakePhotoSettingObserver
{
	void OnPlayerNameSettingBtn();

	void OnTeammateSettingBtn();

	void OnWeaponSettingBtn();

	void OnBackpakSettingBtn();

	void OnPetSettingBtn();

	void HideSettingIsOpen();

	bool IsShowTeammate();

	bool IsShowPlayerName();

	bool IsShowBackpack();

	bool IsShowWeapon();

	bool IsShowPet();
}
