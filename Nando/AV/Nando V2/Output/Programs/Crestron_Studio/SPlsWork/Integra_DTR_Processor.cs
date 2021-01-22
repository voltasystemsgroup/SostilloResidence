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

namespace CrestronModule_INTEGRA_DTR_PROCESSOR
{
    public class CrestronModuleClass_INTEGRA_DTR_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_DONE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> TUNER_KEY;
        Crestron.Logos.SplusObjects.AnalogInput VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogInput SELECTED_TUNER;
        Crestron.Logos.SplusObjects.BufferInput TUNER_COMMAND__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput VOLUME_COMMAND__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_FB;
        Crestron.Logos.SplusObjects.StringOutput TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        ushort IVOL = 0;
        ushort IVOLCHANGING = 0;
        CrestronString SFREQ;
        CrestronString STUNER;
        CrestronString SVOLUME;
        object TUNER_KEY_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort ITEMP = 0;
                
                
                __context__.SourceCodeLine = 71;
                ITEMP = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 72;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != 100))  ) ) 
                    { 
                    __context__.SourceCodeLine = 74;
                    switch ((int)SELECTED_TUNER  .UshortValue)
                    
                        { 
                        case 3 : 
                        
                            { 
                            __context__.SourceCodeLine = 78;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMP >= 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 80;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 10))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 82;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 3 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 84;
                                        MakeString ( SFREQ , "{0}0", SFREQ ) ; 
                                        __context__.SourceCodeLine = 85;
                                        TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                        __context__.SourceCodeLine = 86;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 90;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 93;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 11))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 95;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 97;
                                            SFREQ  .UpdateValue ( Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) )  ) ; 
                                            __context__.SourceCodeLine = 98;
                                            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                            __context__.SourceCodeLine = 99;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 102;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 12))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 104;
                                            SFREQ  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 105;
                                            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                            __context__.SourceCodeLine = 106;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 108;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 13))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 110;
                                                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}\r", "!1XCH" , SFREQ .PadLeft( 3, '0' )) ; 
                                                __context__.SourceCodeLine = 111;
                                                SFREQ  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 112;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 116;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 121;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 3 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 123;
                                    MakeString ( SFREQ , "{0}{1:d}", SFREQ , (short)ITEMP) ; 
                                    __context__.SourceCodeLine = 124;
                                    TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                    __context__.SourceCodeLine = 125;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 129;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                } 
                            
                            __context__.SourceCodeLine = 132;
                            break ; 
                            } 
                        
                        goto case 4 ;
                        case 4 : 
                        
                            { 
                            __context__.SourceCodeLine = 136;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMP >= 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 138;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 10))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 140;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 3 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 142;
                                        MakeString ( SFREQ , "{0}0", SFREQ ) ; 
                                        __context__.SourceCodeLine = 143;
                                        TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                        __context__.SourceCodeLine = 144;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 148;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 151;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 11))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 153;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 155;
                                            SFREQ  .UpdateValue ( Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) )  ) ; 
                                            __context__.SourceCodeLine = 156;
                                            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                            __context__.SourceCodeLine = 157;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 160;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 12))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 162;
                                            SFREQ  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 163;
                                            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                            __context__.SourceCodeLine = 164;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 166;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 13))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 168;
                                                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}\r", "!1SCH" , SFREQ .PadLeft( 3, '0' )) ; 
                                                __context__.SourceCodeLine = 169;
                                                SFREQ  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 170;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 174;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 179;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 3 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 181;
                                    MakeString ( SFREQ , "{0}{1:d}", SFREQ , (short)ITEMP) ; 
                                    __context__.SourceCodeLine = 182;
                                    TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                    __context__.SourceCodeLine = 183;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 187;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                } 
                            
                            __context__.SourceCodeLine = 190;
                            break ; 
                            } 
                        
                        goto case 1 ;
                        case 1 : 
                        
                            { 
                            __context__.SourceCodeLine = 194;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMP >= 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 196;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 10))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 198;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 5 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 200;
                                        MakeString ( SFREQ , "{0}0", SFREQ ) ; 
                                        __context__.SourceCodeLine = 201;
                                        MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} kHz", SFREQ ) ; 
                                        __context__.SourceCodeLine = 202;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 206;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 209;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 11))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 211;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 213;
                                            SFREQ  .UpdateValue ( Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) )  ) ; 
                                            __context__.SourceCodeLine = 214;
                                            MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} kHz", SFREQ ) ; 
                                            __context__.SourceCodeLine = 215;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 218;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 12))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 220;
                                            SFREQ  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 221;
                                            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                            __context__.SourceCodeLine = 222;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 224;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 13))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 226;
                                                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}\r", STUNER , SFREQ .PadLeft( 5, '0' )) ; 
                                                __context__.SourceCodeLine = 227;
                                                SFREQ  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 228;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 233;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 5 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 235;
                                    MakeString ( SFREQ , "{0}{1:d}", SFREQ , (short)ITEMP) ; 
                                    __context__.SourceCodeLine = 236;
                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} kHz", SFREQ ) ; 
                                    __context__.SourceCodeLine = 237;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 241;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                } 
                            
                            __context__.SourceCodeLine = 244;
                            break ; 
                            } 
                        
                        goto case 2 ;
                        case 2 : 
                        
                            { 
                            __context__.SourceCodeLine = 248;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMP >= 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 250;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 10))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 252;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 5 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 254;
                                        MakeString ( SFREQ , "{0}0", SFREQ ) ; 
                                        __context__.SourceCodeLine = 255;
                                        MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                        __context__.SourceCodeLine = 256;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 260;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 263;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 11))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 265;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 267;
                                            SFREQ  .UpdateValue ( Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) )  ) ; 
                                            __context__.SourceCodeLine = 268;
                                            MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                            __context__.SourceCodeLine = 269;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 272;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 12))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 274;
                                            SFREQ  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 275;
                                            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                            __context__.SourceCodeLine = 276;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 278;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 13))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 280;
                                                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}\r", STUNER , SFREQ .PadLeft( 5, '0' )) ; 
                                                __context__.SourceCodeLine = 281;
                                                SFREQ  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 282;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 286;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 291;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 5 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 293;
                                    MakeString ( SFREQ , "{0}{1:d}", SFREQ , (short)ITEMP) ; 
                                    __context__.SourceCodeLine = 294;
                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                    __context__.SourceCodeLine = 295;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 299;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                } 
                            
                            __context__.SourceCodeLine = 302;
                            break ; 
                            } 
                        
                        goto default;
                        default : 
                        
                            { 
                            __context__.SourceCodeLine = 306;
                            ITEMP = (ushort) ( 100 ) ; 
                            __context__.SourceCodeLine = 307;
                            break ; 
                            } 
                        break;
                        
                        } 
                        
                    
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object VOLUME_UP_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 315;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVOL < 100 ))  ) ) 
                { 
                __context__.SourceCodeLine = 317;
                IVOLCHANGING = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 318;
                IVOL = (ushort) ( (IVOL + 1) ) ; 
                __context__.SourceCodeLine = 319;
                VOLUME_FB  .Value = (ushort) ( IVOL ) ; 
                __context__.SourceCodeLine = 320;
                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1:X2}\r", SVOLUME , IVOL) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object VOLUME_DOWN_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 326;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVOL > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 328;
            IVOLCHANGING = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 329;
            IVOL = (ushort) ( (IVOL - 1) ) ; 
            __context__.SourceCodeLine = 330;
            VOLUME_FB  .Value = (ushort) ( IVOL ) ; 
            __context__.SourceCodeLine = 331;
            MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1:X2}\r", SVOLUME , IVOL) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_DONE_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 337;
        IVOLCHANGING = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_IN_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 342;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( VOLUME_IN  .UshortValue <= 100 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( VOLUME_IN  .UshortValue >= 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (IVOLCHANGING == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (VOLUME_IN  .UshortValue != IVOL) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 344;
            IVOL = (ushort) ( VOLUME_IN  .UshortValue ) ; 
            __context__.SourceCodeLine = 345;
            VOLUME_FB  .Value = (ushort) ( IVOL ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TUNER_COMMAND__DOLLAR___OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 351;
        STUNER  .UpdateValue ( TUNER_COMMAND__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_COMMAND__DOLLAR___OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 356;
        SVOLUME  .UpdateValue ( VOLUME_COMMAND__DOLLAR__  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 365;
        IVOLCHANGING = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    SFREQ  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    STUNER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    SVOLUME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    
    VOLUME_UP = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_UP__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_UP__DigitalInput__, VOLUME_UP );
    
    VOLUME_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_DOWN__DigitalInput__, VOLUME_DOWN );
    
    VOLUME_DONE = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_DONE__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_DONE__DigitalInput__, VOLUME_DONE );
    
    TUNER_KEY = new InOutArray<DigitalInput>( 13, this );
    for( uint i = 0; i < 13; i++ )
    {
        TUNER_KEY[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( TUNER_KEY__DigitalInput__ + i, TUNER_KEY__DigitalInput__, this );
        m_DigitalInputList.Add( TUNER_KEY__DigitalInput__ + i, TUNER_KEY[i+1] );
    }
    
    VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogInput( VOLUME_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUME_IN__AnalogSerialInput__, VOLUME_IN );
    
    SELECTED_TUNER = new Crestron.Logos.SplusObjects.AnalogInput( SELECTED_TUNER__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SELECTED_TUNER__AnalogSerialInput__, SELECTED_TUNER );
    
    VOLUME_FB = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_FB__AnalogSerialOutput__, VOLUME_FB );
    
    TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_FREQUENCY__DOLLAR__ );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    TUNER_COMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( TUNER_COMMAND__DOLLAR____AnalogSerialInput__, 6, this );
    m_StringInputList.Add( TUNER_COMMAND__DOLLAR____AnalogSerialInput__, TUNER_COMMAND__DOLLAR__ );
    
    VOLUME_COMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( VOLUME_COMMAND__DOLLAR____AnalogSerialInput__, 6, this );
    m_StringInputList.Add( VOLUME_COMMAND__DOLLAR____AnalogSerialInput__, VOLUME_COMMAND__DOLLAR__ );
    
    
    for( uint i = 0; i < 13; i++ )
        TUNER_KEY[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( TUNER_KEY_OnPush_0, false ) );
        
    VOLUME_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUME_UP_OnPush_1, false ) );
    VOLUME_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUME_DOWN_OnPush_2, false ) );
    VOLUME_DONE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( VOLUME_DONE_OnRelease_3, false ) );
    VOLUME_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( VOLUME_IN_OnChange_4, false ) );
    TUNER_COMMAND__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TUNER_COMMAND__DOLLAR___OnChange_5, false ) );
    VOLUME_COMMAND__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( VOLUME_COMMAND__DOLLAR___OnChange_6, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_INTEGRA_DTR_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint VOLUME_UP__DigitalInput__ = 0;
const uint VOLUME_DOWN__DigitalInput__ = 1;
const uint VOLUME_DONE__DigitalInput__ = 2;
const uint TUNER_KEY__DigitalInput__ = 3;
const uint VOLUME_IN__AnalogSerialInput__ = 0;
const uint SELECTED_TUNER__AnalogSerialInput__ = 1;
const uint TUNER_COMMAND__DOLLAR____AnalogSerialInput__ = 2;
const uint VOLUME_COMMAND__DOLLAR____AnalogSerialInput__ = 3;
const uint VOLUME_FB__AnalogSerialOutput__ = 0;
const uint TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 1;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 2;

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
