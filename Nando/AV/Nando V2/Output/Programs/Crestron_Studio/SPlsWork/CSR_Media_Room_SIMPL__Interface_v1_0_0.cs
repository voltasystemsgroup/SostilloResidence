using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;
using Crestron.Rio.DataStructures.Media.UserInterfaces;
using Crestron.Rio.DataStructures.Media.DeviceManagement;
using Crestron.Rio.DataStructures.Media.DistributionComponents;
using Crestron.Rio.DataStructures.Media;
using Crestron.Rio.DataStructures.Media.Routing;
using Crestron.Rio.System;
using Crestron.Rio.DataStructures;

namespace CrestronModule_CSR_MEDIA_ROOM_SIMPL__INTERFACE_V1_0_0
{
    public class CrestronModuleClass_CSR_MEDIA_ROOM_SIMPL__INTERFACE_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput ROOMON;
        Crestron.Logos.SplusObjects.DigitalInput ROOMOFF;
        Crestron.Logos.SplusObjects.DigitalInput SETGROUPVOLUMEUP;
        Crestron.Logos.SplusObjects.DigitalInput SETGROUPVOLUMEDOWN;
        Crestron.Logos.SplusObjects.DigitalInput DNDON;
        Crestron.Logos.SplusObjects.DigitalInput DNDOFF;
        Crestron.Logos.SplusObjects.AnalogInput ROOMID;
        Crestron.Logos.SplusObjects.AnalogInput SETROOMSOURCE;
        Crestron.Logos.SplusObjects.DigitalOutput ROOMON_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ROOMOFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput GROUPVOLUMETRACKINGACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput AUDIOENDPOINTSUPPORTSVOLUMETRACKING;
        Crestron.Logos.SplusObjects.DigitalOutput AUDIOENDPOINTISDEFINED;
        Crestron.Logos.SplusObjects.DigitalOutput AUDIOENDPOINTISON;
        Crestron.Logos.SplusObjects.DigitalOutput AUDIOENDPOINTISOFF;
        Crestron.Logos.SplusObjects.DigitalOutput ACTIVATEINTERRUPTMUTE;
        Crestron.Logos.SplusObjects.DigitalOutput TERMINATEINTERRUPTMUTE;
        Crestron.Logos.SplusObjects.AnalogOutput ROOMSOURCE_FB;
        Crestron.Logos.SplusObjects.StringOutput ROOMNAME;
        Crestron.Logos.SplusObjects.StringOutput ROOMSOURCENAME;
        Crestron.Logos.SplusObjects.StringOutput ROOMSOURCENOWPLAYINGLINE1;
        Crestron.Logos.SplusObjects.StringOutput ROOMSOURCENOWPLAYINGLINE2;
        Crestron.Rio.DataStructures.Media.DistributionComponents.MediaRoomSSharpComponent SIMPLSHARPCOMPONENT;
        ushort ROOMIDSET = 0;
        ushort MEDIASUBSYSTEMINITIALIZED = 0;
        object ROOMON_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 62;
                SIMPLSHARPCOMPONENT . TurnRoomOn ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ROOMOFF_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 67;
            SIMPLSHARPCOMPONENT . TurnRoomOff ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SETGROUPVOLUMEUP_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 72;
        SIMPLSHARPCOMPONENT . StartGroupVolumeUp ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETGROUPVOLUMEUP_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 77;
        SIMPLSHARPCOMPONENT . StopGroupVolumeUp ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETGROUPVOLUMEDOWN_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 82;
        SIMPLSHARPCOMPONENT . StartGroupVolumeDown ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETGROUPVOLUMEDOWN_OnRelease_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 87;
        SIMPLSHARPCOMPONENT . StopGroupVolumeDown ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DNDON_OnRelease_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 92;
        SIMPLSHARPCOMPONENT . SetDNDOn ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DNDOFF_OnRelease_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 97;
        SIMPLSHARPCOMPONENT . SetDNDOff ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOMID_OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 102;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMIDSET == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 104;
            ROOMIDSET = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 106;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEDIASUBSYSTEMINITIALIZED == 1))  ) ) 
                {
                __context__.SourceCodeLine = 107;
                SIMPLSHARPCOMPONENT . AssociateSSharpComponent ( (int)( ROOMID  .IntValue )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETROOMSOURCE_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 113;
        SIMPLSHARPCOMPONENT . SetRoomSource ( (int)( SETROOMSOURCE  .IntValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void UPDATENAMECALLBACK ( SimplSharpString ROOMNAMEFROMSSHARP ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 118;
        ROOMNAME  .UpdateValue ( ROOMNAMEFROMSSHARP  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEROOMONFEEDBACKCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 123;
        ROOMOFF_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 124;
        ROOMON_FB  .Value = (ushort) ( 1 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEROOMOFFFEEDBACKCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 129;
        ROOMON_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 130;
        ROOMOFF_FB  .Value = (ushort) ( 1 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESELECTEDSOURCEIDCALLBACK ( int SOURCEID ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 135;
        ROOMSOURCE_FB  .Value = (ushort) ( SOURCEID ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATESELECTEDSOURCENAMECALLBACK ( SimplSharpString SOURCENAMEFROMSSHARP ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 140;
        ROOMSOURCENAME  .UpdateValue ( SOURCENAMEFROMSSHARP  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATENOWPLAYINGLINE1CALLBACK ( SimplSharpString NOWPLAYINGINFORMATION ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 145;
        ROOMSOURCENOWPLAYINGLINE1  .UpdateValue ( NOWPLAYINGINFORMATION  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATENOWPLAYINGLINE2CALLBACK ( SimplSharpString NOWPLAYINGINFORMATION ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 150;
        ROOMSOURCENOWPLAYINGLINE2  .UpdateValue ( NOWPLAYINGINFORMATION  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEGROUPVOLUMETRACKINGENABLEDCALLBACK ( int VOLUMETRACKINGSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 155;
        GROUPVOLUMETRACKINGACTIVE  .Value = (ushort) ( VOLUMETRACKINGSTATE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEAUDIOENDPOINTVOLUMETRACKINGSUPPORTCALLBACK ( int VOLUMETRACKINGABILITY ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 160;
        AUDIOENDPOINTSUPPORTSVOLUMETRACKING  .Value = (ushort) ( VOLUMETRACKINGABILITY ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEAUDIOENDPOINTISDEFINEDCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 165;
        AUDIOENDPOINTISDEFINED  .Value = (ushort) ( 1 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEAUDIOENDPOINTONFEEDBACKCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 170;
        AUDIOENDPOINTISOFF  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 171;
        AUDIOENDPOINTISON  .Value = (ushort) ( 1 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEAUDIOENDPOINTOFFFEEDBACKCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 176;
        AUDIOENDPOINTISON  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 177;
        AUDIOENDPOINTISOFF  .Value = (ushort) ( 1 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEINTERRUPTMUTEACTIVATIONCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 182;
        ACTIVATEINTERRUPTMUTE  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 183;
        ACTIVATEINTERRUPTMUTE  .Value = (ushort) ( 0 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void UPDATEINTERRUPTMUTETERMINATIONCALLBACK ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 188;
        TERMINATEINTERRUPTMUTE  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 189;
        TERMINATEINTERRUPTMUTE  .Value = (ushort) ( 0 ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void MEDIAINITIALIZATIONCOMPLETEEVENTHANDLER ( object __sender__ /*EventArgs ARGS */) 
    { 
    EventArgs  ARGS  = (EventArgs )__sender__;
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 194;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATENAME , UPDATENAMECALLBACK ) 
        SIMPLSHARPCOMPONENT .updateName  = UPDATENAMECALLBACK; ; 
        __context__.SourceCodeLine = 195;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEROOMONFEEDBACK , UPDATEROOMONFEEDBACKCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateRoomOnFeedback  = UPDATEROOMONFEEDBACKCALLBACK; ; 
        __context__.SourceCodeLine = 196;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEROOMOFFFEEDBACK , UPDATEROOMOFFFEEDBACKCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateRoomOffFeedback  = UPDATEROOMOFFFEEDBACKCALLBACK; ; 
        __context__.SourceCodeLine = 197;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESELECTEDSOURCEID , UPDATESELECTEDSOURCEIDCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSelectedSourceID  = UPDATESELECTEDSOURCEIDCALLBACK; ; 
        __context__.SourceCodeLine = 198;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATESELECTEDSOURCENAME , UPDATESELECTEDSOURCENAMECALLBACK ) 
        SIMPLSHARPCOMPONENT .updateSelectedSourceName  = UPDATESELECTEDSOURCENAMECALLBACK; ; 
        __context__.SourceCodeLine = 199;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATENOWPLAYINGLINE1 , UPDATENOWPLAYINGLINE1CALLBACK ) 
        SIMPLSHARPCOMPONENT .updateNowPlayingLine1  = UPDATENOWPLAYINGLINE1CALLBACK; ; 
        __context__.SourceCodeLine = 200;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATENOWPLAYINGLINE2 , UPDATENOWPLAYINGLINE2CALLBACK ) 
        SIMPLSHARPCOMPONENT .updateNowPlayingLine2  = UPDATENOWPLAYINGLINE2CALLBACK; ; 
        __context__.SourceCodeLine = 202;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEGROUPVOLUMETRACKINGENABLED , UPDATEGROUPVOLUMETRACKINGENABLEDCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateGroupVolumeTrackingEnabled  = UPDATEGROUPVOLUMETRACKINGENABLEDCALLBACK; ; 
        __context__.SourceCodeLine = 203;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEAUDIOENDPOINTVOLUMETRACKINGSUPPORT , UPDATEAUDIOENDPOINTVOLUMETRACKINGSUPPORTCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateAudioEndpointVolumeTrackingSupport  = UPDATEAUDIOENDPOINTVOLUMETRACKINGSUPPORTCALLBACK; ; 
        __context__.SourceCodeLine = 204;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEAUDIOENDPOINTISDEFINED , UPDATEAUDIOENDPOINTISDEFINEDCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateAudioEndpointIsDefined  = UPDATEAUDIOENDPOINTISDEFINEDCALLBACK; ; 
        __context__.SourceCodeLine = 205;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEAUDIOENDPOINTONFEEDBACK , UPDATEAUDIOENDPOINTONFEEDBACKCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateAudioEndpointOnFeedback  = UPDATEAUDIOENDPOINTONFEEDBACKCALLBACK; ; 
        __context__.SourceCodeLine = 206;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEAUDIOENDPOINTOFFFEEDBACK , UPDATEAUDIOENDPOINTOFFFEEDBACKCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateAudioEndpointOffFeedback  = UPDATEAUDIOENDPOINTOFFFEEDBACKCALLBACK; ; 
        __context__.SourceCodeLine = 208;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEINTERRUPTMUTEACTIVATION , UPDATEINTERRUPTMUTEACTIVATIONCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateInterruptMuteActivation  = UPDATEINTERRUPTMUTEACTIVATIONCALLBACK; ; 
        __context__.SourceCodeLine = 209;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEINTERRUPTMUTETERMINATION , UPDATEINTERRUPTMUTETERMINATIONCALLBACK ) 
        SIMPLSHARPCOMPONENT .updateInterruptMuteTermination  = UPDATEINTERRUPTMUTETERMINATIONCALLBACK; ; 
        __context__.SourceCodeLine = 211;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOMIDSET == 1))  ) ) 
            {
            __context__.SourceCodeLine = 212;
            SIMPLSHARPCOMPONENT . AssociateSSharpComponent ( (int)( ROOMID  .IntValue )) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 214;
            MEDIASUBSYSTEMINITIALIZED = (ushort) ( 1 ) ; 
            }
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 220;
        ROOMON_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 221;
        ROOMOFF_FB  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 222;
        GROUPVOLUMETRACKINGACTIVE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 223;
        AUDIOENDPOINTSUPPORTSVOLUMETRACKING  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 224;
        AUDIOENDPOINTISDEFINED  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 225;
        AUDIOENDPOINTISON  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 226;
        AUDIOENDPOINTISOFF  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 228;
        ROOMSOURCE_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 230;
        ROOMNAME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 231;
        ROOMSOURCENAME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 232;
        ROOMSOURCENOWPLAYINGLINE1  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 233;
        ROOMSOURCENOWPLAYINGLINE2  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 235;
        // RegisterEvent( MediaSubsystem , MEDIAINITIALIZATIONCOMPLETEEVENT , MEDIAINITIALIZATIONCOMPLETEEVENTHANDLER ) 
        try { g_criticalSection.Enter(); MediaSubsystem .MediaInitializationCompleteEvent  += MEDIAINITIALIZATIONCOMPLETEEVENTHANDLER; } finally { g_criticalSection.Leave(); }
        ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    ROOMON = new Crestron.Logos.SplusObjects.DigitalInput( ROOMON__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMON__DigitalInput__, ROOMON );
    
    ROOMOFF = new Crestron.Logos.SplusObjects.DigitalInput( ROOMOFF__DigitalInput__, this );
    m_DigitalInputList.Add( ROOMOFF__DigitalInput__, ROOMOFF );
    
    SETGROUPVOLUMEUP = new Crestron.Logos.SplusObjects.DigitalInput( SETGROUPVOLUMEUP__DigitalInput__, this );
    m_DigitalInputList.Add( SETGROUPVOLUMEUP__DigitalInput__, SETGROUPVOLUMEUP );
    
    SETGROUPVOLUMEDOWN = new Crestron.Logos.SplusObjects.DigitalInput( SETGROUPVOLUMEDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( SETGROUPVOLUMEDOWN__DigitalInput__, SETGROUPVOLUMEDOWN );
    
    DNDON = new Crestron.Logos.SplusObjects.DigitalInput( DNDON__DigitalInput__, this );
    m_DigitalInputList.Add( DNDON__DigitalInput__, DNDON );
    
    DNDOFF = new Crestron.Logos.SplusObjects.DigitalInput( DNDOFF__DigitalInput__, this );
    m_DigitalInputList.Add( DNDOFF__DigitalInput__, DNDOFF );
    
    ROOMON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOMON_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOMON_FB__DigitalOutput__, ROOMON_FB );
    
    ROOMOFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOMOFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOMOFF_FB__DigitalOutput__, ROOMOFF_FB );
    
    GROUPVOLUMETRACKINGACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( GROUPVOLUMETRACKINGACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( GROUPVOLUMETRACKINGACTIVE__DigitalOutput__, GROUPVOLUMETRACKINGACTIVE );
    
    AUDIOENDPOINTSUPPORTSVOLUMETRACKING = new Crestron.Logos.SplusObjects.DigitalOutput( AUDIOENDPOINTSUPPORTSVOLUMETRACKING__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUDIOENDPOINTSUPPORTSVOLUMETRACKING__DigitalOutput__, AUDIOENDPOINTSUPPORTSVOLUMETRACKING );
    
    AUDIOENDPOINTISDEFINED = new Crestron.Logos.SplusObjects.DigitalOutput( AUDIOENDPOINTISDEFINED__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUDIOENDPOINTISDEFINED__DigitalOutput__, AUDIOENDPOINTISDEFINED );
    
    AUDIOENDPOINTISON = new Crestron.Logos.SplusObjects.DigitalOutput( AUDIOENDPOINTISON__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUDIOENDPOINTISON__DigitalOutput__, AUDIOENDPOINTISON );
    
    AUDIOENDPOINTISOFF = new Crestron.Logos.SplusObjects.DigitalOutput( AUDIOENDPOINTISOFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUDIOENDPOINTISOFF__DigitalOutput__, AUDIOENDPOINTISOFF );
    
    ACTIVATEINTERRUPTMUTE = new Crestron.Logos.SplusObjects.DigitalOutput( ACTIVATEINTERRUPTMUTE__DigitalOutput__, this );
    m_DigitalOutputList.Add( ACTIVATEINTERRUPTMUTE__DigitalOutput__, ACTIVATEINTERRUPTMUTE );
    
    TERMINATEINTERRUPTMUTE = new Crestron.Logos.SplusObjects.DigitalOutput( TERMINATEINTERRUPTMUTE__DigitalOutput__, this );
    m_DigitalOutputList.Add( TERMINATEINTERRUPTMUTE__DigitalOutput__, TERMINATEINTERRUPTMUTE );
    
    ROOMID = new Crestron.Logos.SplusObjects.AnalogInput( ROOMID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ROOMID__AnalogSerialInput__, ROOMID );
    
    SETROOMSOURCE = new Crestron.Logos.SplusObjects.AnalogInput( SETROOMSOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SETROOMSOURCE__AnalogSerialInput__, SETROOMSOURCE );
    
    ROOMSOURCE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( ROOMSOURCE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOMSOURCE_FB__AnalogSerialOutput__, ROOMSOURCE_FB );
    
    ROOMNAME = new Crestron.Logos.SplusObjects.StringOutput( ROOMNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOMNAME__AnalogSerialOutput__, ROOMNAME );
    
    ROOMSOURCENAME = new Crestron.Logos.SplusObjects.StringOutput( ROOMSOURCENAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOMSOURCENAME__AnalogSerialOutput__, ROOMSOURCENAME );
    
    ROOMSOURCENOWPLAYINGLINE1 = new Crestron.Logos.SplusObjects.StringOutput( ROOMSOURCENOWPLAYINGLINE1__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOMSOURCENOWPLAYINGLINE1__AnalogSerialOutput__, ROOMSOURCENOWPLAYINGLINE1 );
    
    ROOMSOURCENOWPLAYINGLINE2 = new Crestron.Logos.SplusObjects.StringOutput( ROOMSOURCENOWPLAYINGLINE2__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOMSOURCENOWPLAYINGLINE2__AnalogSerialOutput__, ROOMSOURCENOWPLAYINGLINE2 );
    
    
    ROOMON.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOMON_OnPush_0, false ) );
    ROOMOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOMOFF_OnPush_1, false ) );
    SETGROUPVOLUMEUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( SETGROUPVOLUMEUP_OnPush_2, false ) );
    SETGROUPVOLUMEUP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SETGROUPVOLUMEUP_OnRelease_3, false ) );
    SETGROUPVOLUMEDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SETGROUPVOLUMEDOWN_OnPush_4, false ) );
    SETGROUPVOLUMEDOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SETGROUPVOLUMEDOWN_OnRelease_5, false ) );
    DNDON.OnDigitalRelease.Add( new InputChangeHandlerWrapper( DNDON_OnRelease_6, false ) );
    DNDOFF.OnDigitalRelease.Add( new InputChangeHandlerWrapper( DNDOFF_OnRelease_7, false ) );
    ROOMID.OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOMID_OnChange_8, false ) );
    SETROOMSOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETROOMSOURCE_OnChange_9, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    SIMPLSHARPCOMPONENT  = new Crestron.Rio.DataStructures.Media.DistributionComponents.MediaRoomSSharpComponent();
    
    
}

public CrestronModuleClass_CSR_MEDIA_ROOM_SIMPL__INTERFACE_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ROOMON__DigitalInput__ = 0;
const uint ROOMOFF__DigitalInput__ = 1;
const uint SETGROUPVOLUMEUP__DigitalInput__ = 2;
const uint SETGROUPVOLUMEDOWN__DigitalInput__ = 3;
const uint DNDON__DigitalInput__ = 4;
const uint DNDOFF__DigitalInput__ = 5;
const uint ROOMID__AnalogSerialInput__ = 0;
const uint SETROOMSOURCE__AnalogSerialInput__ = 1;
const uint ROOMON_FB__DigitalOutput__ = 0;
const uint ROOMOFF_FB__DigitalOutput__ = 1;
const uint GROUPVOLUMETRACKINGACTIVE__DigitalOutput__ = 2;
const uint AUDIOENDPOINTSUPPORTSVOLUMETRACKING__DigitalOutput__ = 3;
const uint AUDIOENDPOINTISDEFINED__DigitalOutput__ = 4;
const uint AUDIOENDPOINTISON__DigitalOutput__ = 5;
const uint AUDIOENDPOINTISOFF__DigitalOutput__ = 6;
const uint ACTIVATEINTERRUPTMUTE__DigitalOutput__ = 7;
const uint TERMINATEINTERRUPTMUTE__DigitalOutput__ = 8;
const uint ROOMSOURCE_FB__AnalogSerialOutput__ = 0;
const uint ROOMNAME__AnalogSerialOutput__ = 1;
const uint ROOMSOURCENAME__AnalogSerialOutput__ = 2;
const uint ROOMSOURCENOWPLAYINGLINE1__AnalogSerialOutput__ = 3;
const uint ROOMSOURCENOWPLAYINGLINE2__AnalogSerialOutput__ = 4;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
