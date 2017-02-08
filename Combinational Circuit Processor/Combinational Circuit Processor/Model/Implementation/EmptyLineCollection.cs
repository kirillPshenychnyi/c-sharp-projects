﻿
/***************************************************************************/

using System;

/***************************************************************************/

namespace LogicalModel.Implementation
{
    /***************************************************************************/

    using API;

    /***************************************************************************/

    public class EmptyLineCollection : ILineCollection
    {
        /***************************************************************************/

        public int Size
        {
            get
            {
                return 0;
            }
        }

        /***************************************************************************/

        public ILine this[ int i ]
        {
            get
            {
                throw new MemberAccessException( 
                    Resoursers.Exceptions.Messages.gettingLineFromEmptyCollection
                );
            }

            set
            {
                throw new MemberAccessException(
                    Resoursers.Exceptions.Messages.addingLineToEmptyCollection
                );
            }
        }

        /***************************************************************************/

        public System.Collections.IEnumerator GetEnumerator()
        {
            throw new MemberAccessException(
                    Resoursers.Exceptions.Messages.gettingLineFromEmptyCollection
                );
        }

        /***************************************************************************/
    }
}

/***************************************************************************/
