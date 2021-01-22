namespace Crestron.Rio.System;
        // class declarations
         class Room;
         class RoomGroup;
         class GlobalMacro;
         class UI;
         class Subsystem;
         class TreeNode;
         class SystemSettings;
         class SystemManager;
         class SystemUI;
         class SystemUIHelperBase;
         class SystemUIHelper;
         class SystemUIMLX3Helper;
         class RioRegistry;
     class Room 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        SIGNED_LONG_INTEGER roomID;
        STRING roomName[];
        SIGNED_LONG_INTEGER icon;

        // class properties
    };

     class RoomGroup 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        SIGNED_LONG_INTEGER roomGroupID;
        SIGNED_LONG_INTEGER roomGroupIcon;
        STRING roomGroupName[];

        // class properties
    };

     class GlobalMacro 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        SIGNED_LONG_INTEGER globalMacroID;
        STRING globalMacroName[];
        SIGNED_LONG_INTEGER globalMacroIcon;

        // class properties
    };

     class UI 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER uiID;
        STRING uiName[];
        SIGNED_LONG_INTEGER uistartupSubsystem;
        SIGNED_LONG_INTEGER uiPersistentSubsystem;
        SIGNED_LONG_INTEGER defaultRoomID;
    };

     class Subsystem 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER subsystemID;
        SIGNED_LONG_INTEGER subsystemIcon;
        STRING subsystemName[];
        STRING subsystemConfigFilePath[];
    };

     class SystemSettings 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION GetSubsystemFilePath ( SIGNED_LONG_INTEGER subsystemID );
        SIGNED_LONG_INTEGER_FUNCTION GetSubsystemIcon ( SIGNED_LONG_INTEGER subsystemID );
        SIGNED_LONG_INTEGER_FUNCTION GetDefaultRoomId ( SIGNED_LONG_INTEGER uiID );
        SIGNED_LONG_INTEGER_FUNCTION TotalSubsystems ();
        FUNCTION Initialize ( SIMPLSHARPSTRING filePath , SIMPLSHARPSTRING moduleParameterUUID );
        STRING_FUNCTION GetRoomName ( SIGNED_LONG_INTEGER roomID );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING systemUUID[];
        STRING configFileVersion[];
        STRING systemName[];
        STRING systemVersion[];
        SIGNED_LONG_INTEGER latitude;
        SIGNED_LONG_INTEGER longitude;
        STRING country[];
        STRING city[];
        SIGNED_LONG_INTEGER timeZone;
        SIGNED_LONG_INTEGER zipCode;
        SIGNED_LONG_INTEGER startupSubsystem;
        SIGNED_LONG_INTEGER persistentSubsystem;
    };

    static class SystemManager 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION RegisterSubsystem ( SIGNED_LONG_INTEGER id );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static Crestron.Rio.System.SystemSettings Settings;
        static Crestron.Rio.System.RioRegistry SystemUIRegistry;

        // class properties
    };

     class SystemUI 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION ShowHomeScreen ();
        FUNCTION HideSubpageFlip ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER ActiveSubsystem;
        SIGNED_LONG_INTEGER uiPersistentSubsystem;
    };

     class SystemUIHelperBase 
    {
        // class delegates
        delegate FUNCTION DelegateFnUshort ( INTEGER i );
        delegate FUNCTION DelegateFnUshortUshort ( INTEGER i , INTEGER j );

        // class events

        // class functions
        FUNCTION InitializeBase ();
        FUNCTION Register ( SIGNED_LONG_INTEGER id );
        FUNCTION TriggerStartupSubsystem ();
        FUNCTION TriggerPersistentSubsystem ();
        FUNCTION ShowHomeScreen ();
        FUNCTION HideHomeScreen ();
        INTEGER_FUNCTION GetNumberofVisibleSubsystems ( INTEGER id );
        INTEGER_FUNCTION GetNumberofHomeScreenItems ( INTEGER id );
        STRING_FUNCTION GetListItemLabel ( INTEGER panelID , INTEGER indexofItem );
        SIMPLSHARPSTRING_FUNCTION GetListItemIcon ( INTEGER panelID , INTEGER indexofItem );
        INTEGER_FUNCTION GetStartupSubSystem ( INTEGER id );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER SystemReady;

        // class properties
        DelegateProperty DelegateFnUshort UpdateHomeScreen;
        DelegateProperty DelegateFnUshortUshort TriggerAction;
        SIGNED_LONG_INTEGER ID;
    };

     class SystemUIHelper 
    {
        // class delegates
        delegate FUNCTION DelegateFnUshort ( INTEGER i );
        delegate FUNCTION DelegateFnUshortUshort ( INTEGER i , INTEGER j );

        // class events

        // class functions
        FUNCTION Initialize ();
        FUNCTION RequestHomeScreen ();
        FUNCTION HomeScreenItemSelected ( INTEGER item , INTEGER panelID );
        FUNCTION RequestSubpage ( INTEGER subpageJoin );
        FUNCTION InitializeBase ();
        FUNCTION Register ( SIGNED_LONG_INTEGER id );
        FUNCTION TriggerStartupSubsystem ();
        FUNCTION TriggerPersistentSubsystem ();
        FUNCTION ShowHomeScreen ();
        FUNCTION HideHomeScreen ();
        INTEGER_FUNCTION GetNumberofVisibleSubsystems ( INTEGER id );
        INTEGER_FUNCTION GetNumberofHomeScreenItems ( INTEGER id );
        STRING_FUNCTION GetListItemLabel ( INTEGER panelID , INTEGER indexofItem );
        SIMPLSHARPSTRING_FUNCTION GetListItemIcon ( INTEGER panelID , INTEGER indexofItem );
        INTEGER_FUNCTION GetStartupSubSystem ( INTEGER id );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER SystemReady;

        // class properties
        DelegateProperty DelegateFnUshort TriggerSubpage;
        DelegateProperty DelegateFnUshort UpdateHomeScreen;
        DelegateProperty DelegateFnUshortUshort TriggerAction;
        SIGNED_LONG_INTEGER ID;
    };

     class SystemUIMLX3Helper 
    {
        // class delegates
        delegate FUNCTION DelegateFnUshort ( INTEGER i );
        delegate FUNCTION DelegateFnUshortUshort ( INTEGER i , INTEGER j );

        // class events

        // class functions
        FUNCTION Initialize ();
        FUNCTION HomeScreenItemSelected ( INTEGER item , INTEGER panelID );
        FUNCTION InitializeBase ();
        FUNCTION Register ( SIGNED_LONG_INTEGER id );
        FUNCTION TriggerStartupSubsystem ();
        FUNCTION TriggerPersistentSubsystem ();
        FUNCTION ShowHomeScreen ();
        FUNCTION HideHomeScreen ();
        INTEGER_FUNCTION GetNumberofVisibleSubsystems ( INTEGER id );
        INTEGER_FUNCTION GetNumberofHomeScreenItems ( INTEGER id );
        STRING_FUNCTION GetListItemLabel ( INTEGER panelID , INTEGER indexofItem );
        SIMPLSHARPSTRING_FUNCTION GetListItemIcon ( INTEGER panelID , INTEGER indexofItem );
        INTEGER_FUNCTION GetStartupSubSystem ( INTEGER id );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER SystemReady;

        // class properties
        DelegateProperty DelegateFnUshort UpdateHomeScreen;
        DelegateProperty DelegateFnUshortUshort TriggerAction;
        SIGNED_LONG_INTEGER ID;
    };

     class RioRegistry 
    {
        // class delegates

        // class events

        // class functions
        LONG_INTEGER_FUNCTION Unregister ( SIGNED_LONG_INTEGER id );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

