﻿using System;
using Foundation;
using IntercomSDK_iOS;
using ObjCRuntime;

namespace IntercomSDK_iOS
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
	//
	// @interface ICMCompany : NSObject
	[BaseType(typeof(NSObject))]
	interface ICMCompany
	{
		// @property (copy, nonatomic) NSString * _Nullable companyId;
		[NullAllowed, Export("companyId")]
		string CompanyId { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable createdAt;
		[NullAllowed, Export("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable monthlySpend;
		[NullAllowed, Export("monthlySpend", ArgumentSemantic.Strong)]
		NSNumber MonthlySpend { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable plan;
		[NullAllowed, Export("plan")]
		string Plan { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,id> * _Nullable customAttributes;
		[NullAllowed, Export("customAttributes", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSObject> CustomAttributes { get; set; }

		// +(NSString * _Nonnull)nullStringAttribute;
		[Static]
		[Export("nullStringAttribute")]
		//[Verify(MethodToProperty)]
		string NullStringAttribute { get; }

		// +(NSNumber * _Nonnull)nullNumberAttribute;
		[Static]
		[Export("nullNumberAttribute")]
		//[Verify(MethodToProperty)]
		NSNumber NullNumberAttribute { get; }

		// +(NSDate * _Nonnull)nullDateAttribute;
		[Static]
		[Export("nullDateAttribute")]
		//[Verify(MethodToProperty)]
		NSDate NullDateAttribute { get; }

		// -(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("attributes")]
		//[Verify(MethodToProperty)]
		NSDictionary<NSString, NSObject> Attributes { get; }
	}

	// @interface ICMUserAttributes : NSObject
	[BaseType(typeof(NSObject))]
	interface ICMUserAttributes
	{
		// @property (copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export("email")]
		string Email { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable userId;
		[NullAllowed, Export("userId")]
		string UserId { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export("phone")]
		string Phone { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable languageOverride;
		[NullAllowed, Export("languageOverride")]
		string LanguageOverride { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable signedUpAt;
		[NullAllowed, Export("signedUpAt", ArgumentSemantic.Strong)]
		NSDate SignedUpAt { get; set; }

		// @property (assign, nonatomic) BOOL unsubscribedFromEmails;
		[Export("unsubscribedFromEmails")]
		bool UnsubscribedFromEmails { get; set; }

		// @property (nonatomic, strong) NSArray<ICMCompany *> * _Nullable companies;
		[NullAllowed, Export("companies", ArgumentSemantic.Strong)]
		ICMCompany[] Companies { get; set; }

		// @property (nonatomic, strong) NSDictionary<NSString *,id> * _Nullable customAttributes;
		[NullAllowed, Export("customAttributes", ArgumentSemantic.Strong)]
		NSDictionary<NSString, NSObject> CustomAttributes { get; set; }

		// +(NSString * _Nonnull)nullStringAttribute;
		[Static]
		[Export("nullStringAttribute")]
		//[Verify(MethodToProperty)]
		string NullStringAttribute { get; }

		// +(NSNumber * _Nonnull)nullNumberAttribute;
		[Static]
		[Export("nullNumberAttribute")]
		//[Verify(MethodToProperty)]
		NSNumber NullNumberAttribute { get; }

		// +(NSDate * _Nonnull)nullDateAttribute;
		[Static]
		[Export("nullDateAttribute")]
		//[Verify(MethodToProperty)]
		NSDate NullDateAttribute { get; }

		// -(NSDictionary<NSString *,id> * _Nonnull)attributes;
		[Export("attributes")]
		//[Verify(MethodToProperty)]
		NSDictionary<NSString, NSObject> Attributes { get; }
	}

	// @interface Intercom : NSObject
	[BaseType(typeof(NSObject))]
	interface Intercom
	{
		// +(void)setApiKey:(NSString * _Nonnull)apiKey forAppId:(NSString * _Nonnull)appId;
		[Static]
		[Export("setApiKey:forAppId:")]
		void SetApiKey(string apiKey, string appId);

		// +(void)setUserHash:(NSString * _Nonnull)userHash;
		[Static]
		[Export("setUserHash:")]
		void SetUserHash(string userHash);

		// +(void)registerUnidentifiedUser;
		[Static]
		[Export("registerUnidentifiedUser")]
		void RegisterUnidentifiedUser();

		// +(void)registerUserWithUserId:(NSString * _Nonnull)userId email:(NSString * _Nonnull)email;
		[Static]
		[Export("registerUserWithUserId:email:")]
		void RegisterUserWithUserId(string userId, string email);

		// +(void)registerUserWithUserId:(NSString * _Nonnull)userId;
		[Static]
		[Export("registerUserWithUserId:")]
		void RegisterUserWithUserId(string userId);

		// +(void)registerUserWithEmail:(NSString * _Nonnull)email;
		[Static]
		[Export("registerUserWithEmail:")]
		void RegisterUserWithEmail(string email);

		// +(void)logout;
		[Static]
		[Export("logout")]
		void Logout();

		// +(void)reset __attribute__((deprecated("'+[Intercom reset]' is deprecated. 'Use +[Intercom logout]' instead.")));
		[Static]
		[Export("reset")]
		void Reset();

		// +(void)updateUser:(ICMUserAttributes * _Nonnull)userAttributes;
		[Static]
		[Export("updateUser:")]
		void UpdateUser(ICMUserAttributes userAttributes);

		// +(void)logEventWithName:(NSString * _Nonnull)name;
		[Static]
		[Export("logEventWithName:")]
		void LogEventWithName(string name);

		// +(void)logEventWithName:(NSString * _Nonnull)name metaData:(NSDictionary * _Nonnull)metaData;
		[Static]
		[Export("logEventWithName:metaData:")]
		void LogEventWithName(string name, NSDictionary metaData);

		// +(void)presentMessenger;
		[Static]
		[Export("presentMessenger")]
		void PresentMessenger();

		// +(void)presentMessageComposer;
		[Static]
		[Export("presentMessageComposer")]
		void PresentMessageComposer();

		// +(void)presentMessageComposerWithInitialMessage:(NSString * _Nonnull)message;
		[Static]
		[Export("presentMessageComposerWithInitialMessage:")]
		void PresentMessageComposerWithInitialMessage(string message);

		// +(void)presentConversationList;
		[Static]
		[Export("presentConversationList")]
		void PresentConversationList();

		// +(void)setDeviceToken:(NSData * _Nonnull)deviceToken;
		[Static]
		[Export("setDeviceToken:")]
		void SetDeviceToken(NSData deviceToken);

		// +(BOOL)isIntercomPushNotification:(NSDictionary * _Nonnull)userInfo;
		[Static]
		[Export("isIntercomPushNotification:")]
		bool IsIntercomPushNotification(NSDictionary userInfo);

		// +(void)handleIntercomPushNotification:(NSDictionary * _Nonnull)userInfo;
		[Static]
		[Export("handleIntercomPushNotification:")]
		void HandleIntercomPushNotification(NSDictionary userInfo);

		// +(void)setBottomPadding:(CGFloat)bottomPadding;
		[Static]
		[Export("setBottomPadding:")]
		void SetBottomPadding(nfloat bottomPadding);

		// +(void)setInAppMessagesVisible:(BOOL)visible;
		[Static]
		[Export("setInAppMessagesVisible:")]
		void SetInAppMessagesVisible(bool visible);

		// +(void)setLauncherVisible:(BOOL)visible;
		[Static]
		[Export("setLauncherVisible:")]
		void SetLauncherVisible(bool visible);

		// +(void)hideMessenger;
		[Static]
		[Export("hideMessenger")]
		void HideMessenger();

		// +(NSUInteger)unreadConversationCount;
		[Static]
		[Export("unreadConversationCount")]
		//[Verify(MethodToProperty)]
		nuint UnreadConversationCount { get; }

		// +(void)enableLogging;
		[Static]
		[Export("enableLogging")]
		void EnableLogging();

		// +(void)setNeedsStatusBarAppearanceUpdate;
		[Static]
		[Export("setNeedsStatusBarAppearanceUpdate")]
		void SetNeedsStatusBarAppearanceUpdate();
	}

	[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull IntercomUnreadConversationCountDidChangeNotification __attribute__((visibility("default")));
		[Field("IntercomUnreadConversationCountDidChangeNotification", "__Internal")]
		NSString IntercomUnreadConversationCountDidChangeNotification { get; }

		// extern NSString *const _Nonnull IntercomWindowWillShowNotification __attribute__((visibility("default")));
		[Field("IntercomWindowWillShowNotification", "__Internal")]
		NSString IntercomWindowWillShowNotification { get; }

		// extern NSString *const _Nonnull IntercomWindowDidShowNotification __attribute__((visibility("default")));
		[Field("IntercomWindowDidShowNotification", "__Internal")]
		NSString IntercomWindowDidShowNotification { get; }

		// extern NSString *const _Nonnull IntercomWindowWillHideNotification __attribute__((visibility("default")));
		[Field("IntercomWindowWillHideNotification", "__Internal")]
		NSString IntercomWindowWillHideNotification { get; }

		// extern NSString *const _Nonnull IntercomWindowDidHideNotification __attribute__((visibility("default")));
		[Field("IntercomWindowDidHideNotification", "__Internal")]
		NSString IntercomWindowDidHideNotification { get; }

		// extern NSString *const _Nonnull IntercomDidStartNewConversationNotification __attribute__((visibility("default")));
		[Field("IntercomDidStartNewConversationNotification", "__Internal")]
		NSString IntercomDidStartNewConversationNotification { get; }
	}
}
