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

namespace UserModule_CLOCK_VALS_V_0_1
{
    public class UserModuleClass_CLOCK_VALS_V_0_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        Crestron.Logos.SplusObjects.StringInput TOD;
        Crestron.Logos.SplusObjects.AnalogOutput MONTH_NUM;
        Crestron.Logos.SplusObjects.AnalogOutput DAY_NUM;
        Crestron.Logos.SplusObjects.AnalogOutput YEAR_NUM;
        Crestron.Logos.SplusObjects.AnalogOutput HOUR_NUM;
        Crestron.Logos.SplusObjects.AnalogOutput MINUTE_NUM;
        Crestron.Logos.SplusObjects.AnalogOutput SECOND_NUM;
        ushort GNMONTH = 0;
        ushort GNDAY = 0;
        ushort GNYEAR = 0;
        ushort GNHOUR = 0;
        ushort GNMINUTE = 0;
        ushort GNSECOND = 0;
        object TOD_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort NVAL = 0;
                
                
                __context__.SourceCodeLine = 24;
                NVAL = (ushort) ( Functions.Atoi( Functions.Mid( TOD , (int)( 1 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 25;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GNMONTH != NVAL))  ) ) 
                    { 
                    __context__.SourceCodeLine = 27;
                    GNMONTH = (ushort) ( NVAL ) ; 
                    __context__.SourceCodeLine = 28;
                    MONTH_NUM  .Value = (ushort) ( GNMONTH ) ; 
                    } 
                
                __context__.SourceCodeLine = 31;
                NVAL = (ushort) ( Functions.Atoi( Functions.Mid( TOD , (int)( 3 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 32;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GNDAY != NVAL))  ) ) 
                    { 
                    __context__.SourceCodeLine = 34;
                    GNDAY = (ushort) ( NVAL ) ; 
                    __context__.SourceCodeLine = 35;
                    DAY_NUM  .Value = (ushort) ( GNDAY ) ; 
                    } 
                
                __context__.SourceCodeLine = 38;
                NVAL = (ushort) ( Functions.Atoi( Functions.Mid( TOD , (int)( 5 ) , (int)( 4 ) ) ) ) ; 
                __context__.SourceCodeLine = 39;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GNYEAR != NVAL))  ) ) 
                    { 
                    __context__.SourceCodeLine = 41;
                    GNYEAR = (ushort) ( NVAL ) ; 
                    __context__.SourceCodeLine = 42;
                    YEAR_NUM  .Value = (ushort) ( GNYEAR ) ; 
                    } 
                
                __context__.SourceCodeLine = 45;
                NVAL = (ushort) ( Functions.Atoi( Functions.Mid( TOD , (int)( 9 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 46;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GNHOUR != NVAL))  ) ) 
                    { 
                    __context__.SourceCodeLine = 48;
                    GNHOUR = (ushort) ( NVAL ) ; 
                    __context__.SourceCodeLine = 49;
                    HOUR_NUM  .Value = (ushort) ( GNHOUR ) ; 
                    } 
                
                __context__.SourceCodeLine = 52;
                NVAL = (ushort) ( Functions.Atoi( Functions.Mid( TOD , (int)( 11 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 53;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GNMINUTE != NVAL))  ) ) 
                    { 
                    __context__.SourceCodeLine = 55;
                    GNMINUTE = (ushort) ( NVAL ) ; 
                    __context__.SourceCodeLine = 56;
                    MINUTE_NUM  .Value = (ushort) ( GNMINUTE ) ; 
                    } 
                
                __context__.SourceCodeLine = 59;
                NVAL = (ushort) ( Functions.Atoi( Functions.Mid( TOD , (int)( 13 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 60;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GNSECOND != NVAL))  ) ) 
                    { 
                    __context__.SourceCodeLine = 62;
                    GNSECOND = (ushort) ( NVAL ) ; 
                    __context__.SourceCodeLine = 63;
                    SECOND_NUM  .Value = (ushort) ( GNSECOND ) ; 
                    } 
                
                
                
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
            
            __context__.SourceCodeLine = 69;
            GNMONTH = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 70;
            GNDAY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 71;
            GNYEAR = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 72;
            GNHOUR = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 73;
            GNMINUTE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 74;
            GNSECOND = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 76;
            MONTH_NUM  .Value = (ushort) ( GNMONTH ) ; 
            __context__.SourceCodeLine = 77;
            DAY_NUM  .Value = (ushort) ( GNDAY ) ; 
            __context__.SourceCodeLine = 78;
            YEAR_NUM  .Value = (ushort) ( GNYEAR ) ; 
            __context__.SourceCodeLine = 79;
            HOUR_NUM  .Value = (ushort) ( GNHOUR ) ; 
            __context__.SourceCodeLine = 80;
            MINUTE_NUM  .Value = (ushort) ( GNMINUTE ) ; 
            __context__.SourceCodeLine = 81;
            SECOND_NUM  .Value = (ushort) ( GNSECOND ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        MONTH_NUM = new Crestron.Logos.SplusObjects.AnalogOutput( MONTH_NUM__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( MONTH_NUM__AnalogSerialOutput__, MONTH_NUM );
        
        DAY_NUM = new Crestron.Logos.SplusObjects.AnalogOutput( DAY_NUM__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( DAY_NUM__AnalogSerialOutput__, DAY_NUM );
        
        YEAR_NUM = new Crestron.Logos.SplusObjects.AnalogOutput( YEAR_NUM__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( YEAR_NUM__AnalogSerialOutput__, YEAR_NUM );
        
        HOUR_NUM = new Crestron.Logos.SplusObjects.AnalogOutput( HOUR_NUM__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( HOUR_NUM__AnalogSerialOutput__, HOUR_NUM );
        
        MINUTE_NUM = new Crestron.Logos.SplusObjects.AnalogOutput( MINUTE_NUM__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( MINUTE_NUM__AnalogSerialOutput__, MINUTE_NUM );
        
        SECOND_NUM = new Crestron.Logos.SplusObjects.AnalogOutput( SECOND_NUM__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( SECOND_NUM__AnalogSerialOutput__, SECOND_NUM );
        
        TOD = new Crestron.Logos.SplusObjects.StringInput( TOD__AnalogSerialInput__, 20, this );
        m_StringInputList.Add( TOD__AnalogSerialInput__, TOD );
        
        
        TOD.OnSerialChange.Add( new InputChangeHandlerWrapper( TOD_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_CLOCK_VALS_V_0_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint TOD__AnalogSerialInput__ = 0;
    const uint MONTH_NUM__AnalogSerialOutput__ = 0;
    const uint DAY_NUM__AnalogSerialOutput__ = 1;
    const uint YEAR_NUM__AnalogSerialOutput__ = 2;
    const uint HOUR_NUM__AnalogSerialOutput__ = 3;
    const uint MINUTE_NUM__AnalogSerialOutput__ = 4;
    const uint SECOND_NUM__AnalogSerialOutput__ = 5;
    
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
