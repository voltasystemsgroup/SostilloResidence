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

namespace UserModule_COUNTDOWN_TIMER_V_0_2
{
    public class UserModuleClass_COUNTDOWN_TIMER_V_0_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        Crestron.Logos.SplusObjects.DigitalInput SECOND_PULSE;
        Crestron.Logos.SplusObjects.DigitalInput START;
        Crestron.Logos.SplusObjects.DigitalInput STOP;
        Crestron.Logos.SplusObjects.DigitalInput RESET;
        Crestron.Logos.SplusObjects.AnalogInput COUNT_DAY;
        Crestron.Logos.SplusObjects.AnalogInput COUNT_HOUR;
        Crestron.Logos.SplusObjects.AnalogInput COUNT_MINUTE;
        Crestron.Logos.SplusObjects.AnalogInput COUNT_SECOND;
        Crestron.Logos.SplusObjects.DigitalOutput COUNTDOWN_STARTED;
        Crestron.Logos.SplusObjects.DigitalOutput COUNTDOWN_FINISHED;
        Crestron.Logos.SplusObjects.AnalogOutput WATCH_DAY;
        Crestron.Logos.SplusObjects.AnalogOutput WATCH_HOUR;
        Crestron.Logos.SplusObjects.AnalogOutput WATCH_MINUTE;
        Crestron.Logos.SplusObjects.AnalogOutput WATCH_SECOND;
        Crestron.Logos.SplusObjects.StringOutput TIME_REMAINING;
        ushort GNCOUNTDOWNSTARTED = 0;
        short GNWATCHDAY = 0;
        short GNWATCHHOUR = 0;
        short GNWATCHMINUTE = 0;
        short GNWATCHSECOND = 0;
        private void COUNTDOWNFINISHED (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 33;
            Functions.Pulse ( 1, COUNTDOWN_FINISHED ) ; 
            
            }
            
        private void STARTCOUNTDOWN (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 38;
            GNCOUNTDOWNSTARTED = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 39;
            COUNTDOWN_STARTED  .Value = (ushort) ( GNCOUNTDOWNSTARTED ) ; 
            
            }
            
        private void STOPCOUNTDOWN (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 44;
            GNCOUNTDOWNSTARTED = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 45;
            COUNTDOWN_STARTED  .Value = (ushort) ( GNCOUNTDOWNSTARTED ) ; 
            
            }
            
        private void RESETCOUNTDOWN (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 50;
            STOPCOUNTDOWN (  __context__  ) ; 
            __context__.SourceCodeLine = 52;
            GNWATCHDAY = (short) ( 0 ) ; 
            __context__.SourceCodeLine = 53;
            GNWATCHHOUR = (short) ( 0 ) ; 
            __context__.SourceCodeLine = 54;
            GNWATCHMINUTE = (short) ( 0 ) ; 
            __context__.SourceCodeLine = 55;
            GNWATCHSECOND = (short) ( 0 ) ; 
            __context__.SourceCodeLine = 57;
            WATCH_DAY  .Value = (ushort) ( GNWATCHDAY ) ; 
            __context__.SourceCodeLine = 58;
            WATCH_HOUR  .Value = (ushort) ( GNWATCHHOUR ) ; 
            __context__.SourceCodeLine = 59;
            WATCH_MINUTE  .Value = (ushort) ( GNWATCHMINUTE ) ; 
            __context__.SourceCodeLine = 60;
            WATCH_SECOND  .Value = (ushort) ( GNWATCHSECOND ) ; 
            __context__.SourceCodeLine = 62;
            MakeString ( TIME_REMAINING , "{0:d2}:{1:d2}:{2:d2}", (short)GNWATCHHOUR, (short)GNWATCHMINUTE, (short)GNWATCHSECOND) ; 
            
            }
            
        object SECOND_PULSE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 69;
                if ( Functions.TestForTrue  ( ( GNCOUNTDOWNSTARTED)  ) ) 
                    { 
                    __context__.SourceCodeLine = 71;
                    GNWATCHSECOND = (short) ( (GNWATCHSECOND - 1) ) ; 
                    __context__.SourceCodeLine = 73;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GNWATCHSECOND == Functions.ToSignedLongInteger( -( 1 ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 75;
                        GNWATCHMINUTE = (short) ( (GNWATCHMINUTE - 1) ) ; 
                        __context__.SourceCodeLine = 77;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GNWATCHMINUTE == Functions.ToSignedLongInteger( -( 1 ) )))  ) ) 
                            { 
                            __context__.SourceCodeLine = 79;
                            GNWATCHHOUR = (short) ( (GNWATCHHOUR - 1) ) ; 
                            __context__.SourceCodeLine = 81;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GNWATCHHOUR == Functions.ToSignedLongInteger( -( 1 ) )))  ) ) 
                                { 
                                __context__.SourceCodeLine = 83;
                                GNWATCHDAY = (short) ( (GNWATCHDAY - 1) ) ; 
                                __context__.SourceCodeLine = 85;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GNWATCHDAY == Functions.ToSignedLongInteger( -( 1 ) )))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 87;
                                    RESETCOUNTDOWN (  __context__  ) ; 
                                    __context__.SourceCodeLine = 88;
                                    COUNTDOWNFINISHED (  __context__  ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 92;
                                    GNWATCHHOUR = (short) ( 23 ) ; 
                                    __context__.SourceCodeLine = 93;
                                    GNWATCHMINUTE = (short) ( 59 ) ; 
                                    __context__.SourceCodeLine = 94;
                                    GNWATCHSECOND = (short) ( 59 ) ; 
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 99;
                                GNWATCHMINUTE = (short) ( 59 ) ; 
                                __context__.SourceCodeLine = 100;
                                GNWATCHSECOND = (short) ( 59 ) ; 
                                } 
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 105;
                            GNWATCHSECOND = (short) ( 59 ) ; 
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 109;
                    WATCH_DAY  .Value = (ushort) ( GNWATCHDAY ) ; 
                    __context__.SourceCodeLine = 110;
                    WATCH_HOUR  .Value = (ushort) ( GNWATCHHOUR ) ; 
                    __context__.SourceCodeLine = 111;
                    WATCH_MINUTE  .Value = (ushort) ( GNWATCHMINUTE ) ; 
                    __context__.SourceCodeLine = 112;
                    WATCH_SECOND  .Value = (ushort) ( GNWATCHSECOND ) ; 
                    __context__.SourceCodeLine = 114;
                    MakeString ( TIME_REMAINING , "{0:d2}:{1:d2}:{2:d2}", (short)GNWATCHHOUR, (short)GNWATCHMINUTE, (short)GNWATCHSECOND) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object COUNT_DAY_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 122;
            GNWATCHDAY = (short) ( COUNT_DAY  .ShortValue ) ; 
            __context__.SourceCodeLine = 123;
            WATCH_DAY  .Value = (ushort) ( GNWATCHDAY ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object COUNT_HOUR_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 128;
        GNWATCHHOUR = (short) ( COUNT_HOUR  .ShortValue ) ; 
        __context__.SourceCodeLine = 130;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GNWATCHHOUR >= 24 ))  ) ) 
            { 
            __context__.SourceCodeLine = 132;
            GNWATCHDAY = (short) ( (GNWATCHHOUR / 24) ) ; 
            __context__.SourceCodeLine = 133;
            GNWATCHHOUR = (short) ( Mod( GNWATCHHOUR , 24 ) ) ; 
            __context__.SourceCodeLine = 135;
            WATCH_DAY  .Value = (ushort) ( GNWATCHDAY ) ; 
            } 
        
        __context__.SourceCodeLine = 137;
        WATCH_HOUR  .Value = (ushort) ( GNWATCHHOUR ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COUNT_MINUTE_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 142;
        GNWATCHMINUTE = (short) ( COUNT_MINUTE  .ShortValue ) ; 
        __context__.SourceCodeLine = 144;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GNWATCHMINUTE >= 60 ))  ) ) 
            { 
            __context__.SourceCodeLine = 146;
            GNWATCHHOUR = (short) ( (GNWATCHMINUTE / 60) ) ; 
            __context__.SourceCodeLine = 147;
            GNWATCHMINUTE = (short) ( Mod( GNWATCHMINUTE , 60 ) ) ; 
            __context__.SourceCodeLine = 149;
            WATCH_HOUR  .Value = (ushort) ( GNWATCHHOUR ) ; 
            } 
        
        __context__.SourceCodeLine = 151;
        WATCH_MINUTE  .Value = (ushort) ( GNWATCHMINUTE ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COUNT_SECOND_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 156;
        GNWATCHSECOND = (short) ( COUNT_SECOND  .ShortValue ) ; 
        __context__.SourceCodeLine = 158;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GNWATCHSECOND >= 60 ))  ) ) 
            { 
            __context__.SourceCodeLine = 160;
            GNWATCHMINUTE = (short) ( (GNWATCHSECOND / 60) ) ; 
            __context__.SourceCodeLine = 161;
            GNWATCHSECOND = (short) ( Mod( GNWATCHSECOND , 60 ) ) ; 
            __context__.SourceCodeLine = 163;
            WATCH_MINUTE  .Value = (ushort) ( GNWATCHMINUTE ) ; 
            } 
        
        __context__.SourceCodeLine = 165;
        WATCH_SECOND  .Value = (ushort) ( GNWATCHSECOND ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object START_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 170;
        STARTCOUNTDOWN (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOP_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 175;
        STOPCOUNTDOWN (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESET_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 180;
        RESETCOUNTDOWN (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 185;
        STOPCOUNTDOWN (  __context__  ) ; 
        __context__.SourceCodeLine = 187;
        RESETCOUNTDOWN (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    SECOND_PULSE = new Crestron.Logos.SplusObjects.DigitalInput( SECOND_PULSE__DigitalInput__, this );
    m_DigitalInputList.Add( SECOND_PULSE__DigitalInput__, SECOND_PULSE );
    
    START = new Crestron.Logos.SplusObjects.DigitalInput( START__DigitalInput__, this );
    m_DigitalInputList.Add( START__DigitalInput__, START );
    
    STOP = new Crestron.Logos.SplusObjects.DigitalInput( STOP__DigitalInput__, this );
    m_DigitalInputList.Add( STOP__DigitalInput__, STOP );
    
    RESET = new Crestron.Logos.SplusObjects.DigitalInput( RESET__DigitalInput__, this );
    m_DigitalInputList.Add( RESET__DigitalInput__, RESET );
    
    COUNTDOWN_STARTED = new Crestron.Logos.SplusObjects.DigitalOutput( COUNTDOWN_STARTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( COUNTDOWN_STARTED__DigitalOutput__, COUNTDOWN_STARTED );
    
    COUNTDOWN_FINISHED = new Crestron.Logos.SplusObjects.DigitalOutput( COUNTDOWN_FINISHED__DigitalOutput__, this );
    m_DigitalOutputList.Add( COUNTDOWN_FINISHED__DigitalOutput__, COUNTDOWN_FINISHED );
    
    COUNT_DAY = new Crestron.Logos.SplusObjects.AnalogInput( COUNT_DAY__AnalogSerialInput__, this );
    m_AnalogInputList.Add( COUNT_DAY__AnalogSerialInput__, COUNT_DAY );
    
    COUNT_HOUR = new Crestron.Logos.SplusObjects.AnalogInput( COUNT_HOUR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( COUNT_HOUR__AnalogSerialInput__, COUNT_HOUR );
    
    COUNT_MINUTE = new Crestron.Logos.SplusObjects.AnalogInput( COUNT_MINUTE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( COUNT_MINUTE__AnalogSerialInput__, COUNT_MINUTE );
    
    COUNT_SECOND = new Crestron.Logos.SplusObjects.AnalogInput( COUNT_SECOND__AnalogSerialInput__, this );
    m_AnalogInputList.Add( COUNT_SECOND__AnalogSerialInput__, COUNT_SECOND );
    
    WATCH_DAY = new Crestron.Logos.SplusObjects.AnalogOutput( WATCH_DAY__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WATCH_DAY__AnalogSerialOutput__, WATCH_DAY );
    
    WATCH_HOUR = new Crestron.Logos.SplusObjects.AnalogOutput( WATCH_HOUR__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WATCH_HOUR__AnalogSerialOutput__, WATCH_HOUR );
    
    WATCH_MINUTE = new Crestron.Logos.SplusObjects.AnalogOutput( WATCH_MINUTE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WATCH_MINUTE__AnalogSerialOutput__, WATCH_MINUTE );
    
    WATCH_SECOND = new Crestron.Logos.SplusObjects.AnalogOutput( WATCH_SECOND__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WATCH_SECOND__AnalogSerialOutput__, WATCH_SECOND );
    
    TIME_REMAINING = new Crestron.Logos.SplusObjects.StringOutput( TIME_REMAINING__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TIME_REMAINING__AnalogSerialOutput__, TIME_REMAINING );
    
    
    SECOND_PULSE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SECOND_PULSE_OnPush_0, false ) );
    COUNT_DAY.OnAnalogChange.Add( new InputChangeHandlerWrapper( COUNT_DAY_OnChange_1, false ) );
    COUNT_HOUR.OnAnalogChange.Add( new InputChangeHandlerWrapper( COUNT_HOUR_OnChange_2, false ) );
    COUNT_MINUTE.OnAnalogChange.Add( new InputChangeHandlerWrapper( COUNT_MINUTE_OnChange_3, false ) );
    COUNT_SECOND.OnAnalogChange.Add( new InputChangeHandlerWrapper( COUNT_SECOND_OnChange_4, false ) );
    START.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_OnPush_5, false ) );
    STOP.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_OnPush_6, false ) );
    RESET.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESET_OnPush_7, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_COUNTDOWN_TIMER_V_0_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SECOND_PULSE__DigitalInput__ = 0;
const uint START__DigitalInput__ = 1;
const uint STOP__DigitalInput__ = 2;
const uint RESET__DigitalInput__ = 3;
const uint COUNT_DAY__AnalogSerialInput__ = 0;
const uint COUNT_HOUR__AnalogSerialInput__ = 1;
const uint COUNT_MINUTE__AnalogSerialInput__ = 2;
const uint COUNT_SECOND__AnalogSerialInput__ = 3;
const uint COUNTDOWN_STARTED__DigitalOutput__ = 0;
const uint COUNTDOWN_FINISHED__DigitalOutput__ = 1;
const uint WATCH_DAY__AnalogSerialOutput__ = 0;
const uint WATCH_HOUR__AnalogSerialOutput__ = 1;
const uint WATCH_MINUTE__AnalogSerialOutput__ = 2;
const uint WATCH_SECOND__AnalogSerialOutput__ = 3;
const uint TIME_REMAINING__AnalogSerialOutput__ = 4;

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
