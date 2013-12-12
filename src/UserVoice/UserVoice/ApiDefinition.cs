using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace UserVoice
{

	[BaseType (typeof (NSObject))]
	interface UserVoice {
		[Static]
		[Export ("presentUserVoiceInterfaceForParentViewController:andConfig:")]
		void PresentUserVoiceInterface (UIViewController parentViewController, UVConfig config);
		
		[Static]
		[Export ("presentUserVoiceContactUsFormForParentViewController:andConfig:")]
		void PresentUserVoiceContactUsForm (UIViewController parentViewController, UVConfig config);
		
		[Static]
		[Export ("presentUserVoiceNewIdeaFormForParentViewController:andConfig:")]
		void PresentUserVoiceNewIdeaForm (UIViewController parentViewController, UVConfig config);
		
		[Static]
		[Export ("presentUserVoiceForumForParentViewController:andConfig:")]
		void PresentUserVoiceForum (UIViewController parentViewController, UVConfig config);
		
		[Static]
		[Export ("version")]
        string Version { get; }
		
		[Static]
		[Export ("setExternalId:forScope:")]
		void SetExternalId (string identifier, string scope);
		
		[Static]
		[Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:")]
		void PresentUserVoiceModalViewController (UIViewController viewController, string site, string key, string secret);
		
		[Static]
		[Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andSsoToken:")]
		void PresentUserVoiceModalViewController (UIViewController viewController, string site, string key, string secret, string token);
		
		[Static]
		[Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andEmail:andDisplayName:andGUID:")]
		void PresentUserVoiceModalViewController (UIViewController viewController, string site, string key, string secret, string email, string displayName, string guid);

		[Static]
		[Wrap ("WeakDelegate")]
		UVDelegate Delegate { get; set; }

		[Static]
		[Export ("delegate")][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
	}
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface UVDelegate {
		[Export ("userVoiceWasDismissed")]
		void UserVoiceWasDismissed ();
	}

	[BaseType (typeof (NSObject))]
	interface UVConfig {
		[Export ("site")]
		string Site { get; set; }
		
		[Export ("key")]
		string Key { get; set; }
		
		[Export ("secret")]
		string Secret { get; set; }
		
		[Export ("ssoToken")]
		string SsoToken { get; set; }
		
		[Export ("displayName")]
		string DisplayName { get; set; }
		
		[Export ("email")]
		string Email { get; set; }
		
		[Export ("guid")]
		string Guid { get; set; }
		
		[Export ("customFields")]
		NSDictionary CustomFields { get; set; }
		
		[Export ("topicId")]
		int TopicId { get; set; }
		
		[Export ("showForum")]
		bool ShowForum { get; set; }
		
		[Export ("showPostIdea")]
		bool ShowPostIdea { get; set; }
		
		[Export ("showContactUs")]
		bool ShowContactUs { get; set; }
		
		[Export ("showKnowledgeBase")]
		bool ShowKnowledgeBase { get; set; }
		
		[Static]
		[Export ("configWithSite:andKey:andSecret:")]
		UVConfig Create (string site, string key, string secret);
		
		[Static]
		[Export ("configWithSite:andKey:andSecret:andSSOToken:")]
        UVConfig Create (string site, string key, string secret, string token);
		
		[Static]
		[Export ("configWithSite:andKey:andSecret:andEmail:andDisplayName:andGUID:")]
        UVConfig Create (string site, string key, string secret, string email, string displayName, string guid);
		
		[Export ("initWithSite:andKey:andSecret:")]
		NSObject Init (string theSite, string theKey, string theSecret);
		
		[Export ("initWithSite:andKey:andSecret:andSSOToken:")]
		NSObject Init (string theSite, string theKey, string theSecret, string theToken);
		
		[Export ("initWithSite:andKey:andSecret:andEmail:andDisplayName:andGUID:")]
		NSObject Init (string theSite, string theKey, string theSecret, string theEmail, string theDisplayName, string theGuid);
		
		[Export ("wasSignedInBySDK")]
		bool WasSignedInBySDK { get; }
	}

	[BaseType (typeof (NSObject))]
	interface UVStyleSheet {
		[Static]
		[Export ("styleSheet")]
		UVStyleSheet StyleSheet { get; set; }
		
		[Static]
		[Export ("zebraBgColor:")]
		UIColor CurrentZebraBgColor (bool dark);
		
		[Static]
		[Export ("backgroundColor")]
		UIColor CurrentBackgroundColor { get; }
		
		[Static]
		[Export ("darkZebraBgColor")]
		UIColor CurrentDarkZebraBgColor { get; }
		
		[Static]
		[Export ("lightZebraBgColor")]
		UIColor CurrentLightZebraBgColor { get; }
		
		[Static]
		[Export ("topSeparatorColor")]
		UIColor CurrentTopSeparatorColor { get; }
		
		[Static]
		[Export ("bottomSeparatorColor")]
		UIColor CurrentBottomSeparatorColor { get; }
		
		[Static]
		[Export ("tableViewHeaderColor")]
		UIColor CurrentTableViewHeaderColor { get; }
		
		[Static]
		[Export ("tableViewHeaderShadowColor")]
		UIColor CurrentTableViewHeaderShadowColor { get; }
		
		[Static]
		[Export ("primaryTextColor")]
		UIColor CurrentPrimaryTextColor { get; }
		
		[Static]
		[Export ("secondaryTextColor")]
		UIColor CurrentSecondaryTextColor { get; }
		
		[Static]
		[Export ("signedInUserTextColor")]
		UIColor CurrentSignedInUserTextColor { get; }
		
		[Static]
		[Export ("labelTextColor")]
		UIColor CurrentLabelTextColor { get; }
		
		[Static]
		[Export ("linkTextColor")]
		UIColor CurrentLinkTextColor { get; }
		
		[Static]
		[Export ("alertTextColor")]
		UIColor CurrentAlertTextColor { get; }
		
		[Static]
		[Export ("navigationBarTintColor")]
		UIColor CurrentNavigationBarTintColor { get; }
		
		[Export ("backgroundColor")]
		UIColor BackgroundColor { get; }
		
		[Export ("darkZebraBgColor")]
		UIColor DarkZebraBgColor { get; }
		
		[Export ("lightZebraBgColor")]
		UIColor LightZebraBgColor { get; }
		
		[Export ("tableViewHeaderColor")]
		UIColor TableViewHeaderColor { get; }
		
		[Export ("tableViewHeaderShadowColor")]
		UIColor TableViewHeaderShadowColor { get; }
		
		[Export ("primaryTextColor")]
		UIColor PrimaryTextColor { get; }
		
		[Export ("secondaryTextColor")]
		UIColor SecondaryTextColor { get; }
		
		[Export ("signedInUserTextColor")]
		UIColor SignedInUserTextColor { get; }
		
		[Export ("labelTextColor")]
		UIColor LabelTextColor { get; }
		
		[Export ("linkTextColor")]
		UIColor LinkTextColor { get; }
		
		[Export ("alertTextColor")]
		UIColor AlertTextColor { get; }
		
		[Export ("navigationBarTintColor")]
		UIColor NavigationBarTintColor { get; }

		[Export ("navigationBarTextColor")]
		UIColor NavigationBarTextColor { get; }
	}
}

