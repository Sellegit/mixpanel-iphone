﻿using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MixpanelBinding
{
//  [BaseType (typeof (NSObject))]
//  public partial interface MPCJSONDataSerializer
//  {
//
//    [Static, Export ("serializer")]
//    NSObject Serializer { get; }
//
//    [Export ("serializeObject:error:")]
//    NSData SerializeObject (NSObject inObject, out NSError outError);
//
//    [Export ("serializeNull:error:")]
//    NSData SerializeNull (NSNull inNull, out NSError outError);
//
//    [Export ("serializeNumber:error:")]
//    NSData SerializeNumber (NSNumber inNumber, out NSError outError);
//
//    [Export ("serializeString:error:")]
//    NSData SerializeString (string inString, out NSError outError);
//
//    [Export ("serializeArray:error:")]
//    NSData SerializeArray (NSArray inArray, out NSError outError);
//
//    [Export ("serializeDictionary:error:")]
//    NSData SerializeDictionary (NSDictionary inDictionary, out NSError outError);
//  }
//
//  [BaseType (typeof (NSObject))]
//  public partial interface MPCSerializedJSONData
//  {
//
//    [Export ("data", ArgumentSemantic.Retain)]
//    NSData Data { get; }
//
//    [Export ("initWithData:")]
//    IntPtr Constructor (NSData inData);
//  }
//
//  [Category, BaseType (typeof (NSData))]
//  public partial interface MP_Base64_NSData
//  {
//
//    [Static, Export ("mp_dataFromBase64String:")]
//    NSData Mp_dataFromBase64String (string aString);
//
//    [Static, Export ("mp_base64EncodedString")]
//  
//  }

  [BaseType (typeof (NSObject))]
  public partial interface Mixpanel
  {

//    [Export ("people", ArgumentSemantic.Retain)]
//    MixpanelPeople People { get; }

    [Export ("distinctId", ArgumentSemantic.Copy)]
    string DistinctId { get; }

    [Export ("nameTag", ArgumentSemantic.Copy)]
    string NameTag { get; set; }

    [Export ("serverURL", ArgumentSemantic.Copy)]
    string ServerURL { get; set; }

    [Export ("flushInterval")]
    uint FlushInterval { get; set; }

    [Export ("flushOnBackground")]
    bool FlushOnBackground { get; set; }

    [Export ("showNetworkActivityIndicator")]
    bool ShowNetworkActivityIndicator { get; set; }

    [Export ("checkForSurveysOnActive")]
    bool CheckForSurveysOnActive { get; set; }

    [Export ("showSurveyOnActive")]
    bool ShowSurveyOnActive { get; set; }

    [Export ("checkForNotificationsOnActive")]
    bool CheckForNotificationsOnActive { get; set; }

    [Export ("checkForVariantsOnActive")]
    bool CheckForVariantsOnActive { get; set; }

    [Export ("showNotificationsOnActive")]
    bool ShowNotificationOnActive { get; set; }

    [Export ("miniNotificationPresentationTime")]
    float MiniNotificationPresentationTime { get; set; }

//    [Export ("delegate", ArgumentSemantic.Assign)]
//    MixpanelDelegate Delegate { get; set; }

    [Static, Export ("sharedInstanceWithToken:")]
    Mixpanel GetSharedInstance (string apiToken);

    [Static, Export ("sharedInstanceWithToken:launchOptions")]
    Mixpanel GetSharedInstance (string apiToken, NSDictionary launchOptions);

    [Static, Export ("sharedInstance")]
    Mixpanel SharedInstance { get; }

    [Export ("initWithToken:andFlushInterval:")]
    IntPtr Constructor (string apiToken, uint flushInterval);

    [Export ("initWithToken:launchOptions:andFlushInterval:")]
    IntPtr Constructor (string apiToken, NSDictionary launchOptions, uint flushInterval);

    [Export ("identify:")]
    void Identify (string distinctId);

    [Export ("track:")]
    void Track (string evt);

    [Export ("track:properties:")]
    void Track (string evt, NSDictionary properties);

    [Export ("trackPushNotifications:")]
    void TrackPushNotifications (NSDictionary userInfo);

    [Export ("registerSuperProperties:")]
    void RegisterSuperProperties (NSDictionary properties);

    [Export ("registerSuperPropertiesOnce:")]
    void RegisterSuperPropertiesOnce (NSDictionary properties);

    [Export ("registerSuperPropertiesOnce:defaultValue:")]
    void RegisterSuperPropertiesOnce (NSDictionary properties, NSObject defaultValue);

    [Export ("unregisterSuperProperty:")]
    void UnregisterSuperProperty (string propertyName);

    [Export ("clearSuperProperties")]
    void ClearSuperProperties ();

    [Export ("currentSuperProperties")]
    NSDictionary CurrentSuperProperties { get; }

    [Export ("reset")]
    void Reset ();

    [Export ("flush")]
    void Flush ();

    [Export ("archive")]
    void Archive ();

    [Export ("createAlias:forDistinctID:")]
    void CreateAlias (string alias, string distinctID);

  }
//
//  [BaseType (typeof (NSObject))]
//  public partial interface MixpanelPeople
//  {
//
//    [Export ("addPushDeviceToken:")]
//    void AddPushDeviceToken (NSData deviceToken);
//
//    [Export ("set:")]
//    NSDictionary Set (NSDictionary properties);
//
//    [Export ("set:to:")]
//    void Set (string property, NSObject obj);
//
//    [Export ("once")]
//    NSDictionary Once { set; }
//
//    [Export ("increment:")]
//    void Increment (NSDictionary properties);
//
//    [Export ("increment:by:")]
//    void Increment (string property, NSNumber amount);
//
//    [Export ("append:")]
//    void Append (NSDictionary properties);
//
//    [Export ("trackCharge:")]
//    void TrackCharge (NSNumber amount);
//
//    [Export ("trackCharge:withProperties:")]
//    void TrackCharge (NSNumber amount, NSDictionary properties);
//
//    [Export ("clearCharges")]
//    void ClearCharges ();
//
//    [Export ("deleteUser")]
//    void DeleteUser ();
//  }

//  [Model, BaseType (typeof (NSObject))]
//  public partial interface MixpanelDelegate
//  {
//
//    [Export ("mixpanelWillFlush:")]
//    bool mixpanelWillFlush (Mixpanel mixpanel);
//  }

//  [BaseType (typeof (NSObject))]
//  public partial interface MPCJSONSerializer
//  {
//
//    [Static, Export ("serializer")]
//    NSObject Serializer { get; }
//
//    [Export ("serializeObject:error:")]
//    string SerializeObject (NSObject inObject, out NSError outError);
//
//    [Export ("serializeArray:error:")]
//    string SerializeArray (NSArray inArray, out NSError outError);
//
//    [Export ("serializeDictionary:error:")]
//    string SerializeDictionary (NSDictionary inDictionary, out NSError outError);
//  }
}