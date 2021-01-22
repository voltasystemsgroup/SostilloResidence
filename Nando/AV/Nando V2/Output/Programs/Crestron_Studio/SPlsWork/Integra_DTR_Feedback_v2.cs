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

namespace CrestronModule_INTEGRA_DTR_FEEDBACK_V2
{
    public class CrestronModuleClass_INTEGRA_DTR_FEEDBACK_V2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> PASSWORD_KEY;
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput INPUT_SIRIUS_PASSWORD;
        Crestron.Logos.SplusObjects.DigitalOutput SIRIUS_PASSWORD_WRONG;
        Crestron.Logos.SplusObjects.AnalogOutput SLEEP_TIME;
        Crestron.Logos.SplusObjects.AnalogOutput MAIN_VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE_2_VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE_3_VOLUME_IN;
        Crestron.Logos.SplusObjects.StringOutput XM_CHANNEL_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_CHANNEL_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_ARTIST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_CATEGORY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_CHANNEL_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_CHANNEL_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_ARTIST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_CATEGORY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TUNER_ZONE_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TUNER_ZONE_3_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_PASSWORD__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_PASSWORD_STARS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_ARTIST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_CHANNEL_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_RADIO_DETAIL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_TUNER_STATUS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        ushort ITEMP = 0;
        ushort IPASSNEEDED = 0;
        ushort ISLEEP = 0;
        ushort IFLAG1 = 0;
        ushort A = 0;
        ushort IVOL = 0;
        ushort IVOL2 = 0;
        ushort IVOL3 = 0;
        ushort ITEMP1 = 0;
        CrestronString STEMP;
        CrestronString SXMCHNAME;
        CrestronString SXMCHNUM;
        CrestronString SXMTITLE;
        CrestronString SXMARTIST;
        CrestronString SXMCAT;
        CrestronString SSIRIUSCHNAME;
        CrestronString SSIRIUSCHNUM;
        CrestronString SSIRIUSTITLE;
        CrestronString SSIRIUSARTIST;
        CrestronString SSIRIUSCAT;
        CrestronString STEMP1;
        CrestronString STUNER;
        CrestronString STUNERZONE;
        CrestronString STUNER3;
        CrestronString SPASSWORD;
        CrestronString SPASSSTARS;
        CrestronString SHDTITLE;
        CrestronString SHDARTIST;
        CrestronString SHDCHNAME;
        CrestronString SHDDETAIL;
        object PASSWORD_KEY_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 95;
                ITEMP = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 96;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPASSNEEDED == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 98;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 11))  ) ) 
                        { 
                        __context__.SourceCodeLine = 100;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPASSWORD ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 102;
                            SPASSWORD  .UpdateValue ( Functions.Left ( SPASSWORD ,  (int) ( (Functions.Length( SPASSWORD ) - 1) ) )  ) ; 
                            __context__.SourceCodeLine = 103;
                            SPASSSTARS  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 104;
                            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( SPASSWORD ); 
                            int __FN_FORSTEP_VAL__1 = (int)1; 
                            for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
                                { 
                                __context__.SourceCodeLine = 106;
                                SPASSSTARS  .UpdateValue ( SPASSSTARS + "*"  ) ; 
                                __context__.SourceCodeLine = 104;
                                } 
                            
                            __context__.SourceCodeLine = 108;
                            SIRIUS_PASSWORD__DOLLAR__  .UpdateValue ( SPASSWORD  ) ; 
                            __context__.SourceCodeLine = 109;
                            SIRIUS_PASSWORD_STARS__DOLLAR__  .UpdateValue ( SPASSSTARS  ) ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 112;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 12))  ) ) 
                            { 
                            __context__.SourceCodeLine = 114;
                            SPASSWORD  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 115;
                            SPASSSTARS  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 116;
                            SIRIUS_PASSWORD__DOLLAR__  .UpdateValue ( SPASSWORD  ) ; 
                            __context__.SourceCodeLine = 117;
                            SIRIUS_PASSWORD_STARS__DOLLAR__  .UpdateValue ( SPASSSTARS  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 119;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 13))  ) ) 
                                { 
                                __context__.SourceCodeLine = 121;
                                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}\r", "!1SLK" , SPASSWORD .PadLeft( 2, '0' )) ; 
                                __context__.SourceCodeLine = 122;
                                SPASSWORD  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 123;
                                SIRIUS_PASSWORD__DOLLAR__  .UpdateValue ( SPASSWORD  ) ; 
                                __context__.SourceCodeLine = 124;
                                SIRIUS_PASSWORD_STARS__DOLLAR__  .UpdateValue ( SPASSWORD  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 126;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 10))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 128;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPASSWORD ) < 4 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 130;
                                        MakeString ( SPASSWORD , "{0}0", SPASSWORD ) ; 
                                        __context__.SourceCodeLine = 131;
                                        SPASSSTARS  .UpdateValue ( ""  ) ; 
                                        __context__.SourceCodeLine = 132;
                                        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                                        ushort __FN_FOREND_VAL__2 = (ushort)Functions.Length( SPASSWORD ); 
                                        int __FN_FORSTEP_VAL__2 = (int)1; 
                                        for ( A  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (A  >= __FN_FORSTART_VAL__2) && (A  <= __FN_FOREND_VAL__2) ) : ( (A  <= __FN_FORSTART_VAL__2) && (A  >= __FN_FOREND_VAL__2) ) ; A  += (ushort)__FN_FORSTEP_VAL__2) 
                                            { 
                                            __context__.SourceCodeLine = 134;
                                            SPASSSTARS  .UpdateValue ( SPASSSTARS + "*"  ) ; 
                                            __context__.SourceCodeLine = 132;
                                            } 
                                        
                                        __context__.SourceCodeLine = 136;
                                        SIRIUS_PASSWORD__DOLLAR__  .UpdateValue ( SPASSWORD  ) ; 
                                        __context__.SourceCodeLine = 137;
                                        SIRIUS_PASSWORD_STARS__DOLLAR__  .UpdateValue ( SPASSSTARS  ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 140;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ITEMP > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ITEMP < 10 ) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 142;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPASSWORD ) < 4 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 144;
                                            MakeString ( SPASSWORD , "{0}{1:d}", SPASSWORD , (short)ITEMP) ; 
                                            __context__.SourceCodeLine = 145;
                                            SPASSSTARS  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 146;
                                            ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
                                            ushort __FN_FOREND_VAL__3 = (ushort)Functions.Length( SPASSWORD ); 
                                            int __FN_FORSTEP_VAL__3 = (int)1; 
                                            for ( A  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (A  >= __FN_FORSTART_VAL__3) && (A  <= __FN_FOREND_VAL__3) ) : ( (A  <= __FN_FORSTART_VAL__3) && (A  >= __FN_FOREND_VAL__3) ) ; A  += (ushort)__FN_FORSTEP_VAL__3) 
                                                { 
                                                __context__.SourceCodeLine = 148;
                                                SPASSSTARS  .UpdateValue ( SPASSSTARS + "*"  ) ; 
                                                __context__.SourceCodeLine = 146;
                                                } 
                                            
                                            __context__.SourceCodeLine = 150;
                                            SIRIUS_PASSWORD__DOLLAR__  .UpdateValue ( SPASSWORD  ) ; 
                                            __context__.SourceCodeLine = 151;
                                            SIRIUS_PASSWORD_STARS__DOLLAR__  .UpdateValue ( SPASSSTARS  ) ; 
                                            } 
                                        
                                        } 
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    __context__.SourceCodeLine = 154;
                    ITEMP = (ushort) ( 100 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object FROM_DEVICE__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 160;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFLAG1 == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 162;
                IFLAG1 = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 163;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u001A" , FROM_DEVICE__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 165;
                    STEMP  .UpdateValue ( Functions.Gather ( "\u001A" , FROM_DEVICE__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 166;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SLP" , STEMP ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 168;
                        ITEMP1 = (ushort) ( Functions.Find( "!1SLP" , STEMP ) ) ; 
                        __context__.SourceCodeLine = 169;
                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1SLP" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                        __context__.SourceCodeLine = 170;
                        ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                        __context__.SourceCodeLine = 171;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != ISLEEP))  ) ) 
                            { 
                            __context__.SourceCodeLine = 173;
                            ISLEEP = (ushort) ( ITEMP ) ; 
                            __context__.SourceCodeLine = 174;
                            SLEEP_TIME  .Value = (ushort) ( ISLEEP ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 176;
                        STEMP1  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 177;
                        STEMP  .UpdateValue ( ""  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 179;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1MVL" , STEMP ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 181;
                            ITEMP1 = (ushort) ( Functions.Find( "!1MVL" , STEMP ) ) ; 
                            __context__.SourceCodeLine = 182;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1MVL" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                            __context__.SourceCodeLine = 183;
                            ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                            __context__.SourceCodeLine = 184;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL))  ) ) 
                                { 
                                __context__.SourceCodeLine = 186;
                                IVOL = (ushort) ( ITEMP ) ; 
                                __context__.SourceCodeLine = 187;
                                MAIN_VOLUME_IN  .Value = (ushort) ( IVOL ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 189;
                            STEMP1  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 190;
                            STEMP  .UpdateValue ( ""  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 192;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1ZVL" , STEMP ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 194;
                                ITEMP1 = (ushort) ( Functions.Find( "!1ZVL" , STEMP ) ) ; 
                                __context__.SourceCodeLine = 195;
                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1ZVL" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                                __context__.SourceCodeLine = 196;
                                ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                                __context__.SourceCodeLine = 197;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL2))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 199;
                                    IVOL2 = (ushort) ( ITEMP ) ; 
                                    __context__.SourceCodeLine = 200;
                                    ZONE_2_VOLUME_IN  .Value = (ushort) ( IVOL2 ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 202;
                                STEMP1  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 203;
                                STEMP  .UpdateValue ( ""  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 205;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1VL3" , STEMP ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 207;
                                    ITEMP1 = (ushort) ( Functions.Find( "!1VL3" , STEMP ) ) ; 
                                    __context__.SourceCodeLine = 208;
                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1VL3" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                                    __context__.SourceCodeLine = 209;
                                    ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                                    __context__.SourceCodeLine = 210;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL3))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 212;
                                        IVOL3 = (ushort) ( ITEMP ) ; 
                                        __context__.SourceCodeLine = 213;
                                        ZONE_3_VOLUME_IN  .Value = (ushort) ( IVOL3 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 215;
                                    STEMP1  .UpdateValue ( ""  ) ; 
                                    __context__.SourceCodeLine = 216;
                                    STEMP  .UpdateValue ( ""  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 218;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1XCN" , STEMP ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 220;
                                        ITEMP1 = (ushort) ( Functions.Find( "!1XCN" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 221;
                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1XCN" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1XCN" )) - ITEMP1) ) )  ) ; 
                                        __context__.SourceCodeLine = 222;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SXMCHNAME != STEMP1))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 224;
                                            SXMCHNAME  .UpdateValue ( STEMP1  ) ; 
                                            __context__.SourceCodeLine = 225;
                                            XM_CHANNEL_NAME__DOLLAR__  .UpdateValue ( SXMCHNAME  ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 227;
                                        STEMP1  .UpdateValue ( ""  ) ; 
                                        __context__.SourceCodeLine = 228;
                                        STEMP  .UpdateValue ( ""  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 230;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1XCH" , STEMP ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 232;
                                            ITEMP1 = (ushort) ( Functions.Find( "!1XCH" , STEMP ) ) ; 
                                            __context__.SourceCodeLine = 233;
                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1XCH" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1XCH" )) - ITEMP1) ) )  ) ; 
                                            __context__.SourceCodeLine = 234;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SXMCHNUM != STEMP1))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 236;
                                                SXMCHNUM  .UpdateValue ( STEMP1  ) ; 
                                                __context__.SourceCodeLine = 237;
                                                XM_CHANNEL_NUMBER__DOLLAR__  .UpdateValue ( SXMCHNUM  ) ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 239;
                                            STEMP1  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 240;
                                            STEMP  .UpdateValue ( ""  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 242;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1XTI" , STEMP ) > 0 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 244;
                                                ITEMP1 = (ushort) ( Functions.Find( "!1XTI" , STEMP ) ) ; 
                                                __context__.SourceCodeLine = 245;
                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1XTI" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1XTI" )) - ITEMP1) ) )  ) ; 
                                                __context__.SourceCodeLine = 246;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SXMTITLE != STEMP1))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 248;
                                                    SXMTITLE  .UpdateValue ( STEMP1  ) ; 
                                                    __context__.SourceCodeLine = 249;
                                                    XM_TITLE__DOLLAR__  .UpdateValue ( SXMTITLE  ) ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 251;
                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 252;
                                                STEMP  .UpdateValue ( ""  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 254;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1XAT" , STEMP ) > 0 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 256;
                                                    ITEMP1 = (ushort) ( Functions.Find( "!1XAT" , STEMP ) ) ; 
                                                    __context__.SourceCodeLine = 257;
                                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1XAT" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1XAT" )) - ITEMP1) ) )  ) ; 
                                                    __context__.SourceCodeLine = 258;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SXMARTIST != STEMP1))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 260;
                                                        SXMARTIST  .UpdateValue ( STEMP1  ) ; 
                                                        __context__.SourceCodeLine = 261;
                                                        XM_ARTIST__DOLLAR__  .UpdateValue ( SXMARTIST  ) ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 263;
                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                    __context__.SourceCodeLine = 264;
                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 266;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1XCT" , STEMP ) > 0 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 268;
                                                        ITEMP1 = (ushort) ( Functions.Find( "!1XCT" , STEMP ) ) ; 
                                                        __context__.SourceCodeLine = 269;
                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1XCT" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1XCT" )) - ITEMP1) ) )  ) ; 
                                                        __context__.SourceCodeLine = 270;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SXMCAT != STEMP1))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 272;
                                                            SXMCAT  .UpdateValue ( STEMP1  ) ; 
                                                            __context__.SourceCodeLine = 273;
                                                            XM_CATEGORY__DOLLAR__  .UpdateValue ( SXMCAT  ) ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 275;
                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                        __context__.SourceCodeLine = 276;
                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 278;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SCN" , STEMP ) > 0 ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 280;
                                                            ITEMP1 = (ushort) ( Functions.Find( "!1SCN" , STEMP ) ) ; 
                                                            __context__.SourceCodeLine = 281;
                                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1SCN" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1SCN" )) - ITEMP1) ) )  ) ; 
                                                            __context__.SourceCodeLine = 282;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSIRIUSCHNAME != STEMP1))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 284;
                                                                SSIRIUSCHNAME  .UpdateValue ( STEMP1  ) ; 
                                                                __context__.SourceCodeLine = 285;
                                                                SIRIUS_CHANNEL_NAME__DOLLAR__  .UpdateValue ( SSIRIUSCHNAME  ) ; 
                                                                } 
                                                            
                                                            __context__.SourceCodeLine = 287;
                                                            STEMP1  .UpdateValue ( ""  ) ; 
                                                            __context__.SourceCodeLine = 288;
                                                            STEMP  .UpdateValue ( ""  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 290;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SCH" , STEMP ) > 0 ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 292;
                                                                ITEMP1 = (ushort) ( Functions.Find( "!1SCH" , STEMP ) ) ; 
                                                                __context__.SourceCodeLine = 293;
                                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1SCH" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1SCH" )) - ITEMP1) ) )  ) ; 
                                                                __context__.SourceCodeLine = 294;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSIRIUSCHNUM != STEMP1))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 296;
                                                                    SSIRIUSCHNUM  .UpdateValue ( STEMP1  ) ; 
                                                                    __context__.SourceCodeLine = 297;
                                                                    SIRIUS_CHANNEL_NUMBER__DOLLAR__  .UpdateValue ( SSIRIUSCHNUM  ) ; 
                                                                    } 
                                                                
                                                                __context__.SourceCodeLine = 299;
                                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                                __context__.SourceCodeLine = 300;
                                                                STEMP  .UpdateValue ( ""  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 302;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1STI" , STEMP ) > 0 ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 304;
                                                                    ITEMP1 = (ushort) ( Functions.Find( "!1STI" , STEMP ) ) ; 
                                                                    __context__.SourceCodeLine = 305;
                                                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1STI" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1STI" )) - ITEMP1) ) )  ) ; 
                                                                    __context__.SourceCodeLine = 306;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSIRIUSTITLE != STEMP1))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 308;
                                                                        SSIRIUSTITLE  .UpdateValue ( STEMP1  ) ; 
                                                                        __context__.SourceCodeLine = 309;
                                                                        SIRIUS_TITLE__DOLLAR__  .UpdateValue ( SSIRIUSTITLE  ) ; 
                                                                        } 
                                                                    
                                                                    __context__.SourceCodeLine = 311;
                                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                                    __context__.SourceCodeLine = 312;
                                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 314;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SAT" , STEMP ) > 0 ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 316;
                                                                        ITEMP1 = (ushort) ( Functions.Find( "!1SAT" , STEMP ) ) ; 
                                                                        __context__.SourceCodeLine = 317;
                                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1SAT" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1SAT" )) - ITEMP1) ) )  ) ; 
                                                                        __context__.SourceCodeLine = 318;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSIRIUSARTIST != STEMP1))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 320;
                                                                            SSIRIUSARTIST  .UpdateValue ( STEMP1  ) ; 
                                                                            __context__.SourceCodeLine = 321;
                                                                            SIRIUS_ARTIST__DOLLAR__  .UpdateValue ( SSIRIUSARTIST  ) ; 
                                                                            } 
                                                                        
                                                                        __context__.SourceCodeLine = 323;
                                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                                        __context__.SourceCodeLine = 324;
                                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 326;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SCT" , STEMP ) > 0 ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 328;
                                                                            ITEMP1 = (ushort) ( Functions.Find( "!1SCT" , STEMP ) ) ; 
                                                                            __context__.SourceCodeLine = 329;
                                                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1SCT" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1SCT" )) - ITEMP1) ) )  ) ; 
                                                                            __context__.SourceCodeLine = 330;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSIRIUSCAT != STEMP1))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 332;
                                                                                SSIRIUSCAT  .UpdateValue ( STEMP1  ) ; 
                                                                                __context__.SourceCodeLine = 333;
                                                                                SIRIUS_CATEGORY__DOLLAR__  .UpdateValue ( SSIRIUSCAT  ) ; 
                                                                                } 
                                                                            
                                                                            __context__.SourceCodeLine = 335;
                                                                            STEMP1  .UpdateValue ( ""  ) ; 
                                                                            __context__.SourceCodeLine = 336;
                                                                            STEMP  .UpdateValue ( ""  ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 338;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SLKINPUT" , STEMP ) > 0 ))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 340;
                                                                                IPASSNEEDED = (ushort) ( 1 ) ; 
                                                                                __context__.SourceCodeLine = 341;
                                                                                INPUT_SIRIUS_PASSWORD  .Value = (ushort) ( IPASSNEEDED ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 344;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SLKWRONG" , STEMP ) > 0 ))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 346;
                                                                                    IPASSNEEDED = (ushort) ( 0 ) ; 
                                                                                    __context__.SourceCodeLine = 347;
                                                                                    INPUT_SIRIUS_PASSWORD  .Value = (ushort) ( IPASSNEEDED ) ; 
                                                                                    __context__.SourceCodeLine = 348;
                                                                                    Functions.Pulse ( 10, SIRIUS_PASSWORD_WRONG ) ; 
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 350;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TUN" , STEMP ) > 0 ))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 352;
                                                                                        ITEMP1 = (ushort) ( Functions.Find( "!1TUN" , STEMP ) ) ; 
                                                                                        __context__.SourceCodeLine = 353;
                                                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TUN" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TUN" )) - ITEMP1) ) )  ) ; 
                                                                                        __context__.SourceCodeLine = 354;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNER != STEMP1))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 356;
                                                                                            STUNER  .UpdateValue ( STEMP1  ) ; 
                                                                                            __context__.SourceCodeLine = 357;
                                                                                            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( STUNER  ) ; 
                                                                                            } 
                                                                                        
                                                                                        __context__.SourceCodeLine = 359;
                                                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                                                        __context__.SourceCodeLine = 360;
                                                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 362;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TUZ" , STEMP ) > 0 ))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 364;
                                                                                            ITEMP1 = (ushort) ( Functions.Find( "!1TUZ" , STEMP ) ) ; 
                                                                                            __context__.SourceCodeLine = 365;
                                                                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TUZ" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TUZ" )) - ITEMP1) ) )  ) ; 
                                                                                            __context__.SourceCodeLine = 366;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNERZONE != STEMP1))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 368;
                                                                                                STUNERZONE  .UpdateValue ( STEMP1  ) ; 
                                                                                                __context__.SourceCodeLine = 369;
                                                                                                TUNER_ZONE_FREQUENCY__DOLLAR__  .UpdateValue ( STUNERZONE  ) ; 
                                                                                                } 
                                                                                            
                                                                                            __context__.SourceCodeLine = 371;
                                                                                            STEMP1  .UpdateValue ( ""  ) ; 
                                                                                            __context__.SourceCodeLine = 372;
                                                                                            STEMP  .UpdateValue ( ""  ) ; 
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 374;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TU3" , STEMP ) > 0 ))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 376;
                                                                                                ITEMP1 = (ushort) ( Functions.Find( "!1TU3" , STEMP ) ) ; 
                                                                                                __context__.SourceCodeLine = 377;
                                                                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TU3" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TU3" )) - ITEMP1) ) )  ) ; 
                                                                                                __context__.SourceCodeLine = 378;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNER3 != STEMP1))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 380;
                                                                                                    STUNER3  .UpdateValue ( STEMP1  ) ; 
                                                                                                    __context__.SourceCodeLine = 381;
                                                                                                    TUNER_ZONE_3_FREQUENCY__DOLLAR__  .UpdateValue ( STUNER3  ) ; 
                                                                                                    } 
                                                                                                
                                                                                                __context__.SourceCodeLine = 383;
                                                                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                __context__.SourceCodeLine = 384;
                                                                                                STEMP  .UpdateValue ( ""  ) ; 
                                                                                                } 
                                                                                            
                                                                                            else 
                                                                                                {
                                                                                                __context__.SourceCodeLine = 386;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1HTI" , STEMP ) > 0 ))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 388;
                                                                                                    ITEMP1 = (ushort) ( Functions.Find( "!1HTI" , STEMP ) ) ; 
                                                                                                    __context__.SourceCodeLine = 389;
                                                                                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1HTI" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1HTI" )) - ITEMP1) ) )  ) ; 
                                                                                                    __context__.SourceCodeLine = 390;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SHDTITLE != STEMP1))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 392;
                                                                                                        SHDTITLE  .UpdateValue ( STEMP1  ) ; 
                                                                                                        __context__.SourceCodeLine = 393;
                                                                                                        HD_TITLE__DOLLAR__  .UpdateValue ( SHDTITLE  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    __context__.SourceCodeLine = 395;
                                                                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                    __context__.SourceCodeLine = 396;
                                                                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                                                                    } 
                                                                                                
                                                                                                else 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 398;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1HAT" , STEMP ) > 0 ))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 400;
                                                                                                        ITEMP1 = (ushort) ( Functions.Find( "!1HAT" , STEMP ) ) ; 
                                                                                                        __context__.SourceCodeLine = 401;
                                                                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1HAT" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1HAT" )) - ITEMP1) ) )  ) ; 
                                                                                                        __context__.SourceCodeLine = 402;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SHDARTIST != STEMP1))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 404;
                                                                                                            SHDARTIST  .UpdateValue ( STEMP1  ) ; 
                                                                                                            __context__.SourceCodeLine = 405;
                                                                                                            HD_ARTIST__DOLLAR__  .UpdateValue ( SHDARTIST  ) ; 
                                                                                                            } 
                                                                                                        
                                                                                                        __context__.SourceCodeLine = 407;
                                                                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                        __context__.SourceCodeLine = 408;
                                                                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        {
                                                                                                        __context__.SourceCodeLine = 410;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1HCN" , STEMP ) > 0 ))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 412;
                                                                                                            ITEMP1 = (ushort) ( Functions.Find( "!1HCN" , STEMP ) ) ; 
                                                                                                            __context__.SourceCodeLine = 413;
                                                                                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1HCN" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1HCN" )) - ITEMP1) ) )  ) ; 
                                                                                                            __context__.SourceCodeLine = 414;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SHDCHNAME != STEMP1))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 416;
                                                                                                                SHDCHNAME  .UpdateValue ( STEMP1  ) ; 
                                                                                                                __context__.SourceCodeLine = 417;
                                                                                                                HD_CHANNEL_NAME__DOLLAR__  .UpdateValue ( SHDCHNAME  ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            __context__.SourceCodeLine = 419;
                                                                                                            STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                            __context__.SourceCodeLine = 420;
                                                                                                            STEMP  .UpdateValue ( ""  ) ; 
                                                                                                            } 
                                                                                                        
                                                                                                        else 
                                                                                                            {
                                                                                                            __context__.SourceCodeLine = 422;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1HDS" , STEMP ) > 0 ))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 424;
                                                                                                                ITEMP1 = (ushort) ( Functions.Find( "!1HDS" , STEMP ) ) ; 
                                                                                                                __context__.SourceCodeLine = 425;
                                                                                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1HDS" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1HDS" )) - ITEMP1) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 426;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SHDDETAIL != STEMP1))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 428;
                                                                                                                    SHDDETAIL  .UpdateValue ( STEMP1  ) ; 
                                                                                                                    __context__.SourceCodeLine = 429;
                                                                                                                    HD_RADIO_DETAIL__DOLLAR__  .UpdateValue ( SHDDETAIL  ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                __context__.SourceCodeLine = 431;
                                                                                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                                __context__.SourceCodeLine = 432;
                                                                                                                STEMP  .UpdateValue ( ""  ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            else 
                                                                                                                {
                                                                                                                __context__.SourceCodeLine = 434;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1HTS" , STEMP ) > 0 ))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 436;
                                                                                                                    ITEMP1 = (ushort) ( Functions.Find( "!1HTS" , STEMP ) ) ; 
                                                                                                                    __context__.SourceCodeLine = 437;
                                                                                                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1HTS" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1HTS" )) - ITEMP1) ) )  ) ; 
                                                                                                                    __context__.SourceCodeLine = 441;
                                                                                                                    HD_TUNER_STATUS__DOLLAR__  .UpdateValue ( STEMP1  ) ; 
                                                                                                                    __context__.SourceCodeLine = 443;
                                                                                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                                    __context__.SourceCodeLine = 444;
                                                                                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                }
                                                                                                            
                                                                                                            }
                                                                                                        
                                                                                                        }
                                                                                                    
                                                                                                    }
                                                                                                
                                                                                                }
                                                                                            
                                                                                            }
                                                                                        
                                                                                        }
                                                                                    
                                                                                    }
                                                                                
                                                                                }
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    __context__.SourceCodeLine = 163;
                    } 
                
                __context__.SourceCodeLine = 447;
                IFLAG1 = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 457;
        IFLAG1 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 458;
        STEMP  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 459;
        STEMP1  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 460;
        ITEMP = (ushort) ( 100 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SXMCHNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SXMCHNUM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    SXMTITLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SXMARTIST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SXMCAT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SSIRIUSCHNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SSIRIUSCHNUM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SSIRIUSTITLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SSIRIUSARTIST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SSIRIUSCAT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    STEMP1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    STUNER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    STUNERZONE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    STUNER3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    SPASSWORD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    SPASSSTARS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    SHDTITLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SHDARTIST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SHDCHNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SHDDETAIL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    PASSWORD_KEY = new InOutArray<DigitalInput>( 13, this );
    for( uint i = 0; i < 13; i++ )
    {
        PASSWORD_KEY[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( PASSWORD_KEY__DigitalInput__ + i, PASSWORD_KEY__DigitalInput__, this );
        m_DigitalInputList.Add( PASSWORD_KEY__DigitalInput__ + i, PASSWORD_KEY[i+1] );
    }
    
    INPUT_SIRIUS_PASSWORD = new Crestron.Logos.SplusObjects.DigitalOutput( INPUT_SIRIUS_PASSWORD__DigitalOutput__, this );
    m_DigitalOutputList.Add( INPUT_SIRIUS_PASSWORD__DigitalOutput__, INPUT_SIRIUS_PASSWORD );
    
    SIRIUS_PASSWORD_WRONG = new Crestron.Logos.SplusObjects.DigitalOutput( SIRIUS_PASSWORD_WRONG__DigitalOutput__, this );
    m_DigitalOutputList.Add( SIRIUS_PASSWORD_WRONG__DigitalOutput__, SIRIUS_PASSWORD_WRONG );
    
    SLEEP_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( SLEEP_TIME__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SLEEP_TIME__AnalogSerialOutput__, SLEEP_TIME );
    
    MAIN_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( MAIN_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MAIN_VOLUME_IN__AnalogSerialOutput__, MAIN_VOLUME_IN );
    
    ZONE_2_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE_2_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE_2_VOLUME_IN__AnalogSerialOutput__, ZONE_2_VOLUME_IN );
    
    ZONE_3_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE_3_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE_3_VOLUME_IN__AnalogSerialOutput__, ZONE_3_VOLUME_IN );
    
    XM_CHANNEL_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, XM_CHANNEL_NAME__DOLLAR__ );
    
    XM_CHANNEL_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_CHANNEL_NUMBER__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_CHANNEL_NUMBER__DOLLAR____AnalogSerialOutput__, XM_CHANNEL_NUMBER__DOLLAR__ );
    
    XM_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_TITLE__DOLLAR____AnalogSerialOutput__, XM_TITLE__DOLLAR__ );
    
    XM_ARTIST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_ARTIST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_ARTIST__DOLLAR____AnalogSerialOutput__, XM_ARTIST__DOLLAR__ );
    
    XM_CATEGORY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_CATEGORY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_CATEGORY__DOLLAR____AnalogSerialOutput__, XM_CATEGORY__DOLLAR__ );
    
    SIRIUS_CHANNEL_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, SIRIUS_CHANNEL_NAME__DOLLAR__ );
    
    SIRIUS_CHANNEL_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_CHANNEL_NUMBER__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_CHANNEL_NUMBER__DOLLAR____AnalogSerialOutput__, SIRIUS_CHANNEL_NUMBER__DOLLAR__ );
    
    SIRIUS_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_TITLE__DOLLAR____AnalogSerialOutput__, SIRIUS_TITLE__DOLLAR__ );
    
    SIRIUS_ARTIST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_ARTIST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_ARTIST__DOLLAR____AnalogSerialOutput__, SIRIUS_ARTIST__DOLLAR__ );
    
    SIRIUS_CATEGORY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_CATEGORY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_CATEGORY__DOLLAR____AnalogSerialOutput__, SIRIUS_CATEGORY__DOLLAR__ );
    
    TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_FREQUENCY__DOLLAR__ );
    
    TUNER_ZONE_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_ZONE_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_ZONE_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_ZONE_FREQUENCY__DOLLAR__ );
    
    TUNER_ZONE_3_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_ZONE_3_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_ZONE_3_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_ZONE_3_FREQUENCY__DOLLAR__ );
    
    SIRIUS_PASSWORD__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_PASSWORD__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_PASSWORD__DOLLAR____AnalogSerialOutput__, SIRIUS_PASSWORD__DOLLAR__ );
    
    SIRIUS_PASSWORD_STARS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_PASSWORD_STARS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_PASSWORD_STARS__DOLLAR____AnalogSerialOutput__, SIRIUS_PASSWORD_STARS__DOLLAR__ );
    
    HD_ARTIST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_ARTIST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_ARTIST__DOLLAR____AnalogSerialOutput__, HD_ARTIST__DOLLAR__ );
    
    HD_CHANNEL_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, HD_CHANNEL_NAME__DOLLAR__ );
    
    HD_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_TITLE__DOLLAR____AnalogSerialOutput__, HD_TITLE__DOLLAR__ );
    
    HD_RADIO_DETAIL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_RADIO_DETAIL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_RADIO_DETAIL__DOLLAR____AnalogSerialOutput__, HD_RADIO_DETAIL__DOLLAR__ );
    
    HD_TUNER_STATUS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_TUNER_STATUS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_TUNER_STATUS__DOLLAR____AnalogSerialOutput__, HD_TUNER_STATUS__DOLLAR__ );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    FROM_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__DOLLAR____AnalogSerialInput__, 200, this );
    m_StringInputList.Add( FROM_DEVICE__DOLLAR____AnalogSerialInput__, FROM_DEVICE__DOLLAR__ );
    
    
    for( uint i = 0; i < 13; i++ )
        PASSWORD_KEY[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( PASSWORD_KEY_OnPush_0, false ) );
        
    FROM_DEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE__DOLLAR___OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_INTEGRA_DTR_FEEDBACK_V2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint PASSWORD_KEY__DigitalInput__ = 0;
const uint FROM_DEVICE__DOLLAR____AnalogSerialInput__ = 0;
const uint INPUT_SIRIUS_PASSWORD__DigitalOutput__ = 0;
const uint SIRIUS_PASSWORD_WRONG__DigitalOutput__ = 1;
const uint SLEEP_TIME__AnalogSerialOutput__ = 0;
const uint MAIN_VOLUME_IN__AnalogSerialOutput__ = 1;
const uint ZONE_2_VOLUME_IN__AnalogSerialOutput__ = 2;
const uint ZONE_3_VOLUME_IN__AnalogSerialOutput__ = 3;
const uint XM_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__ = 4;
const uint XM_CHANNEL_NUMBER__DOLLAR____AnalogSerialOutput__ = 5;
const uint XM_TITLE__DOLLAR____AnalogSerialOutput__ = 6;
const uint XM_ARTIST__DOLLAR____AnalogSerialOutput__ = 7;
const uint XM_CATEGORY__DOLLAR____AnalogSerialOutput__ = 8;
const uint SIRIUS_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__ = 9;
const uint SIRIUS_CHANNEL_NUMBER__DOLLAR____AnalogSerialOutput__ = 10;
const uint SIRIUS_TITLE__DOLLAR____AnalogSerialOutput__ = 11;
const uint SIRIUS_ARTIST__DOLLAR____AnalogSerialOutput__ = 12;
const uint SIRIUS_CATEGORY__DOLLAR____AnalogSerialOutput__ = 13;
const uint TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 14;
const uint TUNER_ZONE_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 15;
const uint TUNER_ZONE_3_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 16;
const uint SIRIUS_PASSWORD__DOLLAR____AnalogSerialOutput__ = 17;
const uint SIRIUS_PASSWORD_STARS__DOLLAR____AnalogSerialOutput__ = 18;
const uint HD_ARTIST__DOLLAR____AnalogSerialOutput__ = 19;
const uint HD_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__ = 20;
const uint HD_TITLE__DOLLAR____AnalogSerialOutput__ = 21;
const uint HD_RADIO_DETAIL__DOLLAR____AnalogSerialOutput__ = 22;
const uint HD_TUNER_STATUS__DOLLAR____AnalogSerialOutput__ = 23;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 24;

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
