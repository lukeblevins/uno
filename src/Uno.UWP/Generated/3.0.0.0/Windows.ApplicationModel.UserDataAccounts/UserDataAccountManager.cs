#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.UserDataAccounts
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class UserDataAccountManager 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.UserDataAccounts.UserDataAccountManagerForUser GetForUser( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member UserDataAccountManagerForUser UserDataAccountManager.GetForUser(User user) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UserDataAccountManagerForUser%20UserDataAccountManager.GetForUser%28User%20user%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.UserDataAccounts.UserDataAccountStore> RequestStoreAsync( global::Windows.ApplicationModel.UserDataAccounts.UserDataAccountStoreAccessType storeAccessType)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<UserDataAccountStore> UserDataAccountManager.RequestStoreAsync(UserDataAccountStoreAccessType storeAccessType) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CUserDataAccountStore%3E%20UserDataAccountManager.RequestStoreAsync%28UserDataAccountStoreAccessType%20storeAccessType%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> ShowAddAccountAsync( global::Windows.ApplicationModel.UserDataAccounts.UserDataAccountContentKinds contentKinds)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> UserDataAccountManager.ShowAddAccountAsync(UserDataAccountContentKinds contentKinds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cstring%3E%20UserDataAccountManager.ShowAddAccountAsync%28UserDataAccountContentKinds%20contentKinds%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction ShowAccountSettingsAsync( string id)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction UserDataAccountManager.ShowAccountSettingsAsync(string id) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20UserDataAccountManager.ShowAccountSettingsAsync%28string%20id%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction ShowAccountErrorResolverAsync( string id)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction UserDataAccountManager.ShowAccountErrorResolverAsync(string id) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20UserDataAccountManager.ShowAccountErrorResolverAsync%28string%20id%29");
		}
		#endif
	}
}
