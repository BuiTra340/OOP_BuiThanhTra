using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1.Base
{
    public interface IEntity
    {
        /*
         * Get id object
         */
        int GetId();

        /*
         * Set id object
         */
        void SetId(int id);

        /*
         * Get name object
         */
        string GetName();

        /*
         * Set name object
         */
        void SetName(string name);

        /*
         * Show data object
         */
        void PrintData();
    }
}
