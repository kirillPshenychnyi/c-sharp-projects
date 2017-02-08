﻿
/***************************************************************************/

namespace LogicalModel.API
{
    public interface ILogicalElement
    {
        /***************************************************************************/

        int ID { get; }

        LogicValue.Enum evaluate();

        /***************************************************************************/
    }
}

/***************************************************************************/
