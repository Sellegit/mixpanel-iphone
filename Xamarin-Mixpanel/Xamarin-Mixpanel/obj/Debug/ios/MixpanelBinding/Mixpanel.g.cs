//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.SceneKit;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace MixpanelBinding {
	[Register("Mixpanel", true)]
	public unsafe partial class Mixpanel : NSObject {
		[CompilerGenerated]
		const string selArchive = "archive";
		static readonly IntPtr selArchiveHandle = Selector.GetHandle ("archive");
		[CompilerGenerated]
		const string selCheckForNotificationsOnActive = "checkForNotificationsOnActive";
		static readonly IntPtr selCheckForNotificationsOnActiveHandle = Selector.GetHandle ("checkForNotificationsOnActive");
		[CompilerGenerated]
		const string selCheckForSurveysOnActive = "checkForSurveysOnActive";
		static readonly IntPtr selCheckForSurveysOnActiveHandle = Selector.GetHandle ("checkForSurveysOnActive");
		[CompilerGenerated]
		const string selCheckForVariantsOnActive = "checkForVariantsOnActive";
		static readonly IntPtr selCheckForVariantsOnActiveHandle = Selector.GetHandle ("checkForVariantsOnActive");
		[CompilerGenerated]
		const string selClearSuperProperties = "clearSuperProperties";
		static readonly IntPtr selClearSuperPropertiesHandle = Selector.GetHandle ("clearSuperProperties");
		[CompilerGenerated]
		const string selCreateAliasForDistinctID_ = "createAlias:forDistinctID:";
		static readonly IntPtr selCreateAliasForDistinctID_Handle = Selector.GetHandle ("createAlias:forDistinctID:");
		[CompilerGenerated]
		const string selCurrentSuperProperties = "currentSuperProperties";
		static readonly IntPtr selCurrentSuperPropertiesHandle = Selector.GetHandle ("currentSuperProperties");
		[CompilerGenerated]
		const string selDistinctId = "distinctId";
		static readonly IntPtr selDistinctIdHandle = Selector.GetHandle ("distinctId");
		[CompilerGenerated]
		const string selFlush = "flush";
		static readonly IntPtr selFlushHandle = Selector.GetHandle ("flush");
		[CompilerGenerated]
		const string selFlushInterval = "flushInterval";
		static readonly IntPtr selFlushIntervalHandle = Selector.GetHandle ("flushInterval");
		[CompilerGenerated]
		const string selFlushOnBackground = "flushOnBackground";
		static readonly IntPtr selFlushOnBackgroundHandle = Selector.GetHandle ("flushOnBackground");
		[CompilerGenerated]
		const string selIdentify_ = "identify:";
		static readonly IntPtr selIdentify_Handle = Selector.GetHandle ("identify:");
		[CompilerGenerated]
		const string selInitWithTokenAndFlushInterval_ = "initWithToken:andFlushInterval:";
		static readonly IntPtr selInitWithTokenAndFlushInterval_Handle = Selector.GetHandle ("initWithToken:andFlushInterval:");
		[CompilerGenerated]
		const string selInitWithTokenLaunchOptionsAndFlushInterval_ = "initWithToken:launchOptions:andFlushInterval:";
		static readonly IntPtr selInitWithTokenLaunchOptionsAndFlushInterval_Handle = Selector.GetHandle ("initWithToken:launchOptions:andFlushInterval:");
		[CompilerGenerated]
		const string selMiniNotificationPresentationTime = "miniNotificationPresentationTime";
		static readonly IntPtr selMiniNotificationPresentationTimeHandle = Selector.GetHandle ("miniNotificationPresentationTime");
		[CompilerGenerated]
		const string selNameTag = "nameTag";
		static readonly IntPtr selNameTagHandle = Selector.GetHandle ("nameTag");
		[CompilerGenerated]
		const string selRegisterSuperProperties_ = "registerSuperProperties:";
		static readonly IntPtr selRegisterSuperProperties_Handle = Selector.GetHandle ("registerSuperProperties:");
		[CompilerGenerated]
		const string selRegisterSuperPropertiesOnce_ = "registerSuperPropertiesOnce:";
		static readonly IntPtr selRegisterSuperPropertiesOnce_Handle = Selector.GetHandle ("registerSuperPropertiesOnce:");
		[CompilerGenerated]
		const string selRegisterSuperPropertiesOnceDefaultValue_ = "registerSuperPropertiesOnce:defaultValue:";
		static readonly IntPtr selRegisterSuperPropertiesOnceDefaultValue_Handle = Selector.GetHandle ("registerSuperPropertiesOnce:defaultValue:");
		[CompilerGenerated]
		const string selReset = "reset";
		static readonly IntPtr selResetHandle = Selector.GetHandle ("reset");
		[CompilerGenerated]
		const string selServerURL = "serverURL";
		static readonly IntPtr selServerURLHandle = Selector.GetHandle ("serverURL");
		[CompilerGenerated]
		const string selSetCheckForNotificationsOnActive_ = "setCheckForNotificationsOnActive:";
		static readonly IntPtr selSetCheckForNotificationsOnActive_Handle = Selector.GetHandle ("setCheckForNotificationsOnActive:");
		[CompilerGenerated]
		const string selSetCheckForSurveysOnActive_ = "setCheckForSurveysOnActive:";
		static readonly IntPtr selSetCheckForSurveysOnActive_Handle = Selector.GetHandle ("setCheckForSurveysOnActive:");
		[CompilerGenerated]
		const string selSetCheckForVariantsOnActive_ = "setCheckForVariantsOnActive:";
		static readonly IntPtr selSetCheckForVariantsOnActive_Handle = Selector.GetHandle ("setCheckForVariantsOnActive:");
		[CompilerGenerated]
		const string selSetFlushInterval_ = "setFlushInterval:";
		static readonly IntPtr selSetFlushInterval_Handle = Selector.GetHandle ("setFlushInterval:");
		[CompilerGenerated]
		const string selSetFlushOnBackground_ = "setFlushOnBackground:";
		static readonly IntPtr selSetFlushOnBackground_Handle = Selector.GetHandle ("setFlushOnBackground:");
		[CompilerGenerated]
		const string selSetMiniNotificationPresentationTime_ = "setMiniNotificationPresentationTime:";
		static readonly IntPtr selSetMiniNotificationPresentationTime_Handle = Selector.GetHandle ("setMiniNotificationPresentationTime:");
		[CompilerGenerated]
		const string selSetNameTag_ = "setNameTag:";
		static readonly IntPtr selSetNameTag_Handle = Selector.GetHandle ("setNameTag:");
		[CompilerGenerated]
		const string selSetServerURL_ = "setServerURL:";
		static readonly IntPtr selSetServerURL_Handle = Selector.GetHandle ("setServerURL:");
		[CompilerGenerated]
		const string selSetShowNetworkActivityIndicator_ = "setShowNetworkActivityIndicator:";
		static readonly IntPtr selSetShowNetworkActivityIndicator_Handle = Selector.GetHandle ("setShowNetworkActivityIndicator:");
		[CompilerGenerated]
		const string selSetShowNotificationsOnActive_ = "setShowNotificationsOnActive:";
		static readonly IntPtr selSetShowNotificationsOnActive_Handle = Selector.GetHandle ("setShowNotificationsOnActive:");
		[CompilerGenerated]
		const string selSetShowSurveyOnActive_ = "setShowSurveyOnActive:";
		static readonly IntPtr selSetShowSurveyOnActive_Handle = Selector.GetHandle ("setShowSurveyOnActive:");
		[CompilerGenerated]
		const string selSharedInstance = "sharedInstance";
		static readonly IntPtr selSharedInstanceHandle = Selector.GetHandle ("sharedInstance");
		[CompilerGenerated]
		const string selSharedInstanceWithToken_ = "sharedInstanceWithToken:";
		static readonly IntPtr selSharedInstanceWithToken_Handle = Selector.GetHandle ("sharedInstanceWithToken:");
		[CompilerGenerated]
		const string selSharedInstanceWithTokenLaunchOptions = "sharedInstanceWithToken:launchOptions";
		static readonly IntPtr selSharedInstanceWithTokenLaunchOptionsHandle = Selector.GetHandle ("sharedInstanceWithToken:launchOptions");
		[CompilerGenerated]
		const string selShowNetworkActivityIndicator = "showNetworkActivityIndicator";
		static readonly IntPtr selShowNetworkActivityIndicatorHandle = Selector.GetHandle ("showNetworkActivityIndicator");
		[CompilerGenerated]
		const string selShowNotificationsOnActive = "showNotificationsOnActive";
		static readonly IntPtr selShowNotificationsOnActiveHandle = Selector.GetHandle ("showNotificationsOnActive");
		[CompilerGenerated]
		const string selShowSurveyOnActive = "showSurveyOnActive";
		static readonly IntPtr selShowSurveyOnActiveHandle = Selector.GetHandle ("showSurveyOnActive");
		[CompilerGenerated]
		const string selTrack_ = "track:";
		static readonly IntPtr selTrack_Handle = Selector.GetHandle ("track:");
		[CompilerGenerated]
		const string selTrackProperties_ = "track:properties:";
		static readonly IntPtr selTrackProperties_Handle = Selector.GetHandle ("track:properties:");
		[CompilerGenerated]
		const string selTrackPushNotifications_ = "trackPushNotifications:";
		static readonly IntPtr selTrackPushNotifications_Handle = Selector.GetHandle ("trackPushNotifications:");
		[CompilerGenerated]
		const string selUnregisterSuperProperty_ = "unregisterSuperProperty:";
		static readonly IntPtr selUnregisterSuperProperty_Handle = Selector.GetHandle ("unregisterSuperProperty:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Mixpanel");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Mixpanel () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public Mixpanel (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Mixpanel (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Mixpanel (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithToken:andFlushInterval:")]
		[CompilerGenerated]
		public Mixpanel (string apiToken, global::System.UInt32 flushInterval)
			: base (NSObjectFlag.Empty)
		{
			if (apiToken == null)
				throw new ArgumentNullException ("apiToken");
			var nsapiToken = NSString.CreateNative (apiToken);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32 (this.Handle, selInitWithTokenAndFlushInterval_Handle, nsapiToken, flushInterval), "initWithToken:andFlushInterval:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selInitWithTokenAndFlushInterval_Handle, nsapiToken, flushInterval), "initWithToken:andFlushInterval:");
			}
			NSString.ReleaseNative (nsapiToken);
			
		}
		
		[Export ("initWithToken:launchOptions:andFlushInterval:")]
		[CompilerGenerated]
		public Mixpanel (string apiToken, NSDictionary launchOptions, global::System.UInt32 flushInterval)
			: base (NSObjectFlag.Empty)
		{
			if (apiToken == null)
				throw new ArgumentNullException ("apiToken");
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			var nsapiToken = NSString.CreateNative (apiToken);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32 (this.Handle, selInitWithTokenLaunchOptionsAndFlushInterval_Handle, nsapiToken, launchOptions.Handle, flushInterval), "initWithToken:launchOptions:andFlushInterval:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (this.SuperHandle, selInitWithTokenLaunchOptionsAndFlushInterval_Handle, nsapiToken, launchOptions.Handle, flushInterval), "initWithToken:launchOptions:andFlushInterval:");
			}
			NSString.ReleaseNative (nsapiToken);
			
		}
		
		[Export ("archive")]
		[CompilerGenerated]
		public virtual void Archive ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, selArchiveHandle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, selArchiveHandle);
			}
		}
		
		[Export ("clearSuperProperties")]
		[CompilerGenerated]
		public virtual void ClearSuperProperties ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, selClearSuperPropertiesHandle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, selClearSuperPropertiesHandle);
			}
		}
		
		[Export ("createAlias:forDistinctID:")]
		[CompilerGenerated]
		public virtual void CreateAlias (string alias, string distinctID)
		{
			if (alias == null)
				throw new ArgumentNullException ("alias");
			if (distinctID == null)
				throw new ArgumentNullException ("distinctID");
			var nsalias = NSString.CreateNative (alias);
			var nsdistinctID = NSString.CreateNative (distinctID);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selCreateAliasForDistinctID_Handle, nsalias, nsdistinctID);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selCreateAliasForDistinctID_Handle, nsalias, nsdistinctID);
			}
			NSString.ReleaseNative (nsalias);
			NSString.ReleaseNative (nsdistinctID);
			
		}
		
		[Export ("flush")]
		[CompilerGenerated]
		public virtual void Flush ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, selFlushHandle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, selFlushHandle);
			}
		}
		
		[Export ("sharedInstanceWithToken:")]
		[CompilerGenerated]
		public static Mixpanel GetSharedInstance (string apiToken)
		{
			if (apiToken == null)
				throw new ArgumentNullException ("apiToken");
			var nsapiToken = NSString.CreateNative (apiToken);
			
			Mixpanel ret;
			ret =  Runtime.GetNSObject<Mixpanel> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selSharedInstanceWithToken_Handle, nsapiToken));
			NSString.ReleaseNative (nsapiToken);
			
			return ret;
		}
		
		[Export ("sharedInstanceWithToken:launchOptions")]
		[CompilerGenerated]
		public static Mixpanel GetSharedInstance (string apiToken, NSDictionary launchOptions)
		{
			if (apiToken == null)
				throw new ArgumentNullException ("apiToken");
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			var nsapiToken = NSString.CreateNative (apiToken);
			
			Mixpanel ret;
			ret =  Runtime.GetNSObject<Mixpanel> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selSharedInstanceWithTokenLaunchOptionsHandle, nsapiToken, launchOptions.Handle));
			NSString.ReleaseNative (nsapiToken);
			
			return ret;
		}
		
		[Export ("identify:")]
		[CompilerGenerated]
		public virtual void Identify (string distinctId)
		{
			if (distinctId == null)
				throw new ArgumentNullException ("distinctId");
			var nsdistinctId = NSString.CreateNative (distinctId);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selIdentify_Handle, nsdistinctId);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selIdentify_Handle, nsdistinctId);
			}
			NSString.ReleaseNative (nsdistinctId);
			
		}
		
		[Export ("registerSuperProperties:")]
		[CompilerGenerated]
		public virtual void RegisterSuperProperties (NSDictionary properties)
		{
			if (properties == null)
				throw new ArgumentNullException ("properties");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRegisterSuperProperties_Handle, properties.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRegisterSuperProperties_Handle, properties.Handle);
			}
		}
		
		[Export ("registerSuperPropertiesOnce:")]
		[CompilerGenerated]
		public virtual void RegisterSuperPropertiesOnce (NSDictionary properties)
		{
			if (properties == null)
				throw new ArgumentNullException ("properties");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRegisterSuperPropertiesOnce_Handle, properties.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRegisterSuperPropertiesOnce_Handle, properties.Handle);
			}
		}
		
		[Export ("registerSuperPropertiesOnce:defaultValue:")]
		[CompilerGenerated]
		public virtual void RegisterSuperPropertiesOnce (NSDictionary properties, NSObject defaultValue)
		{
			if (properties == null)
				throw new ArgumentNullException ("properties");
			if (defaultValue == null)
				throw new ArgumentNullException ("defaultValue");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selRegisterSuperPropertiesOnceDefaultValue_Handle, properties.Handle, defaultValue.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selRegisterSuperPropertiesOnceDefaultValue_Handle, properties.Handle, defaultValue.Handle);
			}
		}
		
		[Export ("reset")]
		[CompilerGenerated]
		public virtual void Reset ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, selResetHandle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, selResetHandle);
			}
		}
		
		[Export ("track:")]
		[CompilerGenerated]
		public virtual void Track (string evt)
		{
			if (evt == null)
				throw new ArgumentNullException ("evt");
			var nsevt = NSString.CreateNative (evt);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTrack_Handle, nsevt);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selTrack_Handle, nsevt);
			}
			NSString.ReleaseNative (nsevt);
			
		}
		
		[Export ("track:properties:")]
		[CompilerGenerated]
		public virtual void Track (string evt, NSDictionary properties)
		{
			if (evt == null)
				throw new ArgumentNullException ("evt");
			if (properties == null)
				throw new ArgumentNullException ("properties");
			var nsevt = NSString.CreateNative (evt);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selTrackProperties_Handle, nsevt, properties.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selTrackProperties_Handle, nsevt, properties.Handle);
			}
			NSString.ReleaseNative (nsevt);
			
		}
		
		[Export ("trackPushNotifications:")]
		[CompilerGenerated]
		public virtual void TrackPushNotifications (NSDictionary userInfo)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTrackPushNotifications_Handle, userInfo.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selTrackPushNotifications_Handle, userInfo.Handle);
			}
		}
		
		[Export ("unregisterSuperProperty:")]
		[CompilerGenerated]
		public virtual void UnregisterSuperProperty (string propertyName)
		{
			if (propertyName == null)
				throw new ArgumentNullException ("propertyName");
			var nspropertyName = NSString.CreateNative (propertyName);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selUnregisterSuperProperty_Handle, nspropertyName);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selUnregisterSuperProperty_Handle, nspropertyName);
			}
			NSString.ReleaseNative (nspropertyName);
			
		}
		
		[CompilerGenerated]
		public virtual bool CheckForNotificationsOnActive {
			[Export ("checkForNotificationsOnActive")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selCheckForNotificationsOnActiveHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCheckForNotificationsOnActiveHandle);
				}
			}
			
			[Export ("setCheckForNotificationsOnActive:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetCheckForNotificationsOnActive_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCheckForNotificationsOnActive_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CheckForSurveysOnActive {
			[Export ("checkForSurveysOnActive")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selCheckForSurveysOnActiveHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCheckForSurveysOnActiveHandle);
				}
			}
			
			[Export ("setCheckForSurveysOnActive:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetCheckForSurveysOnActive_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCheckForSurveysOnActive_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CheckForVariantsOnActive {
			[Export ("checkForVariantsOnActive")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selCheckForVariantsOnActiveHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCheckForVariantsOnActiveHandle);
				}
			}
			
			[Export ("setCheckForVariantsOnActive:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetCheckForVariantsOnActive_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCheckForVariantsOnActive_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_CurrentSuperProperties_var;
		[CompilerGenerated]
		public virtual NSDictionary CurrentSuperProperties {
			[Export ("currentSuperProperties")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selCurrentSuperPropertiesHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCurrentSuperPropertiesHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CurrentSuperProperties_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string DistinctId {
			[Export ("distinctId", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selDistinctIdHandle));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDistinctIdHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt32 FlushInterval {
			[Export ("flushInterval")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, selFlushIntervalHandle);
				} else {
					return ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selFlushIntervalHandle);
				}
			}
			
			[Export ("setFlushInterval:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetFlushInterval_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetFlushInterval_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool FlushOnBackground {
			[Export ("flushOnBackground")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selFlushOnBackgroundHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selFlushOnBackgroundHandle);
				}
			}
			
			[Export ("setFlushOnBackground:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetFlushOnBackground_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetFlushOnBackground_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MiniNotificationPresentationTime {
			[Export ("miniNotificationPresentationTime")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, selMiniNotificationPresentationTimeHandle);
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMiniNotificationPresentationTimeHandle);
				}
			}
			
			[Export ("setMiniNotificationPresentationTime:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, selSetMiniNotificationPresentationTime_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMiniNotificationPresentationTime_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string NameTag {
			[Export ("nameTag", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selNameTagHandle));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNameTagHandle));
				}
			}
			
			[Export ("setNameTag:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNameTag_Handle, nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetNameTag_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ServerURL {
			[Export ("serverURL", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selServerURLHandle));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selServerURLHandle));
				}
			}
			
			[Export ("setServerURL:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetServerURL_Handle, nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetServerURL_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		static object __mt_SharedInstance_var_static;
		[CompilerGenerated]
		public static Mixpanel SharedInstance {
			[Export ("sharedInstance")]
			get {
				Mixpanel ret;
				ret =  Runtime.GetNSObject<Mixpanel> (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, selSharedInstanceHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_SharedInstance_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ShowNetworkActivityIndicator {
			[Export ("showNetworkActivityIndicator")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selShowNetworkActivityIndicatorHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowNetworkActivityIndicatorHandle);
				}
			}
			
			[Export ("setShowNetworkActivityIndicator:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowNetworkActivityIndicator_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowNetworkActivityIndicator_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowNotificationOnActive {
			[Export ("showNotificationsOnActive")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selShowNotificationsOnActiveHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowNotificationsOnActiveHandle);
				}
			}
			
			[Export ("setShowNotificationsOnActive:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowNotificationsOnActive_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowNotificationsOnActive_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowSurveyOnActive {
			[Export ("showSurveyOnActive")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selShowSurveyOnActiveHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowSurveyOnActiveHandle);
				}
			}
			
			[Export ("setShowSurveyOnActive:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowSurveyOnActive_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowSurveyOnActive_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CurrentSuperProperties_var = null;
			}
		}
	} /* class Mixpanel */
}
