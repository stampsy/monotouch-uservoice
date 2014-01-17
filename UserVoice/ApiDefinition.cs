using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;

namespace UserVoice {

	[BaseType (typeof (NSObject))]
	public partial interface UVConfig {

		[Static, Export ("configWithSite:")]
		UVConfig ConfigWithSite (string site);

		[Static, Export ("configWithSite:andKey:andSecret:")]
		UVConfig ConfigWithSite (string site, string key, string secret);

		[Static, Export ("configWithSite:andKey:andSecret:andSSOToken:")]
		UVConfig ConfigWithSite (string site, string key, string secret, string token);

		[Static, Export ("configWithSite:andKey:andSecret:andEmail:andDisplayName:andGUID:")]
		UVConfig ConfigWithSite (string site, string key, string secret, string email, string displayName, string guid);

		[Export ("site", ArgumentSemantic.Retain)]
		string Site { get; set; }

		[Export ("key", ArgumentSemantic.Retain)]
		string Key { get; set; }

		[Export ("secret", ArgumentSemantic.Retain)]
		string Secret { get; set; }

		[Export ("ssoToken", ArgumentSemantic.Retain)]
		string SsoToken { get; set; }

		[Export ("displayName", ArgumentSemantic.Retain)]
		string DisplayName { get; set; }

		[Export ("email", ArgumentSemantic.Retain)]
		string Email { get; set; }

		[Export ("guid", ArgumentSemantic.Retain)]
		string Guid { get; set; }

		[Export ("customFields", ArgumentSemantic.Retain)]
		NSDictionary CustomFields { get; set; }

		[Export ("topicId")]
		int TopicId { get; set; }

		[Export ("forumId")]
		int ForumId { get; set; }

		[Export ("showForum")]
		bool ShowForum { get; set; }

		[Export ("showPostIdea")]
		bool ShowPostIdea { get; set; }

		[Export ("showContactUs")]
		bool ShowContactUs { get; set; }

		[Export ("showKnowledgeBase")]
		bool ShowKnowledgeBase { get; set; }

		[Export ("extraTicketInfo", ArgumentSemantic.Retain)]
		string ExtraTicketInfo { get; set; }

		[Export ("userTraits", ArgumentSemantic.Retain)]
		NSDictionary UserTraits { get; set; }

		[Export ("identifyUserWithEmail:name:guid:")]
		void IdentifyUserWithEmail (string email, string name, string guid);

		[Export ("traits")]
		NSDictionary Traits { get; }
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface UVDelegate {

		[Export ("userVoiceWasDismissed")]
		void UserVoiceWasDismissed ();

		[Export ("userVoiceRequestsDismissal")]
		void UserVoiceRequestsDismissal ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface UVStyleSheet {

		[Static, Export ("instance")]
		UVStyleSheet Instance { get; }

		[Export ("tintColor", ArgumentSemantic.Retain)]
		UIColor TintColor { get; set; }

		[Export ("tableViewBackgroundColor", ArgumentSemantic.Retain)]
		UIColor TableViewBackgroundColor { get; set; }

		[Export ("navigationBarBackgroundColor", ArgumentSemantic.Retain)]
		UIColor NavigationBarBackgroundColor { get; set; }

		[Export ("navigationBarTextColor", ArgumentSemantic.Retain)]
		UIColor NavigationBarTextColor { get; set; }

		[Export ("navigationBarTextShadowColor", ArgumentSemantic.Retain)]
		UIColor NavigationBarTextShadowColor { get; set; }

		[Export ("navigationBarBackgroundImage", ArgumentSemantic.Retain)]
		UIImage NavigationBarBackgroundImage { get; set; }

		[Export ("navigationBarFont", ArgumentSemantic.Retain)]
		UIFont NavigationBarFont { get; set; }

		[Export ("loadingViewBackgroundColor", ArgumentSemantic.Retain)]
		UIColor LoadingViewBackgroundColor { get; set; }
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface UserVoice {

		[Static, Export ("initialize:")]
		void Initialize (UVConfig config);

		[Static, Export ("presentUserVoiceInterfaceForParentViewController:")]
		void PresentUserVoiceInterfaceForParentViewController (UIViewController parentViewController);

		[Static, Export ("presentUserVoiceContactUsFormForParentViewController:")]
		void PresentUserVoiceContactUsFormForParentViewController (UIViewController parentViewController);

		[Static, Export ("presentUserVoiceNewIdeaFormForParentViewController:")]
		void PresentUserVoiceNewIdeaFormForParentViewController (UIViewController parentViewController);

		[Static, Export ("presentUserVoiceForumForParentViewController:")]
		void PresentUserVoiceForumForParentViewController (UIViewController parentViewController);

		[Static, Export ("getUserVoiceContactUsFormForModalDisplay")]
		UIViewController GetUserVoiceContactUsFormForModalDisplay { get; }

		[Static, Export ("delegate")]
		UVDelegate Delegate { get; set; }

		[Static, Export ("version")]
		string Version { get; }

		[Static, Export ("setExternalId:forScope:")]
		void SetExternalId (string identifier, string scope);

		[Static, Export ("track:")]
		void Track (string e);

		[Static, Export ("track:properties:")]
		void Track (string e, NSDictionary properties);

		[Static, Export ("presentUserVoiceInterfaceForParentViewController:andConfig:")]
		void PresentUserVoiceInterfaceForParentViewController (UIViewController parentViewController, UVConfig config);

		[Static, Export ("presentUserVoiceContactUsFormForParentViewController:andConfig:")]
		void PresentUserVoiceContactUsFormForParentViewController (UIViewController parentViewController, UVConfig config);

		[Static, Export ("presentUserVoiceNewIdeaFormForParentViewController:andConfig:")]
		void PresentUserVoiceNewIdeaFormForParentViewController (UIViewController parentViewController, UVConfig config);

		[Static, Export ("presentUserVoiceForumForParentViewController:andConfig:")]
		void PresentUserVoiceForumForParentViewController (UIViewController parentViewController, UVConfig config);

		[Static, Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:")]
		void PresentUserVoiceModalViewControllerForParent (UIViewController viewController, string site, string key, string secret);

		[Static, Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andSsoToken:")]
		void PresentUserVoiceModalViewControllerForParent (UIViewController viewController, string site, string key, string secret, string token);

		[Static, Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andEmail:andDisplayName:andGUID:")]
		void PresentUserVoiceModalViewControllerForParent (UIViewController viewController, string site, string key, string secret, string email, string displayName, string guid);
	}
}
