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

namespace UserModule_TWO_WAY_ABUF_V_0_1
{
    public class UserModuleClass_TWO_WAY_ABUF_V_0_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput ENABLE;
        Crestron.Logos.SplusObjects.AnalogInput TX_IN;
        Crestron.Logos.SplusObjects.AnalogInput RX_IN;
        Crestron.Logos.SplusObjects.AnalogInput RE_PROPOGATE;
        Crestron.Logos.SplusObjects.AnalogOutput TX_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput RX_OUT;
        object ENABLE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 12;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)RE_PROPOGATE  .UshortValue);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 16;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (TX_IN  .UshortValue != RX_IN  .UshortValue) ) && Functions.TestForTrue ( ENABLE  .Value )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 18;
                                TX_OUT  .Value = (ushort) ( TX_IN  .UshortValue ) ; 
                                } 
                            
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 23;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (RX_IN  .UshortValue != TX_IN  .UshortValue) ) && Functions.TestForTrue ( ENABLE  .Value )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 25;
                                RX_OUT  .Value = (ushort) ( RX_IN  .UshortValue ) ; 
                                } 
                            
                            } 
                        
                        else 
                            { 
                            } 
                        
                        } 
                        
                    }
                    
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object TX_IN_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 37;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (TX_IN  .UshortValue != RX_IN  .UshortValue) ) && Functions.TestForTrue ( ENABLE  .Value )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 39;
                TX_OUT  .Value = (ushort) ( TX_IN  .UshortValue ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object RX_IN_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 45;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (RX_IN  .UshortValue != TX_IN  .UshortValue) ) && Functions.TestForTrue ( ENABLE  .Value )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 47;
            RX_OUT  .Value = (ushort) ( RX_IN  .UshortValue ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    ENABLE = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE__DigitalInput__, ENABLE );
    
    TX_IN = new Crestron.Logos.SplusObjects.AnalogInput( TX_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( TX_IN__AnalogSerialInput__, TX_IN );
    
    RX_IN = new Crestron.Logos.SplusObjects.AnalogInput( RX_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RX_IN__AnalogSerialInput__, RX_IN );
    
    RE_PROPOGATE = new Crestron.Logos.SplusObjects.AnalogInput( RE_PROPOGATE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RE_PROPOGATE__AnalogSerialInput__, RE_PROPOGATE );
    
    TX_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( TX_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TX_OUT__AnalogSerialOutput__, TX_OUT );
    
    RX_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( RX_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RX_OUT__AnalogSerialOutput__, RX_OUT );
    
    
    ENABLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_OnPush_0, false ) );
    TX_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( TX_IN_OnChange_1, false ) );
    RX_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( RX_IN_OnChange_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TWO_WAY_ABUF_V_0_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ENABLE__DigitalInput__ = 0;
const uint TX_IN__AnalogSerialInput__ = 0;
const uint RX_IN__AnalogSerialInput__ = 1;
const uint RE_PROPOGATE__AnalogSerialInput__ = 2;
const uint TX_OUT__AnalogSerialOutput__ = 0;
const uint RX_OUT__AnalogSerialOutput__ = 1;

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
