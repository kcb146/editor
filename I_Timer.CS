/* Model Controller / I_Timer

   Created : 2011-04-13
   Last Modified : 2011-04-13
   Author : Tom Coleman
   Copyright : 2011-2011
   By : University of Mississippi Medical Center */

using System ;
using System.Collections ;
using System.Drawing ;
using System.Windows.Forms ;

namespace ModelEditor
{ public class I_Timer
  { public static void Install ()
    { Insert_Data Insert ;
      String nl = Environment.NewLine ; 

      Insert = new Insert_Data () ;

      Insert.Name = "Timer" ;
      Insert.Label = "<timer>...</timer>" ;

      Insert.Content += "        <timer>" + nl ;
      Insert.Content += "          <name>  </name>" + nl ;
      Insert.Content += "          <val>  </val>" + nl ;
      Insert.Content += "          <state>  </state>" + nl ;
      Insert.Content += "        </timer>" + nl ;

      Insert.WideContent += "        <timer>" + nl ;
      Insert.WideContent += "          <name>  </name><val>  </val><state>  </state>" + nl ;
      Insert.WideContent += "        </timer>" + nl ;

      Insert_Manager.Add (Insert) ;
    } 
  }
}

/* End */
