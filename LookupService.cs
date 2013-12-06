using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninjectTest
{
    public interface IStateService
    {
        IEnumerable<string> States();
        string ToString();
    }
    public class StateService : IStateService
    {
        public IEnumerable<string> States()
        {
            List<string> rtn = new List<string>();
            rtn.Add( "ID" );
            rtn.Add( "IL" );
            rtn.Add( "MT" );
            return rtn;
        }
        public override string ToString()
        {
            StringBuilder rtn = new StringBuilder();
            var states = this.States();
            foreach (var st in states)
            {
                rtn.Append( st );
                rtn.Append( "," );
            }
            //remove the last comma
            if (rtn.Length > 1)
                return rtn.Remove( rtn.Length - 1, 1 ).ToString();
            else
                return string.Empty;
        }
    }
}
