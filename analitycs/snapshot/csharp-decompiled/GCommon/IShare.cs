namespace GCommon;

public interface IShare
{
	void BeforeScreenshot();

	void AfterScreenshot();

	void BeforeSharePreview();

	void AfterSharePreview();

	void OnShare(bool success, int platform);

	void OnSaveSharePhoto(bool success);

	void OnCopyShareLink(bool success);
}
