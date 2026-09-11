namespace GarenaMSDK;

internal interface IRegFormCallback
{
	void onRegFormCompleted(string regFormRetJson);

	void onRegFormShown();

	void onRegFormClosed(int closeType);

	void onGetUserVerificationInfo(string retJson);
}
