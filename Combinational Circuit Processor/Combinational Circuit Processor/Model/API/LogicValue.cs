﻿
/***************************************************************************/

using System;

/***************************************************************************/

namespace LogicalModel.API
{
    public class LogicValue
    {
        /***************************************************************************/

        public enum Enum
        {
            Low
          , High
          , Unknown       
        }

        /***************************************************************************/

        public static int asNumber( Enum _enum )
        {
            switch (_enum)
            {
                case Enum.Low:
                    return 0;
                case Enum.High:
                    return 1;
                case Enum.Unknown:
                    return -1;
                default:
                    throw new ArgumentException( Resoursers.Exceptions.Messages.unknownLogicalValue );
            }
        }

        /***************************************************************************/

        public static Enum invert( Enum _enum )
        {
            switch ( _enum )
            {
                case Enum.High:
                    return Enum.Low;

                case Enum.Low:
                    return Enum.High;

                case Enum.Unknown:
                    return Enum.Unknown;

                default:
                    return Enum.Unknown;
            }
        }
    }
}

/***************************************************************************/

